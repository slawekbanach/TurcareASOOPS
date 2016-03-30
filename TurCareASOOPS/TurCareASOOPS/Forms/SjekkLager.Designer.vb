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
        Me.txtsoek = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.btnSok = New System.Windows.Forms.Button()
        Me.btnListUt = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsoek
        '
        Me.txtsoek.Location = New System.Drawing.Point(854, 594)
        Me.txtsoek.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsoek.Name = "txtsoek"
        Me.txtsoek.Size = New System.Drawing.Size(148, 26)
        Me.txtsoek.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1161, 508)
        Me.DataGridView1.TabIndex = 8
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(32, 610)
        Me.btnTilbake.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(112, 35)
        Me.btnTilbake.TabIndex = 7
        Me.btnTilbake.Text = "<- Tilbake"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'btnSok
        '
        Me.btnSok.Location = New System.Drawing.Point(854, 548)
        Me.btnSok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSok.Name = "btnSok"
        Me.btnSok.Size = New System.Drawing.Size(112, 35)
        Me.btnSok.TabIndex = 6
        Me.btnSok.Text = "Søk på vare"
        Me.btnSok.UseVisualStyleBackColor = True
        '
        'btnListUt
        '
        Me.btnListUt.Location = New System.Drawing.Point(30, 536)
        Me.btnListUt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnListUt.Name = "btnListUt"
        Me.btnListUt.Size = New System.Drawing.Size(208, 35)
        Me.btnListUt.TabIndex = 5
        Me.btnListUt.Text = "List ut alle varer"
        Me.btnListUt.UseVisualStyleBackColor = True
        '
        'SjekkLager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 662)
        Me.Controls.Add(Me.txtsoek)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnSok)
        Me.Controls.Add(Me.btnListUt)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SjekkLager"
        Me.Text = "SjekkLager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsoek As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTilbake As Button
    Friend WithEvents btnSok As Button
    Friend WithEvents btnListUt As Button
End Class
