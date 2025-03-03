Imports System

Module Program
    Sub Main(args As String())

        'bitshift operators

        Dim x, y, z As Integer
        x = 12
        y = 25

        Dim a, b As Double
        a = 5
        b = 9

        'use of and operator
        z = x And y
        Console.WriteLine("bitshift operator x and y is {0}", z)

        'use of or operator
        z = x Or y
        Console.WriteLine("bitshift operator x or y is {0}", z)

        'use of Xor operator
        z = x Xor y
        Console.WriteLine("bitshift operator x Xor y is {0}", z)

        'use of not operator
        z = Not y
        Console.WriteLine("bitshift operator Not y is {0}", z)

        'use of << left shift operator
        Console.WriteLine("BitWise left shift operator -a<<1 = {0}", a << 1)
        Console.WriteLine("BitWise left shift operator -b<<1 = {0}", b << 1)

        'use of >> right shift operator
        Console.WriteLine("BitWise right shift operator -a>>1 = {0}", a >> 1)
        Console.WriteLine("BitWise right shift operator -b>>1 = {0}", b >> 1)

        '
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()









    End Sub
End Module
