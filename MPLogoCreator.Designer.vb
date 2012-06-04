
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
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
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DesignData = New System.Windows.Forms.DataGridView
        Me.btNewDesign = New System.Windows.Forms.Button
        Me.buttonCreate = New System.Windows.Forms.Button
        Me.tbSourceLogo = New System.Windows.Forms.TextBox
        Me.tbSavePath = New System.Windows.Forms.TextBox
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.tbWidth = New System.Windows.Forms.TextBox
        Me.tbHeight = New System.Windows.Forms.TextBox
        Me.tbOffset = New System.Windows.Forms.TextBox
        Me.CheckBoxSelector = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.ProgressLabel = New System.Windows.Forms.Label
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tbSourceRadio = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbSourceTv = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RBdesign = New System.Windows.Forms.RadioButton
        Me.RBtvRadio = New System.Windows.Forms.RadioButton
        Me.ColumnImage = New System.Windows.Forms.DataGridViewImageColumn
        Me.ColumnCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ColumnDesign = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBackground = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnOverlay = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DesignData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DesignData
        '
        Me.DesignData.AllowUserToAddRows = False
        Me.DesignData.AllowUserToDeleteRows = False
        Me.DesignData.AllowUserToResizeColumns = False
        Me.DesignData.AllowUserToResizeRows = False
        Me.DesignData.BackgroundColor = System.Drawing.Color.White
        Me.DesignData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DesignData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DesignData.ColumnHeadersVisible = False
        Me.DesignData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnImage, Me.ColumnCheckBox, Me.ColumnDesign, Me.ColumnBackground, Me.ColumnOverlay})
        Me.DesignData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DesignData.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DesignData.Location = New System.Drawing.Point(9, 19)
        Me.DesignData.MultiSelect = False
        Me.DesignData.Name = "DesignData"
        Me.DesignData.RowHeadersVisible = False
        Me.DesignData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DesignData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DesignData.RowTemplate.Height = 100
        Me.DesignData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DesignData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DesignData.Size = New System.Drawing.Size(590, 300)
        Me.DesignData.TabIndex = 0
        '
        'btNewDesign
        '
        Me.btNewDesign.Location = New System.Drawing.Point(481, 325)
        Me.btNewDesign.Name = "btNewDesign"
        Me.btNewDesign.Size = New System.Drawing.Size(118, 28)
        Me.btNewDesign.TabIndex = 1
        Me.btNewDesign.Text = "Create new design"
        Me.btNewDesign.UseVisualStyleBackColor = True
        '
        'buttonCreate
        '
        Me.buttonCreate.Location = New System.Drawing.Point(478, 675)
        Me.buttonCreate.Name = "buttonCreate"
        Me.buttonCreate.Size = New System.Drawing.Size(133, 45)
        Me.buttonCreate.TabIndex = 2
        Me.buttonCreate.Text = "create"
        Me.buttonCreate.UseVisualStyleBackColor = True
        '
        'tbSourceLogo
        '
        Me.tbSourceLogo.Location = New System.Drawing.Point(78, 28)
        Me.tbSourceLogo.Name = "tbSourceLogo"
        Me.tbSourceLogo.Size = New System.Drawing.Size(379, 20)
        Me.tbSourceLogo.TabIndex = 3
        '
        'tbSavePath
        '
        Me.tbSavePath.Location = New System.Drawing.Point(78, 151)
        Me.tbSavePath.Name = "tbSavePath"
        Me.tbSavePath.Size = New System.Drawing.Size(379, 20)
        Me.tbSavePath.TabIndex = 4
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.label2)
        Me.groupBox3.Controls.Add(Me.tbWidth)
        Me.groupBox3.Controls.Add(Me.tbHeight)
        Me.groupBox3.Controls.Add(Me.tbOffset)
        Me.groupBox3.Location = New System.Drawing.Point(481, 569)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(130, 100)
        Me.groupBox3.TabIndex = 22
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Logo size"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 25)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Height:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(9, 77)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Offset:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 51)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Width:"
        '
        'tbWidth
        '
        Me.tbWidth.Location = New System.Drawing.Point(56, 22)
        Me.tbWidth.Name = "tbWidth"
        Me.tbWidth.Size = New System.Drawing.Size(57, 20)
        Me.tbWidth.TabIndex = 9
        Me.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbHeight
        '
        Me.tbHeight.Location = New System.Drawing.Point(56, 48)
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(57, 20)
        Me.tbHeight.TabIndex = 10
        Me.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbOffset
        '
        Me.tbOffset.Location = New System.Drawing.Point(56, 74)
        Me.tbOffset.Name = "tbOffset"
        Me.tbOffset.Size = New System.Drawing.Size(57, 20)
        Me.tbOffset.TabIndex = 11
        Me.tbOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBoxSelector
        '
        Me.CheckBoxSelector.AutoSize = True
        Me.CheckBoxSelector.Location = New System.Drawing.Point(342, 332)
        Me.CheckBoxSelector.Name = "CheckBoxSelector"
        Me.CheckBoxSelector.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxSelector.TabIndex = 23
        Me.CheckBoxSelector.Text = "Select all / deselect all"
        Me.CheckBoxSelector.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(5, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Source path:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Save path:"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 675)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(463, 23)
        Me.ProgressBar.TabIndex = 26
        '
        'ProgressLabel
        '
        Me.ProgressLabel.Location = New System.Drawing.Point(12, 701)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(459, 19)
        Me.ProgressLabel.TabIndex = 27
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.Location = New System.Drawing.Point(-9, -5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(650, 119)
        Me.pictureBox1.TabIndex = 28
        Me.pictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DesignData)
        Me.GroupBox1.Controls.Add(Me.btNewDesign)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSelector)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 360)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Logo designs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbSourceRadio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbSourceTv)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbSourceLogo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbSavePath)
        Me.GroupBox2.Controls.Add(Me.label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 486)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 183)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Directories"
        '
        'tbSourceRadio
        '
        Me.tbSourceRadio.Location = New System.Drawing.Point(78, 109)
        Me.tbSourceRadio.Name = "tbSourceRadio"
        Me.tbSourceRadio.Size = New System.Drawing.Size(379, 20)
        Me.tbSourceRadio.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Source radio:"
        '
        'tbSourceTv
        '
        Me.tbSourceTv.Location = New System.Drawing.Point(78, 69)
        Me.tbSourceTv.Name = "tbSourceTv"
        Me.tbSourceTv.Size = New System.Drawing.Size(379, 20)
        Me.tbSourceTv.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Source tv:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RBdesign)
        Me.GroupBox4.Controls.Add(Me.RBtvRadio)
        Me.GroupBox4.Location = New System.Drawing.Point(481, 486)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(130, 74)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Folder structure"
        '
        'RBdesign
        '
        Me.RBdesign.AutoSize = True
        Me.RBdesign.Location = New System.Drawing.Point(12, 52)
        Me.RBdesign.Name = "RBdesign"
        Me.RBdesign.Size = New System.Drawing.Size(87, 17)
        Me.RBdesign.TabIndex = 2
        Me.RBdesign.Text = "Design name"
        Me.RBdesign.UseVisualStyleBackColor = True
        '
        'RBtvRadio
        '
        Me.RBtvRadio.AutoSize = True
        Me.RBtvRadio.Location = New System.Drawing.Point(12, 23)
        Me.RBtvRadio.Name = "RBtvRadio"
        Me.RBtvRadio.Size = New System.Drawing.Size(113, 17)
        Me.RBtvRadio.TabIndex = 0
        Me.RBtvRadio.Text = "MediaPortal thumb"
        Me.RBtvRadio.UseVisualStyleBackColor = True
        '
        'ColumnImage
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        Me.ColumnImage.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColumnImage.HeaderText = "Image"
        Me.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColumnImage.Name = "ColumnImage"
        Me.ColumnImage.ReadOnly = True
        '
        'ColumnCheckBox
        '
        Me.ColumnCheckBox.HeaderText = "Enable"
        Me.ColumnCheckBox.Name = "ColumnCheckBox"
        Me.ColumnCheckBox.Width = 30
        '
        'ColumnDesign
        '
        Me.ColumnDesign.HeaderText = "Design"
        Me.ColumnDesign.Name = "ColumnDesign"
        Me.ColumnDesign.ReadOnly = True
        Me.ColumnDesign.Width = 240
        '
        'ColumnBackground
        '
        Me.ColumnBackground.HeaderText = "Background"
        Me.ColumnBackground.Name = "ColumnBackground"
        Me.ColumnBackground.ReadOnly = True
        Me.ColumnBackground.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnBackground.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnBackground.Visible = False
        '
        'ColumnOverlay
        '
        Me.ColumnOverlay.HeaderText = "Overlay"
        Me.ColumnOverlay.Name = "ColumnOverlay"
        Me.ColumnOverlay.ReadOnly = True
        Me.ColumnOverlay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnOverlay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColumnOverlay.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 726)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.buttonCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MPLogoCreator"
        CType(Me.DesignData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tbOffset As System.Windows.Forms.TextBox
    Private WithEvents tbHeight As System.Windows.Forms.TextBox
    Private WithEvents tbWidth As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents tbSavePath As System.Windows.Forms.TextBox
    Private WithEvents tbSourceLogo As System.Windows.Forms.TextBox
    Private WithEvents buttonCreate As System.Windows.Forms.Button
    Private WithEvents btNewDesign As System.Windows.Forms.Button
    Private WithEvents DesignData As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxSelector As System.Windows.Forms.CheckBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RBdesign As System.Windows.Forms.RadioButton
    Friend WithEvents RBtvRadio As System.Windows.Forms.RadioButton
    Private WithEvents tbSourceTv As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents tbSourceRadio As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColumnCheckBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColumnDesign As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBackground As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnOverlay As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
