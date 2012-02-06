
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.DesignData = New System.Windows.Forms.DataGridView
		Me.ColumnImage = New System.Windows.Forms.DataGridViewImageColumn
		Me.ColumnCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ColumnDesign = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ColumnBackground = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ColumnOverlay = New System.Windows.Forms.DataGridViewTextBoxColumn
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
		CType(Me.DesignData,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'DesignData
		'
		Me.DesignData.AllowUserToAddRows = false
		Me.DesignData.AllowUserToDeleteRows = false
		Me.DesignData.BackgroundColor = System.Drawing.Color.White
		Me.DesignData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.DesignData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DesignData.ColumnHeadersVisible = false
		Me.DesignData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnImage, Me.ColumnCheckBox, Me.ColumnDesign, Me.ColumnBackground, Me.ColumnOverlay})
		Me.DesignData.GridColor = System.Drawing.SystemColors.ActiveCaption
		Me.DesignData.Location = New System.Drawing.Point(77, 74)
		Me.DesignData.MultiSelect = false
		Me.DesignData.Name = "DesignData"
		Me.DesignData.RowHeadersVisible = false
		Me.DesignData.RowTemplate.Height = 60
		Me.DesignData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DesignData.Size = New System.Drawing.Size(470, 286)
		Me.DesignData.TabIndex = 0
		AddHandler Me.DesignData.CellClick, AddressOf Me.DataGridView1_CellClick
		'
		'ColumnImage
		'
		Me.ColumnImage.HeaderText = "Image"
		Me.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
		Me.ColumnImage.Name = "ColumnImage"
		Me.ColumnImage.ReadOnly = true
		Me.ColumnImage.Width = 62
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
		Me.ColumnDesign.ReadOnly = true
		Me.ColumnDesign.Width = 240
		'
		'ColumnBackground
		'
		Me.ColumnBackground.HeaderText = "Background"
		Me.ColumnBackground.Name = "ColumnBackground"
		Me.ColumnBackground.ReadOnly = true
		Me.ColumnBackground.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ColumnBackground.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.ColumnBackground.Visible = false
		'
		'ColumnOverlay
		'
		Me.ColumnOverlay.HeaderText = "Overlay"
		Me.ColumnOverlay.Name = "ColumnOverlay"
		Me.ColumnOverlay.ReadOnly = true
		Me.ColumnOverlay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ColumnOverlay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.ColumnOverlay.Visible = false
		'
		'btNewDesign
		'
		Me.btNewDesign.Location = New System.Drawing.Point(354, 366)
		Me.btNewDesign.Name = "btNewDesign"
		Me.btNewDesign.Size = New System.Drawing.Size(73, 28)
		Me.btNewDesign.TabIndex = 1
		Me.btNewDesign.Text = "new"
		Me.btNewDesign.UseVisualStyleBackColor = true
		AddHandler Me.btNewDesign.Click, AddressOf Me.BtNewDesignClick
		'
		'buttonCreate
		'
		Me.buttonCreate.Location = New System.Drawing.Point(586, 440)
		Me.buttonCreate.Name = "buttonCreate"
		Me.buttonCreate.Size = New System.Drawing.Size(150, 55)
		Me.buttonCreate.TabIndex = 2
		Me.buttonCreate.Text = "create"
		Me.buttonCreate.UseVisualStyleBackColor = true
		AddHandler Me.buttonCreate.Click, AddressOf Me.ButtonCreateClick
		'
		'tbSourceLogo
		'
		Me.tbSourceLogo.Location = New System.Drawing.Point(103, 43)
		Me.tbSourceLogo.Name = "tbSourceLogo"
		Me.tbSourceLogo.Size = New System.Drawing.Size(369, 20)
		Me.tbSourceLogo.TabIndex = 3
		'
		'tbSavePath
		'
		Me.tbSavePath.Location = New System.Drawing.Point(60, 462)
		Me.tbSavePath.Name = "tbSavePath"
		Me.tbSavePath.Size = New System.Drawing.Size(270, 20)
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
		Me.groupBox3.Location = New System.Drawing.Point(627, 185)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(133, 163)
		Me.groupBox3.TabIndex = 22
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "Logo size"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(14, 31)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(41, 13)
		Me.label3.TabIndex = 19
		Me.label3.Text = "Height:"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(14, 129)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(38, 13)
		Me.label4.TabIndex = 20
		Me.label4.Text = "Offset:"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(14, 80)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(38, 13)
		Me.label2.TabIndex = 18
		Me.label2.Text = "Width:"
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
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(825, 527)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.tbSavePath)
		Me.Controls.Add(Me.tbSourceLogo)
		Me.Controls.Add(Me.buttonCreate)
		Me.Controls.Add(Me.btNewDesign)
		Me.Controls.Add(Me.DesignData)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MPLogoCreator"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.DesignData,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private tbOffset As System.Windows.Forms.TextBox
	Private tbHeight As System.Windows.Forms.TextBox
	Private tbWidth As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private tbSavePath As System.Windows.Forms.TextBox
	Private tbSourceLogo As System.Windows.Forms.TextBox
	Private buttonCreate As System.Windows.Forms.Button
	Private btNewDesign As System.Windows.Forms.Button
	Private DesignData As System.Windows.Forms.DataGridView
	Private ColumnOverlay As System.Windows.Forms.DataGridViewTextBoxColumn
	Private ColumnBackground As System.Windows.Forms.DataGridViewTextBoxColumn
	Private ColumnCheckBox As System.Windows.Forms.DataGridViewCheckBoxColumn
	Private ColumnDesign As System.Windows.Forms.DataGridViewTextBoxColumn
	Private ColumnImage As System.Windows.Forms.DataGridViewImageColumn
End Class
