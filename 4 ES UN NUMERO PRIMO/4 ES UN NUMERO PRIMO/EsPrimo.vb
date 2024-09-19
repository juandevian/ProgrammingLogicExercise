Module EsPrimo

    Sub Main()
        printPrimeNumber1to100()

        Console.WriteLine("¿ES UN NÚMERO PRIMO?")
        Console.WriteLine("Vamos a comprobar si el núemro ingrresado es primo.")

        Try
            Console.WriteLine("Ingrese un número entero: ")
            Dim lintNumber As Integer = CInt(Console.ReadLine())

            If fboolIsPrimeNumber(lintNumber) Then
                Console.WriteLine("El número " & lintNumber.ToString & " ES primo.")
            Else
                Console.WriteLine("El número " & lintNumber.ToString & " NO ES primo.")
            End If

        Catch e As FormatException

            MsgBox("El número ingresado no es valido, recuerde que debe ingresar un número entero. " & e.Message)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Private Function fboolIsPrimeNumber(aintNumber As Integer) As Boolean
        Dim lboolIsPrimeNumber As Boolean = False

        If aintNumber > 2 AndAlso aintNumber Mod 2 <> 0 Then

            If ((aintNumber + 1) Mod 2) = 0 Then

                Dim lintDividedBy As Integer = (aintNumber + 1) / 2

                For index = 1 To lintDividedBy Step 1

                    If lintDividedBy = 1 Then

                        lboolIsPrimeNumber = True

                    ElseIf aintNumber Mod lintDividedBy = 0 Then

                        Exit For

                    Else

                        lintDividedBy -= 1

                    End If

                Next

            End If

        ElseIf aintNumber = 2 Then

            lboolIsPrimeNumber = True

        End If

        Return lboolIsPrimeNumber

    End Function
    Private Sub printPrimeNumber1to100()
        Console.WriteLine("Los siguientes son los números primos existentes entre uno (1) y cien (100)")

        For index = 1 To 100 Step 1

            If fboolIsPrimeNumber(index) Then

                Console.WriteLine("   --> " & index)

            End If

        Next
    End Sub

End Module
