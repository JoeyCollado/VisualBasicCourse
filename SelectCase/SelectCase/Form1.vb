Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim temperature As Integer
        temperature = CInt(txtTemp.Text)

        Select Case temperature
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 0
                MsgBox("Sub Zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select




    End Sub
End Class
