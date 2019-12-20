Imports System.Data.Odbc
Public Class frm_absensi

    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        Dim jam_masuk, jam_kerja As DateTime
        Dim jam_pulang As String
        Dim a1, a2 As String
        Dim tgl As DateTime

        If (e.KeyChar = Chr(13)) Then
            konek()
            strcon = "select * from karyawan where nik='" & txtnik.Text & "'"
            cmd = New OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                lblnik.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                '=========================code simpan================='
                jam_masuk = Format(Now, "HH:mm:ss")
                jam_kerja = "07:00:00"

                a1 = Format(Now, "HH:mm:ss")
                a2 = "07:00:00"

                jam_pulang = Format(Now, "HH:mm:ss")
                tgl = Format(Now, "yyyy-MM-dd")

                Dim selisih As TimeSpan = New TimeSpan
                selisih = jam_masuk - jam_kerja
                lblinfo.Text = selisih.ToString

                strcon = "Insert into absensi (id_absensi ,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk)values(?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(txtnik.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = txtnik.Text.Trim
                    .Add("?", OdbcType.VarChar, 15).Value = jam_masuk
                    .Add("?", OdbcType.VarChar, 15).Value = jam_kerja
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = jam_pulang
                    .Add("?", OdbcType.VarChar, 10).Value = selisih.ToString
                End With

                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")
                '========================End Kode Simpan===================
            Else
                txtnik.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True


         
        End If

    End Sub

    Private Sub txtnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged

    End Sub

    Private Sub frm_absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltglsekarang.Text = Format(Now, "yyyy-MM-dd")
        lbljamsekarang.Text = Format(Now, "HH:mm:ss")

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblinfo.Click
        'Dim jamkerja As String
        'Dim jammasuk As String
        'jammasuk = Format(Now, "HH:mm:ss")
        ''jamkerja = Format(, "HH:mm:ss")
        'jamkerja = Format("07:00:00")
        'lblinfo.Text = jammasuk - jamkerja
    End Sub
End Class