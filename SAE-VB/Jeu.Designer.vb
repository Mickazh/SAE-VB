﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEssaie = New System.Windows.Forms.Button()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lblCaractères = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCodeColor = New System.Windows.Forms.Label()
        Me.lblAbsent = New System.Windows.Forms.Label()
        Me.lblPresentPlace = New System.Windows.Forms.Label()
        Me.lblPresent = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlChar = New System.Windows.Forms.Panel()
        Me.BtnBye = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.RTBTenta = New System.Windows.Forms.RichTextBox()
        Me.LblCharJouable = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.lblSeconde = New System.Windows.Forms.Label()
        Me.LblCacheur = New System.Windows.Forms.Label()
        Me.LblChercheur = New System.Windows.Forms.Label()
        Me.PnlChar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEssaie
        '
        Me.btnEssaie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEssaie.Location = New System.Drawing.Point(357, 79)
        Me.btnEssaie.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEssaie.Name = "btnEssaie"
        Me.btnEssaie.Size = New System.Drawing.Size(56, 19)
        Me.btnEssaie.TabIndex = 19
        Me.btnEssaie.Text = "Guess"
        Me.btnEssaie.UseVisualStyleBackColor = True
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(264, 4)
        Me.txt5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(59, 20)
        Me.txt5.TabIndex = 18
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(201, 4)
        Me.txt4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(59, 20)
        Me.txt4.TabIndex = 17
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(138, 4)
        Me.txt3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(59, 20)
        Me.txt3.TabIndex = 16
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(75, 4)
        Me.txt2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(59, 20)
        Me.txt2.TabIndex = 15
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 4)
        Me.txt1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(59, 20)
        Me.txt1.TabIndex = 14
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaractères
        '
        Me.lblCaractères.AutoSize = True
        Me.lblCaractères.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaractères.Location = New System.Drawing.Point(249, 248)
        Me.lblCaractères.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCaractères.Name = "lblCaractères"
        Me.lblCaractères.Size = New System.Drawing.Size(153, 17)
        Me.lblCaractères.TabIndex = 13
        Me.lblCaractères.Text = "Caractères jouables"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(154, 26)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(96, 17)
        Me.lblTitre.TabIndex = 12
        Me.lblTitre.Text = "Master Mind"
        '
        'lblCodeColor
        '
        Me.lblCodeColor.AutoSize = True
        Me.lblCodeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeColor.Location = New System.Drawing.Point(249, 129)
        Me.lblCodeColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeColor.Name = "lblCodeColor"
        Me.lblCodeColor.Size = New System.Drawing.Size(106, 17)
        Me.lblCodeColor.TabIndex = 20
        Me.lblCodeColor.Text = "Code Couleur"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(250, 166)
        Me.lblAbsent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(40, 13)
        Me.lblAbsent.TabIndex = 24
        Me.lblAbsent.Text = "Absent"
        '
        'lblPresentPlace
        '
        Me.lblPresentPlace.AutoSize = True
        Me.lblPresentPlace.Location = New System.Drawing.Point(250, 208)
        Me.lblPresentPlace.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPresentPlace.Name = "lblPresentPlace"
        Me.lblPresentPlace.Size = New System.Drawing.Size(109, 13)
        Me.lblPresentPlace.TabIndex = 25
        Me.lblPresentPlace.Text = "Présent et Bien Placé"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(250, 187)
        Me.lblPresent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(43, 13)
        Me.lblPresent.TabIndex = 26
        Me.lblPresent.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Essais précédents"
        '
        'PnlChar
        '
        Me.PnlChar.Controls.Add(Me.txt5)
        Me.PnlChar.Controls.Add(Me.txt4)
        Me.PnlChar.Controls.Add(Me.txt3)
        Me.PnlChar.Controls.Add(Me.txt2)
        Me.PnlChar.Controls.Add(Me.txt1)
        Me.PnlChar.Location = New System.Drawing.Point(19, 77)
        Me.PnlChar.Name = "PnlChar"
        Me.PnlChar.Size = New System.Drawing.Size(335, 32)
        Me.PnlChar.TabIndex = 29
        '
        'BtnBye
        '
        Me.BtnBye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBye.Location = New System.Drawing.Point(283, 492)
        Me.BtnBye.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBye.Name = "BtnBye"
        Me.BtnBye.Size = New System.Drawing.Size(92, 41)
        Me.BtnBye.TabIndex = 30
        Me.BtnBye.Text = "Bye"
        Me.BtnBye.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'RTBTenta
        '
        Me.RTBTenta.Location = New System.Drawing.Point(56, 163)
        Me.RTBTenta.Name = "RTBTenta"
        Me.RTBTenta.ReadOnly = True
        Me.RTBTenta.Size = New System.Drawing.Size(115, 396)
        Me.RTBTenta.TabIndex = 31
        Me.RTBTenta.Text = ""
        '
        'LblCharJouable
        '
        Me.LblCharJouable.AutoSize = True
        Me.LblCharJouable.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCharJouable.Location = New System.Drawing.Point(250, 264)
        Me.LblCharJouable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCharJouable.Name = "LblCharJouable"
        Me.LblCharJouable.Size = New System.Drawing.Size(0, 13)
        Me.LblCharJouable.TabIndex = 32
        Me.LblCharJouable.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemps.Location = New System.Drawing.Point(279, 401)
        Me.lblTemps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(73, 17)
        Me.lblTemps.TabIndex = 33
        Me.lblTemps.Text = "lblTemps"
        '
        'lblSeconde
        '
        Me.lblSeconde.AutoSize = True
        Me.lblSeconde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconde.Location = New System.Drawing.Point(332, 401)
        Me.lblSeconde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeconde.Name = "lblSeconde"
        Me.lblSeconde.Size = New System.Drawing.Size(94, 17)
        Me.lblSeconde.TabIndex = 34
        Me.lblSeconde.Text = "seconde (s)"
        '
        'LblCacheur
        '
        Me.LblCacheur.AutoSize = True
        Me.LblCacheur.Location = New System.Drawing.Point(19, 2)
        Me.LblCacheur.Name = "LblCacheur"
        Me.LblCacheur.Size = New System.Drawing.Size(0, 13)
        Me.LblCacheur.TabIndex = 35
        '
        'LblChercheur
        '
        Me.LblChercheur.AutoSize = True
        Me.LblChercheur.Location = New System.Drawing.Point(269, 2)
        Me.LblChercheur.Name = "LblChercheur"
        Me.LblChercheur.Size = New System.Drawing.Size(0, 13)
        Me.LblChercheur.TabIndex = 36
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(424, 584)
        Me.Controls.Add(Me.LblChercheur)
        Me.Controls.Add(Me.LblCacheur)
        Me.Controls.Add(Me.lblSeconde)
        Me.Controls.Add(Me.LblCharJouable)
        Me.Controls.Add(Me.RTBTenta)
        Me.Controls.Add(Me.BtnBye)
        Me.Controls.Add(Me.PnlChar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.lblPresentPlace)
        Me.Controls.Add(Me.lblAbsent)
        Me.Controls.Add(Me.lblCodeColor)
        Me.Controls.Add(Me.btnEssaie)
        Me.Controls.Add(Me.lblCaractères)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblTemps)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.PnlChar.ResumeLayout(False)
        Me.PnlChar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEssaie As Button
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lblCaractères As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblCodeColor As Label
    Friend WithEvents lblAbsent As Label
    Friend WithEvents lblPresentPlace As Label
    Friend WithEvents lblPresent As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PnlChar As Panel
    Friend WithEvents BtnBye As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents RTBTenta As RichTextBox
    Friend WithEvents LblCharJouable As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents lblSeconde As Label
    Friend WithEvents LblCacheur As Label
    Friend WithEvents LblChercheur As Label
End Class
