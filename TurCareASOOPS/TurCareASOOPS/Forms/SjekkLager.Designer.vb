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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtsoek = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.G_oops_t4DataSet = New TurCareASOOPS.g_oops_t4DataSet()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnListUt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VareTableAdapter = New TurCareASOOPS.g_oops_t4DataSetTableAdapters.vareTableAdapter()
        Me.VarenavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaresalgutleieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilstandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareprisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaretilbudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarestatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VareantallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.G_oops_t4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'VareBindingSource
        '
        Me.VareBindingSource.DataMember = "vare"
        Me.VareBindingSource.DataSource = Me.G_oops_t4DataSet
        '
        'G_oops_t4DataSet
        '
        Me.G_oops_t4DataSet.DataSetName = "g_oops_t4DataSet"
        Me.G_oops_t4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(263, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Oppdater/lagre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VareTableAdapter
        '
        Me.VareTableAdapter.ClearBeforeFill = True
        '
        'VarenavnDataGridViewTextBoxColumn
        '
        Me.VarenavnDataGridViewTextBoxColumn.DataPropertyName = "vare_navn"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarenavnDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.VarenavnDataGridViewTextBoxColumn.HeaderText = "Varenavn"
        Me.VarenavnDataGridViewTextBoxColumn.Name = "VarenavnDataGridViewTextBoxColumn"
        '
        'VaresalgutleieDataGridViewTextBoxColumn
        '
        Me.VaresalgutleieDataGridViewTextBoxColumn.DataPropertyName = "vare_salg_utleie"
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaresalgutleieDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.VaresalgutleieDataGridViewTextBoxColumn.HeaderText = "Salg eller Utleie"
        Me.VaresalgutleieDataGridViewTextBoxColumn.Name = "VaresalgutleieDataGridViewTextBoxColumn"
        '
        'VaretilstandDataGridViewTextBoxColumn
        '
        Me.VaretilstandDataGridViewTextBoxColumn.DataPropertyName = "vare_tilstand"
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilstandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.VaretilstandDataGridViewTextBoxColumn.HeaderText = "Tilstand"
        Me.VaretilstandDataGridViewTextBoxColumn.Name = "VaretilstandDataGridViewTextBoxColumn"
        '
        'VareprisDataGridViewTextBoxColumn
        '
        Me.VareprisDataGridViewTextBoxColumn.DataPropertyName = "vare_pris"
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VareprisDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.VareprisDataGridViewTextBoxColumn.HeaderText = "Enhetspris"
        Me.VareprisDataGridViewTextBoxColumn.Name = "VareprisDataGridViewTextBoxColumn"
        '
        'VaretilbudDataGridViewTextBoxColumn
        '
        Me.VaretilbudDataGridViewTextBoxColumn.DataPropertyName = "vare_tilbud"
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VaretilbudDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle19
        Me.VaretilbudDataGridViewTextBoxColumn.HeaderText = "Tilbud (desimal) "
        Me.VaretilbudDataGridViewTextBoxColumn.Name = "VaretilbudDataGridViewTextBoxColumn"
        '
        'VarestatusDataGridViewTextBoxColumn
        '
        Me.VarestatusDataGridViewTextBoxColumn.DataPropertyName = "vare_status"
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSkyBlue
        Me.VarestatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle20
        Me.VarestatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.VarestatusDataGridViewTextBoxColumn.Name = "VarestatusDataGridViewTextBoxColumn"
        '
        'VareantallDataGridViewTextBoxColumn
        '
        Me.VareantallDataGridViewTextBoxColumn.DataPropertyName = "vare_antall"
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Transparent
        Me.VareantallDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle21
        Me.VareantallDataGridViewTextBoxColumn.HeaderText = "Antall på lager"
        Me.VareantallDataGridViewTextBoxColumn.Name = "VareantallDataGridViewTextBoxColumn"
        '
        'SjekkLager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 662)
        Me.Controls.Add(Me.Button1)
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
        CType(Me.G_oops_t4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsoek As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnSok As Button
    Friend WithEvents btnListUt As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents G_oops_t4DataSet As g_oops_t4DataSet
    Friend WithEvents VareBindingSource As BindingSource
    Friend WithEvents VareTableAdapter As g_oops_t4DataSetTableAdapters.vareTableAdapter
    Friend WithEvents VarenavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaresalgutleieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilstandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareprisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaretilbudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VarestatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VareantallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
