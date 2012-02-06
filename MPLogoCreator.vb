
Imports System.Threading

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		Dim _EditButton As New DataGridViewButtonColumn
		
		with _editbutton
			.DefaultCellStyle.Padding = new Padding(5,20,5,20)
			.HeaderText = "Edit"
			.Text = "Edit"
			.Name = "Edit"
			.FlatStyle = flatstyle.flat
			.UseColumnTextForButtonValue = True
			'_editbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
			.Width = 60
		End With

		Dim _DeleteButton As New DataGridViewButtonColumn
		
		with _DeleteButton
			.DefaultCellStyle.Padding = new Padding(5,20,5,20)
			.HeaderText = "Delete"
			.Text = "Delete"
			.Name = "Delete"
			.FlatStyle = flatstyle.flat
			.UseColumnTextForButtonValue = True
			'_editbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
			.Width = 60
		End With

		Me.DesignData.Columns.Add(_Editbutton)
		Me.DesignData.Columns.Add(_DeleteButton)
		
		Me.tbHeight.Text = 200
       	Me.tbWidth.Text = 200
       	Me.tbOffset.Text = 6
		
		LoadAvailableDesigns
	End Sub
	
	public Sub LoadAvailableDesigns
		
		'DesignData mit allen Unterordnern füllen
       	me.DesignData.Rows.Clear
       	
       	Dim _oDir As New System.IO.DirectoryInfo(application.StartupPath & "\Design")
		Dim i As Integer = 0		
	
		For Each Dir As System.IO.DirectoryInfo In _odir.GetDirectories
					
			Me.DesignData.Rows.Add(CreateCloneImage(dir.fullname & "\sample.png"),false,dir.Name,dir.fullname & "\overlay.png")
			Me.DesignData(2,i).Value = dir.Name
			Me.DesignData(3,i).Value = dir.fullname & "\background.png"
			Me.DesignData(4,i).Value = dir.fullname & "\overlay.png"
			Me.DesignData(0,i).Dispose
			
			Me.DesignData.Item(2, i).Style.Font = New Font(Me.DesignData.Font, FontStyle.Bold)
			
			i = i +1
		Next
	
	End Sub
	
	Sub BtNewDesignClick(sender As Object, e As EventArgs)
			
		Dim _NewDesign As Form = newdesign
		newdesign.picBackground.Tag = ""
		newdesign.picOverlay.Tag = ""
		_newdesign.ShowDialog

	End Sub
	
	Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
		
		Select Case (e.ColumnIndex)
			Case = 5
				Dim _NewDesign As Form = newdesign
				newdesign.picBackground.Tag = me.DesignData(3, e.RowIndex).Value
				newdesign.picOverlay.Tag = Me.DesignData(4,e.RowIndex).Value
				newdesign.tbDesignName.Text = Me.DesignData(2,e.RowIndex).Value

				_newdesign.ShowDialog
								
			Case = 6
				Dim antwort As DialogResult
				
				antwort = msgbox("Would you like to delete the design", MsgBoxStyle.Question + msgboxstyle.YesNo,"Delete Design?")
				
				If antwort = vbyes Then				
										
					Dim DeletePath As String = application.StartupPath & "\Design\" & Me.DesignData(2,e.RowIndex).Value
					
					Me.DesignData.Rows.Clear					
					io.Directory.Delete(DeletePath,true)
					LoadAvailableDesigns
				End If
				
		End Select
	End Sub
		
		Public shared function CreateCloneImage (path As String) As Bitmap
			
			'Work around: ImageClone erstellen, weil sonst löschen net funzt -> verhindert (... used by other process)
			Dim bmpClone As Bitmap 'the clone to be loaded to a PictureBox
			Dim bmpOriginal As System.Drawing.Image = System.Drawing.Image.FromFile(path) 
			bmpClone = New Bitmap(bmpOriginal.Width, bmpOriginal.Height)
			Dim gr As Graphics = Graphics.FromImage(bmpClone) 'get object representing clone's currently empty drawing surface
			gr.SmoothingMode = Drawing2D.SmoothingMode.None
			gr.InterpolationMode =Drawing2D.InterpolationMode.NearestNeighbor
			gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
			gr.DrawImage(bmpOriginal, 0, 0, bmpOriginal.Width,bmpOriginal.Height) 'copy original image onto this surface
			gr.Dispose()
			
			bmpOriginal.Dispose()
			Return bmpClone
			
		End function
	

	
	Sub ButtonCreateClick(sender As Object, e As EventArgs)
		
		For i = 0 To Me.DesignData.Rows.Count -1
				If Me.DesignData.Item(1,i).Value = True Then
				
				if io.Directory.Exists(me.tbSourceLogo.Text) = true and io.Directory.Exists(Me.tbSavePath.text) = true then
		        try
		        
		        ' Verzeichnis, dessen Dateien ermittelt werden sollen
		        Dim TVLogoPath As String = me.tbSourceLogo.Text
		
		        ' ggf. abschließenden Backslash entfernen
		        If TVLogoPath.EndsWith("\") And TVLogoPath.Length > 3 Then
		            TVLogoPath = TVLogoPath.Substring(0, TVLogoPath.Length - 1)
		        End If
		
		        ' Directory-Object erstellen
		        Dim oDir As New System.IO.DirectoryInfo(TVLogoPath)
		
		        ' alle Dateien des Ordners
		        Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()
		
		        ' Datei-Array durchlaufen
		        Dim oFile As System.IO.FileInfo
		
		            For Each oFile In oFiles
		
						if io.Path.GetExtension(ofile.FullName) = ".png" then
			                    Dim LayerBG As Image = Bitmap.FromFile(Me.DesignData.Item(3,i).Value)
			                    Dim Logo As Image = Bitmap.FromFile(oFile.FullName)
			                    Dim LayerOverlay As Image = Bitmap.FromFile(Me.DesignData.Item(4,i).Value)
			                    
			                    Dim b As New Bitmap(CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))
			                    Dim g As Graphics = Graphics.FromImage(b)
			                    g.DrawImage(LayerBG, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))
			                    g.DrawImage(Logo, cint(me.tbOffset.Text), cint(me.tbOffset.Text),CInt(Me.tbWidth.Text)- 2* cint(me.tbOffset.Text), CInt(Me.tbHeight.text)- 2* cint(me.tbOffset.Text))
			                    g.DrawImage(LayerOverlay, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.text))
			                                        
			                    b.Save(Me.tbSavePath.text & "\" & io.Path.GetFileName(ofile.FullName).ToString)
			            End If
		            
		            Next
		            
				Catch ex As Exception
				msgbox("Error creating logos - " & ex.Message & " - " & ex.StackTrace)
				End Try
				
			Else
				
				If io.Directory.Exists(Me.tbSourceLogo.Text) = False Then
					msgbox("Source path not found !", MsgBoxStyle.Critical,"Warning...")
				End If
				If io.Directory.Exists(Me.tbSavePath.text) = False Then
					msgbox("Save path not found !", MsgBoxStyle.Critical,"Warning...")
				End If
			
			End If
		
		End If	
		Next		
	End Sub
End Class
