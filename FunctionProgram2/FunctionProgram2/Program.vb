Imports System
Module Program
    'Declaring a Function
    Function hypotenuseCalc(sideA As Double, sideB As Double) As Double

        Dim hypo As Double
        hypo = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
        Return hypo
    End Function
    Sub Main(args As String())

        Dim sideA As Double
        Dim sideB As Double
        Dim hypotenuse As Double
        Console.WriteLine("Enter side A : ")
        sideA = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Enter side B : ")
        sideB = Console.ReadLine()
        Console.WriteLine()
        hypotenuse = hypotenuseCalc(sideA, sideB)
        Console.WriteLine("The Length of the Hypotenuse is : {0}", hypotenuse)
        Console.WriteLine()
        Console.WriteLine("Submitted by : Joey Aibert U. Collado")
        Console.WriteLine("Submitted to : Ma Femia Moreno")
    End Sub
End Module
