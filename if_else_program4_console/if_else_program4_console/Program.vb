Imports System

Module Program
    Sub Main(args As String())
        'program to show the uses of If... ElseIf statements.

        Dim var1 As Integer

        Console.WriteLine("enter a number")
        var1 = Console.ReadLine

        If var1 = 20 Then
            Console.WriteLine("the number is equal to 20")

        ElseIf var1 < 50 Then
            Console.WriteLine("the number is less than 50")

        ElseIf var1 >= 100 Then
            Console.WriteLine("the number is greater or equal to 100")

        Else
            Console.WriteLine("the number doesnt match anything")
        End If

        Console.WriteLine("the number you enter is : {0}", var1)

    End Sub
End Module
