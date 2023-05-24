Imports System.IO
Imports System.Runtime.InteropServices

Module ModuleJoueur
    Private joueursPath = "../../joueurs"
    Structure Joueur
        <VBFixedString(15)> Dim nom As String
        Dim score, PB, NBJ1, NBJ2, TotalTemps As Integer 'pas sur que TotalTemps devrait être un entier
    End Structure

    Private joueurs As Joueur() = New Joueur(0) {}

    Sub lectureJoueurs()
        MsgBox(New FileInfo(joueursPath).Length)
        Dim numFichierJoueur = FreeFile()
        Dim j As Joueur
        Dim indice As Integer = 1
        FileOpen(numFichierJoueur, joueursPath, OpenMode.Random, , , Len(j))
        While Not EOF(numFichierJoueur)
            FileGet(numFichierJoueur, j, indice)
            If (indice - 1) = joueurs.Length Then
                ReDim Preserve joueurs(joueurs.Length + 1)
            End If
            joueurs(indice - 1) = j

            indice += 1
        End While
        FileClose(numFichierJoueur)

    End Sub

    Sub enregistrerJoueur(ByRef joueurAj As Joueur)
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
    ''' <returns>L'indice du joueur dans la liste des joueurs</returns>
    Public Function getIndexJoueurByName(name As String) As Integer
        Dim i = 0
        While i < joueurs.Length - 1
            If Trim(joueurs(i).nom).Equals(name) Then
                Return i
            End If
            i += 1
        End While
        Return i + 1
    End Function

    Public Function getJoueur(index As Integer) As Joueur
        Return joueurs(index)
    End Function
End Module
