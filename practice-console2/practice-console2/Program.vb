Imports System

Module Program
    Sub Main(args As String())


        'declaring variables
        Dim x As Integer
        Dim y As Integer
        Dim obj1, obj2, result1, result2, result3 As Object
        Dim str1, str2 As String

        'initialization
        x = 12
        y = 24

        str1 = "12345"
        str2 = "12345"

        obj1 = 30
        obj2 = 40

        result1 = obj1 Is obj2
        result2 = obj1 IsNot obj2
        result3 = obj1 Like obj2
        '
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("Program of comparison operator")
        Console.WriteLine(" ")
        Console.WriteLine("Output of x > y is {0}", x > y)
        Console.WriteLine("Output of x < y is {0}", x < y)
        Console.WriteLine("Output of x = y is {0}", x = y)
        Console.WriteLine("Output of x <> y is {0}", x <> y)
        Console.WriteLine("Output of x >= y is {0}", x >= y)
        Console.WriteLine("Output of x <= y is {0}", x <= y)
        Console.WriteLine("Output of obj1 is obj2 is {0}", result1)
        Console.WriteLine("Output of obj1 isNot obj2 is {0}", result2)
        Console.WriteLine("Output of str1 Like str2 is {0}", result3)
        Console.WriteLine(" ")
        Console.WriteLine("Submitted to: Ma femia Moreno")
        Console.WriteLine("Submitted by: Joey Aibert U. Collado")
        Console.WriteLine(" ")
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()



    End Sub
End Module
