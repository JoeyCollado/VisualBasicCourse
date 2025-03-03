Imports System

Module Program
    Sub Main(args As String())

        Dim m1, m2, m3, m4, m5 As Integer
        Dim per As Integer

        '
        Console.WriteLine("Enter a mark in five subjects")


        m1 = Console.ReadLine()
        m2 = Console.ReadLine()
        m3 = Console.ReadLine()
        m4 = Console.ReadLine()
        m5 = Console.ReadLine()

        '
        per = (m1 + m2 + m3 + m4 + m5) / 5

        '
        If (per >= 70) Then
            Console.WriteLine("first division")

        ElseIf (per >= 60) Then
            Console.WriteLine("second division")

        ElseIf (per >= 50) Then
            Console.WriteLine("third division")
        ElseIf (per >= 40) Then
            Console.WriteLine("only passed with grace")

        Else
            Console.WriteLine("failed")
        End If





    End Sub
End Module
