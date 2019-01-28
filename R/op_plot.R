#' Optimos Prime calculates optima and tolerance for a matrix of species and environmental factors
#'
#' This function (op_plot) generates caterpillar plots for a specified environmental variable showing optima and tolerance ranges as calculated with the op_calculate() function
#' @param optimaDF The dataframe resulting from the op_calculate() method.
#' @param label (optional) The label for the X axis (usually the environmental variable's name)
#' @description
#' This function plots the specified variable in a caterpillar plot
#' @import ggplot2 tidyverse plotly
#' @keywords ecology, optimum, tolerance, species density
#' @export op_plot
#'


########-------- FUNCTION OP_PLOT CREATES A CATERPILLAR PLOT FOR A SELECTED VARIABLE SHOWING OPTIMA AND TOLERANCE RANGE BY INCREASING OPTIMA  --------------#########
op_plot <- function(optimaDF, label){
  # Needs tidyverse, ggPlot2, plotly libraries
  optimum = NULL
  mymean = NULL
  species = NULL
  x = NULL

  #Checks in there's a dataframe or aborts function
  if(missing(optimaDF) ) {
    print("A dataframe with optima and tolerance ranges is needed, as the one obtained from the op_calculate() function.")
    stop("No dataframe specified")
  }
  #Deletes empty rows so it doesn't get stuck in endless loop trying to graph
  optimaDF <- optimaDF[complete.cases(optimaDF), ]

  #Offers options for variables
  col_indexes <- seq(2,ncol(optimaDF), 3)
  col_names <- colnames(optimaDF[col_indexes])
  colTable <- data.frame(variables=col_names)
  colnames(colTable) <- c()
  print(colTable)
  variablenum <- readline(prompt= "[Question] What variable number do you want to plot?")
  variablenum <- as.numeric(unlist(strsplit(variablenum, ",")))
  variable <- col_names[variablenum]

  #Checks in there's a label, or uses the variable name
  if(missing(label) ) {
    label <- variable
  }

  print("Plotting...")
  #EXTRACTS COLUMNS
  variablemas <- paste(variable, "-HIGH")
  variablemenos <- paste(variable, "-LOW")

  data1mean <- optimaDF[[variable]]
  data1mas <- optimaDF[[variablemas]]
  data1menos <- optimaDF[[variablemenos]]

  data1 <- as.data.frame(optimaDF$Species)
  data1$optimum <- data1mean
  data1$max <- data1mas
  data1$min <- data1menos
  colnames(data1) <- c("species", "optimum", "max", "min")

  # Reorder data using average
  data1 = data1 %>% mutate( mymean = optimum) %>% arrange(mymean) %>% mutate(x=factor(species, species))

  # PLOT
plotBasic <- ggplot(data1) +
    geom_segment( aes(x=x, xend=x, y=max, yend=min), color="grey") +
    geom_point( aes(x=x, y=optimum), color=rgb(0.2,0.7,0.1,0.5), size=3 ) +
    geom_point( aes(x=x, y=max), color=rgb(0.7,0.2,0.1,0.5), size=1 ) +
    geom_point( aes(x=x, y=min), color=rgb(0.7,0.2,0.1,0.5), size=1 ) +
    coord_flip()+
    theme_light() +
    theme(
      legend.position = "none",
      panel.border = element_blank(),
      panel.grid.major = element_blank(),
      panel.grid.minor = element_blank(),
      panel.background = element_blank(),
      axis.line = element_line(color = "gray")
    ) +
    xlab("") +
    ylab(label)
print("Plot complete!")
#Enhance with plotly
ggplotly(plotBasic)

}
