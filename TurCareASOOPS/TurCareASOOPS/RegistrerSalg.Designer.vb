<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrerSalg
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
        Me.txtSelger = New System.Windows.Forms.TextBox()
        Me.txtKunde = New System.Windows.Forms.TextBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.txtVare = New System.Windows.Forms.TextBox()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.btnRegistrerSalg = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnVarer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pris = New System.Windows.Forms.Label()
        Me.txtAntall = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKunder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSelger
        '
        Me.txtSelger.Location = New System.Drawing.Point(154, 67)
        Me.txtSelger.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSelger.Name = "txtSelger"
        Me.txtSelger.Size = New System.Drawing.Size(122, 20)
        Me.txtSelger.TabIndex = 0
        '
        'txtKunde
        '
        Me.txtKunde.Location = New System.Drawing.Point(154, 103)
        Me.txtKunde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKunde.Name = "txtKunde"
        Me.txtKunde.Size = New System.Drawing.Size(122, 20)
        Me.txtKunde.TabIndex = 1
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(154, 140)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(122, 20)
        Me.txtDato.TabIndex = 2
        '
        'txtVare
        '
        Me.txtVare.Location = New System.Drawing.Point(154, 177)
        Me.txtVare.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVare.Name = "txtVare"
        Me.txtVare.Size = New System.Drawing.Size(122, 20)
        Me.txtVare.TabIndex = 3
        '
        'txtPris
        '
        Me.txtPris.Location = New System.Drawing.Point(154, 247)
        Me.txtPris.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPris.Name = "txtPris"
        Me.txtPris.Size = New System.Drawing.Size(122, 20)
        Me.txtPris.TabIndex = 4
        '
        'btnRegistrerSalg
        '
        Me.btnRegistrerSalg.Location = New System.Drawing.Point(154, 281)
        Me.btnRegistrerSalg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegistrerSalg.Name = "btnRegistrerSalg"
        Me.btnRegistrerSalg.Size = New System.Drawing.Size(121, 28)
        Me.btnRegistrerSalg.TabIndex = 5
        Me.btnRegistrerSalg.Text = "Registrer Salg"
        Me.btnRegistrerSalg.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 353)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "<- Tilbake"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnVarer
        '
        Me.btnVarer.Location = New System.Drawing.Point(119, 353)
        Me.btnVarer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVarer.Name = "btnVarer"
        Me.btnVarer.Size = New System.Drawing.Size(123, 31)
        Me.btnVarer.TabIndex = 7
        Me.btnVarer.Text = "Oversikt over varer"
        Me.btnVarer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Selger"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kunde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Salgsdato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Vare"
        '
        'Pris
        '
        Me.Pris.AutoSize = True
        Me.Pris.Location = New System.Drawing.Point(82, 250)
        Me.Pris.Name = "Pris"
        Me.Pris.Size = New System.Drawing.Size(24, 13)
        Me.Pris.TabIndex = 12
        Me.Pris.Text = "Pris"
        '
        'txtAntall
        '
        Me.txtAntall.Location = New System.Drawing.Point(154, 211)
        Me.txtAntall.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAntall.Name = "txtAntall"
        Me.txtAntall.Size = New System.Drawing.Size(122, 20)
        Me.txtAntall.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Antall"
        '
        'btnKunder
        '
        Me.btnKunder.Location = New System.Drawing.Point(269, 353)
        Me.btnKunder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKunder.Name = "btnKunder"
        Me.btnKunder.Size = New System.Drawing.Size(123, 31)
        Me.btnKunder.TabIndex = 15
        Me.btnKunder.Text = "Oversikt over kunder"
        Me.btnKunder.UseVisualStyleBackColor = True
        '
        'RegistrerSalg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 395)
        Me.Controls.Add(Me.btnKunder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAntall)
        Me.Controls.Add(Me.Pris)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVarer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRegistrerSalg)
        Me.Controls.Add(Me.txtPris)
        Me.Controls.Add(Me.txtVare)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.txtKunde)
        Me.Controls.Add(Me.txtSelger)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RegistrerSalg"
        Me.Text = "RegistrerSalg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSelger As TextBox
    Friend WithEvents txtKunde As TextBox
    Friend WithEvents txtDato As TextBox
    Friend WithEvents txtVare As TextBox
    Friend WithEvents txtPris As TextBox
    Friend WithEvents btnRegistrerSalg As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnVarer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Pris As Label
    Friend WithEvents txtAntall As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKunder As Button
End Class
