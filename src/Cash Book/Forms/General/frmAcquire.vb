
Public Class frmAcquire

    Public OkClicked As Boolean = False
    Private Shared imgOriginal As Image 'Holds the original loaded image that will remain unmodified by zooming
    Private Biro As Pen
    Private Rec As Rectangle
    Private Grphx As Graphics

    Public Shared ImageSource As String = "disk" 'Holds the default image source. Either Scanner or Disk.

    Private Sub DrawRect(ByVal mouseX As Integer, ByVal mouseY As Integer)

        Dim X As Integer
        Dim Y As Integer

        X = mouseX - (0.5 * Rec.Width)
        Y = mouseY - (0.5 * Rec.Height)

        Rec.X = X
        Rec.Y = Y
       
        Me.Refresh()
        Grphx.DrawRectangle(Biro, Rec)


    End Sub

        Private Sub cropRegion(ByVal imgOriginal As Image, ByVal Area As Rectangle)

        Dim Height As Integer
        Dim Width As Integer
        Dim bmCropped As Bitmap
        Dim grCropped As Graphics
        Dim RecF As RectangleF
        Dim Mem As System.IO.MemoryStream = Nothing

        Height = Area.Height
        Width = Area.Width

        RecF = imgOriginal.GetBounds(GraphicsUnit.Point)
        bmCropped = New Bitmap(Width, Height, Imaging.PixelFormat.Format24bppRgb)
        grCropped = Graphics.FromImage(bmCropped)

        grCropped.DrawImage(imgOriginal, New Rectangle(0, 0, Width, Height), Rec, GraphicsUnit.Pixel)

        Mem = New System.IO.MemoryStream
        bmCropped.Save(Mem, Imaging.ImageFormat.Jpeg)

        bmCropped.Dispose()
        grCropped.Dispose()

        picPreview.Image = Image.FromStream(Mem)

    End Sub

    Public Shared Function Acquire() As Image

        Dim AcquireForm As New frmAcquire
        Dim ReturnImage As Image

        AcquireForm.ShowDialog()

        If AcquireForm.OkClicked = True Then
            If Not AcquireForm.picPreview.Image Is Nothing Then
                ReturnImage = AcquireForm.picPreview.Image
            ElseIf AcquireForm.picPhoto.Image Is Nothing Then
                ReturnImage = AcquireForm.picPhoto.Image
            Else
                ReturnImage = Nothing
            End If
        Else
            ReturnImage = Nothing
        End If

        AcquireForm.OkClicked = False

        Return ReturnImage

    End Function

    Public Function Zoom(ByVal img As System.Drawing.Image, ByVal ZoomValue As Int32) As System.Drawing.Image

        Dim width As Int32 = Convert.ToInt32(img.Width * ZoomValue) / 100
        Dim height As Int32 = Convert.ToInt32(img.Height * ZoomValue) / 100

        'Create a new image based on the zoom parameters we require
        Dim zoomImage As New System.Drawing.Bitmap(img, width, height)

        'Create a new graphics object based on the new image
        Dim converted As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(zoomImage)

        'Clean up the image
        converted.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

        'Return the zoomed image
        Return zoomImage

    End Function

    Private Sub loadFromFile()

        Dim Photo As Image

        Photo = Util.loadPhoto

        If Not Photo Is Nothing Then
            picPhoto.Image = Photo
            imgOriginal = picPhoto.Image
        End If

    End Sub

    Private Sub Slider_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slider.Scroll

        Dim sValue As Int32
        Dim NewImage As Image

        If picPhoto.Image Is Nothing Then Exit Sub

        sValue = Slider.Value

        NewImage = Zoom(imgOriginal, sValue)
        picPhoto.Image = NewImage.Clone

        NewImage.Dispose()

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        EZTwain.SelectImageSource(Me.Handle)

    End Sub

    Private Sub btnAcquire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcquire.Click

        Dim strPath As String

        If chkFile.Checked = True Then
            loadFromFile()
            Exit Sub
        End If


        strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\twainphoto.bmp"

        If chkDialog.Checked = True Then EZTwain.SetHideUI(0) Else EZTwain.SetHideUI(1)

        If EZTwain.AcquireToFilename(Me.Handle, strPath) = 0 Then
            picPhoto.Load(strPath)
            imgOriginal = picPhoto.Image
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        OkClicked = False
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        OkClicked = True
        Me.Close()
    End Sub

    Private Sub chkFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFile.CheckedChanged
        If chkFile.Checked = True Then
            chkDialog.Enabled = False
            btnSelect.Enabled = False
        Else
            chkDialog.Enabled = True
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub picPhoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPhoto.Click

        If picPhoto.Image Is Nothing Then Exit Sub
        cropRegion(picPhoto.Image, Rec)

    End Sub

    Private Sub picPhoto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picPhoto.MouseMove
        DrawRect(e.X, e.Y)
    End Sub

    Private Sub frmAcquire_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If chkFile.Checked = True Then frmAcquire.ImageSource = "disk" Else frmAcquire.ImageSource = "scanner"

    End Sub

    Private Sub frmAcquire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Biro = New Pen(Color.Black)
        If passport = True And document = False Then
            Rec = New Rectangle(100, 100, 250, 250)
        ElseIf passport = False And document = True
            Rec = New Rectangle(100, 100, 630, 439)
        End If

        If frmAcquire.ImageSource = "disk" Then chkFile.Checked = True Else chkFile.Checked = False

    End Sub

    Private Sub frmAcquire_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Grphx = picPhoto.CreateGraphics

    End Sub

    Private Sub btnClearPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPreview.Click
        If Not picPreview.Image Is Nothing Then picPreview.Image = Nothing
    End Sub

    Private Sub btnHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHorizontal.Click

        Dim Img As Image

        If picPhoto.Image Is Nothing Then Exit Sub
        Img = picPhoto.Image
        Img.RotateFlip(RotateFlipType.Rotate180FlipY)
        picPhoto.Image = Img

    End Sub

    Private Sub btnVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVertical.Click

        Dim Img As Image

        If picPhoto.Image Is Nothing Then Exit Sub
        Img = picPhoto.Image
        Img.RotateFlip(RotateFlipType.Rotate180FlipX)
        picPhoto.Image = Img

    End Sub
End Class