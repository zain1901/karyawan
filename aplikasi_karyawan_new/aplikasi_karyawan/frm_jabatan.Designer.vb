<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jabatan
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
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnamajabatan = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtgajipokok = New System.Windows.Forms.TextBox
        Me.btnhapus = New System.Windows.Forms.Button
        Me.btnperbaiki = New System.Windows.Forms.Button
        Me.btnkeluar = New System.Windows.Forms.Button
        Me.txtid = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(12, 141)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(117, 37)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Jabatan"
        '
        'txtnamajabatan
        '
        Me.txtnamajabatan.Location = New System.Drawing.Point(126, 47)
        Me.txtnamajabatan.Name = "txtnamajabatan"
        Me.txtnamajabatan.Size = New System.Drawing.Size(143, 20)
        Me.txtnamajabatan.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(862, 215)
        Me.DataGridView1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gaji Pokok"
        '
        'txtgajipokok
        '
        Me.txtgajipokok.Location = New System.Drawing.Point(126, 76)
        Me.txtgajipokok.Name = "txtgajipokok"
        Me.txtgajipokok.Size = New System.Drawing.Size(143, 20)
        Me.txtgajipokok.TabIndex = 2
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(135, 141)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(117, 37)
        Me.btnhapus.TabIndex = 0
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnperbaiki
        '
        Me.btnperbaiki.Location = New System.Drawing.Point(258, 141)
        Me.btnperbaiki.Name = "btnperbaiki"
        Me.btnperbaiki.Size = New System.Drawing.Size(117, 37)
        Me.btnperbaiki.TabIndex = 0
        Me.btnperbaiki.Text = "Perbaiki"
        Me.btnperbaiki.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(381, 141)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(117, 37)
        Me.btnkeluar.TabIndex = 0
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(126, 21)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(143, 20)
        Me.txtid.TabIndex = 4
        Me.txtid.Visible = False
        '
        'frm_jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 411)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtgajipokok)
        Me.Controls.Add(Me.txtnamajabatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnperbaiki)
        Me.Controls.Add(Me.btnsimpan)
        Me.Name = "frm_jabatan"
        Me.Text = "frm_jabatan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnamajabatan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtgajipokok As System.Windows.Forms.TextBox
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnperbaiki As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
