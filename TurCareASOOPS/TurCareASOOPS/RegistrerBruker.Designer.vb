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
        Me.lblBrukernavn = New System.Windows.Forms.Label()
        Me.lblPw = New System.Windows.Forms.Label()
        Me.lblGjentaPW = New System.Windows.Forms.Label()
        Me.txtBrukernavn = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.txtGjentaPw = New System.Windows.Forms.TextBox()
        Me.btnRegistrerBruker = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.TxtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtEpost = New System.Windows.Forms.TextBox()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtPostNr = New System.Windows.Forms.TextBox()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.lblNavn = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPostnr = New System.Windows.Forms.Label()
        Me.lblPoststed = New System.Windows.Forms.Label()
        Me.radioAnsatt = New System.Windows.Forms.RadioButton()
        Me.radioKunde = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrer ny person i databasen"
        '
        'lblBrukernavn
        '
        Me.lblBrukernavn.AutoSize = True
        Me.lblBrukernavn.Location = New System.Drawing.Point(42, 381)
        Me.lblBrukernavn.Name = "lblBrukernavn"
        Me.lblBrukernavn.Size = New System.Drawing.Size(62, 13)
        Me.lblBrukernavn.TabIndex = 1
        Me.lblBrukernavn.Text = "Brukernavn"
        '
        'lblPw
        '
        Me.lblPw.AutoSize = True
        Me.lblPw.Location = New System.Drawing.Point(45, 419)
        Me.lblPw.Name = "lblPw"
        Me.lblPw.Size = New System.Drawing.Size(45, 13)
        Me.lblPw.TabIndex = 2
        Me.lblPw.Text = "Passord"
        '
        'lblGjentaPW
        '
        Me.lblGjentaPW.AutoSize = True
        Me.lblGjentaPW.Location = New System.Drawing.Point(42, 460)
        Me.lblGjentaPW.Name = "lblGjentaPW"
        Me.lblGjentaPW.Size = New System.Drawing.Size(78, 13)
        Me.lblGjentaPW.TabIndex = 3
        Me.lblGjentaPW.Text = "Gjenta passord"
        '
        'txtBrukernavn
        '
        Me.txtBrukernavn.Location = New System.Drawing.Point(153, 378)
        Me.txtBrukernavn.Name = "txtBrukernavn"
        Me.txtBrukernavn.Size = New System.Drawing.Size(122, 20)
        Me.txtBrukernavn.TabIndex = 5
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(153, 416)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(122, 20)
        Me.txtPW.TabIndex = 6
        '
        'txtGjentaPw
        '
        Me.txtGjentaPw.Location = New System.Drawing.Point(153, 457)
        Me.txtGjentaPw.Name = "txtGjentaPw"
        Me.txtGjentaPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtGjentaPw.Size = New System.Drawing.Size(122, 20)
        Me.txtGjentaPw.TabIndex = 7
        '
        'btnRegistrerBruker
        '
        Me.btnRegistrerBruker.Location = New System.Drawing.Point(155, 526)
        Me.btnRegistrerBruker.Name = "btnRegistrerBruker"
        Me.btnRegistrerBruker.Size = New System.Drawing.Size(122, 23)
        Me.btnRegistrerBruker.TabIndex = 9
        Me.btnRegistrerBruker.Text = "Registrer ny bruker"
        Me.btnRegistrerBruker.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = " <- Gå tilbake"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(154, 56)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(122, 20)
        Me.txtFornavn.TabIndex = 11
        '
        'TxtEtternavn
        '
        Me.TxtEtternavn.Location = New System.Drawing.Point(155, 93)
        Me.TxtEtternavn.Name = "TxtEtternavn"
        Me.TxtEtternavn.Size = New System.Drawing.Size(122, 20)
        Me.TxtEtternavn.TabIndex = 12
        '
        'txtEpost
        '
        Me.txtEpost.Location = New System.Drawing.Point(154, 131)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(122, 20)
        Me.txtEpost.TabIndex = 13
        '
        'txtTlf
        '
        Me.txtTlf.Location = New System.Drawing.Point(155, 175)
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(122, 20)
        Me.txtTlf.TabIndex = 14
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(154, 217)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(122, 20)
        Me.txtAdresse.TabIndex = 15
        '
        'txtPostNr
        '
        Me.txtPostNr.Location = New System.Drawing.Point(154, 259)
        Me.txtPostNr.Name = "txtPostNr"
        Me.txtPostNr.Size = New System.Drawing.Size(122, 20)
        Me.txtPostNr.TabIndex = 16
        '
        'txtPoststed
        '
        Me.txtPoststed.Location = New System.Drawing.Point(154, 295)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.Size = New System.Drawing.Size(122, 20)
        Me.txtPoststed.TabIndex = 17
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Location = New System.Drawing.Point(42, 178)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(43, 13)
        Me.lblTlf.TabIndex = 21
        Me.lblTlf.Text = "Telefon"
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(42, 134)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(37, 13)
        Me.lblEpost.TabIndex = 20
        Me.lblEpost.Text = "E-post"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(42, 96)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 19
        Me.lblEtternavn.Text = "Etternavn"
        '
        'lblNavn
        '
        Me.lblNavn.AutoSize = True
        Me.lblNavn.Location = New System.Drawing.Point(42, 59)
        Me.lblNavn.Name = "lblNavn"
        Me.lblNavn.Size = New System.Drawing.Size(46, 13)
        Me.lblNavn.TabIndex = 18
        Me.lblNavn.Text = "Fornavn"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(42, 220)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 22
        Me.lblAdresse.Text = "Adresse"
        '
        'lblPostnr
        '
        Me.lblPostnr.AutoSize = True
        Me.lblPostnr.Location = New System.Drawing.Point(42, 262)
        Me.lblPostnr.Name = "lblPostnr"
        Me.lblPostnr.Size = New System.Drawing.Size(65, 13)
        Me.lblPostnr.TabIndex = 23
        Me.lblPostnr.Text = "Postnummer"
        '
        'lblPoststed
        '
        Me.lblPoststed.AutoSize = True
        Me.lblPoststed.Location = New System.Drawing.Point(44, 298)
        Me.lblPoststed.Name = "lblPoststed"
        Me.lblPoststed.Size = New System.Drawing.Size(48, 13)
        Me.lblPoststed.TabIndex = 24
        Me.lblPoststed.Text = "Poststed"
        '
        'radioAnsatt
        '
        Me.radioAnsatt.AutoSize = True
        Me.radioAnsatt.Location = New System.Drawing.Point(154, 335)
        Me.radioAnsatt.Name = "radioAnsatt"
        Me.radioAnsatt.Size = New System.Drawing.Size(55, 17)
        Me.radioAnsatt.TabIndex = 25
        Me.radioAnsatt.TabStop = True
        Me.radioAnsatt.Text = "Ansatt"
        Me.radioAnsatt.UseVisualStyleBackColor = True
        '
        'radioKunde
        '
        Me.radioKunde.AutoSize = True
        Me.radioKunde.Location = New System.Drawing.Point(222, 335)
        Me.radioKunde.Name = "radioKunde"
        Me.radioKunde.Size = New System.Drawing.Size(56, 17)
        Me.radioKunde.TabIndex = 26
        Me.radioKunde.TabStop = True
        Me.radioKunde.Text = "Kunde"
        Me.radioKunde.UseVisualStyleBackColor = True
        '
        'RegistrerBruker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 622)
        Me.Controls.Add(Me.radioKunde)
        Me.Controls.Add(Me.radioAnsatt)
        Me.Controls.Add(Me.lblPoststed)
        Me.Controls.Add(Me.lblPostnr)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblTlf)
        Me.Controls.Add(Me.lblEpost)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblNavn)
        Me.Controls.Add(Me.txtPoststed)
        Me.Controls.Add(Me.txtPostNr)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtTlf)
        Me.Controls.Add(Me.txtEpost)
        Me.Controls.Add(Me.TxtEtternavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRegistrerBruker)
        Me.Controls.Add(Me.txtGjentaPw)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtBrukernavn)
        Me.Controls.Add(Me.lblGjentaPW)
        Me.Controls.Add(Me.lblPw)
        Me.Controls.Add(Me.lblBrukernavn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrerBruker"
        Me.Text = "RegistrerBruker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBrukernavn As Label
    Friend WithEvents lblPw As Label
    Friend WithEvents lblGjentaPW As Label
    Friend WithEvents txtBrukernavn As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtGjentaPw As TextBox
    Friend WithEvents btnRegistrerBruker As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents TxtEtternavn As TextBox
    Friend WithEvents txtEpost As TextBox
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtPostNr As TextBox
    Friend WithEvents txtPoststed As TextBox
    Friend WithEvents lblTlf As Label
    Friend WithEvents lblEpost As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents lblNavn As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblPostnr As Label
    Friend WithEvents lblPoststed As Label
    Friend WithEvents radioAnsatt As RadioButton
    Friend WithEvents radioKunde As RadioButton
End Class
