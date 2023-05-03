Imports System.IO
Imports System.Text

Module Module1
    ''' <summary>
    ''' c est le caractère le réprésentant 
    ''' status est un entier réprésentant son status : 0->absent, 1->présent, 2->présent et bien placé
    ''' </summary>
    Public Structure Caractere
        Dim c As Char
        Dim status As Integer
    End Structure

    Public joueurs() As String
    Public scors() As Integer

    Sub main()
        Dim filePath As String = "../../Joueurs.csv"
        'Dim fileContent As String = System.IO.File.ReadAllText(filePath)
        'For Each line As String In System.IO.File.ReadLines(filePath)
        '    Dim joueur() As String = line.Split(" ")
        '    For i = 0 To joueur.Length - 1
        '        MsgBox(joueur(i))
        '    Next
        'Next
        'Dim fs As FileStream = File.Create(filePath)
        'Dim fileExists As Boolean = File.Exists(filePath)
        'Using sw As New StreamWriter(File.Open(filePath, FileMode.OpenOrCreate))
        '    sw.WriteLine("test")
        'End Using
        'Dim info As Byte() = New UTF8Encoding(True).GetBytes("test")
        'fs.Write(info, 0, info.Length)
        Dim t As String = "Nom;Score;PB;NBJ1;NBJ2;TotalTemps" & vbCrLf
        File.AppendAllText(filePath, t)

        Application.Run(FormAccueil)
    End Sub
End Module
