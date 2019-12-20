<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gaji
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnoslip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnamajabatan = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtgajipokok = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttunjangan = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtuanglembur = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtpotbpjskes = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtpotbpjsket = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtpotlain2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtnorek = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtnamarekening = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtnamabank = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txttotalgaji = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnperbaiki = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.cmbidjabatan = New System.Windows.Forms.ComboBox
        Me.dtptglgaji = New System.Windows.Forms.DateTimePicker
        Me.txtidgaji = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Slip"
        '
        'txtnoslip
        '
        Me.txtnoslip.Location = New System.Drawing.Point(152, 24)
        Me.txtnoslip.Name = "txtnoslip"
        Me.txtnoslip.Size = New System.Drawing.Size(250, 20)
        Me.txtnoslip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NIK"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(152, 50)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(250, 20)
        Me.txtnik.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tgl Gaji"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nama Jabatan"
        '
        'txtnamajabatan
        '
        Me.txtnamajabatan.Location = New System.Drawing.Point(152, 128)
        Me.txtnamajabatan.Name = "txtnamajabatan"
        Me.txtnamajabatan.Size = New System.Drawing.Size(250, 20)
        Me.txtnamajabatan.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gaji Pokok"
        '
        'txtgajipokok
        '
        Me.txtgajipokok.Location = New System.Drawing.Point(152, 154)
        Me.txtgajipokok.Name = "txtgajipokok"
        Me.txtgajipokok.Size = New System.Drawing.Size(250, 20)
        Me.txtgajipokok.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tunjangan"
        '
        'txttunjangan
        '
        Me.txttunjangan.Location = New System.Drawing.Point(152, 180)
        Me.txttunjangan.Name = "txttunjangan"
        Me.txttunjangan.Size = New System.Drawing.Size(250, 20)
        Me.txttunjangan.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Uang Lembur"
        '
        'txtuanglembur
        '
        Me.txtuanglembur.Location = New System.Drawing.Point(152, 206)
        Me.txtuanglembur.Name = "txtuanglembur"
        Me.txtuanglembur.Size = New System.Drawing.Size(250, 20)
        Me.txtuanglembur.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(578, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Pot BPJS Kes"
        '
        'txtpotbpjskes
        '
        Me.txtpotbpjskes.Location = New System.Drawing.Point(718, 24)
        Me.txtpotbpjskes.Name = "txtpotbpjskes"
        Me.txtpotbpjskes.Size = New System.Drawing.Size(250, 20)
        Me.txtpotbpjskes.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(578, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Pot BPJS Ket"
        '
        'txtpotbpjsket
        '
        Me.txtpotbpjsket.Location = New System.Drawing.Point(718, 50)
        Me.txtpotbpjsket.Name = "txtpotbpjsket"
        Me.txtpotbpjsket.Size = New System.Drawing.Size(250, 20)
        Me.txtpotbpjsket.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(578, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Pot Lain2"
        '
        'txtpotlain2
        '
        Me.txtpotlain2.Location = New System.Drawing.Point(718, 76)
        Me.txtpotlain2.Name = "txtpotlain2"
        Me.txtpotlain2.Size = New System.Drawing.Size(250, 20)
        Me.txtpotlain2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(578, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "No Rek"
        '
        'txtnorek
        '
        Me.txtnorek.Location = New System.Drawing.Point(718, 102)
        Me.txtnorek.Name = "txtnorek"
        Me.txtnorek.Size = New System.Drawing.Size(250, 20)
        Me.txtnorek.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(578, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nama Rekening"
        '
        'txtnamarekening
        '
        Me.txtnamarekening.Location = New System.Drawing.Point(718, 128)
        Me.txtnamarekening.Name = "txtnamarekening"
        Me.txtnamarekening.Size = New System.Drawing.Size(250, 20)
        Me.txtnamarekening.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(578, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Nama Bank"
        '
        'txtnamabank
        '
        Me.txtnamabank.Location = New System.Drawing.Point(718, 154)
        Me.txtnamabank.Name = "txtnamabank"
        Me.txtnamabank.Size = New System.Drawing.Size(250, 20)
        Me.txtnamabank.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(578, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Total Gaji"
        '
        'txttotalgaji
        '
        Me.txttotalgaji.Location = New System.Drawing.Point(718, 180)
        Me.txttotalgaji.Name = "txttotalgaji"
        Me.txttotalgaji.Size = New System.Drawing.Size(250, 20)
        Me.txttotalgaji.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1085, 215)
        Me.DataGridView1.TabIndex = 8
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(381, 240)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(117, 37)
        Me.btnkeluar.TabIndex = 7
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(135, 240)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(117, 37)
        Me.btnhapus.TabIndex = 6
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnperbaiki
        '
        Me.btnperbaiki.Location = New System.Drawing.Point(258, 240)
        Me.btnperbaiki.Name = "btnperbaiki"
        Me.btnperbaiki.Size = New System.Drawing.Size(117, 37)
        Me.btnperbaiki.TabIndex = 5
        Me.btnperbaiki.Text = "Perbaiki"
        Me.btnperbaiki.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(12, 240)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(117, 37)
        Me.btnsimpan.TabIndex = 4
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'cmbidjabatan
        '
        Me.cmbidjabatan.FormattingEnabled = True
        Me.cmbidjabatan.Location = New System.Drawing.Point(152, 102)
        Me.cmbidjabatan.Name = "cmbidjabatan"
        Me.cmbidjabatan.Size = New System.Drawing.Size(250, 21)
        Me.cmbidjabatan.TabIndex = 9
        '
        'dtptglgaji
        '
        Me.dtptglgaji.CustomFormat = "yyyy-MM-dd"
        Me.dtptglgaji.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglgaji.Location = New System.Drawing.Point(152, 77)
        Me.dtptglgaji.Name = "dtptglgaji"
        Me.dtptglgaji.Size = New System.Drawing.Size(100, 20)
        Me.dtptglgaji.TabIndex = 10
        '
        'txtidgaji
        '
        Me.txtidgaji.Location = New System.Drawing.Point(152, -2)
        Me.txtidgaji.Name = "txtidgaji"
        Me.txtidgaji.Size = New System.Drawing.Size(103, 20)
        Me.txtidgaji.TabIndex = 11
        '
        'frm_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 509)
        Me.Controls.Add(Me.txtidgaji)
        Me.Controls.Add(Me.dtptglgaji)
        Me.Controls.Add(Me.cmbidjabatan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnperbaiki)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txttotalgaji)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtnamabank)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtnamarekening)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtnorek)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtpotlain2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpotbpjsket)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtpotbpjskes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtuanglembur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttunjangan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtgajipokok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnamajabatan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnoslip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_gaji"
        Me.Text = "  "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnoslip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnamajabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtgajipokok As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttunjangan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtuanglembur As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpotbpjskes As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtpotbpjsket As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpotlain2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtnorek As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtnamarekening As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtnamabank As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttotalgaji As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnperbaiki As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents cmbidjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents dtptglgaji As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtidgaji As System.Windows.Forms.TextBox
End Class
