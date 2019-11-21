Public Class Form1

    Dim MyGraphics As Graphics
    Dim Score As Integer
    Dim FruitSize As Integer
    Dim MyRandom As New Random
    Dim FruitChoice As Integer
    Dim FruitX As Integer
    Dim FruitY As Integer
    Dim BlankBrush As Brush
    Dim fruitspeed As Integer
    Dim fruitspeedY As Integer
    Dim slice As Boolean
    Dim FormWidth As Integer
    Dim FormHeight As Integer



    Private Sub btnDirections_Click(sender As Object, e As EventArgs) Handles btnDirections.Click

        'Message box with directions 
        MessageBox.Show("Click start game button on main screen to begin. Click the fruit as it appears on your screen. If you miss 3 fruits or click the bomb, the game is over. You can then click start game again to begin a new game.")

    End Sub

    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click

        'Close form 
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form 
        Me.Close()

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        'Enable Controls and disable main menu 
        pnlGame.Enabled = True
        lblScore.Enabled = True
        txtScore.Enabled = True
        btnStartGame.Enabled = True
        btnExit.Enabled = True
        picBomb.Enabled = True
        picPineapple.Enabled = True
        picPomegranite.Enabled = True
        picMelon.Enabled = True
        lblTitle.Enabled = False
        btnPlay.Enabled = False
        btnDirections.Enabled = False
        btnExit2.Enabled = False

        'Make controls visible and make main menu invisible
        pnlGame.Visible = True
        lblScore.Visible = True
        txtScore.Visible = True
        btnStartGame.Visible = True
        btnExit.Visible = True
        lblTitle.Visible = False
        btnPlay.Visible = False
        btnDirections.Visible = False
        btnExit2.Visible = False

    End Sub

    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click

        'turn timer on/off
        timFruit.Enabled = Not (timFruit.Enabled)
        fruitspeedY = -10
        'Start a new game 
        If btnStartGame.Text = "Start Game" Then
            MyGraphics.Clear(pnlGame.BackColor)
            btnStartGame.Text = "Stop"
            Score = 0
            txtScore.Text = Score
            'Randomly Choose 
            FruitX = MyRandom.Next(463) + 1
            FruitY = pnlGame.Height - 10
            'Randomly select a fruit to be displayed 
            FruitChoice = MyRandom.Next(4) + 1
        Else
            btnStartGame.Text = "Start Game"
        End If
        lblStrikes.Text = ""
        lblStrikes.Visible = False

        slice = False

        pnlGame.BackColor = Color.PowderBlue

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Disable controls on load 
        lblScore.Enabled = False
        txtScore.Enabled = False
        btnStartGame.Enabled = False
        btnExit.Enabled = False
        picBomb.Enabled = False
        picPineapple.Enabled = False
        picPomegranite.Enabled = False
        picMelon.Enabled = False
        lblTitle.Enabled = True
        btnPlay.Visible = True
        btnDirections.Enabled = True
        btnExit2.Enabled = True

        'Make controls invisible on load
        lblScore.Visible = False
        txtScore.Visible = False
        btnStartGame.Visible = False
        btnExit.Visible = False
        picBomb.Visible = False
        picPineapple.Visible = False
        picPomegranite.Visible = False
        picMelon.Visible = False
        lblTitle.Visible = True
        btnPlay.Visible = True
        btnDirections.Visible = True
        btnExit2.Visible = True



        'Declare Fruit Size 
        FruitSize = 40

        'Create Brush and graphics
        BlankBrush = New SolidBrush(Color.PowderBlue)
        MyGraphics = pnlGame.CreateGraphics

        'Resize form to appropriate aspect ratio for screen
        ' FormWidth = Screen.PrimaryScreen.Bounds.Width * 0.75
        'FormHeight = Screen.PrimaryScreen.Bounds.Height * 0.75
        'Me.Width = FormWidth
        'Me.Height = FormHeight


    End Sub

    Private Sub timFruit_Tick(sender As Object, e As EventArgs) Handles timFruit.Tick

        If slice = True Then
            FruitX = MyRandom.Next(463) + 1
            FruitY = pnlGame.Height - 10
            fruitspeedY = -10
            'Randomly select a fruit to be displayed 
            FruitChoice = MyRandom.Next(4) + 1
            slice = False
        Else

            'Display fruit based on selection
            If FruitChoice = 1 Then
                picActive.Image = picPineapple.Image
            ElseIf FruitChoice = 2 Then
                picActive.Image = picPomegranite.Image
            ElseIf FruitChoice = 3 Then
                picActive.Image = picMelon.Image
            ElseIf FruitChoice = 4 Then
                picActive.Image = picBomb.Image
            End If

            'Draw 
            MyGraphics.DrawImage(picActive.Image, FruitX, FruitY, FruitSize, FruitSize)


            'Erase 
            MyGraphics.FillRectangle(BlankBrush, FruitX, FruitY, FruitSize, FruitSize)

            'Move 
            If FruitX < (Int(pnlGame.Width / 2)) And FruitY = pnlGame.Height Then
                'make fruit move right
                fruitspeed = MyRandom.Next(8) + 1
            ElseIf FruitX >= (Int(pnlGame.Width / 2)) And FruitY = pnlGame.Height Then
                'make fruit move left
                fruitspeed = -(MyRandom.Next(8) + 1)
            End If
            FruitX = FruitX + fruitspeed
            FruitY = FruitY + fruitspeedY

            'change direction when fruit gets high enough 
            If FruitY <= 120 Then
                fruitspeedY = 10

            End If
            'check for hitting right panel
            If FruitX + 40 > pnlGame.Width Then
                fruitspeed = -fruitspeed
            End If
            'check for hitting left panel
            If FruitX < 0 Then
                fruitspeed = -fruitspeed
            End If
            'Draw 
            MyGraphics.DrawImage(picActive.Image, FruitX, FruitY, FruitSize, FruitSize)

            'Add strikes if fruit is missed 
            If FruitY > pnlGame.Height And FruitChoice <> 4 And lblStrikes.Text = "" Then
                lblStrikes.Text = "X"
                lblStrikes.Visible = True
                slice = True
            ElseIf FruitY > pnlGame.Height And lblStrikes.Text = "X" And FruitChoice <> 4 Then
                lblStrikes.Text = "X X"
                slice = True
            ElseIf FruitY > pnlGame.Height And lblStrikes.Text = "X X" And FruitChoice <> 4 Then
                lblStrikes.Text = "X X X"
                slice = True
            End If
            'redraw fruit if bomb is passed on
            If FruitChoice = 4 And FruitY > pnlGame.Height Then
                slice = True
            End If
            'When three strikes, game over 
            If lblStrikes.Text = "X X X" Then
                timFruit.Enabled = False
                MessageBox.Show("Game over, click start game to begin again.")
                btnStartGame.Text = "Start Game"
                Score = 0
                txtScore.Text = Score
                lblStrikes.Text = ""
                lblStrikes.Visible = False
            End If
        End If

    End Sub

    Private Sub pnlGame_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlGame.MouseDown

        'If fruit is clicked succesfully
        If e.X > FruitX And e.Y > FruitY And e.X < (FruitX + 40) And e.Y < (FruitY + 40) Then
            Score = Score + 1
            txtScore.Text = Score
            slice = True
            MyGraphics.Clear(pnlGame.BackColor)

        End If

        If FruitChoice = 4 And e.X > FruitX And e.Y > FruitY And e.X < FruitX + 40 And e.Y < FruitY + 40 Then
            timFruit.Enabled = Not (timFruit.Enabled)
            btnStartGame.Text = "Start Game"
            Score = 0
            txtScore.Text = Score
            lblStrikes.Text = ""
            lblStrikes.Visible = False
            MessageBox.Show("Game over, click start game to begin again.")
        End If

    End Sub


End Class

