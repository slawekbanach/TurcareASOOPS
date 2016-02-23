<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrerBruker
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRegistrerbrukernavn = New System.Windows.Forms.TextBox()
        Me.txtregistrerpw = New System.Windows.Forms.TextBox()
        Me.txtgjentapw = New System.Windows.Forms.TextBox()
        Me.ComboAnsattype = New System.Windows.Forms.ComboBox()
        Me.btnRegistrerBruker = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrer en ny bruker:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brukernavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Passord"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gjenta passord"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ansatt-type"
        '
        'txtRegistrerbrukernavn
        '
        Me.txtRegistrerbrukernavn.Location = New System.Drawing.Point(153, 79)
        Me.txtRegistrerbrukernavn.Name = "txtRegistrerbrukernavn"
        Me.txtRegistrerbrukernavn.Size = New System.Drawing.Size(122, 20)
        Me.txtRegistrerbrukernavn.TabIndex = 5
        '
        'txtregistrerpw
        '
        Me.txtregistrerpw.Location = New System.Drawing.Point(153, 117)
        Me.txtregistrerpw.Name = "txtregistrerpw"
        Me.txtregistrerpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregistrerpw.Size = New System.Drawing.Size(122, 20)
        Me.txtregistrerpw.TabIndex = 6
        '
        'txtgjentapw
        '
        Me.txtgjentapw.Location = New System.Drawing.Point(153, 158)
        Me.txtgjentapw.Name = "txtgjentapw"
        Me.txtgjentapw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtgjentapw.Size = New System.Drawing.Size(122, 20)
        Me.txtgjentapw.TabIndex = 7
        '
        'ComboAnsattype
        '
        Me.ComboAnsattype.FormattingEnabled = True
        Me.ComboAnsattype.Items.AddRange(New Object() {"Selger", "Lagerarbeider", "Kursleder", "Daglig leder ", "Sekretær", "admin"})
        Me.ComboAnsattype.Location = New System.Drawing.Point(153, 198)
        Me.ComboAnsattype.Name = "ComboAnsattype"
        Me.ComboAnsattype.Size = New System.Drawing.Size(121, 21)
        Me.ComboAnsattype.TabIndex = 8
        '
        'btnRegistrerBruker
        '
        Me.btnRegistrerBruker.Location = New System.Drawing.Point(153, 240)
        Me.btnRegistrerBruker.Name = "btnRegistrerBruker"
        Me.btnRegistrerBruker.Size = New System.Drawing.Size(122, 23)
        Me.btnRegistrerBruker.TabIndex = 9
        Me.btnRegistrerBruker.Text = "Registrer ny bruker"
        Me.btnRegistrerBruker.UseVisualStyleBackColor = True
        '
        'RegistrerBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 296)
        Me.Controls.Add(Me.btnRegistrerBruker)
        Me.Controls.Add(Me.ComboAnsattype)
        Me.Controls.Add(Me.txtgjentapw)
        Me.Controls.Add(Me.txtregistrerpw)
        Me.Controls.Add(Me.txtRegistrerbrukernavn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrerBruker"
        Me.Text = "RegistrerBruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRegistrerbrukernavn As TextBox
    Friend WithEvents txtregistrerpw As TextBox
    Friend WithEvents txtgjentapw As TextBox
    Friend WithEvents ComboAnsattype As ComboBox
    Friend WithEvents btnRegistrerBruker As Button
End Class
