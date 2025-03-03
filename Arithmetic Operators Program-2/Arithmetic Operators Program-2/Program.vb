Imports System

Module Hypotenuse
    Sub Main(args As String())

        'declaring the variables
        Dim a As Double
        Dim b As Double
        Dim hypotenuse As Double

        'assigning two values
        a = 32
        b = 12

        'hypotenuse formula
        hypotenuse = Math.Sqrt(a * a + b * b)

        'displaying the output
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine(hypotenuse)


    End Sub
End Module
