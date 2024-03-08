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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.timerRight = New System.Windows.Forms.Timer(Me.components)
        Me.timerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timerUp = New System.Windows.Forms.Timer(Me.components)
        Me.timerGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.timerGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.mousePictureBox = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.spawn = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New PlatformerGame.mover()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Mover2 = New PlatformerGame.mover()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Mover3 = New PlatformerGame.mover()
        Me.Mover4 = New PlatformerGame.mover()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxtp = New System.Windows.Forms.PictureBox()
        Me.PictureBoxtp2 = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.WinBox = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxtp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(1085, 347)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(70, 76)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.Image = CType(resources.GetObject("picAir.Image"), System.Drawing.Image)
        Me.picAir.Location = New System.Drawing.Point(0, 0)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(1281, 661)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'timerRight
        '
        Me.timerRight.Interval = 50
        '
        'timerLeft
        '
        Me.timerLeft.Interval = 50
        '
        'timerUp
        '
        Me.timerUp.Interval = 50
        '
        'timerGameLogic
        '
        '
        'timerGravity
        '
        Me.timerGravity.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(208, 188)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 23)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        Me.PictureBox1.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(0, 487)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1001, 23)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        Me.PictureBox3.Visible = False
        '
        'mousePictureBox
        '
        Me.mousePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mousePictureBox.Image = CType(resources.GetObject("mousePictureBox.Image"), System.Drawing.Image)
        Me.mousePictureBox.Location = New System.Drawing.Point(32, 162)
        Me.mousePictureBox.Name = "mousePictureBox"
        Me.mousePictureBox.Size = New System.Drawing.Size(149, 207)
        Me.mousePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mousePictureBox.TabIndex = 6
        Me.mousePictureBox.TabStop = False
        Me.mousePictureBox.Tag = "win"
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picground.Location = New System.Drawing.Point(0, 602)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(1281, 23)
        Me.picground.TabIndex = 7
        Me.picground.TabStop = False
        Me.picground.Tag = "bound"
        Me.picground.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(208, 396)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(775, 23)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(208, 298)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(764, 23)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        Me.PictureBox5.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1055, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 10
        '
        'spawn
        '
        Me.spawn.BackColor = System.Drawing.Color.Transparent
        Me.spawn.Image = CType(resources.GetObject("spawn.Image"), System.Drawing.Image)
        Me.spawn.Location = New System.Drawing.Point(1118, 298)
        Me.spawn.Name = "spawn"
        Me.spawn.Size = New System.Drawing.Size(22, 23)
        Me.spawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spawn.TabIndex = 11
        Me.spawn.TabStop = False
        Me.spawn.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(379, 215)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "kill"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(606, 114)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "kill"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(606, 327)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 15
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "kill"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(671, 516)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 16
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "kill"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(310, 425)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 17
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "kill"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(826, 217)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(68, 77)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 18
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "kill"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(227, 316)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(68, 88)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 19
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "eat"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(379, 103)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(68, 88)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 20
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "eat"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(390, 508)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(68, 88)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 21
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "eat"
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(531, 422)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(68, 88)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 22
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Tag = "eat"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(751, 114)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "kill"
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(270, 337)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 24
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "kill"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(870, 445)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 25
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "kill"
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(746, 528)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox19.TabIndex = 26
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Tag = "kill"
        '
        'Mover1
        '
        Me.Mover1.interval = 100
        Me.Mover1.Location = New System.Drawing.Point(421, 124)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(446, 10)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox6
        Me.Mover1.TabIndex = 27
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4250
        '
        'Mover2
        '
        Me.Mover2.interval = 100
        Me.Mover2.Location = New System.Drawing.Point(280, 327)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(587, 10)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox17
        Me.Mover2.TabIndex = 28
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 2500
        '
        'Mover3
        '
        Me.Mover3.interval = 100
        Me.Mover3.Location = New System.Drawing.Point(570, 455)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(307, 10)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox18
        Me.Mover3.TabIndex = 29
        '
        'Mover4
        '
        Me.Mover4.interval = 100
        Me.Mover4.Location = New System.Drawing.Point(426, 538)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(441, 10)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox19
        Me.Mover4.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(176, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1105, 86)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "kill"
        Me.PictureBox2.Visible = False
        '
        'PictureBoxtp
        '
        Me.PictureBoxtp.Location = New System.Drawing.Point(1274, 0)
        Me.PictureBoxtp.Name = "PictureBoxtp"
        Me.PictureBoxtp.Size = New System.Drawing.Size(98, 661)
        Me.PictureBoxtp.TabIndex = 32
        Me.PictureBoxtp.TabStop = False
        Me.PictureBoxtp.Tag = "kill"
        Me.PictureBoxtp.Visible = False
        '
        'PictureBoxtp2
        '
        Me.PictureBoxtp2.Location = New System.Drawing.Point(176, 654)
        Me.PictureBoxtp2.Name = "PictureBoxtp2"
        Me.PictureBoxtp2.Size = New System.Drawing.Size(1120, 122)
        Me.PictureBoxtp2.TabIndex = 33
        Me.PictureBoxtp2.TabStop = False
        Me.PictureBoxtp2.Tag = "kill"
        Me.PictureBoxtp2.Visible = False
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 1
        '
        'WinBox
        '
        Me.WinBox.Image = CType(resources.GetObject("WinBox.Image"), System.Drawing.Image)
        Me.WinBox.Location = New System.Drawing.Point(0, 0)
        Me.WinBox.Name = "WinBox"
        Me.WinBox.Size = New System.Drawing.Size(1281, 661)
        Me.WinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WinBox.TabIndex = 34
        Me.WinBox.TabStop = False
        Me.WinBox.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 662)
        Me.Controls.Add(Me.WinBox)
        Me.Controls.Add(Me.PictureBoxtp2)
        Me.Controls.Add(Me.PictureBoxtp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.spawn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.mousePictureBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mousePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxtp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents timerRight As Timer
    Friend WithEvents timerLeft As Timer
    Friend WithEvents timerUp As Timer
    Friend WithEvents timerGameLogic As Timer
    Friend WithEvents timerGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents mousePictureBox As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents spawn As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Mover2 As mover
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Mover3 As mover
    Friend WithEvents Mover4 As mover
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBoxtp As PictureBox
    Friend WithEvents PictureBoxtp2 As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents WinBox As PictureBox
End Class
