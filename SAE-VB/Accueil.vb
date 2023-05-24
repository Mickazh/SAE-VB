Public Class FormAccueil
    Private indexJ1, indexJ2 As Integer

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJoueur2.SelectedIndexChanged

    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboJoueur1.Sorted = True
        cboJoueur2.Sorted = True
        refreshCbo()
    End Sub

    Private Sub refreshCbo()
        Dim joueurs As Joueur() = ModuleJoueur.getJoueurs()
        cboJoueur1.Items.Clear()
        cboJoueur2.Items.Clear()
        For i As Integer = 0 To joueurs.Length - 1
            cboJoueur1.Items.Add(Trim(joueurs(i).nom))
            cboJoueur2.Items.Add(Trim(joueurs(i).nom))
        Next
    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Dim choix = MsgBox("Voulez vous quitter?", vbYesNo)
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStartJeu_Click(sender As Object, e As EventArgs) Handles btnStartJeu.Click
        Dim joueurPasValide = False
        For Each cbo As ComboBox In PnlJoueurs.Controls
            If Trim(cbo.Text).Equals("") Then
                cbo.BackColor = Color.Red
                joueurPasValide = True
            End If
        Next
        If Trim(cboJoueur1.Text).Equals(Trim(cboJoueur2.Text)) AndAlso Not Trim(cboJoueur1.Text).Equals("") Then
            MsgBox("Vous avez le meme nom")
            joueurPasValide = True
        End If
        If joueurPasValide Then
            Exit Sub
        End If

        indexJ1 = ModuleJoueur.getIndexJoueurByName(cboJoueur1.Text)
        indexJ2 = ModuleJoueur.getIndexJoueurByName(cboJoueur2.Text)

        If indexJ1 = -1 Then
            Dim j = New Joueur
            j.nom = cboJoueur1.Text
            indexJ1 = ModuleJoueur.enregistrerNouveauJoueur(j)
        End If
        'pas très propre
        If indexJ2 = -1 Then
            Dim j = New Joueur
            j.nom = cboJoueur2.Text
            indexJ2 = ModuleJoueur.enregistrerNouveauJoueur(j)
        End If

        refreshCbo()
        Me.Hide()
        LectParam()
        combin.Show()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Me.Hide()
        Score.Show()
    End Sub

    Private Sub cboJoueur_GotFocus(sender As Object, e As EventArgs) Handles cboJoueur1.GotFocus, cboJoueur2.GotFocus
        sender.backColor = Color.White
    End Sub
End Class
