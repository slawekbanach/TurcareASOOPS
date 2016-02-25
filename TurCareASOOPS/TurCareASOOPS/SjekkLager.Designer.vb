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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoek = New System.Windows.Forms.TextBox()
        Me.btnSoek = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Skriv inn varenavn du vil søke opp"
        '
        'txtSoek
        '
        Me.txtSoek.Location = New System.Drawing.Point(37, 63)
        Me.txtSoek.Name = "txtSoek"
        Me.txtSoek.Size = New System.Drawing.Size(168, 20)
        Me.txtSoek.TabIndex = 1
        '
        'btnSoek
        '
        Me.btnSoek.Location = New System.Drawing.Point(37, 98)
        Me.btnSoek.Name = "btnSoek"
        Me.btnSoek.Size = New System.Drawing.Size(168, 23)
        Me.btnSoek.TabIndex = 2
        Me.btnSoek.Text = "Søk på varen"
        Me.btnSoek.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(237, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(537, 384)
        Me.ListBox1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(74, 137)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(74, 349)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(75, 23)
        Me.btnTilbake.TabIndex = 5
        Me.btnTilbake.Text = "<- Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'SjekkLager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 384)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnSoek)
        Me.Controls.Add(Me.txtSoek)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SjekkLager"
        Me.Text = "SjekkLager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSoek As TextBox
    Friend WithEvents btnSoek As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTilbake As Button
End Class
