<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.cboJoueur1 = New System.Windows.Forms.ComboBox()
        Me.cboJoueur2 = New System.Windows.Forms.ComboBox()
        Me.btnStartJeu = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboJoueur1
        '
        Me.cboJoueur1.FormattingEnabled = True
        Me.cboJoueur1.Location = New System.Drawing.Point(162, 156)
        Me.cboJoueur1.Name = "cboJoueur1"
        Me.cboJoueur1.Size = New System.Drawing.Size(121, 24)
        Me.cboJoueur1.TabIndex = 0
        '
        'cboJoueur2
        '
        Me.cboJoueur2.FormattingEnabled = True
        Me.cboJoueur2.Location = New System.Drawing.Point(318, 155)
        Me.cboJoueur2.Name = "cboJoueur2"
        Me.cboJoueur2.Size = New System.Drawing.Size(121, 24)
        Me.cboJoueur2.TabIndex = 1
        '
        'btnStartJeu
        '
        Me.btnStartJeu.Location = New System.Drawing.Point(435, 326)
        Me.btnStartJeu.Name = "btnStartJeu"
        Me.btnStartJeu.Size = New System.Drawing.Size(75, 23)
        Me.btnStartJeu.TabIndex = 2
        Me.btnStartJeu.Text = "Démarrer"
        Me.btnStartJeu.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(135, 326)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(75, 23)
        Me.btnExitApp.TabIndex = 3
        Me.btnExitApp.Text = "Quitter"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(285, 326)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 23)
        Me.btnScores.TabIndex = 4
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnStartJeu)
        Me.Controls.Add(Me.cboJoueur2)
        Me.Controls.Add(Me.cboJoueur1)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboJoueur1 As ComboBox
    Friend WithEvents cboJoueur2 As ComboBox
    Friend WithEvents btnStartJeu As Button
    Friend WithEvents btnExitApp As Button
    Friend WithEvents btnScores As Button
End Class
