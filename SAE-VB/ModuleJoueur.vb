Imports System.IO
Imports System.Runtime.InteropServices
Imports SAE_VB.Score

Module ModuleJoueur
    Private joueursPath = "../../joueurs"


    Private joueurs As Joueur() = New Joueur() {}

    Sub lectureJoueurs()
        'MsgBox(New FileInfo(joueursPath).Length)
        Dim numFichierJoueur = FreeFile()
        Dim j As Joueur
        Dim indice As Integer = 1
        FileOpen(numFichierJoueur, joueursPath, OpenMode.Random, , , Len(j))
        While Not EOF(numFichierJoueur)
            FileGet(numFichierJoueur, j, indice)
            If (indice - 1) = joueurs.Length Then
                ReDim Preserve joueurs(joueurs.Length)
            End If
            joueurs(indice - 1) = j

            indice += 1
        End While
        FileClose(numFichierJoueur)

    End Sub

    ''' <summary>
    ''' Enregistre un nouveau joueur
    ''' </summary>
    ''' <param name="joueurAJ"></param>
    ''' <returns>L'indice à laquel le joueur est placé</returns>
    Public Function enregistrerNouveauJoueur(joueurAJ As Joueur) As Integer
        Dim numFichierJoueur = FreeFile()
        FileOpen(numFichierJoueur, joueursPath, OpenMode.Random, , , Len(joueurAJ))
        FilePut(numFichierJoueur, joueurAJ, joueurs.Length + 1)
        FileClose(numFichierJoueur)

        ReDim Preserve joueurs(joueurs.Length)
        joueurs(joueurs.Length - 1) = joueurAJ

        Return joueurs.Length - 1
    End Function

    Sub enregistrerJoueur(joueurAj As Joueur)
        Dim joueurFichier As Joueur
        Dim numFichierJoueur = FreeFile()
        Dim joueurInFile = False
        Dim indice As Integer = 1
        FileOpen(numFichierJoueur, joueursPath, OpenMode.Random, , , Len(joueurAj))

        While Not EOF(numFichierJoueur)
            FileGet(numFichierJoueur, joueurFichier, indice)
            If Trim(joueurAj.nom).Equals(Trim(joueurFichier.nom)) Then
                FilePut(numFichierJoueur, joueurAj, indice)
                FileClose(numFichierJoueur)
                Exit Sub
            End If
            indice += 1
        End While
        FilePut(numFichierJoueur, joueurAj, indice)
        FileClose(numFichierJoueur)
    End Sub

    ''' <summary>
    ''' renvoie l'indice du joueur grace au nom
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns>L'indice du joueur dans la liste des joueurs, s'il n'y est pas alors renvoie -1</returns>
    Public Function getIndexJoueurByName(name As String) As Integer
        Dim i = 0
        While i < joueurs.Length - 1
            If Trim(joueurs(i).nom).Equals(Trim(name)) Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function getJoueur(index As Integer) As Joueur
        Return joueurs(index)
    End Function

    Public Function getJoueurs() As Joueur()
        Return joueurs
    End Function

    Public Sub incScore(i As Integer)
        joueurs(i).score += 1
    End Sub

    Public Sub addTime(i As Integer, time As Integer)
        'MsgBox(time)
        joueurs(i).TotalTemps += time
    End Sub

    Public Sub incNbJ1(i As Integer)
        joueurs(i).NBJ1 += 1
    End Sub
    Public Sub incNbJ2(i As Integer)
        joueurs(i).NBJ2 += 1
    End Sub

    Public Sub editPB(i As Integer, time As Integer)
        If joueurs(i).PB > time Then
            joueurs(i).PB = time
        End If
    End Sub

    Public Function getTime(i As Integer) As Integer
        Return joueurs(i).TotalTemps
    End Function
End Module
