Public Class TicTacToe
    Dim roundNum As Integer = 1

    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teamXTurn.Visible = True
        teamOTurn.Visible = False
    End Sub

    Private Sub ticTacToe_Terminate(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles _
            Me.FormClosing
        GameMenu.Show()
    End Sub

    'Checks if there is 3 matches in a row/column/diagonal
    'If yes, output winner and start next round
    Private Sub checkWinner()
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then '1st row
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then '2nd row
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then '3rd row
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then 'diagonal from 1
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then 'diagonal from 3
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then '1st column
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then '2nd column
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then '3rd column
            MsgBox("Congratulations! Team Ex has won this round!")
            ptCounterX.Text += 1
            resetBoard()
        ElseIf btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then '1st row
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then '2nd row
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then '3rd row
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then 'diagonal from 1
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then 'diagonal from 3
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then '1st column
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then '2nd column
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        ElseIf btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then '3rd column
            MsgBox("Congratulations! Team Oh has won this round!")
            ptCounterO.Text += 1
            resetBoard()
        Else
            checkTie()
        End If
    End Sub

    'Checks if the board is full and there is no winner
    'If yes, then it's a tie
    Private Sub checkTie()
        If btn1.Enabled = False And btn2.Enabled = False And btn3.Enabled = False And btn4.Enabled = False _
            And btn5.Enabled = False And btn6.Enabled = False And btn7.Enabled = False And
            btn8.Enabled = False And btn9.Enabled = False Then
            MsgBox("This round is a tie!")
            resetBoard()
        End If
    End Sub

    'Resets board after a win
    Private Sub resetBoard()
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        roundNum += 1
        roundCounter.Text = "Round " & CStr(roundNum)
        teamXTurn.Visible = True
        teamOTurn.Visible = False
    End Sub

    'Handles the reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ptCounterO.Text = "0"
        ptCounterX.Text = "0"
        roundCounter.Text = "Round 1"
        roundNum = 1
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        teamXTurn.Visible = True
        teamOTurn.Visible = False
    End Sub

    'Handles the upper left btn
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If teamXTurn.Visible = True Then
            btn1.Text = "X"

            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn1.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn1.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn1.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the upper mid btn
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If teamXTurn.Visible = True Then
            btn2.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn2.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn2.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn2.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the upper right btn
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If teamXTurn.Visible = True Then
            btn3.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn3.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn3.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn3.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the mid left btn
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If teamXTurn.Visible = True Then
            btn4.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn4.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn4.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn4.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the mid mid btn
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If teamXTurn.Visible = True Then
            btn5.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn5.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn5.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn5.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the mid right btn
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If teamXTurn.Visible = True Then
            btn6.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn6.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn6.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn6.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the lower left btn
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If teamXTurn.Visible = True Then
            btn7.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn7.Enabled = False
            checkWinner()

        ElseIf teamOTurn.Visible = True Then
            btn7.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn7.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the lower mid btn
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If teamXTurn.Visible = True Then
            btn8.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn8.Enabled = False
            checkWinner()
        ElseIf teamOTurn.Visible = True Then
            btn8.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn8.Enabled = False
            checkWinner()

        End If
    End Sub

    'Handles the lower right btn
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If teamXTurn.Visible = True Then
            btn9.Text = "X"
            teamXTurn.Visible = False
            teamOTurn.Visible = True
            btn9.Enabled = False
            checkWinner()
        ElseIf teamOTurn.Visible = True Then
            btn9.Text = "O"
            teamOTurn.Visible = False
            teamXTurn.Visible = True
            btn9.Enabled = False
            checkWinner()
        End If
    End Sub
End Class
