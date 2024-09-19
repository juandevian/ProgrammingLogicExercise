Class MainWindow
    Private Sub btnCompare_Click(sender As Object, e As RoutedEventArgs) Handles btnCompare.Click

        Dim clsLogicAnagram As New clsLogicAnagram

        MsgBox(clsLogicAnagram.fstrMessageIsAnagram(txtFirstWord.Text.Trim, txtSecondWord.Text.Trim))

        sClearTexBox()




    End Sub

    Private Sub sClearTexBox()

        txtFirstWord.Clear()
        txtSecondWord.Clear()

    End Sub
End Class
