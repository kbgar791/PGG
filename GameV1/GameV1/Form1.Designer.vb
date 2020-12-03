<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PacManGunGame
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
        Me.Ghost1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Ghost2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.GameOver = New System.Windows.Forms.TextBox()
        Me.Grenade = New System.Windows.Forms.PictureBox()
        Me.Boom = New System.Windows.Forms.PictureBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Ghost4 = New System.Windows.Forms.PictureBox()
        Me.Ghost3 = New System.Windows.Forms.PictureBox()
        Me.Blinky = New System.Windows.Forms.PictureBox()
        Me.Scorebox = New System.Windows.Forms.TextBox()
        Me.WALL1WALL = New System.Windows.Forms.PictureBox()
        Me.WALL4WALL = New System.Windows.Forms.PictureBox()
        Me.WALL3WALL = New System.Windows.Forms.PictureBox()
        Me.WALL2WALL = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.WALL5WALL = New System.Windows.Forms.PictureBox()
        Me.Ghost5 = New System.Windows.Forms.PictureBox()
        Me.Ghost6 = New System.Windows.Forms.PictureBox()
        Me.PGGMenu1 = New System.Windows.Forms.PictureBox()
        Me.WALLCEILINGWALL = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.oga1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grenade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL1WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL4WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL3WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL2WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALL5WALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PGGMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WALLCEILINGWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oga1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ghost1
        '
        Me.Ghost1.BackColor = System.Drawing.Color.Transparent
        Me.Ghost1.Image = Global.GameV1.My.Resources.Resources._2469743_orange
        Me.Ghost1.Location = New System.Drawing.Point(823, 116)
        Me.Ghost1.Name = "Ghost1"
        Me.Ghost1.Size = New System.Drawing.Size(52, 48)
        Me.Ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost1.TabIndex = 2
        Me.Ghost1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.GameV1.My.Resources.Resources.unnamed__2_
        Me.PictureBox2.InitialImage = Global.GameV1.My.Resources.Resources.unnamed__2_
        Me.PictureBox2.Location = New System.Drawing.Point(651, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Ghost2
        '
        Me.Ghost2.BackColor = System.Drawing.Color.Transparent
        Me.Ghost2.Image = Global.GameV1.My.Resources.Resources.unnamed
        Me.Ghost2.Location = New System.Drawing.Point(-4, 104)
        Me.Ghost2.Name = "Ghost2"
        Me.Ghost2.Size = New System.Drawing.Size(53, 48)
        Me.Ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost2.TabIndex = 0
        Me.Ghost2.TabStop = False
        '
        'Timer1
        '
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.BackgroundImage = Global.GameV1.My.Resources.Resources.yjjhj_removebg_preview
        Me.Bullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bullet.Location = New System.Drawing.Point(340, 104)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(17, 19)
        Me.Bullet.TabIndex = 51
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'GameOver
        '
        Me.GameOver.BackColor = System.Drawing.Color.Maroon
        Me.GameOver.Enabled = False
        Me.GameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOver.Location = New System.Drawing.Point(243, 382)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(409, 80)
        Me.GameOver.TabIndex = 53
        Me.GameOver.Text = "GAME OVER"
        Me.GameOver.Visible = False
        '
        'Grenade
        '
        Me.Grenade.BackColor = System.Drawing.Color.Transparent
        Me.Grenade.Image = Global.GameV1.My.Resources.Resources.unnamed__3_
        Me.Grenade.Location = New System.Drawing.Point(582, 242)
        Me.Grenade.Name = "Grenade"
        Me.Grenade.Size = New System.Drawing.Size(36, 38)
        Me.Grenade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Grenade.TabIndex = 55
        Me.Grenade.TabStop = False
        Me.Grenade.Visible = False
        '
        'Boom
        '
        Me.Boom.BackColor = System.Drawing.Color.Transparent
        Me.Boom.Enabled = False
        Me.Boom.Image = Global.GameV1.My.Resources.Resources.c2e5b72c0138a2e0230e5fcb694d5d59
        Me.Boom.Location = New System.Drawing.Point(145, 342)
        Me.Boom.Name = "Boom"
        Me.Boom.Size = New System.Drawing.Size(543, 563)
        Me.Boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Boom.TabIndex = 56
        Me.Boom.TabStop = False
        Me.Boom.Visible = False
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Timer6
        '
        '
        'Ghost4
        '
        Me.Ghost4.BackColor = System.Drawing.Color.Transparent
        Me.Ghost4.Image = Global.GameV1.My.Resources.Resources._2469743_orange
        Me.Ghost4.Location = New System.Drawing.Point(823, 304)
        Me.Ghost4.Name = "Ghost4"
        Me.Ghost4.Size = New System.Drawing.Size(52, 48)
        Me.Ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost4.TabIndex = 57
        Me.Ghost4.TabStop = False
        '
        'Ghost3
        '
        Me.Ghost3.BackColor = System.Drawing.Color.Transparent
        Me.Ghost3.Image = Global.GameV1.My.Resources.Resources.unnamed
        Me.Ghost3.Location = New System.Drawing.Point(-4, 304)
        Me.Ghost3.Name = "Ghost3"
        Me.Ghost3.Size = New System.Drawing.Size(53, 48)
        Me.Ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost3.TabIndex = 58
        Me.Ghost3.TabStop = False
        '
        'Blinky
        '
        Me.Blinky.BackColor = System.Drawing.Color.Transparent
        Me.Blinky.Enabled = False
        Me.Blinky.Image = Global.GameV1.My.Resources.Resources.unnamed__1_
        Me.Blinky.Location = New System.Drawing.Point(368, -60)
        Me.Blinky.Name = "Blinky"
        Me.Blinky.Size = New System.Drawing.Size(100, 93)
        Me.Blinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Blinky.TabIndex = 59
        Me.Blinky.TabStop = False
        Me.Blinky.Visible = False
        '
        'Scorebox
        '
        Me.Scorebox.Enabled = False
        Me.Scorebox.Location = New System.Drawing.Point(12, 546)
        Me.Scorebox.Name = "Scorebox"
        Me.Scorebox.ReadOnly = True
        Me.Scorebox.Size = New System.Drawing.Size(100, 20)
        Me.Scorebox.TabIndex = 60
        Me.Scorebox.Visible = False
        '
        'WALL1WALL
        '
        Me.WALL1WALL.Location = New System.Drawing.Point(162, 58)
        Me.WALL1WALL.Name = "WALL1WALL"
        Me.WALL1WALL.Size = New System.Drawing.Size(81, 65)
        Me.WALL1WALL.TabIndex = 61
        Me.WALL1WALL.TabStop = False
        '
        'WALL4WALL
        '
        Me.WALL4WALL.Location = New System.Drawing.Point(162, 382)
        Me.WALL4WALL.Name = "WALL4WALL"
        Me.WALL4WALL.Size = New System.Drawing.Size(81, 71)
        Me.WALL4WALL.TabIndex = 62
        Me.WALL4WALL.TabStop = False
        '
        'WALL3WALL
        '
        Me.WALL3WALL.Location = New System.Drawing.Point(705, 382)
        Me.WALL3WALL.Name = "WALL3WALL"
        Me.WALL3WALL.Size = New System.Drawing.Size(81, 71)
        Me.WALL3WALL.TabIndex = 63
        Me.WALL3WALL.TabStop = False
        '
        'WALL2WALL
        '
        Me.WALL2WALL.Location = New System.Drawing.Point(705, 58)
        Me.WALL2WALL.Name = "WALL2WALL"
        Me.WALL2WALL.Size = New System.Drawing.Size(81, 65)
        Me.WALL2WALL.TabIndex = 64
        Me.WALL2WALL.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(705, 546)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Maroon
        Me.ProgressBar1.Location = New System.Drawing.Point(314, 546)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(217, 23)
        Me.ProgressBar1.TabIndex = 65
        Me.ProgressBar1.Value = 100
        Me.ProgressBar1.Visible = False
        '
        'Timer7
        '
        '
        'Timer8
        '
        '
        'WALL5WALL
        '
        Me.WALL5WALL.Location = New System.Drawing.Point(450, 209)
        Me.WALL5WALL.Name = "WALL5WALL"
        Me.WALL5WALL.Size = New System.Drawing.Size(81, 71)
        Me.WALL5WALL.TabIndex = 66
        Me.WALL5WALL.TabStop = False
        '
        'Ghost5
        '
        Me.Ghost5.BackColor = System.Drawing.Color.Transparent
        Me.Ghost5.Image = Global.GameV1.My.Resources.Resources.unnamed
        Me.Ghost5.Location = New System.Drawing.Point(-4, 209)
        Me.Ghost5.Name = "Ghost5"
        Me.Ghost5.Size = New System.Drawing.Size(53, 48)
        Me.Ghost5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost5.TabIndex = 67
        Me.Ghost5.TabStop = False
        '
        'Ghost6
        '
        Me.Ghost6.BackColor = System.Drawing.Color.Transparent
        Me.Ghost6.Image = Global.GameV1.My.Resources.Resources._2469743_orange
        Me.Ghost6.Location = New System.Drawing.Point(823, 209)
        Me.Ghost6.Name = "Ghost6"
        Me.Ghost6.Size = New System.Drawing.Size(52, 48)
        Me.Ghost6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost6.TabIndex = 68
        Me.Ghost6.TabStop = False
        '
        'PGGMenu1
        '
        Me.PGGMenu1.BackgroundImage = Global.GameV1.My.Resources.Resources.PGGMenu
        Me.PGGMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PGGMenu1.Location = New System.Drawing.Point(2, 0)
        Me.PGGMenu1.Name = "PGGMenu1"
        Me.PGGMenu1.Size = New System.Drawing.Size(873, 569)
        Me.PGGMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PGGMenu1.TabIndex = 69
        Me.PGGMenu1.TabStop = False
        '
        'WALLCEILINGWALL
        '
        Me.WALLCEILINGWALL.Location = New System.Drawing.Point(0, 31)
        Me.WALLCEILINGWALL.Name = "WALLCEILINGWALL"
        Me.WALLCEILINGWALL.Size = New System.Drawing.Size(899, 27)
        Me.WALLCEILINGWALL.TabIndex = 70
        Me.WALLCEILINGWALL.TabStop = False
        Me.WALLCEILINGWALL.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(-4, 263)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(875, 63)
        Me.TextBox2.TabIndex = 71
        Me.TextBox2.Text = "YOU WIN, GOOD JOB, VERY IMPRESSIVE"
        Me.TextBox2.Visible = False
        '
        'oga1
        '
        Me.oga1.BackgroundImage = Global.GameV1.My.Resources.Resources.inst1
        Me.oga1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.oga1.Location = New System.Drawing.Point(3, 0)
        Me.oga1.Name = "oga1"
        Me.oga1.Size = New System.Drawing.Size(872, 571)
        Me.oga1.TabIndex = 72
        Me.oga1.TabStop = False
        Me.oga1.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(798, 279)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Enabled = False
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Enabled = False
        Me.SplitContainer1.Size = New System.Drawing.Size(54, 8)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 73
        '
        'PacManGunGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources.sand_texture_background_top_view_260nw_399049936
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(874, 578)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.oga1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.WALLCEILINGWALL)
        Me.Controls.Add(Me.PGGMenu1)
        Me.Controls.Add(Me.Ghost6)
        Me.Controls.Add(Me.Ghost5)
        Me.Controls.Add(Me.WALL5WALL)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.WALL2WALL)
        Me.Controls.Add(Me.WALL3WALL)
        Me.Controls.Add(Me.WALL4WALL)
        Me.Controls.Add(Me.WALL1WALL)
        Me.Controls.Add(Me.Scorebox)
        Me.Controls.Add(Me.Blinky)
        Me.Controls.Add(Me.Ghost3)
        Me.Controls.Add(Me.Ghost4)
        Me.Controls.Add(Me.Boom)
        Me.Controls.Add(Me.Grenade)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GameOver)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Ghost1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Ghost2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "PacManGunGame"
        Me.Text = "Form1"
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grenade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL1WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL4WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL3WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL2WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALL5WALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PGGMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WALLCEILINGWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oga1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ghost2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Ghost1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents GameOver As TextBox
    Friend WithEvents Grenade As PictureBox
    Friend WithEvents Boom As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Ghost4 As PictureBox
    Friend WithEvents Ghost3 As PictureBox
    Friend WithEvents Blinky As PictureBox
    Friend WithEvents Scorebox As TextBox
    Friend WithEvents WALL1WALL As PictureBox
    Friend WithEvents WALL4WALL As PictureBox
    Friend WithEvents WALL3WALL As PictureBox
    Friend WithEvents WALL2WALL As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents WALL5WALL As PictureBox
    Friend WithEvents Ghost5 As PictureBox
    Friend WithEvents Ghost6 As PictureBox
    Friend WithEvents PGGMenu1 As PictureBox
    Friend WithEvents WALLCEILINGWALL As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents oga1 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
