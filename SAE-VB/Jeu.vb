Imports SAE_VB.Score
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Jeu
    Private indexCacheur, indexChercheur As Integer
    Private totalTempsPasse As Integer = 0
    Private tentatives As Caractere()()
    Private nbTentatives As Integer = 0
    Private correct As Boolean = True

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAbsent.BackColor = getcouleurAbsent()
        Timer.Start()
        LblCacheur.Text = "Cacheur : " & FormAccueil.getNameJ1()
        LblChercheur.Text = "Chercheur : " & FormAccueil.getNameJ2()
        indexCacheur = FormAccueil.getIndexJ1
        indexChercheur = FormAccueil.getIndexJ2
        ModuleJoueur.incNbJ1(indexCacheur)
        ModuleJoueur.incNbJ2(indexChercheur)
        Me.Size = New Size(450, 630)
        Me.Text = $"Il vous reste {getnbEssaie()} coup(s)..."
        tentatives = New Caractere(0)() {}
        BtnBye.Visible = False
        lblPresent.ForeColor = getcouleurPresent()
        lblPresentPlace.ForeColor = getcouleurPBP()
        lblTemps.Text = getTempsPourJouer()

        For i As Integer = 0 To getCaracteresJouable.Length - 1
            LblCharJouable.Text &= getCaracteresJouable(i).c & " "
        Next
        If getLimiteTemps() Then
            Timer_count = getTempsPourJouer() * Timer.Interval
        Else
            lblTemps.Visible = False
            lblSeconde.Visible = False
        End If

    End Sub
    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress, txt4.KeyPress, txt5.KeyPress
        If e.KeyChar = vbBack Then
            sender.BackColor = Color.White
            Exit Sub
        End If
        If sender.Text.Length = 1 Then
            e.Handled = True
            Exit Sub
        End If
        For i As Integer = 0 To getCaracteresJouable.Length - 1
            If (e.KeyChar = getCaracteresJouable(i).c) Then
                sender.BackColor = Color.White
                'SendKeys.Send("{TAB}") 'sympa mais fait comme si je cliquais sur tab, pas pratique pour @ par exemple
                Exit Sub
            End If
        Next
        e.Handled = True
    End Sub
    Private Sub txt1_Click(sender As Object, e As EventArgs) Handles txt1.Click, txt2.Click, txt3.Click, txt4.Click, txt5.Click
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.Text = String.Empty
        textBox.BackColor = Color.White
    End Sub

    Private Sub BtnBye_Click(sender As Object, e As EventArgs) Handles BtnBye.Click
        Me.Close()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'peut être un peu brutale car j'empeche la fermeture du fichier
        If Not correct Then
            e.Cancel = True
            Exit Sub
        End If
        ModuleJoueur.addTime(indexCacheur, totalTempsPasse)
        ModuleJoueur.addTime(indexChercheur, totalTempsPasse)
        ModuleJoueur.enregistrerJoueur(getJoueur(indexCacheur))
        ModuleJoueur.enregistrerJoueur(getJoueur(indexChercheur))
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        totalTempsPasse += 1
        Timer_count -= Timer.Interval
        lblTemps.Text = CStr(Timer_count / Timer.Interval)
        If getLimiteTemps() AndAlso Timer_count = 0 Then
            Timer.Stop()
            EndGame()
        End If
    End Sub

    Private Sub Jeu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'peut être un peu brutale car j'empeche la fermeture du fichier
        combin.Close()
        FormAccueil.echangeJoueur()
        FormAccueil.Show()
    End Sub

    Private Sub btnEssaie_Click(sender As Object, e As EventArgs) Handles btnEssaie.Click
        Dim valide = True
        For i As Integer = 0 To PnlChar.Controls.Count - 1
            If PnlChar.Controls(i).Text.Length <> 1 Then
                PnlChar.Controls(i).BackColor = Color.Red
                valide = False
            End If
        Next
        If Not valide Then
            Exit Sub
        End If

        Dim correct = True
        Dim caract As Caractere
        tentatives(nbTentatives) = New Caractere(4) {}
        For i As Integer = PnlChar.Controls.Count - 1 To 0 Step -1
            caract = New Caractere
            caract.c = PnlChar.Controls(i).Text(0)

            If PnlChar.Controls(i).Text(0).Equals(combin.combineCache(i)) Then
                PnlChar.Controls(i).BackColor = getcouleurPBP()
                RTBTenta.SelectionColor = getcouleurPBP()
                caract.status = 2

            ElseIf combin.combineCache.Contains(PnlChar.Controls(i).Text(0)) Then
                PnlChar.Controls(i).BackColor = getcouleurPresent()
                RTBTenta.SelectionColor = getcouleurPresent()
                caract.status = 1

                correct = False

            Else
                caract.status = 0
                'PnlChar.Controls(i).BackColor = colorMauvais
                'RTBTenta.SelectionColor = getcouleurAbsent()'
                PnlChar.Controls(i).BackColor = getcouleurAbsent()
                RTBTenta.SelectionColor = lblAbsent.ForeColor
                correct = False
            End If

            RTBTenta.AppendText(caract.c)
            RTBTenta.AppendText("    ")
            tentatives(nbTentatives)(i) = caract
        Next

        RTBTenta.SelectAll()
        RTBTenta.SelectionAlignment = HorizontalAlignment.Center
        RTBTenta.AppendText(vbCrLf)

        If correct Then
            Timer.Stop()
            MsgBox($"Bravo {FormAccueil.getNameJ2}, vous avez trouvé, vous gagnez donc un point")
            incScore(indexChercheur)
            editPB(indexChercheur, totalTempsPasse)
            fin()
            Exit Sub
        End If

        nbTentatives += 1
        Me.Text = $"Il vous reste {getnbEssaie() - nbTentatives} coup(s)..."
        If getnbEssaie() = nbTentatives Then
            EndGame()
            Exit Sub
        End If
        'For i As Integer = 0 To tentatives.Length - 1
        '    Dim s = ""
        '    For j As Integer = 0 To tentatives(i).Length - 1
        '        s &= tentatives(i)(j).c & " "
        '    Next
        'Next
        ReDim Preserve tentatives(nbTentatives)
    End Sub
    Private Sub EndGame()
        incScore(indexCacheur)
        MsgBox($"Dommage {FormAccueil.getNameJ2}, vous n'avez pas trouvé !
{FormAccueil.getNameJ1} gagne donc un point")
        fin()
    End Sub

    Private Sub fin()
        btnEssaie.Enabled = False
        BtnBye.Visible = True
    End Sub
    Private Sub RTBTenta_MouseEnter(sender As Object, e As EventArgs) Handles RTBTenta.MouseEnter
        RTBTenta.Enabled = True
    End Sub

    Private Sub RTBTenta_MouseLeave(sender As Object, e As EventArgs) Handles RTBTenta.MouseLeave
        RTBTenta.Enabled = False
    End Sub

End Class