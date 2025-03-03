Imports System

Module Program
    Sub Main(args As String())

        Dim x = 20
        Dim y = 5
        Dim z = 10

        Dim totalSum = x + y + z
        Dim product = x * y * z

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        Console.WriteLine("z = " & z)
        Console.WriteLine()
        Console.WriteLine("The total sum of x+y+z is {0}", totalSum)
        Console.WriteLine("The product of x *y* z is {0}", product.ToString("N0"))
        Console.WriteLine()
        Console.WriteLine("Submitted by: Joey Aibert U. Collado")
    End Sub
End Module
