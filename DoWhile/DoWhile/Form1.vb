Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'do while loop
        ' its more flexible


        Dim x As Integer

        Do While x < 5
            x = x + 1                  'increment x
            MsgBox(" Hello " & x)
        Loop
        MsgBox("all done")


        'it does the same thing but here we use until
        Do Until x = 5
            x = x + 1
            MsgBox("all done")
        Loop

    End Sub
End Class
