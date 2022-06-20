Public Class Form1
    Private botChoice As Integer = 0
    Private userChoice As Integer = 0
    Private userScore As Integer = 0
    Private userTry As Integer = 0
    Private maxTry As Integer = 0
    Private maxValue As Integer
    Private userWin As Boolean = False
    Private pbValue As Integer = 0
    Private stepsNbr As Integer = 0
    Private random As Random = New Random()
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        StopGame()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If CbxDifficult.SelectedItem = "" Then
            MessageBox.Show("Vous devez sélectionner une difficulté!!")
        Else
            Timer1.Enabled = True
            BtnStop.Enabled = True
            BtnStart.Enabled = False
            BtnOK.Enabled = True

            StartGame()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'On verifie que la valeur de la barre de progression n'est pas a zero
        'et que le joueur n'a pas gagné et que le nombre d'essais du jouer ne dépasse pas le maximum
        If pbValue >= 0 And userWin = False And userTry < maxTry Then
            PbCountDown.Value = pbValue
            pbValue -= 1
        Else
            If stepsNbr = 10 Then
                Timer1.Stop()
                MessageBox.Show("La partie est finie, vous fait le score de " & userScore)
                StopGame()
                Return
            End If

            'On passe à la prochaine etapes
            stepsNbr += 1
            LblSteps.Text = "Etapes: " & stepsNbr & " sur 10"
            pbValue = 30
            PbCountDown.Value = pbValue
            userTry = 0
            LblTry.Text = "Nombre d'essais: " & userTry & " sur " & maxTry
            userWin = False
            GeneratNumber()
            Threading.Thread.Sleep(2000)
            BtnOK.Enabled = True
        End If

    End Sub

    Private Sub StartGame()
        'On definie les variable suivant la difficulté
        Select Case CbxDifficult.SelectedItem
            Case "Facile"
                maxValue = 5
                maxTry = 3
            Case "Moyen"
                maxValue = 10
                maxTry = 5
            Case "Difficile"
                maxValue = 20
                maxTry = 10
            Case "Expert"
                maxValue = 30
                maxTry = 15
        End Select
        LblTry.Text = "Nombre d'essais: 0 sur " & maxTry
        Timer1.Start()
    End Sub

    Private Sub StopGame()
        'On remet tout à zéro
        BtnStop.Enabled = False
        BtnStart.Enabled = True
        BtnOK.Enabled = False
        Timer1.Stop()
        Timer1.Dispose()
        Timer1.Enabled = False
        LblSteps.Text = "Etapes: 0 sur 10"
        LblScore.Text = "Score: 0"
        LblResultat.Text = "En attente d'une nouvelle partie...."
        LblTry.Text = "Nombre d'essais: 0 sur 0"
        botChoice = 0
        userChoice = 0
        userScore = 0
        userWin = False
        userTry = 0
        pbValue = 30
        stepsNbr = 0
        maxValue = 0
        maxTry = 0
        PbCountDown.Value = pbValue
    End Sub

    Private Sub GeneratNumber()
        'On génère un nombre aléatoire
        botChoice = random.Next(0, maxValue + 1)
        LblResultat.Text = "Jouer"
        LblResultat.ForeColor = Color.Blue
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        'Si la péponse est bonne
        userChoice = TxbResultat.Text
        If userChoice = botChoice Then
            userWin = True
            LblResultat.Text = "Vous avez gagné!!"
            LblResultat.ForeColor = Color.Green
            userScore = userScore + (maxTry - userTry) + 1
            LblScore.Text = "Score: " & userScore
            BtnOK.Enabled = False
        Else
            'Si la réponse est mauvaise
            userTry += 1
            LblTry.Text = "Nombre d'essais: " & userTry & " sur " & maxTry
        End If
        'Si le nombre d'essais est au maximum
        If userTry = maxTry Then
            BtnOK.Enabled = False
            LblResultat.Text = "Vous avez perdu!!"
            LblResultat.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub
End Class
