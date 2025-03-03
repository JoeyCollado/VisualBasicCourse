Imports System
Module Program
    Sub Main(args As String())
        'creating instance for the classes
        Dim DM As New display()
        Dim GD As New density()
        '
        'declaring variables in which i placed the values to be calculated
        Dim mass As Double = 100.1
        Dim volume As Double = 100.1
        '
        'storing the class density inside this variable and passing the two arguments which is mass and volume
        Dim Density As Double = GD.getDensity(mass, volume)
        '
        'displaying the following outputs
        Console.WriteLine("****************************************************************") 'design
        DM.displayMessage() 'display the output for the display class
        Console.WriteLine("****************************************************************") 'design
        Console.WriteLine("The Density is : {0} g/cm3", Density) 'display the output for the density class
        Console.WriteLine("****************************************************************") 'design
        Console.WriteLine("Submitted by : Joey Aibert U. Collado ")
        Console.WriteLine("Submitted to : Ma Femia Moreno")
    End Sub
End Module
