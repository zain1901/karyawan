Imports System.Data.Odbc
Public Class tambah_karyawan
    Private PathFile As String = Nothing

    Private Sub tambah_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbtglmasuk_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtglmasuk.ValueChanged

    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        konek()

        'strcon = "insert into karyawan " _
        '+ "values ('" & txtnik.Text & "'," _
        '+ "'" & txtnama.Text & "'," _
        '+ "'" & txttempatlahir.Text & "'," _
        '+ "'" & cmbtgllahir.Text & "'," _
        '+ "'" & cmbagama.Text & "'," _
        '+ "'" & cmbstatus.Text & "'," _
        '+ "'" & cmbkewarganegaraan.Text & "'," _
        '+ "'" & txtnohp.Text & "'," _
        '+ "'" & txtemail.Text & "'," _
        '+ "'" & txtalamat.Text & "'," _
        '+ "'" & cmbpendidikanterakhir.Text & "'," _
        '+ "'" & txtperguruantinggi.Text & "'," _
        '+ "'" & txtjabatan.Text & "'," _
        '+ "'" & cmbtglmasuk.Text & "'," _
        '+ "'" & txtbagian.Text & "'," _
        '+ "'" & txtgaji.Text & "'," _
        '+ "'" & cmbstatuskaryawan.Text & "'," _
        '+ "'" & cmbstatuskerja.Text & "')"

        ''MsgBox(strcon)
        'Dim cmd As New Odbc.OdbcCommand
        'cmd.Connection = conn
        'cmd.CommandText = strcon
        'cmd.ExecuteNonQuery()
        'conn.Close()
        'MsgBox("data berhasil disimpan")

        Try
            strcon = "Insert into karyawan(nik,nama,tempat_lahir,tgl_lahir,agama,status,kewarganegaraan,no_hp,email,alamat,pendidikan_terakhir,pt_terakhir,jabatan,tgl_masuk,bagian,gaji,status_karyawan,status_kerja,nama_gambar,lokasi_gambar)values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
            With mycomm.Parameters
                .Add("?", OdbcType.VarChar, 15).Value = txtnik.Text.Trim
                .Add("?", OdbcType.VarChar, 30).Value = txtnama.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txttempatlahir.Text.Trim
                .Add("?", OdbcType.Date).Value = cmbtgllahir.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbagama.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatus.Text.Trim
                .Add("?", OdbcType.VarChar, 3).Value = cmbkewarganegaraan.Text.Trim
                .Add("?", OdbcType.VarChar, 13).Value = txtnohp.Text.Trim
                .Add("?", OdbcType.VarChar, 25).Value = txtemail.Text.Trim
                .Add("?", OdbcType.VarChar, 35).Value = txtalamat.Text.Trim
                .Add("?", OdbcType.VarChar, 4).Value = cmbpendidikanterakhir.Text.Trim
                .Add("?", OdbcType.VarChar, 40).Value = txtperguruantinggi.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtjabatan.Text.Trim
                .Add("?", OdbcType.Date).Value = cmbtglmasuk.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = txtbagian.Text.Trim
                .Add("?", OdbcType.VarChar, 10).Value = txtgaji.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskaryawan.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = cmbstatuskerja.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = txtnamagambar.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = lblpath.Text.Trim
            End With

            mycomm.ExecuteNonQuery()
            mycomm = Nothing
            MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilih.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg| JPEG Files(*.jpeg)|*.jpeg| GIF Files(*.gif)|*.gif| PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctgbr.SizeMode = PictureBoxSizeMode.StretchImage
            pctgbr.Image = New Bitmap(OpenFileDialog1.FileName)
            btnpilih.Enabled = True
            PathFile = OpenFileDialog1.FileName
            txtnamagambar.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            lblpath.Text = OpenFileDialog1.FileName
            pctgbr.Image = Image.FromFile(lblpath.Text)
        End If
        pctgbr.Visible = True
    End Sub
End Class