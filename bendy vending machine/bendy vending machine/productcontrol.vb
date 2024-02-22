Imports System.Reflection.Emit

Public Class ProductControl
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productpicture As Image
    Public Property productcount As Integer

    Private Sub ProductControl_Load(sender As Object, e As EventArgs)
        idlabel.Text = productid
        pricelabel.Text = productprice.ToString("c2")
        PictureBox1.Image = productpicture
    End Sub
    Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents idlabel As Windows.Forms.Label
    Friend WithEvents pricelabel As Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.idlabel = New System.Windows.Forms.Label()
        Me.pricelabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 110)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.Location = New System.Drawing.Point(3, 130)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(53, 20)
        Me.idlabel.TabIndex = 1
        Me.idlabel.Text = "Label1"
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Location = New System.Drawing.Point(94, 130)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(53, 20)
        Me.pricelabel.TabIndex = 2
        Me.pricelabel.Text = "Label2"
        '
        'ProductControl
        '
        Me.Controls.Add(Me.pricelabel)
        Me.Controls.Add(Me.idlabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductControl"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class