<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.pnlEssais = New System.Windows.Forms.Panel()
        Me.LstTentatives = New System.Windows.Forms.ListBox()
        Me.PnlChar = New System.Windows.Forms.Panel()
        Me.BtnBye = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.RTBTenta = New System.Windows.Forms.RichTextBox()
        Me.pnlEssais.SuspendLayout()
        Me.PnlChar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEssaie
        '
        Me.btnEssaie.Location = New System.Drawing.Point(536, 122)
        Me.btnEssaie.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnEssaie.Name = "btnEssaie"
        Me.btnEssaie.Size = New System.Drawing.Size(84, 29)
        Me.btnEssaie.TabIndex = 19
        Me.btnEssaie.Text = "Guess"
        Me.btnEssaie.UseVisualStyleBackColor = True
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(396, 6)
        Me.txt5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(86, 26)
        Me.txt5.TabIndex = 18
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(302, 6)
        Me.txt4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(86, 26)
        Me.txt4.TabIndex = 17
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(207, 6)
        Me.txt3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(86, 26)
        Me.txt3.TabIndex = 16
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(112, 6)
        Me.txt2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(86, 26)
        Me.txt2.TabIndex = 15
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(18, 6)
        Me.txt1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(86, 26)
        Me.txt1.TabIndex = 14
        '
        'lblCaractères
        '
        Me.lblCaractères.AutoSize = True
        Me.lblCaractères.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaractères.Location = New System.Drawing.Point(374, 382)
        Me.lblCaractères.Name = "lblCaractères"
        Me.lblCaractères.Size = New System.Drawing.Size(205, 25)
        Me.lblCaractères.TabIndex = 13
        Me.lblCaractères.Text = "Caractères jouables"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(231, 40)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(131, 25)
        Me.lblTitre.TabIndex = 12
        Me.lblTitre.Text = "Master Mind"
        '
        'lblCodeColor
        '
        Me.lblCodeColor.AutoSize = True
        Me.lblCodeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeColor.Location = New System.Drawing.Point(374, 198)
        Me.lblCodeColor.Name = "lblCodeColor"
        Me.lblCodeColor.Size = New System.Drawing.Size(146, 25)
        Me.lblCodeColor.TabIndex = 20
        Me.lblCodeColor.Text = "Code Couleur"
        '
        'lblAbsent
        '
        Me.lblAbsent.AutoSize = True
        Me.lblAbsent.Location = New System.Drawing.Point(375, 255)
        Me.lblAbsent.Name = "lblAbsent"
        Me.lblAbsent.Size = New System.Drawing.Size(60, 20)
        Me.lblAbsent.TabIndex = 24
        Me.lblAbsent.Text = "Absent"
        '
        'lblPresentPlace
        '
        Me.lblPresentPlace.AutoSize = True
        Me.lblPresentPlace.Location = New System.Drawing.Point(375, 320)
        Me.lblPresentPlace.Name = "lblPresentPlace"
        Me.lblPresentPlace.Size = New System.Drawing.Size(161, 20)
        Me.lblPresentPlace.TabIndex = 25
        Me.lblPresentPlace.Text = "Présent et Bien Placé"
        '
        'lblPresent
        '
        Me.lblPresent.AutoSize = True
        Me.lblPresent.Location = New System.Drawing.Point(375, 288)
        Me.lblPresent.Name = "lblPresent"
        Me.lblPresent.Size = New System.Drawing.Size(64, 20)
        Me.lblPresent.TabIndex = 26
        Me.lblPresent.Text = "Présent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Essais précédents"
        '
        'pnlEssais
        '
        Me.pnlEssais.Controls.Add(Me.LstTentatives)
        Me.pnlEssais.Location = New System.Drawing.Point(82, 255)
        Me.pnlEssais.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pnlEssais.Name = "pnlEssais"
        Me.pnlEssais.Size = New System.Drawing.Size(212, 546)
        Me.pnlEssais.TabIndex = 28
        '
        'LstTentatives
        '
        Me.LstTentatives.FormattingEnabled = True
        Me.LstTentatives.ItemHeight = 20
        Me.LstTentatives.Location = New System.Drawing.Point(4, 12)
        Me.LstTentatives.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstTentatives.Name = "LstTentatives"
        Me.LstTentatives.Size = New System.Drawing.Size(200, 524)
        Me.LstTentatives.TabIndex = 0
        '
        'PnlChar
        '
        Me.PnlChar.Controls.Add(Me.txt5)
        Me.PnlChar.Controls.Add(Me.txt4)
        Me.PnlChar.Controls.Add(Me.txt3)
        Me.PnlChar.Controls.Add(Me.txt2)
        Me.PnlChar.Controls.Add(Me.txt1)
        Me.PnlChar.Location = New System.Drawing.Point(28, 118)
        Me.PnlChar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlChar.Name = "PnlChar"
        Me.PnlChar.Size = New System.Drawing.Size(502, 49)
        Me.PnlChar.TabIndex = 29
        '
        'BtnBye
        '
        Me.BtnBye.Location = New System.Drawing.Point(502, 748)
        Me.BtnBye.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBye.Name = "BtnBye"
        Me.BtnBye.Size = New System.Drawing.Size(112, 35)
        Me.BtnBye.TabIndex = 30
        Me.BtnBye.Text = "Bye"
        Me.BtnBye.UseVisualStyleBackColor = True
        '
        'RTBTenta
        '
        Me.RTBTenta.Location = New System.Drawing.Point(368, 520)
        Me.RTBTenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RTBTenta.Name = "RTBTenta"
        Me.RTBTenta.Size = New System.Drawing.Size(118, 61)
        Me.RTBTenta.TabIndex = 31
        Me.RTBTenta.Text = ""
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 818)
        Me.Controls.Add(Me.RTBTenta)
        Me.Controls.Add(Me.BtnBye)
        Me.Controls.Add(Me.PnlChar)
        Me.Controls.Add(Me.pnlEssais)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPresent)
        Me.Controls.Add(Me.lblPresentPlace)
        Me.Controls.Add(Me.lblAbsent)
        Me.Controls.Add(Me.lblCodeColor)
        Me.Controls.Add(Me.btnEssaie)
        Me.Controls.Add(Me.lblCaractères)
        Me.Controls.Add(Me.lblTitre)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.pnlEssais.ResumeLayout(False)
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
    Friend WithEvents pnlEssais As Panel
    Friend WithEvents PnlChar As Panel
    Friend WithEvents BtnBye As Button
    Friend WithEvents LstTentatives As ListBox
    Friend WithEvents Timer As Timer
    Friend WithEvents RTBTenta As RichTextBox
End Class
