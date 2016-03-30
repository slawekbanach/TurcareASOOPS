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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSoek = New System.Windows.Forms.TextBox()
        Me.btnSok = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "List ut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(12, 388)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 2
        Me.btnTilbake.Text = "Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(606, 317)
        Me.DataGridView1.TabIndex = 3
        '
        'txtSoek
        '
        Me.txtSoek.Location = New System.Drawing.Point(470, 322)
        Me.txtSoek.Name = "txtSoek"
        Me.txtSoek.Size = New System.Drawing.Size(100, 20)
        Me.txtSoek.TabIndex = 4
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(470, 349)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(75, 23)
        Me.btnSok.TabIndex = 5
        Me.btnSok.Text = "Button2"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'ListUtAnsatte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 423)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.txtSoek)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ListUtAnsatte"
        Me.Text = "ListUtAnsatte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSoek As TextBox
    Friend WithEvents btnSok As Button
End Class
