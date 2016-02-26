<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginDB
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
        Me.btnDBlogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDBpassord = New System.Windows.Forms.TextBox()
        Me.txtDBuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDBlogin
        '
        Me.btnDBlogin.Location = New System.Drawing.Point(91, 141)
        Me.btnDBlogin.Name = "btnDBlogin"
        Me.btnDBlogin.Size = New System.Drawing.Size(132, 30)
        Me.btnDBlogin.TabIndex = 9
        Me.btnDBlogin.Text = "Logg inn i databasen"
        Me.btnDBlogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Passord"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Brukernavn"
        '
        'txtDBpassord
        '
        Me.txtDBpassord.Location = New System.Drawing.Point(91, 98)
        Me.txtDBpassord.Name = "txtDBpassord"
        Me.txtDBpassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDBpassord.Size = New System.Drawing.Size(132, 20)
        Me.txtDBpassord.TabIndex = 6
        Me.txtDBpassord.Text = "passord123"
        '
        'txtDBuser
        '
        Me.txtDBuser.Location = New System.Drawing.Point(91, 57)
        Me.txtDBuser.Name = "txtDBuser"
        Me.txtDBuser.Size = New System.Drawing.Size(132, 20)
        Me.txtDBuser.TabIndex = 5
        Me.txtDBuser.Text = "g_oops_t4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tilkobling til databasen"
        '
        'LoginDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 229)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDBlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDBpassord)
        Me.Controls.Add(Me.txtDBuser)
        Me.Name = "LoginDB"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDBlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDBpassord As TextBox
    Friend WithEvents txtDBuser As TextBox
    Friend WithEvents Label3 As Label
End Class
