Public Class frm_jabatan

    Private Sub frm_jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        Call tampil()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        konek()

        strcon = "insert into jabatan " _
        + "values (''," _
        + "'" & txtnamajabatan.Text & "'," _
        + "'" & txtgajipokok.Text & "')"

        'MsgBox(strcon)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("data berhasil disimpan")

        Call tampil()
    End Sub
    Sub tampil()
        da = New Odbc.OdbcDataAdapter("select * from jabatan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jabatan")
        DataGridView1.DataSource = (ds.Tables("jabatan"))
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dim pesan As Integer
        pesan = MsgBox("Apakah Anda Akan Keluar Dari Aplikasi ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If pesan = vbNo Then Exit Sub
        End
    End Sub

    Private Sub btnperbaiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnperbaiki.Click
        strcon = "UPDATE jabatan SET " _
       + "nama_jabatan            = '" & txtnamajabatan.Text & "'," _
       + "gaji_pokok    = '" & txtgajipokok.Text & "'" _
       + " WHERE id_jabatan = '" & txtid.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        'Call tampil_data()
        Form1.DataGridView1.Refresh()
        Call tampil()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        set_editjabatan(e.RowIndex)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            txtid.Text = DataGridView1.Rows(x).Cells(0).Value
            txtnamajabatan.Text = DataGridView1.Rows(x).Cells(1).Value
            txtgajipokok.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click

    End Sub
End Class