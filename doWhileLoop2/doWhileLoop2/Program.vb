Imports System

Module Program
    Sub Main(args As String())

        Dim i As Integer = 1
        Dim j As Integer = 1

        Do 'outer loop
            Console.WriteLine("Execution of outer loop is: {0}", i & " times")
            i = i + 1

            Do 'inner loop
                Console.WriteLine("Execution of inner loop is: {0}", j)
                j = j + 1

            Loop While j < 3 'inner loop while repetition
            Console.WriteLine() 'provide space
        Loop While i < 4 'outer loop while repetition

        Console.WriteLine("Exit from the loop")

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
