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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.txtColorPrésent = New System.Windows.Forms.TextBox()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.PnlColorChoice = New System.Windows.Forms.Panel()
        Me.lblColorMaster = New System.Windows.Forms.Label()
        Me.txtColorPrésentBienPla = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RBPrésentBien = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RBPrésent = New System.Windows.Forms.RadioButton()
        Me.PnlTemps = New System.Windows.Forms.Panel()
        Me.RBNon = New System.Windows.Forms.RadioButton()
        Me.RBOui = New System.Windows.Forms.RadioButton()
        Me.label_seconde = New System.Windows.Forms.Label()
        Me.txtbox_temps = New System.Windows.Forms.TextBox()
        Me.label_timer = New System.Windows.Forms.Label()
        Me.lblLimiteTime = New System.Windows.Forms.Label()
        Me.button_points = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSauvegarde = New System.Windows.Forms.Label()
        Me.cboChemin = New System.Windows.Forms.ComboBox()
        Me.PnlColorChoice.SuspendLayout()
        Me.PnlTemps.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtColorPrésent
        '
        Me.txtColorPrésent.Location = New System.Drawing.Point(150, 83)
        Me.txtColorPrésent.Name = "txtColorPrésent"
        Me.txtColorPrésent.Size = New System.Drawing.Size(22, 22)
        Me.txtColorPrésent.TabIndex = 16
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnregistrer.Location = New System.Drawing.Point(629, 376)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(148, 62)
        Me.btnEnregistrer.TabIndex = 17
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'PnlColorChoice
        '
        Me.PnlColorChoice.Controls.Add(Me.lblColorMaster)
        Me.PnlColorChoice.Controls.Add(Me.txtColorPrésentBienPla)
        Me.PnlColorChoice.Controls.Add(Me.TextBox1)
        Me.PnlColorChoice.Controls.Add(Me.RBPrésentBien)
        Me.PnlColorChoice.Controls.Add(Me.RadioButton2)
        Me.PnlColorChoice.Controls.Add(Me.RBPrésent)
        Me.PnlColorChoice.Controls.Add(Me.txtColorPrésent)
        Me.PnlColorChoice.Location = New System.Drawing.Point(544, 19)
        Me.PnlColorChoice.Name = "PnlColorChoice"
        Me.PnlColorChoice.Size = New System.Drawing.Size(200, 152)
        Me.PnlColorChoice.TabIndex = 18
        '
        'lblColorMaster
        '
        Me.lblColorMaster.AutoSize = True
        Me.lblColorMaster.Location = New System.Drawing.Point(32, 14)
        Me.lblColorMaster.Name = "lblColorMaster"
        Me.lblColorMaster.Size = New System.Drawing.Size(117, 16)
        Me.lblColorMaster.TabIndex = 22
        Me.lblColorMaster.Text = "Couleur du résultat"
        '
        'txtColorPrésentBienPla
        '
        Me.txtColorPrésentBienPla.Location = New System.Drawing.Point(150, 111)
        Me.txtColorPrésentBienPla.Name = "txtColorPrésentBienPla"
        Me.txtColorPrésentBienPla.Size = New System.Drawing.Size(22, 22)
        Me.txtColorPrésentBienPla.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 22)
        Me.TextBox1.TabIndex = 20
        '
        'RBPrésentBien
        '
        Me.RBPrésentBien.AutoSize = True
        Me.RBPrésentBien.Location = New System.Drawing.Point(35, 104)
        Me.RBPrésentBien.Name = "RBPrésentBien"
        Me.RBPrésentBien.Size = New System.Drawing.Size(93, 36)
        Me.RBPrésentBien.TabIndex = 19
        Me.RBPrésentBien.Text = "Présent et " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bien Placé"
        Me.RBPrésentBien.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(35, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RBPrésent
        '
        Me.RBPrésent.AutoSize = True
        Me.RBPrésent.Location = New System.Drawing.Point(35, 78)
        Me.RBPrésent.Name = "RBPrésent"
        Me.RBPrésent.Size = New System.Drawing.Size(74, 20)
        Me.RBPrésent.TabIndex = 17
        Me.RBPrésent.Text = "Présent"
        Me.RBPrésent.UseVisualStyleBackColor = True
        '
        'PnlTemps
        '
        Me.PnlTemps.BackColor = System.Drawing.Color.Transparent
        Me.PnlTemps.Controls.Add(Me.RBNon)
        Me.PnlTemps.Controls.Add(Me.RBOui)
        Me.PnlTemps.Controls.Add(Me.label_seconde)
        Me.PnlTemps.Controls.Add(Me.txtbox_temps)
        Me.PnlTemps.Controls.Add(Me.label_timer)
        Me.PnlTemps.Controls.Add(Me.lblLimiteTime)
        Me.PnlTemps.Location = New System.Drawing.Point(13, 9)
        Me.PnlTemps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlTemps.Name = "PnlTemps"
        Me.PnlTemps.Size = New System.Drawing.Size(354, 162)
        Me.PnlTemps.TabIndex = 24
        '
        'RBNon
        '
        Me.RBNon.AutoSize = True
        Me.RBNon.ForeColor = System.Drawing.Color.Black
        Me.RBNon.Location = New System.Drawing.Point(127, 61)
        Me.RBNon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RBNon.Name = "RBNon"
        Me.RBNon.Size = New System.Drawing.Size(53, 20)
        Me.RBNon.TabIndex = 8
        Me.RBNon.TabStop = True
        Me.RBNon.Text = "Non"
        Me.RBNon.UseVisualStyleBackColor = True
        '
        'RBOui
        '
        Me.RBOui.AutoSize = True
        Me.RBOui.ForeColor = System.Drawing.Color.Black
        Me.RBOui.Location = New System.Drawing.Point(127, 26)
        Me.RBOui.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RBOui.Name = "RBOui"
        Me.RBOui.Size = New System.Drawing.Size(48, 20)
        Me.RBOui.TabIndex = 7
        Me.RBOui.TabStop = True
        Me.RBOui.Text = "Oui"
        Me.RBOui.UseVisualStyleBackColor = True
        '
        'label_seconde
        '
        Me.label_seconde.AutoSize = True
        Me.label_seconde.ForeColor = System.Drawing.Color.Black
        Me.label_seconde.Location = New System.Drawing.Point(243, 127)
        Me.label_seconde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_seconde.Name = "label_seconde"
        Me.label_seconde.Size = New System.Drawing.Size(75, 16)
        Me.label_seconde.TabIndex = 5
        Me.label_seconde.Text = "seconde(s)"
        '
        'txtbox_temps
        '
        Me.txtbox_temps.Location = New System.Drawing.Point(112, 121)
        Me.txtbox_temps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox_temps.Name = "txtbox_temps"
        Me.txtbox_temps.Size = New System.Drawing.Size(120, 22)
        Me.txtbox_temps.TabIndex = 4
        '
        'label_timer
        '
        Me.label_timer.AutoSize = True
        Me.label_timer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_timer.ForeColor = System.Drawing.Color.Black
        Me.label_timer.Location = New System.Drawing.Point(29, 127)
        Me.label_timer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_timer.Name = "label_timer"
        Me.label_timer.Size = New System.Drawing.Size(54, 16)
        Me.label_timer.TabIndex = 3
        Me.label_timer.Text = "Timer :"
        '
        'lblLimiteTime
        '
        Me.lblLimiteTime.AutoSize = True
        Me.lblLimiteTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimiteTime.ForeColor = System.Drawing.Color.Black
        Me.lblLimiteTime.Location = New System.Drawing.Point(4, 46)
        Me.lblLimiteTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimiteTime.Name = "lblLimiteTime"
        Me.lblLimiteTime.Size = New System.Drawing.Size(115, 16)
        Me.lblLimiteTime.TabIndex = 0
        Me.lblLimiteTime.Text = "Limite de temps"
        '
        'button_points
        '
        Me.button_points.BackColor = System.Drawing.Color.White
        Me.button_points.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_points.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!)
        Me.button_points.ForeColor = System.Drawing.Color.Black
        Me.button_points.Location = New System.Drawing.Point(284, 50)
        Me.button_points.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button_points.Name = "button_points"
        Me.button_points.Size = New System.Drawing.Size(48, 32)
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
        Me.Panel4.Location = New System.Drawing.Point(13, 211)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(354, 105)
        Me.Panel4.TabIndex = 25
        '
        'lblSauvegarde
        '
        Me.lblSauvegarde.AutoSize = True
        Me.lblSauvegarde.BackColor = System.Drawing.Color.Transparent
        Me.lblSauvegarde.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSauvegarde.ForeColor = System.Drawing.Color.Black
        Me.lblSauvegarde.Location = New System.Drawing.Point(88, 23)
        Me.lblSauvegarde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSauvegarde.Name = "lblSauvegarde"
        Me.lblSauvegarde.Size = New System.Drawing.Size(162, 16)
        Me.lblSauvegarde.TabIndex = 8
        Me.lblSauvegarde.Text = "Chemin de sauvegarde"
        '
        'cboChemin
        '
        Me.cboChemin.FormattingEnabled = True
        Me.cboChemin.Location = New System.Drawing.Point(32, 55)
        Me.cboChemin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboChemin.Name = "cboChemin"
        Me.cboChemin.Size = New System.Drawing.Size(244, 24)
        Me.cboChemin.TabIndex = 13
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PnlTemps)
        Me.Controls.Add(Me.PnlColorChoice)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.PnlColorChoice.ResumeLayout(False)
        Me.PnlColorChoice.PerformLayout()
        Me.PnlTemps.ResumeLayout(False)
        Me.PnlTemps.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtColorPrésent As TextBox
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents PnlColorChoice As Panel
    Friend WithEvents txtColorPrésentBienPla As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RBPrésentBien As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RBPrésent As RadioButton
    Friend WithEvents lblColorMaster As Label
    Friend WithEvents PnlTemps As Panel
    Friend WithEvents RBNon As RadioButton
    Friend WithEvents RBOui As RadioButton
    Friend WithEvents label_seconde As Label
    Friend WithEvents txtbox_temps As TextBox
    Friend WithEvents label_timer As Label
    Friend WithEvents lblLimiteTime As Label
    Friend WithEvents button_points As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSauvegarde As Label
    Friend WithEvents cboChemin As ComboBox
End Class
