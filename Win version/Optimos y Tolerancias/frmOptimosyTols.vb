Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.IO
Imports System
Imports System.Globalization
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop


Public Class frmOptimosyTols
    Dim cuantasmuestras As Integer
    Dim cuantassp As Integer
    Dim cuantosFQ As Integer
    Dim lenguaje As String
    Dim checkOK As Boolean = True

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '////////////////BEGIN
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub frmOptimosyTols_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Automatic language detector
        '   lenguaje = CultureInfo.CurrentCulture.TwoLetterISOLanguageName
        'Changes the language of the GUI
        If lenguaje = "es" Then
            'Spanish
            Label6.Text = "Calculador de óptimos y tolerancias de las especies"
            Label5.Text = "Datos calculados siguiendo la fórmula descripta en:"
            Label1.Text = "Matriz de ESPECIES (filas) x MUESTRA (columnas)"
            Label2.Text = "Matriz de VARIABLES AMBIENTALES  (filas) x MUESTRA (columnas)"
            btnCargaSpXMuestras.Text = "COMENZAR"
            btnPegarAbu.Text = "Pegar matriz de Especies x Muestras"
            btnPegarFQ.Text = "Pegar matriz de Variables ambientales x Muestras"
            radAbundancias.Text = "Abundancias relativas"
            radDensidades.Text = "Densidades"
            radLog10Data.Text = "Datos en Log10"
            radRawData.Text = "Datos crudos"
            btnCalcular.Text = "CALCULAR"
            btnExportar.Text = "Exportar XLS"
            GroupBox1.Text = "Los datos son..."
            GroupBox2.Text = "Los datos son..."
            lblFQ.Text = "Cantidad de Variables Ambientales"
            lblSamples.Text = "Cantidad de Muestras"
            lblSpecies.Text = "Cantidad de Especies"
            tabStart.Text = "COMENZAR"
            tabSpecies.Text = "ESPECIES"
            tabFQ.Text = "VARIABLES AMBIENTALES"
            tabResultados.Text = "RESULTADOS"

        ElseIf lenguaje = "en" Then
            'English
            Label6.Text = "Optima and tolerance calculator"
            Label5.Text = "Optima and tolerance range calculated after:"
            Label1.Text = "Matrix of SPECIES (rows) x SAMPLES (columns)"
            Label2.Text = "Matrix of ENVIRONMENTAL VARIABLES (rows) x SAMPLES (columns)"
            btnCargaSpXMuestras.Text = "START"
            btnPegarAbu.Text = "Paste matrix of Species x Samples"
            btnPegarFQ.Text = "Paste matrix of Environmental Variables x Samples"
            radAbundancias.Text = "Relative Abundance"
            radDensidades.Text = "Density"
            radLog10Data.Text = "Data in Log10"
            radRawData.Text = "Raw data"
            btnCalcular.Text = "CALCULATE"
            btnExportar.Text = "Export XLS"
            GroupBox1.Text = "Type of data"
            GroupBox2.Text = "Type of data"
            lblFQ.Text = "Amount of Environmental Variables"
            lblSamples.Text = "Amount of Samples"
            lblSpecies.Text = "Amount of Species"
            tabStart.Text = "START"
            tabSpecies.Text = "SPECIES"
            tabFQ.Text = "ENVIRONMENTAL VARIABLES"
            tabResultados.Text = "RESULTS"

        End If

    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// BEGIN button : Generates the tables
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub btnCargaSpXMuestras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaSpXMuestras.Click

        'Cleans the datagrids
        PlanillaFqXMuestras.Rows.Clear()
        PlanillaFqXMuestras.Columns.Clear()
        PlanillaResultados.Columns.Clear()
        PlanillaResultados.Rows.Clear()
        PlanillaResumen.Columns.Clear()
        PlanillaResumen.Rows.Clear()
        PlanillaSpXMuestras.Columns.Clear()
        PlanillaSpXMuestras.Rows.Clear()
        PlanillaTolerancia.Rows.Clear()
        PlanillaTolerancia.Columns.Clear()

        'Checks number of samples chosen
        If numMuestras.Value <= 1 Then
            If lenguaje = "es" Then
                MsgBox("Ingrese la cantidad de muestras para proceder")
            ElseIf lenguaje = "en" Then
                MsgBox("Enter the number of environmental samples")
            End If
            Exit Sub
        Else
            cuantasmuestras = CInt(numMuestras.Value)
        End If

        If numFQ.Value <= 1 Then
            If lenguaje = "es" Then
                MsgBox("Ingrese la cantidad de parámetros físicos o químicos para proceder")
            ElseIf lenguaje = "en" Then
                MsgBox("Enter the number of physical-chemical parameters to proceed")
            End If
            Exit Sub
        Else
            cuantosFQ = CInt(numFQ.Value)
        End If

        If numSpecies.Value <= 1 Then
            If lenguaje = "es" Then
                MsgBox("Ingrese la cantidad de especies para las cuales quiere calcular los óptimos y tolerancias")
            ElseIf lenguaje = "en" Then
                MsgBox("Enter the number of species for which you will calculate the optimum and tolerance values")
            End If
            Exit Sub
        Else
            cuantassp = CInt(numSpecies.Value)
        End If

        'Generates new datagrids
        ProgressBar1.Value = 0
        Dim progresstotal As Integer = cuantasmuestras

        Dim spnames As New DataGridViewTextBoxColumn
        Dim fqnames As New DataGridViewTextBoxColumn
        Dim fqresnames As New DataGridViewTextBoxColumn

        spnames.Name = "spnames"
        fqnames.Name = "fqnames"
        fqresnames.Name = "fqresnames"
        spnames.HeaderText = "Especies"
        fqnames.HeaderText = "Parámetro FQ"
        fqresnames.HeaderText = "Parámetro FQ"

        'Adds columns
        PlanillaSpXMuestras.Columns.Add(spnames)
        PlanillaFqXMuestras.Columns.Add(fqnames)
        PlanillaResultados.Columns.Add(fqresnames)

        For i As Integer = 0 To cuantasmuestras - 1
            ProgressBar1.Value = (i * 100) / progresstotal
            Dim ncsp As New DataGridViewTextBoxColumn
            Dim ncfq As New DataGridViewTextBoxColumn
            Dim ncres As New DataGridViewTextBoxColumn

            ncsp.Name = "muestra " & i.ToString
            PlanillaSpXMuestras.Columns.Add(ncsp)
            ncfq.Name = "muestra " & i.ToString
            PlanillaFqXMuestras.Columns.Add(ncfq)
            ncres.Name = "muestra " & i.ToString
            PlanillaResultados.Columns.Add(ncres)
        Next

        'Adds rows
        PlanillaSpXMuestras.Rows.Add(cuantassp - 1)
        PlanillaFqXMuestras.Rows.Add(cuantosFQ - 1)
        PlanillaResultados.Rows.Add(cuantosFQ - 1)

        'Places buttons
        btnPegarAbu.Enabled = True
        btnPegarFQ.Enabled = True
        btnCargaSpXMuestras.Enabled = False
        btnCalcular.Enabled = True
        ProgressBar1.Value = 0
        TabControl1.SelectedTab = tabSpecies

    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// PASTE DATA IN DATAGRIDS FROM CLIPBOARD
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Public Sub PasteData(ByRef dgv As DataGridView, datatype As String)
        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Split(Environment.NewLine)
        r = 0
        c = 0

        'Checks computer decimal symbol
        Dim groupSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator

        'Paste
        For i = 0 To tArr.Length - 1
            If tArr(i) <> "" Then
                arT = tArr(i).Split(vbTab)
                cc = c
                For ii = 0 To arT.Length - 1
                    If cc > dgv.ColumnCount - 1 Then Exit For
                    If r > dgv.Rows.Count - 1 Then Exit Sub

                    'Checks if the first column is text
                    If ii = 0 Then
                        If IsNumeric(arT(ii)) = True Then
                            If lenguaje = "es" Then
                                MsgBox("El valor '" & arT(ii) & "' es numerico. La primera columna debería contener el nombre de las especies")
                            Else
                                MsgBox("The value '" & arT(ii) & "' is numeric. The first column should have the names of the species")
                            End If
                            Exit Sub
                            checkOK = False
                        End If
                    Else

                        ' Checks for empty cells and turns them to 0
                        If datatype = "especies" Then
                            If IsNumeric(arT(ii)) = False Then
                                If lenguaje = "es" Then
                                    'MsgBox("El valor en la celda # " & ii + 1 & " en la fila # " & i + 1 & "no es numérico, o es una celda vacía. Convierta las celdas vacías a 0 (cero)")
                                    arT(ii) = 0
                                Else
                                    'MsgBox("The value in cell # " & ii + 1 & " in row # " & i + 1 & "is not a number, or it is an empty cell. Turn all empty cells to 0 (zero)")
                                    arT(ii) = 0
                                End If
                                'checkOK = False
                            End If
                            If arT(ii).Contains(groupSeparator) Then

                                If lenguaje = "es" Then
                                    MsgBox("El valor en la celda # " & ii + 1 & " en la fila # " & i + 1 & "tiene un caracter incorrecto. Compruebe que los separadores decimales sean los correctos para su sistema operativo (comas/puntos). Se detendrá la carga.")

                                Else
                                    MsgBox("Value in cell # " & ii + 1 & " in row # " & i + 1 & "has an incorrect character. Check that the decimal separator in your sheet matches the decimal separator of your OS (comma, period) and try pasting it again.")

                                End If
                            End If
                        End If
                    End If

                    With dgv.Item(cc, r)
                        .Value = arT(ii).TrimStart
                    End With
                    cc = cc + 1
                Next
                r = r + 1
            End If
        Next

    End Sub


    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// BUTTON: PASTE SPECIES
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub btnPegarAbu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegarAbu.Click
        PasteData(PlanillaSpXMuestras, "especies")
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// BUTTON: PASTE ENVIRONMENTAL DATA
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub btnPegarFQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPegarFQ.Click
        PasteData(PlanillaFqXMuestras, "fq")
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// BUTTON: CALCULATE
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        'Validation
        If checkOK = False Then
            If lenguaje = "es" Then
                MsgBox("Debes corregir los errores en las matrices antes de proseguir")
            ElseIf lenguaje = "en" Then
                MsgBox("There are errors in the matrix that need fixing")
            End If
            Exit Sub
        End If

        If PlanillaFqXMuestras.RowCount = 0 Then
            If lenguaje = "es" Then
                MsgBox("Debe ingresar datos físico-químicos")
            ElseIf lenguaje = "en" Then
                MsgBox("Physical-chemical data must be entered")
            End If
            Exit Sub
        End If

        If PlanillaSpXMuestras.RowCount = 0 Then
            If lenguaje = "es" Then
                MsgBox("Debe ingresar datos de las especies (densidad, abundancia)")
            ElseIf lenguaje = "en" Then
                MsgBox("Species' data has to be entered (abundance, density)")
            End If
            Exit Sub
        End If

        If IsNumeric(PlanillaSpXMuestras.Item(0, 1).Value) = True Then
            If lenguaje = "es" Then
                MsgBox("La primera columna de la matriz de ESPECIES no puede ser numérica. Debe contener los nombres de las especies.")
            ElseIf lenguaje = "en" Then
                MsgBox("The first column of the species matrix cannot be numeric, it has to contain the names of the species")
            End If
            Exit Sub
        End If

        If IsNumeric(PlanillaFqXMuestras.Item(0, 1).Value) = True Then
            If lenguaje = "es" Then
                MsgBox("La primera columna de la matriz de FÍSICOQUÍMICOS no puede ser numérica. Debe contener los nombres de los parámetros físico-químicos a considerar.")
            ElseIf lenguaje = "en" Then
                MsgBox("The first column of the physical-chemical data matrix cannot be numeric, it has to contain the names of the parameters")
            End If

            Exit Sub
        End If

        If IsNumeric(PlanillaFqXMuestras.Item(1, 0).Value) = False Then

            If lenguaje = "es" Then
                MsgBox("La primera fila de la matriz de FÍSICOQUÍMICOS no debe incluir los nombres de las muestras u otro texto.")
            ElseIf lenguaje = "en" Then
                MsgBox("The first column of the physical-chemical data matrix cannot include the names of the samples or any other text")
            End If
            Exit Sub
        End If

        If IsNumeric(PlanillaSpXMuestras.Item(1, 0).Value) = False Then

            If lenguaje = "es" Then
                MsgBox("La primera fila de la matriz de ESPECIES no debe incluir los nombres de las muestras u otro texto")
            ElseIf lenguaje = "en" Then
                MsgBox("The first column of the species' data matrix cannot include the names of the samples or any other text")
            End If
            Exit Sub
        End If

        Dim spactual As Integer = 0

        ' Converts empty cells to 0 

        For i = 1 To PlanillaSpXMuestras.Columns.Count - 1
            For j = 0 To PlanillaSpXMuestras.Rows.Count - 1
                If PlanillaSpXMuestras.Item(i, j).Value = "" Or PlanillaSpXMuestras.Item(i, j).Value = Nothing Then
                    PlanillaSpXMuestras.Item(i, j).Value = 0
                End If
            Next
        Next


        ' Converts all densities to relative abundance data 
        If radDensidades.Checked = True Then
            Dim msj As String
            If lenguaje = "es" Then
                msj = "Las densidades de las especies serán convertidas a abundancias relativas en cada muestra"
            ElseIf lenguaje = "en" Then
                msj = "Density values for each species will be converted to relative abundance"
            End If

            Dim cuidado As Integer = MessageBox.Show(msj, "Cuidado!", MessageBoxButtons.OKCancel)
            If cuidado = DialogResult.Cancel Then
                Exit Sub
            End If

            Dim abutotal As Double
            For i = 1 To PlanillaSpXMuestras.Columns.Count - 1
                For j = 0 To PlanillaSpXMuestras.Rows.Count - 1
                    If PlanillaSpXMuestras.Item(i, j).Value IsNot Nothing And PlanillaSpXMuestras.Item(i, j).Value.ToString <> "" Then
                        abutotal = abutotal + CDbl(PlanillaSpXMuestras.Item(i, j).Value)
                    End If
                Next
                For j = 0 To PlanillaSpXMuestras.Rows.Count - 1
                    If PlanillaSpXMuestras.Item(i, j).Value IsNot Nothing And PlanillaSpXMuestras.Item(i, j).Value.ToString <> "" Then
                        PlanillaSpXMuestras.Item(i, j).Value = (CDbl(PlanillaSpXMuestras.Item(i, j).Value) * 100) / abutotal
                    End If
                Next
            Next
        End If

        ProgressBar1.Value = 0
        Dim progress As Integer

        ' Converts environmental missing data to "MD" 
        For i = 0 To PlanillaFqXMuestras.RowCount - 1
            For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                If IsNumeric(PlanillaFqXMuestras.Item(j, i).Value) = False Then
                    PlanillaFqXMuestras.Item(j, i).Value = "MD"
                End If
            Next
        Next

        ' converts environmental data to LOG 
        If radRawData.Checked = True Then
            Dim msj As String
            If lenguaje = "es" Then
                msj = "Ha indicado que los valores físico-químicos ingresados son datos crudos. Para calcular los óptimos, los datos deben estar en Logaritmo (base 10). Desea que el software los convierta automáticamente?"
            ElseIf lenguaje = "en" Then
                msj = "You have specified that the physical-chemical values entered are raw data. To calcula optimum values, the data has to be converted to Log(10). Do you want Optimos Prime to convert them automatically?"
            End If
            Dim cuidado As Integer = MessageBox.Show(msj, "Cuidado!", MessageBoxButtons.YesNo)
            If cuidado = DialogResult.No Then
                If lenguaje = "es" Then
                    MsgBox("Se cancelará el calculo")
                ElseIf lenguaje = "en" Then
                    MsgBox("Calculation cancelled")
                End If

                Exit Sub
            End If

            For i = 0 To PlanillaFqXMuestras.RowCount - 1
                For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                    If PlanillaFqXMuestras.Item(j, i).Value.ToString <> "MD" Then
                        'Converts data to LOG+1
                        PlanillaFqXMuestras.Item(j, i).Value = Math.Log10(PlanillaFqXMuestras.Item(j, i).Value + 1)
                    End If
                Next
            Next
        End If

        Try
            progress = PlanillaSpXMuestras.Rows.Count - 1
            For spactual = 0 To PlanillaSpXMuestras.Rows.Count - 1

                ProgressBar1.Value = (spactual * 100) / progress
                CalcularAxB(spactual)

                ' Cleans result datagrid
                For i = 0 To PlanillaResultados.Rows.Count - 1
                    For k As Integer = 0 To PlanillaResultados.Columns.Count - 1
                        PlanillaResultados.Item(k, i).Value = ""
                    Next
                Next
                PlanillaResultados.Columns.Remove("sumyxx")
                PlanillaResultados.Columns.Remove("sumy")
                PlanillaResultados.Columns.Remove("hrhs")
                PlanillaResultados.Columns.Remove("antilog")
                PlanillaTolerancia.Rows.Clear()
                PlanillaTolerancia.Columns.Clear()

            Next

        Catch ex As Exception

            If lenguaje = "es" Then
                MsgBox("Error calculando optimos. Revise que los datos sean correctos")
            ElseIf lenguaje = "en" Then
                MsgBox("Error calculating. Please check that the data is in the correct form")
            End If
            MsgBox("Especie=" & spactual)


            'Disables buttons
            btnCalcular.Enabled = True
            btnPegarAbu.Enabled = True
            btnPegarFQ.Enabled = True
            btnCargaSpXMuestras.Enabled = True

 
            Exit Sub
        End Try
        '' COnverts LOG data back to raw data
        Dim valortemp As Double


        If radRawData.Checked = True Then
            For i = 0 To PlanillaFqXMuestras.RowCount - 1
                For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                    If PlanillaFqXMuestras.Item(j, i).Value.ToString <> "MD" Then
                        valortemp = Math.Pow(10, PlanillaFqXMuestras.Item(j, i).Value)
                        PlanillaFqXMuestras.Item(j, i).Value = valortemp + 1
                        'PlanillaFqXMuestras.Item(j, i).Value = Math.Pow(10, PlanillaFqXMuestras.Item(j, i).Value))
                    End If
                Next
            Next
        End If

        'Disables buttons
        btnCalcular.Enabled = False
        btnPegarAbu.Enabled = False
        btnPegarFQ.Enabled = False
        btnCargaSpXMuestras.Enabled = True

        MsgBox("Óptimos y tolerancias calculados!")
        ProgressBar1.Value = 0


    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// OPTIMA CALCULATION. AxB
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////


    Private Sub CalcularAxB(ByVal spactual As Integer)
        ' Calculates AxB for one species (spactual)
        Dim i, j As Integer
        Dim abrelativa As String
        Dim logfq As String
        Dim resultadoaxb As Double


        'Moves the names of the environmental data to the result datagrid 
        For i = 0 To PlanillaFqXMuestras.Rows.Count - 1
            PlanillaResultados.Item(0, i).Value = PlanillaFqXMuestras.Item(0, i).Value
        Next

        ' Calculates relative abundance of the current species * Log of the environmental data and moves result to the results datagrid

        For i = 0 To PlanillaFqXMuestras.RowCount - 1
            For j = 1 To PlanillaFqXMuestras.ColumnCount - 1
                abrelativa = PlanillaSpXMuestras.Item(j, spactual).Value
                logfq = PlanillaFqXMuestras.Item(j, i).Value.ToString
                If abrelativa = "?" Or logfq = "?" Or logfq = "" Or logfq = "MD" Then
                    PlanillaResultados.Item(j, i).Value = "MD"
                Else
                    resultadoaxb = CDbl(abrelativa) * CDbl(logfq)
                    PlanillaResultados.Item(j, i).Value = resultadoaxb
                End If
            Next j
        Next
        CalcularSums(spactual)
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// OPTIMA CALCULATION. ADDITIONS
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub CalcularSums(ByVal spactual As Integer)
        Dim i, k As Integer
        PlanillaResultados.Columns.Add("sumyxx", "SUMy * x desde i hasta n")
        PlanillaResultados.Columns.Add("sumy", "SUMy desde i hasta n")
        ' Calculates SUMYXX

        Dim sumyxx As Double
        For i = 0 To PlanillaResultados.RowCount - 1
            sumyxx = 0
            For k = 1 To PlanillaResultados.ColumnCount - 2
                ' For k = PlanillaResultados.ColumnCount - 2 To 1 Step -1
                If PlanillaResultados.Columns(k).Name = "sumyxx" Then
                    PlanillaResultados.Item(k, i).Value = sumyxx.ToString
                Else
                    If Not PlanillaResultados.Item(k, i).Value.ToString = "MD" Then
                        sumyxx = sumyxx + CDbl(PlanillaResultados.Item(k, i).Value)
                    End If
                End If
                'Next
            Next k
        Next i


        ' Calculates sumy In the SPXMuestras datagrid
        Dim o, p As Integer
        Dim sumy As Double

        For o = 0 To PlanillaFqXMuestras.RowCount - 1
            sumy = 0
            For p = 1 To PlanillaSpXMuestras.ColumnCount - 1
                If PlanillaFqXMuestras.Item(p, o).Value.ToString <> "MD" And PlanillaFqXMuestras.Item(p, o).Value.ToString <> "" Then
                    sumy = sumy + CDbl(PlanillaSpXMuestras.Item(p, spactual).Value.ToString)
                End If

            Next p
            ' Moves results to results datagrid
            For k = 1 To PlanillaResultados.ColumnCount - 1
                'For k = PlanillaResultados.ColumnCount - 1 To 1 Step -1
                If PlanillaResultados.Columns(k).Name = "sumy" Then
                    PlanillaResultados.Item(k, o).Value = sumy
                End If
                'Next
            Next k
        Next o
        CalcularOptimo(spactual)
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// OPTIMA CALCULATION. OPTIMA
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub CalcularOptimo(ByVal spactual As Integer)
        Dim sumyxx As Double
        Dim sumy As Double

        PlanillaResultados.Columns.Add("hrhs", "HR/HS")
        PlanillaResultados.Columns.Add("antilog", "Optimo")

        ' CALCULATES HR/HS IN THE RESULTS DATAGRID
        Dim hrhs As Double
        sumy = 0
        sumyxx = 0
        For i = 0 To PlanillaResultados.RowCount - 1
            For k = 1 To PlanillaResultados.ColumnCount - 1
                If PlanillaResultados.Columns(k).Name = "sumyxx" Then
                    sumyxx = CDbl(PlanillaResultados.Item(k, i).Value.ToString)
                ElseIf PlanillaResultados.Columns(k).Name = "sumy" Then
                    sumy = CDbl(PlanillaResultados.Item(k, i).Value.ToString)
                Else
                End If
                If sumy <> 0 And sumyxx <> 0 And PlanillaResultados.Columns(k).Name = "hrhs" Then
                    hrhs = sumyxx / sumy
                    PlanillaResultados.Item(k, i).Value = hrhs
                End If
            Next
        Next i




        ' CALCULATES OPTIMA (Antilog of hrhs)
        Dim optimo As Double
        For i = 0 To PlanillaResultados.RowCount - 1
            'For k = PlanillaResultados.ColumnCount - 1 To 1 Step -1
            For k = 1 To PlanillaResultados.ColumnCount - 1
                If PlanillaResultados.Columns(k).Name = "hrhs" Then

                    optimo = CDbl(PlanillaResultados.Item(k, i).Value)
                    optimo = Math.Pow(10, optimo)
                End If
                If PlanillaResultados.Columns(k).Name = "antilog" And optimo <> 0 Then
                    PlanillaResultados.Item(k, i).Value = optimo.ToString
                End If

            Next
        Next
        pasarOptimoaResumen(spactual)
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// OPTIMA CALCULATION. MOVE TO SUMMARY
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    Private Sub pasarOptimoaResumen(ByVal spactual As Integer)
        Dim i, k As Integer

        ' CONFIGURES THE SUMMARY
        Dim nombresp As String
        nombresp = PlanillaSpXMuestras.Item(0, spactual).Value.ToString

        Dim nombrefq As String
        If spactual = 0 Then
            PlanillaResumen.Columns.Add("sp", "Especie")
            PlanillaResumen.Rows.Add()

            For i = 0 To PlanillaResultados.Rows.Count - 1
                nombrefq = PlanillaResultados.Item(0, i).Value.ToString
                PlanillaResumen.Columns.Add("fq" & i & "opt", nombrefq & " - Optimo")
                PlanillaResumen.Item("fq" & i & "opt", 0).Value = nombrefq & " - Optimo"
                PlanillaResumen.Columns.Add("fq" & i & "max", nombrefq & " - MAX")
                PlanillaResumen.Item("fq" & i & "max", 0).Value = nombrefq & " - MAX"
                PlanillaResumen.Columns.Add("fq" & i & "min", nombrefq & " - MIN")
                PlanillaResumen.Item("fq" & i & "min", 0).Value = nombrefq & " - MIN"
            Next
        End If


        ' adds rows
        PlanillaResumen.Rows.Add()
        Dim currentrowindex As Integer = PlanillaResumen.Rows.Count - 2

        ' Moves optima to summary
        PlanillaResumen.Item(0, currentrowindex).Value = nombresp

        Dim valoroptimo As Double
        Dim columnaoptimoindex As Integer
        columnaoptimoindex = PlanillaResultados.Columns("antilog").Index
        Dim columnaoptimoresumen As Integer = 1

        For k = 0 To PlanillaResultados.Rows.Count - 1
            valoroptimo = CDbl(PlanillaResultados.Item(columnaoptimoindex, k).Value)
            PlanillaResumen.Item(columnaoptimoresumen, currentrowindex).Value = valoroptimo
            columnaoptimoresumen = columnaoptimoresumen + 3
        Next
        calcularTolerancia(spactual)
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '/////////////// TOLERANCE RANGE CALCULATION
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////

    Private Sub calcularTolerancia(ByVal spactual As Integer)
        Dim i, j, m As Integer
        Dim fqxoptimo As Double = 0
        Dim optimocolindex As Integer = 0
        Dim valoroptimo As Double = 0
        Dim columnamaxresumen As Integer = 2
        Dim columnaminresumen As Integer = 3
        Dim valorsumayindex As Integer
        Dim valorsumay As Double = 0

        optimocolindex = PlanillaResultados.Columns("hrhs").Index
        valorsumayindex = PlanillaResultados.Columns("sumy").Index

        PlanillaTolerancia.Columns.Add("fqxoptimo", "fqxoptimo")
        PlanillaTolerancia.Rows.Add(cuantosFQ - 1)


        Dim parteA As Double
        Dim abrelativa As Double

        For i = 0 To PlanillaFqXMuestras.Rows.Count - 1
            valoroptimo = CDbl(PlanillaResultados.Item(optimocolindex, i).Value)
            fqxoptimo = 0
            valorsumay = CDbl(PlanillaResultados.Item(valorsumayindex, i).Value)
            For j = 1 To PlanillaFqXMuestras.Columns.Count - 1
                If Not PlanillaFqXMuestras.Item(j, i).Value.ToString = "MD" Then
                    parteA = Math.Pow((CDbl(PlanillaFqXMuestras.Item(j, i).Value) - valoroptimo), 2)
                    abrelativa = CDbl(PlanillaSpXMuestras.Item(j, spactual).Value)
                    fqxoptimo = fqxoptimo + (parteA * abrelativa)
                ElseIf PlanillaFqXMuestras.Item(j, i).Value.ToString = "MD" Then
                    parteA = 0
                End If
            Next j
            fqxoptimo = Math.Sqrt(fqxoptimo / valorsumay)
            PlanillaTolerancia.Item(0, i).Value = fqxoptimo
        Next i
        ' Moves tolerance ranges to result datagrid
        Dim hrhs As Double
        Dim max As Double
        For m = 0 To PlanillaTolerancia.Rows.Count - 1
            hrhs = CDbl(PlanillaResumen.Item(columnamaxresumen - 1, spactual + 1).Value)
            hrhs = Math.Log10(hrhs)
            max = hrhs + CDbl(PlanillaTolerancia.Item(0, m).Value)
            PlanillaResumen.Item(columnamaxresumen, spactual + 1).Value = Math.Pow(10, (hrhs + CDbl(PlanillaTolerancia.Item(0, m).Value)))
            PlanillaResumen.Item(columnamaxresumen + 1, spactual + 1).Value = Math.Pow(10, (hrhs - CDbl(PlanillaTolerancia.Item(0, m).Value)))
            columnamaxresumen = columnamaxresumen + 3
        Next
    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// BUTTON: EXPORT TO EXCEL
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim filepath As String
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Archivos de Excel 2007-2010(*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try

                filepath = saveFileDialog1.FileName

                ' ADDS SHEETS
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Dim xlApp As New Microsoft.Office.Interop.Excel.Application

                Dim excelBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add


                Dim rowsTotal, colsTotal As Short
                Dim I, j, iC As Short
                Dim k, m As Short

                Dim excelWorksheet As Excel.Worksheet
                excelWorksheet = DirectCast(excelBook.Sheets.Add(, Count:=1, Type:=Excel.XlSheetType.xlWorksheet), Excel.Worksheet)
                Try
                    rowsTotal = PlanillaResumen.RowCount - 1
                    colsTotal = PlanillaResumen.Columns.Count - 1

                    With excelWorksheet
                        .Name = "Optimos"
                        .Cells.Select()
                        .Cells.Delete()

                        'MOVES VALUES
                        For I = 0 To rowsTotal
                            For j = 0 To colsTotal
                                m = PlanillaResumen.Columns(j).DisplayIndex
                                .Cells(I + 2, m + 1).value = PlanillaResumen.Rows(I).Cells(j).Value
                            Next j
                        Next I

                        .Rows("1:1").Font.FontStyle = "Bold"
                        .Cells.Columns.AutoFit()
                        .Cells.Select()
                        .Cells.EntireColumn.AutoFit()
                        .Cells(1, 1).Select()
                    End With

                Catch ex As Exception
                    MsgBox("Error al exportar: " & ex.Message)
                Finally

                    'RELEASE ALLOACTED RESOURCES  
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    xlApp = Nothing
                End Try
                excelBook.SaveAs(filepath)
                MsgBox("Archivo XLS finalizado!")

            Catch ex As Exception
                MsgBox("No fue posible grabar el archivo XLS. Compruebe que el archivo no este abierto o en uso.")
            End Try

        End If

    End Sub

    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    '//////////////// LANGUAGE BUTTONS
    '////////////////////////////////////////////////
    '////////////////////////////////////////////////
    Private Sub butEs_Click(sender As Object, e As EventArgs) Handles butEs.Click

        Me.Controls.Clear()
        Me.lenguaje = "es"
        InitializeComponent()
        frmOptimosyTols_Load(e, e)

    End Sub

    Private Sub butEn_Click(sender As Object, e As EventArgs) Handles butEn.Click
        'Dim frm = New frmOptimosyTols
        'frm.lenguaje = "en"
        'frm.Show()

        Me.Controls.Clear()
        Me.lenguaje = "en"
        InitializeComponent()
        frmOptimosyTols_Load(e, e)

    End Sub
End Class
