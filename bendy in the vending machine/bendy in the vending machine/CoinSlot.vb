Public Class CoinSlot
    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property dollars As Integer
    Public Property total As Decimal
        Get
            Return dollars + (quarters * 0.25 + dimes * 0.1 + nickels * 0.05)
        End Get
        Set(value As Decimal)

        End Set
    End Property
    Public Sub coinreturn()
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0
    End Sub
    Public Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Public Sub insertnickles()
        nickels = nickels + 1
    End Sub
    Public Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Public Sub insertdollars()
        dollars = dollars + 1
    End Sub
End Class
