Public Class Score
    'La structure est ici car sinon SubProcedureDelegate ne veut pas prendre un paramètre Joueur()
    Structure Joueur
        <VBFixedString(15)> Dim nom As String
        Dim score, PB, NBJ1, NBJ2, TotalTemps As Integer 'pas sur que TotalTemps devrait être un entier
    End Structure
    Dim attributs As String() = New String(5) {"Nom", "Score", "Nb Joueur 1", "Nb Joueur 2", "Meilleur temps", "Temps de jeu"}

    Dim joueurs As Joueur() = ModuleJoueur.getJoueurs().Clone()
    Dim procedures() As SubProcedureDelegate = {AddressOf triParNom,
            AddressOf triParScore, AddressOf triParNbJ1, AddressOf triParNbJ2,
            AddressOf triParPB, AddressOf triParTemps}

    Delegate Sub SubProcedureDelegate(joueurs As Joueur())
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRechercher.Enabled = False
        cboRechercher.DropDownStyle = ComboBoxStyle.DropDownList
        cboTrier.DropDownStyle = ComboBoxStyle.DropDownList
        cboRechercher.Sorted = True
        For Each j As Joueur In joueurs
            cboRechercher.Items.Add(j.nom)
        Next
        For Each attribut In attributs
            cboTrier.Items.Add(attribut)
        Next
    End Sub

    Private Sub triParNom(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) x.nom.CompareTo(y.nom))
    End Sub

    Private Sub triParScore(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) -x.score.CompareTo(y.score))
    End Sub
    Private Sub triParNbJ1(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) -x.NBJ1.CompareTo(y.NBJ1))
    End Sub
    Private Sub triParNbJ2(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) -x.NBJ2.CompareTo(y.NBJ2))
    End Sub
    Private Sub triParPB(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) x.PB.CompareTo(y.PB))
    End Sub
    Private Sub triParTemps(joueurs As Joueur())
        Array.Sort(joueurs, Function(x, y) -x.TotalTemps.CompareTo(y.TotalTemps))
    End Sub
    Private Sub Score_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormAccueil.Show()
    End Sub

    Private Sub cboTrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrier.SelectedIndexChanged
        procedures(cboTrier.SelectedIndex)(joueurs)
        refreshLst()
    End Sub

    Private Sub refreshLst()
        For Each lst As ListBox In PnlLst.Controls
            lst.Items.Clear()
        Next
        For Each j As Joueur In joueurs
            lbNom.Items.Add(j.nom)
            lbScore.Items.Add(j.score)
            lbNbJ1.Items.Add(j.NBJ1)
            lbNbJ2.Items.Add(j.NBJ2)
            lbMeilleurTemps.Items.Add(j.PB)
            lbTemps.Items.Add(j.TotalTemps)
        Next
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Dim name = cboRechercher.Text
        Dim iJoueur = ModuleJoueur.getIndexJoueurByName(name)
        Dim j As Joueur = ModuleJoueur.getJoueur(iJoueur)
        Dim s As String =
$"Nom : {j.nom}
Score : {j.score}
Nombre de partie en cacheur : {j.NBJ1}
Nombre de partie en chercheur : {j.NBJ2}
Meilleur temps : {j.PB}
Total de temps joue : {j.TotalTemps}"
        MsgBox(s)
    End Sub

    Private Sub cboRechercher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRechercher.SelectedIndexChanged
        btnRechercher.Enabled = True
    End Sub
End Class