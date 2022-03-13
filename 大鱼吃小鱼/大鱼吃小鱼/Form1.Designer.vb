<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Pic4 = New System.Windows.Forms.PictureBox()
        Me.Pic5 = New System.Windows.Forms.PictureBox()
        Me.Pic3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.游戏开始 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic1
        '
        Me.Pic1.Image = CType(resources.GetObject("Pic1.Image"), System.Drawing.Image)
        Me.Pic1.Location = New System.Drawing.Point(231, 94)
        Me.Pic1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(10, 10)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic1.TabIndex = 0
        Me.Pic1.TabStop = False
        '
        'Pic2
        '
        Me.Pic2.Image = CType(resources.GetObject("Pic2.Image"), System.Drawing.Image)
        Me.Pic2.Location = New System.Drawing.Point(231, 227)
        Me.Pic2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(25, 25)
        Me.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic2.TabIndex = 1
        Me.Pic2.TabStop = False
        '
        'Pic4
        '
        Me.Pic4.Image = CType(resources.GetObject("Pic4.Image"), System.Drawing.Image)
        Me.Pic4.Location = New System.Drawing.Point(231, 403)
        Me.Pic4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic4.Name = "Pic4"
        Me.Pic4.Size = New System.Drawing.Size(55, 55)
        Me.Pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic4.TabIndex = 2
        Me.Pic4.TabStop = False
        '
        'Pic5
        '
        Me.Pic5.Image = CType(resources.GetObject("Pic5.Image"), System.Drawing.Image)
        Me.Pic5.Location = New System.Drawing.Point(231, 545)
        Me.Pic5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic5.Name = "Pic5"
        Me.Pic5.Size = New System.Drawing.Size(70, 70)
        Me.Pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic5.TabIndex = 3
        Me.Pic5.TabStop = False
        '
        'Pic3
        '
        Me.Pic3.Image = CType(resources.GetObject("Pic3.Image"), System.Drawing.Image)
        Me.Pic3.Location = New System.Drawing.Point(231, 318)
        Me.Pic3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(40, 40)
        Me.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic3.TabIndex = 4
        Me.Pic3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 318)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 14)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        '游戏开始
        '
        Me.游戏开始.BackgroundImage = CType(resources.GetObject("游戏开始.BackgroundImage"), System.Drawing.Image)
        Me.游戏开始.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.游戏开始.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.游戏开始.Location = New System.Drawing.Point(1101, 47)
        Me.游戏开始.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.游戏开始.Name = "游戏开始"
        Me.游戏开始.Size = New System.Drawing.Size(208, 74)
        Me.游戏开始.TabIndex = 6
        Me.游戏开始.Text = "游戏开始"
        Me.游戏开始.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1166, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "倒计时"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1166, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "排行榜"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(1098, 616)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 38)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "按上左下右键来进行操作按空格进行一次吞噬尝试"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.TextBox1.Location = New System.Drawing.Point(1145, 208)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 28)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(1145, 358)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 192)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(1354, 616)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(10, 28)
        Me.TextBox3.TabIndex = 12
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.WindowsApplication14.My.Resources.Resources.QQ图片20211030141831__2_
        Me.ClientSize = New System.Drawing.Size(1451, 716)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.游戏开始)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pic3)
        Me.Controls.Add(Me.Pic5)
        Me.Controls.Add(Me.Pic4)
        Me.Controls.Add(Me.Pic2)
        Me.Controls.Add(Me.Pic1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "大鱼吃小鱼"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents Pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents 游戏开始 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
