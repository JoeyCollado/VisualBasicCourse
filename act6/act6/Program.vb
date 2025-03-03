Imports System

Module Program
    Sub Main(args As String())
        'declaration

        Dim i As Integer
        Dim name As String = "Joey Aibert U Collado"

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("These are the characters of my name :")
        Console.WriteLine()
        '
        For i = 0 To name.Length - 1
            Console.WriteLine(name(i))
        Next
        '
        Console.WriteLine()
        Console.WriteLine("length is {0}", name.Length)
        Console.WriteLine()
        Console.WriteLine("Submitted by  : Joey Aibert U. Collado")
        Console.WriteLine("Submitted to  : Ma Femia Moreno")
        Console.WriteLine("Date and time : 6/20/2024")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
