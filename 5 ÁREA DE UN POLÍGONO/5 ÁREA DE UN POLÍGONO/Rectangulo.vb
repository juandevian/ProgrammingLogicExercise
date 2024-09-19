Public Class Rectangulo
    Inherits CBPolygon

    Sub New(aHigh As Decimal, aWidth As Decimal)

        MyBase.New(aHigh, aWidth)

    End Sub

    Friend Overrides Function CalculateAreaOfAPolygon() As Decimal

        PropAreaOfPolygon = GetHighPolygon * GetWidthPolygon
        Return PropAreaOfPolygon

    End Function

    Friend Overrides Sub PrintAreaOfPoligon()

        CalculateAreaOfAPolygon()
        Console.WriteLine("El área del Rectángulo ingresado es: " & AreaOfPolygon)

    End Sub





End Class
