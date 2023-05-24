Public Class Score
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
        FormAccueil.Show()
    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class