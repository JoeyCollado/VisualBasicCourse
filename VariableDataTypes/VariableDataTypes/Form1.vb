Public Class Form1
    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer                  'integer is another name for whole number
        Dim stColour As String
        Dim bTaxed As Boolean                  'word boolean is named after the computer scientist george boole, a boolean can always have two values either true or false
        Dim EngineSize As Integer
        Dim price As Decimal
        Dim DateRegistered As Date



        stMake = "ford"
        stModel = "escort"
        iDoors = 4
        stColour = "black"
        bTaxed = "True"
        EngineSize = "1200"
        price = 999.99
        DateRegistered = #05/7/2024#              'hash symbol is used to enclosed a date

        MsgBox("The Car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColour & vbNewLine & bTaxed & vbNewLine &
               EngineSize & vbNewLine & price & vbNewLine & DateRegistered)

        ' just add _ to the last line to compressed it and put the excess line to a new line
        'vbNewLine = prints statement in a new line











    End Sub
End Class
