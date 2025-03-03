Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            MsgBox(allData(i))
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim stOut As String


        For i = 0 To 4
            stOut = stOut & allData(i) & vbNewLine 'outputs all value in the same message box separated in a new line
        Next

        MsgBox(stOut)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim total As Integer
        total = allData(0) + allData(1) + allData(2) + allData(3) + allData(4)

        MsgBox("The Total is " & total)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To 4
            total = total + allData(i)
        Next

        MsgBox("The total is " & total / 5)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To 4
            If allData(i) > 20 Then
                total = total + allData(i)
            End If
        Next

        MsgBox("The total of the items bigger than 20 is " & total)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim max As Integer

        max = 0

        For i = 0 To 4
            If allData(i) > max Then
                max = allData(i)
            End If
        Next

        MsgBox("The largest item is " & max)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To 4
            allData(i) = allData(i) * 2
        Next

        Dim stOut As String

        For i = 0 To 4
            stOut = stOut & allData(i) & vbNewLine
        Next

        MsgBox(stOut)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim allData(4) As Integer

        allData(0) = 5
        allData(1) = 7
        allData(2) = 33
        allData(3) = 22
        allData(4) = 8

        Dim i As Integer
        Dim min As Integer

        min = 10000

        For i = 0 To 4
            If allData(i) < min Then
                min = allData(i)
            End If
        Next

        MsgBox("The smalles item is " & min)

    End Sub
End Class
