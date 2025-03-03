Imports System

Module Program
    Sub Main(args As String())
        'declaration
        Dim i As Integer = 1
        'loop function
        Console.ForegroundColor = ConsoleColor.Cyan
        Do
            Console.WriteLine("The Variable i has looped {0} times", i)
            i = i + 1

        Loop Until i = 42 + 1
        'print outputs
        Console.WriteLine()
        Console.WriteLine("Submitted by: Joey Aibert U. Collado")
        Console.WriteLine("Submitted to: Ma Femia Moreno")
        Console.WriteLine("Date and Time: 6/20/2024")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
