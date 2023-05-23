Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Module ModuleSettings
    ''' <summary>
    ''' c est le caractère le réprésentant 
    ''' status est un entier réprésentant son status : 0->absent, 1->présent, 2->présent et bien placé
    ''' </summary>
    Public Structure Caractere
        Dim c As Char
        Dim status As Integer
    End Structure

    Public caracteresJouable As Caractere()
    Public chemin As String = ""
    Public charJouable As String = ""
    Public limiteTemps As Boolean
    Private tempsPourJouer As Integer
    Public path As String = ""
    Public nbPropostions As Integer = 0
    Public couleurAbsent As Color
    Public couleurPresent As Color
    Public couleurPresentBienPlacé As Color

    Sub main()
        joueurs = New String(1) {}
        scors = New Integer(1) {}
        caracteresJouable = New Caractere(4) {}

        'Lecture des caracteres jouable
        Module1.Jouer()
        'LectCharJouable()
        LectParam()
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


    'Private Sub LectParam()
    'Dim filePathCJ As String = "../../config.txt"
    'For Each line As String In System.IO.File.ReadLines(filePathCJ)
    ' Traitement de chaque ligne pour extraire les données
    'Dim data() As String = line.Split(": ")

    ' Vérification de la longueur du tableau
    'If data.Length >= 2 Then
    ' Ignorer le premier élément et accéder aux autres éléments
    'CharJouable = data
    'Dim variable1 As String = data(1)
    'Dim variable2 As Integer = Integer.Parse(data(2))
    ' ... Continuer pour les autres variables
    'End If
    '
    'LectCharJouable(CharJouable)
    'End Sub
    Private Sub LectParam()
        Dim filePathCJ As String = "../../config.txt"
        Dim lines As String() = File.ReadAllLines(filePathCJ)
        charJouable = lines(0).Split(" ")(1)
        limiteTemps = CBool(lines(1).Split(" ")(1))
        tempsPourJouer = CInt(lines(2).Split(" ")(1))
        path = lines(3).Split(" ")(1)
        nbPropostions = CInt(lines(4).Split(" ")(1))

        couleurAbsent = Color.FromArgb(CInt(lines(5).Split(" ")(1)),
CInt(lines(5).Split(" ")(2)), CInt(lines(5).Split(" ")(3)))
        couleurPresent = Color.FromArgb(CInt(lines(6).Split(" ")(1)),
CInt(lines(6).Split(" ")(2)), CInt(lines(6).Split(" ")(3)))
        couleurPresentBienPlacé = Color.FromArgb(CInt(lines(7).Split(" ")(1)),
CInt(lines(7).Split(" ")(2)), CInt(lines(7).Split(" ")(3)))
        LectCharJouable()
    End Sub

    Private Sub LectCharJouable()
        For i As Integer = 0 To charJouable.Length - 1
            Dim caractere As Caractere = New Caractere
            caractere.c = charJouable(i) 'je prend le premier char de la chaine
            caractere.status = 0 'absent pour qu'il soit normal (couleur)
            caracteresJouable(i) = caractere
        Next
    End Sub

    Public Sub EnregistrerParam()
        Dim filePath As String = "../../config.txt"
        'Dim fichier As Integer = 0
        'Dim s As String = ""
        'Dim nomFichier As String = ""
        'fichier = FreeFile()
        'nomFichier = "../../cond.json"
        's = chaine
        'FileOpen(fichier, nomFichier, OpenMode.Output)
        'Print(fichier, s)
        'FileClose(fichier)
        'Using writer As New StreamWriter(filePath, True)
        ' Écriture des données dans le fichier, une par ligne
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList()
        lines(0) = "charJouable " & charJouable
        lines(1) = "limiteTemps " & limiteTemps
        lines(2) = "tempsPourJouer " & tempsPourJouer
        lines(3) = "path " & path
        lines(4) = "nbPropostions " & nbPropostions
        lines(5) = "couleurAbsent " & couleurAbsent.R & " " & couleurAbsent.G & " " & couleurAbsent.B
        lines(6) = "couleurPresent " & couleurPresent.R & " " & couleurPresent.G & " " & couleurPresent.B
        lines(7) = "couleurPresentBienPlacé " & couleurPresentBienPlacé.R & " " & couleurPresentBienPlacé.G & " " & couleurPresentBienPlacé.B
        'writer.WriteLine(charJouable)
        'writer.WriteLine(limiteTemps)
        'writer.WriteLine(tempsPourJouer)
        'writer.WriteLine(path)
        'writer.WriteLine(nbPropostions)

        'writer.WriteLine(couleurAbsent.R & "" & couleurAbsent.G & "" & couleurAbsent.B)
        'writer.WriteLine(couleurPresent.R & "" & couleurPresent.G & "" & couleurPresent.B)
        'writer.WriteLine(couleurPresentBienPlacé.R & "" & couleurPresentBienPlacé.G & "" & couleurPresentBienPlacé.B)
        System.IO.File.WriteAllLines(filePath, lines)
        'End Using
    End Sub

    Public Function getTempsPourJouer()
        Return tempsPourJouer
    End Function
End Module
