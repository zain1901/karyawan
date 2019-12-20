<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lembur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lembur))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnperbaiki = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtuang = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtjum = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttanggallembur = New System.Windows.Forms.TextBox
        Me.cmbjabatan = New System.Windows.Forms.ComboBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1085, 248)
        Me.DataGridView1.TabIndex = 43
        '
        'btnkeluar
        '
        Me.btnkeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(381, 182)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(117, 43)
        Me.btnkeluar.TabIndex = 42
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(135, 182)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(117, 43)
        Me.btnhapus.TabIndex = 41
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnperbaiki
        '
        Me.btnperbaiki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnperbaiki.Image = CType(resources.GetObject("btnperbaiki.Image"), System.Drawing.Image)
        Me.btnperbaiki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnperbaiki.Location = New System.Drawing.Point(258, 182)
        Me.btnperbaiki.Name = "btnperbaiki"
        Me.btnperbaiki.Size = New System.Drawing.Size(117, 43)
        Me.btnperbaiki.TabIndex = 40
        Me.btnperbaiki.Text = "Perbaiki"
        Me.btnperbaiki.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(12, 182)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(117, 43)
        Me.btnsimpan.TabIndex = 39
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(718, 82)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(250, 21)
        Me.txttotal.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(578, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Total Uang Lembur"
        '
        'txtuang
        '
        Me.txtuang.Location = New System.Drawing.Point(718, 52)
        Me.txtuang.Name = "txtuang"
        Me.txtuang.Size = New System.Drawing.Size(250, 21)
        Me.txtuang.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(578, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Uang Lembur"
        '
        'txtjum
        '
        Me.txtjum.Location = New System.Drawing.Point(718, 22)
        Me.txtjum.Name = "txtjum"
        Me.txtjum.Size = New System.Drawing.Size(250, 21)
        Me.txtjum.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.ImageKey = "(none)"
        Me.Label10.Location = New System.Drawing.Point(578, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Jam Lembur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ID Jabatan"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(152, 52)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(250, 21)
        Me.txtnama.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama Karyawan"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(152, 22)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(250, 21)
        Me.txtnik.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tgl Lembur"
        '
        'txttanggallembur
        '
        Me.txttanggallembur.Location = New System.Drawing.Point(152, 112)
        Me.txttanggallembur.Name = "txttanggallembur"
        Me.txttanggallembur.Size = New System.Drawing.Size(250, 21)
        Me.txttanggallembur.TabIndex = 30
        '
        'cmbjabatan
        '
        Me.cmbjabatan.FormattingEnabled = True
        Me.cmbjabatan.Location = New System.Drawing.Point(152, 82)
        Me.cmbjabatan.Name = "cmbjabatan"
        Me.cmbjabatan.Size = New System.Drawing.Size(249, 23)
        Me.cmbjabatan.TabIndex = 44
        '
        'frm_lembur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1109, 500)
        Me.Controls.Add(Me.cmbjabatan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnperbaiki)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtuang)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtjum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttanggallembur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Minion Pro Med", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_lembur"
        Me.Text = "frm_lembur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnperbaiki As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtuang As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtjum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttanggallembur As System.Windows.Forms.TextBox
    Friend WithEvents cmbjabatan As System.Windows.Forms.ComboBox
End Class
