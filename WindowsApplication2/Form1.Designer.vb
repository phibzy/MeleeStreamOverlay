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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Player1Name = New System.Windows.Forms.TextBox()
        Me.Player2Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Player1Score = New System.Windows.Forms.NumericUpDown()
        Me.PlayerScore2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BracketStage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Player1Char = New System.Windows.Forms.ComboBox()
        Me.Player2Char = New System.Windows.Forms.ComboBox()
        Me.Player3Char = New System.Windows.Forms.ComboBox()
        Me.Player4Char = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Player1Score, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerScore2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Swap Names"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Player1Name
        '
        Me.Player1Name.Location = New System.Drawing.Point(12, 28)
        Me.Player1Name.Name = "Player1Name"
        Me.Player1Name.Size = New System.Drawing.Size(125, 20)
        Me.Player1Name.TabIndex = 2
        '
        'Player2Name
        '
        Me.Player2Name.Location = New System.Drawing.Point(236, 28)
        Me.Player2Name.Name = "Player2Name"
        Me.Player2Name.Size = New System.Drawing.Size(125, 20)
        Me.Player2Name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Player 1 Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Player 2 Name"
        '
        'Player1Score
        '
        Me.Player1Score.Location = New System.Drawing.Point(59, 239)
        Me.Player1Score.Name = "Player1Score"
        Me.Player1Score.Size = New System.Drawing.Size(41, 20)
        Me.Player1Score.TabIndex = 8
        '
        'PlayerScore2
        '
        Me.PlayerScore2.Location = New System.Drawing.Point(282, 239)
        Me.PlayerScore2.Name = "PlayerScore2"
        Me.PlayerScore2.Size = New System.Drawing.Size(41, 20)
        Me.PlayerScore2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Player 1 Score"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Player 2 Score"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(150, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Reset Scores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BracketStage
        '
        Me.BracketStage.Location = New System.Drawing.Point(116, 77)
        Me.BracketStage.Name = "BracketStage"
        Me.BracketStage.Size = New System.Drawing.Size(142, 20)
        Me.BracketStage.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Bracket Stage"
        '
        'Player1Char
        '
        Me.Player1Char.FormattingEnabled = True
        Me.Player1Char.Items.AddRange(New Object() {"Bowser Green", "Bowser Red", "Bowser Blue", "Bowser Black", "", "Captain Falcon Neutral", "Captain Falcon Black", "Captain Falcon Blue", "Captain Falcon Green", "Captain Falcon Pink", "Captain Falcon Red", "", "Donkey Kong Brown", "Donkey Kong Black", "Donkey Kong Blue", "Donkey Kong Green", "Donkey Kong Red", "", "Dr. Mario White", "Dr. Mario Black", "Dr. Mario Blue", "Dr. Mario Green", "Dr. Mario Red", "", "Falco Vanilla", "Falco Blue", "Falco Green", "Falco Red", "", "Fox Vanilla", "Fox Blue", "Fox Green", "Fox Orange", "", "Ganondorf Neutral", "Ganondorf Blue", "Ganondorf Green", "Ganondorf Red", "Ganondorf Purple", "", "Ice Climbers Neutral", "Ice Climbers Green", "Ice Climbers Orange", "Ice Climbers Red", "", "Jigglypuff Neutral", "Jigglypuff Blue", "Jigglypuff Green", "Jigglypuff Red", "Jigglypuff Yellow", "", "Kirby Neutral", "Kirby Blue", "Kirby Green", "Kirby Red", "Kirby Yellow", "Kirby White", "", "Link Green", "Link Black", "Link Blue", "Link Red", "Link White", "", "Luigi Green", "Luigi Blue", "Luigi Pink", "Luigi White", "", "Mario Red", "Mario Blue", "Mario Brown", "Mario Green", "Mario Yellow", "", "Marth Blue", "Marth Black", "Marth Green", "Marth Red", "Marth White", "", "Mewtwo Neutral", "Mewtwo Blue", "Mewtwo Green", "Mewtwo Red", " ", "Mr. Game & Watch Black", "Mr. Game & Watch Blue", "Mr. Game & Watch Green", "Mr. Game & Watch Red", "", "Ness Red", "Ness Blue", "Ness Green", "Ness Yellow", "", "Peach Pink", "Peach Blue", "Peach Green", "Peach White", "Peach Yellow", "", "Pichu Neutral", "Pichu Blue", "Pichu Green", "Pichu Red", "", "Pikachu Neutral", "Pikachu Blue", "Pikachu Green", "Pikachu Red", "", "Roy Neutral", "Roy Blue", "Roy Green", "Roy Red", "Roy Yellow", "", "Samus Orange", "Samus Brown", "Samus Green", "Samus Pink", "Samus Purple", "", "Sheik Neutral", "Sheik Blue", "Sheik Green", "Sheik Red", "Sheik White", " ", "Yoshi Green", "Yoshi Blue", "Yoshi Cyan", "Yoshi Pink", "Yoshi Red", "Yoshi Yellow", "", "Young Link Green", "Young Link Black", "Young Link Blue", "Young Link Green", "Young Link Red", "", "Zelda Neutral", "Zelda Blue", "Zelda Green", "Zelda Red", "Zelda White"})
        Me.Player1Char.Location = New System.Drawing.Point(12, 122)
        Me.Player1Char.Name = "Player1Char"
        Me.Player1Char.Size = New System.Drawing.Size(113, 21)
        Me.Player1Char.TabIndex = 15
        '
        'Player2Char
        '
        Me.Player2Char.FormattingEnabled = True
        Me.Player2Char.Items.AddRange(New Object() {"Bowser Green", "Bowser Red", "Bowser Blue", "Bowser Black", "", "Captain Falcon Neutral", "Captain Falcon Black", "Captain Falcon Blue", "Captain Falcon Green", "Captain Falcon Pink", "Captain Falcon Red", "", "Donkey Kong Brown", "Donkey Kong Black", "Donkey Kong Blue", "Donkey Kong Green", "Donkey Kong Red", "", "Dr. Mario White", "Dr. Mario Black", "Dr. Mario Blue", "Dr. Mario Green", "Dr. Mario Red", "", "Falco Vanilla", "Falco Blue", "Falco Green", "Falco Red", "", "Fox Vanilla", "Fox Blue", "Fox Green", "Fox Orange", "", "Ganondorf Neutral", "Ganondorf Blue", "Ganondorf Green", "Ganondorf Red", "Ganondorf Purple", "", "Ice Climbers Neutral", "Ice Climbers Green", "Ice Climbers Orange", "Ice Climbers Red", "", "Jigglypuff Neutral", "Jigglypuff Blue", "Jigglypuff Green", "Jigglypuff Red", "Jigglypuff Yellow", "", "Kirby Neutral", "Kirby Blue", "Kirby Green", "Kirby Red", "Kirby Yellow", "Kirby White", "", "Link Green", "Link Black", "Link Blue", "Link Red", "Link White", "", "Luigi Green", "Luigi Blue", "Luigi Pink", "Luigi White", "", "Mario Red", "Mario Blue", "Mario Brown", "Mario Green", "Mario Yellow", "", "Marth Blue", "Marth Black", "Marth Green", "Marth Red", "Marth White", "", "Mewtwo Neutral", "Mewtwo Blue", "Mewtwo Green", "Mewtwo Red", " ", "Mr. Game & Watch Black", "Mr. Game & Watch Blue", "Mr. Game & Watch Green", "Mr. Game & Watch Red", "", "Ness Red", "Ness Blue", "Ness Green", "Ness Yellow", "", "Peach Pink", "Peach Blue", "Peach Green", "Peach White", "Peach Yellow", "", "Pichu Neutral", "Pichu Blue", "Pichu Green", "Pichu Red", "", "Pikachu Neutral", "Pikachu Blue", "Pikachu Green", "Pikachu Red", "", "Roy Neutral", "Roy Blue", "Roy Green", "Roy Red", "Roy Yellow", "", "Samus Orange", "Samus Brown", "Samus Green", "Samus Pink", "Samus Purple", "", "Sheik Neutral", "Sheik Blue", "Sheik Green", "Sheik Red", "Sheik White", " ", "Yoshi Green", "Yoshi Blue", "Yoshi Cyan", "Yoshi Pink", "Yoshi Red", "Yoshi Yellow", "", "Young Link Green", "Young Link Black", "Young Link Blue", "Young Link Green", "Young Link Red", "", "Zelda Neutral", "Zelda Blue", "Zelda Green", "Zelda Red", "Zelda White"})
        Me.Player2Char.Location = New System.Drawing.Point(240, 124)
        Me.Player2Char.Name = "Player2Char"
        Me.Player2Char.Size = New System.Drawing.Size(121, 21)
        Me.Player2Char.TabIndex = 16
        '
        'Player3Char
        '
        Me.Player3Char.FormattingEnabled = True
        Me.Player3Char.Items.AddRange(New Object() {"Bowser Green", "Bowser Red", "Bowser Blue", "Bowser Black", "", "Captain Falcon Neutral", "Captain Falcon Black", "Captain Falcon Blue", "Captain Falcon Green", "Captain Falcon Pink", "Captain Falcon Red", "", "Donkey Kong Brown", "Donkey Kong Black", "Donkey Kong Blue", "Donkey Kong Green", "Donkey Kong Red", "", "Dr. Mario White", "Dr. Mario Black", "Dr. Mario Blue", "Dr. Mario Green", "Dr. Mario Red", "", "Falco Vanilla", "Falco Blue", "Falco Green", "Falco Red", "", "Fox Vanilla", "Fox Blue", "Fox Green", "Fox Orange", "", "Ganondorf Neutral", "Ganondorf Blue", "Ganondorf Green", "Ganondorf Red", "Ganondorf Purple", "", "Ice Climbers Neutral", "Ice Climbers Green", "Ice Climbers Orange", "Ice Climbers Red", "", "Jigglypuff Neutral", "Jigglypuff Blue", "Jigglypuff Green", "Jigglypuff Red", "Jigglypuff Yellow", "", "Kirby Neutral", "Kirby Blue", "Kirby Green", "Kirby Red", "Kirby Yellow", "Kirby White", "", "Link Green", "Link Black", "Link Blue", "Link Red", "Link White", "", "Luigi Green", "Luigi Blue", "Luigi Pink", "Luigi White", "", "Mario Red", "Mario Blue", "Mario Brown", "Mario Green", "Mario Yellow", "", "Marth Blue", "Marth Black", "Marth Green", "Marth Red", "Marth White", "", "Mewtwo Neutral", "Mewtwo Blue", "Mewtwo Green", "Mewtwo Red", " ", "Mr. Game & Watch Black", "Mr. Game & Watch Blue", "Mr. Game & Watch Green", "Mr. Game & Watch Red", "", "Ness Red", "Ness Blue", "Ness Green", "Ness Yellow", "", "Peach Pink", "Peach Blue", "Peach Green", "Peach White", "Peach Yellow", "", "Pichu Neutral", "Pichu Blue", "Pichu Green", "Pichu Red", "", "Pikachu Neutral", "Pikachu Blue", "Pikachu Green", "Pikachu Red", "", "Roy Neutral", "Roy Blue", "Roy Green", "Roy Red", "Roy Yellow", "", "Samus Orange", "Samus Brown", "Samus Green", "Samus Pink", "Samus Purple", "", "Sheik Neutral", "Sheik Blue", "Sheik Green", "Sheik Red", "Sheik White", " ", "Yoshi Green", "Yoshi Blue", "Yoshi Cyan", "Yoshi Pink", "Yoshi Red", "Yoshi Yellow", "", "Young Link Green", "Young Link Black", "Young Link Blue", "Young Link Green", "Young Link Red", "", "Zelda Neutral", "Zelda Blue", "Zelda Green", "Zelda Red", "Zelda White"})
        Me.Player3Char.Location = New System.Drawing.Point(14, 199)
        Me.Player3Char.Name = "Player3Char"
        Me.Player3Char.Size = New System.Drawing.Size(113, 21)
        Me.Player3Char.TabIndex = 17
        '
        'Player4Char
        '
        Me.Player4Char.FormattingEnabled = True
        Me.Player4Char.Items.AddRange(New Object() {"Bowser Green", "Bowser Red", "Bowser Blue", "Bowser Black", "", "Captain Falcon Neutral", "Captain Falcon Black", "Captain Falcon Blue", "Captain Falcon Green", "Captain Falcon Pink", "Captain Falcon Red", "", "Donkey Kong Brown", "Donkey Kong Black", "Donkey Kong Blue", "Donkey Kong Green", "Donkey Kong Red", "", "Dr. Mario White", "Dr. Mario Black", "Dr. Mario Blue", "Dr. Mario Green", "Dr. Mario Red", "", "Falco Vanilla", "Falco Blue", "Falco Green", "Falco Red", "", "Fox Vanilla", "Fox Blue", "Fox Green", "Fox Orange", "", "Ganondorf Neutral", "Ganondorf Blue", "Ganondorf Green", "Ganondorf Red", "Ganondorf Purple", "", "Ice Climbers Neutral", "Ice Climbers Green", "Ice Climbers Orange", "Ice Climbers Red", "", "Jigglypuff Neutral", "Jigglypuff Blue", "Jigglypuff Green", "Jigglypuff Red", "Jigglypuff Yellow", "", "Kirby Neutral", "Kirby Blue", "Kirby Green", "Kirby Red", "Kirby Yellow", "Kirby White", "", "Link Green", "Link Black", "Link Blue", "Link Red", "Link White", "", "Luigi Green", "Luigi Blue", "Luigi Pink", "Luigi White", "", "Mario Red", "Mario Blue", "Mario Brown", "Mario Green", "Mario Yellow", "", "Marth Blue", "Marth Black", "Marth Green", "Marth Red", "Marth White", "", "Mewtwo Neutral", "Mewtwo Blue", "Mewtwo Green", "Mewtwo Red", " ", "Mr. Game & Watch Black", "Mr. Game & Watch Blue", "Mr. Game & Watch Green", "Mr. Game & Watch Red", "", "Ness Red", "Ness Blue", "Ness Green", "Ness Yellow", "", "Peach Pink", "Peach Blue", "Peach Green", "Peach White", "Peach Yellow", "", "Pichu Neutral", "Pichu Blue", "Pichu Green", "Pichu Red", "", "Pikachu Neutral", "Pikachu Blue", "Pikachu Green", "Pikachu Red", "", "Roy Neutral", "Roy Blue", "Roy Green", "Roy Red", "Roy Yellow", "", "Samus Orange", "Samus Brown", "Samus Green", "Samus Pink", "Samus Purple", "", "Sheik Neutral", "Sheik Blue", "Sheik Green", "Sheik Red", "Sheik White", " ", "Yoshi Green", "Yoshi Blue", "Yoshi Cyan", "Yoshi Pink", "Yoshi Red", "Yoshi Yellow", "", "Young Link Green", "Young Link Black", "Young Link Blue", "Young Link Green", "Young Link Red", "", "Zelda Neutral", "Zelda Blue", "Zelda Green", "Zelda Red", "Zelda White"})
        Me.Player4Char.Location = New System.Drawing.Point(242, 199)
        Me.Player4Char.Name = "Player4Char"
        Me.Player4Char.Size = New System.Drawing.Size(121, 21)
        Me.Player4Char.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(136, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Copy Player Icons"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(157, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Swap"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Player 1 Icon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Player 2 Icon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Webcam Icon 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(259, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Webcam Icon 2"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 159)
        Me.Panel1.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(373, 307)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Player4Char)
        Me.Controls.Add(Me.Player3Char)
        Me.Controls.Add(Me.Player2Char)
        Me.Controls.Add(Me.Player1Char)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BracketStage)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PlayerScore2)
        Me.Controls.Add(Me.Player1Score)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player2Name)
        Me.Controls.Add(Me.Player1Name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Stream Thingy"
        CType(Me.Player1Score, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerScore2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Player1Name As TextBox
    Friend WithEvents Player2Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Player1Score As NumericUpDown
    Friend WithEvents PlayerScore2 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BracketStage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Player1Char As ComboBox
    Friend WithEvents Player2Char As ComboBox
    Friend WithEvents Player3Char As ComboBox
    Friend WithEvents Player4Char As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
