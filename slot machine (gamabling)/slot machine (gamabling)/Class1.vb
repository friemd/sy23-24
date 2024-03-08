Public Class CoinSlot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)

    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Public Property dollars As Integer
    Public Property total As Decimal
        Get
            Return dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
        End Get
        Set(value As Decimal)

        End Set
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0
    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub
    Sub insertnickel()
        nickels = nickels + 1
    End Sub
    Sub insertdime()
        dimes = dimes + 1
    End Sub
    Sub insertdollar()
        dollars = dollars + 1
    End Sub
    Sub spinslotmachine()
        total = total - 5
    End Sub
End Class
