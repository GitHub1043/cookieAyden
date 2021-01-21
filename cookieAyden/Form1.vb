Public Class Form1
    Dim intCookies As Integer = 0
    Dim intBakerCount As Integer = 0
    Dim intFarmCount As Integer = 0
    Dim intFactoryCount As Integer = 0
    Dim intMineCount As Integer = 0
    Dim intBakerCost As Integer = 50
    Dim intFarmCost As Integer = 500
    Dim intFactoryCost As Integer = 10000
    Dim intMineCost As Integer = 100000
    Dim intTimer As Integer = 100
    Dim intCookieTime As Integer = -1

    Private Sub btnCookie_Click(sender As Object, e As EventArgs) Handles btnCookie.Click
        intCookies = intCookies + 1
        intCookies = intCookies + 1 * intBakerCount * 2
        intCookies = intCookies + 1 * intFarmCount * 5
        intCookies = intCookies + 1 * intFactoryCount * 10
        intCookies = intCookies + 1 * intMineCount * 50

        btnCookie.Text = intCookies

        If (intCookies >= intBakerCost) Then
            btnBaker.Text = "Baker"
            picBaker.Visible = True
        End If

        If (intCookies >= intFarmCost) Then
            btnFarm.Text = "Farm"
            picFarm.Visible = True
        End If

        If (intCookies >= intFactoryCost) Then
            btnFactory.Text = "Factory"
            picFactory.Visible = True
        End If

        If (intCookies >= intMineCost) Then
            btnMine.Text = "Mine"
            picMine.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBaker.Click
        If (intCookies >= intBakerCost) Then
            intBakerCount = intBakerCount + 1
            intCookies = intCookies - intBakerCost
            intBakerCost = intBakerCost * 1.5

            lblBakerCount.Text = intBakerCount
            btnCookie.Text = intCookies
            lblBakerCost.Text = "Cost: " & intBakerCost
            ' want more
            ' really working well
            ' too much
            Select Case intBakerCount
                Case 1
                    lblNews.Text = "News: Bakers have arrived!"

                Case 5
                    lblNews.Text = "News: Bakers are helping very much!"

                Case 10
                    lblNews.Text = "News: Bakers threaten strike! demand better working conditions!"
            End Select
        End If
    End Sub

    Private Sub btnFarm_Click(sender As Object, e As EventArgs) Handles btnFarm.Click
        If (intCookies >= intFarmCost) Then
            intFarmCount = intFarmCount + 1
            intCookies = intCookies - intFarmCost
            intFarmCost = intFarmCost * 1.5

            lblFarmCount.Text = intFarmCount
            btnCookie.Text = intCookies
            lblFarmCost.Text = "Cost: " & intFarmCost

            Select Case intFarmCount
                Case 1
                    lblNews.Text = "News: Farmers are farming cookies!"

                Case 5
                    lblNews.Text = "News: Farmers love eating your cookies!"

                Case 10
                    lblNews.Text = "News: There is so many cookies that the farmers have no place to store them!"
            End Select
        End If
    End Sub

    Private Sub btnFactory_Click(sender As Object, e As EventArgs) Handles btnFactory.Click
        If (intCookies >= intFactoryCost) Then
            intFactoryCount = intFactoryCount + 1
            intCookies = intCookies - intFactoryCost
            intFactoryCost = intFactoryCost * 1.5

            lblFactoryCount.Text = intFactoryCount
            btnCookie.Text = intCookies
            lblFactoryCost.Text = "Cost: " & intFactoryCost

            Select Case intFactoryCount
                Case 1
                    lblNews.Text = "News: New factories are being built to bake cookies!"

                Case 5
                    lblNews.Text = "News: Factories are increasing you stocks!"

                Case 10
                    lblNews.Text = "News: Factories are becoming over populated!"
            End Select
        End If
    End Sub

    Private Sub btnMine_Click(sender As Object, e As EventArgs) Handles btnMine.Click
        If (intCookies >= intMineCost) Then
            intMineCount = intMineCount + 1
            intCookies = intCookies - intMineCost
            intMineCost = intMineCost * 1.5

            lblMineCount.Text = intMineCount
            btnCookie.Text = intCookies
            lblMineCost.Text = "Cost: " & intMineCost

            Select Case intMineCount
                Case 1
                    lblNews.Text = "News: Mines are being found that contain your cookies!"

                Case 5
                    lblNews.Text = "News: People are wondering if they can find your cookies in mines!"

                Case 10
                    lblNews.Text = "News: You've dug so many holes into the Earth that it might collapse!"
            End Select
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBaker.Text = ""
        picBaker.Visible = False

        btnFarm.Text = ""
        picFarm.Visible = False

        btnFactory.Text = ""
        picFactory.Visible = False

        btnMine.Text = ""
        picMine.Visible = False

        Timer1.Start()
        intTimer = 100
        btnGold.Visible = False

    End Sub

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        intCookies = intCookies * 1.1
        btnCookie.Text = intCookies
        btnGold.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intTimer = intTimer - 1
        intCookieTime = intCookieTime - 1
        If intTimer = 0 Then
            intCookieTime = Int(Rnd() * 20) + 20
            ' random from 20 - 40
            btnGold.Location = New Point(Int(Rnd() * 130) + 926, Int(Rnd() * 257) + 12)
            ' x = 926 to 1060
            ' int(RND()*130)+926
            ' y = 12 to 269
            ' int(RND()*257)+12
            btnGold.Visible = True
            intTimer = Int(Rnd() * 500) + 1000
            ' random from 1000 - 1500
        End If

        If intCookieTime = 0 Then
            btnGold.Visible = False
        End If

    End Sub
End Class
