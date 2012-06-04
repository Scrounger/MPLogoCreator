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

Imports System.Threading

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If Settings.GetSetting("FolderStructure") = "TvRadio" Then
            RBtvRadio.Checked = True
            tbSourceLogo.Enabled = False
            tbSourceRadio.Enabled = True
            tbSourceTv.Enabled = True
        Else
            RBdesign.Checked = True
            tbSourceLogo.Enabled = True
            tbSourceRadio.Enabled = False
            tbSourceTv.Enabled = False
        End If

        Try
            Dim _EditButton As New DataGridViewButtonColumn

            With _EditButton
                .DefaultCellStyle.Padding = New Padding(5, 20, 5, 20)
                .HeaderText = "Edit"
                .Text = "Edit"
                .Name = "Edit"
                .FlatStyle = FlatStyle.Flat
                .UseColumnTextForButtonValue = True
                '_editbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Width = 100
            End With

            Dim _DeleteButton As New DataGridViewButtonColumn

            With _DeleteButton
                .DefaultCellStyle.Padding = New Padding(5, 20, 5, 20)
                .HeaderText = "Delete"
                .Text = "Delete"
                .Name = "Delete"
                .FlatStyle = FlatStyle.Flat
                .UseColumnTextForButtonValue = True
                '_editbutton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Width = 100
            End With

            Me.DesignData.Columns.Add(_EditButton)
            Me.DesignData.Columns.Add(_DeleteButton)

            Me.tbHeight.Text = CStr(200)
            Me.tbWidth.Text = CStr(200)
            Me.tbOffset.Text = CStr(6)

            Me.tbSourceLogo.Text = Settings.GetSetting("SourcePath")
            Me.tbSavePath.Text = Settings.GetSetting("SavePath")
            Me.tbSourceTv.Text = Settings.GetSetting("SourceTv")
            Me.tbSourceRadio.Text = Settings.GetSetting("SourceRadio")

            LoadAvailableDesigns()

        Catch ex As Exception
            MsgBox("[MainFormLoad] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
	
	public Sub LoadAvailableDesigns

        Try
            'DesignData mit allen Unterordnern füllen
            Me.DesignData.Rows.Clear()

            Dim _oDir As New System.IO.DirectoryInfo(Application.StartupPath & "\Design")
            Dim i As Integer = 0

            For Each Dir As System.IO.DirectoryInfo In _oDir.GetDirectories

                Me.DesignData.Rows.Add(CreateCloneImage(Dir.FullName & "\sample.png"), False, Dir.Name, Dir.FullName & "\overlay.png")
                Me.DesignData(0, i).Style.BackColor = Color.Black

                Me.DesignData(2, i).Value = Dir.Name
                Me.DesignData(3, i).Value = Dir.FullName & "\background.png"
                Me.DesignData(4, i).Value = Dir.FullName & "\overlay.png"
                Me.DesignData(0, i).Dispose()

                Me.DesignData.Item(2, i).Style.Font = New Font(Me.DesignData.Font, FontStyle.Bold)

                i = i + 1
            Next
        Catch ex As Exception
            MsgBox("[LoadAvailableDesigns] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
	
    Sub BtNewDesignClick(ByVal sender As Object, ByVal e As EventArgs) Handles btNewDesign.Click

        Try
            Dim _NewDesign As Form = NewDesign
            NewDesign.picBackground.Tag = ""
            NewDesign.picOverlay.Tag = ""
            _NewDesign.ShowDialog()
        Catch ex As Exception
            MsgBox("[BtNewDesignClick] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
	
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DesignData.CellClick
        Try
            Select Case (e.ColumnIndex)
                Case Is = 1
                    If CBool(Me.DesignData(1, e.RowIndex).Value) = True Then
                        Me.DesignData(1, e.RowIndex).Value = False
                    Else
                        Me.DesignData(1, e.RowIndex).Value = True
                    End If

                Case Is = 5
                    Dim _NewDesign As Form = NewDesign
                    NewDesign.picBackground.Tag = Me.DesignData(3, e.RowIndex).Value
                    NewDesign.picOverlay.Tag = Me.DesignData(4, e.RowIndex).Value
                    NewDesign.tbDesignName.Text = Me.DesignData(2, e.RowIndex).Value.ToString

                    _NewDesign.ShowDialog()

                Case Is = 6
                    Dim antwort As MsgBoxResult
                    antwort = MsgBox("Really delete the Desing?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Overwrite Design?")

                    If antwort = vbYes Then

                        Dim DeletePath As String = Application.StartupPath & "\Design\" & Me.DesignData(2, e.RowIndex).Value.ToString

                        Me.DesignData.Rows.Clear()
                        IO.Directory.Delete(DeletePath, True)
                        LoadAvailableDesigns()
                    End If

            End Select
        Catch ex As Exception
            MsgBox("[DataGridView1_CellClick] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
		
    Public Shared Function CreateCloneImage(ByVal path As String) As Bitmap

        Dim bmpClone As Bitmap = Nothing 'the clone to be loaded to a PictureBox

        Try
            'Work around: ImageClone erstellen, weil sonst löschen net funzt -> verhindert (... used by other process)

            Dim bmpOriginal As System.Drawing.Image = System.Drawing.Image.FromFile(path)
            bmpClone = New Bitmap(bmpOriginal.Width, bmpOriginal.Height)
            Dim gr As Graphics = Graphics.FromImage(bmpClone) 'get object representing clone's currently empty drawing surface
            gr.SmoothingMode = Drawing2D.SmoothingMode.None
            gr.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
            gr.DrawImage(bmpOriginal, 0, 0, bmpOriginal.Width, bmpOriginal.Height) 'copy original image onto this surface
            gr.Dispose()

            bmpOriginal.Dispose()

        Catch ex As Exception
            MsgBox("[CreateCloneImage] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return bmpClone
    End Function
	
    Sub ButtonCreateClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCreate.Click
        Try
            If IO.Directory.Exists(Me.tbSavePath.Text) = True Then

                If RBtvRadio.Checked = True Then
                    If Not String.IsNullOrEmpty(tbSourceTv.Text) Or Not String.IsNullOrEmpty(tbSourceRadio.Text) Then
                        If IO.Directory.Exists(Me.tbSourceTv.Text) = True And IO.Directory.Exists(Me.tbSourceRadio.Text) = True Then
                            CreateLogos(Me.tbSourceTv.Text, "\tv\logos")
                            CreateLogos(Me.tbSourceRadio.Text, "\Radio")
                        Else
                            MsgBox("tv / radio Source path not found !", MsgBoxStyle.Critical, "Warning...")
                            Exit Sub
                        End If
                    End If

                Else
                    If Not String.IsNullOrEmpty(Me.tbSourceLogo.Text) Then
                        If IO.Directory.Exists(Me.tbSourceLogo.Text) = True Then
                            CreateLogos(Me.tbSourceLogo.Text)
                        Else
                            MsgBox("Source path not found !", MsgBoxStyle.Critical, "Warning...")
                            Exit Sub
                        End If
                    End If
                End If
            Else
                MsgBox("Save path not found !", MsgBoxStyle.Critical, "Warning...")
            End If

            MsgBox("Logos successfully saved", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub CreateLogos(ByVal SourcePath As String, Optional ByVal subFolder As String = "")
        Try
            For i = 0 To Me.DesignData.Rows.Count - 1
                If CBool(Me.DesignData.Item(1, i).Value) = True Then

                    'If IO.Directory.Exists(SourcePath) = True And IO.Directory.Exists(Me.tbSavePath.Text) = True Then
                    Try

                        ' Verzeichnis, dessen Dateien ermittelt werden sollen
                        Dim TVLogoPath As String = SourcePath

                        ' ggf. abschließenden Backslash entfernen
                        If TVLogoPath.EndsWith("\") And TVLogoPath.Length > 3 Then
                            TVLogoPath = TVLogoPath.Substring(0, TVLogoPath.Length - 1)
                        End If

                        ' Directory-Object erstellen
                        Dim oDir As New System.IO.DirectoryInfo(TVLogoPath)

                        ' alle Dateien des Ordners
                        Dim oFiles As System.IO.FileInfo() = oDir.GetFiles()


                        Dim oFile As System.IO.FileInfo

                        Me.ProgressBar.Value = 0
                        Me.ProgressBar.Maximum = oFiles.Length
                        Me.ProgressLabel.Visible = True
                        Me.ProgressLabel.Text = Me.DesignData.Item(2, i).Value.ToString
                        Application.DoEvents()

                        ' Datei-Array durchlaufen
                        For Each oFile In oFiles
                            Me.ProgressBar.PerformStep()

                            If IO.Path.GetExtension(oFile.FullName) = ".png" Then
                                Dim LayerBG As Image = Bitmap.FromFile(Me.DesignData.Item(3, i).Value.ToString)
                                Dim Logo As Image = Bitmap.FromFile(oFile.FullName)
                                Dim LayerOverlay As Image = Bitmap.FromFile(Me.DesignData.Item(4, i).Value.ToString)

                                Dim b As New Bitmap(CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))
                                Dim g As Graphics = Graphics.FromImage(b)
                                g.DrawImage(LayerBG, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))
                                g.DrawImage(Logo, CInt(Me.tbOffset.Text), CInt(Me.tbOffset.Text), CInt(Me.tbWidth.Text) - 2 * CInt(Me.tbOffset.Text), CInt(Me.tbHeight.Text) - 2 * CInt(Me.tbOffset.Text))
                                g.DrawImage(LayerOverlay, 0, 0, CInt(Me.tbWidth.Text), CInt(Me.tbHeight.Text))

                                IO.Directory.CreateDirectory(Me.tbSavePath.Text & "\" & Me.DesignData.Item(2, i).Value.ToString & subFolder)
                                b.Save(Me.tbSavePath.Text & "\" & Me.DesignData.Item(2, i).Value.ToString & subFolder & "\" & IO.Path.GetFileName(oFile.FullName).ToString)

                            End If
                        Next

                    Catch ex As Exception
                        MsgBox("Error creating logos - " & ex.Message & " - " & ex.StackTrace)
                    End Try

                    'Else

                    '    If IO.Directory.Exists(Me.tbSourceLogo.Text) = False Then
                    '        MsgBox("Source path not found !", MsgBoxStyle.Critical, "Warning...")
                    '        Exit Sub
                    '    End If
                    '    If IO.Directory.Exists(Me.tbSavePath.Text) = False Then
                    '        MsgBox("Save path not found !", MsgBoxStyle.Critical, "Warning...")
                    '    End If
                    '    Exit Sub
                    'End If

                End If
            Next

            Settings.SetSetting("SourcePath", tbSourceLogo.Text)
            Settings.SetSetting("SavePath", tbSavePath.Text)
            Settings.SetSetting("SourceTv", tbSourceTv.Text)
            Settings.SetSetting("SourceRadio", tbSourceRadio.Text)

            Me.ProgressBar.Value = 0
            Me.ProgressLabel.Visible = False

        Catch ex As Exception
            MsgBox("[ButtonCreateClick] Error !" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CheckBoxSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSelector.CheckedChanged
        For i = 0 To Me.DesignData.Rows.Count - 1
            If CheckBoxSelector.CheckState = CheckState.Checked Then
                Me.DesignData.Item(1, i).Value = True
            Else
                Me.DesignData.Item(1, i).Value = False
            End If
        Next
    End Sub

    Private Sub RBtvRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtvRadio.CheckedChanged
        tbSourceLogo.Enabled = False
        tbSourceRadio.Enabled = True
        tbSourceTv.Enabled = True
        Settings.SetSetting("FolderStructure", "TvRadio")

    End Sub

    Private Sub RBdesign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBdesign.CheckedChanged
        tbSourceLogo.Enabled = True
        tbSourceRadio.Enabled = False
        tbSourceTv.Enabled = False
        Settings.SetSetting("FolderStructure", "Design")
    End Sub
End Class
