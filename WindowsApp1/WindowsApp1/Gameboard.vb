Public Class Gameboard

    'Intialize data
    Dim player As String = "X"
    Dim Turn As String = "1"

    'Show whose turn it is
    Private Sub Gameboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblPlayerTurn.Text = player
    End Sub

    'Change the text of the button if clicked on
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Btn1.Text = player
        Btn1.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Btn2.Text = player
        Btn2.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Btn3.Text = player
        Btn3.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Btn4.Text = player
        Btn4.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Btn5.Text = player
        Btn5.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Btn6.Text = player
        Btn6.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Btn7.Text = player
        Btn7.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Btn8.Text = player
        Btn8.Enabled = False
        SwapTurns()
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Btn9.Text = player
        Btn9.Enabled = False
        SwapTurns()
    End Sub

    'Swap turns after player clicks a button
    Private Function SwapTurns()
        Checker()
        If Turn = 1 Then
            player = "O"
            Turn = 2
            Refresher()
        ElseIf Turn = 2 Then
            player = "X"
            Turn = 1
            Refresher()
        End If
        Return "Swapped Turns"
    End Function

    'Check if someone won the game
    Private Function Checker()

        Iftied()

        'Did player X win the game
        If Btn1.Text = "X" And Btn2.Text = "X" And Btn3.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn4.Text = "X" And Btn5.Text = "X" And Btn6.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn7.Text = "X" And Btn8.Text = "X" And Btn9.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn1.Text = "X" And Btn4.Text = "X" And Btn7.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn2.Text = "X" And Btn5.Text = "X" And Btn8.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn3.Text = "X" And Btn6.Text = "X" And Btn9.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn1.Text = "X" And Btn5.Text = "X" And Btn9.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        If Btn7.Text = "X" And Btn5.Text = "X" And Btn3.Text = "X" Then
            Result.Show()
            Result.LblPlayerWon.Text = "X"
            Pause()
        End If

        'Did player O win the game
        If Btn1.Text = "O" And Btn2.Text = "O" And Btn3.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn4.Text = "O" And Btn5.Text = "O" And Btn6.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn7.Text = "O" And Btn8.Text = "O" And Btn9.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn1.Text = "O" And Btn4.Text = "O" And Btn7.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn2.Text = "O" And Btn5.Text = "O" And Btn8.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn3.Text = "O" And Btn6.Text = "O" And Btn9.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn1.Text = "O" And Btn5.Text = "O" And Btn9.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        If Btn7.Text = "O" And Btn5.Text = "O" And Btn3.Text = "O" Then
            Result.Show()
            Result.LblPlayerWon.Text = "O"
            Pause()
        End If

        Return "Checked"
    End Function

    'Pause functionality of tic tac toe board
    Private Function Pause()
        Btn1.Enabled = False
        Btn2.Enabled = False
        Btn3.Enabled = False
        Btn4.Enabled = False
        Btn5.Enabled = False
        Btn6.Enabled = False
        Btn7.Enabled = False
        Btn8.Enabled = False
        Btn9.Enabled = False
        Return "Game is paused"
    End Function

    'Refresh the data for player turn display
    Private Function Refresher()
        LblPlayerTurn.Text = player
        Return "Updated Values"
    End Function

    'Check if there is a tie
    Private Function Iftied()
        Dim count As Integer = 0

        If Not (Btn1.Enabled Or Btn2.Enabled Or Btn3.Enabled Or
           Btn4.Enabled Or Btn5.Enabled Or Btn6.Enabled Or
           Btn7.Enabled Or Btn8.Enabled Or Btn9.Enabled) Then

            Result.Show()
            Result.LblPlayerWon.Text = "TIE"
            Pause()
        End If

        Return "Tied"
    End Function

    'Reset all data
    Public Function Reset()
        Btn1.Enabled = True
        Btn2.Enabled = True
        Btn3.Enabled = True
        Btn4.Enabled = True
        Btn5.Enabled = True
        Btn6.Enabled = True
        Btn7.Enabled = True
        Btn8.Enabled = True
        Btn9.Enabled = True

        Btn1.Text = ""
        Btn2.Text = ""
        Btn3.Text = ""
        Btn4.Text = ""
        Btn5.Text = ""
        Btn6.Text = ""
        Btn7.Text = ""
        Btn8.Text = ""
        Btn9.Text = ""

        player = "X"
        Turn = 1

        Refresher()
        Return "Game Reset"
    End Function

    'Link the reset function to the reset button
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Reset()
    End Sub
End Class
