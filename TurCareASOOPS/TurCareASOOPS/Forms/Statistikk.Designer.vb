<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistikk
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.salgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.g_oops_t4DataSet = New TurCareASOOPS.g_oops_t4DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.salgTableAdapter = New TurCareASOOPS.g_oops_t4DataSetTableAdapters.salgTableAdapter()
        CType(Me.salgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.g_oops_t4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salgBindingSource
        '
        Me.salgBindingSource.DataMember = "salg"
        Me.salgBindingSource.DataSource = Me.g_oops_t4DataSet
        '
        'g_oops_t4DataSet
        '
        Me.g_oops_t4DataSet.DataSetName = "g_oops_t4DataSet"
        Me.g_oops_t4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Salgsrapport"
        ReportDataSource1.Value = Me.salgBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TurCareASOOPS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1059, 477)
        Me.ReportViewer1.TabIndex = 0
        '
        'salgTableAdapter
        '
        Me.salgTableAdapter.ClearBeforeFill = True
        '
        'Statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 477)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Statistikk"
        Me.Text = "Statistikk"
        CType(Me.salgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.g_oops_t4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents salgBindingSource As BindingSource
    Friend WithEvents g_oops_t4DataSet As g_oops_t4DataSet
    Friend WithEvents salgTableAdapter As g_oops_t4DataSetTableAdapters.salgTableAdapter
End Class
