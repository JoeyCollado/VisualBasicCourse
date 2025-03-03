Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        Dim max As Integer
        Dim oddOreven As String
        Dim x As Integer

        max = InputBox("what number do you want to count up to?")
        oddOreven = InputBox("do you want odd or even numbers?").ToUpper ' to accept all input as uppercase

        If oddOreven = "EVEN" Then
            For x = 2 To max Step 2
                Beep() 'program will beep each iteration
                Threading.Thread.Sleep(3000) 'iteration will execute every 3 seconds
                MsgBox(x)
            Next
        End If

        If oddOreven = "ODD".ToUpper Then
            For x = 1 To max Step 2
                Beep() 'program will beep each iteration
                Threading.Thread.Sleep(3000) 'iteration will execute every 3 seconds
                MsgBox(x)
            Next
        End If

    End Sub
End Class