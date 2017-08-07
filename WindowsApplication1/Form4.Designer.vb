<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.candidateResidenceID = New System.Windows.Forms.TextBox()
        Me.candidateHouseNumber = New System.Windows.Forms.TextBox()
        Me.candidateName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.candidateSex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.candidateDob = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.candidateDzongkhag = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.candidateConstituency = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.candidateGewog = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.candidateVillage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.candidateImageBox = New System.Windows.Forms.PictureBox()
        Me.candidateImageButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.candidateImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'candidateResidenceID
        '
        Me.candidateResidenceID.Location = New System.Drawing.Point(99, 50)
        Me.candidateResidenceID.Name = "candidateResidenceID"
        Me.candidateResidenceID.Size = New System.Drawing.Size(200, 19)
        Me.candidateResidenceID.TabIndex = 0
        '
        'candidateHouseNumber
        '
        Me.candidateHouseNumber.Location = New System.Drawing.Point(99, 75)
        Me.candidateHouseNumber.Name = "candidateHouseNumber"
        Me.candidateHouseNumber.Size = New System.Drawing.Size(200, 19)
        Me.candidateHouseNumber.TabIndex = 1
        '
        'candidateName
        '
        Me.candidateName.Location = New System.Drawing.Point(99, 100)
        Me.candidateName.Name = "candidateName"
        Me.candidateName.Size = New System.Drawing.Size(200, 19)
        Me.candidateName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Residence ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "House Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name"
        '
        'candidateSex
        '
        Me.candidateSex.FormattingEnabled = True
        Me.candidateSex.Items.AddRange(New Object() {"Male", "Female", "Unspecified"})
        Me.candidateSex.Location = New System.Drawing.Point(99, 126)
        Me.candidateSex.Name = "candidateSex"
        Me.candidateSex.Size = New System.Drawing.Size(200, 20)
        Me.candidateSex.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sex"
        '
        'candidateDob
        '
        Me.candidateDob.Location = New System.Drawing.Point(99, 153)
        Me.candidateDob.Name = "candidateDob"
        Me.candidateDob.Size = New System.Drawing.Size(200, 19)
        Me.candidateDob.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Born"
        '
        'candidateDzongkhag
        '
        Me.candidateDzongkhag.FormattingEnabled = True
        Me.candidateDzongkhag.Items.AddRange(New Object() {"Bumthang", "Chhukha", "Dagana", "Gasa", "Haa", "Lhuentse", "Monggar", "Paro", "Pema Gatshel", "Punakha", "Samdrup Jongkhar", "Samtse", "Sarpang", "Tashi Yangtse", "Thimphu", "Trashigang", "Trongsa", "Tsirang", "Wangdue Phodrang", "Zhemgang"})
        Me.candidateDzongkhag.Location = New System.Drawing.Point(99, 179)
        Me.candidateDzongkhag.Name = "candidateDzongkhag"
        Me.candidateDzongkhag.Size = New System.Drawing.Size(200, 20)
        Me.candidateDzongkhag.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dzongkhag"
        '
        'candidateConstituency
        '
        Me.candidateConstituency.FormattingEnabled = True
        Me.candidateConstituency.Items.AddRange(New Object() {"Chhoekhor Tang", "Chhumig Ura", "Bongo Chapchha", "Phuentshogling", "Drukjeygang Tseza", "Lhamoi Dzingkha Tashiding", "Khamaed Lunana", "Khatoed Laya", "Bji Kar Tshog Uesu", "Sombaykha", "Gangzur Minjey", "Maenbi Tsaenkhar", "Dramedtse Ngatshang", "Kengkhar Weringla", "Monggar", "Dokar Sharpa", "Lamgong Wangchang", "Khar Yurung", "Nanong Shumar", "Nganglam", "Kabisa Talog", "Lingmukha Toedwang", "Dewathang Gomdar", "Jomotshangkha Martshala", "Dophuchen Tading", "Phuentshogpelri Samtse", "Tashichhoeling", "Ugyentse Yoeseltse", "Gelegphu", "Shompangkha", "Bomdeling Jamkhar", "Khamdang Ramjar", "North Thimphu", "South Thimphu", "Bartsham Shongphu", "Kanglung Samkhar Udzorong", "Radhi Sakteng", "Thrimshing", "Wamrong", "Draagteng Langthil", "Nubi Tangsibji", "Kilkhorthang Mendrelgang", "Sergithang Tsirang Toed", "Athang Thedtsho", "Nyishog Saephu", "Bardo Trong", "Panbang"})
        Me.candidateConstituency.Location = New System.Drawing.Point(99, 206)
        Me.candidateConstituency.Name = "candidateConstituency"
        Me.candidateConstituency.Size = New System.Drawing.Size(200, 20)
        Me.candidateConstituency.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Constituency"
        '
        'candidateGewog
        '
        Me.candidateGewog.FormattingEnabled = True
        Me.candidateGewog.Items.AddRange(New Object() {"Chhoekhor", "Chhume", "Tang", "Ura", "Bjachho", "Bongo", "Chapcha", "Darla", "Dungna", "Geling", "Getana", "Lokchina", "Metakha", "Phuentsholing", "Sampheling", "Dorona", "Drujegang", "Gesarling", "Goshi", "Kana", "Karmaling", "Khebisa", "Lajab", "Lhamoi Zingkha", "Nichula", "Trashiding", "Tsangkha", "Tsendagang་", "Tseza", "Khamaed", "Khatoe", "Laya", "Lunana", "Bji", "Gakiling", "Katsho", "Samar", "Sangbay", "Uesu", "Gangzur", "Khoma", "Jarey", "Kurtoed", "Menbi", "Metsho", "Minjay", "Tsenkhar", "Balam", "Chali", "Chaskhar", "Drametse", "Drepong", "Gongdue", "Jurmey", "Kengkhar", "Mongar", "Narang", "Ngatshang", "Saling", "Shermuhoong", "Silambi", "Thangrong", "Tsakaling", "Tsamang", "Dokar", "Dopshari", "Doteng", "Hungrel", "Lamgong", "Lungnyi", "Naja", "Shapa", "Tsento", "Wangchang", "Chimoong", "Chokhorling", "Chongshing", "Dechheling", "Dungmaed", "Khar", "Nanong", "Norbugang", "Shumar", "Yurung", "Zobel", "Barp", "Chhubug", "Dzomi", "Goenshari", "Guma", "Kabisa", "Lingmukha", "Shenga Bjemi", "Talog", "Toepisa", "Toewang", "Dewathang", "Gomdar", "Langchenphu", "Lauri", "Martshala", "Orong", "Pemathang", "Phuntshothang", "Samrang", "Serthi", "Wangphu", "Gewog", "Dungtoe", "Dophoogchen", "Duenchukha", "Namgaychhoeling", "Norbugang", "Norgaygang", "Pemaling", "Phuentshogpelri", "Samtse", "Sangngagchhoeling", "Tading", "Tashicholing", "Tendruk", "Ugentse", "Yoeseltse", "Chhuzagang", "Chhudzom", "Dekiling", "Gakiling", "Gelephu", "Jigmechholing", "Samtenling", "Senggey", "Sherzhong", "Shompangkha", "Tareythang", "Umling", "Chang", "Darkala", "Genye", "Kawang", "Lingzhi", "Mewang", "Naro", "Soe", "Bartsham", "Bidung", "Kanglung", "Kangpar", "Khaling", "Lumang", "Merag", "Phongmed", "Radi", "Sagteng", "Samkhar", "Shongphoog", "Thrimshing", "Uzorong", "Yangnyer", "Bumdeling", "Jamkhar", "Khamdang", "Ramjar", "Toetsho", "Tomzhang", "Yalang", "Yangtse", "Dragteng", "Korphoog", "Langthil", "Nubi", "Tangsibji", "Barshong", "Dunglegang", "Gosarling", "Kikhorthang", "Mendrelgang", "Patshaling", "Phuntenchu", "Rangthangling", "Semjong", "Sergithang", "Tsholingkhar", "Tsirangtoe", "Athang", "Bjendag", "Darkar", "Dangchu", "Gangteng", "Gasetsho Gom", "Gasetsho Wom", "Kazhi", "Nahi", "Nyisho", "Phangyul", "Phobji", "Ruepisa", "Sephu", "Thedtsho", "Bardo", "Bjoka", "Goshing", "Nangkor", "Ngangla", "Phangkhar", "Shingkhar", "Trong"})
        Me.candidateGewog.Location = New System.Drawing.Point(99, 232)
        Me.candidateGewog.Name = "candidateGewog"
        Me.candidateGewog.Size = New System.Drawing.Size(200, 20)
        Me.candidateGewog.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Gewog"
        '
        'candidateVillage
        '
        Me.candidateVillage.Location = New System.Drawing.Point(99, 258)
        Me.candidateVillage.Name = "candidateVillage"
        Me.candidateVillage.Size = New System.Drawing.Size(200, 19)
        Me.candidateVillage.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Village"
        '
        'candidateImageBox
        '
        Me.candidateImageBox.Location = New System.Drawing.Point(373, 65)
        Me.candidateImageBox.Name = "candidateImageBox"
        Me.candidateImageBox.Size = New System.Drawing.Size(158, 177)
        Me.candidateImageBox.TabIndex = 18
        Me.candidateImageBox.TabStop = False
        '
        'candidateImageButton
        '
        Me.candidateImageButton.Location = New System.Drawing.Point(373, 248)
        Me.candidateImageButton.Name = "candidateImageButton"
        Me.candidateImageButton.Size = New System.Drawing.Size(158, 38)
        Me.candidateImageButton.TabIndex = 19
        Me.candidateImageButton.Text = "Open Image File"
        Me.candidateImageButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(371, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 12)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Photo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(199, 306)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(163, 41)
        Me.submitButton.TabIndex = 21
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(174, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(244, 27)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Register Candidate"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 359)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.candidateImageButton)
        Me.Controls.Add(Me.candidateImageBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.candidateVillage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.candidateGewog)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.candidateConstituency)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.candidateDzongkhag)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.candidateDob)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.candidateSex)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.candidateName)
        Me.Controls.Add(Me.candidateHouseNumber)
        Me.Controls.Add(Me.candidateResidenceID)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.candidateImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents candidateResidenceID As TextBox
    Friend WithEvents candidateHouseNumber As TextBox
    Friend WithEvents candidateName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents candidateSex As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents candidateDob As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents candidateDzongkhag As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents candidateConstituency As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents candidateGewog As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents candidateVillage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents candidateImageBox As PictureBox
    Friend WithEvents candidateImageButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents submitButton As Button
    Friend WithEvents Label11 As Label
End Class
