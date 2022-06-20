<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxDifficult = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.LblTry = New System.Windows.Forms.Label()
        Me.LblSteps = New System.Windows.Forms.Label()
        Me.LblResultat = New System.Windows.Forms.Label()
        Me.TxbResultat = New System.Windows.Forms.TextBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.PbCountDown = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisissez la difficulté:"
        '
        'CbxDifficult
        '
        Me.CbxDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxDifficult.FormattingEnabled = True
        Me.CbxDifficult.Items.AddRange(New Object() {"Facile", "Moyen", "Difficile", "Expert"})
        Me.CbxDifficult.Location = New System.Drawing.Point(183, 12)
        Me.CbxDifficult.Name = "CbxDifficult"
        Me.CbxDifficult.Size = New System.Drawing.Size(121, 29)
        Me.CbxDifficult.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 105)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(12, 78)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(101, 39)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Jouer"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Enabled = False
        Me.BtnStop.Location = New System.Drawing.Point(183, 78)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(101, 39)
        Me.BtnStop.TabIndex = 4
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'LblScore
        '
        Me.LblScore.ForeColor = System.Drawing.Color.Blue
        Me.LblScore.Location = New System.Drawing.Point(12, 246)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(133, 24)
        Me.LblScore.TabIndex = 5
        Me.LblScore.Text = "Score: 0"
        '
        'LblTry
        '
        Me.LblTry.ForeColor = System.Drawing.Color.Blue
        Me.LblTry.Location = New System.Drawing.Point(183, 246)
        Me.LblTry.Name = "LblTry"
        Me.LblTry.Size = New System.Drawing.Size(212, 24)
        Me.LblTry.TabIndex = 6
        Me.LblTry.Text = "Nombre d'essais: 0 sur 0"
        '
        'LblSteps
        '
        Me.LblSteps.ForeColor = System.Drawing.Color.Blue
        Me.LblSteps.Location = New System.Drawing.Point(401, 246)
        Me.LblSteps.Name = "LblSteps"
        Me.LblSteps.Size = New System.Drawing.Size(212, 24)
        Me.LblSteps.TabIndex = 7
        Me.LblSteps.Text = "Etapes: 0 sur 10"
        '
        'LblResultat
        '
        Me.LblResultat.ForeColor = System.Drawing.Color.Green
        Me.LblResultat.Location = New System.Drawing.Point(60, 294)
        Me.LblResultat.Name = "LblResultat"
        Me.LblResultat.Size = New System.Drawing.Size(345, 26)
        Me.LblResultat.TabIndex = 8
        Me.LblResultat.Text = "En attente d'une nouvelle partie"
        '
        'TxbResultat
        '
        Me.TxbResultat.Location = New System.Drawing.Point(60, 339)
        Me.TxbResultat.Name = "TxbResultat"
        Me.TxbResultat.Size = New System.Drawing.Size(100, 29)
        Me.TxbResultat.TabIndex = 9
        Me.TxbResultat.Text = "0"
        Me.TxbResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxbResultat.WordWrap = False
        '
        'BtnOK
        '
        Me.BtnOK.Enabled = False
        Me.BtnOK.Location = New System.Drawing.Point(183, 339)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 34)
        Me.BtnOK.TabIndex = 10
        Me.BtnOK.Text = "Ok"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'PbCountDown
        '
        Me.PbCountDown.ForeColor = System.Drawing.Color.Lime
        Me.PbCountDown.Location = New System.Drawing.Point(12, 399)
        Me.PbCountDown.Maximum = 30
        Me.PbCountDown.Name = "PbCountDown"
        Me.PbCountDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PbCountDown.Size = New System.Drawing.Size(739, 23)
        Me.PbCountDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbCountDown.TabIndex = 11
        Me.PbCountDown.Tag = ""
        Me.PbCountDown.Value = 30
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 434)
        Me.Controls.Add(Me.PbCountDown)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxbResultat)
        Me.Controls.Add(Me.LblResultat)
        Me.Controls.Add(Me.LblSteps)
        Me.Controls.Add(Me.LblTry)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxDifficult)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devine le nombre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbxDifficult As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents LblScore As Label
    Friend WithEvents LblTry As Label
    Friend WithEvents LblSteps As Label
    Friend WithEvents LblResultat As Label
    Friend WithEvents TxbResultat As TextBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents PbCountDown As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
