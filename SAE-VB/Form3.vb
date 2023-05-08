Public Class Form3
    Private tentatives As Caractere()()
    Private nbTentatives As Integer = 0
    Private win As Boolean = False
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste 15 coup(s)..."
        tentatives = New Caractere(0)() {}
        BtnBye.Visible = False
        lblPresent.ForeColor = Color.Blue
        lblPresentPlace.ForeColor = Color.Green
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
        For i As Integer = 0 To caracteresJouable.Length - 1
            If (e.KeyChar = caracteresJouable(i).c) Then
                sender.BackColor = Color.White
                'SendKeys.Send("{TAB}") 'sympa mais fait comme si je cliquais sur tab, pas pratique pour @ par exemple
                Exit Sub
            End If
        Next
        e.Handled = True
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'peut être un peu brutale car j'empeche la fermeture du fichier
        If Not win Then
            e.Cancel = True
        End If
        Me.Hide()
        FormAccueil.cboJoueur1.Text = "j2"
        FormAccueil.cboJoueur2.Text = "j1"
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
        For i As Integer = 0 To PnlChar.Controls.Count - 1
            caract = New Caractere
            caract.c = PnlChar.Controls(i).Text(0)
            If PnlChar.Controls(i).Text(0).Equals(combin.combineCache(i)) Then
                PnlChar.Controls(i).BackColor = Color.Green
                caract.status = 2
            ElseIf Not combin.combineCache.Contains(PnlChar.Controls(i).Text(0)) Then
                PnlChar.Controls(i).BackColor = Color.Blue
                caract.status = 1
                correct = False
            Else
                caract.status = 0
                correct = False
            End If
            tentatives(nbTentatives)(i) = caract
        Next
        If correct Then
            MsgBox("bravo")
        End If
        nbTentatives += 1
        Me.Text = $"Il vous reste {15 - nbTentatives} coup(s)..."
        For i As Integer = 0 To tentatives.Length - 1
            Dim s = ""
            For j As Integer = 0 To tentatives(i).Length - 1
                s &= tentatives(i)(j).c & " "
            Next
        Next
        ReDim Preserve tentatives(nbTentatives)
    End Sub

End Class