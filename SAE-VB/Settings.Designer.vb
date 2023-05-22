<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.txtColorPrésent = New System.Windows.Forms.TextBox()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.PnlColorChoice = New System.Windows.Forms.Panel()
        Me.lblColorResult = New System.Windows.Forms.Label()
        Me.txtColorPrésentBienPla = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RBPrésentBien = New System.Windows.Forms.RadioButton()
        Me.RBAbsent = New System.Windows.Forms.RadioButton()
        Me.RBPrésent = New System.Windows.Forms.RadioButton()
        Me.PnlTemps = New System.Windows.Forms.Panel()
        Me.PanelTime = New System.Windows.Forms.Panel()
        Me.label_seconde = New System.Windows.Forms.Label()
        Me.txtbox_temps = New System.Windows.Forms.TextBox()
        Me.label_timer = New System.Windows.Forms.Label()
        Me.lblLimiteTime = New System.Windows.Forms.Label()
        Me.button_points = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSauvegarde = New System.Windows.Forms.Label()
        Me.cboChemin = New System.Windows.Forms.ComboBox()
        Me.txtCar = New System.Windows.Forms.TextBox()
        Me.lblResultChar = New System.Windows.Forms.Label()
        Me.ToolTipChar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblChoixCaractere = New System.Windows.Forms.Label()
        Me.ToolTipCombin = New System.Windows.Forms.ToolTip(Me.components)
        Me.NumUpDownEssaie = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        Me.PnlColorChoice.SuspendLayout()
        Me.PnlTemps.SuspendLayout()
        Me.PanelTime.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumUpDownEssaie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtColorPrésent
        '
        Me.txtColorPrésent.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtColorPrésent.Location = New System.Drawing.Point(112, 67)
        Me.txtColorPrésent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtColorPrésent.Name = "txtColorPrésent"
        Me.txtColorPrésent.ReadOnly = True
        Me.txtColorPrésent.Size = New System.Drawing.Size(18, 20)
        Me.txtColorPrésent.TabIndex = 16
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnregistrer.Location = New System.Drawing.Point(472, 306)
        Me.btnEnregistrer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(111, 50)
        Me.btnEnregistrer.TabIndex = 17
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'PnlColorChoice
        '
        Me.PnlColorChoice.Controls.Add(Me.lblColorResult)
        Me.PnlColorChoice.Controls.Add(Me.txtColorPrésentBienPla)
        Me.PnlColorChoice.Controls.Add(Me.TextBox1)
        Me.PnlColorChoice.Controls.Add(Me.RBPrésentBien)
        Me.PnlColorChoice.Controls.Add(Me.RBAbsent)
        Me.PnlColorChoice.Controls.Add(Me.RBPrésent)
        Me.PnlColorChoice.Controls.Add(Me.txtColorPrésent)
        Me.PnlColorChoice.Location = New System.Drawing.Point(408, 15)
        Me.PnlColorChoice.Margin = New System.Windows.Forms.Padding(2)
        Me.PnlColorChoice.Name = "PnlColorChoice"
        Me.PnlColorChoice.Size = New System.Drawing.Size(157, 124)
        Me.PnlColorChoice.TabIndex = 18
        '
        'lblColorResult
        '
        Me.lblColorResult.AutoSize = True
        Me.lblColorResult.BackColor = System.Drawing.Color.Transparent
        Me.lblColorResult.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorResult.ForeColor = System.Drawing.Color.Black
        Me.lblColorResult.Location = New System.Drawing.Point(8, 13)
        Me.lblColorResult.Name = "lblColorResult"
        Me.lblColorResult.Size = New System.Drawing.Size(153, 12)
        Me.lblColorResult.TabIndex = 32
        Me.lblColorResult.Text = "Couleur de la combinaison"
        Me.lblColorResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtColorPrésentBienPla
        '
        Me.txtColorPrésentBienPla.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtColorPrésentBienPla.Location = New System.Drawing.Point(112, 90)
        Me.txtColorPrésentBienPla.Margin = New System.Windows.Forms.Padding(2)
        Me.txtColorPrésentBienPla.Name = "txtColorPrésentBienPla"
        Me.txtColorPrésentBienPla.ReadOnly = True
        Me.txtColorPrésentBienPla.Size = New System.Drawing.Size(18, 20)
        Me.txtColorPrésentBienPla.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 20)
        Me.TextBox1.TabIndex = 20
        '
        'RBPrésentBien
        '
        Me.RBPrésentBien.AutoSize = True
        Me.RBPrésentBien.Location = New System.Drawing.Point(26, 84)
        Me.RBPrésentBien.Margin = New System.Windows.Forms.Padding(2)
        Me.RBPrésentBien.Name = "RBPrésentBien"
        Me.RBPrésentBien.Size = New System.Drawing.Size(76, 30)
        Me.RBPrésentBien.TabIndex = 19
        Me.RBPrésentBien.Text = "Présent et " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bien Placé"
        Me.RBPrésentBien.UseVisualStyleBackColor = True
        '
        'RBAbsent
        '
        Me.RBAbsent.AutoSize = True
        Me.RBAbsent.Location = New System.Drawing.Point(26, 42)
        Me.RBAbsent.Margin = New System.Windows.Forms.Padding(2)
        Me.RBAbsent.Name = "RBAbsent"
        Me.RBAbsent.Size = New System.Drawing.Size(58, 17)
        Me.RBAbsent.TabIndex = 18
        Me.RBAbsent.Text = "Absent"
        Me.RBAbsent.UseVisualStyleBackColor = True
        '
        'RBPrésent
        '
        Me.RBPrésent.AutoSize = True
        Me.RBPrésent.Location = New System.Drawing.Point(26, 63)
        Me.RBPrésent.Margin = New System.Windows.Forms.Padding(2)
        Me.RBPrésent.Name = "RBPrésent"
        Me.RBPrésent.Size = New System.Drawing.Size(61, 17)
        Me.RBPrésent.TabIndex = 17
        Me.RBPrésent.Text = "Présent"
        Me.RBPrésent.UseVisualStyleBackColor = True
        '
        'PnlTemps
        '
        Me.PnlTemps.BackColor = System.Drawing.Color.Transparent
        Me.PnlTemps.Controls.Add(Me.CheckBoxTime)
        Me.PnlTemps.Controls.Add(Me.PanelTime)
        Me.PnlTemps.Controls.Add(Me.lblLimiteTime)
        Me.PnlTemps.Location = New System.Drawing.Point(10, 7)
        Me.PnlTemps.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlTemps.Name = "PnlTemps"
        Me.PnlTemps.Size = New System.Drawing.Size(266, 132)
        Me.PnlTemps.TabIndex = 24
        '
        'PanelTime
        '
        Me.PanelTime.Controls.Add(Me.label_seconde)
        Me.PanelTime.Controls.Add(Me.txtbox_temps)
        Me.PanelTime.Controls.Add(Me.label_timer)
        Me.PanelTime.Location = New System.Drawing.Point(10, 91)
        Me.PanelTime.Name = "PanelTime"
        Me.PanelTime.Size = New System.Drawing.Size(238, 30)
        Me.PanelTime.TabIndex = 9
        Me.PanelTime.Visible = False
        '
        'label_seconde
        '
        Me.label_seconde.AutoSize = True
        Me.label_seconde.ForeColor = System.Drawing.Color.Black
        Me.label_seconde.Location = New System.Drawing.Point(172, 12)
        Me.label_seconde.Name = "label_seconde"
        Me.label_seconde.Size = New System.Drawing.Size(59, 13)
        Me.label_seconde.TabIndex = 5
        Me.label_seconde.Text = "seconde(s)"
        '
        'txtbox_temps
        '
        Me.txtbox_temps.Location = New System.Drawing.Point(74, 7)
        Me.txtbox_temps.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_temps.Name = "txtbox_temps"
        Me.txtbox_temps.Size = New System.Drawing.Size(91, 20)
        Me.txtbox_temps.TabIndex = 4
        '
        'label_timer
        '
        Me.label_timer.AutoSize = True
        Me.label_timer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_timer.ForeColor = System.Drawing.Color.Black
        Me.label_timer.Location = New System.Drawing.Point(12, 12)
        Me.label_timer.Name = "label_timer"
        Me.label_timer.Size = New System.Drawing.Size(43, 12)
        Me.label_timer.TabIndex = 3
        Me.label_timer.Text = "Timer :"
        '
        'lblLimiteTime
        '
        Me.lblLimiteTime.AutoSize = True
        Me.lblLimiteTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteTime.ForeColor = System.Drawing.Color.Black
        Me.lblLimiteTime.Location = New System.Drawing.Point(3, 37)
        Me.lblLimiteTime.Name = "lblLimiteTime"
        Me.lblLimiteTime.Size = New System.Drawing.Size(93, 12)
        Me.lblLimiteTime.TabIndex = 0
        Me.lblLimiteTime.Text = "Limite de temps"
        '
        'button_points
        '
        Me.button_points.BackColor = System.Drawing.Color.White
        Me.button_points.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_points.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.button_points.ForeColor = System.Drawing.Color.Black
        Me.button_points.Location = New System.Drawing.Point(213, 41)
        Me.button_points.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.button_points.Name = "button_points"
        Me.button_points.Size = New System.Drawing.Size(36, 26)
        Me.button_points.TabIndex = 26
        Me.button_points.Text = "..."
        Me.button_points.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.button_points)
        Me.Panel4.Controls.Add(Me.lblSauvegarde)
        Me.Panel4.Controls.Add(Me.cboChemin)
        Me.Panel4.Location = New System.Drawing.Point(10, 171)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(266, 85)
        Me.Panel4.TabIndex = 25
        '
        'lblSauvegarde
        '
        Me.lblSauvegarde.AutoSize = True
        Me.lblSauvegarde.BackColor = System.Drawing.Color.Transparent
        Me.lblSauvegarde.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSauvegarde.ForeColor = System.Drawing.Color.Black
        Me.lblSauvegarde.Location = New System.Drawing.Point(66, 19)
        Me.lblSauvegarde.Name = "lblSauvegarde"
        Me.lblSauvegarde.Size = New System.Drawing.Size(133, 12)
        Me.lblSauvegarde.TabIndex = 8
        Me.lblSauvegarde.Text = "Chemin de sauvegarde"
        '
        'cboChemin
        '
        Me.cboChemin.FormattingEnabled = True
        Me.cboChemin.Location = New System.Drawing.Point(24, 45)
        Me.cboChemin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboChemin.Name = "cboChemin"
        Me.cboChemin.Size = New System.Drawing.Size(184, 21)
        Me.cboChemin.TabIndex = 13
        '
        'txtCar
        '
        Me.txtCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCar.Location = New System.Drawing.Point(56, 39)
        Me.txtCar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCar.Name = "txtCar"
        Me.txtCar.Size = New System.Drawing.Size(26, 26)
        Me.txtCar.TabIndex = 30
        Me.txtCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResultChar
        '
        Me.lblResultChar.AutoSize = True
        Me.lblResultChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultChar.Location = New System.Drawing.Point(44, 77)
        Me.lblResultChar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultChar.Name = "lblResultChar"
        Me.lblResultChar.Size = New System.Drawing.Size(0, 15)
        Me.lblResultChar.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblChoixCaractere)
        Me.Panel1.Controls.Add(Me.txtCar)
        Me.Panel1.Controls.Add(Me.lblResultChar)
        Me.Panel1.Location = New System.Drawing.Point(408, 171)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 92)
        Me.Panel1.TabIndex = 32
        '
        'lblChoixCaractere
        '
        Me.lblChoixCaractere.AutoSize = True
        Me.lblChoixCaractere.BackColor = System.Drawing.Color.Transparent
        Me.lblChoixCaractere.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoixCaractere.ForeColor = System.Drawing.Color.Black
        Me.lblChoixCaractere.Location = New System.Drawing.Point(16, 11)
        Me.lblChoixCaractere.Name = "lblChoixCaractere"
        Me.lblChoixCaractere.Size = New System.Drawing.Size(124, 12)
        Me.lblChoixCaractere.TabIndex = 27
        Me.lblChoixCaractere.Text = "Choix des caractères"
        Me.lblChoixCaractere.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NumUpDownEssaie
        '
        Me.NumUpDownEssaie.Location = New System.Drawing.Point(19, 35)
        Me.NumUpDownEssaie.Margin = New System.Windows.Forms.Padding(2)
        Me.NumUpDownEssaie.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumUpDownEssaie.Minimum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.NumUpDownEssaie.Name = "NumUpDownEssaie"
        Me.NumUpDownEssaie.Size = New System.Drawing.Size(38, 20)
        Me.NumUpDownEssaie.TabIndex = 33
        Me.NumUpDownEssaie.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.NumUpDownEssaie)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(10, 271)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 63)
        Me.Panel2.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 12)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Limite de proposition pour l'adversaire"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 31
        '
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.Location = New System.Drawing.Point(116, 37)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTime.TabIndex = 10
        Me.CheckBoxTime.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PnlTemps)
        Me.Controls.Add(Me.PnlColorChoice)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.PnlColorChoice.ResumeLayout(False)
        Me.PnlColorChoice.PerformLayout()
        Me.PnlTemps.ResumeLayout(False)
        Me.PnlTemps.PerformLayout()
        Me.PanelTime.ResumeLayout(False)
        Me.PanelTime.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumUpDownEssaie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtColorPrésent As TextBox
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents PnlColorChoice As Panel
    Friend WithEvents txtColorPrésentBienPla As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RBPrésentBien As RadioButton
    Friend WithEvents RBAbsent As RadioButton
    Friend WithEvents RBPrésent As RadioButton
    Friend WithEvents PnlTemps As Panel
    Friend WithEvents label_seconde As Label
    Friend WithEvents txtbox_temps As TextBox
    Friend WithEvents label_timer As Label
    Friend WithEvents lblLimiteTime As Label
    Friend WithEvents button_points As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSauvegarde As Label
    Friend WithEvents cboChemin As ComboBox
    Friend WithEvents txtCar As TextBox
    Friend WithEvents lblResultChar As Label
    Friend WithEvents ToolTipChar As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblColorResult As Label
    Friend WithEvents lblChoixCaractere As Label
    Friend WithEvents ToolTipCombin As ToolTip
    Friend WithEvents NumUpDownEssaie As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTime As Panel
    Friend WithEvents CheckBoxTime As CheckBox
End Class
