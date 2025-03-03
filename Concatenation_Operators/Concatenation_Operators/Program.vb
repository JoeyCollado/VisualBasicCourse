Imports System

Module Program
    Sub Main(args As String())

        Dim str1 As String = "wel"
        Dim str2 As String = "come"
        Dim str3 As String = " "
        Dim str4 As String = "to JavaPoint"

        '
        Dim result As String
        Dim result2 As String

        '
        result = str1 & str2
        Console.WriteLine("Result = str1 & str2 = {0}", result)

        result2 = str1 + str2 + str3 + str4
        Console.WriteLine("Result = str1 + str2 + str3 + str4 gives = {0}", result2.ToString)

        Console.ReadLine()
    End Sub
End Module
