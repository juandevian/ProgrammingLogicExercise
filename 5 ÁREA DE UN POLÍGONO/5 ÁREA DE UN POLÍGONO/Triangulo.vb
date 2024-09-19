Public Class Triangulo
    Inherits CBPolygon

    Public Sub New(aHigh As Decimal, aWidth As Decimal)

        MyBase.New(aHigh, aWidth)

    End Sub

    Friend Overrides Function CalculateAreaOfAPolygon() As Decimal

        PropAreaOfPolygon = (GetHighPolygon * GetWidthPolygon) / 2
        Return PropAreaOfPolygon

    End Function

    Friend Overrides Sub PrintAreaOfPoligon()

        CalculateAreaOfAPolygon()
        Console.WriteLine("El área del triángulo ingresado es: " & AreaOfPolygon)

    End Sub









End Class
