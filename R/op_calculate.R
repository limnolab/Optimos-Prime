#' This function of Optimos Prime calculates optima and tolerance for a matrix of species and environmental factors
#' @param enviromental_df The dataframe with your environmental data. Variables as rows, Sites as columns
#' @param species_df The dataframe with your species densities. Species as rows, Sites as columns.
#' @param islog10 Boolean. If set to 'TRUE' it means that your environmental data is already transformed to log10. Default = False
#' @description
#' You will need two dataframes. If they are not specified as arguments, you will be prompted to import them from CSV format.
#' The resulting dataframe from the op_calculate() function will be a dataframe of species (rows) and the optima and tolerance range (+ and -) of the environmental variables (columns)
#' \itemize{
#' \item Matrix 1: Species (rows) by Sampling sites (columns).
#'     First row needs to be the sampling sites names.
#'     First column needs to be the species' names.
#'     Values in cells therefore need to be the density of each species at each site.
#' \item Matrix 2: Environmental variables (rows) by Sampling sites (columns).
#'     First row needs to be the sampling sites names.
#'     First column needs to be the names of the environmental variables (i.e. physical-chemical parameters).
#'     Values in cells therefore need to be the value of each environmental variable at each site.
#' }
#' The calculations for optima and tolerance ranges is conducted according to the article by Potapova & Charles (2003):
#' \itemize{
#' \item Potapova, M., & Charles, D. F. (2003). Distribution of benthic diatoms in US rivers in relation to conductivity and ionic composition. Freshwater Biology, 48(8), 1311-1328.
#' }
#' @keywords ecology, optimum, tolerance, species density
#' @export


########-------- FUNCTION OP_CALCULATE CALCULATES OPTIMA AND TOLERANCE RANGES  --------------#########
op_calculate <- function(enviromental_df, species_df, islog10=FALSE){
    # First checks in environmental and species dataframes exist. If not, loads them from CSV files
    if(missing(enviromental_df) | missing(species_df) ) {
      print("Select CSV matrices")
    ########-------- LOADS THE SPECIES AND ENVIRONMENTAL DATA FROM CSV FILES IF NOT IN DATAMATRIX
    Filters <- matrix(c("Comma Separated Values (CSV)", "*.csv"),
                      1, 2, byrow = TRUE)
    print("Select ENVIRONMENTAL matrix")
    enviromental_df <- read.csv(choose.files(caption="Select environmental matrix", filters = Filters),sep=",")
    print("Select SPECIES matrix")
    species_df <- read.csv(choose.files(caption="Select species density matrix", filters = Filters),sep=",")
  }

  df_densidades <- species_df
  df_ambientales <- enviromental_df


  #Checks that both matrices exist, or exits
  if(missing(enviromental_df) | missing(species_df) ) {
    stop("The correct matrices were not selected, the script will cancel.")
  }

  print("Calculating...")

  list_sites <- t(colnames(df_densidades[2:ncol(df_densidades)]))
  list_especies <- as.vector(df_densidades[,1])
  list_ambientales <- as.vector(df_ambientales[,1])

  #builds a matrix of SPECIES vs ENVIRONMENTAL VARIABLES called finalDF (will be used to load the results)
  finalDF <- data.frame(matrix(nrow=nrow(df_densidades), ncol=nrow(df_ambientales)*3 + 1),stringsAsFactors=FALSE)

  #######---------  IF islog10 parameter is false, converts the environmental data to LOG10
  if (islog10 == FALSE){
    df_ambientales <- log(df_ambientales[2:ncol(df_ambientales)], 10)
  }

  #########-------- STARTS OPTIMA CALCULATION
  for (species_i in 1:nrow(df_densidades)){
    testsp1 <- df_densidades[species_i, 2:ncol(df_densidades)]
    # converts the dataframes to matrices for calculation
    testsp1 <- data.matrix(testsp1)
    testamb <- data.matrix(df_ambientales)
    # multiplies both matrices
    testsp1_amb <- sweep(testamb[,1:ncol(testamb)], MARGIN=2, testsp1, '*')

    # converts matrices back to dataframes for row sums
    testsp1_amb <- as.data.frame(testsp1_amb)
    testsp1_amb$sumaAB <- rowSums(testsp1_amb, na.rm=TRUE)

    # Adds species densities in all samples only if there is a valid environmental parameter for each sample into a new column (sumaDens_SiFQ)
    for (valrow in 1:nrow(testamb)) {
      sumrowI <- 0
      for (valcol in 1:ncol(testamb)){
        if(!is.na(testamb[valrow,valcol])) {
          sumrowI <- sumrowI + testsp1[1,valcol]}

      }
      testsp1_amb[valrow,'sumaDens_SiFQ'] <- sumrowI
    }
    # Divides total density sums by the column sumaDens_SiFQ
    testsp1_amb$div <- testsp1_amb$sumaAB/testsp1_amb$sumaDens_SiFQ
    # OPTIMA CALCULATION: antiLog of the previous calculation for each sample, to revert from log10
    testsp1_amb$Optimo <- 10^testsp1_amb$div

    #########-------- STARTS TOLERANCE RANGE CALCULATION

    # First calculates the difference between the log of the original environmental variable and the log of the optimum
    testsp1_tol <- testamb - testsp1_amb$div
    # Then elevates the entire matrix to the square
    testsp1_tol <- testsp1_tol^2
    # And the elevated matrix is multiplied by the species' density for each site
    for (valrow in 1:nrow(testsp1_tol)) {
      for (valcol in 1:ncol(testsp1_tol)){
        testsp1_tol[valrow,valcol] <- testsp1_tol[valrow,valcol] * testsp1[1,valcol]
      }
    }
    # Adds rows into a new column (sumaTol)
    testsp1_tol <- as.data.frame(testsp1_tol)
    testsp1_tol$sumaTol <- rowSums(testsp1_tol, na.rm=TRUE)
    # Divides the sumaTol column by the "sumaDens_SiFQ" column used in optima calculation
    testsp1_tol$divTol <- testsp1_tol$sumaTol / testsp1_amb$sumaDens_SiFQ
    # Square root of that division
    testsp1_tol$SqdivTol <- sqrt(testsp1_tol$divTol)
    # Adds new columns: With tolerance high and tolerance low
    testsp1_tol$Tol_high <-  10^(testsp1_amb$div + testsp1_tol$SqdivTol)
    testsp1_tol$Tol_low <-  10^(testsp1_amb$div - testsp1_tol$SqdivTol)

    ########-------- COPIES EVERYTHING TO THE FINAL DATAFRAME FOR DISPLAY
    # COPIES THE OPTIMUM AND TOLERANCE COLUMNS TO A SEPARATE DATAFRAME, TRANSPOSES IT AND COPIES
    # IT TO finalDF FOR EXPORT

    testsp1_final <- data.frame(testsp1_amb$Optimo, testsp1_tol$Tol_high, testsp1_tol$Tol_low, stringsAsFactors=FALSE)

    # Rearranges rows
    for (valrow in 2:nrow(testsp1_final)) {
      for (valcol in 1:3){
        testsp1_final[1,ncol(testsp1_final)+1] <- testsp1_final[valrow,valcol]
      }
    }
    # Adds a column in the final dataframe with the species' names (from the original CSV file)
    testsp1_final <- head(testsp1_final,1)
    testsp1_final <- cbind(a = 'spName', testsp1_final)
    finalDF[species_i,] <- testsp1_final[1,]
  }

  # COPIES THE LIST OF SPECIES NAME TO THE 1ST COLUMN OF THE FINAL DATAFRAME
  finalDF[,1] <- df_densidades[,1]

  # COPIES THE LIST OF ENVIRONMENTAL VARIABLES AS COLUMN NAMES. THREE COLUMNS PER VARIABLE (OPTIMUM, TOLERANCE HIGH, TOLERANCE LOW)
  colnames(finalDF)[1] <- "Species"
  numamb <- length(list_ambientales)
  for (val in 1:numamb){
    valcol2 <- val * 3 - 1
    colnames(finalDF)[valcol2] <- list_ambientales[val]
    colnames(finalDF)[valcol2+1] <- paste(list_ambientales[val], "-HIGH")
    colnames(finalDF)[valcol2+2] <- paste(list_ambientales[val], "-LOW")
  }
  #increases print option
  options(max.print=900000)

  print("Optimum values and tolerance range calculated and placed in the final dataframe")
  print("Use View() to view dataframe with results")
  return(finalDF)

}



