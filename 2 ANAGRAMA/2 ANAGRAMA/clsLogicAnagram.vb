Public Class clsLogicAnagram


    Friend Function fstrMessageIsAnagram(astrFirstWord As String, astrSecondWord As String) As String


        Dim lstrFirstWord As String = astrFirstWord.ToUpper.Trim
        Dim lstrSecondWord As String = astrSecondWord.ToUpper.Trim
        Dim lstrMsgIsAnagram = If(fbolIsAnagram(lstrFirstWord, lstrSecondWord),
            "Excelente!! Las palabras " & astrFirstWord & " y " & astrSecondWord & " son anagramas",
            "Las palabras " & lstrFirstWord & " y " & lstrSecondWord & " no son anagramas")

        Return lstrMsgIsAnagram
    End Function


    Friend Function fbolIsAnagram(astrFirstWord As String, astrSecondWord As String) As Boolean

        Dim lblnIsAnagram As Boolean = False

        If astrFirstWord.Length = astrSecondWord.Length AndAlso astrFirstWord <> astrSecondWord Then

            If fintValidCharToChar(astrFirstWord, astrSecondWord) <> -1 Then

                lblnIsAnagram = True

            End If

        End If

        Return lblnIsAnagram


    End Function

    Private Function fintValidCharToChar(astrFirstWord As String, astrSecondWord As String) As Integer

        Const INT_START_SEARCH As Integer = 0
        Const INT_QUANTITY_LETTERS As Integer = 1

        Dim lintLenghtSecondWord As Integer
        Dim lintIndexWord As Integer
        Dim lintQuantity As Integer = -1

        Try

            For Each letter In astrFirstWord

                lintLenghtSecondWord = astrSecondWord.Length
                lintIndexWord = astrSecondWord.IndexOf(letter, INT_START_SEARCH, lintLenghtSecondWord)

                If lintIndexWord <> -1 Then

                    astrSecondWord = astrSecondWord.Remove(lintIndexWord, INT_QUANTITY_LETTERS)

                Else

                    lintQuantity = -1
                    Exit For

                End If

                lintQuantity = astrSecondWord.Length
            Next

        Catch ex As Exception

        End Try

        Return lintQuantity


    End Function


End Class
