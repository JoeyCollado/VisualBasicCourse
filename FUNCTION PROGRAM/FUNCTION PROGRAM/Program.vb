Imports System

Module Program
    Sub Main(args As String())

        Dim sideA As Double
        Dim sideB As Double
        Dim hypotenuse As Double

        Console.WriteLine("Enter Side A")
        sideA = Console.ReadLine

        Console.WriteLine("Enter Side B")
        sideB = Console.ReadLine

        hypotenuse = hypotenuseCalculator(sideA, sideB)

        Console.WriteLine("The Hypotenuse is {0}", hypotenuse)

    End Sub

    Function hypotenuseCalculator(sideA As Double, sideB As Double) As Double

        Return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2))

    End Function

End Module



