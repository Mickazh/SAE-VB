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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Score))
        Me.lbNom = New System.Windows.Forms.ListBox()
        Me.lbScore = New System.Windows.Forms.ListBox()
        Me.lbNbJ1 = New System.Windows.Forms.ListBox()
        Me.lbNbJ2 = New System.Windows.Forms.ListBox()
        Me.lbMeilleurTemps = New System.Windows.Forms.ListBox()
        Me.lbTemps = New System.Windows.Forms.ListBox()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.cboRechercher = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTrier = New System.Windows.Forms.ComboBox()
        Me.PnlLst = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlLst.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbNom
        '
        Me.lbNom.FormattingEnabled = True
        Me.lbNom.ItemHeight = 16
        Me.lbNom.Location = New System.Drawing.Point(17, 14)
        Me.lbNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(120, 84)
        Me.lbNom.TabIndex = 0
        '
        'lbScore
        '
        Me.lbScore.FormattingEnabled = True
        Me.lbScore.ItemHeight = 16
        Me.lbScore.Location = New System.Drawing.Point(143, 14)
        Me.lbScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(120, 84)
        Me.lbScore.TabIndex = 1
        '
        'lbNbJ1
        '
        Me.lbNbJ1.FormattingEnabled = True
        Me.lbNbJ1.ItemHeight = 16
        Me.lbNbJ1.Location = New System.Drawing.Point(268, 14)
        Me.lbNbJ1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbNbJ1.Name = "lbNbJ1"
        Me.lbNbJ1.Size = New System.Drawing.Size(120, 84)
        Me.lbNbJ1.TabIndex = 2
        '
        'lbNbJ2
        '
        Me.lbNbJ2.FormattingEnabled = True
        Me.lbNbJ2.ItemHeight = 16
        Me.lbNbJ2.Location = New System.Drawing.Point(395, 14)
        Me.lbNbJ2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbNbJ2.Name = "lbNbJ2"
        Me.lbNbJ2.Size = New System.Drawing.Size(120, 84)
        Me.lbNbJ2.TabIndex = 3
        '
        'lbMeilleurTemps
        '
        Me.lbMeilleurTemps.FormattingEnabled = True
        Me.lbMeilleurTemps.ItemHeight = 16
        Me.lbMeilleurTemps.Location = New System.Drawing.Point(521, 14)
        Me.lbMeilleurTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbMeilleurTemps.Name = "lbMeilleurTemps"
        Me.lbMeilleurTemps.Size = New System.Drawing.Size(120, 84)
        Me.lbMeilleurTemps.TabIndex = 4
        '
        'lbTemps
        '
        Me.lbTemps.FormattingEnabled = True
        Me.lbTemps.ItemHeight = 16
        Me.lbTemps.Location = New System.Drawing.Point(647, 14)
        Me.lbTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbTemps.Name = "lbTemps"
        Me.lbTemps.Size = New System.Drawing.Size(120, 84)
        Me.lbTemps.TabIndex = 5
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(316, 289)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(156, 60)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.Location = New System.Drawing.Point(531, 52)
        Me.btnRechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.cboRechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRechercher.Name = "cboRechercher"
        Me.cboRechercher.Size = New System.Drawing.Size(151, 24)
        Me.cboRechercher.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Trier Par:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Chercher par Nom"
        '
        'cboTrier
        '
        Me.cboTrier.FormattingEnabled = True
        Me.cboTrier.Location = New System.Drawing.Point(91, 52)
        Me.cboTrier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTrier.Name = "cboTrier"
        Me.cboTrier.Size = New System.Drawing.Size(151, 24)
        Me.cboTrier.TabIndex = 13
        '
        'PnlLst
        '
        Me.PnlLst.Controls.Add(Me.lbTemps)
        Me.PnlLst.Controls.Add(Me.lbMeilleurTemps)
        Me.PnlLst.Controls.Add(Me.lbNbJ2)
        Me.PnlLst.Controls.Add(Me.lbNbJ1)
        Me.PnlLst.Controls.Add(Me.lbScore)
        Me.PnlLst.Controls.Add(Me.lbNom)
        Me.PnlLst.Location = New System.Drawing.Point(9, 133)
        Me.PnlLst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlLst.Name = "PnlLst"
        Me.PnlLst.Size = New System.Drawing.Size(778, 104)
        Me.PnlLst.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nombre de partie " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chercheur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nombre de partie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trouveur"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(547, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Meilleur temps"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(670, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Temps Total"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 380)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PnlLst)
        Me.Controls.Add(Me.cboTrier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboRechercher)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnQuitter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.PnlLst.ResumeLayout(False)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTrier As ComboBox
    Friend WithEvents PnlLst As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
