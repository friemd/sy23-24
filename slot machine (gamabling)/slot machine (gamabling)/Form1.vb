Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserControl11.spin()
        UserControl12.spin()
        UserControl13.spin()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If UserControl11.itemvalue = 4 And UserControl12.itemvalue = 4 And UserControl13.itemvalue = 4 Then

        End If
    End Sub
End Class
'0 = sonic and eggman hugging
'1 = adam vs homelander
'2 = scrambled eggs
'3 = skibidi toilet trash
'4 = ballin
'5 = ballin jesus vs satan
