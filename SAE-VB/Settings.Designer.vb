<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.PnlColorChoice = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnPresent = New System.Windows.Forms.Button()
        Me.btnPrePla = New System.Windows.Forms.Button()
        Me.lblColorResult = New System.Windows.Forms.Label()
        Me.TextBoxAbsent = New System.Windows.Forms.TextBox()
        Me.PnlTemps = New System.Windows.Forms.Panel()
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        Me.PanelTime = New System.Windows.Forms.Panel()
        Me.label_seconde = New System.Windows.Forms.Label()
        Me.txtbox_temps = New System.Windows.Forms.TextBox()
        Me.label_timer = New System.Windows.Forms.Label()
        Me.lblLimiteTime = New System.Windows.Forms.Label()
        Me.button_points = New System.Windows.Forms.Button()
        Me.PnlPath = New System.Windows.Forms.Panel()
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
        Me.PnlColorChoice.SuspendLayout()
        Me.PnlTemps.SuspendLayout()
        Me.PanelTime.SuspendLayout()
        Me.PnlPath.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumUpDownEssaie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnregistrer.Location = New System.Drawing.Point(472, 306)
        Me.btnEnregistrer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(111, 50)
        Me.btnEnregistrer.TabIndex = 17
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'PnlColorChoice
        '
        Me.PnlColorChoice.Controls.Add(Me.Label5)
        Me.PnlColorChoice.Controls.Add(Me.Label4)
        Me.PnlColorChoice.Controls.Add(Me.Label3)
        Me.PnlColorChoice.Controls.Add(Me.btnAbs)
        Me.PnlColorChoice.Controls.Add(Me.btnPresent)
        Me.PnlColorChoice.Controls.Add(Me.btnPrePla)
        Me.PnlColorChoice.Controls.Add(Me.lblColorResult)
        Me.PnlColorChoice.Controls.Add(Me.TextBoxAbsent)
        Me.PnlColorChoice.Location = New System.Drawing.Point(408, 15)
        Me.PnlColorChoice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PnlColorChoice.Name = "PnlColorChoice"
        Me.PnlColorChoice.Size = New System.Drawing.Size(166, 124)
        Me.PnlColorChoice.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 26)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Présent et " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bien Placé"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Présent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Absent"
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(117, 42)
        Me.btnAbs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(23, 15)
        Me.btnAbs.TabIndex = 35
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnPresent
        '
        Me.btnPresent.Location = New System.Drawing.Point(117, 62)
        Me.btnPresent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPresent.Name = "btnPresent"
        Me.btnPresent.Size = New System.Drawing.Size(23, 17)
        Me.btnPresent.TabIndex = 34
        Me.btnPresent.UseVisualStyleBackColor = True
        '
        'btnPrePla
        '
        Me.btnPrePla.Location = New System.Drawing.Point(117, 90)
        Me.btnPrePla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPrePla.Name = "btnPrePla"
        Me.btnPrePla.Size = New System.Drawing.Size(23, 15)
        Me.btnPrePla.TabIndex = 33
        Me.btnPrePla.UseVisualStyleBackColor = True
        '
        'lblColorResult
        '
        Me.lblColorResult.AutoSize = True
        Me.lblColorResult.BackColor = System.Drawing.Color.Transparent
        Me.lblColorResult.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorResult.ForeColor = System.Drawing.Color.Black
        Me.lblColorResult.Location = New System.Drawing.Point(8, 13)
        Me.lblColorResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColorResult.Name = "lblColorResult"
        Me.lblColorResult.Size = New System.Drawing.Size(153, 12)
        Me.lblColorResult.TabIndex = 32
        Me.lblColorResult.Text = "Couleur de la combinaison"
        Me.lblColorResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxAbsent
        '
        Me.TextBoxAbsent.Location = New System.Drawing.Point(170, 65)
        Me.TextBoxAbsent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAbsent.Name = "TextBoxAbsent"
        Me.TextBoxAbsent.Size = New System.Drawing.Size(24, 20)
        Me.TextBoxAbsent.TabIndex = 20
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
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.Location = New System.Drawing.Point(116, 37)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTime.TabIndex = 10
        Me.CheckBoxTime.UseVisualStyleBackColor = True
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
        Me.label_seconde.Location = New System.Drawing.Point(172, 11)
        Me.label_seconde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.label_timer.Location = New System.Drawing.Point(12, 11)
        Me.label_timer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.lblLimiteTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        'PnlPath
        '
        Me.PnlPath.BackColor = System.Drawing.Color.Transparent
        Me.PnlPath.Controls.Add(Me.button_points)
        Me.PnlPath.Controls.Add(Me.lblSauvegarde)
        Me.PnlPath.Controls.Add(Me.cboChemin)
        Me.PnlPath.Location = New System.Drawing.Point(10, 171)
        Me.PnlPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlPath.Name = "PnlPath"
        Me.PnlPath.Size = New System.Drawing.Size(266, 85)
        Me.PnlPath.TabIndex = 25
        '
        'lblSauvegarde
        '
        Me.lblSauvegarde.AutoSize = True
        Me.lblSauvegarde.BackColor = System.Drawing.Color.Transparent
        Me.lblSauvegarde.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSauvegarde.ForeColor = System.Drawing.Color.Black
        Me.lblSauvegarde.Location = New System.Drawing.Point(66, 19)
        Me.lblSauvegarde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.txtCar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCar.Name = "txtCar"
        Me.txtCar.Size = New System.Drawing.Size(26, 26)
        Me.txtCar.TabIndex = 30
        Me.txtCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResultChar
        '
        Me.lblResultChar.AutoSize = True
        Me.lblResultChar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultChar.Location = New System.Drawing.Point(44, 76)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 93)
        Me.Panel1.TabIndex = 32
        '
        'lblChoixCaractere
        '
        Me.lblChoixCaractere.AutoSize = True
        Me.lblChoixCaractere.BackColor = System.Drawing.Color.Transparent
        Me.lblChoixCaractere.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoixCaractere.ForeColor = System.Drawing.Color.Black
        Me.lblChoixCaractere.Location = New System.Drawing.Point(16, 11)
        Me.lblChoixCaractere.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChoixCaractere.Name = "lblChoixCaractere"
        Me.lblChoixCaractere.Size = New System.Drawing.Size(124, 12)
        Me.lblChoixCaractere.TabIndex = 27
        Me.lblChoixCaractere.Text = "Choix des caractères"
        Me.lblChoixCaractere.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NumUpDownEssaie
        '
        Me.NumUpDownEssaie.Location = New System.Drawing.Point(19, 35)
        Me.NumUpDownEssaie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 366)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlPath)
        Me.Controls.Add(Me.PnlTemps)
        Me.Controls.Add(Me.PnlColorChoice)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.PnlColorChoice.ResumeLayout(False)
        Me.PnlColorChoice.PerformLayout()
        Me.PnlTemps.ResumeLayout(False)
        Me.PnlTemps.PerformLayout()
        Me.PanelTime.ResumeLayout(False)
        Me.PanelTime.PerformLayout()
        Me.PnlPath.ResumeLayout(False)
        Me.PnlPath.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumUpDownEssaie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents PnlColorChoice As Panel
    Friend WithEvents TextBoxAbsent As TextBox
    Friend WithEvents PnlTemps As Panel
    Friend WithEvents label_seconde As Label
    Friend WithEvents txtbox_temps As TextBox
    Friend WithEvents label_timer As Label
    Friend WithEvents lblLimiteTime As Label
    Friend WithEvents button_points As Button
    Friend WithEvents PnlPath As Panel
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
    Friend WithEvents btnAbs As Button
    Friend WithEvents btnPresent As Button
    Friend WithEvents btnPrePla As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
