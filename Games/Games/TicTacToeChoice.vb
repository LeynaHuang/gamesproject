Public Class TicTacToeChoice
    'Opens player vs AI Tic-Tac-Toe game
    Private Sub btnAI_Click(sender As Object, e As EventArgs) Handles btnAI.Click
        Dim ticTacToeAIBox = New TicTacToeAI()
        ticTacToeAIBox.Show()
        Me.Close()
    End Sub

    'Opens player vs player Tic-Tac-Toe game
    Private Sub btnPVP_Click(sender As Object, e As EventArgs) Handles btnPVP.Click
        Dim ticTacToePVPBox = New TicTacToe()
        ticTacToePVPBox.Show()
        Me.Close()
    End Sub
End Class