Imports System.Runtime.InteropServices

Module ModuleJoueurs
    Private joueursPath = "../../joueurs"
    Structure Joueur
        <VBFixedString(15)> Dim nom As String
        Dim score, PB, NBJ1, NBJ2, TotalTemps As Integer 'pas sur que TotalTemps devrait être un entier
    End Structure

    Sub lectureJoueurs()
        Dim numFichierJoueur = FreeFile()
        Dim j As Joueur
        Dim indice As Integer = 1
        FileOpen(numFichierJoueur, joueursPath, OpenMode.Random, , , Len(j))
        While Not EOF(numFichierJoueur)
            FileGet(numFichierJoueur, j, indice)
            MsgBox("J" & indice & j.nom)
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
                joueurInFile = True
                MsgBox("in")
            End If
            indice += 1
        End While
        If Not joueurInFile Then
            FilePut(numFichierJoueur, joueurAj, indice)
        End If
        FileClose(numFichierJoueur)
    End Sub
End Module
