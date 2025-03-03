Imports System


Module Program
    Sub Main(args As String())

        Dim num1, num2 As Integer

        Console.WriteLine("Enter any 2 number")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()

        If num1 > num2 Then
            Console.WriteLine("Num 1 is greater than Num 2")
        Else
            Console.WriteLine("Num 2 is greater than Num 1")
        End If
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()







    End Sub
End Module
