Imports System

Module Program
    Sub Main(args As String())

        Dim a As Boolean = True
        Dim b As Boolean = False
        Dim c, d As Integer

        '
        c = 10
        d = 20

        '
        If a And b Then
            Console.WriteLine("Operands a And b are true")
        End If

        If a Or b Then
            Console.WriteLine("Operands a Or b are true")
        End If

        If a Xor b Then
            Console.WriteLine("Operands a Xor b are true")
        End If

        If c And d Then
            Console.WriteLine("Operands c And d are true")
        End If

        If c Or d Then
            Console.WriteLine("Operands c Or d are true")
        End If

        If a AndAlso b Then
            Console.WriteLine("Operands a AndAlso b are true")
        End If

        If a OrElse b Then
            Console.WriteLine("Operands a OrElse b are true")
        End If

        If Not (a And b) Then
            Console.WriteLine("Output of Not (a and b) are true")
        End If



        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
