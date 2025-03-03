Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim people(4, 5) As String 'x dimension, y dimension

        'inserting values
        people(0, 0) = "barack"
        people(1, 0) = "obama"
        people(2, 0) = "male"
        people(3, 0) = "american"
        people(4, 0) = "president"
        '
        people(0, 1) = "jacinda"
        people(1, 1) = "ardern"
        people(2, 1) = "female"
        people(3, 1) = "new zealand"
        people(4, 1) = "prime minister"
        '
        people(0, 2) = "ada"
        people(1, 2) = "lovelace"
        people(2, 2) = "female"
        people(3, 2) = "british"
        people(4, 2) = "mathematician"
        '
        people(0, 3) = "ligma"
        people(1, 3) = "balls"
        people(2, 3) = "male"
        people(3, 3) = "american"
        people(4, 3) = "nigga"
        '
        people(0, 4) = "joey"
        people(1, 4) = "pogi"
        people(2, 4) = "male"
        people(3, 4) = "aeon"
        people(4, 4) = "god"
        '
        people(0, 5) = "jake"
        people(1, 5) = "acang"
        people(2, 5) = "male"
        people(3, 5) = "filipino"
        people(4, 5) = "student"

        'how to get data out
        ' MsgBox(people(0, 4)) ' get the data at the specified index

        ' since the y value the same you can just change the y value to select the array you want to print
        ' ex change 0 to 5 to get jake array
        Dim x As Integer
        Dim y As Integer

        For y = 0 To 5
            For x = 0 To 4
                MsgBox(people(x, y))
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim people(4, 5) As String 'x dimension, y dimension

        'inserting values
        people(0, 0) = "barack"
        people(1, 0) = "obama"
        people(2, 0) = "male"
        people(3, 0) = "american"
        people(4, 0) = "president"
        '
        people(0, 1) = "jacinda"
        people(1, 1) = "ardern"
        people(2, 1) = "female"
        people(3, 1) = "new zealand"
        people(4, 1) = "prime minister"
        '
        people(0, 2) = "ada"
        people(1, 2) = "lovelace"
        people(2, 2) = "female"
        people(3, 2) = "british"
        people(4, 2) = "mathematician"
        '
        people(0, 3) = "ligma"
        people(1, 3) = "balls"
        people(2, 3) = "male"
        people(3, 3) = "american"
        people(4, 3) = "nigga"
        '
        people(0, 4) = "joey"
        people(1, 4) = "pogi"
        people(2, 4) = "male"
        people(3, 4) = "aeon"
        people(4, 4) = "god"
        '
        people(0, 5) = "jake"
        people(1, 5) = "acang"
        people(2, 5) = "male"
        people(3, 5) = "filipino"
        people(4, 5) = "student"

        'how to get data out
        ' MsgBox(people(0, 4)) ' get the data at the specified index

        ' since the y value the same you can just change the y value to select the array you want to print
        ' ex change 0 to 5 to get jake array
        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(people(x, y))
            Next
        Next


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim people(4, 5) As String 'x dimension, y dimension

        'inserting values
        people(0, 0) = "barack"
        people(1, 0) = "obama"
        people(2, 0) = "male"
        people(3, 0) = "american"
        people(4, 0) = "president"
        '
        people(0, 1) = "jacinda"
        people(1, 1) = "ardern"
        people(2, 1) = "female"
        people(3, 1) = "new zealand"
        people(4, 1) = "prime minister"
        '
        people(0, 2) = "ada"
        people(1, 2) = "lovelace"
        people(2, 2) = "female"
        people(3, 2) = "british"
        people(4, 2) = "mathematician"
        '
        people(0, 3) = "ligma"
        people(1, 3) = "balls"
        people(2, 3) = "male"
        people(3, 3) = "american"
        people(4, 3) = "nigga"
        '
        people(0, 4) = "joey"
        people(1, 4) = "pogi"
        people(2, 4) = "male"
        people(3, 4) = "aeon"
        people(4, 4) = "god"
        '
        people(0, 5) = "jake"
        people(1, 5) = "acang"
        people(2, 5) = "male"
        people(3, 5) = "filipino"
        people(4, 5) = "student"

        'how to get data out
        ' MsgBox(people(0, 4)) ' get the data at the specified index

        ' since the y value the same you can just change the y value to select the array you want to print
        ' ex change 0 to 5 to get jake array
        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & people(x, y) & " "
            Next
            stOut = stOut & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim people(4, 5) As String 'x dimension, y dimension

        'inserting values
        people(0, 0) = "barack"
        people(1, 0) = "obama"
        people(2, 0) = "male"
        people(3, 0) = "american"
        people(4, 0) = "president"
        '
        people(0, 1) = "jacinda"
        people(1, 1) = "ardern"
        people(2, 1) = "female"
        people(3, 1) = "new zealand"
        people(4, 1) = "prime minister"
        '
        people(0, 2) = "ada"
        people(1, 2) = "lovelace"
        people(2, 2) = "female"
        people(3, 2) = "british"
        people(4, 2) = "mathematician"
        '
        people(0, 3) = "ligma"
        people(1, 3) = "balls"
        people(2, 3) = "male"
        people(3, 3) = "american"
        people(4, 3) = "nigga"
        '
        people(0, 4) = "joey"
        people(1, 4) = "pogi"
        people(2, 4) = "male"
        people(3, 4) = "aeon"
        people(4, 4) = "god"
        '
        people(0, 5) = "jake"
        people(1, 5) = "acang"
        people(2, 5) = "male"
        people(3, 5) = "filipino"
        people(4, 5) = "student"

        'how to get data out
        ' MsgBox(people(0, 4)) ' get the data at the specified index

        ' since the y value the same you can just change the y value to select the array you want to print
        ' ex change 0 to 5 to get jake array
        Dim x As Integer
        Dim y As Integer
        Dim found As Boolean
        Dim target As String
        Dim stOut As String

        found = False

        target = InputBox("enter the surname of the person")

        For y = 0 To 5
            If people(1, y) = target Then
                found = True
                Exit For
            End If
        Next

        If found = True Then
            For x = 0 To 4
                stOut = stOut & people(x, y) & " "
            Next
        Else
            MsgBox("not found")
        End If

        MsgBox(stOut)


    End Sub
End Class
