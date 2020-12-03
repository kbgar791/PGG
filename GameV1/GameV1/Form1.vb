Public Class PacManGunGame

    Dim r As New Random
    Dim score As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                Bullet.Location = PictureBox2.Location
                Bullet.Visible = True
                If TextBox1.Text = "r" Then
                    Timer3.Stop()
                    Timer2.Start()
                    Timer7.Stop()
                    Timer8.Stop()
                ElseIf TextBox1.Text = "l" Then
                    Timer2.Stop()
                    Timer3.Start()
                    Timer7.Stop()
                    Timer8.Stop()
                ElseIf TextBox1.Text = "u" Then
                    Timer2.Stop()
                    Timer8.Stop()
                    Timer3.Stop()
                    Timer7.Start()
                ElseIf TextBox1.Text = "d" Then
                    Timer2.Stop()
                    Timer8.Start()
                    Timer3.Stop()
                    Timer7.Stop()
                End If
            Case Keys.W
                MoveTo(PictureBox2, 0, -10)
                TextBox1.Text = "u"
                PictureBox2.Image = GameV1.My.Resources.Resources.unnamed__2_2
            Case Keys.S
                MoveTo(PictureBox2, 0, 10)
                TextBox1.Text = "d"
                PictureBox2.Image = GameV1.My.Resources.Resources.unnamed__2uj_
            Case Keys.A
                MoveTo(PictureBox2, -10, 0)
                PictureBox2.Image = GameV1.My.Resources.Resources.unnamed_3_
                TextBox1.Text = "l"
            Case Keys.D
                MoveTo(PictureBox2, 10, 0)
                PictureBox2.Image = GameV1.My.Resources.Resources.unnamed__2_
                TextBox1.Text = "r"
            Case Keys.B
                Grenade.Visible = True
                Grenade.Location = PictureBox2.Location
                Boom.Location = Grenade.Location
                Timer4.Start()
            Case Keys.Enter
                PGGMenu1.Visible = False
                Timer1.Enabled = False
                WALLCEILINGWALL.Visible = True
                oga1.Visible = True
            Case Keys.Q
                oga1.Visible = False
                Timer1.Enabled = True
        End Select
    End Sub

    Sub Randmove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-10, 11)
        y = r.Next(-10, 11)
        MoveTo(p, x, y)
    End Sub
    Private Sub Time1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        chase(Ghost2)
        chase(Ghost1)
        chase(Ghost3)
        chase(Ghost4)
        chase(Ghost5)
        chase(Ghost6)
        Scorebox.Text = score
        If score >= 15 Then
            Blinky.Visible = True
            Move(WALLCEILINGWALL, 8000, 8000)
            Blinky.Enabled = True
            chase(Blinky)
            ProgressBar1.Visible = True
        End If
    End Sub


    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub

    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox2.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox2.Location.X Then
            x = -3
        Else
            x = 3
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox2.Location.Y Then
            y = 3
        Else
            y = -3
        End If
        MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"++
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox2" And Collision(p, "WIN") Then
            Me.BackColor = Color.Green
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost1") Then
            Ghost1.Visible = False
            MoveTo(Ghost1, 1000, 0)
            Ghost1.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost2") Then
            Ghost2.Visible = False
            MoveTo(Ghost2, -1000, -370)
            Ghost2.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost3") Then
            Ghost3.Visible = False
            MoveTo(Ghost3, 1050, 520)
            Ghost3.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost4") Then
            Ghost4.Visible = False
            MoveTo(Ghost4, 900, 110)
            Ghost4.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost5") Then
            Ghost5.Visible = False
            MoveTo(Ghost5, -1037, 50)
            Ghost5.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Ghost6") Then
            Ghost6.Visible = False
            MoveTo(Ghost6, -800, -100)
            Ghost6.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Bullet" And Collision(p, "Blinky") Then
            ProgressBar1.Value -= 20
            MoveTo(Bullet, 0, -100000)
        End If

        If ProgressBar1.Value = 0 Then
            Move(Blinky, 10000000, 2000000)
            Blinky.Enabled = False
            Blinky.Visible = False
            TextBox2.Visible = True
        End If


        If p.Name = "PictureBox2" And Collision(p, "Ghost2") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Ghost1") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Ghost3") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Ghost4") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Ghost5") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Ghost6") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "PictureBox2" And Collision(p, "Blinky") Then
            PictureBox2.Visible = False
            GameOver.Visible = True
        End If

        If p.Name = "Boom" And Collision(p, "Ghost1") Then
            Ghost1.Visible = False
            MoveTo(Ghost1, 1000, 0)
            Ghost1.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Boom" And Collision(p, "Ghost5") Then
            Ghost5.Visible = False
            MoveTo(Ghost5, 1000, 0)
            Ghost5.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Boom" And Collision(p, "Ghost6") Then
            Ghost5.Visible = False
            MoveTo(Ghost6, 1000, 0)
            Ghost5.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Boom" And Collision(p, "Blinky") Then
            ProgressBar1.Value -= 40
        End If

        If p.Name = "Boom" And Collision(p, "Ghost2") Then
            Ghost2.Visible = False
            MoveTo(Ghost2, -1000, -50)
            Ghost2.Visible = True
            score += 1
            Return
        End If



        If p.Name = "Boom" And Collision(p, "Ghost3") Then
            Ghost3.Visible = False
            MoveTo(Ghost2, -1000, -50)
            Ghost3.Visible = True
            score += 1
            Return
        End If

        If p.Name = "Boom" And Collision(p, "Ghost4") Then
            Ghost4.Visible = False
            MoveTo(Ghost2, -1000, -50)
            Ghost4.Visible = True
            score += 1
            Return
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(Bullet, 20, 0)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MoveTo(Bullet, -20, 0)
    End Sub
    Dim Count As Integer
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Count = Count + 1
        If Count > 35 Then
            Boom.Enabled = True
            Boom.Visible = True
            Grenade.Visible = False
            Timer5.Start()
        End If
        If Count > 45 Then
            Boom.Enabled = False
            Boom.Visible = False
            Grenade.Enabled = False
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Start()
        End If
        If Count > 46 Then
            Timer6.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        MoveTo(Boom, 1, 0)
        MoveTo(Boom, -1, 0)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        MoveTo(Boom, 0, -100000)
    End Sub

    Private Sub Boom_Click(sender As Object, e As EventArgs) Handles Boom.Click

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        MoveTo(Bullet, 0, -20)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        MoveTo(Bullet, 0, 20)
    End Sub

    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub
End Class