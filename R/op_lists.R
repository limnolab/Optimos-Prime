#' Optimos Prime calculates optima and tolerance for a matrix of species and environmental factors
#'
#' This function (op_lists) generates three lists from your dataframes: a species list, an environmental factors list and a sample (or sampling sites) list
#' @param enviromental_df The dataframe with your environmental data. Variables as rows, Sites as columns
#' @param species_df The dataframe with your species densities. Species as rows, Sites as columns.
#' @param listOnly Which lists to return. If = 0, then returns all three lists combined (Sites, Species, Environmental). If = 1, it returns only lists of Sites. If = 2, it returns only list of Species. If = 3, it returns only list of Environmental parameters.
#' @description
#' You will need two dataframes. If they are not specified as arguments, you will be prompted to import them from CSV format.
#'
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
#' @keywords ecology, optimum, tolerance, species density
#' @export op_lists
#'

########-------- FUNCTION OP_LISTS SHOWS SPECIES LIST AND ENVIRONMENTAL VARIABLES LISTS  --------------#########
op_lists <- function(enviromental_df, species_df, listOnly=0){
  # First checks in environmental and species dataframes exist. If not, loads them from CSV files
  if(missing(enviromental_df) | missing(species_df) ) {
    print("Select CSV matrices")
    ########-------- LOADS THE SPECIES AND ENVIRONMENTAL DATA FROM CSV FILES IF NOT IN DATAMATRIX
    Filters <- matrix(c("Comma Separated Values (CSV)", "*.csv"),
                      1, 2, byrow = TRUE)
    print("Select ENVIRONMENTAL matrix first")
    env <- read.csv(file.choose())
    #enviromental_df <- read.csv(choose.files(caption="Select environmental matrix", filters = Filters),sep=",")
    enviromental_df <- read.csv(file.choose())
    print("Select SPECIES matrix second")
    # species_df <- read.csv(choose.files(caption="Select species density matrix", filters = Filters),sep=",")
    species_df <- read.csv(file.choose())
  }


  df_ambientales <- enviromental_df
  df_densidades <- species_df
  #Checks that both matrices exist, or exits
  if(missing(enviromental_df) | missing(species_df) ) {
    stop("The correct matrices were not selected, the script will cancel.")
  }

  # Creates three lists: site list, species list and environmental variables list, and returns them
  list_sites <- t(colnames(df_densidades[2:ncol(df_densidades)]))
  list_especies <- as.vector(df_densidades[,1])
  list_ambientales <- as.vector(df_ambientales[,1])

  if(listOnly==0){
    newList <- list(list_sites, list_especies, list_ambientales)
    return(newList)
  } else if(listOnly==1){
    newList <- list(list_sites)
    return(newList)
  } else if(listOnly==2){
    newList <- list(list_especies)
    return(newList)
  } else if(listOnly==3){
    newList <- list(list_ambientales)
    return(newList)
  }

}
