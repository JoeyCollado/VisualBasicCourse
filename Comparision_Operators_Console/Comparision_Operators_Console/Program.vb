Imports System

Module Program
    Sub Main(args As String())

        ' comparision operators
        'Comparison Operators
        'As the name suggests, the Comparison Operator Is used to compare the value of two variables
        'Or operands for the various condition such as greater, less than Or equal, etc. And returns a
        'Boolean value either true Or false based on the condition.

        Dim x As Integer = 5
        Dim y As Integer = 10
        Dim result, obj1, obj2 As Object
        Dim str, str2 As String

        'assignment
        str = "Apple12345"
        str2 = "Apple12345"
        obj1 = 10
        obj2 = 20

        'output

        'use of > Operator
        Console.WriteLine("Output of x > y {0}", x > y)

        'use of < Operator
        Console.WriteLine("Output of x < y {0}", x < y)

        'use of = Operator
        Console.WriteLine("Output of x = y {0}", x = y)

        'use of <> operator
        Console.WriteLine("Output of x <> y {0}", x <> y)

        'use of >= Operator
        Console.WriteLine("Output of x >= y {0}", x >= y)

        'use of <= Operator
        Console.WriteLine("Output of x >= y {0}", x <= y)

        'use of is Operator
        result = obj1 Is obj2
        Console.WriteLine("Outout of obj1 Is obj2 is {0}", result)

        'use of is not Operator
        result = obj1 IsNot obj2
        Console.WriteLine("Outout of obj1 IsNot obj2 is {0}", result)

        'use of like operator
        result = str Like str2
        Console.WriteLine("Output of str1 Like str2 is {0}", result)

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()





    End Sub
End Module
