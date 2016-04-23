<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SjekkLager
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
        Me.txtsoek = New System.Windows.Forms.TextBox()
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
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnListUt = New System.Windows.Forms.Button()
        Me.btnLagreLager = New System.Windows.Forms.Button()
        Me.VareTableAdapter = New TurCareASOOPS.OppdatertDatasetTableAdapters.vareTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsoek
        '
        Me.txtsoek.Location = New System.Drawing.Point(854, 594)
        Me.txtsoek.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsoek.Name = "txtsoek"
        Me.txtsoek.Size = New System.Drawing.Size(148, 26)
        Me.txtsoek.TabIndex = 9
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1161, 508)
        Me.DataGridView1.TabIndex = 8
        '
        'VarenavnDataGridViewTextBoxColumn
        '
        Me.VarenavnDataGridViewTextBoxColumn.DataPropertyName = "vare_navn"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarenavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.VarenavnDataGridViewTextBoxColumn.HeaderText = "Varenavn"
        Me.VarenavnDataGridViewTextBoxColumn.Name = "VarenavnDataGridViewTextBoxColumn"
        '
        'VaresalgutleieDataGridViewTextBoxColumn
        '
        Me.VaresalgutleieDataGridViewTextBoxColumn.DataPropertyName = "vare_salg_utleie"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaresalgutleieDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.VaresalgutleieDataGridViewTextBoxColumn.HeaderText = "Salg/Utleie"
        Me.VaresalgutleieDataGridViewTextBoxColumn.Name = "VaresalgutleieDataGridViewTextBoxColumn"
        '
        'VaretilstandDataGridViewTextBoxColumn
        '
        Me.VaretilstandDataGridViewTextBoxColumn.DataPropertyName = "vare_tilstand"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilstandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.VaretilstandDataGridViewTextBoxColumn.HeaderText = "Tilstand"
        Me.VaretilstandDataGridViewTextBoxColumn.Name = "VaretilstandDataGridViewTextBoxColumn"
        '
        'VareprisDataGridViewTextBoxColumn
        '
        Me.VareprisDataGridViewTextBoxColumn.DataPropertyName = "vare_pris"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareprisDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.VareprisDataGridViewTextBoxColumn.HeaderText = "Enhetspris/Pris per døgn"
        Me.VareprisDataGridViewTextBoxColumn.Name = "VareprisDataGridViewTextBoxColumn"
        '
        'VaretilbudDataGridViewTextBoxColumn
        '
        Me.VaretilbudDataGridViewTextBoxColumn.DataPropertyName = "vare_tilbud"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilbudDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.VaretilbudDataGridViewTextBoxColumn.HeaderText = "Tilbud"
        Me.VaretilbudDataGridViewTextBoxColumn.Name = "VaretilbudDataGridViewTextBoxColumn"
        '
        'VarestatusDataGridViewTextBoxColumn
        '
        Me.VarestatusDataGridViewTextBoxColumn.DataPropertyName = "vare_status"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarestatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.VarestatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.VarestatusDataGridViewTextBoxColumn.Name = "VarestatusDataGridViewTextBoxColumn"
        '
        'VareantallDataGridViewTextBoxColumn
        '
        Me.VareantallDataGridViewTextBoxColumn.DataPropertyName = "vare_antall"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareantallDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
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
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(32, 610)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(112, 35)
        Me.btnTilbake.TabIndex = 7
        Me.btnTilbake.Text = "<- Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(854, 548)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(112, 35)
        Me.btnSok.TabIndex = 6
        Me.btnSok.Text = "Søk på vare"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnListUt
        '
        Me.btnListUt.Location = New System.Drawing.Point(30, 536)
        Me.btnListUt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUt.Name = "btnListUt"
        Me.btnListUt.Size = New System.Drawing.Size(208, 35)
        Me.btnListUt.TabIndex = 5
        Me.btnListUt.Text = "List ut alle varer"
        Me.btnListUt.UseVisualStyleBackColor = True
        '
        'btnLagreLager
        '
        Me.btnLagreLager.Location = New System.Drawing.Point(263, 536)
        Me.btnLagreLager.Name = "btnLagreLager"
        Me.btnLagreLager.Size = New System.Drawing.Size(172, 35)
        Me.btnLagreLager.TabIndex = 10
        Me.btnLagreLager.Text = "Oppdater/lagre"
        Me.btnLagreLager.UseVisualStyleBackColor = True
        '
        'VareTableAdapter
        '
        Me.VareTableAdapter.ClearBeforeFill = True
        '
        'SjekkLager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 662)
        Me.Controls.Add(Me.btnLagreLager)
        Me.Controls.Add(Me.txtsoek)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.btnListUt)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SjekkLager"
        Me.Text = "SjekkLager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsoek As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnSok As Button
    Friend WithEvents btnListUt As Button
    Friend WithEvents btnLagreLager As Button
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents VareBindingSource As BindingSource
    Friend WithEvents VarenavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaresalgutleieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilstandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareprisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilbudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarestatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareantallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
