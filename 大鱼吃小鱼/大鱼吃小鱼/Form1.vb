Public Class Form1
    Dim x As Single
    Dim y As Integer
    Dim i As Integer
    Dim a(4) As Integer
    Dim b(99) As Integer
    Dim z As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x - 0.1
        TextBox1.Text = Fix(x)
        If x <= 0 Then
            Timer1.Enabled = False
            MsgBox("游戏结束")
        End If
        Pic1.Left = Pic1.Left - (10 - 2 * a(0))
        If Pic1.Left <= 0 Then
            Pic1.Left = 500
        End If
        Pic2.Left = Pic2.Left + (10 - 2 * a(1))
        If Pic2.Left >= 500 Then
            Pic2.Left = -Pic2.Width
        End If
        Pic3.Left = Pic3.Left - (10 - 2 * a(2))
        If Pic3.Left <= 0 Then
            Pic3.Left = 500
        End If
        Pic4.Left = Pic4.Left + (10 - 2 * a(3))
        If Pic4.Left >= 500 Then
            Pic4.Left = -Pic4.Width
        End If
        Pic5.Left = Pic5.Left - (10 - 2 * a(4))
        If Pic5.Left <= 0 Then
            Pic5.Left = 500
        End If

    End Sub
    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = 37 Then
            PictureBox1.Left = PictureBox1.Left - 4
        End If
        If e.KeyCode = 39 Then
            PictureBox1.Left = PictureBox1.Left + 4
        End If
        If e.KeyCode = 38 Then
            PictureBox1.Top = PictureBox1.Top - 4
        End If
        If e.KeyCode = 40 Then
            PictureBox1.Top = PictureBox1.Top + 4
        End If
        If e.KeyCode = 32 Then
            Timer1.Enabled = False
            If (PictureBox1.Left <= Pic1.Left + PictureBox1.Width) And (PictureBox1.Left >= Pic1.Left - PictureBox1.Width) And (PictureBox1.Top <= Pic1.Top + Pic1.Height) And (PictureBox1.Top >= Pic1.Top - PictureBox1.Height) Then
                If y = 0 Then
                    y += 1
                    Pic1.Hide()
                    PictureBox1.Size = New Size(15 + 15 * y, 15 + 15 * y)
                    Timer1.Enabled = True
                End If
                If y < 0 Then
                    Timer1.Enabled = False
                    MsgBox("游戏结束")
                End If
            End If
            If (PictureBox1.Left <= Pic2.Left + Pic2.Width) And (PictureBox1.Left >= Pic2.Left - PictureBox1.Width) And (PictureBox1.Top <= Pic2.Top + Pic2.Height) And (PictureBox1.Top >= Pic2.Top - PictureBox1.Height) Then
                If y = 1 Then
                    y += 1
                    Pic2.Hide()
                    PictureBox1.Size = New Size(15 + 15 * y, 15 + 15 * y)
                    Timer1.Enabled = True
                End If
                If y < 1 Then
                    Timer1.Enabled = False
                    MsgBox("游戏结束")
                End If
            End If
            If (PictureBox1.Left <= Pic3.Left + Pic3.Width) And (PictureBox1.Left >= Pic3.Left - PictureBox1.Width) And (PictureBox1.Top <= Pic3.Top + Pic3.Height) And (PictureBox1.Top >= Pic3.Top - PictureBox1.Height) Then
                If y = 2 Then
                    y += 1
                    Pic3.Hide()
                    PictureBox1.Size = New Size(15 + 15 * y, 15 + 15 * y)
                    Timer1.Enabled = True
                End If
                If y < 2 Then
                    Timer1.Enabled = False
                    MsgBox("游戏结束")
                End If
            End If
            If (PictureBox1.Left <= Pic4.Left + Pic4.Width) And (PictureBox1.Left >= Pic4.Left - PictureBox1.Width) And (PictureBox1.Top <= Pic4.Top + Pic4.Height) And (PictureBox1.Top >= Pic4.Top - PictureBox1.Height) Then
                If y = 3 Then
                    y += 1
                    Pic4.Hide()
                    PictureBox1.Size = New Size(15 + 15 * y, 15 + 15 * y)
                    Timer1.Enabled = True
                End If
                If y < 3 Then
                    Timer1.Enabled = False
                    MsgBox("游戏结束")
                End If
            End If
            Timer1.Enabled = True
            If (PictureBox1.Left <= Pic4.Left + 100) And (PictureBox1.Left >= Pic5.Left - 100) And (PictureBox1.Top <= Pic5.Top + 100) And (PictureBox1.Top >= Pic5.Top - 100) Then
                If y = 4 Then
                    y += 1
                    Pic5.Hide()
                    PictureBox1.Size = New Size(15 + 15 * y, 15 + 15 * y)
                    MsgBox("你赢了！")
                    Timer1.Enabled = False
                    z += 1
                    b(z - 1) = x
                    TextBox1.Text = ""

                End If
                If y < 4 Then
                    Timer1.Enabled = False
                    MsgBox("游戏结束")
                End If
            End If
            Array.Sort(b)
            Array.Reverse(b)
            TextBox2.Text = ""
            For i = 0 To z - 1
                TextBox2.Text = TextBox2.Text & i + 1 & "、" & b(i) & "s" & vbCrLf
            Next
        End If
    End Sub

    Private Sub 游戏开始_Click(sender As Object, e As EventArgs) Handles 游戏开始.Click
        TextBox3.Focus()
        Pic1.Size = New Size(10, 10)
        Pic2.Size = New Size(25, 25)
        Pic3.Size = New Size(40, 40)
        Pic4.Size = New Size(55, 55)
        Pic5.Size = New Size(70, 70)
        x = 60
        y = 0
        TextBox1.Text = x
        Timer1.Enabled = True
        a(0) = Fix(5 * Rnd())
        Do Until a(1) <> a(0)
            a(1) = Fix(5 * Rnd())
        Loop
        Do Until a(2) <> a(1) And a(2) <> a(0)
            a(2) = Fix(5 * Rnd())
        Loop
        Do Until a(3) <> a(0) And a(3) <> a(1) And a(3) <> a(2)
            a(3) = Fix(5 * Rnd())
        Loop
        Do Until a(4) <> a(0) And a(4) <> a(1) And a(4) <> a(2) And a(4) <> a(3)
            a(4) = Fix(5 * Rnd())
        Loop
        Pic1.Location = New Point(Fix(500 * Rnd()), Fix(100 * Rnd() + a(0) * 100))
        Pic2.Location = New Point(Fix(500 * Rnd()), Fix(100 * Rnd() + a(1) * 100))
        Pic3.Location = New Point(Fix(500 * Rnd()), Fix(100 * Rnd() + a(2) * 100))
        Pic4.Location = New Point(Fix(500 * Rnd()), Fix(100 * Rnd() + a(3) * 100))
        Pic5.Location = New Point(Fix(500 * Rnd()), Fix(100 * Rnd() + a(4) * 100))
        PictureBox1.Size = New Size(15, 15)
        PictureBox1.Location = New Point(300, 300)
        Pic1.Show()
        Pic2.Show()
        Pic3.Show()
        Pic4.Show()
        Pic5.Show()
        TextBox3.Focus()
    End Sub
End Class
