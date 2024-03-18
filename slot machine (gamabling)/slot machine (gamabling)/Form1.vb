Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.spin()
        UserControl12.spin()
        UserControl13.spin()
        Timer1.Enabled = True
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = UserControl11.itemvalue
        Label3.Text = UserControl12.itemvalue
        Label4.Text = UserControl13.itemvalue
        Timer1.Enabled = False
        If UserControl11.itemvalue = 0 And UserControl12.itemvalue = 0 And UserControl13.itemvalue = 0 Then
            Me.BackColor = Color.Pink

        End If
        If UserControl11.itemvalue = 1 And UserControl12.itemvalue = 1 And UserControl13.itemvalue = 1 Then
            Me.BackColor = Color.Red
        End If
        If UserControl11.itemvalue = 2 And UserControl12.itemvalue = 2 And UserControl13.itemvalue = 2 Then
            Me.BackColor = Color.Yellow
        End If
        If UserControl11.itemvalue = 3 And UserControl12.itemvalue = 3 And UserControl13.itemvalue = 3 Then
            Me.BackColor = Color.Brown
        End If
        If UserControl11.itemvalue = 4 And UserControl12.itemvalue = 4 And UserControl13.itemvalue = 4 Then
            Me.BackColor = Color.Orange
        End If
        If UserControl11.itemvalue = 5 And UserControl12.itemvalue = 5 And UserControl13.itemvalue = 5 Then
            Me.BackColor = Color.Salmon
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertnickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class
'0 = sonic and eggman hugging
'1 = adam vs homelander
'2 = scrambled eggs
'3 = skibidi toilet trash
'4 = ballin
'5 = ballin jesus vs satan
