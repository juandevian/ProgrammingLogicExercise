Imports _5_ÁREA_DE_UN_POLÍGONO.AreaDeUnPoligono
' RETO #5
' * ÁREA DE UN POLÍGONO
' * Fecha publicación enunciado: 24/01/22
' * Fecha publicación resolución: 31/01/22
' * Fecha resolución IanVillegas: 18/09/24
' * Dificultad: FÁCIL
'
'   Enunciado: Crea UNA ÚNICA FUNCIÓN (importante que sólo sea una)
'   que sea capaz de calcular y retornar el área de un polígono.
'   * - La función recibirá por parámetro sólo UN polígono a la vez.
'   * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
'   * - Imprime el cálculo del área de un polígono de cada tipo.
'   *
'   * Información adicional:
'   * - Resolveré uno a uno los retos de (https://retosdeprogramacion.com/ejercicios/)
'   * Esta es mi interpretación propia del problema y la resolución.
'   * Subiré a mi GitHub la solución dada por mí al problema, también,
'   * luego de revisar las soluciones de otros desarrolladores, decido crear
'   * otra implementación que la desarrollaré en este mismo módlo.

Module Module1


    Sub Main()

        '' Solución 1, Resolución al problema planteado con mi interpretación.

        'Dim lbytPolygon As Byte
        'Dim ldecAreaPolygon As Decimal = Nothing

        'Try

        '    Console.WriteLine("Elige el número correspondiente al polígono que deseas calcular el área: 1. Triángulo, 2. Cuadrado, 3. Rectángulo")
        '    lbytPolygon = Val(Console.ReadLine())

        '    ldecAreaPolygon = fdecCalculateAreaOfAPolygon(lbytPolygon)

        'Catch ex As Exception

        '    MsgBox(ex.Message)

        'End Try

        'If ldecAreaPolygon = 0 Then
        '    Console.WriteLine("Reinicia la aplicación porque hay algún error en los valores ingresados")
        'ElseIf ldecAreaPolygon > 0 Then
        '    Console.WriteLine("El área total del poligono ingresado es: " & ldecAreaPolygon.ToString)
        'End If

        ' Solución 2, basada en clases y herencias.

        AreaOfAPolygon(New Triangulo(10, 5))
        Dim area = AreaOfAPolygon(New Cuadrado(10))
        AreaOfAPolygon(New Rectangulo(10, 5))


        'Console.WriteLine("Esta es el área del resultado area. " & area)
    End Sub


    Private Function AreaOfAPolygon(polygon As CBPolygon) As Decimal

        polygon.PrintAreaOfPoligon()
        Return polygon.PropAreaOfPolygon

    End Function

    Private Function fdecCalculateAreaOfAPolygon(abytPolygon As Byte) As Decimal
        Dim ldecWidth As Decimal
        Dim ldecHigh As Decimal
        Dim lstrPolygon As String
        Dim ldecAreaOfolygon As Decimal

        Select Case abytPolygon
            Case 1 'Triángulo

                lstrPolygon = "Triángulo"

                Console.WriteLine("Ingresa la altura del " & lstrPolygon)
                ldecWidth = Val(Console.ReadLine())
                Console.WriteLine("Ingresa la base del " & lstrPolygon)
                ldecHigh = Val(Console.ReadLine())
                ldecAreaOfolygon = (ldecHigh * ldecWidth) / 2

            Case 2 'Cuadrado

                lstrPolygon = "Cuadrado"

                Console.WriteLine("Ingresa la altura del " & lstrPolygon)
                ldecWidth = Val(Console.ReadLine())
                ldecHigh = ldecWidth
                ldecAreaOfolygon = ldecHigh * ldecWidth

            Case 3 'Rectángulo

                lstrPolygon = "Rectángulo"

                Console.WriteLine("Ingresa la altura del " & lstrPolygon)
                ldecWidth = Val(Console.ReadLine())
                Console.WriteLine("Ingresa la base del " & lstrPolygon)
                ldecHigh = Val(Console.ReadLine())
                ldecAreaOfolygon = ldecWidth * ldecHigh

            Case Else
                ldecAreaOfolygon = 0
        End Select

        Return ldecAreaOfolygon
    End Function


End Module
