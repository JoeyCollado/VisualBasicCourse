Imports System

Module Arithmetic_Operators_Program
    Sub Main(args As String())

        'Declaring integer Data Types
        Dim a, b, c As Integer
        Dim d As Single

        a = 17
        b = 4
        c = a + b

        'use of + Operator
        c = a + b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Sum of a + b is: {0}", c)

        'use of - Operator
        c = a - b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Subtraction of a - b is: {0}", c)

        'use of * Operator
        c = a * b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Multiplication of a * b is: {0}", c)

        'use of / Operator
        c = a / b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Division of a / b is: {0}", c)

        'use of \ Operator
        c = a \ b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Similar to division Operator(return only integer value) of a \ b is: {0}", c)

        'use of Mod Operator
        c = a Mod b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Modulus of a Mod is: {0}", c)

        'use of ^ Operator
        c = a ^ b
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Power of a ^ b is: {0}", c)
        Console.WriteLine("Submitted by: Joey Aibert U. Collado")
        Console.WriteLine("Submitted to: Ma'am Femia Moreno")
        Console.WriteLine("Press any key to exit...")

        Console.ReadKey()
    End Sub
End Module
