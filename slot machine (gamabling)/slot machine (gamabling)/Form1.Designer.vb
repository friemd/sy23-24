<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UserControl11 = New slot_machine__gamabling_.UserControl1()
        Me.UserControl12 = New slot_machine__gamabling_.UserControl1()
        Me.UserControl13 = New slot_machine__gamabling_.UserControl1()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "gettyimages-1201913873-612x612.jpg")
        Me.ImageList1.Images.SetKeyName(1, "sddefault (1).jpg")
        Me.ImageList1.Images.SetKeyName(2, "maxresdefault (2).jpg")
        Me.ImageList1.Images.SetKeyName(3, "capsule_616x353.jpg")
        Me.ImageList1.Images.SetKeyName(4, "tom-pottiger-571831-unsplash.jpg")
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(599, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 383)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 62)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl11.itemvalue = 0
        Me.UserControl11.Location = New System.Drawing.Point(12, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(185, 185)
        Me.UserControl11.spintime = 2000
        Me.UserControl11.TabIndex = 3
        '
        'UserControl12
        '
        Me.UserControl12.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UserControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl12.itemvalue = 0
        Me.UserControl12.Location = New System.Drawing.Point(203, 12)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(185, 185)
        Me.UserControl12.spintime = 3500
        Me.UserControl12.TabIndex = 4
        '
        'UserControl13
        '
        Me.UserControl13.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UserControl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl13.itemvalue = 0
        Me.UserControl13.Location = New System.Drawing.Point(394, 12)
        Me.UserControl13.Name = "UserControl13"
        Me.UserControl13.Size = New System.Drawing.Size(185, 185)
        Me.UserControl13.spintime = 5000
        Me.UserControl13.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 422)
        Me.Controls.Add(Me.UserControl13)
        Me.Controls.Add(Me.UserControl12)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents UserControl12 As UserControl1
    Friend WithEvents UserControl13 As UserControl1
End Class
