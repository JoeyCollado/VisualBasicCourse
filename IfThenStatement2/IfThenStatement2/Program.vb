Imports System

Module Program
    Sub Main(args As String())
        'program to print a number is greater than another number'

        Dim no1, no2 As Integer

        Console.WriteLine("Enter any two number")
        no1 = Console.ReadLine()                  'read user input
        no2 = Console.ReadLine()

        '
        If no1 > no2 Then
            Console.WriteLine("first number is greater than second number")
        End If
        If no1 < no2 Then
            Console.WriteLine("first number is less than second number")
        End If

        Console.ReadKey()
    End Sub
End Module
