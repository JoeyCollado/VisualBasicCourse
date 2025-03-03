Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        '3 fundamental constructs
        '1st is sequence
        '2nd is selection
        '3rd is iteration

        'sequence = each statement in a program or block of code will run one after one another
        MsgBox("welcum")
        MsgBox("to")
        MsgBox("the")
        MsgBox("niggerhood")

        'another command to use to display on a screen
        MessageBox.Show("nigga")


    End Sub

    Private Sub variables_Click(sender As Object, e As EventArgs) Handles variables.Click


        'variable = is a location in computer memory where a program can temporarily store data while its running
        'first step is to declare
        'Dim is short for dimension
        'string is another data type
        '& is a concatenation notation

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "joey" 'assingning value to variable
        stLastName = "collado"


        MsgBox("Hello " & stFirstName & " " & stLastName & " Have an ice day")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
