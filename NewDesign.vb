#Region "Copyright (C) 2005-2011 Team MediaPortal"

' Copyright (C) 2005-2011 Team MediaPortal
' http://www.team-mediaportal.com
' 
' MediaPortal is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 2 of the License, or
' (at your option) any later version.
' 
' MediaPortal is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with MediaPortal. If not, see <http://www.gnu.org/licenses/>.

#End Region

Imports MPLogoCreator.MainForm

Public Partial Class NewDesign
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
    Sub BtBackClick(ByVal sender As Object, ByVal e As EventArgs) Handles btBack.Click
        Me.tbDesignName.Clear()
        Me.Close()

    End Sub
	
    Sub BtSaveDesignClick(ByVal sender As Object, ByVal e As EventArgs) Handles btSaveDesign.Click
        Try
            Dim _NewPath As String = Application.StartupPath & "\Design\" & Me.tbDesignName.Text

            If Not String.IsNullOrEmpty(Me.tbDesignName.Text) Then
                If IO.Directory.Exists(_NewPath) = False Then
                    IO.Directory.CreateDirectory(_NewPath)
                    IO.File.Copy(Me.picBackground.Tag.ToString, _NewPath & "\background.png")
                    IO.File.Copy(Me.picOverlay.Tag.ToString, _NewPath & "\overlay.png")

                    Me.picPreview.Image.Save(_NewPath & "\sample.png")
                    MainForm.LoadAvailableDesigns()
                    Me.tbDesignName.Clear()

                    Me.Close()
                Else
                    Dim antwort As MsgBoxResult
                    antwort = MsgBox("Design name still exist!" & vbNewLine & vbNewLine & "Would you like to overwirte the design", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Overwrite Design?")
                    If antwort = vbYes Then

                        IO.Directory.CreateDirectory(_NewPath)

                        '				io.File.Copy(Me.picBackground.Tag, _NewPath & "\background.png",true)
                        '				io.File.Copy(Me.picOverlay.Tag, _NewPath & "\overlay.png",true)

                        Me.picBackground.Image.Save(_NewPath & "\background.png")
                        Me.picOverlay.Image.Save(_NewPath & "\overlay.png")
                        Me.picPreview.Image.Save(_NewPath & "\sample.png")
                        MainForm.LoadAvailableDesigns()
                        Me.tbDesignName.Clear()
                        Me.Close()
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("[BtSaveDesignClick] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Sub NewDesignLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            If String.IsNullOrEmpty(Me.picBackground.Tag.ToString) Then
                Dim imgStream As New IO.MemoryStream
                CreateCloneImage(Application.StartupPath & "\Source\transparent.png").Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
                Me.picBackground.Tag = Application.StartupPath & "\Source\transparent.png"
                imgStream.Dispose()
            Else
                Dim imgStream As New IO.MemoryStream
                CreateCloneImage(Me.picBackground.Tag.ToString).Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
                imgStream.Dispose()
            End If

            If String.IsNullOrEmpty(Me.picOverlay.Tag.ToString) Then
                Dim imgStream As New IO.MemoryStream
                CreateCloneImage(Application.StartupPath & "\Source\transparent.png").Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                Me.picOverlay.Image = System.Drawing.Image.FromStream(imgStream)
                Me.picOverlay.Tag = Application.StartupPath & "\Source\transparent.png"
                imgStream.Dispose()
            Else
                Dim imgStream As New IO.MemoryStream
                CreateCloneImage(Me.picOverlay.Tag.ToString).Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
                Me.picOverlay.Image = System.Drawing.Image.FromStream(imgStream)
                imgStream.Dispose()
            End If

            Me.picBackground.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picBackground.SizeMode = PictureBoxSizeMode.Zoom
            Me.picOverlay.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picOverlay.SizeMode = PictureBoxSizeMode.Zoom

            Me.tbHeight.Text = CStr(200)
            Me.tbWidth.Text = CStr(200)
            Me.tbOffset.Text = CStr(6)


            CreatePreviewImage()
        Catch ex As Exception
            MsgBox("[NewDesignLoad] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
	
    Private Sub CreatePreviewImage()
        Try

            Dim LayerBGStream As New IO.MemoryStream
            CreateCloneImage(Me.picBackground.Tag.ToString).Save(LayerBGStream, System.Drawing.Imaging.ImageFormat.Png)
            Dim LayerBG As Image = System.Drawing.Image.FromStream(LayerBGStream)
            LayerBGStream.Dispose()

            Dim LogoStream As New IO.MemoryStream
            CreateCloneImage(Application.StartupPath & "\Source\sampleLogo.png").Save(LogoStream, System.Drawing.Imaging.ImageFormat.Png)
            Dim Logo As Image = System.Drawing.Image.FromStream(LogoStream)
            LogoStream.Dispose()

            Dim LayerOverlayStream As New IO.MemoryStream
            CreateCloneImage(Me.picOverlay.Tag.ToString).Save(LayerOverlayStream, System.Drawing.Imaging.ImageFormat.Png)
            Dim LayerOverlay As Image = System.Drawing.Image.FromStream(LayerOverlayStream)

            Dim b As New Bitmap(CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))
            Dim g As Graphics = Graphics.FromImage(b)
            g.DrawImage(LayerBG, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))
            g.DrawImage(Logo, CInt(Me.tbOffset.Text), CInt(Me.tbOffset.Text), CInt(Me.tbWidth.Text) - 2 * CInt(Me.tbOffset.Text), CInt(Me.tbHeight.Text) - 2 * CInt(Me.tbOffset.Text))
            g.DrawImage(LayerOverlay, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))

            Dim imgStream As New IO.MemoryStream
            b.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)


            '		Me.picPreview.image.FromStream(imgStream)
            Me.picPreview.Image = System.Drawing.Image.FromStream(imgStream)
            Me.picPreview.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picPreview.SizeMode = PictureBoxSizeMode.Zoom

            LayerBG.Dispose()
            Logo.Dispose()
            LayerOverlay.Dispose()

            b.Dispose()
            g.Dispose()
            imgStream.Dispose()

        Catch ex As Exception
            MsgBox("[CreatePreviewImage] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
	
    Sub BtBrowseBackgroundClick(ByVal sender As Object, ByVal e As EventArgs) Handles btBrowseBackground.Click

        Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image (*.png) |*.png;"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imgStream As New IO.MemoryStream

            CreateCloneImage(_openFileDialog.FileName).Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)

            Me.picBackground.Image = System.Drawing.Image.FromStream(imgStream)
            Me.picBackground.Tag = _openFileDialog.FileName
            Me.picBackground.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picBackground.SizeMode = PictureBoxSizeMode.Zoom

            imgStream.Dispose()

            CreatePreviewImage()
        End If
    End Sub
	
    Sub BtBrowseOverlayClick(ByVal sender As Object, ByVal e As EventArgs) Handles btBrowseOverlay.Click

        Dim _openFileDialog As New System.Windows.Forms.OpenFileDialog

        _openFileDialog.Filter = "Image (*.png) |*.png;"

        If _openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imgStream As New IO.MemoryStream

            CreateCloneImage(_openFileDialog.FileName).Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)

            Me.picOverlay.Image = System.Drawing.Image.FromStream(imgStream)
            Me.picOverlay.Tag = _openFileDialog.FileName
            Me.picOverlay.SizeMode = PictureBoxSizeMode.CenterImage
            Me.picOverlay.SizeMode = PictureBoxSizeMode.Zoom

            imgStream.Dispose()

            CreatePreviewImage()
        End If

    End Sub
	
    Sub BtRefreshClick(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        CreatePreviewImage()
    End Sub
End Class
