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
        Me.salgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvStatistikk = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAntallSalgStatistikk = New System.Windows.Forms.Button()
        Me.btnSalgPrSelgerStatistikk = New System.Windows.Forms.Button()
        Me.btnAntallUtleieStatistikk = New System.Windows.Forms.Button()
        Me.btnUtleiePrSelgerStatistikk = New System.Windows.Forms.Button()
        Me.btnSalgInntektStatistikk = New System.Windows.Forms.Button()
        Me.btnUtleieInntektStatistikk = New System.Windows.Forms.Button()
        Me.btnTotalInntektStatistikk = New System.Windows.Forms.Button()
        Me.btnVarePopularStatistikk = New System.Windows.Forms.Button()
        CType(Me.salgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStatistikk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salgBindingSource
        '
        Me.salgBindingSource.DataMember = "salg"
        '
        'dgvStatistikk
        '
        Me.dgvStatistikk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatistikk.Location = New System.Drawing.Point(3, 0)
        Me.dgvStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvStatistikk.Name = "dgvStatistikk"
        Me.dgvStatistikk.Size = New System.Drawing.Size(1054, 389)
        Me.dgvStatistikk.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 517)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tilbake"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAntallSalgStatistikk
        '
        Me.btnAntallSalgStatistikk.Location = New System.Drawing.Point(18, 397)
        Me.btnAntallSalgStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAntallSalgStatistikk.Name = "btnAntallSalgStatistikk"
        Me.btnAntallSalgStatistikk.Size = New System.Drawing.Size(112, 68)
        Me.btnAntallSalgStatistikk.TabIndex = 2
        Me.btnAntallSalgStatistikk.Text = "Hvor mange salg"
        Me.btnAntallSalgStatistikk.UseVisualStyleBackColor = True
        '
        'btnSalgPrSelgerStatistikk
        '
        Me.btnSalgPrSelgerStatistikk.Location = New System.Drawing.Point(140, 397)
        Me.btnSalgPrSelgerStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalgPrSelgerStatistikk.Name = "btnSalgPrSelgerStatistikk"
        Me.btnSalgPrSelgerStatistikk.Size = New System.Drawing.Size(112, 68)
        Me.btnSalgPrSelgerStatistikk.TabIndex = 3
        Me.btnSalgPrSelgerStatistikk.Text = "Salg pr Selger"
        Me.btnSalgPrSelgerStatistikk.UseVisualStyleBackColor = True
        '
        'btnAntallUtleieStatistikk
        '
        Me.btnAntallUtleieStatistikk.Location = New System.Drawing.Point(261, 398)
        Me.btnAntallUtleieStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAntallUtleieStatistikk.Name = "btnAntallUtleieStatistikk"
        Me.btnAntallUtleieStatistikk.Size = New System.Drawing.Size(112, 66)
        Me.btnAntallUtleieStatistikk.TabIndex = 4
        Me.btnAntallUtleieStatistikk.Text = "Hvor mange utleie"
        Me.btnAntallUtleieStatistikk.UseVisualStyleBackColor = True
        '
        'btnUtleiePrSelgerStatistikk
        '
        Me.btnUtleiePrSelgerStatistikk.Location = New System.Drawing.Point(382, 397)
        Me.btnUtleiePrSelgerStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUtleiePrSelgerStatistikk.Name = "btnUtleiePrSelgerStatistikk"
        Me.btnUtleiePrSelgerStatistikk.Size = New System.Drawing.Size(112, 66)
        Me.btnUtleiePrSelgerStatistikk.TabIndex = 5
        Me.btnUtleiePrSelgerStatistikk.Text = "Utleie pr Selger"
        Me.btnUtleiePrSelgerStatistikk.UseVisualStyleBackColor = True
        '
        'btnSalgInntektStatistikk
        '
        Me.btnSalgInntektStatistikk.Location = New System.Drawing.Point(507, 397)
        Me.btnSalgInntektStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalgInntektStatistikk.Name = "btnSalgInntektStatistikk"
        Me.btnSalgInntektStatistikk.Size = New System.Drawing.Size(112, 65)
        Me.btnSalgInntektStatistikk.TabIndex = 6
        Me.btnSalgInntektStatistikk.Text = "Salg Inntekt"
        Me.btnSalgInntektStatistikk.UseVisualStyleBackColor = True
        '
        'btnUtleieInntektStatistikk
        '
        Me.btnUtleieInntektStatistikk.Location = New System.Drawing.Point(628, 397)
        Me.btnUtleieInntektStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUtleieInntektStatistikk.Name = "btnUtleieInntektStatistikk"
        Me.btnUtleieInntektStatistikk.Size = New System.Drawing.Size(112, 65)
        Me.btnUtleieInntektStatistikk.TabIndex = 7
        Me.btnUtleieInntektStatistikk.Text = "Utleie Inntekt"
        Me.btnUtleieInntektStatistikk.UseVisualStyleBackColor = True
        '
        'btnTotalInntektStatistikk
        '
        Me.btnTotalInntektStatistikk.Location = New System.Drawing.Point(752, 400)
        Me.btnTotalInntektStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTotalInntektStatistikk.Name = "btnTotalInntektStatistikk"
        Me.btnTotalInntektStatistikk.Size = New System.Drawing.Size(112, 62)
        Me.btnTotalInntektStatistikk.TabIndex = 8
        Me.btnTotalInntektStatistikk.Text = "Total Inntekt"
        Me.btnTotalInntektStatistikk.UseVisualStyleBackColor = True
        '
        'btnVarePopularStatistikk
        '
        Me.btnVarePopularStatistikk.Location = New System.Drawing.Point(874, 400)
        Me.btnVarePopularStatistikk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVarePopularStatistikk.Name = "btnVarePopularStatistikk"
        Me.btnVarePopularStatistikk.Size = New System.Drawing.Size(112, 62)
        Me.btnVarePopularStatistikk.TabIndex = 9
        Me.btnVarePopularStatistikk.Text = "Vare Populæritet"
        Me.btnVarePopularStatistikk.UseVisualStyleBackColor = True
        '
        'Statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 571)
        Me.Controls.Add(Me.btnVarePopularStatistikk)
        Me.Controls.Add(Me.btnTotalInntektStatistikk)
        Me.Controls.Add(Me.btnUtleieInntektStatistikk)
        Me.Controls.Add(Me.btnSalgInntektStatistikk)
        Me.Controls.Add(Me.btnUtleiePrSelgerStatistikk)
        Me.Controls.Add(Me.btnAntallUtleieStatistikk)
        Me.Controls.Add(Me.btnSalgPrSelgerStatistikk)
        Me.Controls.Add(Me.btnAntallSalgStatistikk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvStatistikk)
        Me.Name = "Statistikk"
        Me.Text = "Statistikk"
        CType(Me.salgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStatistikk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salgBindingSource As BindingSource
    Friend WithEvents g_oops_t4DataSet As g_oops_t4DataSet
    Friend WithEvents salgTableAdapter As g_oops_t4DataSetTableAdapters.salgTableAdapter
    Friend WithEvents dgvStatistikk As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAntallSalgStatistikk As Button
    Friend WithEvents btnSalgPrSelgerStatistikk As Button
    Friend WithEvents btnAntallUtleieStatistikk As Button
    Friend WithEvents btnUtleiePrSelgerStatistikk As Button
    Friend WithEvents btnSalgInntektStatistikk As Button
    Friend WithEvents btnUtleieInntektStatistikk As Button
    Friend WithEvents btnTotalInntektStatistikk As Button
    Friend WithEvents btnVarePopularStatistikk As Button
End Class
