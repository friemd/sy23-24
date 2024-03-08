Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Start()
            Case Keys.Left
                timerLeft.Start()
            Case Keys.Up
                timerUp.Start()
                isjumping = True
            Case Keys.Down
                timerGravity.Start()
        End Select
    End Sub

    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles timerRight.Tick
        picPlayer.Left += 15
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                timerRight.Stop()
            Case Keys.Left
                timerLeft.Stop()
            Case Keys.Up
                timerUp.Stop()
                isjumping = False
            Case Keys.Down
                timerGravity.Stop()
        End Select
    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles timerLeft.Tick
        picPlayer.Left -= movespeed
    End Sub

    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles timerUp.Tick
        picPlayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerGameLogic.Start()
    End Sub

    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles timerGameLogic.Tick


        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then

                    End If
                End If
                If b.Tag = "win" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        mousePictureBox.Visible = False

                    End If
                End If
                If b.Tag = "kill" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        picPlayer.Location = spawn.Location

                    End If
                End If
                If b.Tag = "eat" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Location = PictureBoxtp2.Location
                        b.Visible = False

                    End If
                End If
            End If
        Next
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        picPlayer.Top += movespeed
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox6.Location = PictureBox14.Location
        PictureBox19.Location = PictureBox15.Location
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox17.Location = PictureBox13.Location
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox18.Location = PictureBox16.Location
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If PictureBox14.Visible = Not Visible Then
            PictureBox6.Location = PictureBox14.Location
        End If
        If PictureBox15.Visible = Not Visible Then
            PictureBox19.Location = PictureBox15.Location
        End If
        If PictureBox13.Visible = Not Visible Then
            PictureBox17.Location = PictureBox13.Location
        End If
        If PictureBox16.Visible = Not Visible Then
            PictureBox18.Location = PictureBox16.Location
        End If
        If PictureBox16.Visible = Not Visible And PictureBox13.Visible = Not Visible And PictureBox15.Visible = Not Visible And PictureBox14.Visible = Not Visible And mousePictureBox.Visible = Not Visible Then
            WinBox.Visible = Visible
        End If
    End Sub
End Class
