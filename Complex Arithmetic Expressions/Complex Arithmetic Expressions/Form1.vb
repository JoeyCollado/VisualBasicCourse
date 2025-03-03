Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dePrice As Decimal
        Dim iQuantity As Integer
        Dim Discount As Decimal
        Dim deTotalCost As Decimal
        Dim Postage As Decimal

        dePrice = 5
        iQuantity = 10
        Discount = 2
        Postage = 3

        deTotalCost = (dePrice - Discount) * iQuantity + Postage

        'BODMAS - Brackets - Order - Divison - Multiplication - Addition - Subtraction
        'Order of Priority of arithmetic expressions
        'order are just exponents

        MsgBox(deTotalCost)

    End Sub
End Class
