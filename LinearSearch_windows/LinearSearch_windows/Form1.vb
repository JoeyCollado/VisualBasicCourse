Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'declaring variables
        Dim targetSearch As String
            Dim fruits(9) As String
            Dim found As Boolean

            'initializing
            fruits(0) = "apple"
            fruits(1) = "banana"
            fruits(2) = "mango"
            fruits(3) = "oranges"
            fruits(4) = "pineapple"
            fruits(5) = "kiwi"
            fruits(6) = "lemon"
            fruits(7) = "peach"
            fruits(8) = "strawberry"
            fruits(9) = "watermelon"

            'creating a prompt
            targetSearch = InputBox("Which fruit u lookin?")

            'using for loop to scan through the array
            Dim i As Integer
            For i = 0 To 9
                If fruits(i).ToUpper = targetSearch.ToUpper Then
                    found = True
                    Exit For  'force exit loop if conditino is satisfied
                End If
            Next

            If found = True Then
                MsgBox("found it")
            Else
                MsgBox("nah")
            End If




        End Sub
    End Class
