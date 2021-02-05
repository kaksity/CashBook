Imports FirebirdSql.Data.FirebirdClient

Public Class Util

   
    ''' <summary>
    ''' Opens a dialog box that let's the user select an image file
    ''' </summary>
    ''' <returns>An image object representing the image file selected</returns>
    ''' <remarks></remarks>
    Public Shared Function loadPhoto() As Image

        Dim Dialog As New OpenFileDialog
        Dim strFilename As String = ""
        Dim Photo As Image

        Dialog.Filter = "(*.jpg)|*jpg| (*.jpeg)|*.jpeg| (*.png)|*.png| (*.bmp)|*.bmp| (*.gif)|*gif| (*.svg)|*.svg"
        Dialog.ShowDialog()
        strFilename = Dialog.FileName
        If Not strFilename.Trim = "" Then Photo = Image.FromFile(strFilename) Else Photo = Nothing

        Return Photo

    End Function

End Class

