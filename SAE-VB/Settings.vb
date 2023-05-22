Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Xml
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

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
        FormAccueil.Show()
        Me.Close()
    End Sub

    Private Sub button_points_Click(sender As Object, e As EventArgs) Handles button_points.Click
        Dim SaveFileDialog As New SaveFileDialog()
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim nomFichier As String = SaveFileDialog.FileName

            ' Votre code pour enregistrer le fichier ici
            ' Vous pouvez utiliser le chemin d'accès 'nomFichier' pour enregistrer le fichier
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumUpDownEssaie.Value = nbPropostions
        txtbox_temps.Text = tempsPourJouer
        If limiteTemps Then
            RBNon.Checked = True
        Else
            RBOui.Checked = True
        End If
        cboChemin.Text = path
        txtColorPrésent.BackColor = couleurPresent
        txtColorPrésentBienPla.BackColor = couleurPresentBienPlacé
        ToolTipChar.SetToolTip(txtCar, "Appuyer sur Entrée pour valider le caractère choisi")
    End Sub

    Private Sub Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        FormAccueil.Show() 'on suppose que si on ferme cette fenetre on veut retourner sur le form d'acccueil
    End Sub

    Private charactersSet As HashSet(Of Char) = New HashSet(Of Char)()
    Public CharJouable As String = ""
    Private Sub TextBoxCaractere_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCar.KeyDown
        ' Vérifier si l'utilisateur a appuyé sur la touche Entrée
        If e.KeyCode = Keys.Enter Then
            Dim character As Char = txtCar.Text.Trim()

            ' Vérifier si le caractère est vide ou s'il est déjà dans le HashSet
            If String.IsNullOrEmpty(character) OrElse charactersSet.Contains(character) Then
                MessageBox.Show("Veuillez entrer un caractère différent.")
                Return
            End If

            ' Vérifie si tous les caractères ont été saisis
            If charactersSet.Count = 5 Then
                MessageBox.Show("Tous les caractères ont été saisis.")
                Return
            End If

            ' Ajoute le caractère au HashSet
            charactersSet.Add(character)

            ' Efface le contenu de la TextBox
            txtCar.Clear()
            'CharJouable = String.Join("", charactersSet)
            lblResultChar.Text = String.Join(" ", charactersSet)
        End If
    End Sub

    Private Sub txtCar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCar.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If sender.Text.Length = 1 Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub txtbox_temps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbox_temps.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PnlColorChoice_MouseHover(sender As Object, e As EventArgs) Handles PnlColorChoice.MouseHover
        ToolTipCombin.SetToolTip(PnlColorChoice, "Conseil : Choississez des couleurs qui se différencient")
    End Sub

    Private Sub btnAbsent_Click(sender As Object, e As EventArgs) Handles btnAbsent.Click, btnPresent.Click, btnPrePLa.Click
        Dim colorDialog As New ColorDialog()

        ' Affiche le dialogue de sélection de couleur
        If colorDialog.ShowDialog() = DialogResult.OK Then
            ' Récupère la couleur sélectionnée
            Dim selectedColor As Color = colorDialog.Color
            sender.BackColor = selectedColor
        End If

    End Sub
End Class