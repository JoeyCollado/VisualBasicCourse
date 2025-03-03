Imports System

Module Program
    Sub Main(args As String())
        'program to print the larger and smaller of the two numbers.

        Dim a As Integer
        Dim b As Integer
        '
        Console.WriteLine("Enter first number")
        a = Console.ReadLine
        '
        Console.WriteLine("Enter second number")
        b = Console.ReadLine

        '
        If a > b Then
            Console.WriteLine("the larger number is {0} the smaller number is {1}", a, b)

        Else
            Console.WriteLine("the larger number is {0} the smaller number is {1}", b, a)
        End If
    End Sub
End Module
