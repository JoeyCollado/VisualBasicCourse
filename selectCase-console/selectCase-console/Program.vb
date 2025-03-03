Imports System

Module Program
    Sub Main(args As String())


        Dim myInt As Integer

        Console.WriteLine("Enter an integer (1-5)")
        myInt = Console.ReadLine

        Select Case myInt

            Case 1
                Console.WriteLine("this is 1")
            Case 2
                Console.WriteLine("this is 2")
            Case 3
                Console.WriteLine("this is 3")
            Case 4
                Console.WriteLine("this is 4")
            Case 5
                Console.WriteLine("this is 5")
        End Select

    End Sub
End Module
