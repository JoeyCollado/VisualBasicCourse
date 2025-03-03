Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' arithmetic operators basic operation calculations = + - * / ^ \

        Dim number1 As Double        'here we used the double variable (real number) to get more accurate results especialy when dividing
        Dim number2 As Double

        Dim result As Double         'store the result of the calculation

        number1 = txtBoxNumber1.Text 'capture the data that the user types in the textbox
        number2 = txtBoxNumber2.Text 'capture the data that the user types in the textbox

        result = number1 + number2
        MsgBox(result)

        result = number1 - number2
        MsgBox(result)

        result = number1 * number2
        MsgBox(result)

        result = number1 / number2
        MsgBox(result)

        result = number1 ^ number2   'raise to the power
        MsgBox(result)

        result = number1 \ number2   'integer division, leave off the decimal portion of a number, ignoring the remainder
        MsgBox(result)

        result = number1 Mod number2   'mod is the remainder after a whole number division
        MsgBox(result)



    End Sub
End Class
