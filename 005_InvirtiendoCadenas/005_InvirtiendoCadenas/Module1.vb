'/*
' * Crea un programa que invierta el orden de una cadena de texto
' * sin usar funciones propias del lenguaje que lo hagan de forma automática.
' * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
' */

Module Module1


#Region "Variables y constantes principales"
    Const MINT_START As Integer = 0

    Dim mStrImputMessage As String = "Hola mundo"
    Dim mStrReverseMessage As String = String.Empty
#End Region

    Sub Main()

        ReverseText(mStrImputMessage)
        Console.WriteLine(mStrReverseMessage)

    End Sub

#Region "Funciones propias"

    Private Sub ReverseText(aStrMessage As String)

#Region "Variables locales del procedimiento"
        Dim lCharSubstring As Char
        Dim lIntEnd As Integer = aStrMessage.Length - 1
#End Region

        For index As Integer = lIntEnd To MINT_START Step -1
            lCharSubstring = aStrMessage.Substring(index)
            mStrReverseMessage += lCharSubstring
        Next

    End Sub

#End Region

End Module
