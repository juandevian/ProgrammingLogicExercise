Module Module1
    ''' Reto #0
    ''' EL FAMOSO "FIZZ BUZZ"
    ''' Fecha publicación enunciado: 27/12/21
    ''' Fecha publicación resolución: 03/01/22
    ''' Dificultad: FÁCIL
    ''' 
    ''' Fecha publicación resolución DEVIAN: 19/09/24
    ''' 
    ''' 
    ''' Escribe un programa que muestre por consola (con un print) los
    ''' números de 1 a 100 (ambos incluidos y con un salto de línea entre
    ''' cada impresión), sustituyendo los siguientes:
    ''' - Múltiplos de 3 por la palabra "fizz".
    ''' - Múltiplos de 5 por la palabra "buzz".
    ''' - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz"
    ''' 
    ''' Repositorio: https://github.com/mouredev/Weekly-Challenge-2022-Kotlin/blob/main/app/src/main/java/com/mouredev/weeklychallenge2022/Challenge0.kt
    ''' Repositorio personal: 

    Sub Main()

        FizzBuzzPrint(1, 100)

    End Sub

    Private Function FizzBuzz(num) As String
        Dim numFizzBuzz As String
        If num Mod 3 = 0 Then
            numFizzBuzz = "fizz"
            If num Mod 5 = 0 Then
                numFizzBuzz += "buzz"
            End If
        ElseIf num Mod 5 = 0 Then
            numFizzBuzz = "buzz"
        Else
            numFizzBuzz = num.ToString()
        End If
        Return numFizzBuzz
    End Function

    Private Sub FizzBuzzPrint(aStartNumber As Integer, aEndNumber As Integer)
        For number As Integer = aStartNumber To aEndNumber
            Console.WriteLine(FizzBuzz(number))
        Next
    End Sub

End Module


