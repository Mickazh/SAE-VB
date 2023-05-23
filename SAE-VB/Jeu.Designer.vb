<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PnlChar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEssaie
        '
        Me.btnEssaie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEssaie.Location = New System.Drawing.Point(476, 97)
        Me.btnEssaie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEssaie.Name = "btnEssaie"
        Me.btnEssaie.Size = New System.Drawing.Size(75, 23)
        Me.btnEssaie.TabIndex = 19
        Me.btnEssaie.Text = "Guess"
        Me.btnEssaie.UseVisualStyleBackColor = True
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(352, 5)
        Me.txt5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(77, 22)
        Me.txt5.TabIndex = 18
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(268, 5)
        Me.txt4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(77, 22)
        Me.txt4.TabIndex = 17
        Me.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(184, 5)
        Me.txt3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(77, 22)
        Me.txt3.TabIndex = 16
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(100, 5)
        Me.txt2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(77, 22)
        Me.txt2.TabIndex = 15
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(16, 5)
        Me.txt1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(77, 22)
        Me.txt1.TabIndex = 14
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCaractères
        '
        Me.lblCaractères.AutoSize = True
        Me.lblCaractères.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaractères.Location = New System.Drawing.Point(332, 305)
        Me.lblCaractères.Name = "lblCaractères"
        Me.lblCaractères.Size = New System.Drawing.Size(178, 20)
        Me.lblCaractères.TabIndex = 13
        Me.lblCaractères.Text = "Caractères jouables"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(205, 32)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(113, 20)
        Me.lblTitre.TabIndex = 12
        Me.lblTitre.Text = "Master Mind"
        '
        'lblCodeColor
        '
        Me.lblCodeColor.AutoSize = True
        Me.lblCodeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeColor.Location = New System.Drawing.Point(332, 159)
        Me.lblCodeColor.Name = "lblCodeColor"
        Me.lblCodeColor.Size = New System.Drawing.Size(123, 20)
        Me.lblCodeColor.TabIndex = 20
        Me.lblCodeColor.Text = "Code Couleur"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(333, 204)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(52, 17)
        Me.lblAbsent.TabIndex = 24
        Me.lblAbsent.Text = "Absent"
        '
        'lblPresentPlace
        '
        Me.lblPresentPlace.AutoSize = True
        Me.lblPresentPlace.Location = New System.Drawing.Point(333, 256)
        Me.lblPresentPlace.Name = "lblPresentPlace"
        Me.lblPresentPlace.Size = New System.Drawing.Size(144, 17)
        Me.lblPresentPlace.TabIndex = 25
        Me.lblPresentPlace.Text = "Présent et Bien Placé"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(333, 230)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(57, 17)
        Me.lblPresent.TabIndex = 26
        Me.lblPresent.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 20)
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
        Me.PnlChar.Location = New System.Drawing.Point(25, 95)
        Me.PnlChar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlChar.Name = "PnlChar"
        Me.PnlChar.Size = New System.Drawing.Size(447, 39)
        Me.PnlChar.TabIndex = 29
        '
        'BtnBye
        '
        Me.BtnBye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBye.Location = New System.Drawing.Point(447, 598)
        Me.BtnBye.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBye.Name = "BtnBye"
        Me.BtnBye.Size = New System.Drawing.Size(100, 28)
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
        Me.RTBTenta.Location = New System.Drawing.Point(75, 201)
        Me.RTBTenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RTBTenta.Name = "RTBTenta"
        Me.RTBTenta.ReadOnly = True
        Me.RTBTenta.Size = New System.Drawing.Size(161, 422)
        Me.RTBTenta.TabIndex = 31
        Me.RTBTenta.Text = ""
        '
        'LblCharJouable
        '
        Me.LblCharJouable.AutoSize = True
        Me.LblCharJouable.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCharJouable.Location = New System.Drawing.Point(333, 325)
        Me.LblCharJouable.Name = "LblCharJouable"
        Me.LblCharJouable.Size = New System.Drawing.Size(0, 17)
        Me.LblCharJouable.TabIndex = 32
        Me.LblCharJouable.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemps.Location = New System.Drawing.Point(348, 493)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(85, 20)
        Me.lblTemps.TabIndex = 33
        Me.lblTemps.Text = "lblTemps"
        '
        'lblSeconde
        '
        Me.lblSeconde.AutoSize = True
        Me.lblSeconde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconde.Location = New System.Drawing.Point(443, 493)
        Me.lblSeconde.Name = "lblSeconde"
        Me.lblSeconde.Size = New System.Drawing.Size(109, 20)
        Me.lblSeconde.TabIndex = 34
        Me.lblSeconde.Text = "seconde (s)"
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 655)
        Me.Controls.Add(Me.lblSeconde)
        Me.Controls.Add(Me.lblTemps)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
End Class
