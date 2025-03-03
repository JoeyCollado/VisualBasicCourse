Imports System

Module Program
    Sub Main(args As String())


        Console.WriteLine("Enter Username")          'creating a prompt
        Dim username As String = Console.ReadLine()  'directly declaring a local variable and taking user input at one line
        Console.WriteLine()
        Console.WriteLine("Enter Passowrd")          'creating a prompt
        Dim password As String = Console.ReadLine()  'directly declaring a local variable and taking user input at one line

        'first if statement
        If (username = "joey") Then
            Console.WriteLine("Username is Correct")

        Else
            Console.WriteLine("Username doesn't exist")
        End If

        '2nd if statement
        If (password = "collado") Then
            Console.WriteLine("Password is Correct")

        Else
            Console.WriteLine("Password is Incorrect")
        End If


    End Sub
End Module
