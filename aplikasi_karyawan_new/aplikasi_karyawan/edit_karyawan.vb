Public Class edit_karyawan

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        strcon = "UPDATE karyawan SET " _
       + "nama             = '" & txtnama.Text & "'," _
       + "tempat_lahir     = '" & txttempatlahir.Text & "'," _
       + "tgl_lahir        = '" & cmbtgllahir.Text & "'," _
       + "agama            = '" & cmbagama.Text & "'," _
       + "status           = '" & cmbstatus.Text & "'," _
       + "kewarganegaraan  = '" & cmbkewarganegaraan.Text & "'," _
       + "no_hp            = '" & txtnohp.Text & "'," _
       + "email            = '" & txtemail.Text & "'," _
       + "alamat           = '" & txtalamat.Text & "'," _
       + "pendidikan_terakhir= '" & cmbpendidikanterakhir.Text & "'," _
       + "pt_terakhir      = '" & cmbpendidikanterakhir.Text & "'," _
       + "jabatan          = '" & txtjabatan.Text & "'," _
       + "tgl_masuk        = '" & cmbtglmasuk.Text & "'," _
       + "bagian           = '" & txtbagian.Text & "'," _
       + "gaji             = '" & txtgaji.Text & "'," _
       + "status_karyawan  = '" & cmbstatuskaryawan.Text & "'," _
       + "status_kerja     = '" & cmbstatuskerja.Text & "'" _
       + " WHERE nik       = '" & txtnik.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        Call tampil_data()
        Form1.DataGridView1.Refresh()

    End Sub

    Private Sub edit_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil_data()

        'txtnik.Enabled = False
        'konek()
        'cmd = New Odbc.OdbcCommand("SELECT * FROM karyawan WHERE nik='" & txtnik.Text & "'", conn)
        'rd = cmd.ExecuteReader
        'If rd.Read Then
        'txtnama.Text = rd(1).ToString
        'txtnama.Text = rd(1).ToString
        'txttempatlahir.Text = rd(2).ToString
        'cmbtgllahir.Text = rd(3).ToString
        'cmbagama.Text = rd(4).ToString
        'cmbstatus.Text = rd(5).ToString
        'cmbkewarganegaraan.Text = rd(6).ToString
        'txtnohp.Text = rd(7).ToString
        'txtemail.Text = rd(8).ToString
        'txtalamat.Text = rd(9).ToString
        'cmbpendidikanterakhir.Text = rd(10).ToString
        'txtperguruantinggi.Text = rd(11).ToString
        'txtjabatan.Text = rd(12).ToString
        'cmbtglmasuk.Text = rd(13).ToString
        'txtbagian.Text = rd(14).ToString
        'txtgaji.Text = rd(15).ToString
        'cmbstatuskaryawan.Text = rd(16).ToString
        'cmbstatuskerja.Text = rd(17).ToString
        'Else
        'Exit Sub
        'MsgBox("tidak ditemukan")
        'End If
        'conn.Close()
    End Sub

    Sub tampil_data()
        txtnik.Enabled = False
        konek()
        cmd = New Odbc.OdbcCommand("SELECT * FROM karyawan WHERE nik ='" & txtnik.Text & "'", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtnama.Text = rd(1).ToString
            txttempatlahir.Text = rd(2).ToString
            cmbtgllahir.Text = rd(3).ToString
            cmbagama.Text = rd(4).ToString
            cmbstatus.Text = rd(5).ToString
            cmbkewarganegaraan.Text = rd(6).ToString
            txtnohp.Text = rd(7).ToString
            txtemail.Text = rd(8).ToString
            txtalamat.Text = rd(9).ToString
            cmbpendidikanterakhir.Text = rd(10).ToString
            cmbpendidikanterakhir.Text = rd(11).ToString
            txtjabatan.Text = rd(12).ToString
            cmbtglmasuk.Text = rd(13).ToString
            txtbagian.Text = rd(14).ToString
            txtgaji.Text = rd(15).ToString
            cmbstatuskaryawan.Text = rd(16).ToString
            cmbstatuskerja.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak ditemukan")
        End If
        'conn.Close() 
    End Sub

End Class