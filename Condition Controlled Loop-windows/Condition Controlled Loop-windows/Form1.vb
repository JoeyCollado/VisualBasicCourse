Public Class Form1
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        'do while = is a condition controlled loop
        Dim name As String

        Do While name <> "JOEY" 'do while name is not equal to kevin enter loop
            name = InputBox("Please enter your name")
        Loop

        MsgBox("Hello " & name)

    End Sub
End Class
