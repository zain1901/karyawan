Public Class frm_gaji

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click

    End Sub


    Sub auto_slip()
        Dim no_slip As String = "TR" + Format(Now, "yyMMdd-hhmmss")
        txtnoslip.Text = no_slip
    End Sub


    Sub tampil()
        konek()
        da = New Odbc.OdbcDataAdapter("select * from gaji", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan from karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "gaji")
        DataGridView1.DataSource = (ds.Tables("gaji"))
    End Sub

    Sub tampil_data()
        txtidgaji.Enabled = False
        konek()
        cmd = New Odbc.OdbcCommand("SELECT * FROM gaji WHERE id_gaji ='" & txtidgaji.Text & "'", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            txtnoslip.Text = rd(1).ToString
            txtnik.Text = rd(2).ToString
            dtptglgaji.Text = rd(3).ToString
            cmbidjabatan.Text = rd(4).ToString
            txtnamajabatan.Text = rd(5).ToString
            txtgajipokok.Text = rd(6).ToString
            txttunjangan.Text = rd(7).ToString
            txtuanglembur.Text = rd(8).ToString
            txtpotbpjskes.Text = rd(9).ToString
            txtpotbpjsket.Text = rd(10).ToString
            txtpotlain2.Text = rd(11).ToString
            txtnorek.Text = rd(12).ToString
            txtnamarekening.Text = rd(13).ToString
            txtnamabank.Text = rd(14).ToString
            txttotalgaji.Text = rd(15).ToString
        Else
            Exit Sub
            MsgBox("Tidak ditemukan")
        End If
    End Sub

    Sub kosongkan()
        txtidgaji.Clear()
        txtnoslip.Clear()
        txtnik.Clear()
        txtnamajabatan.Clear()
        txtgajipokok.Clear()
        txttunjangan.Clear()
        txtuanglembur.Clear()
        txtpotbpjskes.Clear()
        txtpotbpjsket.Clear()
        txtpotlain2.Clear()
        txtnorek.Clear()
        txtnamarekening.Clear()
        txtnamabank.Clear()
        txttotalgaji.Clear()
    End Sub

    Private Sub frm_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call get_idjabatan()
        Call tampil()

        Call auto_slip()

        Call tampil_data()

        txtnoslip.Enabled = False
    End Sub

    Sub get_idjabatan()
        konek()
        da = New Odbc.OdbcDataAdapter("select id_jabatan from jabatan", conn)

        ds = New DataSet
        da.Fill(ds, "jabatan")
        cmbidjabatan.datasource = (ds.Tables("jabatan"))
        cmbidjabatan.valuemember = "id_jabatan"
        cmbidjabatan.displaymember = "id_jabatan"
    End Sub

    Private Sub set_editgaji(ByVal x As Integer)
        Try
            txtidgaji.Text = DataGridView1.Rows(x).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmbidjabatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbidjabatan.SelectedIndexChanged
        konek()
        cmd = New Odbc.OdbcCommand("select nama_jabatan, gaji_pokok from jabatan where id_jabatan = '" & cmbidjabatan.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnamajabatan.Text = rd(0).ToString
            txtgajipokok.Text = rd(1).ToString
        End If
        conn.Close()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        konek()

        strcon = "insert into gaji " _
        + "values ('""'," _
        + "'" & txtnoslip.Text & "'," _
        + "'" & txtnik.Text & "'," _
        + "'" & dtptglgaji.Text & "'," _
        + "'" & cmbidjabatan.Text & "'," _
        + "'" & txtnamajabatan.Text & "'," _
        + "'" & txtgajipokok.Text & "'," _
        + "'" & txttunjangan.Text & "'," _
        + "'" & txtuanglembur.Text & "'," _
        + "'" & txtpotbpjskes.Text & "'," _
        + "'" & txtpotbpjsket.Text & "'," _
        + "'" & txtpotlain2.Text & "'," _
        + "'" & txtnorek.Text & "'," _
        + "'" & txtnamarekening.Text & "'," _
        + "'" & txtnamabank.Text & "'," _
        + "'" & txttotalgaji.Text & "')"

        'MsgBox(strcon)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        'MsgBox("data berhasil disimpan")

       
        Dim pesan As Integer
        pesan = MsgBox("Data Berhasil Disimpan, " + "Apakah Anda Akan Mencetak Transaksi..?? " + txtnoslip.Text, vbExclamation + vbYesNo, "Cetak Transaksi")

        If pesan = vbNo Then
            Exit Sub
        Else
            Call cetak_slipgaji()
        End If
        Call tampil()
        'Call kosongkan()


    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dim pesan As Integer
        pesan = MsgBox("Apakah Anda Akan Keluar Dari Aplikasi ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If pesan = vbNo Then Exit Sub
        End
    End Sub

    Private Sub cetak_slipgaji()
        frm_cetakgaji.CrystalReportViewer1.SelectionFormula = "{gaji.no_slip} = '" & txtnoslip.Text & "'"
        frm_cetakgaji.Show()

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM gaji WHERE id_gaji = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

            Dim cmd As New Odbc.OdbcCommand
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            conn.Close()

            Call tampil()
            MsgBox("Data Sudah Dihapus", vbInformation)
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        set_editgaji(e.RowIndex)

        Call tampil_data()
    End Sub

    Private Sub btnperbaiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnperbaiki.Click
        strcon = "UPDATE gaji SET " _
     + "no_slip             = '" & txtnoslip.Text & "'," _
     + "nik                 = '" & txtnik.Text & "'," _
     + "tgl_gaji            = '" & dtptglgaji.Text & "'," _
     + "id_jabatan          = '" & cmbidjabatan.Text & "'," _
     + "nama_jabatan        = '" & txtnamajabatan.Text & "'," _
     + "gaji_pokok          = '" & txtgajipokok.Text & "'," _
     + "tunjangan           = '" & txttunjangan.Text & "'," _
     + "uang_lembur         = '" & txtuanglembur.Text & "'," _
     + "pot_bpjs_kes        = '" & txtpotbpjskes.Text & "'," _
     + "pot_bpjs_ket        = '" & txtpotbpjsket.Text & "'," _
     + "pot_lain2           = '" & txtpotlain2.Text & "'," _
     + "no_rek              = '" & txtnorek.Text & "'," _
     + "nama_rekening       = '" & txtnamarekening.Text & "'," _
     + "nama_bank           = '" & txtnamabank.Text & "'," _
     + "total_gaji          = '" & txttotalgaji.Text & "'" _
     + "WHERE id_gaji       = '" & txtidgaji.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        Call tampil_data()
        Form1.DataGridView1.Refresh()

        Call tampil()
    End Sub
End Class