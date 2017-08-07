Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Dim myDB As MySqlConnection
    Dim WithEvents FpReg As FlexCodeSDK.FinFPReg
    Dim Template As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=fingerprintvb"
        myDB.Open()
        If myDB.State = ConnectionState.Open Then
            registerFingerPrintButton.Enabled = True
        Else
            registerFingerPrintButton.Enabled = False
        End If
        myDB.Close()
    End Sub

    Private Sub registerFingerPrint_Click(sender As Object, e As EventArgs) Handles registerFingerPrintButton.Click
        FpReg = New FlexCodeSDK.FinFPReg
        FpReg.AddDeviceInfo("C300J002911", "F5B597C713305D8", "XU24A41C173DFD1044976UM2")
        FpReg.PictureSamplePath = My.Application.Info.DirectoryPath & "\Temp.bmp"
        FpReg.PictureSampleHeight = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(voterFingerImageBox.Height)
        FpReg.PictureSampleWidth = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(voterFingerImageBox.Width)
        FpReg.FPRegistrationStart("3197B988220A34AF3008425D6A835A47")
    End Sub

    Private Sub FpReg_FPRegistrationStatus(ByVal Status As FlexCodeSDK.RegistrationStatus) Handles FpReg.FPRegistrationStatus
        If Status = FlexCodeSDK.RegistrationStatus.r_OK Then
            registrationStatus.Text = "Scanning done, press the submit registration button to save it into Database."
        End If
    End Sub

    Private Sub FpReg_FPRegistrationTemplate(ByVal FPTemplate As String) Handles FpReg.FPRegistrationTemplate
        Template = FPTemplate
    End Sub

    Private Sub FpReg_FPSamplesNeeded(ByVal Samples As Short) Handles FpReg.FPSamplesNeeded
        registrationStatus.Text = "Now Scan your finger " & Str(Samples) & " times"
    End Sub

    Private Sub openImageFile_Click(sender As Object, e As EventArgs) Handles openImageButton.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            voterPhotoBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            voterPhotoBox.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub FpReg_FPRegistrationImage() Handles FpReg.FPRegistrationImage
        Dim imgFile As System.IO.FileStream = New System.IO.FileStream(My.Application.Info.DirectoryPath & "\Temp.bmp", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite)
        Dim fileByte(imgFile.Length) As Byte
        imgFile.Read(fileByte, 0, fileByte.Length)
        imgFile.Close()
        Dim ms As System.IO.MemoryStream = New MemoryStream(fileByte)
        voterFingerImageBox.Image = Image.FromStream(ms)
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        myDB.Open()
        Dim sqlCommand As New MySqlCommand
        Dim fileStream As New System.IO.MemoryStream()
        voterPhotoBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = fileStream.GetBuffer()
        fileStream.Close()
        sqlCommand.Connection = myDB
        sqlCommand.CommandType = CommandType.Text
        sqlCommand.CommandText = "INSERT INTO voterdb(houseNumber,residenceID,name,sex,dateOfBorn,dzongkhag,constituency,gewog,village,pollingStation,fingerPrintTemplate,fpIndex,voteStatus,photo) VALUES('" & voterHouseNumber.Text & "','" & voterNationalId.Text & "','" & voterName.Text & "','" & voterDob.Value.ToString("yyyy-MM-dd") & "','" & voterDzongkhag.Text & "','" & voterConstituency.Text & "','" & voterGewog.Text & "','" & voterVillage.Text & "','" & voterPollingStation.Text & "','" & Template & "', '1', '0', @voterPhotoData)"
        sqlCommand.Parameters.AddWithValue("@voterPhotoData", arrImage)
        sqlCommand.ExecuteNonQuery()
        myDB.Close()
        sqlCommand.Parameters.Clear()
        MsgBox("Successfully submitted into Database!")
        voterName.Clear()
        voterPhotoBox.ImageLocation = ""
    End Sub
End Class
