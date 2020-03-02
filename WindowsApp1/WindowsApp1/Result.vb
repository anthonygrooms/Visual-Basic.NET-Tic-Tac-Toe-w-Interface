Public Class Result
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Gameboard.Reset()
        Close()
    End Sub
End Class