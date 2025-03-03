Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        '
        Dim num1, num2, sum As Integer
        Dim def As Char

        'declaring and initializing
        num1 = 6
        num1 = 12

        'prompt user
        Console.WriteLine("Want to perform any operation")
        Console.WriteLine("A for addition")
        Console.WriteLine("S for subtraction")
        Console.WriteLine("M for multiplication")
        Console.WriteLine("D for division")
        Console.WriteLine("Please enter any input")
        'read def variable
        def = Console.ReadLine
        'select case statement
        Select Case def
            Case "A".ToLower
                sum = num1 + num2
                Console.WriteLine("the addition of num1 + num2 is {0}", sum)
            Case "S".ToLower
                sum = num1 - num2
                Console.WriteLine("the addition of num1 - num2 is {0}", sum)
            Case "M".ToLower
                sum = num1 * num2
                Console.WriteLine("the addition of num1 * num2 is {0}", sum)
            Case "D".ToLower
                sum = num1 / num2
                Console.WriteLine("the addition of num1 / num2 is {0}", sum)
            Case Else
                Console.WriteLine("Please enter a vaild input")
        End Select
    End Sub
End Module
