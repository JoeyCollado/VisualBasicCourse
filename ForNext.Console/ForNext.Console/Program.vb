Imports System

Module Program
    Sub Main(args As String())
        'one of the 3 fundamental constructs namely "iteration"
        'iteration = means executing a block of code repeatedly also known as looping
        ' you can do it using 
        ' for loop
        ' do loop

        'for loop
        Dim count As Integer
        ' you can change the step value at the end of for statement "Step (value)" for example Step 5 which means your program will count every after 5 number
        ' if you want to count backwards just set the values to "2 To 6  Step -2"

        For count = 0 To 6 Step 2 ' in this case program will count to 0-6 every 2 num
            Beep() 'program will beep each iteration
            Threading.Thread.Sleep(3000) 'iteration will execute every 3 seconds
            MsgBox("Hello " & count)
        Next
    End Sub
End Module
