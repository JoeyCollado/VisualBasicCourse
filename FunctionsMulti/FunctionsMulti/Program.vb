Imports System

Module Program
    Sub Main(args As String())

        Dim a As Double
        Dim b As Double
        Dim hypotenuse As Double
        Dim total, total2, total3, total4 As Double


        Console.WriteLine("Enter Value 1: ")
        a = Console.ReadLine()

        Console.WriteLine("Enter Value 2: ")
        b = Console.ReadLine()

        total = add(a, b)
        total2 = subt(a, b)
        total3 = Mult(a, b)
        total4 = divi(a, b)
        hypotenuse = hypotenuseCalc(a, b)

        Console.WriteLine()
        Console.WriteLine("The sum is: {0}", total)
        Console.WriteLine("The subtraction is: {0}", total2)
        Console.WriteLine("The multiplication is: {0}", total)
        Console.WriteLine("The division is: {0}", total)
        Console.WriteLine("The hypotenuse is: {0}", hypotenuse)
    End Sub

    Function add(val1 As Double, val2 As Double) As Double
        Return (val1 + val2)
    End Function

    Function subt(val1 As Double, val2 As Double) As Double
        Return (val1 - val2)
    End Function

    Function mult(val1 As Double, val2 As Double) As Double
        Return (val1 * val2)
    End Function

    Function divi(val1 As Double, val2 As Double) As Double
        Return (val1 / val2)
    End Function

    Function hypotenuseCalc(sideA As Double, sideB As Double) As Double
        Return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
    End Function

End Module
