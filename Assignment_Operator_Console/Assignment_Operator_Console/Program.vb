Imports System

Module Program
    Sub Main(args As String())

        '
        Dim a As Integer = 5
        Dim b As Integer
        Dim str, name As String

        '
        name = "come"
        str = "wel"

        'use of = operator
        b = a
        Console.WriteLine("assign value a to b is {0}", b)

        'use of += operator
        b += a
        Console.WriteLine("output of b += a is {0}", b)


        'use of -= operator
        b -= a
        Console.WriteLine("output of b -= a is {0}", b)

        'use of *= operator
        b *= a
        Console.WriteLine("output of b *= a is {0}", b)

        'use of /= operator
        b /= a
        Console.WriteLine("output of b /= a is {0}", b)

        'use of -= operator
        b \= a
        Console.WriteLine("output of b \= a is {0}", b)

        'use of ^= operator
        b ^= a
        Console.WriteLine("output of b ^= a is {0}", b)

        'use of &= operator
        str &= name
        Console.WriteLine("output of str &= name is {0}", str)

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
