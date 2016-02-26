<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListUtKunder
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsoek = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(560, 336)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(75, 23)
        Me.btnSok.TabIndex = 1
        Me.btnSok.Text = "Button2"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(13, 384)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 2
        Me.btnTilbake.Text = "Button2"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(684, 330)
        Me.DataGridView1.TabIndex = 3
        '
        'txtsoek
        '
        Me.txtsoek.Location = New System.Drawing.Point(560, 366)
        Me.txtsoek.Name = "txtsoek"
        Me.txtsoek.Size = New System.Drawing.Size(100, 20)
        Me.txtsoek.TabIndex = 4
        '
        'ListUtKunder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 419)
        Me.Controls.Add(Me.txtsoek)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ListUtKunder"
        Me.Text = "ListUtKunder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnSok As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtsoek As TextBox
End Class
