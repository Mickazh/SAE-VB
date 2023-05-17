﻿Public Class combin
    Public combineCache As Char()
    Private Sub combin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combineCache = New Char(4) {}
        For i As Integer = 0 To caracteresJouable.Length - 1
            LblCharJouable.Text &= caracteresJouable(i).c & " "
        Next
    End Sub

    Private Sub combin_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        FormAccueil.Show() 'on suppose que si on ferme cette fenetre on veut retourner sur le form d'acccueil
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress, txt4.KeyPress, txt5.KeyPress
        If e.KeyChar = vbBack Then
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

    Private Sub btnCacher_Click(sender As Object, e As EventArgs) Handles btnCacher.Click
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

        'Je sais que le tableau est à l'envers, mais ce n'est pas grave si on compare aussi à un tableau à l'envers
        'Si l'utilisateur entre "£, @, %, #, $" alors le tableau est {"$", "#", "%", "@", "£"}
        For i As Integer = 0 To PnlChar.Controls.Count - 1
            combineCache(i) = PnlChar.Controls(i).Text(0)
        Next

        'Dim s As String = ""
        'For i As Integer = 0 To 4
        '    s &= combineCache(i) & " "
        'Next
        'MsgBox(s)

        Me.Hide()
        Jeu.Show()
    End Sub

    'Private Sub txt_GotFocus(sender As Object, e As EventArgs) Handles txt1.GotFocus, txt2.GotFocus, txt3.GotFocus, txt4.GotFocus, txt5.GotFocus
    '    sender.BackColor = Color.White
    'End Sub
End Class