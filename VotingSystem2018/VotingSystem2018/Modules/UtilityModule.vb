Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions

Module UtilityModule

    'Config Directories
    Public ProjectDirectory As String = AppDomain.CurrentDomain.BaseDirectory.Replace("VotingSystem2018\bin\Debug\", "")
    Public ImagesDirectory As String = ProjectDirectory & "VotingSystem2018\Pictures\"
    Public UIImagesDirectory As String = ImagesDirectory & "UI\"
    Public CandidateImagesDirectory As String = ImagesDirectory & "Candidates\"

    'Clears Text
    Sub EraseText(ByVal FormName As Form)
        Dim a As Control
        For Each a In FormName.Controls
            If TypeOf a Is TextBox And Not Nothing Then
                a.Text = Nothing
            End If
        Next
    End Sub

    'Removes Extra White Spaces
    Sub StripSpaces(ByVal FormName As Form)
        Dim a As Control
        For Each a In FormName.Controls
            If TypeOf a Is TextBox Then
                a.Text = String.Join(" ", a.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries))
            End If
        Next
    End Sub

    'Gets the formated current time and date
    Function getClock() As String
        getClock = Date.Now.ToString("h:mm:ss tt") & Environment.NewLine & Date.Now.ToString("dddd, MMMM dd,yyyy")
    End Function

    'Change opacity of picture
    'First call the file like this PictureBox1.Image = Image.FromFile("dir/picture.png")
    'Then  
    'PictureBox1.Image.Dispose()
    'PictureBox1.Image = ChangeOpacity(Image.FromFile("dir/picture.png"), 0.3)
    Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix
        colormatrix.Matrix33 = opacityvalue
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, _
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function

    'Get first name of a person after the space
    Function getFirstName(ByVal full_name As String) As String
        Dim name = full_name.Split(", ")(1)
        Return name.Split(" ")(1)
    End Function

End Module
