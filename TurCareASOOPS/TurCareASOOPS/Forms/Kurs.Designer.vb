<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kurs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRegistrerKurs = New System.Windows.Forms.Button()
        Me.btnLeggTilKursdeltager = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.panelKursLabels = New System.Windows.Forms.Panel()
        Me.dgvKursdeltagere = New System.Windows.Forms.DataGridView()
        Me.DeltagernavnDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeltagertlfDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PameldingkursBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KursDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KursDataSet = New TurCareASOOPS.kursDataSet()
        Me.PameldingkursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelKursTextboxes = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DeltagernavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeltagertlfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KursidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbVelgKurs = New System.Windows.Forms.ComboBox()
        Me.Pamelding_kursTableAdapter = New TurCareASOOPS.kursDataSetTableAdapters.pamelding_kursTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnVisPameldteKurs = New System.Windows.Forms.Button()
        Me.panelKursLabels.SuspendLayout()
        CType(Me.dgvKursdeltagere, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PameldingkursBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KursDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KursDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PameldingkursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelKursTextboxes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegistrerKurs
        '
        Me.btnRegistrerKurs.Location = New System.Drawing.Point(91, 57)
        Me.btnRegistrerKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistrerKurs.Name = "btnRegistrerKurs"
        Me.btnRegistrerKurs.Size = New System.Drawing.Size(218, 68)
        Me.btnRegistrerKurs.TabIndex = 0
        Me.btnRegistrerKurs.Text = "Registrer nytt kurs"
        Me.btnRegistrerKurs.UseVisualStyleBackColor = True
        '
        'btnLeggTilKursdeltager
        '
        Me.btnLeggTilKursdeltager.Location = New System.Drawing.Point(372, 57)
        Me.btnLeggTilKursdeltager.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeggTilKursdeltager.Name = "btnLeggTilKursdeltager"
        Me.btnLeggTilKursdeltager.Size = New System.Drawing.Size(218, 68)
        Me.btnLeggTilKursdeltager.TabIndex = 1
        Me.btnLeggTilKursdeltager.Text = "Legg til kursdeltagere"
        Me.btnLeggTilKursdeltager.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(310, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(4, 154)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(310, 26)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(4, 225)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(310, 26)
        Me.TextBox3.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(4, 85)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(310, 26)
        Me.DateTimePicker1.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(4, 289)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(310, 26)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(4, 348)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(310, 26)
        Me.TextBox5.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 305)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 363)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(375, 648)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(322, 83)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'panelKursLabels
        '
        Me.panelKursLabels.Controls.Add(Me.Label6)
        Me.panelKursLabels.Controls.Add(Me.Label1)
        Me.panelKursLabels.Controls.Add(Me.Label3)
        Me.panelKursLabels.Controls.Add(Me.Label5)
        Me.panelKursLabels.Controls.Add(Me.Label4)
        Me.panelKursLabels.Controls.Add(Me.Label2)
        Me.panelKursLabels.Location = New System.Drawing.Point(258, 205)
        Me.panelKursLabels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelKursLabels.Name = "panelKursLabels"
        Me.panelKursLabels.Size = New System.Drawing.Size(112, 403)
        Me.panelKursLabels.TabIndex = 9
        '
        'dgvKursdeltagere
        '
        Me.dgvKursdeltagere.AutoGenerateColumns = False
        Me.dgvKursdeltagere.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvKursdeltagere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKursdeltagere.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeltagernavnDataGridViewTextBoxColumn1, Me.DeltagertlfDataGridViewTextBoxColumn1, Me.KursidDataGridViewTextBoxColumn1})
        Me.dgvKursdeltagere.DataSource = Me.PameldingkursBindingSource1
        Me.dgvKursdeltagere.Location = New System.Drawing.Point(1, 208)
        Me.dgvKursdeltagere.Name = "dgvKursdeltagere"
        Me.dgvKursdeltagere.RowTemplate.Height = 28
        Me.dgvKursdeltagere.Size = New System.Drawing.Size(1075, 377)
        Me.dgvKursdeltagere.TabIndex = 14
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
        'PameldingkursBindingSource
        '
        Me.PameldingkursBindingSource.DataMember = "pamelding_kurs"
        Me.PameldingkursBindingSource.DataSource = Me.KursDataSet
        '
        'PanelKursTextboxes
        '
        Me.PanelKursTextboxes.Controls.Add(Me.TextBox5)
        Me.PanelKursTextboxes.Controls.Add(Me.TextBox4)
        Me.PanelKursTextboxes.Controls.Add(Me.TextBox1)
        Me.PanelKursTextboxes.Controls.Add(Me.TextBox3)
        Me.PanelKursTextboxes.Controls.Add(Me.TextBox2)
        Me.PanelKursTextboxes.Controls.Add(Me.DateTimePicker1)
        Me.PanelKursTextboxes.Location = New System.Drawing.Point(375, 211)
        Me.PanelKursTextboxes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelKursTextboxes.Name = "PanelKursTextboxes"
        Me.PanelKursTextboxes.Size = New System.Drawing.Size(362, 397)
        Me.PanelKursTextboxes.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeltagernavnDataGridViewTextBoxColumn, Me.DeltagertlfDataGridViewTextBoxColumn, Me.KursidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PameldingkursBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-8, 208)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 297)
        Me.DataGridView1.TabIndex = 10
        '
        'DeltagernavnDataGridViewTextBoxColumn
        '
        Me.DeltagernavnDataGridViewTextBoxColumn.DataPropertyName = "deltager_navn"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DeltagernavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DeltagernavnDataGridViewTextBoxColumn.HeaderText = "Navn"
        Me.DeltagernavnDataGridViewTextBoxColumn.Name = "DeltagernavnDataGridViewTextBoxColumn"
        '
        'DeltagertlfDataGridViewTextBoxColumn
        '
        Me.DeltagertlfDataGridViewTextBoxColumn.DataPropertyName = "deltager_tlf"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DeltagertlfDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DeltagertlfDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.DeltagertlfDataGridViewTextBoxColumn.Name = "DeltagertlfDataGridViewTextBoxColumn"
        '
        'KursidDataGridViewTextBoxColumn
        '
        Me.KursidDataGridViewTextBoxColumn.DataPropertyName = "kurs_id"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.KursidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.KursidDataGridViewTextBoxColumn.HeaderText = "Kurs ID"
        Me.KursidDataGridViewTextBoxColumn.Name = "KursidDataGridViewTextBoxColumn"
        '
        'cmbVelgKurs
        '
        Me.cmbVelgKurs.FormattingEnabled = True
        Me.cmbVelgKurs.Location = New System.Drawing.Point(372, 152)
        Me.cmbVelgKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbVelgKurs.Name = "cmbVelgKurs"
        Me.cmbVelgKurs.Size = New System.Drawing.Size(318, 28)
        Me.cmbVelgKurs.TabIndex = 11
        Me.cmbVelgKurs.Text = "Velg kurs fra listen"
        '
        'Pamelding_kursTableAdapter
        '
        Me.Pamelding_kursTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(375, 618)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(322, 83)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnVisPameldteKurs
        '
        Me.btnVisPameldteKurs.Location = New System.Drawing.Point(661, 57)
        Me.btnVisPameldteKurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVisPameldteKurs.Name = "btnVisPameldteKurs"
        Me.btnVisPameldteKurs.Size = New System.Drawing.Size(218, 68)
        Me.btnVisPameldteKurs.TabIndex = 13
        Me.btnVisPameldteKurs.Text = "Vis påmeldte "
        Me.btnVisPameldteKurs.UseVisualStyleBackColor = True
        '
        'Kurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 1000)
        Me.Controls.Add(Me.dgvKursdeltagere)
        Me.Controls.Add(Me.btnVisPameldteKurs)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmbVelgKurs)
        Me.Controls.Add(Me.PanelKursTextboxes)
        Me.Controls.Add(Me.panelKursLabels)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnLeggTilKursdeltager)
        Me.Controls.Add(Me.btnRegistrerKurs)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Kurs"
        Me.Text = "Kurs"
        Me.panelKursLabels.ResumeLayout(False)
        Me.panelKursLabels.PerformLayout()
        CType(Me.dgvKursdeltagere, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PameldingkursBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KursDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KursDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PameldingkursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelKursTextboxes.ResumeLayout(False)
        Me.PanelKursTextboxes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegistrerKurs As Button
    Friend WithEvents btnLeggTilKursdeltager As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents panelKursLabels As Panel
    Friend WithEvents PanelKursTextboxes As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbVelgKurs As ComboBox
    Friend WithEvents KursDataSet As kursDataSet
    Friend WithEvents PameldingkursBindingSource As BindingSource
    Friend WithEvents Pamelding_kursTableAdapter As kursDataSetTableAdapters.pamelding_kursTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents DeltagernavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeltagertlfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KursidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnVisPameldteKurs As Button
    Friend WithEvents dgvKursdeltagere As DataGridView
    Friend WithEvents DeltagernavnDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DeltagertlfDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KursidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PameldingkursBindingSource1 As BindingSource
    Friend WithEvents KursDataSetBindingSource As BindingSource
End Class
