Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.Black
        Console.SetCursorPosition(30, 11)
        Console.WriteLine("Hello World!")
        Console.ReadLine()

        Console.Clear()

        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.Black
        Console.SetCursorPosition(30, 11) 'the two integer defines left and top (0,0)
        Console.WriteLine("Welcome")



    End Sub
End Module
