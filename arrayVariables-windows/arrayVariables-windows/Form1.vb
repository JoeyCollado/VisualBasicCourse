Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim fruits(4) As String

        fruits(0) = "banana"
        fruits(1) = "orange"
        fruits(2) = "mango"
        fruits(3) = "pineapple"
        fruits(4) = "apple"

        Dim i As Integer

        'iterating through array using for next loop
        For i = 0 To 4
            MsgBox(fruits(i))
        Next

        'MsgBox(fruits(1)) 'outputs orange

    End Sub
End Class
