<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginUser
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAnsattlogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnsattpassord = New System.Windows.Forms.TextBox()
        Me.txtAnsattbrukernavn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Innlogging for ansatte"
        '
        'btnAnsattlogin
        '
        Me.btnAnsattlogin.Location = New System.Drawing.Point(218, 257)
        Me.btnAnsattlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnsattlogin.Name = "btnAnsattlogin"
        Me.btnAnsattlogin.Size = New System.Drawing.Size(198, 46)
        Me.btnAnsattlogin.TabIndex = 15
        Me.btnAnsattlogin.Text = "Logg inn som ansatt"
        Me.btnAnsattlogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 195)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Passord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ansatt-brukernavn"
        '
        'txtAnsattpassord
        '
        Me.txtAnsattpassord.Location = New System.Drawing.Point(218, 191)
        Me.txtAnsattpassord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnsattpassord.Name = "txtAnsattpassord"
        Me.txtAnsattpassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAnsattpassord.Size = New System.Drawing.Size(196, 26)
        Me.txtAnsattpassord.TabIndex = 12
        Me.txtAnsattpassord.Text = "123"
        '
        'txtAnsattbrukernavn
        '
        Me.txtAnsattbrukernavn.Location = New System.Drawing.Point(218, 128)
        Me.txtAnsattbrukernavn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnsattbrukernavn.Name = "txtAnsattbrukernavn"
        Me.txtAnsattbrukernavn.Size = New System.Drawing.Size(196, 26)
        Me.txtAnsattbrukernavn.TabIndex = 11
        Me.txtAnsattbrukernavn.Text = "admin"
        '
        'LoginUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 402)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAnsattlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnsattpassord)
        Me.Controls.Add(Me.txtAnsattbrukernavn)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnAnsattlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnsattpassord As TextBox
    Friend WithEvents txtAnsattbrukernavn As TextBox
End Class
