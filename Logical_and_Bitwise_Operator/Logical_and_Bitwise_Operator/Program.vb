Imports System

Module Program
    Sub Main(args As String())

        Dim a As Boolean = True
        Dim b As Boolean = False
        Dim c, d As Integer

        c = 10
        d = 20

        'use of and operator
        If a And b Then
            Console.WriteLine("Operands a and b are true")
        End If

        'use of or operator
        If a Or b Then
            Console.WriteLine("Operands a or b are true")
        End If

        'use of Xor operator
        If a Xor b Then
            Console.WriteLine("Operands a Xor b is true")
        End If

        'use of and operator
        If c And d Then
            Console.WriteLine("Operands c and d is true")
        End If

        'use of or operator
        If c Or d Then
            Console.WriteLine("Operands c or d is true")
        End If

        'use of AndAlso operator
        If a AndAlso b Then
            Console.WriteLine("Operands a AndAlso b is true")
        End If

        'use of OrElse operator
        If c OrElse d Then
            Console.WriteLine("Operands a OrElse b is true")
        End If

        'use of not operator
        If c Or d Then
            Console.WriteLine("Output of not (a and b) is true")
        End If

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Module
