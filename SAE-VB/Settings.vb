Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Settings

    Public typeActuel As String = ""

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RBPrésent.CheckedChanged, RBPrésentBien.CheckedChanged
        Dim radioButton As RadioButton = CType(sender, RadioButton)

        If radioButton.Checked Then
            Dim colorDialog As New ColorDialog()

            ' Affiche le dialogue de sélection de couleur
            If colorDialog.ShowDialog() = DialogResult.OK Then
                ' Récupère la couleur sélectionnée
                Dim selectedColor As Color = colorDialog.Color

                If RBPrésent.Checked Then
                    txtColorPrésent.BackColor = selectedColor
                Else
                    txtColorPrésentBienPla.BackColor = selectedColor
                End If
                ' Décoche tous les RadioButtons après la sélection de la couleur
                For Each rb As RadioButton In PnlColorChoice.Controls.OfType(Of RadioButton)()
                    rb.Checked = False
                Next
            End If
        End If
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        chemin = cboChemin.Text
        'Module1.EnregistrerParam(s)
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub button_points_Click(sender As Object, e As EventArgs) Handles button_points.Click
        Dim SaveFileDialog As New SaveFileDialog()
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboChemin.Items.Add(Module1.chemin)
        cboChemin.Text = Module1.chemin
    End Sub
End Class