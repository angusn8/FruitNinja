<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnDirections = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.picBomb = New System.Windows.Forms.PictureBox()
        Me.picPineapple = New System.Windows.Forms.PictureBox()
        Me.picPomegranite = New System.Windows.Forms.PictureBox()
        Me.picMelon = New System.Windows.Forms.PictureBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.timFruit = New System.Windows.Forms.Timer(Me.components)
        Me.picActive = New System.Windows.Forms.PictureBox()
        Me.lblStrikes = New System.Windows.Forms.Label()
        Me.pnlGame.SuspendLayout()
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPineapple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPomegranite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMelon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.Transparent
        Me.pnlGame.Controls.Add(Me.lblTitle)
        Me.pnlGame.Controls.Add(Me.btnExit2)
        Me.pnlGame.Controls.Add(Me.btnDirections)
        Me.pnlGame.Controls.Add(Me.btnPlay)
        Me.pnlGame.Location = New System.Drawing.Point(120, 120)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(463, 460)
        Me.pnlGame.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Viner Hand ITC", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(131, 129)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 57)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Fruit Ninja"
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.Color.White
        Me.btnExit2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit2.Location = New System.Drawing.Point(155, 262)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(180, 31)
        Me.btnExit2.TabIndex = 2
        Me.btnExit2.Text = "Exit"
        Me.btnExit2.UseVisualStyleBackColor = False
        '
        'btnDirections
        '
        Me.btnDirections.BackColor = System.Drawing.Color.White
        Me.btnDirections.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirections.Location = New System.Drawing.Point(155, 226)
        Me.btnDirections.Name = "btnDirections"
        Me.btnDirections.Size = New System.Drawing.Size(180, 31)
        Me.btnDirections.TabIndex = 1
        Me.btnDirections.Text = "Instructions"
        Me.btnDirections.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(155, 189)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(180, 31)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'picBomb
        '
        Me.picBomb.BackColor = System.Drawing.Color.Transparent
        Me.picBomb.Image = CType(resources.GetObject("picBomb.Image"), System.Drawing.Image)
        Me.picBomb.Location = New System.Drawing.Point(610, 583)
        Me.picBomb.Name = "picBomb"
        Me.picBomb.Size = New System.Drawing.Size(28, 30)
        Me.picBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBomb.TabIndex = 1
        Me.picBomb.TabStop = False
        '
        'picPineapple
        '
        Me.picPineapple.BackColor = System.Drawing.Color.Transparent
        Me.picPineapple.Image = CType(resources.GetObject("picPineapple.Image"), System.Drawing.Image)
        Me.picPineapple.Location = New System.Drawing.Point(644, 583)
        Me.picPineapple.Name = "picPineapple"
        Me.picPineapple.Size = New System.Drawing.Size(28, 30)
        Me.picPineapple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPineapple.TabIndex = 2
        Me.picPineapple.TabStop = False
        '
        'picPomegranite
        '
        Me.picPomegranite.BackColor = System.Drawing.Color.Transparent
        Me.picPomegranite.Image = CType(resources.GetObject("picPomegranite.Image"), System.Drawing.Image)
        Me.picPomegranite.Location = New System.Drawing.Point(610, 619)
        Me.picPomegranite.Name = "picPomegranite"
        Me.picPomegranite.Size = New System.Drawing.Size(28, 30)
        Me.picPomegranite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPomegranite.TabIndex = 3
        Me.picPomegranite.TabStop = False
        '
        'picMelon
        '
        Me.picMelon.BackColor = System.Drawing.Color.Transparent
        Me.picMelon.Image = CType(resources.GetObject("picMelon.Image"), System.Drawing.Image)
        Me.picMelon.Location = New System.Drawing.Point(644, 619)
        Me.picMelon.Name = "picMelon"
        Me.picMelon.Size = New System.Drawing.Size(28, 30)
        Me.picMelon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMelon.TabIndex = 4
        Me.picMelon.TabStop = False
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.White
        Me.txtScore.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(610, 147)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(57, 34)
        Me.txtScore.TabIndex = 6
        Me.txtScore.Text = "0"
        '
        'btnStartGame
        '
        Me.btnStartGame.BackColor = System.Drawing.Color.White
        Me.btnStartGame.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(595, 275)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(86, 44)
        Me.btnStartGame.TabIndex = 7
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(606, 120)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(61, 24)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(595, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 44)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'timFruit
        '
        Me.timFruit.Interval = 20
        '
        'picActive
        '
        Me.picActive.BackColor = System.Drawing.Color.Transparent
        Me.picActive.Location = New System.Drawing.Point(644, 547)
        Me.picActive.Name = "picActive"
        Me.picActive.Size = New System.Drawing.Size(28, 30)
        Me.picActive.TabIndex = 11
        Me.picActive.TabStop = False
        Me.picActive.Visible = False
        '
        'lblStrikes
        '
        Me.lblStrikes.AutoSize = True
        Me.lblStrikes.BackColor = System.Drawing.Color.Transparent
        Me.lblStrikes.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrikes.ForeColor = System.Drawing.Color.Red
        Me.lblStrikes.Location = New System.Drawing.Point(589, 196)
        Me.lblStrikes.Name = "lblStrikes"
        Me.lblStrikes.Size = New System.Drawing.Size(32, 31)
        Me.lblStrikes.TabIndex = 12
        Me.lblStrikes.Text = "X"
        Me.lblStrikes.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.lblStrikes)
        Me.Controls.Add(Me.picActive)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.picMelon)
        Me.Controls.Add(Me.picPomegranite)
        Me.Controls.Add(Me.picPineapple)
        Me.Controls.Add(Me.picBomb)
        Me.Controls.Add(Me.pnlGame)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fruit Ninja "
        Me.pnlGame.ResumeLayout(False)
        Me.pnlGame.PerformLayout()
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPineapple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPomegranite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMelon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlGame As Panel
    Friend WithEvents picBomb As PictureBox
    Friend WithEvents picPineapple As PictureBox
    Friend WithEvents picPomegranite As PictureBox
    Friend WithEvents picMelon As PictureBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents timFruit As Timer
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnDirections As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picActive As PictureBox
    Friend WithEvents lblStrikes As Label
End Class
