<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combin
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblCaractères = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.btnCacher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(324, 37)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(113, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Master Mind"
        '
        'lblCaractères
        '
        Me.lblCaractères.AutoSize = True
        Me.lblCaractères.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaractères.Location = New System.Drawing.Point(594, 170)
        Me.lblCaractères.Name = "lblCaractères"
        Me.lblCaractères.Size = New System.Drawing.Size(178, 20)
        Me.lblCaractères.TabIndex = 1
        Me.lblCaractères.Text = "Caractères jouables"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(160, 104)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(78, 22)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(244, 104)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(78, 22)
        Me.txt2.TabIndex = 7
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(328, 104)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(78, 22)
        Me.txt3.TabIndex = 8
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(412, 104)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(78, 22)
        Me.txt4.TabIndex = 9
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(496, 104)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(78, 22)
        Me.txt5.TabIndex = 10
        '
        'btnCacher
        '
        Me.btnCacher.Location = New System.Drawing.Point(680, 102)
        Me.btnCacher.Name = "btnCacher"
        Me.btnCacher.Size = New System.Drawing.Size(75, 23)
        Me.btnCacher.TabIndex = 11
        Me.btnCacher.Text = "Hide"
        Me.btnCacher.UseVisualStyleBackColor = True
        '
        'combin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 242)
        Me.Controls.Add(Me.btnCacher)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblCaractères)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "combin"
        Me.Text = "Pattern à deviner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblCaractères As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents btnCacher As Button
End Class
