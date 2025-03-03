Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        '
        Dim days As String

        days = "thur"

        Select Case days
            Case "mon"
                Console.WriteLine("it is monday")
            Case "tue"
                Console.WriteLine("it is tuesday")
            Case "wed"
                Console.WriteLine("it is wednesday")
            Case "thur"
                Console.WriteLine("it is thursday")
            Case "fri"
                Console.WriteLine("it is friday")
            Case "sun"
                Console.WriteLine("it is saturday")
            Case "sat"
                Console.WriteLine("it is sunday")
        End Select

        Console.WriteLine("you have selected : {0}", days)

    End Sub
End Module
