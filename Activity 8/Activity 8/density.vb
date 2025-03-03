Public Class density

    'creating a function to calculate density
    Public Function getDensity(volume As Double, mass As Double) As Double


        Dim Density As Double     'declaring the variable density

        Density = mass / volume   'storing the formula inside the variable

        Return Density            'setting the formula as the return value

    End Function

End Class
