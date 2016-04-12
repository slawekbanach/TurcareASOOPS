<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListUtAnsatte
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
        Me.components = New System.ComponentModel.Container()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Goopst4DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.G_oops_t4DataSet = New TurCareASOOPS.g_oops_t4DataSet()
        Me.txtSoek = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.PersonerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonerTableAdapter = New TurCareASOOPS.g_oops_t4DataSetTableAdapters.personerTableAdapter()
        Me.PersonfornavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonetternavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonepostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersontlfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonpostnrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonpoststedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersontypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonbrukernavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.person_passord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Goopst4DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_oops_t4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 537)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "List ut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(18, 597)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(112, 35)
        Me.btnTilbake.TabIndex = 2
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonfornavnDataGridViewTextBoxColumn, Me.PersonetternavnDataGridViewTextBoxColumn, Me.PersonepostDataGridViewTextBoxColumn, Me.PersontlfDataGridViewTextBoxColumn, Me.PersonadresseDataGridViewTextBoxColumn, Me.PersonpostnrDataGridViewTextBoxColumn, Me.PersonpoststedDataGridViewTextBoxColumn, Me.PersontypeDataGridViewTextBoxColumn, Me.PersonbrukernavnDataGridViewTextBoxColumn, Me.person_passord})
        Me.DataGridView1.DataSource = Me.PersonerBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1237, 488)
        Me.DataGridView1.TabIndex = 3
        '
        'Goopst4DataSetBindingSource
        '
        Me.Goopst4DataSetBindingSource.DataSource = Me.G_oops_t4DataSet
        Me.Goopst4DataSetBindingSource.Position = 0
        '
        'G_oops_t4DataSet
        '
        Me.G_oops_t4DataSet.DataSetName = "g_oops_t4DataSet"
        Me.G_oops_t4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSoek
        '
        Me.txtSoek.Location = New System.Drawing.Point(705, 495)
        Me.txtSoek.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSoek.Name = "txtSoek"
        Me.txtSoek.Size = New System.Drawing.Size(148, 26)
        Me.txtSoek.TabIndex = 4
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(705, 537)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(112, 35)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Button2"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'PersonerBindingSource
        '
        Me.PersonerBindingSource.DataMember = "personer"
        Me.PersonerBindingSource.DataSource = Me.Goopst4DataSetBindingSource
        '
        'PersonerTableAdapter
        '
        Me.PersonerTableAdapter.ClearBeforeFill = True
        '
        'PersonfornavnDataGridViewTextBoxColumn
        '
        Me.PersonfornavnDataGridViewTextBoxColumn.DataPropertyName = "person_fornavn"
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonfornavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.PersonfornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn"
        Me.PersonfornavnDataGridViewTextBoxColumn.Name = "PersonfornavnDataGridViewTextBoxColumn"
        '
        'PersonetternavnDataGridViewTextBoxColumn
        '
        Me.PersonetternavnDataGridViewTextBoxColumn.DataPropertyName = "person_etternavn"
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonetternavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle22
        Me.PersonetternavnDataGridViewTextBoxColumn.HeaderText = "Etternavn"
        Me.PersonetternavnDataGridViewTextBoxColumn.Name = "PersonetternavnDataGridViewTextBoxColumn"
        '
        'PersonepostDataGridViewTextBoxColumn
        '
        Me.PersonepostDataGridViewTextBoxColumn.DataPropertyName = "person_epost"
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonepostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle23
        Me.PersonepostDataGridViewTextBoxColumn.HeaderText = "Epost"
        Me.PersonepostDataGridViewTextBoxColumn.Name = "PersonepostDataGridViewTextBoxColumn"
        '
        'PersontlfDataGridViewTextBoxColumn
        '
        Me.PersontlfDataGridViewTextBoxColumn.DataPropertyName = "person_tlf"
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle24
        Me.PersontlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.PersontlfDataGridViewTextBoxColumn.Name = "PersontlfDataGridViewTextBoxColumn"
        '
        'PersonadresseDataGridViewTextBoxColumn
        '
        Me.PersonadresseDataGridViewTextBoxColumn.DataPropertyName = "person_adresse"
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonadresseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle25
        Me.PersonadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.PersonadresseDataGridViewTextBoxColumn.Name = "PersonadresseDataGridViewTextBoxColumn"
        '
        'PersonpostnrDataGridViewTextBoxColumn
        '
        Me.PersonpostnrDataGridViewTextBoxColumn.DataPropertyName = "person_postnr"
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpostnrDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle26
        Me.PersonpostnrDataGridViewTextBoxColumn.HeaderText = "Postnummer"
        Me.PersonpostnrDataGridViewTextBoxColumn.Name = "PersonpostnrDataGridViewTextBoxColumn"
        '
        'PersonpoststedDataGridViewTextBoxColumn
        '
        Me.PersonpoststedDataGridViewTextBoxColumn.DataPropertyName = "person_poststed"
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpoststedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle27
        Me.PersonpoststedDataGridViewTextBoxColumn.HeaderText = "Poststed"
        Me.PersonpoststedDataGridViewTextBoxColumn.Name = "PersonpoststedDataGridViewTextBoxColumn"
        '
        'PersontypeDataGridViewTextBoxColumn
        '
        Me.PersontypeDataGridViewTextBoxColumn.DataPropertyName = "person_type"
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle28
        Me.PersontypeDataGridViewTextBoxColumn.HeaderText = "Ansatt/Kunde"
        Me.PersontypeDataGridViewTextBoxColumn.Name = "PersontypeDataGridViewTextBoxColumn"
        '
        'PersonbrukernavnDataGridViewTextBoxColumn
        '
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DataPropertyName = "person_brukernavn"
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle29
        Me.PersonbrukernavnDataGridViewTextBoxColumn.HeaderText = "Brukernavn "
        Me.PersonbrukernavnDataGridViewTextBoxColumn.Name = "PersonbrukernavnDataGridViewTextBoxColumn"
        '
        'person_passord
        '
        Me.person_passord.DataPropertyName = "person_passord"
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.LightSkyBlue
        Me.person_passord.DefaultCellStyle = DataGridViewCellStyle30
        Me.person_passord.HeaderText = "Passord"
        Me.person_passord.Name = "person_passord"
        '
        'ListUtAnsatte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 651)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.txtSoek)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListUtAnsatte"
        Me.Text = "ListUtAnsatte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Goopst4DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.G_oops_t4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSoek As TextBox
    Friend WithEvents btnSok As Button
    Friend WithEvents Goopst4DataSetBindingSource As BindingSource
    Friend WithEvents G_oops_t4DataSet As g_oops_t4DataSet
    Friend WithEvents PersonerBindingSource As BindingSource
    Friend WithEvents PersonerTableAdapter As g_oops_t4DataSetTableAdapters.personerTableAdapter
    Friend WithEvents PersonfornavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonetternavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonepostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersontlfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonpostnrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonpoststedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersontypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonbrukernavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents person_passord As DataGridViewTextBoxColumn
End Class
