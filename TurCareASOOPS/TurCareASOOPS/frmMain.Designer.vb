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
        Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle81 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle82 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle83 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle84 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle85 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pageLager = New System.Windows.Forms.TabPage()
        Me.btnLagreLager = New System.Windows.Forms.Button()
        Me.txtsoek = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnListUt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VarenavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaresalgutleieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilstandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareprisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilbudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarestatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareantallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New TurCareASOOPS.DatabaseDataSet()
        Me.pagePerson = New System.Windows.Forms.TabPage()
        Me.btnListUtKunder = New System.Windows.Forms.Button()
        Me.btnLeggTilAnsatt = New System.Windows.Forms.Button()
        Me.btnSoekAnsattKunde = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnLeggTilKunde = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
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
        Me.PersonerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New TurCareASOOPS.DatabaseDataSet()
        Me.btnListUtAnsatte = New System.Windows.Forms.Button()
        Me.pageVare = New System.Windows.Forms.TabPage()
        Me.pageSalg = New System.Windows.Forms.TabPage()
        Me.pageKurs = New System.Windows.Forms.TabPage()
        Me.pageStatitikk = New System.Windows.Forms.TabPage()
        Me.pageLogut = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VareTableAdapter = New TurCareASOOPS.DatabaseDataSetTableAdapters.vareTableAdapter()
        Me.PersonerTableAdapter = New TurCareASOOPS.DatabaseDataSetTableAdapters.personerTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.pageLager.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagePerson.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.pageLager)
        Me.TabControl1.Controls.Add(Me.pagePerson)
        Me.TabControl1.Controls.Add(Me.pageVare)
        Me.TabControl1.Controls.Add(Me.pageSalg)
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
        'pageLager
        '
        Me.pageLager.Controls.Add(Me.btnLagreLager)
        Me.pageLager.Controls.Add(Me.txtsoek)
        Me.pageLager.Controls.Add(Me.btnSok)
        Me.pageLager.Controls.Add(Me.btnListUt)
        Me.pageLager.Controls.Add(Me.DataGridView1)
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
        Me.btnLagreLager.Location = New System.Drawing.Point(263, 555)
        Me.btnLagreLager.Name = "btnLagreLager"
        Me.btnLagreLager.Size = New System.Drawing.Size(172, 35)
        Me.btnLagreLager.TabIndex = 16
        Me.btnLagreLager.Text = "Oppdater/lagre"
        Me.btnLagreLager.UseVisualStyleBackColor = True
        '
        'txtsoek
        '
        Me.txtsoek.Location = New System.Drawing.Point(854, 638)
        Me.txtsoek.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsoek.Name = "txtsoek"
        Me.txtsoek.Size = New System.Drawing.Size(148, 26)
        Me.txtsoek.TabIndex = 15
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(724, 634)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(112, 35)
        Me.btnSok.TabIndex = 12
        Me.btnSok.Text = "Søk på vare"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnListUt
        '
        Me.btnListUt.Location = New System.Drawing.Point(30, 555)
        Me.btnListUt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUt.Name = "btnListUt"
        Me.btnListUt.Size = New System.Drawing.Size(208, 35)
        Me.btnListUt.TabIndex = 11
        Me.btnListUt.Text = "List ut alle varer"
        Me.btnListUt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VarenavnDataGridViewTextBoxColumn, Me.VaresalgutleieDataGridViewTextBoxColumn, Me.VaretilstandDataGridViewTextBoxColumn, Me.VareprisDataGridViewTextBoxColumn, Me.VaretilbudDataGridViewTextBoxColumn, Me.VarestatusDataGridViewTextBoxColumn, Me.VareantallDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VareBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1216, 508)
        Me.DataGridView1.TabIndex = 14
        '
        'VarenavnDataGridViewTextBoxColumn
        '
        Me.VarenavnDataGridViewTextBoxColumn.DataPropertyName = "vare_navn"
        DataGridViewCellStyle69.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarenavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle69
        Me.VarenavnDataGridViewTextBoxColumn.HeaderText = "Varenavn"
        Me.VarenavnDataGridViewTextBoxColumn.Name = "VarenavnDataGridViewTextBoxColumn"
        '
        'VaresalgutleieDataGridViewTextBoxColumn
        '
        Me.VaresalgutleieDataGridViewTextBoxColumn.DataPropertyName = "vare_salg_utleie"
        DataGridViewCellStyle70.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaresalgutleieDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle70
        Me.VaresalgutleieDataGridViewTextBoxColumn.HeaderText = "Salg/Utleie"
        Me.VaresalgutleieDataGridViewTextBoxColumn.Name = "VaresalgutleieDataGridViewTextBoxColumn"
        '
        'VaretilstandDataGridViewTextBoxColumn
        '
        Me.VaretilstandDataGridViewTextBoxColumn.DataPropertyName = "vare_tilstand"
        DataGridViewCellStyle71.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilstandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle71
        Me.VaretilstandDataGridViewTextBoxColumn.HeaderText = "Tilstand"
        Me.VaretilstandDataGridViewTextBoxColumn.Name = "VaretilstandDataGridViewTextBoxColumn"
        '
        'VareprisDataGridViewTextBoxColumn
        '
        Me.VareprisDataGridViewTextBoxColumn.DataPropertyName = "vare_pris"
        DataGridViewCellStyle72.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareprisDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle72
        Me.VareprisDataGridViewTextBoxColumn.HeaderText = "Enhetspris/Pris per døgn"
        Me.VareprisDataGridViewTextBoxColumn.Name = "VareprisDataGridViewTextBoxColumn"
        '
        'VaretilbudDataGridViewTextBoxColumn
        '
        Me.VaretilbudDataGridViewTextBoxColumn.DataPropertyName = "vare_tilbud"
        DataGridViewCellStyle73.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilbudDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle73
        Me.VaretilbudDataGridViewTextBoxColumn.HeaderText = "Tilbud"
        Me.VaretilbudDataGridViewTextBoxColumn.Name = "VaretilbudDataGridViewTextBoxColumn"
        '
        'VarestatusDataGridViewTextBoxColumn
        '
        Me.VarestatusDataGridViewTextBoxColumn.DataPropertyName = "vare_status"
        DataGridViewCellStyle74.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarestatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle74
        Me.VarestatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.VarestatusDataGridViewTextBoxColumn.Name = "VarestatusDataGridViewTextBoxColumn"
        '
        'VareantallDataGridViewTextBoxColumn
        '
        Me.VareantallDataGridViewTextBoxColumn.DataPropertyName = "vare_antall"
        DataGridViewCellStyle75.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareantallDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle75
        Me.VareantallDataGridViewTextBoxColumn.HeaderText = "Antall på lager"
        Me.VareantallDataGridViewTextBoxColumn.Name = "VareantallDataGridViewTextBoxColumn"
        '
        'VareBindingSource
        '
        Me.VareBindingSource.DataMember = "vare"
        Me.VareBindingSource.DataSource = Me.DatabaseDataSetBindingSource
        '
        'DatabaseDataSetBindingSource
        '
        Me.DatabaseDataSetBindingSource.DataSource = Me.DatabaseDataSet
        Me.DatabaseDataSetBindingSource.Position = 0
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pagePerson
        '
        Me.pagePerson.Controls.Add(Me.btnListUtKunder)
        Me.pagePerson.Controls.Add(Me.btnLeggTilAnsatt)
        Me.pagePerson.Controls.Add(Me.btnSoekAnsattKunde)
        Me.pagePerson.Controls.Add(Me.TextBox1)
        Me.pagePerson.Controls.Add(Me.btnLeggTilKunde)
        Me.pagePerson.Controls.Add(Me.DataGridView2)
        Me.pagePerson.Controls.Add(Me.btnListUtAnsatte)
        Me.pagePerson.ImageKey = "Person.png"
        Me.pagePerson.Location = New System.Drawing.Point(52, 4)
        Me.pagePerson.Name = "pagePerson"
        Me.pagePerson.Padding = New System.Windows.Forms.Padding(3)
        Me.pagePerson.Size = New System.Drawing.Size(1222, 686)
        Me.pagePerson.TabIndex = 1
        Me.pagePerson.UseVisualStyleBackColor = True
        '
        'btnListUtKunder
        '
        Me.btnListUtKunder.Location = New System.Drawing.Point(179, 534)
        Me.btnListUtKunder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUtKunder.Name = "btnListUtKunder"
        Me.btnListUtKunder.Size = New System.Drawing.Size(138, 35)
        Me.btnListUtKunder.TabIndex = 15
        Me.btnListUtKunder.Text = "List ut kunder"
        Me.btnListUtKunder.UseVisualStyleBackColor = True
        '
        'btnLeggTilAnsatt
        '
        Me.btnLeggTilAnsatt.Location = New System.Drawing.Point(18, 578)
        Me.btnLeggTilAnsatt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilAnsatt.Name = "btnLeggTilAnsatt"
        Me.btnLeggTilAnsatt.Size = New System.Drawing.Size(138, 35)
        Me.btnLeggTilAnsatt.TabIndex = 14
        Me.btnLeggTilAnsatt.Text = "Legg til Ansatt"
        Me.btnLeggTilAnsatt.UseVisualStyleBackColor = True
        '
        'btnSoekAnsattKunde
        '
        Me.btnSoekAnsattKunde.Location = New System.Drawing.Point(711, 585)
        Me.btnSoekAnsattKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSoekAnsattKunde.Name = "btnSoekAnsattKunde"
        Me.btnSoekAnsattKunde.Size = New System.Drawing.Size(112, 35)
        Me.btnSoekAnsattKunde.TabIndex = 13
        Me.btnSoekAnsattKunde.Text = "Søk på ansatt eller kunde"
        Me.btnSoekAnsattKunde.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(711, 543)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 26)
        Me.TextBox1.TabIndex = 12
        '
        'btnLeggTilKunde
        '
        Me.btnLeggTilKunde.Location = New System.Drawing.Point(179, 579)
        Me.btnLeggTilKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilKunde.Name = "btnLeggTilKunde"
        Me.btnLeggTilKunde.Size = New System.Drawing.Size(138, 35)
        Me.btnLeggTilKunde.TabIndex = 16
        Me.btnLeggTilKunde.Text = "Legg til Kunde"
        Me.btnLeggTilKunde.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonfornavnDataGridViewTextBoxColumn, Me.PersonetternavnDataGridViewTextBoxColumn, Me.PersonepostDataGridViewTextBoxColumn, Me.PersontlfDataGridViewTextBoxColumn, Me.PersonadresseDataGridViewTextBoxColumn, Me.PersonpostnrDataGridViewTextBoxColumn, Me.PersonpoststedDataGridViewTextBoxColumn, Me.PersontypeDataGridViewTextBoxColumn, Me.PersonbrukernavnDataGridViewTextBoxColumn, Me.PersonpassordDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PersonerBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1216, 488)
        Me.DataGridView2.TabIndex = 11
        '
        'PersonfornavnDataGridViewTextBoxColumn
        '
        Me.PersonfornavnDataGridViewTextBoxColumn.DataPropertyName = "person_fornavn"
        DataGridViewCellStyle76.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonfornavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle76
        Me.PersonfornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn"
        Me.PersonfornavnDataGridViewTextBoxColumn.Name = "PersonfornavnDataGridViewTextBoxColumn"
        '
        'PersonetternavnDataGridViewTextBoxColumn
        '
        Me.PersonetternavnDataGridViewTextBoxColumn.DataPropertyName = "person_etternavn"
        DataGridViewCellStyle77.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonetternavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle77
        Me.PersonetternavnDataGridViewTextBoxColumn.HeaderText = "Etternavn"
        Me.PersonetternavnDataGridViewTextBoxColumn.Name = "PersonetternavnDataGridViewTextBoxColumn"
        '
        'PersonepostDataGridViewTextBoxColumn
        '
        Me.PersonepostDataGridViewTextBoxColumn.DataPropertyName = "person_epost"
        DataGridViewCellStyle78.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonepostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle78
        Me.PersonepostDataGridViewTextBoxColumn.HeaderText = "Epost"
        Me.PersonepostDataGridViewTextBoxColumn.Name = "PersonepostDataGridViewTextBoxColumn"
        '
        'PersontlfDataGridViewTextBoxColumn
        '
        Me.PersontlfDataGridViewTextBoxColumn.DataPropertyName = "person_tlf"
        DataGridViewCellStyle79.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle79
        Me.PersontlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.PersontlfDataGridViewTextBoxColumn.Name = "PersontlfDataGridViewTextBoxColumn"
        '
        'PersonadresseDataGridViewTextBoxColumn
        '
        Me.PersonadresseDataGridViewTextBoxColumn.DataPropertyName = "person_adresse"
        DataGridViewCellStyle80.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonadresseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle80
        Me.PersonadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.PersonadresseDataGridViewTextBoxColumn.Name = "PersonadresseDataGridViewTextBoxColumn"
        '
        'PersonpostnrDataGridViewTextBoxColumn
        '
        Me.PersonpostnrDataGridViewTextBoxColumn.DataPropertyName = "person_postnr"
        DataGridViewCellStyle81.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpostnrDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle81
        Me.PersonpostnrDataGridViewTextBoxColumn.HeaderText = "Postnummer"
        Me.PersonpostnrDataGridViewTextBoxColumn.Name = "PersonpostnrDataGridViewTextBoxColumn"
        '
        'PersonpoststedDataGridViewTextBoxColumn
        '
        Me.PersonpoststedDataGridViewTextBoxColumn.DataPropertyName = "person_poststed"
        DataGridViewCellStyle82.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpoststedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle82
        Me.PersonpoststedDataGridViewTextBoxColumn.HeaderText = "Poststed"
        Me.PersonpoststedDataGridViewTextBoxColumn.Name = "PersonpoststedDataGridViewTextBoxColumn"
        '
        'PersontypeDataGridViewTextBoxColumn
        '
        Me.PersontypeDataGridViewTextBoxColumn.DataPropertyName = "person_type"
        DataGridViewCellStyle83.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle83
        Me.PersontypeDataGridViewTextBoxColumn.HeaderText = "Ansatt/kunde"
        Me.PersontypeDataGridViewTextBoxColumn.Name = "PersontypeDataGridViewTextBoxColumn"
        '
        'PersonbrukernavnDataGridViewTextBoxColumn
        '
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DataPropertyName = "person_brukernavn"
        DataGridViewCellStyle84.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle84
        Me.PersonbrukernavnDataGridViewTextBoxColumn.HeaderText = "Brukernavn - ansatte"
        Me.PersonbrukernavnDataGridViewTextBoxColumn.Name = "PersonbrukernavnDataGridViewTextBoxColumn"
        '
        'PersonpassordDataGridViewTextBoxColumn
        '
        Me.PersonpassordDataGridViewTextBoxColumn.DataPropertyName = "person_passord"
        DataGridViewCellStyle85.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpassordDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle85
        Me.PersonpassordDataGridViewTextBoxColumn.HeaderText = "Passord - ansatte"
        Me.PersonpassordDataGridViewTextBoxColumn.Name = "PersonpassordDataGridViewTextBoxColumn"
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
        'btnListUtAnsatte
        '
        Me.btnListUtAnsatte.Location = New System.Drawing.Point(18, 534)
        Me.btnListUtAnsatte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUtAnsatte.Name = "btnListUtAnsatte"
        Me.btnListUtAnsatte.Size = New System.Drawing.Size(138, 35)
        Me.btnListUtAnsatte.TabIndex = 9
        Me.btnListUtAnsatte.Text = "List ut ansatte"
        Me.btnListUtAnsatte.UseVisualStyleBackColor = True
        '
        'pageVare
        '
        Me.pageVare.ImageKey = "Vare.png"
        Me.pageVare.Location = New System.Drawing.Point(52, 4)
        Me.pageVare.Name = "pageVare"
        Me.pageVare.Size = New System.Drawing.Size(1222, 686)
        Me.pageVare.TabIndex = 2
        Me.pageVare.UseVisualStyleBackColor = True
        '
        'pageSalg
        '
        Me.pageSalg.ImageKey = "Salg.png"
        Me.pageSalg.Location = New System.Drawing.Point(52, 4)
        Me.pageSalg.Name = "pageSalg"
        Me.pageSalg.Size = New System.Drawing.Size(1222, 686)
        Me.pageSalg.TabIndex = 3
        Me.pageSalg.UseVisualStyleBackColor = True
        '
        'pageKurs
        '
        Me.pageKurs.ImageKey = "Kurs.png"
        Me.pageKurs.Location = New System.Drawing.Point(52, 4)
        Me.pageKurs.Name = "pageKurs"
        Me.pageKurs.Size = New System.Drawing.Size(1222, 686)
        Me.pageKurs.TabIndex = 4
        Me.pageKurs.UseVisualStyleBackColor = True
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
        'pageLogut
        '
        Me.pageLogut.ImageKey = "Logout.png"
        Me.pageLogut.Location = New System.Drawing.Point(52, 4)
        Me.pageLogut.Name = "pageLogut"
        Me.pageLogut.Size = New System.Drawing.Size(1222, 686)
        Me.pageLogut.TabIndex = 6
        Me.pageLogut.UseVisualStyleBackColor = True
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
        'VareTableAdapter
        '
        Me.VareTableAdapter.ClearBeforeFill = True
        '
        'PersonerTableAdapter
        '
        Me.PersonerTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 744)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "TurCareAS - Datasystem"
        Me.TabControl1.ResumeLayout(False)
        Me.pageLager.ResumeLayout(False)
        Me.pageLager.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagePerson.ResumeLayout(False)
        Me.pagePerson.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pageLager As TabPage
    Friend WithEvents pagePerson As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pageVare As TabPage
    Friend WithEvents pageSalg As TabPage
    Friend WithEvents pageKurs As TabPage
    Friend WithEvents pageStatitikk As TabPage
    Friend WithEvents pageLogut As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLagreLager As Button
    Friend WithEvents txtsoek As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents btnListUt As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VarenavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaresalgutleieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilstandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareprisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilbudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarestatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareantallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareBindingSource As BindingSource
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents VareTableAdapter As DatabaseDataSetTableAdapters.vareTableAdapter
    Friend WithEvents btnListUtKunder As Button
    Friend WithEvents btnLeggTilAnsatt As Button
    Friend WithEvents btnSoekAnsattKunde As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnLeggTilKunde As Button
    Friend WithEvents DataGridView2 As DataGridView
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
    Friend WithEvents btnListUtAnsatte As Button
    Friend WithEvents PersonerTableAdapter As DatabaseDataSetTableAdapters.personerTableAdapter
End Class
