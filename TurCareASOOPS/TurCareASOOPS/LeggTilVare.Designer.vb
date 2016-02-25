<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeggTilVare
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
        Me.txtVarenavn = New System.Windows.Forms.TextBox()
        Me.txtVarepris = New System.Windows.Forms.TextBox()
        Me.txtVaretilbud = New System.Windows.Forms.TextBox()
        Me.txtVareantall = New System.Windows.Forms.TextBox()
        Me.cmbSalgutleie = New System.Windows.Forms.ComboBox()
        Me.cmbVaretilstand = New System.Windows.Forms.ComboBox()
        Me.cmbVarestatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLeggTilVare = New System.Windows.Forms.Button()
        Me.btntilbake = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVarenavn
        '
        Me.txtVarenavn.Location = New System.Drawing.Point(216, 79)
        Me.txtVarenavn.Name = "txtVarenavn"
        Me.txtVarenavn.Size = New System.Drawing.Size(171, 20)
        Me.txtVarenavn.TabIndex = 0
        '
        'txtVarepris
        '
        Me.txtVarepris.Location = New System.Drawing.Point(216, 199)
        Me.txtVarepris.Name = "txtVarepris"
        Me.txtVarepris.Size = New System.Drawing.Size(171, 20)
        Me.txtVarepris.TabIndex = 1
        '
        'txtVaretilbud
        '
        Me.txtVaretilbud.Location = New System.Drawing.Point(216, 239)
        Me.txtVaretilbud.Name = "txtVaretilbud"
        Me.txtVaretilbud.Size = New System.Drawing.Size(171, 20)
        Me.txtVaretilbud.TabIndex = 2
        '
        'txtVareantall
        '
        Me.txtVareantall.Location = New System.Drawing.Point(216, 323)
        Me.txtVareantall.Name = "txtVareantall"
        Me.txtVareantall.Size = New System.Drawing.Size(171, 20)
        Me.txtVareantall.TabIndex = 3
        '
        'cmbSalgutleie
        '
        Me.cmbSalgutleie.FormattingEnabled = True
        Me.cmbSalgutleie.Items.AddRange(New Object() {"Salg", "Utleie"})
        Me.cmbSalgutleie.Location = New System.Drawing.Point(216, 115)
        Me.cmbSalgutleie.Name = "cmbSalgutleie"
        Me.cmbSalgutleie.Size = New System.Drawing.Size(171, 21)
        Me.cmbSalgutleie.TabIndex = 4
        '
        'cmbVaretilstand
        '
        Me.cmbVaretilstand.FormattingEnabled = True
        Me.cmbVaretilstand.Items.AddRange(New Object() {"Ny", "Brukt"})
        Me.cmbVaretilstand.Location = New System.Drawing.Point(216, 156)
        Me.cmbVaretilstand.Name = "cmbVaretilstand"
        Me.cmbVaretilstand.Size = New System.Drawing.Size(171, 21)
        Me.cmbVaretilstand.TabIndex = 5
        '
        'cmbVarestatus
        '
        Me.cmbVarestatus.FormattingEnabled = True
        Me.cmbVarestatus.Items.AddRange(New Object() {"På lager", "Utleid"})
        Me.cmbVarestatus.Location = New System.Drawing.Point(216, 278)
        Me.cmbVarestatus.Name = "cmbVarestatus"
        Me.cmbVarestatus.Size = New System.Drawing.Size(171, 21)
        Me.cmbVarestatus.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Varenavn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Salg eller utleie?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tilstand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pris"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tilbud?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(149, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Antall"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Legg til vare"
        '
        'btnLeggTilVare
        '
        Me.btnLeggTilVare.Location = New System.Drawing.Point(216, 364)
        Me.btnLeggTilVare.Name = "btnLeggTilVare"
        Me.btnLeggTilVare.Size = New System.Drawing.Size(171, 39)
        Me.btnLeggTilVare.TabIndex = 15
        Me.btnLeggTilVare.Text = "Legg til vare"
        Me.btnLeggTilVare.UseVisualStyleBackColor = True
        '
        'btntilbake
        '
        Me.btntilbake.Location = New System.Drawing.Point(23, 506)
        Me.btntilbake.Name = "btntilbake"
        Me.btntilbake.Size = New System.Drawing.Size(75, 23)
        Me.btntilbake.TabIndex = 16
        Me.btntilbake.Text = "<- Tilbake"
        Me.btntilbake.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(385, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Under tilbud skriv avslag i prisen på desimalform. Full pris flir 1.00 for eksemp" &
    "el :) "
        '
        'LeggTilVare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 566)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btntilbake)
        Me.Controls.Add(Me.btnLeggTilVare)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVarestatus)
        Me.Controls.Add(Me.cmbVaretilstand)
        Me.Controls.Add(Me.cmbSalgutleie)
        Me.Controls.Add(Me.txtVareantall)
        Me.Controls.Add(Me.txtVaretilbud)
        Me.Controls.Add(Me.txtVarepris)
        Me.Controls.Add(Me.txtVarenavn)
        Me.Name = "LeggTilVare"
        Me.Text = "LeggTilVare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVarenavn As TextBox
    Friend WithEvents txtVarepris As TextBox
    Friend WithEvents txtVaretilbud As TextBox
    Friend WithEvents txtVareantall As TextBox
    Friend WithEvents cmbSalgutleie As ComboBox
    Friend WithEvents cmbVaretilstand As ComboBox
    Friend WithEvents cmbVarestatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLeggTilVare As Button
    Friend WithEvents btntilbake As Button
    Friend WithEvents Label9 As Label
End Class
