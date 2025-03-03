Imports System

Module Rectangle
    'declaring global variables
    Public length As Integer

    Public breadth As Integer
    'declaring a global variable in which we assigned values to those two global variables
    Public Sub dimension()
        length = 5
        breadth = 6

    End Sub
    'creating a function or method that inherits the values of global variables
    Public Function area() As Integer
        area = length * breadth
    End Function
    'creating a function or method that inherits the values of global variables
    Public Function pera() As Integer
        pera = 2 * (length + breadth)
    End Function
    'creating a function that will display all the outputs
    Public Sub display()
        Console.WriteLine("Length is {0}", length)
        Console.WriteLine("Breadth is {0}", breadth)
        Console.WriteLine("Area of Rectangle is {0}", area())
        Console.WriteLine("perimter of Rectangle is {0}", pera())
    End Sub
    'a local function that will call all the global functions
    Sub main()

        dimension() ' directly call the function in main method
        area()
        pera()
        display()
        Console.WriteLine("press any key to exit")
        Console.ReadKey()
    End Sub
End Module

