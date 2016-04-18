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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnListUtAnsatte = New System.Windows.Forms.Button()
        Me.btnTilbakePerson = New System.Windows.Forms.Button()
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
        Me.PersonerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New TurCareASOOPS.DatabaseDataSet()
        Me.txtSoekPerson = New System.Windows.Forms.TextBox()
        Me.btnSokPerson = New System.Windows.Forms.Button()
        Me.btnLeggTilAnsatt = New System.Windows.Forms.Button()
        Me.btnListUtKunder = New System.Windows.Forms.Button()
        Me.btnLeggTilKunde = New System.Windows.Forms.Button()
        Me.PersonerTableAdapter = New TurCareASOOPS.DatabaseDataSetTableAdapters.personerTableAdapter()
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListUtAnsatte
        '
        Me.btnListUtAnsatte.Location = New System.Drawing.Point(18, 508)
        Me.btnListUtAnsatte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUtAnsatte.Name = "btnListUtAnsatte"
        Me.btnListUtAnsatte.Size = New System.Drawing.Size(138, 35)
        Me.btnListUtAnsatte.TabIndex = 0
        Me.btnListUtAnsatte.Text = "List ut ansatte"
        Me.btnListUtAnsatte.UseVisualStyleBackColor = True
        '
        'btnTilbakePerson
        '
        Me.btnTilbakePerson.Location = New System.Drawing.Point(18, 597)
        Me.btnTilbakePerson.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTilbakePerson.Name = "btnTilbakePerson"
        Me.btnTilbakePerson.Size = New System.Drawing.Size(112, 35)
        Me.btnTilbakePerson.TabIndex = 2
        Me.btnTilbakePerson.Text = "Tilbake"
        Me.btnTilbakePerson.UseVisualStyleBackColor = True
        '
        'dgvPerson
        '
        Me.dgvPerson.AutoGenerateColumns = False
        Me.dgvPerson.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerson.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonfornavnDataGridViewTextBoxColumn, Me.PersonetternavnDataGridViewTextBoxColumn, Me.PersonepostDataGridViewTextBoxColumn, Me.PersontlfDataGridViewTextBoxColumn, Me.PersonadresseDataGridViewTextBoxColumn, Me.PersonpostnrDataGridViewTextBoxColumn, Me.PersonpoststedDataGridViewTextBoxColumn, Me.PersontypeDataGridViewTextBoxColumn, Me.PersonbrukernavnDataGridViewTextBoxColumn, Me.PersonpassordDataGridViewTextBoxColumn})
        Me.dgvPerson.DataSource = Me.PersonerBindingSource
        Me.dgvPerson.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvPerson.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPerson.Location = New System.Drawing.Point(0, 0)
        Me.dgvPerson.Name = "dgvPerson"
        Me.dgvPerson.RowTemplate.Height = 28
        Me.dgvPerson.Size = New System.Drawing.Size(1237, 488)
        Me.dgvPerson.TabIndex = 3
        '
        'PersonfornavnDataGridViewTextBoxColumn
        '
        Me.PersonfornavnDataGridViewTextBoxColumn.DataPropertyName = "person_fornavn"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonfornavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PersonfornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn"
        Me.PersonfornavnDataGridViewTextBoxColumn.Name = "PersonfornavnDataGridViewTextBoxColumn"
        '
        'PersonetternavnDataGridViewTextBoxColumn
        '
        Me.PersonetternavnDataGridViewTextBoxColumn.DataPropertyName = "person_etternavn"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonetternavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PersonetternavnDataGridViewTextBoxColumn.HeaderText = "Etternavn"
        Me.PersonetternavnDataGridViewTextBoxColumn.Name = "PersonetternavnDataGridViewTextBoxColumn"
        '
        'PersonepostDataGridViewTextBoxColumn
        '
        Me.PersonepostDataGridViewTextBoxColumn.DataPropertyName = "person_epost"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonepostDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PersonepostDataGridViewTextBoxColumn.HeaderText = "Epost"
        Me.PersonepostDataGridViewTextBoxColumn.Name = "PersonepostDataGridViewTextBoxColumn"
        '
        'PersontlfDataGridViewTextBoxColumn
        '
        Me.PersontlfDataGridViewTextBoxColumn.DataPropertyName = "person_tlf"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PersontlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.PersontlfDataGridViewTextBoxColumn.Name = "PersontlfDataGridViewTextBoxColumn"
        '
        'PersonadresseDataGridViewTextBoxColumn
        '
        Me.PersonadresseDataGridViewTextBoxColumn.DataPropertyName = "person_adresse"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonadresseDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PersonadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.PersonadresseDataGridViewTextBoxColumn.Name = "PersonadresseDataGridViewTextBoxColumn"
        '
        'PersonpostnrDataGridViewTextBoxColumn
        '
        Me.PersonpostnrDataGridViewTextBoxColumn.DataPropertyName = "person_postnr"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpostnrDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PersonpostnrDataGridViewTextBoxColumn.HeaderText = "Postnummer"
        Me.PersonpostnrDataGridViewTextBoxColumn.Name = "PersonpostnrDataGridViewTextBoxColumn"
        '
        'PersonpoststedDataGridViewTextBoxColumn
        '
        Me.PersonpoststedDataGridViewTextBoxColumn.DataPropertyName = "person_poststed"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpoststedDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PersonpoststedDataGridViewTextBoxColumn.HeaderText = "Poststed"
        Me.PersonpoststedDataGridViewTextBoxColumn.Name = "PersonpoststedDataGridViewTextBoxColumn"
        '
        'PersontypeDataGridViewTextBoxColumn
        '
        Me.PersontypeDataGridViewTextBoxColumn.DataPropertyName = "person_type"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersontypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PersontypeDataGridViewTextBoxColumn.HeaderText = "Ansatt/kunde"
        Me.PersontypeDataGridViewTextBoxColumn.Name = "PersontypeDataGridViewTextBoxColumn"
        '
        'PersonbrukernavnDataGridViewTextBoxColumn
        '
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DataPropertyName = "person_brukernavn"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonbrukernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PersonbrukernavnDataGridViewTextBoxColumn.HeaderText = "Brukernavn - ansatte"
        Me.PersonbrukernavnDataGridViewTextBoxColumn.Name = "PersonbrukernavnDataGridViewTextBoxColumn"
        '
        'PersonpassordDataGridViewTextBoxColumn
        '
        Me.PersonpassordDataGridViewTextBoxColumn.DataPropertyName = "person_passord"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PersonpassordDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.PersonpassordDataGridViewTextBoxColumn.HeaderText = "Passord - ansatte"
        Me.PersonpassordDataGridViewTextBoxColumn.Name = "PersonpassordDataGridViewTextBoxColumn"
        '
        'PersonerBindingSource
        '
        Me.PersonerBindingSource.DataMember = "personer"
        Me.PersonerBindingSource.DataSource = Me.DatabaseDataSetBindingSource
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
        'txtSoekPerson
        '
        Me.txtSoekPerson.Location = New System.Drawing.Point(705, 495)
        Me.txtSoekPerson.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSoekPerson.Name = "txtSoekPerson"
        Me.txtSoekPerson.Size = New System.Drawing.Size(148, 26)
        Me.txtSoekPerson.TabIndex = 4
        '
        'btnSokPerson
        '
        Me.btnSokPerson.Location = New System.Drawing.Point(705, 537)
        Me.btnSokPerson.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSokPerson.Name = "btnSokPerson"
        Me.btnSokPerson.Size = New System.Drawing.Size(112, 35)
        Me.btnSokPerson.TabIndex = 5
        Me.btnSokPerson.Text = "Button2"
        Me.btnSokPerson.UseVisualStyleBackColor = True
        '
        'btnLeggTilAnsatt
        '
        Me.btnLeggTilAnsatt.Location = New System.Drawing.Point(18, 552)
        Me.btnLeggTilAnsatt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilAnsatt.Name = "btnLeggTilAnsatt"
        Me.btnLeggTilAnsatt.Size = New System.Drawing.Size(138, 35)
        Me.btnLeggTilAnsatt.TabIndex = 6
        Me.btnLeggTilAnsatt.Text = "Legg til Ansatt"
        Me.btnLeggTilAnsatt.UseVisualStyleBackColor = True
        '
        'btnListUtKunder
        '
        Me.btnListUtKunder.Location = New System.Drawing.Point(179, 508)
        Me.btnListUtKunder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUtKunder.Name = "btnListUtKunder"
        Me.btnListUtKunder.Size = New System.Drawing.Size(138, 35)
        Me.btnListUtKunder.TabIndex = 7
        Me.btnListUtKunder.Text = "List ut kunder"
        Me.btnListUtKunder.UseVisualStyleBackColor = True
        '
        'btnLeggTilKunde
        '
        Me.btnLeggTilKunde.Location = New System.Drawing.Point(179, 553)
        Me.btnLeggTilKunde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilKunde.Name = "btnLeggTilKunde"
        Me.btnLeggTilKunde.Size = New System.Drawing.Size(138, 35)
        Me.btnLeggTilKunde.TabIndex = 8
        Me.btnLeggTilKunde.Text = "Legg til Kunde"
        Me.btnLeggTilKunde.UseVisualStyleBackColor = True
        '
        'PersonerTableAdapter
        '
        Me.PersonerTableAdapter.ClearBeforeFill = True
        '
        'ListUtAnsatte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 652)
        Me.Controls.Add(Me.btnLeggTilKunde)
        Me.Controls.Add(Me.btnListUtKunder)
        Me.Controls.Add(Me.btnLeggTilAnsatt)
        Me.Controls.Add(Me.btnSokPerson)
        Me.Controls.Add(Me.txtSoekPerson)
        Me.Controls.Add(Me.dgvPerson)
        Me.Controls.Add(Me.btnTilbakePerson)
        Me.Controls.Add(Me.btnListUtAnsatte)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListUtAnsatte"
        Me.Text = "ListUtAnsatte"
        CType(Me.dgvPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListUtAnsatte As Button
    Friend WithEvents btnTilbakePerson As Button
    Friend WithEvents dgvPerson As DataGridView
    Friend WithEvents txtSoekPerson As TextBox
    Friend WithEvents btnSokPerson As Button
    Friend WithEvents btnLeggTilAnsatt As Button
    Friend WithEvents btnListUtKunder As Button
    Friend WithEvents btnLeggTilKunde As Button
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents PersonerTableAdapter1 As g_oops_t4DataSetTableAdapters.personerTableAdapter
    Friend WithEvents PersonerBindingSource As BindingSource
    Friend WithEvents PersonerTableAdapter As DatabaseDataSetTableAdapters.personerTableAdapter
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
End Class
