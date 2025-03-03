Imports System

Module Program
    Sub Main(args As String())

        'declaring variables
        Dim num1 As Integer
        Dim num2 As Integer

        'assigning values
        num1 = 32
        num2 = 23

        'storing results in the variable
        Dim result As Double

        result = num1 + num2
        Console.WriteLine(result)
        Console.ReadLine()

        result = num1 - num2
        Console.WriteLine(result)
        Console.ReadLine()

        result = num1 * num2
        Console.WriteLine(result)
        Console.ReadLine()

        result = num1 / num2
        Console.WriteLine(result)
        Console.ReadLine()

        result = num1 ^ num2
        Console.WriteLine(result)
        Console.ReadLine()

        result = num1 Mod num2
        Console.WriteLine(result)
        Console.ReadLine()

    End Sub
End Module
