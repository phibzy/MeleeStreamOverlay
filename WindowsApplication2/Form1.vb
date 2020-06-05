Imports System
Imports System.IO

Public Class Form1
    Dim path As String = Directory.GetCurrentDirectory
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player1Name.Text = System.IO.File.ReadAllText(path + "\Name1.txt")
        Player2Name.Text = System.IO.File.ReadAllText(Path + "\Name2.txt")
        BracketStage.Text = System.IO.File.ReadAllText(Path + "\BracketStage.txt")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Player1Name.TextChanged




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.IO.File.WriteAllText(path + "\Name1.txt", Player1Name.Text)
        System.IO.File.WriteAllText(path + "\Name2.txt", Player2Name.Text)
        System.IO.File.WriteAllText(path + "\BracketStage.txt", BracketStage.Text)
        SaveCharPlayer("1")
        SaveCharPlayer("2")


    End Sub

    Private Sub SaveCharPlayer(number As String)
        Dim itemName As String = "Player" + number + "Char"

        If (CType(Controls(itemName), ComboBox).Text = "Bowser Green") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Bowser.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Bowser Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Bowser.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Bowser Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Bowser.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Bowser Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Bowser.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Captain Falcon.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Captain Falcon.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Captain Falcon.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Captain Falcon.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Pink") Then
            System.IO.File.Copy(path + "\Stock Icons\white Captain Falcon.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Captain Falcon Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Captain Falcon.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Donkey Kong Brown") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Donkey Kong.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Donkey Kong Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Donkey Kong.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Donkey Kong Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Donkey Kong.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Donkey Kong Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Donkey Kong.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Donkey Kong Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Donkey Kong.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Dr. Mario White") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Doctor Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Dr. Mario Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Doctor Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Dr. Mario Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Doctor Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Dr. Mario Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Doctor Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Dr. Mario Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Doctor Mario.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Falco Vanilla") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Falco.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Falco Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Falco.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Falco Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Falco.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Falco Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Falco.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Fox Vanilla") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Fox.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Fox Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Fox.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Fox Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Fox.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Fox Orange") Then
            System.IO.File.Copy(path + "\Stock Icons\red Fox.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ganondorf Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Ganondorf.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ganondorf Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Ganondorf.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ganondorf Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Ganondorf.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ganondorf Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Ganondorf.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ganondorf Purple") Then
            System.IO.File.Copy(path + "\Stock Icons\purple Ganondorf.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ice Climbers Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Ice Climbers.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ice Climbers Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Ice Climbers.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ice Climbers Orange") Then
            System.IO.File.Copy(path + "\Stock Icons\orange Ice Climbers.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ice Climbers Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Ice Climbers.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Jigglypuff Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Jigglypuff.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Jigglypuff Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\bow Jigglypuff.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Jigglypuff Green") Then
            System.IO.File.Copy(path + "\Stock Icons\headband Jigglypuff.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Jigglypuff Red") Then
            System.IO.File.Copy(path + "\Stock Icons\flower Jigglypuff.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Jigglypuff Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\crown Jigglypuff.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Kirby.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Kirby.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Kirby.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Kirby.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Kirby.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Kirby Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\yellow Kirby.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Link Green") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Link Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Link Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Link Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Link White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Link.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Luigi Green") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Luigi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Luigi Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Luigi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Luigi Pink") Then
            System.IO.File.Copy(path + "\Stock Icons\pink Luigi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Luigi White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Luigi.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mario Red") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mario Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mario Brown") Then
            System.IO.File.Copy(path + "\Stock Icons\brown Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mario Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Mario.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mario Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\yellow Mario.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Marth Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Marth.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Marth Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Marth.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Marth Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Marth.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Marth Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Marth.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Marth White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Marth.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mewtwo Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Mewtwo.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mewtwo Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Mewtwo.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mewtwo Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Mewtwo.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mewtwo Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Mewtwo.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mr. Game & Watch Black") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Mr. Game & Watch.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mr. Game & Watch Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Mr. Game & Watch.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mr. Game & Watch Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Mr. Game & Watch.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Mr. Game & Watch Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Mr. Game & Watch.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ness Red") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Ness.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ness Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Ness.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ness Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Ness.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Ness Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\yellow Ness.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Peach Pink") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Peach.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Peach Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Peach.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Peach Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Peach.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Peach White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Peach.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Peach Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\daisy Peach.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pichu Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Pichu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pichu Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Pichu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pichu Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Pichu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pichu Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Pichu.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pikachu Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Pikachu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pikachu Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Pikachu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pikachu Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Pikachu.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Pikachu Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Pikachu.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Roy Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Roy.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Roy Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Roy.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Roy Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Roy.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Roy Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Roy.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Roy Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\yellow Roy.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Samus Orange") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Samus.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Samus Brown") Then
            System.IO.File.Copy(path + "\Stock Icons\brown Samus.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Samus Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Samus.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Samus Pink") Then
            System.IO.File.Copy(path + "\Stock Icons\red Samus.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Samus Purple") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Samus.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Sheik Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Sheik.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Sheik Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Sheik.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Sheik Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Sheik.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Sheik Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Sheik.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Sheik White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Sheik.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Green") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Yoshi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Yoshi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Cyan") Then
            System.IO.File.Copy(path + "\Stock Icons\cyan Yoshi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Pink") Then
            System.IO.File.Copy(path + "\Stock Icons\pink Yoshi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Yoshi.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Yoshi Yellow") Then
            System.IO.File.Copy(path + "\Stock Icons\yellow Yoshi.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Young Link Green") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Young Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Young Link Black") Then
            System.IO.File.Copy(path + "\Stock Icons\black Young Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Young Link Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Young Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Young Link Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Young Link.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Young Link White") Then
            System.IO.File.Copy(path + "\Stock Icons\white Young Link.png", path + "\player" + number + "char.png", True)

        ElseIf (CType(Controls(itemName), ComboBox).Text = "Zelda Neutral") Then
            System.IO.File.Copy(path + "\Stock Icons\neutral Zelda.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Zelda Blue") Then
            System.IO.File.Copy(path + "\Stock Icons\blue Zelda.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Zelda Green") Then
            System.IO.File.Copy(path + "\Stock Icons\green Zelda.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Zelda Red") Then
            System.IO.File.Copy(path + "\Stock Icons\red Zelda.png", path + "\player" + number + "char.png", True)
        ElseIf (CType(Controls(itemName), ComboBox).Text = "Zelda White") Then
            System.IO.File.Copy(path + "\Stock Icons\lavender Zelda.png", path + "\player" + number + "char.png", True)
        Else
            System.IO.File.Copy(path + "\Stock Icons\Wireframe.png", path + "\player" + number + "char.png", True)
        End If

        File.SetLastWriteTime(path + "\player" + number + "char.png", DateTime.Now)

    End Sub

    Private Sub SaveCharPlayer2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player1Name.Text = System.IO.File.ReadAllText(path + "\Name2.txt")
        Player2Name.Text = System.IO.File.ReadAllText(path + "\Name1.txt")
        System.IO.File.WriteAllText(path + "\Name1.txt", Player1Name.Text)
        System.IO.File.WriteAllText(path + "\Name2.txt", Player2Name.Text)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles Player1Score.ValueChanged
        System.IO.File.WriteAllText(path + "\Score1.txt", Player1Score.Value)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles PlayerScore2.ValueChanged
        System.IO.File.WriteAllText(path + "\Score2.txt", PlayerScore2.Value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.IO.File.WriteAllText(path + "\Score1.txt", "0")
        System.IO.File.WriteAllText(path + "\Score2.txt", "0")
        PlayerScore2.Value = 0
        Player1Score.Value = 0
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles BracketStage.TextChanged

    End Sub

    Private Sub Player1Char_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Player1Char.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Player3Char.Text = Player1Char.Text
        Player4Char.Text = Player2Char.Text
        System.IO.File.Copy(path + "\player1char.png", path + "\player3char.png", True)
        System.IO.File.Copy(path + "\player2char.png", path + "\player4char.png", True)
        File.SetLastWriteTime(path + "\player3char.png", DateTime.Now)
        File.SetLastWriteTime(path + "\player4char.png", DateTime.Now)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim temp As String = Player3Char.Text
        Player3Char.Text = Player4Char.Text
        Player4Char.Text = temp
        System.IO.File.Copy(path + "\player3char.png", path + "\player5char.png", True)
        System.IO.File.Copy(path + "\player4char.png", path + "\player3char.png", True)
        System.IO.File.Copy(path + "\player5char.png", path + "\player4char.png", True)
        File.SetLastWriteTime(path + "\player3char.png", DateTime.Now)
        File.SetLastWriteTime(path + "\player4char.png", DateTime.Now)
    End Sub
End Class
