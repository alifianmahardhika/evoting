Imports FlexCodeSDK
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim myDB As MySqlConnection
    Dim WithEvents fpVer As FlexCodeSDK.FinFPVer
    Dim voterID As String
    Dim fpIndex As Byte

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myDB = New MySqlConnection
        myDB.ConnectionString = "server=127.0.0.1;user id=root;password=;database=fingerprintvb"
        myDB.Open()
        If myDB.State = ConnectionState.Open Then
            fpVer = New FlexCodeSDK.FinFPVer
            fpVer.AddDeviceInfo("C300J002911", "F5B597C713305D8", "XU24A41C173DFD1044976UM2")

            Dim sqlCommand As New MySqlCommand
            sqlCommand.Connection = myDB
            sqlCommand.CommandText = "SELECT * FROM voterdb"
            Dim readDB As MySqlDataReader
            readDB = sqlCommand.ExecuteReader
            While readDB.Read
                fpVer.FPLoad(readDB.GetString(0), readDB.GetString(1), readDB.GetString(13), "3197B988220A34AF3008425D6A835A47")
            End While
            fpVer.FPVerificationStart()
            readDB.Close()
        Else
            MsgBox("Please Register Finger Print First!")
        End If
    End Sub

    Private Sub fpVer_FPVerificationID(ID As String, FingerNr As FingerNumber) Handles fpVer.FPVerificationID
        voterID = ID
        fpIndex = FingerNr
    End Sub

    Private Sub fpVer_FPVerificationStatus(Status As VerificationStatus) Handles fpVer.FPVerificationStatus
        If Status = FlexCodeSDK.VerificationStatus.v_OK Then
            Dim sqlCommand2 As New MySqlCommand
            sqlCommand2.Connection = myDB
            sqlCommand2.CommandText = "SELECT * FROM voterdb WHERE id = '" & voterID & "'"
            Dim readDB2 As MySqlDataReader
            readDB2 = sqlCommand2.ExecuteReader
            readDB2.Read()

            TextBox1.Text = TextBox1.Text & vbNewLine & "ID: " & voterID & ", Name: " & readDB2.GetString(4) & ", Finger Index: " & Str(fpIndex)
            Dim url As String = "http://localhost/bhutanelection/index.php?id='" & voterID & "'"
            voterID = ""
            readDB2.Close()

        ElseIf Status = FlexCodeSDK.VerificationStatus.v_NotMatch Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Not recognized!"
        ElseIf Status = FlexCodeSDK.VerificationStatus.v_VerifyCaptureFingerTouch Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Finger touch!"
        Else
            TextBox1.Text = TextBox1.Text & vbNewLine & "Result Status: " & Str(Status)
        End If
    End Sub
End Class