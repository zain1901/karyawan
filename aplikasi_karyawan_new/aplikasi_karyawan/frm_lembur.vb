Public Class frm_lembur

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click

    End Sub

    Private Sub frm_lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttanggallembur.TextChanged

    End Sub

    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        If (e.KeyChar = Chr(13)) Then
            konek()
            cmd = New Odbc.OdbcCommand("SELECT * FROM karyawan where nik ='" & txtnik.Text & "'", conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                txtnama.Text = rd(1).ToString
                cmbjabatan.Text = rd(12).ToString
            Else
                'exit sub
                MsgBox("Tidak ditemukan")
                txtnik.Focus()
                txtnik.Clear()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged
       
    End Sub

    Private Sub txtuang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuang.TextChanged
        txttotal.Text = Val(txtjum.Text) * Val(txtuang.Text)
    End Sub

    Private Sub txtjum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjum.TextChanged
        txttotal.Text = Val(txtjum.Text) * Val(txtuang.Text)
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class