Public Class CBPolygon

    Protected High As Decimal
    Protected Width As Decimal
    Protected AreaOfPolygon As Decimal

    Sub New(aHigh As Decimal, aWidth As Decimal)

        Me.High = aHigh
        Me.Width = aWidth
        Me.AreaOfPolygon = 0

    End Sub

    Sub New(aHigh As Decimal)

        Me.High = aHigh
        Me.Width = aHigh
        Me.AreaOfPolygon = 0

    End Sub


    Friend ReadOnly Property GetHighPolygon() As Decimal
        Get
            Return High
        End Get
    End Property

    Friend ReadOnly Property GetWidthPolygon() As Decimal
        Get
            Return Width
        End Get
    End Property

    Friend Property PropAreaOfPolygon() As Decimal
        Get
            Return AreaOfPolygon
        End Get
        Set(value As Decimal)
            AreaOfPolygon = value
        End Set
    End Property


    Friend Overridable Function CalculateAreaOfAPolygon() As Decimal

        Return AreaOfPolygon

    End Function

    Friend Overridable Sub PrintAreaOfPoligon()


    End Sub




End Class
