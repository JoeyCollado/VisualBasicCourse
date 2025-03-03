Imports System

Module Program
    Sub Main(args As String())

        ' Declaring variables
        Dim b As Byte
        Dim num As Integer
        Dim db As Single
        Dim si As Double
        Dim get_date As Date
        Dim c As Char
        Dim str As String

        ' Assigning values
        b = 1
        num = 20
        db = 0.12
        si = 2131.787
        get_date = Today
        c = "A"
        str = "Joey Aibert U. Collado"

        ' Displaying the concatenated string in the console along with the values
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Welcome To Visual Basic Network")
        Console.WriteLine("Byte    = {0}", b)
        Console.WriteLine("Integer = {0}", num)
        Console.WriteLine("Single  = {0}", si)
        Console.WriteLine("Double  = {0}", db)
        Console.WriteLine("Date    = {0}", get_date)
        Console.WriteLine("Char    = {0}", c)
        Console.WriteLine("My name is  = {0}", str & " And i am an BSCS")
        Console.WriteLine("Submitted by: Joey Aibert U. Collado")
        Console.WriteLine("Submitted to: Ma Femia Moreno")
        Console.ReadKey()
    End Sub
End Module
