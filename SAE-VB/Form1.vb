﻿Public Class FormAccueil
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJoueur2.SelectedIndexChanged

    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboJoueur1.Sorted = True
        cboJoueur2.Sorted = True
        For i As Integer = 0 To joueurs.Length - 1
            MsgBox(joueurs(i))
            cboJoueur1.Items.Add(joueurs(i))
            cboJoueur2.Items.Add(joueurs(i))
        Next
    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Dim choix = MsgBox("Voulez vous quitter?", vbYesNo)
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStartJeu_Click(sender As Object, e As EventArgs) Handles btnStartJeu.Click

    End Sub
End Class
