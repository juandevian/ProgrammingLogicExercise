
' Reto #7
' CONTANDO PALABRAS
' Fecha publicación enunciado: 14/02/22
' Fecha publicación resolución: 21/02/22
' Dificultad: MEDIA
'
' ╔════════════════════════════════════════╗
' ║ Autor:  Juan Villegas Dev (Ian)        ║
' ║ GitHub: https://github.com/juandevian  ║
' ║ Fecha enunciado: 25/09/2024            ║
' ║ Fecha publicación solución: 25/09/2024 ║
' ║ Dificultad: MEDIA                      ║
' ║ 2024 -  VB.NET                         ║
' ╚════════════════════════════════════════╝
'-----------------------------------------------------
'* CHALLENGE: CONTANDO PALABRAS
'-----------------------------------------------------
' * ENUNCIADO:
' * Crea un programa que cuente cuantas veces se repite cada palabra y que muestre el recuento final de todas ellas.
' * - Los signos de puntuación no forman parte de la palabra.
' * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
' * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan automáticamente.
' ____________________________________________________
' * INFORMACIÓN ADICIONAL:
' * - Usa el canal de nuestro discord (https//mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
' * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
' * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
' * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
' ____________________________________________________
'* COMENTARIOS PERSONALES:
' * - Finalizada
' * - Se me dificultó el manejo de arreglos, quería eliminar cada palabra luego de contada para que no se sumara en el conteo, pero no logré hAcerlo de esta forma.
' * - Aprendí un poco más sobre el manejo de lista.
' * - Ahora debo estudiar Diccionarios.
' * - Revisar que estructuras de datos en VB me permitan almacenar tuplas. 

Module Module1
    Dim mStrText As String = "Hola mi nombre es Juan Villegas (Dev Ian) creador de Optimusof SAS. Soy desarrollador Desktop y me encanta el desarrollo de software."

    Dim mListStrWordsRepeated As List(Of String) = New List(Of String)
    Dim mListIntNumWordsRepeated As List(Of Integer) = New List(Of Integer)

    Sub Main()

        Console.WriteLine("La frase a revisar es:{1}{0}{1}", mStrText, vbCrLf)
        sWordCounter(mStrText)

    End Sub

    ' Word Counter: Count how many words are in a given text
    Private Sub sWordCounter(ByRef aStrText As String)
        Dim lArrStringResultText() As String

        lArrStringResultText = fStrSplitsText(aStrText)

        For Each word In lArrStringResultText
            Dim lIntWordsRepeated As Integer = 0

            If word IsNot Nothing Then

                mListStrWordsRepeated.Add(word)
                For index = 0 To lArrStringResultText.Length - 1 Step 1

                    If lArrStringResultText(index) IsNot Nothing AndAlso word.Equals(lArrStringResultText(index)) Then

                        lIntWordsRepeated += 1
                        lArrStringResultText(index) = Nothing

                    End If
                Next
            End If
            If lIntWordsRepeated <> 0 Then

                mListIntNumWordsRepeated.Add(lIntWordsRepeated)

            End If

        Next

        sShowWordCountResult()

    End Sub

    ' Splits text into an array of strings
    Private Function fStrSplitsText(ByRef aStrText As String) As String()
        Dim lStrNewStringText As String
        Dim lCharSeparators() As Char = {" "c}

        ' Prepare the text to be divided and compared
        lStrNewStringText = aStrText.ToLower.Replace(".", String.Empty).Replace(",", String.Empty).Replace("(", String.Empty).Replace(")", String.Empty)
        Return lStrNewStringText.Split(lCharSeparators, StringSplitOptions.RemoveEmptyEntries)

    End Function

    ' Prints the result of the word count made to the text
    Private Sub sShowWordCountResult()
        If mListIntNumWordsRepeated.Count = mListStrWordsRepeated.Count Then
            For index = 0 To mListStrWordsRepeated.Count - 1

                Dim lStrPluralOrNouns As String
                If mListIntNumWordsRepeated(index) = 1 Then
                    lStrPluralOrNouns = "vez"
                Else
                    lStrPluralOrNouns = "veces"
                End If

                Console.WriteLine("{0} se repitió {1} {2} en el texto.", mListStrWordsRepeated(index).ToUpper, mListIntNumWordsRepeated(index), lStrPluralOrNouns)
                ' Console.Write(vbCrLf & vbCrLf)

            Next

        Else

            Console.WriteLine("Existe un problema con la creación de las listas del resultado en el rpograma.")

        End If

    End Sub

End Module
