Public Class FormAccueil
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJoueur2.SelectedIndexChanged

    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Dim choix = MsgBox("Voulez vous quitter?", vbYesNo)
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
