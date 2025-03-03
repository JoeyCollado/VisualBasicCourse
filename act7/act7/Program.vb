Imports System
Module Program
    '
    Function factorial(ByVal num As Integer) As Integer
        If (num = 0) Then
            Return 0
        ElseIf (num = 1) Then
            Return 1
        Else
            Return num * factorial(num - 1)
        End If
    End Function
    '
    Sub Main(args As String())
        Console.ForegroundColor = ConsoleColor.Cyan
        Dim n, f As Integer
        Console.WriteLine("Enter the number you want to calculate the factorial: ")
        n = Console.ReadLine()
        f = factorial(n)
        '
        Console.WriteLine("Factorial is : {0}", f)
        Console.WriteLine()
        Console.WriteLine("Submitted by  : Joey Aibert U. Collado")
        Console.WriteLine("Submitted to  : Ma Femia Moreno")
        Console.WriteLine("Date and Time : 6/20/2024")
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
