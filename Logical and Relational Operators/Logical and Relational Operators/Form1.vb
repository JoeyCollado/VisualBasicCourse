Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        'or is one of the 3 logical operator (OR, AND, NOT)
        ' < and > are relational operators
        Dim score As Integer

        If IsNumeric(txtGrade.Text) = True Then 'here we're asking if the input can be converted to number because if yes we will do the line of code if not program will stop
            score = txtGrade.Text
        Else
            MsgBox("You must enter a number")
            Exit Sub 'force program to stop
        End If

        score = txtGrade.Text

        If Not (score >= 0 And score <= 100) Then
            MsgBox("Enter a Valid Score, Between 0-100")

        ElseIf score <= 20 Then
            MsgBox("F")
        ElseIf score > 20 And score <= 30 Then
            MsgBox("E")
        ElseIf score > 30 And score <= 40 Then
            MsgBox("D")
        ElseIf score > 40 And score <= 50 Then
            MsgBox("C")
        ElseIf score > 50 And score <= 70 Then
            MsgBox("B")
        Else
            MsgBox("A")
        End If

        MsgBox("all done")
    End Sub
End Class
