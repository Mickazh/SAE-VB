Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Xml
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json

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
        Module1.EnregistrerParam(GetParam())
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

        ToolTipChar.SetToolTip(txtCar, "Appuyer sur Entrée pour valider le caractère choisi")
        cboChemin.Items.Add(Module1.chemin)
        cboChemin.Text = Module1.chemin
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
            CharJouable = String.Join("", charactersSet)
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

    Public Function GetParam()
        Dim chaineS As String = ""
        Dim i As Integer = 0


        If (txtbox_temps.Text.Length = 0) Then
            i = 60
        Else
            i = Integer.Parse(txtbox_temps.Text)
        End If

        If (RBOui.Checked = True) Then
            chaineS += "AvecTemps_" & i.ToString & vbCrLf
        Else
            chaineS += "SansTemps" & vbCrLf
        End If
        Dim s As String = txtColorPrésentBienPla.BackColor.ToString
        s = s.Replace(s.First, "")
        s = s.Replace(s.Last, "")
        s = s.Remove(0, 6)
        chaineS += s & vbCrLf
        chaineS += typeActuel & vbCrLf
        'chaineS += "Difficulté_" + TrackBar1.Value.ToString
        'Return chaineS
        Dim donnees As New List(Of Donnee)()

        ' Ajoutez des données à la liste
        donnees.Add(New Donnee() With {.Entier = txtbox_temps.Text, .Descript = "Temps"})
        donnees.Add(New Donnee() With {.Entier = NumUpDownEssaie.Value, .Descript = "Nombre_Essaie"})
        donnees.Add(New Donnee() With {.Couleur = txtColorPrésent.BackColor, .Descript = "Couleur_Présent"})
        donnees.Add(New Donnee() With {.Couleur = txtColorPrésentBienPla.BackColor, .Descript = "Couleur_Présent_BienPlacé"})
        donnees.Add(New Donnee() With {.Chaine = cboChemin.Text, .Descript = "Chemin"})
        donnees.Add(New Donnee() With {.Chaine = CharJouable, .Descript = "Caractères"})
        ' Ajoutez autant de données que nécessaire
        Return donnees

    End Function
End Class