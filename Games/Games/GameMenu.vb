Public Class GameMenu
    Private Sub TicTacToe_Click(sender As Object, e As EventArgs) Handles openTicTacToe.Click
        Dim ticTacToeChoiceBox = New TicTacToeChoice()
        ticTacToeChoiceBox.Show()
        Me.Hide()
    End Sub
End Class