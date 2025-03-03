Imports System

Module Program
    Sub Main(args As String())

        'declaration
        Dim i As Integer = 1

        Do
            Console.WriteLine("Value of i is: {0}", i) 'output
            i = i + 1                                  ' i is incremented by 1
        Loop While i <= 10                             ' loop will execute as long as i is less than or  equal to 10

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub
End Module
