Imports System

Module Program
    Sub Main(args As String())

        Dim num1 As Integer = 31
        Dim num2 As Integer = &O31
        Dim num3 As Integer = &H1A
        Dim num4 As Integer = &B1001001

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("num1 : " & num1)
        Console.WriteLine("num2 : " & num2)
        Console.WriteLine("num3 : " & num3)
        Console.WriteLine("num4 : " & num4)

    End Sub
End Module
