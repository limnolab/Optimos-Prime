<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptimosyTols
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptimosyTols))
        Me.PlanillaSpXMuestras = New System.Windows.Forms.DataGridView()
        Me.PlanillaFqXMuestras = New System.Windows.Forms.DataGridView()
        Me.btnCargaSpXMuestras = New System.Windows.Forms.Button()
        Me.btnPegarAbu = New System.Windows.Forms.Button()
        Me.btnPegarFQ = New System.Windows.Forms.Button()
        Me.PlanillaResultados = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.PlanillaResumen = New System.Windows.Forms.DataGridView()
        Me.PlanillaTolerancia = New System.Windows.Forms.DataGridView()
        Me.radRawData = New System.Windows.Forms.RadioButton()
        Me.radLog10Data = New System.Windows.Forms.RadioButton()
        Me.radAbundancias = New System.Windows.Forms.RadioButton()
        Me.radDensidades = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabStart = New System.Windows.Forms.TabPage()
        Me.lblFQ = New System.Windows.Forms.Label()
        Me.lblSamples = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.numFQ = New System.Windows.Forms.NumericUpDown()
        Me.numMuestras = New System.Windows.Forms.NumericUpDown()
        Me.numSpecies = New System.Windows.Forms.NumericUpDown()
        Me.tabSpecies = New System.Windows.Forms.TabPage()
        Me.tabFQ = New System.Windows.Forms.TabPage()
        Me.tabResultados = New System.Windows.Forms.TabPage()
        Me.butEs = New System.Windows.Forms.Button()
        Me.butEn = New System.Windows.Forms.Button()
        CType(Me.PlanillaSpXMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaFqXMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaTolerancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabStart.SuspendLayout()
        CType(Me.numFQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMuestras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSpecies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSpecies.SuspendLayout()
        Me.tabFQ.SuspendLayout()
        Me.tabResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlanillaSpXMuestras
        '
        Me.PlanillaSpXMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanillaSpXMuestras.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaSpXMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaSpXMuestras.Location = New System.Drawing.Point(55, 38)
        Me.PlanillaSpXMuestras.Name = "PlanillaSpXMuestras"
        Me.PlanillaSpXMuestras.Size = New System.Drawing.Size(978, 258)
        Me.PlanillaSpXMuestras.TabIndex = 0
        '
        'PlanillaFqXMuestras
        '
        Me.PlanillaFqXMuestras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanillaFqXMuestras.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaFqXMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaFqXMuestras.Location = New System.Drawing.Point(55, 38)
        Me.PlanillaFqXMuestras.Name = "PlanillaFqXMuestras"
        Me.PlanillaFqXMuestras.Size = New System.Drawing.Size(978, 258)
        Me.PlanillaFqXMuestras.TabIndex = 1
        '
        'btnCargaSpXMuestras
        '
        Me.btnCargaSpXMuestras.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnCargaSpXMuestras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCargaSpXMuestras.FlatAppearance.BorderSize = 2
        Me.btnCargaSpXMuestras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaSpXMuestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaSpXMuestras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCargaSpXMuestras.Location = New System.Drawing.Point(395, 205)
        Me.btnCargaSpXMuestras.Name = "btnCargaSpXMuestras"
        Me.btnCargaSpXMuestras.Size = New System.Drawing.Size(282, 81)
        Me.btnCargaSpXMuestras.TabIndex = 2
        Me.btnCargaSpXMuestras.Text = "START"
        Me.btnCargaSpXMuestras.UseVisualStyleBackColor = False
        '
        'btnPegarAbu
        '
        Me.btnPegarAbu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPegarAbu.Enabled = False
        Me.btnPegarAbu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnPegarAbu.FlatAppearance.BorderSize = 2
        Me.btnPegarAbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPegarAbu.Location = New System.Drawing.Point(840, 302)
        Me.btnPegarAbu.Name = "btnPegarAbu"
        Me.btnPegarAbu.Size = New System.Drawing.Size(193, 75)
        Me.btnPegarAbu.TabIndex = 4
        Me.btnPegarAbu.Text = "Paste Species x Samples matrix"
        Me.btnPegarAbu.UseVisualStyleBackColor = True
        '
        'btnPegarFQ
        '
        Me.btnPegarFQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPegarFQ.Enabled = False
        Me.btnPegarFQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnPegarFQ.FlatAppearance.BorderSize = 2
        Me.btnPegarFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPegarFQ.Location = New System.Drawing.Point(840, 302)
        Me.btnPegarFQ.Name = "btnPegarFQ"
        Me.btnPegarFQ.Size = New System.Drawing.Size(193, 75)
        Me.btnPegarFQ.TabIndex = 5
        Me.btnPegarFQ.Text = "Paste Physical-chemical x Samples Matrix"
        Me.btnPegarFQ.UseVisualStyleBackColor = True
        '
        'PlanillaResultados
        '
        Me.PlanillaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaResultados.Location = New System.Drawing.Point(6, 69)
        Me.PlanillaResultados.Name = "PlanillaResultados"
        Me.PlanillaResultados.ReadOnly = True
        Me.PlanillaResultados.Size = New System.Drawing.Size(188, 215)
        Me.PlanillaResultados.TabIndex = 6
        '
        'btnCalcular
        '
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnCalcular.FlatAppearance.BorderSize = 2
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(6, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(237, 58)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "CALCULATE"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'PlanillaResumen
        '
        Me.PlanillaResumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanillaResumen.BackgroundColor = System.Drawing.Color.White
        Me.PlanillaResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaResumen.Location = New System.Drawing.Point(6, 69)
        Me.PlanillaResumen.Name = "PlanillaResumen"
        Me.PlanillaResumen.ReadOnly = True
        Me.PlanillaResumen.Size = New System.Drawing.Size(1019, 328)
        Me.PlanillaResumen.TabIndex = 9
        '
        'PlanillaTolerancia
        '
        Me.PlanillaTolerancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillaTolerancia.Location = New System.Drawing.Point(200, 69)
        Me.PlanillaTolerancia.Name = "PlanillaTolerancia"
        Me.PlanillaTolerancia.Size = New System.Drawing.Size(204, 215)
        Me.PlanillaTolerancia.TabIndex = 11
        '
        'radRawData
        '
        Me.radRawData.AutoSize = True
        Me.radRawData.Checked = True
        Me.radRawData.Location = New System.Drawing.Point(7, 19)
        Me.radRawData.Name = "radRawData"
        Me.radRawData.Size = New System.Drawing.Size(71, 17)
        Me.radRawData.TabIndex = 12
        Me.radRawData.TabStop = True
        Me.radRawData.Text = "Raw data"
        Me.radRawData.UseVisualStyleBackColor = True
        '
        'radLog10Data
        '
        Me.radLog10Data.AutoSize = True
        Me.radLog10Data.Location = New System.Drawing.Point(7, 42)
        Me.radLog10Data.Name = "radLog10Data"
        Me.radLog10Data.Size = New System.Drawing.Size(79, 17)
        Me.radLog10Data.TabIndex = 13
        Me.radLog10Data.Text = "Log10 data"
        Me.radLog10Data.UseVisualStyleBackColor = True
        '
        'radAbundancias
        '
        Me.radAbundancias.AutoSize = True
        Me.radAbundancias.Checked = True
        Me.radAbundancias.Location = New System.Drawing.Point(7, 19)
        Me.radAbundancias.Name = "radAbundancias"
        Me.radAbundancias.Size = New System.Drawing.Size(121, 17)
        Me.radAbundancias.TabIndex = 15
        Me.radAbundancias.TabStop = True
        Me.radAbundancias.Text = "Relative abundance"
        Me.radAbundancias.UseVisualStyleBackColor = True
        '
        'radDensidades
        '
        Me.radDensidades.AutoSize = True
        Me.radDensidades.Location = New System.Drawing.Point(7, 42)
        Me.radDensidades.Name = "radDensidades"
        Me.radDensidades.Size = New System.Drawing.Size(68, 17)
        Me.radDensidades.TabIndex = 14
        Me.radDensidades.Text = "Densities"
        Me.radDensidades.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.radDensidades)
        Me.GroupBox1.Controls.Add(Me.radAbundancias)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 73)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "The data is..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.radLog10Data)
        Me.GroupBox2.Controls.Add(Me.radRawData)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 75)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "The data is..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(818, 520)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(239, 20)
        Me.ProgressBar1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Matrix of SPECIES (rows) x SAMPLES (columns)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Matrix of PHYSICAL-CHEMICAL PARAMETERS (rows) x SAMPLES (columns)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Optimos Prime"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnExportar.FlatAppearance.BorderSize = 2
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(920, 6)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(105, 57)
        Me.btnExportar.TabIndex = 24
        Me.btnExportar.Text = "Export XLS"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(850, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Optima and tolerance range calculated after:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Species' optima and tolerance range calculator"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(735, 34)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(327, 45)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Text = "Potapova y Charles (2003). Distribution of benthic diatoms in U.S. rivers in in r" & _
    "elation to conductivity and ionic composition.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Freshwater Biology 48:1311-132" & _
    "8"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabStart)
        Me.TabControl1.Controls.Add(Me.tabSpecies)
        Me.TabControl1.Controls.Add(Me.tabFQ)
        Me.TabControl1.Controls.Add(Me.tabResultados)
        Me.TabControl1.Location = New System.Drawing.Point(14, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1047, 429)
        Me.TabControl1.TabIndex = 0
        '
        'tabStart
        '
        Me.tabStart.Controls.Add(Me.lblFQ)
        Me.tabStart.Controls.Add(Me.lblSamples)
        Me.tabStart.Controls.Add(Me.lblSpecies)
        Me.tabStart.Controls.Add(Me.numFQ)
        Me.tabStart.Controls.Add(Me.numMuestras)
        Me.tabStart.Controls.Add(Me.numSpecies)
        Me.tabStart.Controls.Add(Me.btnCargaSpXMuestras)
        Me.tabStart.Location = New System.Drawing.Point(4, 22)
        Me.tabStart.Name = "tabStart"
        Me.tabStart.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStart.Size = New System.Drawing.Size(1039, 403)
        Me.tabStart.TabIndex = 2
        Me.tabStart.Text = "START"
        Me.tabStart.ToolTipText = "Start here!"
        Me.tabStart.UseVisualStyleBackColor = True
        '
        'lblFQ
        '
        Me.lblFQ.AutoSize = True
        Me.lblFQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFQ.Location = New System.Drawing.Point(257, 161)
        Me.lblFQ.Name = "lblFQ"
        Me.lblFQ.Size = New System.Drawing.Size(299, 20)
        Me.lblFQ.TabIndex = 8
        Me.lblFQ.Text = "Number of physical-chemical parameters:"
        Me.lblFQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSamples
        '
        Me.lblSamples.AutoSize = True
        Me.lblSamples.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSamples.Location = New System.Drawing.Point(406, 128)
        Me.lblSamples.Name = "lblSamples"
        Me.lblSamples.Size = New System.Drawing.Size(150, 20)
        Me.lblSamples.TabIndex = 7
        Me.lblSamples.Text = "Number of samples:"
        Me.lblSamples.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.Location = New System.Drawing.Point(411, 96)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(145, 20)
        Me.lblSpecies.TabIndex = 6
        Me.lblSpecies.Text = "Number of species:"
        Me.lblSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'numFQ
        '
        Me.numFQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFQ.Location = New System.Drawing.Point(557, 158)
        Me.numFQ.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numFQ.Name = "numFQ"
        Me.numFQ.Size = New System.Drawing.Size(120, 26)
        Me.numFQ.TabIndex = 5
        '
        'numMuestras
        '
        Me.numMuestras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMuestras.Location = New System.Drawing.Point(557, 126)
        Me.numMuestras.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.numMuestras.Name = "numMuestras"
        Me.numMuestras.Size = New System.Drawing.Size(120, 26)
        Me.numMuestras.TabIndex = 4
        '
        'numSpecies
        '
        Me.numSpecies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSpecies.Location = New System.Drawing.Point(557, 94)
        Me.numSpecies.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.numSpecies.Name = "numSpecies"
        Me.numSpecies.Size = New System.Drawing.Size(120, 26)
        Me.numSpecies.TabIndex = 3
        '
        'tabSpecies
        '
        Me.tabSpecies.Controls.Add(Me.PlanillaSpXMuestras)
        Me.tabSpecies.Controls.Add(Me.Label1)
        Me.tabSpecies.Controls.Add(Me.btnPegarAbu)
        Me.tabSpecies.Controls.Add(Me.GroupBox1)
        Me.tabSpecies.Location = New System.Drawing.Point(4, 22)
        Me.tabSpecies.Name = "tabSpecies"
        Me.tabSpecies.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSpecies.Size = New System.Drawing.Size(1039, 403)
        Me.tabSpecies.TabIndex = 0
        Me.tabSpecies.Text = "Species Data"
        Me.tabSpecies.UseVisualStyleBackColor = True
        '
        'tabFQ
        '
        Me.tabFQ.Controls.Add(Me.Label2)
        Me.tabFQ.Controls.Add(Me.PlanillaFqXMuestras)
        Me.tabFQ.Controls.Add(Me.btnPegarFQ)
        Me.tabFQ.Controls.Add(Me.GroupBox2)
        Me.tabFQ.Location = New System.Drawing.Point(4, 22)
        Me.tabFQ.Name = "tabFQ"
        Me.tabFQ.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFQ.Size = New System.Drawing.Size(1039, 403)
        Me.tabFQ.TabIndex = 1
        Me.tabFQ.Text = "Physical chemical data"
        Me.tabFQ.UseVisualStyleBackColor = True
        '
        'tabResultados
        '
        Me.tabResultados.Controls.Add(Me.PlanillaResumen)
        Me.tabResultados.Controls.Add(Me.PlanillaTolerancia)
        Me.tabResultados.Controls.Add(Me.PlanillaResultados)
        Me.tabResultados.Controls.Add(Me.btnExportar)
        Me.tabResultados.Controls.Add(Me.btnCalcular)
        Me.tabResultados.Location = New System.Drawing.Point(4, 22)
        Me.tabResultados.Name = "tabResultados"
        Me.tabResultados.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResultados.Size = New System.Drawing.Size(1039, 403)
        Me.tabResultados.TabIndex = 3
        Me.tabResultados.Text = "Calculate"
        Me.tabResultados.UseVisualStyleBackColor = True
        '
        'butEs
        '
        Me.butEs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butEs.FlatAppearance.BorderSize = 0
        Me.butEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEs.Image = CType(resources.GetObject("butEs.Image"), System.Drawing.Image)
        Me.butEs.Location = New System.Drawing.Point(14, 544)
        Me.butEs.Name = "butEs"
        Me.butEs.Size = New System.Drawing.Size(44, 44)
        Me.butEs.TabIndex = 31
        Me.butEs.UseVisualStyleBackColor = True
        '
        'butEn
        '
        Me.butEn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butEn.FlatAppearance.BorderSize = 0
        Me.butEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEn.Image = CType(resources.GetObject("butEn.Image"), System.Drawing.Image)
        Me.butEn.Location = New System.Drawing.Point(63, 544)
        Me.butEn.Name = "butEn"
        Me.butEn.Size = New System.Drawing.Size(44, 44)
        Me.butEn.TabIndex = 32
        Me.butEn.UseVisualStyleBackColor = True
        '
        'frmOptimosyTols
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1069, 610)
        Me.Controls.Add(Me.butEn)
        Me.Controls.Add(Me.butEs)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptimosyTols"
        Me.Text = "Optimos Prime"
        CType(Me.PlanillaSpXMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaFqXMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaTolerancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabStart.ResumeLayout(False)
        Me.tabStart.PerformLayout()
        CType(Me.numFQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMuestras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSpecies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSpecies.ResumeLayout(False)
        Me.tabSpecies.PerformLayout()
        Me.tabFQ.ResumeLayout(False)
        Me.tabFQ.PerformLayout()
        Me.tabResultados.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlanillaSpXMuestras As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaFqXMuestras As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargaSpXMuestras As System.Windows.Forms.Button
    Friend WithEvents btnPegarAbu As System.Windows.Forms.Button
    Friend WithEvents btnPegarFQ As System.Windows.Forms.Button
    Friend WithEvents PlanillaResultados As System.Windows.Forms.DataGridView
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents PlanillaResumen As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaTolerancia As System.Windows.Forms.DataGridView
    Friend WithEvents radRawData As System.Windows.Forms.RadioButton
    Friend WithEvents radLog10Data As System.Windows.Forms.RadioButton
    Friend WithEvents radAbundancias As System.Windows.Forms.RadioButton
    Friend WithEvents radDensidades As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSpecies As System.Windows.Forms.TabPage
    Friend WithEvents tabFQ As System.Windows.Forms.TabPage
    Friend WithEvents tabStart As System.Windows.Forms.TabPage
    Friend WithEvents numFQ As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMuestras As System.Windows.Forms.NumericUpDown
    Friend WithEvents numSpecies As System.Windows.Forms.NumericUpDown
    Friend WithEvents tabResultados As System.Windows.Forms.TabPage
    Friend WithEvents lblFQ As System.Windows.Forms.Label
    Friend WithEvents lblSamples As System.Windows.Forms.Label
    Friend WithEvents lblSpecies As System.Windows.Forms.Label
    Friend WithEvents butEs As System.Windows.Forms.Button
    Friend WithEvents butEn As System.Windows.Forms.Button

End Class
