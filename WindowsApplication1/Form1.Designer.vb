<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.registerFingerPrintButton = New System.Windows.Forms.Button()
        Me.registrationStatus = New System.Windows.Forms.Label()
        Me.voterHouseNumber = New System.Windows.Forms.TextBox()
        Me.voterName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.voterSex = New System.Windows.Forms.ComboBox()
        Me.voterDzongkhag = New System.Windows.Forms.ComboBox()
        Me.voterGewog = New System.Windows.Forms.ComboBox()
        Me.voterConstituency = New System.Windows.Forms.ComboBox()
        Me.voterPhotoBox = New System.Windows.Forms.PictureBox()
        Me.voterFingerImageBox = New System.Windows.Forms.PictureBox()
        Me.openImageButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.voterDob = New System.Windows.Forms.DateTimePicker()
        Me.voterVillage = New System.Windows.Forms.TextBox()
        Me.voterPollingStation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.formTitle = New System.Windows.Forms.Label()
        Me.voterNationalId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.voterPhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voterFingerImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registerFingerPrintButton
        '
        Me.registerFingerPrintButton.Location = New System.Drawing.Point(553, 295)
        Me.registerFingerPrintButton.Name = "registerFingerPrintButton"
        Me.registerFingerPrintButton.Size = New System.Drawing.Size(136, 42)
        Me.registerFingerPrintButton.TabIndex = 0
        Me.registerFingerPrintButton.Text = "Register Fingerprint (Right Thumb)"
        Me.registerFingerPrintButton.UseVisualStyleBackColor = True
        '
        'registrationStatus
        '
        Me.registrationStatus.AutoSize = True
        Me.registrationStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.registrationStatus.Location = New System.Drawing.Point(245, 387)
        Me.registrationStatus.Name = "registrationStatus"
        Me.registrationStatus.Size = New System.Drawing.Size(279, 21)
        Me.registrationStatus.TabIndex = 2
        Me.registrationStatus.Text = "Waiting for Registration Process . . ."
        Me.registrationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'voterHouseNumber
        '
        Me.voterHouseNumber.Location = New System.Drawing.Point(144, 212)
        Me.voterHouseNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.voterHouseNumber.Name = "voterHouseNumber"
        Me.voterHouseNumber.Size = New System.Drawing.Size(200, 19)
        Me.voterHouseNumber.TabIndex = 3
        '
        'voterName
        '
        Me.voterName.Location = New System.Drawing.Point(144, 140)
        Me.voterName.Margin = New System.Windows.Forms.Padding(2)
        Me.voterName.Name = "voterName"
        Me.voterName.Size = New System.Drawing.Size(200, 19)
        Me.voterName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "National ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date of born"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 237)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dzongkhag"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Gewog"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 313)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Village"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 261)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 12)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Constituency"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(459, 120)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 12)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Photo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(592, 120)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 12)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Fingerprint"
        '
        'voterSex
        '
        Me.voterSex.FormattingEnabled = True
        Me.voterSex.Items.AddRange(New Object() {"Male", "Female", "Unspecified"})
        Me.voterSex.Location = New System.Drawing.Point(144, 163)
        Me.voterSex.Margin = New System.Windows.Forms.Padding(2)
        Me.voterSex.Name = "voterSex"
        Me.voterSex.Size = New System.Drawing.Size(200, 20)
        Me.voterSex.TabIndex = 20
        '
        'voterDzongkhag
        '
        Me.voterDzongkhag.FormattingEnabled = True
        Me.voterDzongkhag.Items.AddRange(New Object() {"Bumthang", "Chhukha", "Dagana", "Gasa", "Haa", "Lhuentse", "Monggar", "Paro", "Pema Gatshel", "Punakha", "Samdrup Jongkhar", "Samtse", "Sarpang", "Tashi Yangtse", "Thimphu", "Trashigang", "Trongsa", "Tsirang", "Wangdue Phodrang", "Zhemgang"})
        Me.voterDzongkhag.Location = New System.Drawing.Point(144, 237)
        Me.voterDzongkhag.Margin = New System.Windows.Forms.Padding(2)
        Me.voterDzongkhag.Name = "voterDzongkhag"
        Me.voterDzongkhag.Size = New System.Drawing.Size(200, 20)
        Me.voterDzongkhag.TabIndex = 21
        '
        'voterGewog
        '
        Me.voterGewog.FormattingEnabled = True
        Me.voterGewog.Items.AddRange(New Object() {"Chhoekhor", "Chhume", "Tang", "Ura", "Bjachho", "Bongo", "Chapcha", "Darla", "Dungna", "Geling", "Getana", "Lokchina", "Metakha", "Phuentsholing", "Sampheling", "Dorona", "Drujegang", "Gesarling", "Goshi", "Kana", "Karmaling", "Khebisa", "Lajab", "Lhamoi Zingkha", "Nichula", "Trashiding", "Tsangkha", "Tsendagang་", "Tseza", "Khamaed", "Khatoe", "Laya", "Lunana", "Bji", "Gakiling", "Katsho", "Samar", "Sangbay", "Uesu", "Gangzur", "Khoma", "Jarey", "Kurtoed", "Menbi", "Metsho", "Minjay", "Tsenkhar", "Balam", "Chali", "Chaskhar", "Drametse", "Drepong", "Gongdue", "Jurmey", "Kengkhar", "Mongar", "Narang", "Ngatshang", "Saling", "Shermuhoong", "Silambi", "Thangrong", "Tsakaling", "Tsamang", "Dokar", "Dopshari", "Doteng", "Hungrel", "Lamgong", "Lungnyi", "Naja", "Shapa", "Tsento", "Wangchang", "Chimoong", "Chokhorling", "Chongshing", "Dechheling", "Dungmaed", "Khar", "Nanong", "Norbugang", "Shumar", "Yurung", "Zobel", "Barp", "Chhubug", "Dzomi", "Goenshari", "Guma", "Kabisa", "Lingmukha", "Shenga Bjemi", "Talog", "Toepisa", "Toewang", "Dewathang", "Gomdar", "Langchenphu", "Lauri", "Martshala", "Orong", "Pemathang", "Phuntshothang", "Samrang", "Serthi", "Wangphu", "Gewog", "Dungtoe", "Dophoogchen", "Duenchukha", "Namgaychhoeling", "Norbugang", "Norgaygang", "Pemaling", "Phuentshogpelri", "Samtse", "Sangngagchhoeling", "Tading", "Tashicholing", "Tendruk", "Ugentse", "Yoeseltse", "Chhuzagang", "Chhudzom", "Dekiling", "Gakiling", "Gelephu", "Jigmechholing", "Samtenling", "Senggey", "Sherzhong", "Shompangkha", "Tareythang", "Umling", "Chang", "Darkala", "Genye", "Kawang", "Lingzhi", "Mewang", "Naro", "Soe", "Bartsham", "Bidung", "Kanglung", "Kangpar", "Khaling", "Lumang", "Merag", "Phongmed", "Radi", "Sagteng", "Samkhar", "Shongphoog", "Thrimshing", "Uzorong", "Yangnyer", "Bumdeling", "Jamkhar", "Khamdang", "Ramjar", "Toetsho", "Tomzhang", "Yalang", "Yangtse", "Dragteng", "Korphoog", "Langthil", "Nubi", "Tangsibji", "Barshong", "Dunglegang", "Gosarling", "Kikhorthang", "Mendrelgang", "Patshaling", "Phuntenchu", "Rangthangling", "Semjong", "Sergithang", "Tsholingkhar", "Tsirangtoe", "Athang", "Bjendag", "Darkar", "Dangchu", "Gangteng", "Gasetsho Gom", "Gasetsho Wom", "Kazhi", "Nahi", "Nyisho", "Phangyul", "Phobji", "Ruepisa", "Sephu", "Thedtsho", "Bardo", "Bjoka", "Goshing", "Nangkor", "Ngangla", "Phangkhar", "Shingkhar", "Trong"})
        Me.voterGewog.Location = New System.Drawing.Point(144, 285)
        Me.voterGewog.Margin = New System.Windows.Forms.Padding(2)
        Me.voterGewog.Name = "voterGewog"
        Me.voterGewog.Size = New System.Drawing.Size(200, 20)
        Me.voterGewog.TabIndex = 22
        '
        'voterConstituency
        '
        Me.voterConstituency.FormattingEnabled = True
        Me.voterConstituency.Items.AddRange(New Object() {"Chhoekhor Tang", "Chhumig Ura", "Bongo Chapchha", "Phuentshogling", "Drukjeygang Tseza", "Lhamoi Dzingkha Tashiding", "Khamaed Lunana", "Khatoed Laya", "Bji Kar Tshog Uesu", "Sombaykha", "Gangzur Minjey", "Maenbi Tsaenkhar", "Dramedtse Ngatshang", "Kengkhar Weringla", "Monggar", "Dokar Sharpa", "Lamgong Wangchang", "Khar Yurung", "Nanong Shumar", "Nganglam", "Kabisa Talog", "Lingmukha Toedwang", "Dewathang Gomdar", "Jomotshangkha Martshala", "Dophuchen Tading", "Phuentshogpelri Samtse", "Tashichhoeling", "Ugyentse Yoeseltse", "Gelegphu", "Shompangkha", "Bomdeling Jamkhar", "Khamdang Ramjar", "North Thimphu", "South Thimphu", "Bartsham Shongphu", "Kanglung Samkhar Udzorong", "Radhi Sakteng", "Thrimshing", "Wamrong", "Draagteng Langthil", "Nubi Tangsibji", "Kilkhorthang Mendrelgang", "Sergithang Tsirang Toed", "Athang Thedtsho", "Nyishog Saephu", "Bardo Trong", "Panbang"})
        Me.voterConstituency.Location = New System.Drawing.Point(144, 261)
        Me.voterConstituency.Margin = New System.Windows.Forms.Padding(2)
        Me.voterConstituency.Name = "voterConstituency"
        Me.voterConstituency.Size = New System.Drawing.Size(200, 20)
        Me.voterConstituency.TabIndex = 23
        '
        'voterPhotoBox
        '
        Me.voterPhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.voterPhotoBox.Location = New System.Drawing.Point(403, 134)
        Me.voterPhotoBox.Margin = New System.Windows.Forms.Padding(2)
        Me.voterPhotoBox.Name = "voterPhotoBox"
        Me.voterPhotoBox.Size = New System.Drawing.Size(144, 156)
        Me.voterPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.voterPhotoBox.TabIndex = 25
        Me.voterPhotoBox.TabStop = False
        '
        'voterFingerImageBox
        '
        Me.voterFingerImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.voterFingerImageBox.Location = New System.Drawing.Point(552, 134)
        Me.voterFingerImageBox.Margin = New System.Windows.Forms.Padding(2)
        Me.voterFingerImageBox.Name = "voterFingerImageBox"
        Me.voterFingerImageBox.Size = New System.Drawing.Size(137, 156)
        Me.voterFingerImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.voterFingerImageBox.TabIndex = 26
        Me.voterFingerImageBox.TabStop = False
        '
        'openImageButton
        '
        Me.openImageButton.Location = New System.Drawing.Point(403, 295)
        Me.openImageButton.Margin = New System.Windows.Forms.Padding(2)
        Me.openImageButton.Name = "openImageButton"
        Me.openImageButton.Size = New System.Drawing.Size(144, 42)
        Me.openImageButton.TabIndex = 27
        Me.openImageButton.Text = "Open Image"
        Me.openImageButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.saveButton.Location = New System.Drawing.Point(290, 427)
        Me.saveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(192, 68)
        Me.saveButton.TabIndex = 29
        Me.saveButton.Text = "Submit Registration"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'voterDob
        '
        Me.voterDob.Location = New System.Drawing.Point(144, 188)
        Me.voterDob.Name = "voterDob"
        Me.voterDob.Size = New System.Drawing.Size(200, 19)
        Me.voterDob.TabIndex = 32
        '
        'voterVillage
        '
        Me.voterVillage.Location = New System.Drawing.Point(144, 310)
        Me.voterVillage.Name = "voterVillage"
        Me.voterVillage.Size = New System.Drawing.Size(200, 19)
        Me.voterVillage.TabIndex = 33
        '
        'voterPollingStation
        '
        Me.voterPollingStation.Location = New System.Drawing.Point(144, 335)
        Me.voterPollingStation.Name = "voterPollingStation"
        Me.voterPollingStation.Size = New System.Drawing.Size(200, 19)
        Me.voterPollingStation.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 12)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Polling Station"
        '
        'formTitle
        '
        Me.formTitle.AutoSize = True
        Me.formTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.formTitle.Location = New System.Drawing.Point(197, 36)
        Me.formTitle.Name = "formTitle"
        Me.formTitle.Size = New System.Drawing.Size(369, 35)
        Me.formTitle.TabIndex = 36
        Me.formTitle.Text = "Voter Registration Form"
        Me.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'voterNationalId
        '
        Me.voterNationalId.Location = New System.Drawing.Point(144, 117)
        Me.voterNationalId.Name = "voterNationalId"
        Me.voterNationalId.Size = New System.Drawing.Size(200, 19)
        Me.voterNationalId.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 12)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "House Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 528)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.voterNationalId)
        Me.Controls.Add(Me.formTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.voterPollingStation)
        Me.Controls.Add(Me.voterVillage)
        Me.Controls.Add(Me.voterDob)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.openImageButton)
        Me.Controls.Add(Me.voterFingerImageBox)
        Me.Controls.Add(Me.voterPhotoBox)
        Me.Controls.Add(Me.voterConstituency)
        Me.Controls.Add(Me.voterGewog)
        Me.Controls.Add(Me.voterDzongkhag)
        Me.Controls.Add(Me.voterSex)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.voterName)
        Me.Controls.Add(Me.voterHouseNumber)
        Me.Controls.Add(Me.registrationStatus)
        Me.Controls.Add(Me.registerFingerPrintButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.voterPhotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voterFingerImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents registerFingerPrintButton As System.Windows.Forms.Button
    Friend WithEvents registrationStatus As System.Windows.Forms.Label
    Friend WithEvents voterHouseNumber As TextBox
    Friend WithEvents voterName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents voterSex As ComboBox
    Friend WithEvents voterDzongkhag As ComboBox
    Friend WithEvents voterGewog As ComboBox
    Friend WithEvents voterConstituency As ComboBox
    Friend WithEvents voterPhotoBox As PictureBox
    Friend WithEvents voterFingerImageBox As PictureBox
    Friend WithEvents openImageButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents voterDob As DateTimePicker
    Friend WithEvents voterVillage As TextBox
    Friend WithEvents voterPollingStation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents formTitle As Label
    Friend WithEvents voterNationalId As TextBox
    Friend WithEvents Label12 As Label
End Class
