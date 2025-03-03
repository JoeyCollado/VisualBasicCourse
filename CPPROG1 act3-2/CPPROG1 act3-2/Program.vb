Imports System

Module Program
    Sub Main(args As String())

        Dim num1 As Single = 1.234
        Dim num2 As Single = 1.2e-3
        Dim num3 As Single = 1 / 3

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("num1 : " & num1)
        Console.WriteLine("num2 : " & num2)
        Console.WriteLine("num3 : " & num3)
    End Sub
End Module
