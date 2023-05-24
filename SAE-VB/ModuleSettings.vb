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

    Private caracteresJouable As Caractere()
    Private chemin As String
    Private charJouable As String
    Private limiteTemps As Boolean
    Private tempsPourJouer As Integer
    Private nbPropostions As Integer

    Private couleurAbsent As Color
    Private couleurPresent As Color
    Private couleurPresentBienPlacé As Color

    Sub main()

        caracteresJouable = New Caractere(4) {}

        'Lecture des caracteres jouable
        Module1.Jouer()

        LectParam()

        Application.Run(FormAccueil)
    End Sub

    Public Sub LectParam()
        Dim filePathCJ As String = "../../config.txt"
        Dim lines As String() = File.ReadAllLines(filePathCJ)
        charJouable = lines(0).Split(" ")(1)
        limiteTemps = CBool(lines(1).Split(" ")(1))
        tempsPourJouer = CInt(lines(2).Split(" ")(1))
        chemin = lines(3).Split(" ")(1)
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

        ' Écriture des données dans le fichier, une par ligne
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(filePath).ToList()
        lines(0) = "charJouable " & charJouable
        lines(1) = "limiteTemps " & limiteTemps
        lines(2) = "tempsPourJouer " & tempsPourJouer
        lines(3) = "path " & chemin
        lines(4) = "nbPropostions " & nbPropostions
        lines(5) = "couleurAbsent " & couleurAbsent.R & " " & couleurAbsent.G & " " & couleurAbsent.B
        lines(6) = "couleurPresent " & couleurPresent.R & " " & couleurPresent.G & " " & couleurPresent.B
        lines(7) = "couleurPresentBienPlacé " & couleurPresentBienPlacé.R & " " & couleurPresentBienPlacé.G & " " & couleurPresentBienPlacé.B

        System.IO.File.WriteAllLines(filePath, lines)

    End Sub

    Public Function getCaracteresJouable() As Caractere()
        Return caracteresJouable
    End Function

    Public Function getnbEssaie() As Integer
        Return nbPropostions
    End Function
    Public Sub setnbEssaie(value As Integer)
        nbPropostions = value
    End Sub
    Public Function getTempsPourJouer() As Integer
        Return tempsPourJouer
    End Function
    Public Sub setTempsPourJouer(value As Integer)
        tempsPourJouer = value
    End Sub
    Public Function getLimiteTemps()
        Return limiteTemps
    End Function
    Public Sub setLimiteTemps(value As Boolean)
        limiteTemps = value
    End Sub
    Public Function getCharJouable()
        Return charJouable
    End Function
    Public Sub setCharJouable(value As String)
        charJouable = value
    End Sub

    Public Function getChemin()
        Return chemin
    End Function
    Public Sub setChemin(value As String)
        chemin = value
    End Sub

    Public Function getcouleurAbsent()
        Return couleurAbsent
    End Function
    Public Sub setcouleurAbsent(value As Color)
        couleurAbsent = value
    End Sub
    Public Function getcouleurPresent()
        Return couleurPresent
    End Function
    Public Sub setcouleurPresent(value As Color)
        couleurPresent = value
    End Sub
    Public Function getcouleurPBP()
        Return couleurPresentBienPlacé
    End Function
    Public Sub setcouleurPBP(value As Color)
        couleurPresentBienPlacé = value
    End Sub

End Module
