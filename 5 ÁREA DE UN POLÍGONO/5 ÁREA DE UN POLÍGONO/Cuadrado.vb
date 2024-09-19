Public Class Cuadrado
    Inherits CBPolygon

    Friend Sub New(aHigh As Decimal)

        MyBase.New(aHigh)

    End Sub

    Friend Overrides Function CalculateAreaOfAPolygon() As Decimal

        PropAreaOfPolygon = GetHighPolygon * GetWidthPolygon
        Return PropAreaOfPolygon

    End Function

    Friend Overrides Sub PrintAreaOfPoligon()
        CalculateAreaOfAPolygon()
        Console.WriteLine("El área del cuadrado ingresado es: " & AreaOfPolygon)
    End Sub

End Class
