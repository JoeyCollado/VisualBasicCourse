Imports System

Module Program
    Sub Main(args As String())


        Dim temp As Double
        Dim unit As Integer

        Console.WriteLine("Temperature Conversion Program")
        Console.WriteLine("")
        Console.WriteLine("1 = Farenheit")
        Console.WriteLine("2 = Celcius")
        unit = Console.ReadLine

        If (unit = 1) Then
            Console.WriteLine("Enter temperature in celcius: ")
            temp = Console.ReadLine

            temp = (1.8 * temp) + 32.0
            Console.WriteLine("Temperature in celcius is: {0}", temp)

        ElseIf (unit = 2) Then
            Console.WriteLine("Enter temperature in fareheit: ")
            temp = Console.ReadLine

            temp = (temp - 32) / 1.8
            Console.WriteLine("Temperaute in farenheit is: {0}", temp)

        Else
            Console.WriteLine("Only enter between 1 or 2")

        End If





    End Sub
End Module
