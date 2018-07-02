<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.worldClockTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newTimerTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newTimerButton3 = New System.Windows.Forms.Button()
        Me.newTimerButton2 = New System.Windows.Forms.Button()
        Me.newTimerButton1 = New System.Windows.Forms.Button()
        Me.newTimerButton6 = New System.Windows.Forms.Button()
        Me.newTimerButton5 = New System.Windows.Forms.Button()
        Me.newTimerButton4 = New System.Windows.Forms.Button()
        Me.newTimerSecondsButton = New System.Windows.Forms.Button()
        Me.newTimerMinutesButton = New System.Windows.Forms.Button()
        Me.newTimerHoursButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.newTimerRichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.stopwatchTab = New System.Windows.Forms.TabPage()
        Me.aboutTab = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.themeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.newTimerAccept = New System.Windows.Forms.Button()
        Me.newTimerUpdateHMS = New System.Windows.Forms.Timer(Me.components)
        Me.newTimerCancel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.timerBackgroundButton1 = New System.Windows.Forms.Button()
        Me.timerTimerLabel1 = New System.Windows.Forms.Label()
        Me.timerTab = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.timerRight = New System.Windows.Forms.Button()
        Me.timerLeft = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.alarmsTab = New System.Windows.Forms.TabPage()
        Me.timerConvertMillisecondsToTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.worldClockTab.SuspendLayout()
        Me.newTimerTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.aboutTab.SuspendLayout()
        Me.timerTab.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.timerTab)
        Me.TabControl1.Controls.Add(Me.worldClockTab)
        Me.TabControl1.Controls.Add(Me.newTimerTab)
        Me.TabControl1.Controls.Add(Me.stopwatchTab)
        Me.TabControl1.Controls.Add(Me.aboutTab)
        Me.TabControl1.Controls.Add(Me.alarmsTab)
        Me.TabControl1.Location = New System.Drawing.Point(1, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1025, 548)
        Me.TabControl1.TabIndex = 0
        '
        'worldClockTab
        '
        Me.worldClockTab.Controls.Add(Me.Label1)
        Me.worldClockTab.Location = New System.Drawing.Point(4, 22)
        Me.worldClockTab.Name = "worldClockTab"
        Me.worldClockTab.Padding = New System.Windows.Forms.Padding(3)
        Me.worldClockTab.Size = New System.Drawing.Size(1017, 522)
        Me.worldClockTab.TabIndex = 1
        Me.worldClockTab.Text = "worldClockTab"
        Me.worldClockTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(897, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "under construction <3"
        '
        'newTimerTab
        '
        Me.newTimerTab.BackColor = System.Drawing.SystemColors.Control
        Me.newTimerTab.Controls.Add(Me.Button2)
        Me.newTimerTab.Controls.Add(Me.Panel1)
        Me.newTimerTab.Controls.Add(Me.Label8)
        Me.newTimerTab.Controls.Add(Me.Label7)
        Me.newTimerTab.Controls.Add(Me.Label6)
        Me.newTimerTab.Controls.Add(Me.Label5)
        Me.newTimerTab.Controls.Add(Me.Label4)
        Me.newTimerTab.Controls.Add(Me.newTimerButton3)
        Me.newTimerTab.Controls.Add(Me.newTimerButton2)
        Me.newTimerTab.Controls.Add(Me.newTimerButton1)
        Me.newTimerTab.Controls.Add(Me.newTimerButton6)
        Me.newTimerTab.Controls.Add(Me.newTimerButton5)
        Me.newTimerTab.Controls.Add(Me.newTimerButton4)
        Me.newTimerTab.Controls.Add(Me.newTimerSecondsButton)
        Me.newTimerTab.Controls.Add(Me.newTimerMinutesButton)
        Me.newTimerTab.Controls.Add(Me.newTimerHoursButton)
        Me.newTimerTab.Controls.Add(Me.Button1)
        Me.newTimerTab.Controls.Add(Me.newTimerRichTextBox1)
        Me.newTimerTab.Location = New System.Drawing.Point(4, 22)
        Me.newTimerTab.Name = "newTimerTab"
        Me.newTimerTab.Size = New System.Drawing.Size(1017, 522)
        Me.newTimerTab.TabIndex = 4
        Me.newTimerTab.Text = "newTimerTab"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.newTimerCancel)
        Me.Panel1.Controls.Add(Me.newTimerAccept)
        Me.Panel1.Location = New System.Drawing.Point(-17, 481)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 55)
        Me.Panel1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "NEW TIMER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Timer name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "seconds"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "hours"
        '
        'newTimerButton3
        '
        Me.newTimerButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton3.BackgroundImage = CType(resources.GetObject("newTimerButton3.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton3.FlatAppearance.BorderSize = 0
        Me.newTimerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton3.Location = New System.Drawing.Point(192, 37)
        Me.newTimerButton3.Name = "newTimerButton3"
        Me.newTimerButton3.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton3.TabIndex = 10
        Me.newTimerButton3.UseVisualStyleBackColor = False
        '
        'newTimerButton2
        '
        Me.newTimerButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton2.BackgroundImage = CType(resources.GetObject("newTimerButton2.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton2.FlatAppearance.BorderSize = 0
        Me.newTimerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton2.Location = New System.Drawing.Point(107, 37)
        Me.newTimerButton2.Name = "newTimerButton2"
        Me.newTimerButton2.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton2.TabIndex = 9
        Me.newTimerButton2.UseVisualStyleBackColor = False
        '
        'newTimerButton1
        '
        Me.newTimerButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton1.BackgroundImage = CType(resources.GetObject("newTimerButton1.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton1.FlatAppearance.BorderSize = 0
        Me.newTimerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton1.Location = New System.Drawing.Point(22, 37)
        Me.newTimerButton1.Name = "newTimerButton1"
        Me.newTimerButton1.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton1.TabIndex = 8
        Me.newTimerButton1.UseVisualStyleBackColor = False
        '
        'newTimerButton6
        '
        Me.newTimerButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton6.BackgroundImage = CType(resources.GetObject("newTimerButton6.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton6.FlatAppearance.BorderSize = 0
        Me.newTimerButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton6.Location = New System.Drawing.Point(192, 95)
        Me.newTimerButton6.Name = "newTimerButton6"
        Me.newTimerButton6.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton6.TabIndex = 7
        Me.newTimerButton6.UseVisualStyleBackColor = False
        '
        'newTimerButton5
        '
        Me.newTimerButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton5.BackgroundImage = CType(resources.GetObject("newTimerButton5.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton5.FlatAppearance.BorderSize = 0
        Me.newTimerButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton5.Location = New System.Drawing.Point(107, 95)
        Me.newTimerButton5.Name = "newTimerButton5"
        Me.newTimerButton5.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton5.TabIndex = 6
        Me.newTimerButton5.UseVisualStyleBackColor = False
        '
        'newTimerButton4
        '
        Me.newTimerButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerButton4.BackgroundImage = CType(resources.GetObject("newTimerButton4.BackgroundImage"), System.Drawing.Image)
        Me.newTimerButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerButton4.FlatAppearance.BorderSize = 0
        Me.newTimerButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerButton4.Location = New System.Drawing.Point(22, 95)
        Me.newTimerButton4.Name = "newTimerButton4"
        Me.newTimerButton4.Size = New System.Drawing.Size(86, 30)
        Me.newTimerButton4.TabIndex = 5
        Me.newTimerButton4.UseVisualStyleBackColor = False
        '
        'newTimerSecondsButton
        '
        Me.newTimerSecondsButton.BackColor = System.Drawing.Color.SkyBlue
        Me.newTimerSecondsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerSecondsButton.FlatAppearance.BorderSize = 0
        Me.newTimerSecondsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerSecondsButton.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTimerSecondsButton.Location = New System.Drawing.Point(192, 66)
        Me.newTimerSecondsButton.Name = "newTimerSecondsButton"
        Me.newTimerSecondsButton.Size = New System.Drawing.Size(86, 30)
        Me.newTimerSecondsButton.TabIndex = 4
        Me.newTimerSecondsButton.Text = "00"
        Me.newTimerSecondsButton.UseVisualStyleBackColor = False
        '
        'newTimerMinutesButton
        '
        Me.newTimerMinutesButton.BackColor = System.Drawing.Color.SkyBlue
        Me.newTimerMinutesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerMinutesButton.FlatAppearance.BorderSize = 0
        Me.newTimerMinutesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerMinutesButton.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTimerMinutesButton.Location = New System.Drawing.Point(107, 66)
        Me.newTimerMinutesButton.Name = "newTimerMinutesButton"
        Me.newTimerMinutesButton.Size = New System.Drawing.Size(86, 30)
        Me.newTimerMinutesButton.TabIndex = 3
        Me.newTimerMinutesButton.Text = "00"
        Me.newTimerMinutesButton.UseVisualStyleBackColor = False
        '
        'newTimerHoursButton
        '
        Me.newTimerHoursButton.BackColor = System.Drawing.Color.SkyBlue
        Me.newTimerHoursButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerHoursButton.FlatAppearance.BorderSize = 0
        Me.newTimerHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerHoursButton.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTimerHoursButton.Location = New System.Drawing.Point(22, 66)
        Me.newTimerHoursButton.Name = "newTimerHoursButton"
        Me.newTimerHoursButton.Size = New System.Drawing.Size(86, 30)
        Me.newTimerHoursButton.TabIndex = 2
        Me.newTimerHoursButton.Text = "0"
        Me.newTimerHoursButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(259, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'newTimerRichTextBox1
        '
        Me.newTimerRichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.newTimerRichTextBox1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTimerRichTextBox1.Location = New System.Drawing.Point(22, 178)
        Me.newTimerRichTextBox1.MaxLength = 25
        Me.newTimerRichTextBox1.Multiline = False
        Me.newTimerRichTextBox1.Name = "newTimerRichTextBox1"
        Me.newTimerRichTextBox1.Size = New System.Drawing.Size(256, 25)
        Me.newTimerRichTextBox1.TabIndex = 0
        Me.newTimerRichTextBox1.Text = " Timer"
        '
        'stopwatchTab
        '
        Me.stopwatchTab.Location = New System.Drawing.Point(4, 22)
        Me.stopwatchTab.Name = "stopwatchTab"
        Me.stopwatchTab.Padding = New System.Windows.Forms.Padding(3)
        Me.stopwatchTab.Size = New System.Drawing.Size(1017, 522)
        Me.stopwatchTab.TabIndex = 3
        Me.stopwatchTab.Text = "stopwatchTab"
        Me.stopwatchTab.UseVisualStyleBackColor = True
        '
        'aboutTab
        '
        Me.aboutTab.Controls.Add(Me.Button5)
        Me.aboutTab.Controls.Add(Me.Button3)
        Me.aboutTab.Controls.Add(Me.Label11)
        Me.aboutTab.Controls.Add(Me.Label10)
        Me.aboutTab.Controls.Add(Me.Button12)
        Me.aboutTab.Controls.Add(Me.Label3)
        Me.aboutTab.Controls.Add(Me.Button11)
        Me.aboutTab.Controls.Add(Me.Label2)
        Me.aboutTab.Location = New System.Drawing.Point(4, 22)
        Me.aboutTab.Name = "aboutTab"
        Me.aboutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.aboutTab.Size = New System.Drawing.Size(1017, 522)
        Me.aboutTab.TabIndex = 5
        Me.aboutTab.Text = "aboutTab"
        Me.aboutTab.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.LightGray
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(107, 69)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(99, 30)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "License"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Created with <3 by Cloud OS"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightGray
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(14, 69)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(87, 30)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Credits"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "About"
        '
        'newTimerAccept
        '
        Me.newTimerAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newTimerAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerAccept.BackgroundImage = CType(resources.GetObject("newTimerAccept.BackgroundImage"), System.Drawing.Image)
        Me.newTimerAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerAccept.FlatAppearance.BorderSize = 0
        Me.newTimerAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerAccept.Location = New System.Drawing.Point(965, 3)
        Me.newTimerAccept.Name = "newTimerAccept"
        Me.newTimerAccept.Size = New System.Drawing.Size(31, 34)
        Me.newTimerAccept.TabIndex = 17
        Me.newTimerAccept.UseVisualStyleBackColor = False
        '
        'newTimerUpdateHMS
        '
        Me.newTimerUpdateHMS.Enabled = True
        Me.newTimerUpdateHMS.Interval = 10
        '
        'newTimerCancel
        '
        Me.newTimerCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newTimerCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.newTimerCancel.BackgroundImage = CType(resources.GetObject("newTimerCancel.BackgroundImage"), System.Drawing.Image)
        Me.newTimerCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.newTimerCancel.FlatAppearance.BorderSize = 0
        Me.newTimerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTimerCancel.Location = New System.Drawing.Point(928, 3)
        Me.newTimerCancel.Name = "newTimerCancel"
        Me.newTimerCancel.Size = New System.Drawing.Size(31, 34)
        Me.newTimerCancel.TabIndex = 18
        Me.newTimerCancel.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 30)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Select Timer Slot"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer11
        '
        Me.Timer11.Interval = 1
        '
        'timerBackgroundButton1
        '
        Me.timerBackgroundButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timerBackgroundButton1.BackColor = System.Drawing.Color.Silver
        Me.timerBackgroundButton1.FlatAppearance.BorderSize = 0
        Me.timerBackgroundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.timerBackgroundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.timerBackgroundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timerBackgroundButton1.Location = New System.Drawing.Point(230, 56)
        Me.timerBackgroundButton1.Name = "timerBackgroundButton1"
        Me.timerBackgroundButton1.Size = New System.Drawing.Size(557, 410)
        Me.timerBackgroundButton1.TabIndex = 1
        Me.timerBackgroundButton1.UseVisualStyleBackColor = False
        '
        'timerTimerLabel1
        '
        Me.timerTimerLabel1.AutoSize = True
        Me.timerTimerLabel1.Font = New System.Drawing.Font("Open Sans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerTimerLabel1.Location = New System.Drawing.Point(223, 14)
        Me.timerTimerLabel1.Name = "timerTimerLabel1"
        Me.timerTimerLabel1.Size = New System.Drawing.Size(131, 39)
        Me.timerTimerLabel1.TabIndex = 2
        Me.timerTimerLabel1.Text = "TIMER 1"
        '
        'timerTab
        '
        Me.timerTab.Controls.Add(Me.Button6)
        Me.timerTab.Controls.Add(Me.RichTextBox1)
        Me.timerTab.Controls.Add(Me.timerLeft)
        Me.timerTab.Controls.Add(Me.timerRight)
        Me.timerTab.Controls.Add(Me.Panel2)
        Me.timerTab.Controls.Add(Me.timerTimerLabel1)
        Me.timerTab.Controls.Add(Me.timerBackgroundButton1)
        Me.timerTab.Location = New System.Drawing.Point(4, 22)
        Me.timerTab.Name = "timerTab"
        Me.timerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.timerTab.Size = New System.Drawing.Size(1017, 522)
        Me.timerTab.TabIndex = 0
        Me.timerTab.Text = "timerTab"
        Me.timerTab.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Location = New System.Drawing.Point(-17, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 55)
        Me.Panel2.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(993, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 34)
        Me.Button4.TabIndex = 17
        Me.Button4.UseVisualStyleBackColor = False
        '
        'timerRight
        '
        Me.timerRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timerRight.BackColor = System.Drawing.Color.Transparent
        Me.timerRight.BackgroundImage = CType(resources.GetObject("timerRight.BackgroundImage"), System.Drawing.Image)
        Me.timerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.timerRight.FlatAppearance.BorderSize = 0
        Me.timerRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timerRight.Location = New System.Drawing.Point(976, 222)
        Me.timerRight.Name = "timerRight"
        Me.timerRight.Size = New System.Drawing.Size(31, 34)
        Me.timerRight.TabIndex = 18
        Me.timerRight.UseVisualStyleBackColor = False
        '
        'timerLeft
        '
        Me.timerLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timerLeft.BackColor = System.Drawing.Color.Transparent
        Me.timerLeft.BackgroundImage = CType(resources.GetObject("timerLeft.BackgroundImage"), System.Drawing.Image)
        Me.timerLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.timerLeft.FlatAppearance.BorderSize = 0
        Me.timerLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.timerLeft.Location = New System.Drawing.Point(7, 222)
        Me.timerLeft.Name = "timerLeft"
        Me.timerLeft.Size = New System.Drawing.Size(31, 34)
        Me.timerLeft.TabIndex = 19
        Me.timerLeft.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Open Sans Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 33)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Options"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(267, 26)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Launch on startup (for alarms)"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(107, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGray
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(14, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 30)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'alarmsTab
        '
        Me.alarmsTab.Location = New System.Drawing.Point(4, 22)
        Me.alarmsTab.Name = "alarmsTab"
        Me.alarmsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.alarmsTab.Size = New System.Drawing.Size(1017, 522)
        Me.alarmsTab.TabIndex = 6
        Me.alarmsTab.Text = "alarmsTab"
        Me.alarmsTab.UseVisualStyleBackColor = True
        '
        'timerConvertMillisecondsToTimeTimer
        '
        Me.timerConvertMillisecondsToTimeTimer.Interval = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Silver
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.DetectUrls = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Open Sans", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(230, 197)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(557, 96)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = "0:00:00"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(493, 324)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(31, 34)
        Me.Button6.TabIndex = 18
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 575)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1040, 614)
        Me.Name = "Form1"
        Me.Text = "Alarms & Clock"
        Me.TabControl1.ResumeLayout(False)
        Me.worldClockTab.ResumeLayout(False)
        Me.worldClockTab.PerformLayout()
        Me.newTimerTab.ResumeLayout(False)
        Me.newTimerTab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.aboutTab.ResumeLayout(False)
        Me.aboutTab.PerformLayout()
        Me.timerTab.ResumeLayout(False)
        Me.timerTab.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents worldClockTab As TabPage
    Friend WithEvents stopwatchTab As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents newTimerTab As TabPage
    Friend WithEvents themeTimer As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents newTimerButton3 As Button
    Friend WithEvents newTimerButton2 As Button
    Friend WithEvents newTimerButton1 As Button
    Friend WithEvents newTimerButton6 As Button
    Friend WithEvents newTimerButton5 As Button
    Friend WithEvents newTimerButton4 As Button
    Friend WithEvents newTimerSecondsButton As Button
    Friend WithEvents newTimerMinutesButton As Button
    Friend WithEvents newTimerHoursButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents newTimerRichTextBox1 As RichTextBox
    Friend WithEvents aboutTab As TabPage
    Friend WithEvents Button12 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents newTimerAccept As Button
    Friend WithEvents newTimerUpdateHMS As Timer
    Friend WithEvents newTimerCancel As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer11 As Timer
    Friend WithEvents timerTab As TabPage
    Friend WithEvents timerTimerLabel1 As Label
    Friend WithEvents timerBackgroundButton1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents timerLeft As Button
    Friend WithEvents timerRight As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents alarmsTab As TabPage
    Friend WithEvents timerConvertMillisecondsToTimeTimer As Timer
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button6 As Button
End Class
