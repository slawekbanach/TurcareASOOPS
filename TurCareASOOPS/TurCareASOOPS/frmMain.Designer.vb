<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VareTableAdapter = New TurCareASOOPS.DatabaseDataSetTableAdapters.vareTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DatabaseDataSet = New TurCareASOOPS.DatabaseDataSet()
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pageLogut = New System.Windows.Forms.TabPage()
        Me.pageStatitikk = New System.Windows.Forms.TabPage()
        Me.pageKurs = New System.Windows.Forms.TabPage()
        Me.dgvKursdeltagereOversikt = New System.Windows.Forms.DataGridView()
        Me.DeltagernavnDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeltagertlfDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PameldingkursBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KursDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KursDataSet = New TurCareASOOPS.kursDataSet()
        Me.btnVisPameldteKurs = New System.Windows.Forms.Button()
        Me.cmbVelgKurs = New System.Windows.Forms.ComboBox()
        Me.btnLeggTilKursdeltager = New System.Windows.Forms.Button()
        Me.btnRegistrerKurs = New System.Windows.Forms.Button()
        Me.dgvKursMeldPa = New System.Windows.Forms.DataGridView()
        Me.DeltagernavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeltagertlfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PameldingkursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelKursTextboxes = New System.Windows.Forms.Panel()
        Me.txtKursPris = New System.Windows.Forms.TextBox()
        Me.txtKursType = New System.Windows.Forms.TextBox()
        Me.txtKursinstruktor = New System.Windows.Forms.TextBox()
        Me.txtKursSted = New System.Windows.Forms.TextBox()
        Me.txtKursPlasser = New System.Windows.Forms.TextBox()
        Me.dtpKursDato = New System.Windows.Forms.DateTimePicker()
        Me.btnMeldPaDeltagerKurs = New System.Windows.Forms.Button()
        Me.panelKursLabels = New System.Windows.Forms.Panel()
        Me.lblKursPris = New System.Windows.Forms.Label()
        Me.lblKursinstruktor = New System.Windows.Forms.Label()
        Me.lblKursPlasser = New System.Windows.Forms.Label()
        Me.lblKursType = New System.Windows.Forms.Label()
        Me.lblKursSted = New System.Windows.Forms.Label()
        Me.lblKursdato = New System.Windows.Forms.Label()
        Me.btnLagreKurs = New System.Windows.Forms.Button()
        Me.pageSalg = New System.Windows.Forms.TabPage()
        Me.cmbVareSalg = New System.Windows.Forms.ComboBox()
        Me.cmbKundeSalg = New System.Windows.Forms.ComboBox()
        Me.lblEnhetsprisSalg = New System.Windows.Forms.Label()
        Me.lblAntallSalg = New System.Windows.Forms.Label()
        Me.txtEnhetsprisSalg = New System.Windows.Forms.TextBox()
        Me.txtAntallSalg = New System.Windows.Forms.TextBox()
        Me.lblPrisSalg = New System.Windows.Forms.Label()
        Me.lblVareSalg = New System.Windows.Forms.Label()
        Me.lblSalgsdatoSalg = New System.Windows.Forms.Label()
        Me.lblKundeSalg = New System.Windows.Forms.Label()
        Me.lblSelgerSalg = New System.Windows.Forms.Label()
        Me.btnRegistrerSalg = New System.Windows.Forms.Button()
        Me.txtPrisSalg = New System.Windows.Forms.TextBox()
        Me.txtDatoSalg = New System.Windows.Forms.TextBox()
        Me.txtSelgerSalg = New System.Windows.Forms.TextBox()
        Me.pagePerson = New System.Windows.Forms.TabPage()
        Me.btnLeggTilKunde = New System.Windows.Forms.Button()
        Me.btnLeggTilAnsatt = New System.Windows.Forms.Button()
        Me.btnSokPerson = New System.Windows.Forms.Button()
        Me.txtSoekPerson = New System.Windows.Forms.TextBox()
        Me.dgvPerson = New System.Windows.Forms.DataGridView()
        Me.PersonfornavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonetternavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonepostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersontlfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonpostnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonpoststedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersontypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonbrukernavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonpassordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnTilbakePerson = New System.Windows.Forms.Button()
        Me.btnListUtAnsatte = New System.Windows.Forms.Button()
        Me.btnListUtKunder = New System.Windows.Forms.Button()
        Me.PersonerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New TurCareASOOPS.DatabaseDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pageHjem = New System.Windows.Forms.TabPage()
        Me.pageLager = New System.Windows.Forms.TabPage()
        Me.btnLagreLager = New System.Windows.Forms.Button()
        Me.txtsoek = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnListUt = New System.Windows.Forms.Button()
        Me.dgvLager = New System.Windows.Forms.DataGridView()
        Me.VarenavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaresalgutleieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilstandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareprisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilbudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarestatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareantallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonerTableAdapter = New TurCareASOOPS.DatabaseDataSetTableAdapters.personerTableAdapter()
        Me.Pamelding_kursTableAdapter = New TurCareASOOPS.kursDataSetTableAdapters.pamelding_kursTableAdapter()
        Me.pageUtleie = New System.Windows.Forms.TabPage()
        Me.cmbVarer = New System.Windows.Forms.ComboBox()
        Me.cmbKunder = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalpris = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pris = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.txtSelger = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageKurs.SuspendLayout()
        CType(Me.dgvKursdeltagereOversikt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PameldingkursBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KursDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KursDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKursMeldPa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PameldingkursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKursTextboxes.SuspendLayout()
        Me.panelKursLabels.SuspendLayout()
        Me.pageSalg.SuspendLayout()
        Me.pagePerson.SuspendLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.pageLager.SuspendLayout()
        CType(Me.dgvLager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageUtleie.SuspendLayout()
        Me.SuspendLayout()
        '
        'VareTableAdapter
        '
        Me.VareTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1278, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Kurs.png")
        Me.ImageList1.Images.SetKeyName(1, "Lager.png")
        Me.ImageList1.Images.SetKeyName(2, "Person.png")
        Me.ImageList1.Images.SetKeyName(3, "Salg.png")
        Me.ImageList1.Images.SetKeyName(4, "Statistikk.png")
        Me.ImageList1.Images.SetKeyName(5, "Vare.png")
        Me.ImageList1.Images.SetKeyName(6, "Logout.png")
        Me.ImageList1.Images.SetKeyName(7, "Hjem.png")
        Me.ImageList1.Images.SetKeyName(8, "Utleie.png")
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseDataSetBindingSource
        '
        Me.DatabaseDataSetBindingSource.DataSource = Me.DatabaseDataSet
        Me.DatabaseDataSetBindingSource.Position = 0
        '
        'VareBindingSource
        '
        Me.VareBindingSource.DataMember = "vare"
        Me.VareBindingSource.DataSource = Me.DatabaseDataSetBindingSource
        '
        'pageLogut
        '
        Me.pageLogut.ImageKey = "Logout.png"
        Me.pageLogut.Location = New System.Drawing.Point(52, 4)
        Me.pageLogut.Name = "pageLogut"
        Me.pageLogut.Size = New System.Drawing.Size(1222, 686)
        Me.pageLogut.TabIndex = 6
        Me.pageLogut.UseVisualStyleBackColor = True
        '
        'pageStatitikk
        '
        Me.pageStatitikk.ImageKey = "Statistikk.png"
        Me.pageStatitikk.Location = New System.Drawing.Point(52, 4)
        Me.pageStatitikk.Name = "pageStatitikk"
        Me.pageStatitikk.Size = New System.Drawing.Size(1222, 686)
        Me.pageStatitikk.TabIndex = 5
        Me.pageStatitikk.UseVisualStyleBackColor = True
        '
        'pageKurs
        '
        Me.pageKurs.Controls.Add(Me.dgvKursdeltagereOversikt)
        Me.pageKurs.Controls.Add(Me.btnVisPameldteKurs)
        Me.pageKurs.Controls.Add(Me.cmbVelgKurs)
        Me.pageKurs.Controls.Add(Me.btnLeggTilKursdeltager)
        Me.pageKurs.Controls.Add(Me.btnRegistrerKurs)
        Me.pageKurs.Controls.Add(Me.dgvKursMeldPa)
        Me.pageKurs.Controls.Add(Me.PanelKursTextboxes)
        Me.pageKurs.Controls.Add(Me.btnMeldPaDeltagerKurs)
        Me.pageKurs.Controls.Add(Me.panelKursLabels)
        Me.pageKurs.Controls.Add(Me.btnLagreKurs)
        Me.pageKurs.ImageKey = "Kurs.png"
        Me.pageKurs.Location = New System.Drawing.Point(52, 4)
        Me.pageKurs.Name = "pageKurs"
        Me.pageKurs.Size = New System.Drawing.Size(1222, 686)
        Me.pageKurs.TabIndex = 4
        Me.pageKurs.UseVisualStyleBackColor = True
        '
        'dgvKursdeltagereOversikt
        '
        Me.dgvKursdeltagereOversikt.AutoGenerateColumns = False
        Me.dgvKursdeltagereOversikt.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvKursdeltagereOversikt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKursdeltagereOversikt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeltagernavnDataGridViewTextBoxColumn1, Me.DeltagertlfDataGridViewTextBoxColumn1, Me.KursidDataGridViewTextBoxColumn1})
        Me.dgvKursdeltagereOversikt.DataSource = Me.PameldingkursBindingSource1
        Me.dgvKursdeltagereOversikt.Location = New System.Drawing.Point(839, 434)
        Me.dgvKursdeltagereOversikt.Name = "dgvKursdeltagereOversikt"
        Me.dgvKursdeltagereOversikt.RowTemplate.Height = 28
        Me.dgvKursdeltagereOversikt.Size = New System.Drawing.Size(414, 377)
        Me.dgvKursdeltagereOversikt.TabIndex = 24
        '
        'DeltagernavnDataGridViewTextBoxColumn1
        '
        Me.DeltagernavnDataGridViewTextBoxColumn1.DataPropertyName = "deltager_navn"
        Me.DeltagernavnDataGridViewTextBoxColumn1.HeaderText = "Navn"
        Me.DeltagernavnDataGridViewTextBoxColumn1.Name = "DeltagernavnDataGridViewTextBoxColumn1"
        '
        'DeltagertlfDataGridViewTextBoxColumn1
        '
        Me.DeltagertlfDataGridViewTextBoxColumn1.DataPropertyName = "deltager_tlf"
        Me.DeltagertlfDataGridViewTextBoxColumn1.HeaderText = "Telefon"
        Me.DeltagertlfDataGridViewTextBoxColumn1.Name = "DeltagertlfDataGridViewTextBoxColumn1"
        '
        'KursidDataGridViewTextBoxColumn1
        '
        Me.KursidDataGridViewTextBoxColumn1.DataPropertyName = "kurs_id"
        Me.KursidDataGridViewTextBoxColumn1.HeaderText = "Kurs ID "
        Me.KursidDataGridViewTextBoxColumn1.Name = "KursidDataGridViewTextBoxColumn1"
        '
        'PameldingkursBindingSource1
        '
        Me.PameldingkursBindingSource1.DataMember = "pamelding_kurs"
        Me.PameldingkursBindingSource1.DataSource = Me.KursDataSetBindingSource
        '
        'KursDataSetBindingSource
        '
        Me.KursDataSetBindingSource.DataSource = Me.KursDataSet
        Me.KursDataSetBindingSource.Position = 0
        '
        'KursDataSet
        '
        Me.KursDataSet.DataSetName = "kursDataSet"
        Me.KursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnVisPameldteKurs
        '
        Me.btnVisPameldteKurs.Location = New System.Drawing.Point(733, 6)
        Me.btnVisPameldteKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVisPameldteKurs.Name = "btnVisPameldteKurs"
        Me.btnVisPameldteKurs.Size = New System.Drawing.Size(218, 68)
        Me.btnVisPameldteKurs.TabIndex = 23
        Me.btnVisPameldteKurs.Text = "Vis påmeldte "
        Me.btnVisPameldteKurs.UseVisualStyleBackColor = True
        '
        'cmbVelgKurs
        '
        Me.cmbVelgKurs.FormattingEnabled = True
        Me.cmbVelgKurs.Location = New System.Drawing.Point(444, 101)
        Me.cmbVelgKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbVelgKurs.Name = "cmbVelgKurs"
        Me.cmbVelgKurs.Size = New System.Drawing.Size(318, 28)
        Me.cmbVelgKurs.TabIndex = 21
        Me.cmbVelgKurs.Text = "Velg kurs fra listen"
        '
        'btnLeggTilKursdeltager
        '
        Me.btnLeggTilKursdeltager.Location = New System.Drawing.Point(444, 6)
        Me.btnLeggTilKursdeltager.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilKursdeltager.Name = "btnLeggTilKursdeltager"
        Me.btnLeggTilKursdeltager.Size = New System.Drawing.Size(218, 68)
        Me.btnLeggTilKursdeltager.TabIndex = 16
        Me.btnLeggTilKursdeltager.Text = "Legg til kursdeltagere"
        Me.btnLeggTilKursdeltager.UseVisualStyleBackColor = True
        '
        'btnRegistrerKurs
        '
        Me.btnRegistrerKurs.Location = New System.Drawing.Point(163, 6)
        Me.btnRegistrerKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistrerKurs.Name = "btnRegistrerKurs"
        Me.btnRegistrerKurs.Size = New System.Drawing.Size(218, 68)
        Me.btnRegistrerKurs.TabIndex = 15
        Me.btnRegistrerKurs.Text = "Registrer nytt kurs"
        Me.btnRegistrerKurs.UseVisualStyleBackColor = True
        '
        'dgvKursMeldPa
        '
        Me.dgvKursMeldPa.AutoGenerateColumns = False
        Me.dgvKursMeldPa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvKursMeldPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKursMeldPa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeltagernavnDataGridViewTextBoxColumn, Me.DeltagertlfDataGridViewTextBoxColumn, Me.KursidDataGridViewTextBoxColumn})
        Me.dgvKursMeldPa.DataSource = Me.PameldingkursBindingSource
        Me.dgvKursMeldPa.Location = New System.Drawing.Point(839, 101)
        Me.dgvKursMeldPa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvKursMeldPa.Name = "dgvKursMeldPa"
        Me.dgvKursMeldPa.Size = New System.Drawing.Size(379, 297)
        Me.dgvKursMeldPa.TabIndex = 20
        '
        'DeltagernavnDataGridViewTextBoxColumn
        '
        Me.DeltagernavnDataGridViewTextBoxColumn.DataPropertyName = "deltager_navn"
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DeltagernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.DeltagernavnDataGridViewTextBoxColumn.HeaderText = "Navn"
        Me.DeltagernavnDataGridViewTextBoxColumn.Name = "DeltagernavnDataGridViewTextBoxColumn"
        '
        'DeltagertlfDataGridViewTextBoxColumn
        '
        Me.DeltagertlfDataGridViewTextBoxColumn.DataPropertyName = "deltager_tlf"
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DeltagertlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.DeltagertlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.DeltagertlfDataGridViewTextBoxColumn.Name = "DeltagertlfDataGridViewTextBoxColumn"
        '
        'KursidDataGridViewTextBoxColumn
        '
        Me.KursidDataGridViewTextBoxColumn.DataPropertyName = "kurs_id"
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.LightSkyBlue
        Me.KursidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.KursidDataGridViewTextBoxColumn.HeaderText = "Kurs ID"
        Me.KursidDataGridViewTextBoxColumn.Name = "KursidDataGridViewTextBoxColumn"
        '
        'PameldingkursBindingSource
        '
        Me.PameldingkursBindingSource.DataMember = "pamelding_kurs"
        Me.PameldingkursBindingSource.DataSource = Me.KursDataSet
        '
        'PanelKursTextboxes
        '
        Me.PanelKursTextboxes.Controls.Add(Me.txtKursPris)
        Me.PanelKursTextboxes.Controls.Add(Me.txtKursType)
        Me.PanelKursTextboxes.Controls.Add(Me.txtKursinstruktor)
        Me.PanelKursTextboxes.Controls.Add(Me.txtKursSted)
        Me.PanelKursTextboxes.Controls.Add(Me.txtKursPlasser)
        Me.PanelKursTextboxes.Controls.Add(Me.dtpKursDato)
        Me.PanelKursTextboxes.Location = New System.Drawing.Point(447, 160)
        Me.PanelKursTextboxes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelKursTextboxes.Name = "PanelKursTextboxes"
        Me.PanelKursTextboxes.Size = New System.Drawing.Size(362, 397)
        Me.PanelKursTextboxes.TabIndex = 17
        '
        'txtKursPris
        '
        Me.txtKursPris.Location = New System.Drawing.Point(4, 348)
        Me.txtKursPris.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKursPris.Name = "txtKursPris"
        Me.txtKursPris.Size = New System.Drawing.Size(310, 26)
        Me.txtKursPris.TabIndex = 3
        '
        'txtKursType
        '
        Me.txtKursType.Location = New System.Drawing.Point(4, 289)
        Me.txtKursType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKursType.Name = "txtKursType"
        Me.txtKursType.Size = New System.Drawing.Size(310, 26)
        Me.txtKursType.TabIndex = 3
        '
        'txtKursinstruktor
        '
        Me.txtKursinstruktor.Location = New System.Drawing.Point(4, 14)
        Me.txtKursinstruktor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKursinstruktor.Name = "txtKursinstruktor"
        Me.txtKursinstruktor.Size = New System.Drawing.Size(310, 26)
        Me.txtKursinstruktor.TabIndex = 2
        '
        'txtKursSted
        '
        Me.txtKursSted.Location = New System.Drawing.Point(4, 225)
        Me.txtKursSted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKursSted.Name = "txtKursSted"
        Me.txtKursSted.Size = New System.Drawing.Size(310, 26)
        Me.txtKursSted.TabIndex = 3
        '
        'txtKursPlasser
        '
        Me.txtKursPlasser.Location = New System.Drawing.Point(4, 154)
        Me.txtKursPlasser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKursPlasser.Name = "txtKursPlasser"
        Me.txtKursPlasser.Size = New System.Drawing.Size(310, 26)
        Me.txtKursPlasser.TabIndex = 3
        '
        'dtpKursDato
        '
        Me.dtpKursDato.Location = New System.Drawing.Point(4, 85)
        Me.dtpKursDato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpKursDato.Name = "dtpKursDato"
        Me.dtpKursDato.Size = New System.Drawing.Size(310, 26)
        Me.dtpKursDato.TabIndex = 4
        '
        'btnMeldPaDeltagerKurs
        '
        Me.btnMeldPaDeltagerKurs.Location = New System.Drawing.Point(92, 597)
        Me.btnMeldPaDeltagerKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMeldPaDeltagerKurs.Name = "btnMeldPaDeltagerKurs"
        Me.btnMeldPaDeltagerKurs.Size = New System.Drawing.Size(322, 83)
        Me.btnMeldPaDeltagerKurs.TabIndex = 22
        Me.btnMeldPaDeltagerKurs.Text = "Button4"
        Me.btnMeldPaDeltagerKurs.UseVisualStyleBackColor = True
        '
        'panelKursLabels
        '
        Me.panelKursLabels.Controls.Add(Me.lblKursPris)
        Me.panelKursLabels.Controls.Add(Me.lblKursinstruktor)
        Me.panelKursLabels.Controls.Add(Me.lblKursPlasser)
        Me.panelKursLabels.Controls.Add(Me.lblKursType)
        Me.panelKursLabels.Controls.Add(Me.lblKursSted)
        Me.panelKursLabels.Controls.Add(Me.lblKursdato)
        Me.panelKursLabels.Location = New System.Drawing.Point(330, 154)
        Me.panelKursLabels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelKursLabels.Name = "panelKursLabels"
        Me.panelKursLabels.Size = New System.Drawing.Size(112, 403)
        Me.panelKursLabels.TabIndex = 19
        '
        'lblKursPris
        '
        Me.lblKursPris.AutoSize = True
        Me.lblKursPris.Location = New System.Drawing.Point(4, 363)
        Me.lblKursPris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursPris.Name = "lblKursPris"
        Me.lblKursPris.Size = New System.Drawing.Size(57, 20)
        Me.lblKursPris.TabIndex = 5
        Me.lblKursPris.Text = "Label1"
        '
        'lblKursinstruktor
        '
        Me.lblKursinstruktor.AutoSize = True
        Me.lblKursinstruktor.Location = New System.Drawing.Point(4, 29)
        Me.lblKursinstruktor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursinstruktor.Name = "lblKursinstruktor"
        Me.lblKursinstruktor.Size = New System.Drawing.Size(57, 20)
        Me.lblKursinstruktor.TabIndex = 5
        Me.lblKursinstruktor.Text = "Label1"
        '
        'lblKursPlasser
        '
        Me.lblKursPlasser.AutoSize = True
        Me.lblKursPlasser.Location = New System.Drawing.Point(4, 168)
        Me.lblKursPlasser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursPlasser.Name = "lblKursPlasser"
        Me.lblKursPlasser.Size = New System.Drawing.Size(57, 20)
        Me.lblKursPlasser.TabIndex = 5
        Me.lblKursPlasser.Text = "Label1"
        '
        'lblKursType
        '
        Me.lblKursType.AutoSize = True
        Me.lblKursType.Location = New System.Drawing.Point(4, 305)
        Me.lblKursType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursType.Name = "lblKursType"
        Me.lblKursType.Size = New System.Drawing.Size(57, 20)
        Me.lblKursType.TabIndex = 5
        Me.lblKursType.Text = "Label1"
        '
        'lblKursSted
        '
        Me.lblKursSted.AutoSize = True
        Me.lblKursSted.Location = New System.Drawing.Point(4, 238)
        Me.lblKursSted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursSted.Name = "lblKursSted"
        Me.lblKursSted.Size = New System.Drawing.Size(57, 20)
        Me.lblKursSted.TabIndex = 5
        Me.lblKursSted.Text = "Label1"
        '
        'lblKursdato
        '
        Me.lblKursdato.AutoSize = True
        Me.lblKursdato.Location = New System.Drawing.Point(4, 105)
        Me.lblKursdato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKursdato.Name = "lblKursdato"
        Me.lblKursdato.Size = New System.Drawing.Size(57, 20)
        Me.lblKursdato.TabIndex = 5
        Me.lblKursdato.Text = "Label1"
        '
        'btnLagreKurs
        '
        Me.btnLagreKurs.Location = New System.Drawing.Point(462, 597)
        Me.btnLagreKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLagreKurs.Name = "btnLagreKurs"
        Me.btnLagreKurs.Size = New System.Drawing.Size(322, 83)
        Me.btnLagreKurs.TabIndex = 18
        Me.btnLagreKurs.Text = "Button3"
        Me.btnLagreKurs.UseVisualStyleBackColor = True
        '
        'pageSalg
        '
        Me.pageSalg.Controls.Add(Me.cmbVareSalg)
        Me.pageSalg.Controls.Add(Me.cmbKundeSalg)
        Me.pageSalg.Controls.Add(Me.lblEnhetsprisSalg)
        Me.pageSalg.Controls.Add(Me.lblAntallSalg)
        Me.pageSalg.Controls.Add(Me.txtEnhetsprisSalg)
        Me.pageSalg.Controls.Add(Me.txtAntallSalg)
        Me.pageSalg.Controls.Add(Me.lblPrisSalg)
        Me.pageSalg.Controls.Add(Me.lblVareSalg)
        Me.pageSalg.Controls.Add(Me.lblSalgsdatoSalg)
        Me.pageSalg.Controls.Add(Me.lblKundeSalg)
        Me.pageSalg.Controls.Add(Me.lblSelgerSalg)
        Me.pageSalg.Controls.Add(Me.btnRegistrerSalg)
        Me.pageSalg.Controls.Add(Me.txtPrisSalg)
        Me.pageSalg.Controls.Add(Me.txtDatoSalg)
        Me.pageSalg.Controls.Add(Me.txtSelgerSalg)
        Me.pageSalg.ImageKey = "Salg.png"
        Me.pageSalg.Location = New System.Drawing.Point(52, 4)
        Me.pageSalg.Name = "pageSalg"
        Me.pageSalg.Size = New System.Drawing.Size(1222, 686)
        Me.pageSalg.TabIndex = 3
        Me.pageSalg.UseVisualStyleBackColor = True
        '
        'cmbVareSalg
        '
        Me.cmbVareSalg.FormattingEnabled = True
        Me.cmbVareSalg.Location = New System.Drawing.Point(518, 296)
        Me.cmbVareSalg.Name = "cmbVareSalg"
        Me.cmbVareSalg.Size = New System.Drawing.Size(181, 28)
        Me.cmbVareSalg.TabIndex = 29
        Me.cmbVareSalg.Text = "Velg vare fra listen"
        '
        'cmbKundeSalg
        '
        Me.cmbKundeSalg.FormattingEnabled = True
        Me.cmbKundeSalg.Location = New System.Drawing.Point(518, 188)
        Me.cmbKundeSalg.Name = "cmbKundeSalg"
        Me.cmbKundeSalg.Size = New System.Drawing.Size(181, 28)
        Me.cmbKundeSalg.TabIndex = 28
        Me.cmbKundeSalg.Text = "Velg kunde fra listen"
        '
        'lblEnhetsprisSalg
        '
        Me.lblEnhetsprisSalg.AutoSize = True
        Me.lblEnhetsprisSalg.Location = New System.Drawing.Point(380, 352)
        Me.lblEnhetsprisSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnhetsprisSalg.Name = "lblEnhetsprisSalg"
        Me.lblEnhetsprisSalg.Size = New System.Drawing.Size(85, 20)
        Me.lblEnhetsprisSalg.TabIndex = 27
        Me.lblEnhetsprisSalg.Text = "Enhetspris"
        '
        'lblAntallSalg
        '
        Me.lblAntallSalg.AutoSize = True
        Me.lblAntallSalg.Location = New System.Drawing.Point(416, 408)
        Me.lblAntallSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAntallSalg.Name = "lblAntallSalg"
        Me.lblAntallSalg.Size = New System.Drawing.Size(49, 20)
        Me.lblAntallSalg.TabIndex = 27
        Me.lblAntallSalg.Text = "Antall"
        '
        'txtEnhetsprisSalg
        '
        Me.txtEnhetsprisSalg.Location = New System.Drawing.Point(519, 352)
        Me.txtEnhetsprisSalg.Name = "txtEnhetsprisSalg"
        Me.txtEnhetsprisSalg.Size = New System.Drawing.Size(181, 26)
        Me.txtEnhetsprisSalg.TabIndex = 26
        '
        'txtAntallSalg
        '
        Me.txtAntallSalg.Location = New System.Drawing.Point(519, 405)
        Me.txtAntallSalg.Name = "txtAntallSalg"
        Me.txtAntallSalg.Size = New System.Drawing.Size(181, 26)
        Me.txtAntallSalg.TabIndex = 26
        '
        'lblPrisSalg
        '
        Me.lblPrisSalg.AutoSize = True
        Me.lblPrisSalg.Location = New System.Drawing.Point(423, 464)
        Me.lblPrisSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrisSalg.Name = "lblPrisSalg"
        Me.lblPrisSalg.Size = New System.Drawing.Size(35, 20)
        Me.lblPrisSalg.TabIndex = 25
        Me.lblPrisSalg.Text = "Pris"
        '
        'lblVareSalg
        '
        Me.lblVareSalg.AutoSize = True
        Me.lblVareSalg.Location = New System.Drawing.Point(422, 304)
        Me.lblVareSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVareSalg.Name = "lblVareSalg"
        Me.lblVareSalg.Size = New System.Drawing.Size(43, 20)
        Me.lblVareSalg.TabIndex = 24
        Me.lblVareSalg.Text = "Vare"
        '
        'lblSalgsdatoSalg
        '
        Me.lblSalgsdatoSalg.AutoSize = True
        Me.lblSalgsdatoSalg.Location = New System.Drawing.Point(384, 244)
        Me.lblSalgsdatoSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalgsdatoSalg.Name = "lblSalgsdatoSalg"
        Me.lblSalgsdatoSalg.Size = New System.Drawing.Size(81, 20)
        Me.lblSalgsdatoSalg.TabIndex = 23
        Me.lblSalgsdatoSalg.Text = "Salgsdato"
        '
        'lblKundeSalg
        '
        Me.lblKundeSalg.AutoSize = True
        Me.lblKundeSalg.Location = New System.Drawing.Point(404, 190)
        Me.lblKundeSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKundeSalg.Name = "lblKundeSalg"
        Me.lblKundeSalg.Size = New System.Drawing.Size(55, 20)
        Me.lblKundeSalg.TabIndex = 22
        Me.lblKundeSalg.Text = "Kunde"
        '
        'lblSelgerSalg
        '
        Me.lblSelgerSalg.AutoSize = True
        Me.lblSelgerSalg.Location = New System.Drawing.Point(410, 136)
        Me.lblSelgerSalg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelgerSalg.Name = "lblSelgerSalg"
        Me.lblSelgerSalg.Size = New System.Drawing.Size(55, 20)
        Me.lblSelgerSalg.TabIndex = 21
        Me.lblSelgerSalg.Text = "Selger"
        '
        'btnRegistrerSalg
        '
        Me.btnRegistrerSalg.Location = New System.Drawing.Point(518, 513)
        Me.btnRegistrerSalg.Name = "btnRegistrerSalg"
        Me.btnRegistrerSalg.Size = New System.Drawing.Size(182, 44)
        Me.btnRegistrerSalg.TabIndex = 20
        Me.btnRegistrerSalg.Text = "Registrer Salg"
        Me.btnRegistrerSalg.UseVisualStyleBackColor = True
        '
        'txtPrisSalg
        '
        Me.txtPrisSalg.Location = New System.Drawing.Point(518, 460)
        Me.txtPrisSalg.Name = "txtPrisSalg"
        Me.txtPrisSalg.Size = New System.Drawing.Size(181, 26)
        Me.txtPrisSalg.TabIndex = 19
        '
        'txtDatoSalg
        '
        Me.txtDatoSalg.Location = New System.Drawing.Point(518, 242)
        Me.txtDatoSalg.Name = "txtDatoSalg"
        Me.txtDatoSalg.Size = New System.Drawing.Size(181, 26)
        Me.txtDatoSalg.TabIndex = 17
        '
        'txtSelgerSalg
        '
        Me.txtSelgerSalg.Location = New System.Drawing.Point(518, 130)
        Me.txtSelgerSalg.Name = "txtSelgerSalg"
        Me.txtSelgerSalg.Size = New System.Drawing.Size(181, 26)
        Me.txtSelgerSalg.TabIndex = 15
        '
        'pagePerson
        '
        Me.pagePerson.Controls.Add(Me.btnLeggTilKunde)
        Me.pagePerson.Controls.Add(Me.btnLeggTilAnsatt)
        Me.pagePerson.Controls.Add(Me.btnSokPerson)
        Me.pagePerson.Controls.Add(Me.txtSoekPerson)
        Me.pagePerson.Controls.Add(Me.dgvPerson)
        Me.pagePerson.Controls.Add(Me.btnTilbakePerson)
        Me.pagePerson.Controls.Add(Me.btnListUtAnsatte)
        Me.pagePerson.Controls.Add(Me.btnListUtKunder)
        Me.pagePerson.ImageKey = "Person.png"
        Me.pagePerson.Location = New System.Drawing.Point(52, 4)
        Me.pagePerson.Name = "pagePerson"
        Me.pagePerson.Padding = New System.Windows.Forms.Padding(3)
        Me.pagePerson.Size = New System.Drawing.Size(1222, 686)
        Me.pagePerson.TabIndex = 1
        Me.pagePerson.UseVisualStyleBackColor = True
        '
        'btnLeggTilKunde
        '
        Me.btnLeggTilKunde.Location = New System.Drawing.Point(178, 579)
        Me.btnLeggTilKunde.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLeggTilKunde.Name = "btnLeggTilKunde"
        Me.btnLeggTilKunde.Size = New System.Drawing.Size(138, 34)
        Me.btnLeggTilKunde.TabIndex = 16
        Me.btnLeggTilKunde.Text = "Legg til Kunde"
        Me.btnLeggTilKunde.UseVisualStyleBackColor = True
        '
        'btnLeggTilAnsatt
        '
        Me.btnLeggTilAnsatt.Location = New System.Drawing.Point(18, 578)
        Me.btnLeggTilAnsatt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLeggTilAnsatt.Name = "btnLeggTilAnsatt"
        Me.btnLeggTilAnsatt.Size = New System.Drawing.Size(138, 34)
        Me.btnLeggTilAnsatt.TabIndex = 14
        Me.btnLeggTilAnsatt.Text = "Legg til Ansatt"
        Me.btnLeggTilAnsatt.UseVisualStyleBackColor = True
        '
        'btnSokPerson
        '
        Me.btnSokPerson.Location = New System.Drawing.Point(705, 562)
        Me.btnSokPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSokPerson.Name = "btnSokPerson"
        Me.btnSokPerson.Size = New System.Drawing.Size(112, 34)
        Me.btnSokPerson.TabIndex = 13
        Me.btnSokPerson.Text = "Button2"
        Me.btnSokPerson.UseVisualStyleBackColor = True
        '
        'txtSoekPerson
        '
        Me.txtSoekPerson.Location = New System.Drawing.Point(705, 520)
        Me.txtSoekPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoekPerson.Name = "txtSoekPerson"
        Me.txtSoekPerson.Size = New System.Drawing.Size(148, 26)
        Me.txtSoekPerson.TabIndex = 12
        '
        'dgvPerson
        '
        Me.dgvPerson.AutoGenerateColumns = False
        Me.dgvPerson.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonfornavnDataGridViewTextBoxColumn, Me.PersonetternavnDataGridViewTextBoxColumn, Me.PersonepostDataGridViewTextBoxColumn, Me.PersontlfDataGridViewTextBoxColumn, Me.PersonadresseDataGridViewTextBoxColumn, Me.PersonpostnrDataGridViewTextBoxColumn, Me.PersonpoststedDataGridViewTextBoxColumn, Me.PersontypeDataGridViewTextBoxColumn, Me.PersonbrukernavnDataGridViewTextBoxColumn, Me.PersonpassordDataGridViewTextBoxColumn})
        Me.dgvPerson.DataSource = Me.PersonerBindingSource1
        Me.dgvPerson.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvPerson.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPerson.Location = New System.Drawing.Point(3, 3)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.RowTemplate.Height = 28
        Me.dgvPerson.Size = New System.Drawing.Size(1216, 488)
        Me.dgvPerson.TabIndex = 11
        '
        'PersonfornavnDataGridViewTextBoxColumn
        '
        Me.PersonfornavnDataGridViewTextBoxColumn.DataPropertyName = "person_fornavn"
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonfornavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.PersonfornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn"
        Me.PersonfornavnDataGridViewTextBoxColumn.Name = "PersonfornavnDataGridViewTextBoxColumn"
        '
        'PersonetternavnDataGridViewTextBoxColumn
        '
        Me.PersonetternavnDataGridViewTextBoxColumn.DataPropertyName = "person_etternavn"
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonetternavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.PersonetternavnDataGridViewTextBoxColumn.HeaderText = "Etternavn"
        Me.PersonetternavnDataGridViewTextBoxColumn.Name = "PersonetternavnDataGridViewTextBoxColumn"
        '
        'PersonepostDataGridViewTextBoxColumn
        '
        Me.PersonepostDataGridViewTextBoxColumn.DataPropertyName = "person_epost"
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonepostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.PersonepostDataGridViewTextBoxColumn.HeaderText = "Epost"
        Me.PersonepostDataGridViewTextBoxColumn.Name = "PersonepostDataGridViewTextBoxColumn"
        '
        'PersontlfDataGridViewTextBoxColumn
        '
        Me.PersontlfDataGridViewTextBoxColumn.DataPropertyName = "person_tlf"
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.PersontlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.PersontlfDataGridViewTextBoxColumn.Name = "PersontlfDataGridViewTextBoxColumn"
        '
        'PersonadresseDataGridViewTextBoxColumn
        '
        Me.PersonadresseDataGridViewTextBoxColumn.DataPropertyName = "person_adresse"
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonadresseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.PersonadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.PersonadresseDataGridViewTextBoxColumn.Name = "PersonadresseDataGridViewTextBoxColumn"
        '
        'PersonpostnrDataGridViewTextBoxColumn
        '
        Me.PersonpostnrDataGridViewTextBoxColumn.DataPropertyName = "person_postnr"
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpostnrDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle29
        Me.PersonpostnrDataGridViewTextBoxColumn.HeaderText = "Postnummer"
        Me.PersonpostnrDataGridViewTextBoxColumn.Name = "PersonpostnrDataGridViewTextBoxColumn"
        '
        'PersonpoststedDataGridViewTextBoxColumn
        '
        Me.PersonpoststedDataGridViewTextBoxColumn.DataPropertyName = "person_poststed"
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpoststedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle30
        Me.PersonpoststedDataGridViewTextBoxColumn.HeaderText = "Poststed"
        Me.PersonpoststedDataGridViewTextBoxColumn.Name = "PersonpoststedDataGridViewTextBoxColumn"
        '
        'PersontypeDataGridViewTextBoxColumn
        '
        Me.PersontypeDataGridViewTextBoxColumn.DataPropertyName = "person_type"
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle31
        Me.PersontypeDataGridViewTextBoxColumn.HeaderText = "Ansatt/kunde"
        Me.PersontypeDataGridViewTextBoxColumn.Name = "PersontypeDataGridViewTextBoxColumn"
        '
        'PersonbrukernavnDataGridViewTextBoxColumn
        '
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DataPropertyName = "person_brukernavn"
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle32
        Me.PersonbrukernavnDataGridViewTextBoxColumn.HeaderText = "Brukernavn - ansatte"
        Me.PersonbrukernavnDataGridViewTextBoxColumn.Name = "PersonbrukernavnDataGridViewTextBoxColumn"
        '
        'PersonpassordDataGridViewTextBoxColumn
        '
        Me.PersonpassordDataGridViewTextBoxColumn.DataPropertyName = "person_passord"
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpassordDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle33
        Me.PersonpassordDataGridViewTextBoxColumn.HeaderText = "Passord - ansatte"
        Me.PersonpassordDataGridViewTextBoxColumn.Name = "PersonpassordDataGridViewTextBoxColumn"
        '
        'PersonerBindingSource1
        '
        Me.PersonerBindingSource1.DataMember = "personer"
        Me.PersonerBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'btnTilbakePerson
        '
        Me.btnTilbakePerson.Location = New System.Drawing.Point(18, 622)
        Me.btnTilbakePerson.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTilbakePerson.Name = "btnTilbakePerson"
        Me.btnTilbakePerson.Size = New System.Drawing.Size(112, 34)
        Me.btnTilbakePerson.TabIndex = 10
        Me.btnTilbakePerson.Text = "Tilbake"
        Me.btnTilbakePerson.UseVisualStyleBackColor = True
        '
        'btnListUtAnsatte
        '
        Me.btnListUtAnsatte.Location = New System.Drawing.Point(18, 534)
        Me.btnListUtAnsatte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListUtAnsatte.Name = "btnListUtAnsatte"
        Me.btnListUtAnsatte.Size = New System.Drawing.Size(138, 34)
        Me.btnListUtAnsatte.TabIndex = 9
        Me.btnListUtAnsatte.Text = "List ut ansatte"
        Me.btnListUtAnsatte.UseVisualStyleBackColor = True
        '
        'btnListUtKunder
        '
        Me.btnListUtKunder.Location = New System.Drawing.Point(178, 534)
        Me.btnListUtKunder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListUtKunder.Name = "btnListUtKunder"
        Me.btnListUtKunder.Size = New System.Drawing.Size(138, 34)
        Me.btnListUtKunder.TabIndex = 15
        Me.btnListUtKunder.Text = "List ut kunder"
        Me.btnListUtKunder.UseVisualStyleBackColor = True
        '
        'PersonerBindingSource
        '
        Me.PersonerBindingSource.DataMember = "personer"
        Me.PersonerBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DatabaseDataSet1
        Me.BindingSource1.Position = 0
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.pageHjem)
        Me.TabControl1.Controls.Add(Me.pageLager)
        Me.TabControl1.Controls.Add(Me.pagePerson)
        Me.TabControl1.Controls.Add(Me.pageSalg)
        Me.TabControl1.Controls.Add(Me.pageUtleie)
        Me.TabControl1.Controls.Add(Me.pageKurs)
        Me.TabControl1.Controls.Add(Me.pageStatitikk)
        Me.TabControl1.Controls.Add(Me.pageLogut)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(48, 48)
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1278, 694)
        Me.TabControl1.TabIndex = 0
        '
        'pageHjem
        '
        Me.pageHjem.ImageKey = "Hjem.png"
        Me.pageHjem.Location = New System.Drawing.Point(52, 4)
        Me.pageHjem.Name = "pageHjem"
        Me.pageHjem.Padding = New System.Windows.Forms.Padding(3)
        Me.pageHjem.Size = New System.Drawing.Size(1222, 686)
        Me.pageHjem.TabIndex = 7
        Me.pageHjem.UseVisualStyleBackColor = True
        '
        'pageLager
        '
        Me.pageLager.Controls.Add(Me.btnLagreLager)
        Me.pageLager.Controls.Add(Me.txtsoek)
        Me.pageLager.Controls.Add(Me.btnSok)
        Me.pageLager.Controls.Add(Me.btnListUt)
        Me.pageLager.Controls.Add(Me.dgvLager)
        Me.pageLager.ImageIndex = 1
        Me.pageLager.Location = New System.Drawing.Point(52, 4)
        Me.pageLager.Name = "pageLager"
        Me.pageLager.Padding = New System.Windows.Forms.Padding(3)
        Me.pageLager.Size = New System.Drawing.Size(1222, 686)
        Me.pageLager.TabIndex = 0
        Me.pageLager.UseVisualStyleBackColor = True
        '
        'btnLagreLager
        '
        Me.btnLagreLager.Location = New System.Drawing.Point(262, 555)
        Me.btnLagreLager.Name = "btnLagreLager"
        Me.btnLagreLager.Size = New System.Drawing.Size(295, 34)
        Me.btnLagreLager.TabIndex = 16
        Me.btnLagreLager.Text = "Oppdater tabellen / lagre ny vare"
        Me.btnLagreLager.UseVisualStyleBackColor = True
        '
        'txtsoek
        '
        Me.txtsoek.Location = New System.Drawing.Point(854, 638)
        Me.txtsoek.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsoek.Name = "txtsoek"
        Me.txtsoek.Size = New System.Drawing.Size(148, 26)
        Me.txtsoek.TabIndex = 15
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(724, 634)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(112, 34)
        Me.btnSok.TabIndex = 12
        Me.btnSok.Text = "Søk på vare"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnListUt
        '
        Me.btnListUt.Location = New System.Drawing.Point(30, 555)
        Me.btnListUt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListUt.Name = "btnListUt"
        Me.btnListUt.Size = New System.Drawing.Size(208, 34)
        Me.btnListUt.TabIndex = 11
        Me.btnListUt.Text = "List ut alle varer"
        Me.btnListUt.UseVisualStyleBackColor = True
        '
        'dgvLager
        '
        Me.dgvLager.AutoGenerateColumns = False
        Me.dgvLager.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLager.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VarenavnDataGridViewTextBoxColumn, Me.VaresalgutleieDataGridViewTextBoxColumn, Me.VaretilstandDataGridViewTextBoxColumn, Me.VareprisDataGridViewTextBoxColumn, Me.VaretilbudDataGridViewTextBoxColumn, Me.VarestatusDataGridViewTextBoxColumn, Me.VareantallDataGridViewTextBoxColumn})
        Me.dgvLager.DataSource = Me.VareBindingSource
        Me.dgvLager.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvLager.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvLager.Location = New System.Drawing.Point(3, 3)
        Me.dgvLager.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvLager.Name = "dgvLager"
        Me.dgvLager.Size = New System.Drawing.Size(1216, 508)
        Me.dgvLager.TabIndex = 14
        '
        'VarenavnDataGridViewTextBoxColumn
        '
        Me.VarenavnDataGridViewTextBoxColumn.DataPropertyName = "vare_navn"
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarenavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle34
        Me.VarenavnDataGridViewTextBoxColumn.HeaderText = "Varenavn"
        Me.VarenavnDataGridViewTextBoxColumn.Name = "VarenavnDataGridViewTextBoxColumn"
        '
        'VaresalgutleieDataGridViewTextBoxColumn
        '
        Me.VaresalgutleieDataGridViewTextBoxColumn.DataPropertyName = "vare_salg_utleie"
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaresalgutleieDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle35
        Me.VaresalgutleieDataGridViewTextBoxColumn.HeaderText = "Salg/Utleie"
        Me.VaresalgutleieDataGridViewTextBoxColumn.Name = "VaresalgutleieDataGridViewTextBoxColumn"
        '
        'VaretilstandDataGridViewTextBoxColumn
        '
        Me.VaretilstandDataGridViewTextBoxColumn.DataPropertyName = "vare_tilstand"
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilstandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle36
        Me.VaretilstandDataGridViewTextBoxColumn.HeaderText = "Tilstand"
        Me.VaretilstandDataGridViewTextBoxColumn.Name = "VaretilstandDataGridViewTextBoxColumn"
        '
        'VareprisDataGridViewTextBoxColumn
        '
        Me.VareprisDataGridViewTextBoxColumn.DataPropertyName = "vare_pris"
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareprisDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle37
        Me.VareprisDataGridViewTextBoxColumn.HeaderText = "Enhetspris/Pris per døgn"
        Me.VareprisDataGridViewTextBoxColumn.Name = "VareprisDataGridViewTextBoxColumn"
        '
        'VaretilbudDataGridViewTextBoxColumn
        '
        Me.VaretilbudDataGridViewTextBoxColumn.DataPropertyName = "vare_tilbud"
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilbudDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle38
        Me.VaretilbudDataGridViewTextBoxColumn.HeaderText = "Tilbud"
        Me.VaretilbudDataGridViewTextBoxColumn.Name = "VaretilbudDataGridViewTextBoxColumn"
        '
        'VarestatusDataGridViewTextBoxColumn
        '
        Me.VarestatusDataGridViewTextBoxColumn.DataPropertyName = "vare_status"
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarestatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle39
        Me.VarestatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.VarestatusDataGridViewTextBoxColumn.Name = "VarestatusDataGridViewTextBoxColumn"
        '
        'VareantallDataGridViewTextBoxColumn
        '
        Me.VareantallDataGridViewTextBoxColumn.DataPropertyName = "vare_antall"
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareantallDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle40
        Me.VareantallDataGridViewTextBoxColumn.HeaderText = "Antall på lager"
        Me.VareantallDataGridViewTextBoxColumn.Name = "VareantallDataGridViewTextBoxColumn"
        '
        'PersonerTableAdapter
        '
        Me.PersonerTableAdapter.ClearBeforeFill = True
        '
        'Pamelding_kursTableAdapter
        '
        Me.Pamelding_kursTableAdapter.ClearBeforeFill = True
        '
        'pageUtleie
        '
        Me.pageUtleie.Controls.Add(Me.cmbVarer)
        Me.pageUtleie.Controls.Add(Me.cmbKunder)
        Me.pageUtleie.Controls.Add(Me.Label6)
        Me.pageUtleie.Controls.Add(Me.txtTotalpris)
        Me.pageUtleie.Controls.Add(Me.DateTimePicker2)
        Me.pageUtleie.Controls.Add(Me.DateTimePicker1)
        Me.pageUtleie.Controls.Add(Me.Label5)
        Me.pageUtleie.Controls.Add(Me.Pris)
        Me.pageUtleie.Controls.Add(Me.Label4)
        Me.pageUtleie.Controls.Add(Me.Label3)
        Me.pageUtleie.Controls.Add(Me.Label2)
        Me.pageUtleie.Controls.Add(Me.Label1)
        Me.pageUtleie.Controls.Add(Me.Button1)
        Me.pageUtleie.Controls.Add(Me.txtPris)
        Me.pageUtleie.Controls.Add(Me.txtSelger)
        Me.pageUtleie.ImageKey = "Utleie.png"
        Me.pageUtleie.Location = New System.Drawing.Point(52, 4)
        Me.pageUtleie.Name = "pageUtleie"
        Me.pageUtleie.Size = New System.Drawing.Size(1222, 686)
        Me.pageUtleie.TabIndex = 8
        Me.pageUtleie.UseVisualStyleBackColor = True
        '
        'cmbVarer
        '
        Me.cmbVarer.FormattingEnabled = True
        Me.cmbVarer.Location = New System.Drawing.Point(537, 233)
        Me.cmbVarer.Name = "cmbVarer"
        Me.cmbVarer.Size = New System.Drawing.Size(184, 28)
        Me.cmbVarer.TabIndex = 53
        Me.cmbVarer.Text = "Velg vare fra listen"
        '
        'cmbKunder
        '
        Me.cmbKunder.FormattingEnabled = True
        Me.cmbKunder.Location = New System.Drawing.Point(537, 178)
        Me.cmbKunder.Name = "cmbKunder"
        Me.cmbKunder.Size = New System.Drawing.Size(182, 28)
        Me.cmbKunder.TabIndex = 52
        Me.cmbKunder.Text = "Velg kunde fra listen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 351)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Til dato"
        '
        'txtTotalpris
        '
        Me.txtTotalpris.Location = New System.Drawing.Point(538, 458)
        Me.txtTotalpris.Name = "txtTotalpris"
        Me.txtTotalpris.Size = New System.Drawing.Size(181, 26)
        Me.txtTotalpris.TabIndex = 50
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(537, 342)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker2.TabIndex = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(537, 299)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(407, 468)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Totalpris"
        '
        'Pris
        '
        Me.Pris.AutoSize = True
        Me.Pris.Location = New System.Drawing.Point(388, 407)
        Me.Pris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pris.Name = "Pris"
        Me.Pris.Size = New System.Drawing.Size(88, 20)
        Me.Pris.TabIndex = 46
        Me.Pris.Text = "Pris pr. dag"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Vare"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 308)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Utleiedato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Kunde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(423, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Selger"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(538, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 43)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Registrer Utleie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPris
        '
        Me.txtPris.Location = New System.Drawing.Point(538, 402)
        Me.txtPris.Name = "txtPris"
        Me.txtPris.ReadOnly = True
        Me.txtPris.Size = New System.Drawing.Size(181, 26)
        Me.txtPris.TabIndex = 40
        '
        'txtSelger
        '
        Me.txtSelger.Location = New System.Drawing.Point(537, 125)
        Me.txtSelger.Name = "txtSelger"
        Me.txtSelger.Size = New System.Drawing.Size(181, 26)
        Me.txtSelger.TabIndex = 39
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1278, 744)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "TurCareAS - Datasystem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageKurs.ResumeLayout(False)
        CType(Me.dgvKursdeltagereOversikt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PameldingkursBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KursDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KursDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKursMeldPa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PameldingkursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKursTextboxes.ResumeLayout(False)
        Me.PanelKursTextboxes.PerformLayout()
        Me.panelKursLabels.ResumeLayout(False)
        Me.panelKursLabels.PerformLayout()
        Me.pageSalg.ResumeLayout(False)
        Me.pageSalg.PerformLayout()
        Me.pagePerson.ResumeLayout(False)
        Me.pagePerson.PerformLayout()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.pageLager.ResumeLayout(False)
        Me.pageLager.PerformLayout()
        CType(Me.dgvLager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageUtleie.ResumeLayout(False)
        Me.pageUtleie.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VareTableAdapter As DatabaseDataSetTableAdapters.vareTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents VareBindingSource As BindingSource
    Friend WithEvents pageLogut As TabPage
    Friend WithEvents pageStatitikk As TabPage
    Friend WithEvents pageKurs As TabPage
    Friend WithEvents pageSalg As TabPage
    Friend WithEvents pagePerson As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pageLager As TabPage
    Friend WithEvents btnLagreLager As Button
    Friend WithEvents txtsoek As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents btnListUt As Button
    Friend WithEvents dgvLager As DataGridView
    Friend WithEvents VarenavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaresalgutleieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilstandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareprisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilbudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarestatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareantallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnLeggTilKunde As Button
    Friend WithEvents btnLeggTilAnsatt As Button
    Friend WithEvents btnSokPerson As Button
    Friend WithEvents txtSoekPerson As TextBox
    Friend WithEvents dgvPerson As DataGridView
    Friend WithEvents PersonfornavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonetternavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonepostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersontlfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonpostnrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonpoststedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersontypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonbrukernavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonpassordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonerBindingSource As BindingSource
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet
    Friend WithEvents btnTilbakePerson As Button
    Friend WithEvents btnListUtAnsatte As Button
    Friend WithEvents btnListUtKunder As Button
    Friend WithEvents PersonerTableAdapter As DatabaseDataSetTableAdapters.personerTableAdapter
    Friend WithEvents PersonerBindingSource1 As BindingSource
    Friend WithEvents lblAntallSalg As Label
    Friend WithEvents txtAntallSalg As TextBox
    Friend WithEvents lblPrisSalg As Label
    Friend WithEvents lblVareSalg As Label
    Friend WithEvents lblSalgsdatoSalg As Label
    Friend WithEvents lblKundeSalg As Label
    Friend WithEvents lblSelgerSalg As Label
    Friend WithEvents btnRegistrerSalg As Button
    Friend WithEvents txtPrisSalg As TextBox
    Friend WithEvents txtSelgerSalg As TextBox
    Friend WithEvents cmbVareSalg As ComboBox
    Friend WithEvents cmbKundeSalg As ComboBox
    Friend WithEvents lblEnhetsprisSalg As Label
    Friend WithEvents txtEnhetsprisSalg As TextBox
    Friend WithEvents txtDatoSalg As TextBox
    Friend WithEvents pageHjem As TabPage
    Friend WithEvents dgvKursdeltagereOversikt As DataGridView
    Friend WithEvents DeltagernavnDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DeltagertlfDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KursidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PameldingkursBindingSource1 As BindingSource
    Friend WithEvents KursDataSetBindingSource As BindingSource
    Friend WithEvents KursDataSet As kursDataSet
    Friend WithEvents btnVisPameldteKurs As Button
    Friend WithEvents cmbVelgKurs As ComboBox
    Friend WithEvents btnLeggTilKursdeltager As Button
    Friend WithEvents btnRegistrerKurs As Button
    Friend WithEvents dgvKursMeldPa As DataGridView
    Friend WithEvents DeltagernavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeltagertlfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KursidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PameldingkursBindingSource As BindingSource
    Friend WithEvents PanelKursTextboxes As Panel
    Friend WithEvents txtKursPris As TextBox
    Friend WithEvents txtKursType As TextBox
    Friend WithEvents txtKursinstruktor As TextBox
    Friend WithEvents txtKursSted As TextBox
    Friend WithEvents txtKursPlasser As TextBox
    Friend WithEvents dtpKursDato As DateTimePicker
    Friend WithEvents btnMeldPaDeltagerKurs As Button
    Friend WithEvents panelKursLabels As Panel
    Friend WithEvents lblKursPris As Label
    Friend WithEvents lblKursinstruktor As Label
    Friend WithEvents lblKursPlasser As Label
    Friend WithEvents lblKursType As Label
    Friend WithEvents lblKursSted As Label
    Friend WithEvents lblKursdato As Label
    Friend WithEvents btnLagreKurs As Button
    Friend WithEvents Pamelding_kursTableAdapter As kursDataSetTableAdapters.pamelding_kursTableAdapter
    Friend WithEvents pageUtleie As TabPage
    Friend WithEvents cmbVarer As ComboBox
    Friend WithEvents cmbKunder As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalpris As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Pris As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPris As TextBox
    Friend WithEvents txtSelger As TextBox
End Class
