
Partial Class NewDesign
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewDesign))
        Me.btSaveDesign = New System.Windows.Forms.Button
        Me.btBack = New System.Windows.Forms.Button
        Me.tbDesignName = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.picBackground = New System.Windows.Forms.PictureBox
        Me.picOverlay = New System.Windows.Forms.PictureBox
        Me.picPreview = New System.Windows.Forms.PictureBox
        Me.tbWidth = New System.Windows.Forms.TextBox
        Me.tbHeight = New System.Windows.Forms.TextBox
        Me.tbOffset = New System.Windows.Forms.TextBox
        Me.btBrowseBackground = New System.Windows.Forms.Button
        Me.btBrowseOverlay = New System.Windows.Forms.Button
        Me.btRefresh = New System.Windows.Forms.Button
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.groupBox4 = New System.Windows.Forms.GroupBox
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSaveDesign
        '
        Me.btSaveDesign.Location = New System.Drawing.Point(262, 129)
        Me.btSaveDesign.Name = "btSaveDesign"
        Me.btSaveDesign.Size = New System.Drawing.Size(73, 25)
        Me.btSaveDesign.TabIndex = 2
        Me.btSaveDesign.Text = "Save"
        Me.btSaveDesign.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(341, 129)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(73, 25)
        Me.btBack.TabIndex = 3
        Me.btBack.Text = "Cancel"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'tbDesignName
        '
        Me.tbDesignName.Location = New System.Drawing.Point(149, 45)
        Me.tbDesignName.Name = "tbDesignName"
        Me.tbDesignName.Size = New System.Drawing.Size(265, 20)
        Me.tbDesignName.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(147, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Design name:"
        '
        'picBackground
        '
        Me.picBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBackground.Location = New System.Drawing.Point(17, 23)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(100, 100)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBackground.TabIndex = 6
        Me.picBackground.TabStop = False
        '
        'picOverlay
        '
        Me.picOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOverlay.Location = New System.Drawing.Point(16, 23)
        Me.picOverlay.Name = "picOverlay"
        Me.picOverlay.Size = New System.Drawing.Size(100, 100)
        Me.picOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOverlay.TabIndex = 7
        Me.picOverlay.TabStop = False
        '
        'picPreview
        '
        Me.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreview.Location = New System.Drawing.Point(17, 23)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(100, 100)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPreview.TabIndex = 8
        Me.picPreview.TabStop = False
        '
        'tbWidth
        '
        Me.tbWidth.Location = New System.Drawing.Point(61, 28)
        Me.tbWidth.Name = "tbWidth"
        Me.tbWidth.Size = New System.Drawing.Size(55, 20)
        Me.tbWidth.TabIndex = 9
        Me.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbHeight
        '
        Me.tbHeight.Location = New System.Drawing.Point(61, 77)
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(55, 20)
        Me.tbHeight.TabIndex = 10
        Me.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbOffset
        '
        Me.tbOffset.Location = New System.Drawing.Point(61, 126)
        Me.tbOffset.Name = "tbOffset"
        Me.tbOffset.Size = New System.Drawing.Size(55, 20)
        Me.tbOffset.TabIndex = 11
        Me.tbOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btBrowseBackground
        '
        Me.btBrowseBackground.Location = New System.Drawing.Point(17, 129)
        Me.btBrowseBackground.Name = "btBrowseBackground"
        Me.btBrowseBackground.Size = New System.Drawing.Size(100, 25)
        Me.btBrowseBackground.TabIndex = 12
        Me.btBrowseBackground.Text = "Open Image"
        Me.btBrowseBackground.UseVisualStyleBackColor = True
        '
        'btBrowseOverlay
        '
        Me.btBrowseOverlay.Location = New System.Drawing.Point(16, 129)
        Me.btBrowseOverlay.Name = "btBrowseOverlay"
        Me.btBrowseOverlay.Size = New System.Drawing.Size(100, 25)
        Me.btBrowseOverlay.TabIndex = 13
        Me.btBrowseOverlay.Text = "Open Image"
        Me.btBrowseOverlay.UseVisualStyleBackColor = True
        '
        'btRefresh
        '
        Me.btRefresh.Location = New System.Drawing.Point(17, 129)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(100, 25)
        Me.btRefresh.TabIndex = 14
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.Location = New System.Drawing.Point(-3, -5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(461, 82)
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.picBackground)
        Me.groupBox1.Controls.Add(Me.btBrowseBackground)
        Me.groupBox1.Location = New System.Drawing.Point(12, 84)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(133, 163)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Background layer"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.picOverlay)
        Me.groupBox2.Controls.Add(Me.btBrowseOverlay)
        Me.groupBox2.Location = New System.Drawing.Point(161, 84)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(133, 163)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Overlay layer"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Width:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 31)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Height:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(14, 129)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Offset:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Controls.Add(Me.tbWidth)
        Me.groupBox3.Controls.Add(Me.tbHeight)
        Me.groupBox3.Controls.Add(Me.tbOffset)
        Me.groupBox3.Location = New System.Drawing.Point(310, 84)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(133, 163)
        Me.groupBox3.TabIndex = 21
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Logo size"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.picPreview)
        Me.groupBox4.Controls.Add(Me.btRefresh)
        Me.groupBox4.Controls.Add(Me.tbDesignName)
        Me.groupBox4.Controls.Add(Me.label1)
        Me.groupBox4.Controls.Add(Me.btSaveDesign)
        Me.groupBox4.Controls.Add(Me.btBack)
        Me.groupBox4.Location = New System.Drawing.Point(12, 260)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(431, 163)
        Me.groupBox4.TabIndex = 22
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Create new Design"
        '
        'NewDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 432)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NewDesign"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create a new design"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents btRefresh As System.Windows.Forms.Button
    Private WithEvents btBrowseOverlay As System.Windows.Forms.Button
    Private WithEvents btBrowseBackground As System.Windows.Forms.Button
    Private WithEvents tbOffset As System.Windows.Forms.TextBox
    Private WithEvents tbHeight As System.Windows.Forms.TextBox
    Private WithEvents tbWidth As System.Windows.Forms.TextBox
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Public WithEvents picOverlay As System.Windows.Forms.PictureBox
    Public WithEvents picBackground As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents tbDesignName As System.Windows.Forms.TextBox
    Private WithEvents btBack As System.Windows.Forms.Button
    Private WithEvents btSaveDesign As System.Windows.Forms.Button
End Class
