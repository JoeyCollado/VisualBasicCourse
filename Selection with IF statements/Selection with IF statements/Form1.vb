Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        'there are three programming constructs in vb.net Sequence, Selection, and Iteration
        'selection is executing one's block of code or one another

        Dim country As String
        country = txtCountry.Text 'if country is equal to the textbox
        country = country.ToUpper 'remove case sensitivity

        If country = "AUSTRALIA" Then
            MsgBox("G'day Mate")
        ElseIf country = "FRANCE" Then
            MsgBox("Bonjour")
        ElseIf country = "JAPAN" Then
            MsgBox("konichiwa")
        Else
            MsgBox("Hello world niiga")

        End If 'you use end if its a block of code if one line no need

        MsgBox("You entered " & country) 'executes after program escape the if statements


    End Sub
End Class
