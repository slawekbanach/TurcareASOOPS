<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utleie
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
        Me.btnKunder = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pris = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVarer = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRegistrerSalg = New System.Windows.Forms.Button()
        Me.txtPris = New System.Windows.Forms.TextBox()
        Me.txtSelger = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalpris = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbKunder = New System.Windows.Forms.ComboBox()
        Me.cmbVarer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnKunder
        '
        Me.btnKunder.Location = New System.Drawing.Point(502, 528)
        Me.btnKunder.Name = "btnKunder"
        Me.btnKunder.Size = New System.Drawing.Size(184, 48)
        Me.btnKunder.TabIndex = 31
        Me.btnKunder.Text = "Oversikt over kunder"
        Me.btnKunder.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 395)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Totalpris"
        '
        'Pris
        '
        Me.Pris.AutoSize = True
        Me.Pris.Location = New System.Drawing.Point(183, 334)
        Me.Pris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Pris.Name = "Pris"
        Me.Pris.Size = New System.Drawing.Size(88, 20)
        Me.Pris.TabIndex = 28
        Me.Pris.Text = "Pris pr. dag"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Vare"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Utleiedato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Kunde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Selger"
        '
        'btnVarer
        '
        Me.btnVarer.Location = New System.Drawing.Point(278, 528)
        Me.btnVarer.Name = "btnVarer"
        Me.btnVarer.Size = New System.Drawing.Size(184, 48)
        Me.btnVarer.TabIndex = 23
        Me.btnVarer.Text = "Oversikt over varer"
        Me.btnVarer.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 528)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 48)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "<- Tilbake"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnRegistrerSalg
        '
        Me.btnRegistrerSalg.Location = New System.Drawing.Point(333, 445)
        Me.btnRegistrerSalg.Name = "btnRegistrerSalg"
        Me.btnRegistrerSalg.Size = New System.Drawing.Size(182, 43)
        Me.btnRegistrerSalg.TabIndex = 21
        Me.btnRegistrerSalg.Text = "Registrer Utleie"
        Me.btnRegistrerSalg.UseVisualStyleBackColor = True
        '
        'txtPris
        '
        Me.txtPris.Location = New System.Drawing.Point(333, 329)
        Me.txtPris.Name = "txtPris"
        Me.txtPris.Size = New System.Drawing.Size(181, 26)
        Me.txtPris.TabIndex = 20
        '
        'txtSelger
        '
        Me.txtSelger.Location = New System.Drawing.Point(332, 52)
        Me.txtSelger.Name = "txtSelger"
        Me.txtSelger.Size = New System.Drawing.Size(181, 26)
        Me.txtSelger.TabIndex = 16
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(332, 226)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 32
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(332, 269)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker2.TabIndex = 33
        '
        'txtTotalpris
        '
        Me.txtTotalpris.Location = New System.Drawing.Point(333, 385)
        Me.txtTotalpris.Name = "txtTotalpris"
        Me.txtTotalpris.Size = New System.Drawing.Size(181, 26)
        Me.txtTotalpris.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 278)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Til dato"
        '
        'cmbKunder
        '
        Me.cmbKunder.FormattingEnabled = True
        Me.cmbKunder.Location = New System.Drawing.Point(332, 104)
        Me.cmbKunder.Name = "cmbKunder"
        Me.cmbKunder.Size = New System.Drawing.Size(183, 28)
        Me.cmbKunder.TabIndex = 37
        Me.cmbKunder.Text = "Velg kunde fra listen"
        '
        'cmbVarer
        '
        Me.cmbVarer.FormattingEnabled = True
        Me.cmbVarer.Location = New System.Drawing.Point(331, 160)
        Me.cmbVarer.Name = "cmbVarer"
        Me.cmbVarer.Size = New System.Drawing.Size(184, 28)
        Me.cmbVarer.TabIndex = 38
        Me.cmbVarer.Text = "Velg vare fra listen"
        '
        'Utleie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 663)
        Me.Controls.Add(Me.cmbVarer)
        Me.Controls.Add(Me.cmbKunder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalpris)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnKunder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Pris)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVarer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRegistrerSalg)
        Me.Controls.Add(Me.txtPris)
        Me.Controls.Add(Me.txtSelger)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Utleie"
        Me.Text = "Utleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKunder As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Pris As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVarer As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRegistrerSalg As Button
    Friend WithEvents txtPris As TextBox
    Friend WithEvents txtSelger As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtTotalpris As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbKunder As ComboBox
    Friend WithEvents cmbVarer As ComboBox
End Class
