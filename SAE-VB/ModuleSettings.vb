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
    Public limiteTemps As String = ""
    Public tempsPourJouer As Integer = 0
    Public path As String = ""
    Public nbPropostions As Integer = 0
    Public couleurAbsent As String = ""
    Public couleurPresent As String = ""
    Public couleurPresentBienPlacé As String = ""

    Sub main()
        joueurs = New String(1) {}
        scors = New Integer(1) {}
        caracteresJouable = New Caractere(4) {}

        'Lecture des caracteres jouable
        Module1.Jouer()
        'LectCharJouable()
        LectPara()
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
    Private Sub LectPara()
        Dim filePathCJ As String = "../../config.txt"
        Dim lines As String() = File.ReadAllLines(filePathCJ)

        For i As Integer = 0 To lines.Length - 1
            Dim line As String = lines(i)
            Dim words As String() = line.Split(" ")
            ' Vérifier le contenu de la première partie de la ligne pour assigner les valeurs aux variables correspondantes
            Select Case words(0)
                Case "charJouable"
                    ' La deuxième partie de la ligne est la valeur correspondante
                    charJouable = words(1)
                Case "LimiteTemps"
                    limiteTemps = words(1)
                Case "tempsPourJouer"
                    ' Convertir la deuxième partie de la ligne en entier
                    Integer.TryParse(words(1), tempsPourJouer)
                Case "path"
                    path = words(1)
                Case "nbPropostions"
                    Integer.TryParse(words(1), nbPropostions)
                Case "CouleurAbsent"
                    couleurAbsent = words(1)
                Case "CouleurPresent"
                    couleurPresent = words(1)
                Case "CouleurPresentBienPlacé"
                    couleurPresentBienPlacé = words(1)
                    ' Ajouter d'autres cas pour les autres lignes du fichier, si nécessaire
            End Select
        Next
        LectCharJouable()
    End Sub

    Private Sub LectCharJouable()
        'Dim filePathCJ As String = "../../config.txt"
        'For Each line As String In System.IO.File.ReadLines(filePathCJ)
        'Dim c() As String = line.Split(" ")
        For i As Integer = 0 To charJouable.Length - 1
            Dim caractere As Caractere = New Caractere
            caractere.c = charJouable(i) 'je prend le premier char de la chaine
            caractere.status = 0 'absent pour qu'il soit normal (couleur)
            caracteresJouable(i) = caractere
        Next
        'Next
    End Sub

    Public Sub EnregistrerParam(chaine As String)
        Dim fichier As Integer = 0
        Dim s As String = ""
        Dim nomFichier As String = ""
        fichier = FreeFile()
        nomFichier = "../../cond.json"
        s = chaine
        FileOpen(fichier, nomFichier, OpenMode.Output)
        Print(fichier, s)
        FileClose(fichier)
    End Sub

    Public Sub RecupererParam()
        Dim fichier As Integer = 0
        Dim s As String = ""
        Dim Chaines As String() = {}
        Dim nomFichier As String = ""
        fichier = FreeFile()
        nomFichier = chemin + "/Paramètres.txt"
        FileOpen(fichier, nomFichier, OpenMode.Input)
        While EOF(fichier) = False
        End While
        FileClose(fichier)
    End Sub
End Module
