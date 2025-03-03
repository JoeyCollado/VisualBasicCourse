Imports System

Module Program
    Sub Main(args As String())
        'declare a variable
        Dim num As Integer

        'create a console to prompt user
        Console.WriteLine("Enter a number")
        'read our variable
        num = Console.ReadLine

        'create a if condition
        If (num Mod 2 = 0) Then
            Console.WriteLine("The number is even")


        Else
            Console.WriteLine("the number is odd")
        End If

    End Sub
End Module
