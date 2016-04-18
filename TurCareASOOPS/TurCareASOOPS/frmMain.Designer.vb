<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pageLager = New System.Windows.Forms.TabPage()
        Me.pagePerson = New System.Windows.Forms.TabPage()
        Me.pageVare = New System.Windows.Forms.TabPage()
        Me.pageSalg = New System.Windows.Forms.TabPage()
        Me.pageKurs = New System.Windows.Forms.TabPage()
        Me.pageStatitikk = New System.Windows.Forms.TabPage()
        Me.pageLogut = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DatabaseDataSet = New TurCareASOOPS.DatabaseDataSet()
        Me.VareTableAdapter = New TurCareASOOPS.g_oops_t4DataSetTableAdapters.vareTableAdapter()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.pageLager)
        Me.TabControl1.Controls.Add(Me.pagePerson)
        Me.TabControl1.Controls.Add(Me.pageVare)
        Me.TabControl1.Controls.Add(Me.pageSalg)
        Me.TabControl1.Controls.Add(Me.pageKurs)
        Me.TabControl1.Controls.Add(Me.pageStatitikk)
        Me.TabControl1.Controls.Add(Me.pageLogut)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(48, 48)
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 529)
        Me.TabControl1.TabIndex = 0
        '
        'pageLager
        '
        Me.pageLager.ImageIndex = 1
        Me.pageLager.Location = New System.Drawing.Point(52, 4)
        Me.pageLager.Name = "pageLager"
        Me.pageLager.Padding = New System.Windows.Forms.Padding(3)
        Me.pageLager.Size = New System.Drawing.Size(792, 521)
        Me.pageLager.TabIndex = 0
        Me.pageLager.UseVisualStyleBackColor = True
        '
        'pagePerson
        '
        Me.pagePerson.ImageKey = "Person.png"
        Me.pagePerson.Location = New System.Drawing.Point(52, 4)
        Me.pagePerson.Name = "pagePerson"
        Me.pagePerson.Padding = New System.Windows.Forms.Padding(3)
        Me.pagePerson.Size = New System.Drawing.Size(792, 521)
        Me.pagePerson.TabIndex = 1
        Me.pagePerson.UseVisualStyleBackColor = True
        '
        'pageVare
        '
        Me.pageVare.ImageKey = "Vare.png"
        Me.pageVare.Location = New System.Drawing.Point(52, 4)
        Me.pageVare.Name = "pageVare"
        Me.pageVare.Size = New System.Drawing.Size(792, 521)
        Me.pageVare.TabIndex = 2
        Me.pageVare.UseVisualStyleBackColor = True
        '
        'pageSalg
        '
        Me.pageSalg.ImageKey = "Salg.png"
        Me.pageSalg.Location = New System.Drawing.Point(52, 4)
        Me.pageSalg.Name = "pageSalg"
        Me.pageSalg.Size = New System.Drawing.Size(792, 521)
        Me.pageSalg.TabIndex = 3
        Me.pageSalg.UseVisualStyleBackColor = True
        '
        'pageKurs
        '
        Me.pageKurs.ImageKey = "Kurs.png"
        Me.pageKurs.Location = New System.Drawing.Point(52, 4)
        Me.pageKurs.Name = "pageKurs"
        Me.pageKurs.Size = New System.Drawing.Size(792, 521)
        Me.pageKurs.TabIndex = 4
        Me.pageKurs.UseVisualStyleBackColor = True
        '
        'pageStatitikk
        '
        Me.pageStatitikk.ImageKey = "Statistikk.png"
        Me.pageStatitikk.Location = New System.Drawing.Point(52, 4)
        Me.pageStatitikk.Name = "pageStatitikk"
        Me.pageStatitikk.Size = New System.Drawing.Size(792, 521)
        Me.pageStatitikk.TabIndex = 5
        Me.pageStatitikk.UseVisualStyleBackColor = True
        '
        'pageLogut
        '
        Me.pageLogut.ImageKey = "Logout.png"
        Me.pageLogut.Location = New System.Drawing.Point(52, 4)
        Me.pageLogut.Name = "pageLogut"
        Me.pageLogut.Size = New System.Drawing.Size(792, 521)
        Me.pageLogut.TabIndex = 6
        Me.pageLogut.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Kurs.png")
        Me.ImageList1.Images.SetKeyName(1, "Lager.png")
        Me.ImageList1.Images.SetKeyName(2, "Person.png")
        Me.ImageList1.Images.SetKeyName(3, "Salg.png")
        Me.ImageList1.Images.SetKeyName(4, "Statistikk.png")
        Me.ImageList1.Images.SetKeyName(5, "Vare.png")
        Me.ImageList1.Images.SetKeyName(6, "Logout.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(848, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VareTableAdapter
        '
        Me.VareTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 579)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "TurCareAS - Datasystem"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pageLager As TabPage
    Friend WithEvents pagePerson As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pageVare As TabPage
    Friend WithEvents pageSalg As TabPage
    Friend WithEvents pageKurs As TabPage
    Friend WithEvents pageStatitikk As TabPage
    Friend WithEvents pageLogut As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents VareTableAdapter As g_oops_t4DataSetTableAdapters.vareTableAdapter
End Class
