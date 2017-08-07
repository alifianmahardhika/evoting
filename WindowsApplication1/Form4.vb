Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form4
    Dim myDB As MySqlConnection

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=fingerprintvb"
        myDB.Open()
        If myDB.State = ConnectionState.Open Then
            submitButton.Enabled = True
            candidateImageButton.Enabled = True
        Else
            submitButton.Enabled = False
            candidateImageButton.Enabled = False
        End If
        myDB.Close()
    End Sub

    Private Sub candidateImageButton_Click(sender As Object, e As EventArgs) Handles candidateImageButton.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            candidateImageBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            candidateImageBox.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        myDB.Open()
        Dim sqlcommand As New MySqlCommand
        Dim filestream As New System.IO.MemoryStream()
        candidateImageBox.Image.Save(filestream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrayImage() As Byte = filestream.GetBuffer()
        filestream.Close()
        sqlcommand.Connection = myDB
        sqlcommand.CommandType = CommandType.Text
        sqlcommand.CommandText = "INSERT INTO candidatedb(residenceID,houseNumber,name,sex,dateOfBorn,dzongkhag,constituency,gewog,village,photo,voteCount) VALUES(@residence,@house,@name,@sex,@dob,@dzong,@cons,@gew,@vil,@img,@count)"
        sqlcommand.Parameters.AddWithValue("@residence", candidateResidenceID.Text)
        sqlcommand.Parameters.AddWithValue("@house", candidateHouseNumber.Text)
        sqlcommand.Parameters.AddWithValue("@name", candidateName.Text)
        sqlcommand.Parameters.AddWithValue("@sex", candidateSex.Text)
        sqlcommand.Parameters.AddWithValue("@dob", candidateDob.Value.ToString("yyyy-MM-dd"))
        sqlcommand.Parameters.AddWithValue("@dzong", candidateDzongkhag.Text)
        sqlcommand.Parameters.AddWithValue("@cons", candidateConstituency.Text)
        sqlcommand.Parameters.AddWithValue("@gew", candidateGewog.Text)
        sqlcommand.Parameters.AddWithValue("@vil", candidateVillage.Text)
        sqlcommand.Parameters.AddWithValue("@img", arrayImage)
        sqlcommand.Parameters.AddWithValue("@count", "0")
        sqlcommand.ExecuteNonQuery()
        myDB.Close()
        sqlcommand.Parameters.Clear()
        MsgBox("Submitted into database!")
    End Sub
End Class