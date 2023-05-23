<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbNom = New System.Windows.Forms.ListBox()
        Me.lbScore = New System.Windows.Forms.ListBox()
        Me.lbNbJ1 = New System.Windows.Forms.ListBox()
        Me.lbNbJ2 = New System.Windows.Forms.ListBox()
        Me.lbMeilleurTemps = New System.Windows.Forms.ListBox()
        Me.lbTemps = New System.Windows.Forms.ListBox()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.cboRechercher = New System.Windows.Forms.ComboBox()
        Me.cboTrier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbNom
        '
        Me.lbNom.FormattingEnabled = True
        Me.lbNom.ItemHeight = 16
        Me.lbNom.Location = New System.Drawing.Point(26, 147)
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(120, 84)
        Me.lbNom.TabIndex = 0
        '
        'lbScore
        '
        Me.lbScore.FormattingEnabled = True
        Me.lbScore.ItemHeight = 16
        Me.lbScore.Location = New System.Drawing.Point(152, 147)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(120, 84)
        Me.lbScore.TabIndex = 1
        '
        'lbNbJ1
        '
        Me.lbNbJ1.FormattingEnabled = True
        Me.lbNbJ1.ItemHeight = 16
        Me.lbNbJ1.Location = New System.Drawing.Point(278, 147)
        Me.lbNbJ1.Name = "lbNbJ1"
        Me.lbNbJ1.Size = New System.Drawing.Size(120, 84)
        Me.lbNbJ1.TabIndex = 2
        '
        'lbNbJ2
        '
        Me.lbNbJ2.FormattingEnabled = True
        Me.lbNbJ2.ItemHeight = 16
        Me.lbNbJ2.Location = New System.Drawing.Point(404, 147)
        Me.lbNbJ2.Name = "lbNbJ2"
        Me.lbNbJ2.Size = New System.Drawing.Size(120, 84)
        Me.lbNbJ2.TabIndex = 3
        '
        'lbMeilleurTemps
        '
        Me.lbMeilleurTemps.FormattingEnabled = True
        Me.lbMeilleurTemps.ItemHeight = 16
        Me.lbMeilleurTemps.Location = New System.Drawing.Point(530, 147)
        Me.lbMeilleurTemps.Name = "lbMeilleurTemps"
        Me.lbMeilleurTemps.Size = New System.Drawing.Size(120, 84)
        Me.lbMeilleurTemps.TabIndex = 4
        '
        'lbTemps
        '
        Me.lbTemps.FormattingEnabled = True
        Me.lbTemps.ItemHeight = 16
        Me.lbTemps.Location = New System.Drawing.Point(656, 147)
        Me.lbTemps.Name = "lbTemps"
        Me.lbTemps.Size = New System.Drawing.Size(120, 84)
        Me.lbTemps.TabIndex = 5
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(316, 289)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(156, 60)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(530, 52)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(93, 23)
        Me.btnRechercher.TabIndex = 7
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'cboRechercher
        '
        Me.cboRechercher.FormattingEnabled = True
        Me.cboRechercher.Location = New System.Drawing.Point(373, 52)
        Me.cboRechercher.Name = "cboRechercher"
        Me.cboRechercher.Size = New System.Drawing.Size(151, 24)
        Me.cboRechercher.TabIndex = 8
        '
        'cboTrier
        '
        Me.cboTrier.FormattingEnabled = True
        Me.cboTrier.Location = New System.Drawing.Point(90, 52)
        Me.cboTrier.Name = "cboTrier"
        Me.cboTrier.Size = New System.Drawing.Size(151, 24)
        Me.cboTrier.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Trier Par:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Chercher par Nom"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTrier)
        Me.Controls.Add(Me.cboRechercher)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lbTemps)
        Me.Controls.Add(Me.lbMeilleurTemps)
        Me.Controls.Add(Me.lbNbJ2)
        Me.Controls.Add(Me.lbNbJ1)
        Me.Controls.Add(Me.lbScore)
        Me.Controls.Add(Me.lbNom)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNom As ListBox
    Friend WithEvents lbScore As ListBox
    Friend WithEvents lbNbJ1 As ListBox
    Friend WithEvents lbNbJ2 As ListBox
    Friend WithEvents lbMeilleurTemps As ListBox
    Friend WithEvents lbTemps As ListBox
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnRechercher As Button
    Friend WithEvents cboRechercher As ComboBox
    Friend WithEvents cboTrier As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
