<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccueil))
        Me.cboJoueur1 = New System.Windows.Forms.ComboBox()
        Me.cboJoueur2 = New System.Windows.Forms.ComboBox()
        Me.btnStartJeu = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboJoueur1
        '
        Me.cboJoueur1.FormattingEnabled = True
        Me.cboJoueur1.Location = New System.Drawing.Point(163, 156)
        Me.cboJoueur1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboJoueur1.Name = "cboJoueur1"
        Me.cboJoueur1.Size = New System.Drawing.Size(121, 24)
        Me.cboJoueur1.TabIndex = 0
        '
        'cboJoueur2
        '
        Me.cboJoueur2.FormattingEnabled = True
        Me.cboJoueur2.Location = New System.Drawing.Point(317, 155)
        Me.cboJoueur2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboJoueur2.Name = "cboJoueur2"
        Me.cboJoueur2.Size = New System.Drawing.Size(121, 24)
        Me.cboJoueur2.TabIndex = 1
        '
        'btnStartJeu
        '
        Me.btnStartJeu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartJeu.Location = New System.Drawing.Point(435, 326)
        Me.btnStartJeu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStartJeu.Name = "btnStartJeu"
        Me.btnStartJeu.Size = New System.Drawing.Size(82, 23)
        Me.btnStartJeu.TabIndex = 2
        Me.btnStartJeu.Text = "Démarrer"
        Me.btnStartJeu.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitApp.Location = New System.Drawing.Point(135, 326)
        Me.btnExitApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(75, 23)
        Me.btnExitApp.TabIndex = 3
        Me.btnExitApp.Text = "Quitter"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScores.Location = New System.Drawing.Point(285, 326)
        Me.btnScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 23)
        Me.btnScores.TabIndex = 4
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.BackColor = System.Drawing.Color.Transparent
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
        Me.BtnSettings.Location = New System.Drawing.Point(25, 23)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(60, 60)
        Me.BtnSettings.TabIndex = 5
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Joueur 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Joueur 2"
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnStartJeu)
        Me.Controls.Add(Me.cboJoueur2)
        Me.Controls.Add(Me.cboJoueur1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboJoueur1 As ComboBox
    Friend WithEvents cboJoueur2 As ComboBox
    Friend WithEvents btnStartJeu As Button
    Friend WithEvents btnExitApp As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
