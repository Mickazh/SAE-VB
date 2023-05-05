Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Module Module1
    ''' <summary>
    ''' c est le caractère le réprésentant 
    ''' status est un entier réprésentant son status : 0->absent, 1->présent, 2->présent et bien placé
    ''' </summary>
    Public Structure Caractere
        Dim c As Char
        Dim status As Integer
    End Structure

    Public Structure Joueur
        Dim nom As String
        Dim score, PB, NBJ1, NBJ2, TotalTemps As Integer 'pas sur que TotalTemps devrait être un entier

    End Structure

    Public joueurs As String()
    Public scors As Integer()
    Public caracteresJouable As Caractere()

    Sub main()
        joueurs = New String(1) {}
        scors = New Integer(1) {}
        caracteresJouable = New Caractere(4) {}

        'Lecture des joueurs
        Dim filePathJoueurs As String = "../../Joueurs.csv"
        Dim tfp As New TextFieldParser(filePathJoueurs)
        tfp.Delimiters = New String() {";"}
        tfp.TextFieldType = FieldType.Delimited

        Dim header = tfp.ReadLine()
        Dim i = 0
        While Not tfp.EndOfData
            Dim filds = tfp.ReadFields()
            Dim j As String = filds(0)
            If i = joueurs.Length Then
                ReDim Preserve joueurs(joueurs.Length + 1)
            End If
            joueurs(i) = j
            i = i + 1
        End While

        'Lecture des caracteres jouable
        LectCharJouable()

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

        'Dim t As String = "Nom;Score;PB;NBJ1;NBJ2;TotalTemps" & vbCrLf
        'File.AppendAllText(filePath, t)

        Application.Run(FormAccueil)
    End Sub

    Private Sub LectCharJouable()
        Dim filePathCJ As String = "../../config.txt"
        For Each line As String In System.IO.File.ReadLines(filePathCJ)
            Dim c() As String = line.Split(" ")
            For k As Integer = 0 To c.Length - 1
                Dim caractere As Caractere = New Caractere
                caractere.c = c(k)(0) 'je prend le premier char de la chaine
                caractere.status = 0 'absent pour qu'il soit normal (couleur)
                caracteresJouable(k) = caractere
            Next
        Next
    End Sub

End Module
