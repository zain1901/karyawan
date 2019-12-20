<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tambah_karyawan))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.cmbtgllahir = New System.Windows.Forms.DateTimePicker
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.cmbpendidikanterakhir = New System.Windows.Forms.ComboBox
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.txtperguruantinggi = New System.Windows.Forms.TextBox
        Me.cmbtglmasuk = New System.Windows.Forms.DateTimePicker
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rr = New System.Windows.Forms.Label
        Me.ss = New System.Windows.Forms.Label
        Me.www = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ccc = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.pctgbr = New System.Windows.Forms.PictureBox
        Me.lblpath = New System.Windows.Forms.Label
        Me.btnpilih = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtnamagambar = New System.Windows.Forms.TextBox
        CType(Me.pctgbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nik"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(129, 29)
        Me.txtnik.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(162, 20)
        Me.txtnik.TabIndex = 1
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(129, 75)
        Me.txttempatlahir.Margin = New System.Windows.Forms.Padding(2)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(162, 20)
        Me.txttempatlahir.TabIndex = 2
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(129, 52)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(162, 20)
        Me.txtnama.TabIndex = 3
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Nikah", "Belum Nikah"})
        Me.cmbstatus.Location = New System.Drawing.Point(129, 145)
        Me.cmbstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(162, 21)
        Me.cmbstatus.TabIndex = 4
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Khongfucu", "Hindu", "Buda"})
        Me.cmbagama.Location = New System.Drawing.Point(129, 120)
        Me.cmbagama.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(162, 21)
        Me.cmbagama.TabIndex = 5
        '
        'cmbtgllahir
        '
        Me.cmbtgllahir.CustomFormat = " yyyy-MM-dd"
        Me.cmbtgllahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbtgllahir.Location = New System.Drawing.Point(129, 98)
        Me.cmbtgllahir.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbtgllahir.Name = "cmbtgllahir"
        Me.cmbtgllahir.Size = New System.Drawing.Size(162, 20)
        Me.cmbtgllahir.TabIndex = 6
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(129, 169)
        Me.cmbkewarganegaraan.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(162, 21)
        Me.cmbkewarganegaraan.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(129, 217)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(162, 20)
        Me.txtemail.TabIndex = 10
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(129, 240)
        Me.txtalamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(162, 51)
        Me.txtalamat.TabIndex = 9
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(129, 194)
        Me.txtnohp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(162, 20)
        Me.txtnohp.TabIndex = 8
        '
        'cmbpendidikanterakhir
        '
        Me.cmbpendidikanterakhir.FormattingEnabled = True
        Me.cmbpendidikanterakhir.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.cmbpendidikanterakhir.Location = New System.Drawing.Point(478, 29)
        Me.cmbpendidikanterakhir.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbpendidikanterakhir.Name = "cmbpendidikanterakhir"
        Me.cmbpendidikanterakhir.Size = New System.Drawing.Size(162, 21)
        Me.cmbpendidikanterakhir.TabIndex = 12
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(478, 76)
        Me.txtjabatan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(162, 20)
        Me.txtjabatan.TabIndex = 15
        '
        'txtperguruantinggi
        '
        Me.txtperguruantinggi.Location = New System.Drawing.Point(478, 54)
        Me.txtperguruantinggi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtperguruantinggi.Name = "txtperguruantinggi"
        Me.txtperguruantinggi.Size = New System.Drawing.Size(162, 20)
        Me.txtperguruantinggi.TabIndex = 13
        '
        'cmbtglmasuk
        '
        Me.cmbtglmasuk.CustomFormat = " yyyy-MM-dd"
        Me.cmbtglmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbtglmasuk.Location = New System.Drawing.Point(478, 99)
        Me.cmbtglmasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbtglmasuk.Name = "cmbtglmasuk"
        Me.cmbtglmasuk.Size = New System.Drawing.Size(162, 20)
        Me.cmbtglmasuk.TabIndex = 16
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(478, 145)
        Me.txtgaji.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(162, 20)
        Me.txtgaji.TabIndex = 18
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(478, 122)
        Me.txtbagian.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(162, 20)
        Me.txtbagian.TabIndex = 17
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"Tetap", "Kontrak"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(478, 167)
        Me.cmbstatuskaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(162, 21)
        Me.cmbstatuskaryawan.TabIndex = 19
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(478, 192)
        Me.cmbstatuskerja.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(162, 21)
        Me.cmbstatuskerja.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nama"
        '
        'rr
        '
        Me.rr.AutoSize = True
        Me.rr.Location = New System.Drawing.Point(34, 78)
        Me.rr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rr.Name = "rr"
        Me.rr.Size = New System.Drawing.Size(69, 13)
        Me.rr.TabIndex = 0
        Me.rr.Text = "Tempat Lahir"
        '
        'ss
        '
        Me.ss.AutoSize = True
        Me.ss.Location = New System.Drawing.Point(33, 100)
        Me.ss.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(48, 13)
        Me.ss.TabIndex = 21
        Me.ss.Text = "Tgl Lahir"
        '
        'www
        '
        Me.www.AutoSize = True
        Me.www.Location = New System.Drawing.Point(34, 122)
        Me.www.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.www.Name = "www"
        Me.www.Size = New System.Drawing.Size(40, 13)
        Me.www.TabIndex = 0
        Me.www.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Kewarganegaraan"
        '
        'ccc
        '
        Me.ccc.AutoSize = True
        Me.ccc.Location = New System.Drawing.Point(33, 146)
        Me.ccc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ccc.Name = "ccc"
        Me.ccc.Size = New System.Drawing.Size(37, 13)
        Me.ccc.TabIndex = 21
        Me.ccc.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "No. Hp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 220)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 243)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(370, 194)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Status Kerja"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(370, 100)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Tgl Masuk"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(370, 146)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Gaji"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(370, 55)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Perguruan Tinggi"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(371, 171)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Status Karyawan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(371, 78)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Jabatan"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(371, 122)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Bagian"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(371, 32)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Pendidikian Terakhir"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsimpan.CausesValidation = False
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(537, 503)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(103, 31)
        Me.btnsimpan.TabIndex = 32
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'pctgbr
        '
        Me.pctgbr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pctgbr.Location = New System.Drawing.Point(301, 240)
        Me.pctgbr.Name = "pctgbr"
        Me.pctgbr.Size = New System.Drawing.Size(174, 181)
        Me.pctgbr.TabIndex = 33
        Me.pctgbr.TabStop = False
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(481, 263)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(39, 13)
        Me.lblpath.TabIndex = 35
        Me.lblpath.Text = "Label3"
        '
        'btnpilih
        '
        Me.btnpilih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpilih.Image = CType(resources.GetObject("btnpilih.Image"), System.Drawing.Image)
        Me.btnpilih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpilih.Location = New System.Drawing.Point(481, 279)
        Me.btnpilih.Name = "btnpilih"
        Me.btnpilih.Size = New System.Drawing.Size(82, 20)
        Me.btnpilih.TabIndex = 34
        Me.btnpilih.Text = "Pilih"
        Me.btnpilih.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtnamagambar
        '
        Me.txtnamagambar.Location = New System.Drawing.Point(481, 240)
        Me.txtnamagambar.Name = "txtnamagambar"
        Me.txtnamagambar.Size = New System.Drawing.Size(159, 20)
        Me.txtnamagambar.TabIndex = 36
        '
        'tambah_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 546)
        Me.Controls.Add(Me.txtnamagambar)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.btnpilih)
        Me.Controls.Add(Me.pctgbr)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ss)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ccc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbstatuskerja)
        Me.Controls.Add(Me.cmbstatuskaryawan)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtbagian)
        Me.Controls.Add(Me.cmbtglmasuk)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtperguruantinggi)
        Me.Controls.Add(Me.cmbpendidikanterakhir)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.cmbkewarganegaraan)
        Me.Controls.Add(Me.cmbtgllahir)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rr)
        Me.Controls.Add(Me.www)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "tambah_karyawan"
        Me.Text = "tambah_karyawan"
        CType(Me.pctgbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents cmbpendidikanterakhir As System.Windows.Forms.ComboBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtperguruantinggi As System.Windows.Forms.TextBox
    Friend WithEvents cmbtglmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rr As System.Windows.Forms.Label
    Friend WithEvents ss As System.Windows.Forms.Label
    Friend WithEvents www As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ccc As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents pctgbr As System.Windows.Forms.PictureBox
    Friend WithEvents lblpath As System.Windows.Forms.Label
    Friend WithEvents btnpilih As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtnamagambar As System.Windows.Forms.TextBox
End Class
