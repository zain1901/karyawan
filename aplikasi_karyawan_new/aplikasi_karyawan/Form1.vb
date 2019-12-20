Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        da = New Odbc.OdbcDataAdapter("select * from karyawan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan from karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "karyawan")
        DataGridView1.DataSource = (ds.Tables("karyawan"))

        Me.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub set_editkaryawan(ByVal x As Integer)
        Try
            edit_karyawan.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
            'edit_karyawan.txtnama.Text = DataGridView1.Rows(x).Cells(1).Value
            ' edit_karyawan.txttempatlahir.Text = DataGridView1.Rows(x).Cells(2).Value
            'edit_karyawan.cmbtgllahir.Text = DataGridView1.Rows(x).Cells(3).Value
            'edit_karyawan.cmbagama.Text = DataGridView1.Rows(x).Cells(4).Value
            'edit_karyawan.cmbstatus.Text = DataGridView1.Rows(x).Cells(5).Value
            'edit_karyawan.cmbkewarganegaraan.Text = DataGridView1.Rows(x).Cells(6).Value
            'edit_karyawan.txtnohp.Text = DataGridView1.Rows(x).Cells(7).Value
            'edit_karyawan.txtemail.Text = DataGridView1.Rows(x).Cells(8).Value
            'edit_karyawan.txtalamat.Text = DataGridView1.Rows(x).Cells(9).Value
            'edit_karyawan.cmbpendidikanterakhir.Text = DataGridView1.Rows(x).Cells(10).Value
            'edit_karyawan.txtperguruantinggi.Text = DataGridView1.Rows(x).Cells(11).Value
            'edit_karyawan.txtjabatan.Text = DataGridView1.Rows(x).Cells(12).Value
            'edit_karyawan.cmbtglmasuk.Text = DataGridView1.Rows(x).Cells(13).Value
            'edit_karyawan.txtbagian.Text = DataGridView1.Rows(x).Cells(14).Value
            'edit_karyawan.txtgaji.Text = DataGridView1.Rows(x).Cells(15).Value
            'edit_karyawan.cmbstatuskaryawan.Text = DataGridView1.Rows(x).Cells(16).Value
            'edit_karyawan.cmbstatuskerja.Text = DataGridView1.Rows(x).Cells(17).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        set_editkaryawan(e.RowIndex)
        edit_karyawan.Show()
    End Sub

    Private Sub Menu1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu1ToolStripMenuItem.Click
        delete()
    End Sub
    Sub tampil()
        Call konek()
        da = New Odbc.OdbcDataAdapter("select * from karyawan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn) 'untuk memilih beberapa
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "karyawan")
        DataGridView1.DataSource = (ds.Tables("karyawan"))
        Me.ContextMenuStrip = ContextMenuStrip1

    End Sub
    Sub delete()
        Call konek()
        Try
            If MessageBox.Show("apakah kamu ingin menghapus? '" & DataGridView1.CurrentRow.Cells(1).Value _
            & "' ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cmd = New Odbc.OdbcCommand("Delete FROM karyawan where nik='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
                'cmd = New Odbc.OdbcCommand("delete from t_karyawan where nik = '", conn)
                With cmd
                    cmd.Parameters.Add("nik", Odbc.OdbcType.VarChar).Value = DataGridView1.CurrentRow.Cells(0).Value
                    cmd.ExecuteNonQuery()
                End With

                conn.Close()
                tampil()
                MessageBox.Show("Hapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
