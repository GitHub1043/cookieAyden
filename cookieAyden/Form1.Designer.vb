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
        Me.btnBaker = New System.Windows.Forms.Button()
        Me.btnFarm = New System.Windows.Forms.Button()
        Me.btnFactory = New System.Windows.Forms.Button()
        Me.btnMine = New System.Windows.Forms.Button()
        Me.lblBakerCount = New System.Windows.Forms.Label()
        Me.lblFarmCount = New System.Windows.Forms.Label()
        Me.lblFactoryCount = New System.Windows.Forms.Label()
        Me.lblMineCount = New System.Windows.Forms.Label()
        Me.lblBakerCost = New System.Windows.Forms.Label()
        Me.lblFarmCost = New System.Windows.Forms.Label()
        Me.lblFactoryCost = New System.Windows.Forms.Label()
        Me.lblMineCost = New System.Windows.Forms.Label()
        Me.picMine = New System.Windows.Forms.PictureBox()
        Me.picFactory = New System.Windows.Forms.PictureBox()
        Me.picFarm = New System.Windows.Forms.PictureBox()
        Me.picBaker = New System.Windows.Forms.PictureBox()
        Me.btnCookie = New System.Windows.Forms.Button()
        Me.lblNews = New System.Windows.Forms.Label()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFactory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBaker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBaker
        '
        Me.btnBaker.BackColor = System.Drawing.Color.Black
        Me.btnBaker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaker.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBaker.Location = New System.Drawing.Point(634, 45)
        Me.btnBaker.Name = "btnBaker"
        Me.btnBaker.Size = New System.Drawing.Size(101, 35)
        Me.btnBaker.TabIndex = 1
        Me.btnBaker.Text = "Baker"
        Me.btnBaker.UseVisualStyleBackColor = False
        '
        'btnFarm
        '
        Me.btnFarm.BackColor = System.Drawing.Color.Black
        Me.btnFarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFarm.ForeColor = System.Drawing.SystemColors.Window
        Me.btnFarm.Location = New System.Drawing.Point(634, 95)
        Me.btnFarm.Name = "btnFarm"
        Me.btnFarm.Size = New System.Drawing.Size(101, 35)
        Me.btnFarm.TabIndex = 2
        Me.btnFarm.Text = "Farm"
        Me.btnFarm.UseVisualStyleBackColor = False
        '
        'btnFactory
        '
        Me.btnFactory.BackColor = System.Drawing.Color.Black
        Me.btnFactory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactory.ForeColor = System.Drawing.SystemColors.Window
        Me.btnFactory.Location = New System.Drawing.Point(634, 145)
        Me.btnFactory.Name = "btnFactory"
        Me.btnFactory.Size = New System.Drawing.Size(101, 35)
        Me.btnFactory.TabIndex = 3
        Me.btnFactory.Text = "Factory"
        Me.btnFactory.UseVisualStyleBackColor = False
        '
        'btnMine
        '
        Me.btnMine.BackColor = System.Drawing.Color.Black
        Me.btnMine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMine.ForeColor = System.Drawing.SystemColors.Window
        Me.btnMine.Location = New System.Drawing.Point(634, 195)
        Me.btnMine.Name = "btnMine"
        Me.btnMine.Size = New System.Drawing.Size(101, 35)
        Me.btnMine.TabIndex = 4
        Me.btnMine.Text = "Mine"
        Me.btnMine.UseVisualStyleBackColor = False
        '
        'lblBakerCount
        '
        Me.lblBakerCount.AutoSize = True
        Me.lblBakerCount.BackColor = System.Drawing.Color.Black
        Me.lblBakerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBakerCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblBakerCount.Location = New System.Drawing.Point(466, 45)
        Me.lblBakerCount.Name = "lblBakerCount"
        Me.lblBakerCount.Size = New System.Drawing.Size(24, 25)
        Me.lblBakerCount.TabIndex = 5
        Me.lblBakerCount.Text = "0"
        '
        'lblFarmCount
        '
        Me.lblFarmCount.AutoSize = True
        Me.lblFarmCount.BackColor = System.Drawing.Color.Black
        Me.lblFarmCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarmCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFarmCount.Location = New System.Drawing.Point(466, 95)
        Me.lblFarmCount.Name = "lblFarmCount"
        Me.lblFarmCount.Size = New System.Drawing.Size(24, 25)
        Me.lblFarmCount.TabIndex = 6
        Me.lblFarmCount.Text = "0"
        '
        'lblFactoryCount
        '
        Me.lblFactoryCount.AutoSize = True
        Me.lblFactoryCount.BackColor = System.Drawing.Color.Black
        Me.lblFactoryCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactoryCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFactoryCount.Location = New System.Drawing.Point(466, 145)
        Me.lblFactoryCount.Name = "lblFactoryCount"
        Me.lblFactoryCount.Size = New System.Drawing.Size(24, 25)
        Me.lblFactoryCount.TabIndex = 7
        Me.lblFactoryCount.Text = "0"
        '
        'lblMineCount
        '
        Me.lblMineCount.AutoSize = True
        Me.lblMineCount.BackColor = System.Drawing.Color.Black
        Me.lblMineCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMineCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMineCount.Location = New System.Drawing.Point(466, 195)
        Me.lblMineCount.Name = "lblMineCount"
        Me.lblMineCount.Size = New System.Drawing.Size(24, 25)
        Me.lblMineCount.TabIndex = 8
        Me.lblMineCount.Text = "0"
        '
        'lblBakerCost
        '
        Me.lblBakerCost.AutoSize = True
        Me.lblBakerCost.BackColor = System.Drawing.Color.Black
        Me.lblBakerCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBakerCost.ForeColor = System.Drawing.SystemColors.Window
        Me.lblBakerCost.Location = New System.Drawing.Point(780, 46)
        Me.lblBakerCost.Name = "lblBakerCost"
        Me.lblBakerCost.Size = New System.Drawing.Size(92, 25)
        Me.lblBakerCost.TabIndex = 9
        Me.lblBakerCost.Text = "Cost: 50"
        '
        'lblFarmCost
        '
        Me.lblFarmCost.AutoSize = True
        Me.lblFarmCost.BackColor = System.Drawing.Color.Black
        Me.lblFarmCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarmCost.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFarmCost.Location = New System.Drawing.Point(780, 96)
        Me.lblFarmCost.Name = "lblFarmCost"
        Me.lblFarmCost.Size = New System.Drawing.Size(104, 25)
        Me.lblFarmCost.TabIndex = 10
        Me.lblFarmCost.Text = "Cost: 500"
        '
        'lblFactoryCost
        '
        Me.lblFactoryCost.AutoSize = True
        Me.lblFactoryCost.BackColor = System.Drawing.Color.Black
        Me.lblFactoryCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactoryCost.ForeColor = System.Drawing.SystemColors.Window
        Me.lblFactoryCost.Location = New System.Drawing.Point(780, 146)
        Me.lblFactoryCost.Name = "lblFactoryCost"
        Me.lblFactoryCost.Size = New System.Drawing.Size(128, 25)
        Me.lblFactoryCost.TabIndex = 11
        Me.lblFactoryCost.Text = "Cost: 10000"
        '
        'lblMineCost
        '
        Me.lblMineCost.AutoSize = True
        Me.lblMineCost.BackColor = System.Drawing.Color.Black
        Me.lblMineCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMineCost.ForeColor = System.Drawing.SystemColors.Window
        Me.lblMineCost.Location = New System.Drawing.Point(780, 196)
        Me.lblMineCost.Name = "lblMineCost"
        Me.lblMineCost.Size = New System.Drawing.Size(140, 25)
        Me.lblMineCost.TabIndex = 12
        Me.lblMineCost.Text = "Cost: 100000"
        '
        'picMine
        '
        Me.picMine.BackColor = System.Drawing.Color.Black
        Me.picMine.Image = Global.cookieAyden.My.Resources.Resources.mine
        Me.picMine.Location = New System.Drawing.Point(555, 195)
        Me.picMine.Name = "picMine"
        Me.picMine.Size = New System.Drawing.Size(58, 35)
        Me.picMine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMine.TabIndex = 16
        Me.picMine.TabStop = False
        '
        'picFactory
        '
        Me.picFactory.BackColor = System.Drawing.Color.Black
        Me.picFactory.Image = Global.cookieAyden.My.Resources.Resources.factory
        Me.picFactory.Location = New System.Drawing.Point(555, 145)
        Me.picFactory.Name = "picFactory"
        Me.picFactory.Size = New System.Drawing.Size(58, 35)
        Me.picFactory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFactory.TabIndex = 15
        Me.picFactory.TabStop = False
        '
        'picFarm
        '
        Me.picFarm.BackColor = System.Drawing.Color.Black
        Me.picFarm.Image = Global.cookieAyden.My.Resources.Resources.farm
        Me.picFarm.Location = New System.Drawing.Point(555, 95)
        Me.picFarm.Name = "picFarm"
        Me.picFarm.Size = New System.Drawing.Size(58, 35)
        Me.picFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFarm.TabIndex = 14
        Me.picFarm.TabStop = False
        '
        'picBaker
        '
        Me.picBaker.BackColor = System.Drawing.Color.Black
        Me.picBaker.Image = Global.cookieAyden.My.Resources.Resources.baker
        Me.picBaker.Location = New System.Drawing.Point(555, 45)
        Me.picBaker.Name = "picBaker"
        Me.picBaker.Size = New System.Drawing.Size(58, 35)
        Me.picBaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBaker.TabIndex = 13
        Me.picBaker.TabStop = False
        '
        'btnCookie
        '
        Me.btnCookie.BackColor = System.Drawing.Color.Black
        Me.btnCookie.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCookie.Image = Global.cookieAyden.My.Resources.Resources.cookie1
        Me.btnCookie.Location = New System.Drawing.Point(31, 45)
        Me.btnCookie.Name = "btnCookie"
        Me.btnCookie.Size = New System.Drawing.Size(269, 263)
        Me.btnCookie.TabIndex = 0
        Me.btnCookie.Text = "0"
        Me.btnCookie.UseVisualStyleBackColor = False
        '
        'lblNews
        '
        Me.lblNews.AutoSize = True
        Me.lblNews.BackColor = System.Drawing.Color.Black
        Me.lblNews.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNews.ForeColor = System.Drawing.SystemColors.Window
        Me.lblNews.Location = New System.Drawing.Point(27, 369)
        Me.lblNews.Name = "lblNews"
        Me.lblNews.Size = New System.Drawing.Size(56, 20)
        Me.lblNews.TabIndex = 17
        Me.lblNews.Text = "News: "
        '
        'btnGold
        '
        Me.btnGold.BackColor = System.Drawing.Color.Gold
        Me.btnGold.Location = New System.Drawing.Point(1062, 12)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(84, 84)
        Me.btnGold.TabIndex = 18
        Me.btnGold.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cookieAyden.My.Resources.Resources.cookieMonster6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1158, 446)
        Me.Controls.Add(Me.btnGold)
        Me.Controls.Add(Me.lblNews)
        Me.Controls.Add(Me.picMine)
        Me.Controls.Add(Me.picFactory)
        Me.Controls.Add(Me.picFarm)
        Me.Controls.Add(Me.picBaker)
        Me.Controls.Add(Me.lblMineCost)
        Me.Controls.Add(Me.lblFactoryCost)
        Me.Controls.Add(Me.lblFarmCost)
        Me.Controls.Add(Me.lblBakerCost)
        Me.Controls.Add(Me.lblMineCount)
        Me.Controls.Add(Me.lblFactoryCount)
        Me.Controls.Add(Me.lblFarmCount)
        Me.Controls.Add(Me.lblBakerCount)
        Me.Controls.Add(Me.btnMine)
        Me.Controls.Add(Me.btnFactory)
        Me.Controls.Add(Me.btnFarm)
        Me.Controls.Add(Me.btnBaker)
        Me.Controls.Add(Me.btnCookie)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.Name = "Form1"
        Me.Text = "0"
        CType(Me.picMine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFactory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBaker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCookie As System.Windows.Forms.Button
    Friend WithEvents btnBaker As System.Windows.Forms.Button
    Friend WithEvents btnFarm As System.Windows.Forms.Button
    Friend WithEvents btnFactory As System.Windows.Forms.Button
    Friend WithEvents btnMine As System.Windows.Forms.Button
    Friend WithEvents lblBakerCount As System.Windows.Forms.Label
    Friend WithEvents lblFarmCount As System.Windows.Forms.Label
    Friend WithEvents lblFactoryCount As System.Windows.Forms.Label
    Friend WithEvents lblMineCount As System.Windows.Forms.Label
    Friend WithEvents lblBakerCost As System.Windows.Forms.Label
    Friend WithEvents lblFarmCost As System.Windows.Forms.Label
    Friend WithEvents lblFactoryCost As System.Windows.Forms.Label
    Friend WithEvents lblMineCost As System.Windows.Forms.Label
    Friend WithEvents picBaker As System.Windows.Forms.PictureBox
    Friend WithEvents picFarm As System.Windows.Forms.PictureBox
    Friend WithEvents picFactory As System.Windows.Forms.PictureBox
    Friend WithEvents picMine As System.Windows.Forms.PictureBox
    Friend WithEvents lblNews As System.Windows.Forms.Label
    Friend WithEvents btnGold As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
