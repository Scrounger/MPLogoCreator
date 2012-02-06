Imports MPLogoCreator.MainForm

Public Partial Class NewDesign
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtBackClick(sender As Object, e As EventArgs)
		me.tbDesignName.Clear
		Me.Close
		
	End Sub
	
	Sub BtSaveDesignClick(sender As Object, e As EventArgs)
		
		Dim _NewPath as String = application.StartupPath & "\Design\" & Me.tbDesignName.Text	
		
		If io.Directory.Exists(_newpath) = False Then
			io.Directory.CreateDirectory(_newpath)
			io.File.Copy(Me.picBackground.Tag, _NewPath & "\background.png")
			io.File.Copy(Me.picOverlay.Tag, _NewPath & "\overlay.png")
			
			Me.picPreview.Image.Save(_NewPath & "\sample.png")
			MainForm.LoadAvailableDesigns
			me.tbDesignName.Clear
			
			me.Close
		Else
			Dim antwort As DialogResult
			antwort = msgbox("Design name still exist!" & vbnewline & vbnewline & "Would you like to overwirte the design", MsgBoxStyle.Question + msgboxstyle.YesNo,"Delete Design?")
			If antwort = vbyes Then
						
				io.Directory.CreateDirectory(_newpath)
							
'				io.File.Copy(Me.picBackground.Tag, _NewPath & "\background.png",true)
'				io.File.Copy(Me.picOverlay.Tag, _NewPath & "\overlay.png",true)
				
				Me.picBackground.Image.Save(_NewPath & "\background.png")
				Me.picoverlay.Image.Save(_NewPath & "\overlay.png")
				Me.picPreview.Image.Save(_NewPath & "\sample.png")
				MainForm.LoadAvailableDesigns
				me.tbDesignName.Clear
												
			Else
				Me.Close
			End If
		End If
		
	End Sub


	Sub NewDesignLoad(sender As Object, e As EventArgs)
		Dim imgStream As New IO.MemoryStream
			
		if string.IsNullOrEmpty(me.picBackground.Tag) then
			CreateCloneImage(application.StartupPath & "\Source\transparent.png").Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
			Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
			Me.picBackground.Tag = application.StartupPath & "\Source\transparent.png"
		Else
			CreateCloneImage(Me.picBackground.Tag).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
			Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
		End If
		     	
       	If String.IsNullOrEmpty(Me.picOverlay.Tag) Then
       		CreateCloneImage(application.StartupPath & "\Source\transparent.png").Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
	       	Me.picOverlay.Image = System.Drawing.Image.FromStream(imgStream)
	       	Me.picOverlay.Tag = application.StartupPath & "\Source\transparent.png"
       	Else
       		CreateCloneImage(Me.picOverlay.Tag).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
       		Me.picOverlay.Image = System.Drawing.Image.FromStream(imgStream)
       	End If
       	
       	Me.picBackground.SizeMode = PictureBoxSizeMode.CenterImage
       	Me.picBackground.SizeMode = PictureBoxSizeMode.Zoom
       	Me.picOverlay.SizeMode = PictureBoxSizeMode.CenterImage
       	Me.picOverlay.SizeMode = PictureBoxSizeMode.Zoom
       	
       	Me.tbHeight.Text = 200
       	Me.tbWidth.Text = 200
       	Me.tbOffset.Text = 6
       	
       	imgstream.Dispose
       	
       	CreatePreviewImage
	End Sub
	
Private Sub CreatePreviewImage
	    Dim imgStream As New IO.MemoryStream
	    
	    CreateCloneImage(me.picBackground.Tag).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)       	    
	    Dim LayerBG As Image = System.Drawing.Image.FromStream(imgStream)
	    
	    CreateCloneImage(application.StartupPath & "\Source\sampleLogo.png").Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)   	    	    
		Dim Logo As Image = System.Drawing.Image.FromStream(imgStream)
		
		CreateCloneImage(me.picOverlay.Tag).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)   	    	    
		Dim LayerOverlay As Image = Bitmap.FromFile(me.picOverlay.Tag)
		                    
		Dim b As New Bitmap(CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))
		Dim g As Graphics = Graphics.FromImage(b)
		g.DrawImage(LayerBG, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))
		g.DrawImage(Logo, cint(me.tbOffset.Text), cint(me.tbOffset.Text),CInt(Me.tbWidth.Text)- 2* cint(me.tbOffset.Text), CInt(Me.tbHeight.text)- 2* cint(me.tbOffset.Text))
		g.DrawImage(LayerOverlay, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))        		

		b.Save(imgStream, system.Drawing.Imaging.ImageFormat.Png)
		
'		Me.picPreview.image.FromStream(imgStream)
		Me.picPreview.Image = System.Drawing.Image.FromStream(imgStream)
		Me.picPreview.SizeMode = PictureBoxSizeMode.CenterImage
       	Me.picPreview.SizeMode = PictureBoxSizeMode.Zoom
		
		layerbg.Dispose
		logo.Dispose
		layeroverlay.Dispose
		
		b.Dispose
		g.Dispose
		imgstream.Dispose
End Sub
	
	Sub BtBrowseBackgroundClick(sender As Object, e As EventArgs)
	
		Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image (*.png) |*.png;"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then
        	Dim imgStream As New IO.MemoryStream
        	
        	CreateCloneImage(_openFileDialog.FileName).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
        	
        	Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
        	me.picBackground.Tag = _openFileDialog.FileName
        	Me.picBackground.SizeMode = PictureBoxSizeMode.CenterImage
       		Me.picBackground.SizeMode = PictureBoxSizeMode.Zoom
			
			imgStream.Dispose
						
			CreatePreviewImage
        End If
	End Sub
	
	Sub BtBrowseOverlayClick(sender As Object, e As EventArgs)
		
		Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image (*.png) |*.png;"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then
        	Dim imgStream As New IO.MemoryStream
        	
        	CreateCloneImage(_openFileDialog.FileName).Save(imgStream,system.Drawing.Imaging.ImageFormat.Png)
        	
        	Me.picoverlay.Image = System.Drawing.Image.FromStream(imgStream)
        	me.picOverlay.Tag = _openFileDialog.FileName
        	Me.picOverlay.SizeMode = PictureBoxSizeMode.CenterImage
       		Me.picOverlay.SizeMode = PictureBoxSizeMode.Zoom

			imgStream.Dispose
			
			CreatePreviewImage
        End If
        
	End Sub
	
	Sub BtRefreshClick(sender As Object, e As EventArgs)
		CreatePreviewImage
	End Sub
	
End Class
