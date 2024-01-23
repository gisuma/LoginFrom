Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Terbuka()
        FormMenu.LoginToolStripMenuItem.Visible = False
        FormMenu.LogoutToolStripMenuItem.Visible = True
        FormMenu.KeluarToolStripMenuItem.Visible = True
        FormMenu.MasterToolStripMenuItem.Visible = True
        FormMenu.TransaksiToolStripMenuItem.Visible = True
        FormMenu.LaporanToolStripMenuItem.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tusername.Text = "" And Tpassword.Text = "" Then
            MsgBox("Username dan password Tidak Boleh Kosong")
        Else
            Try
                konek()
                cmd = New MySqlCommand("SELECT * FROM user WHERE username = '" & Tusername.Text & "' and password = '" & Tpassword.Text & "' ", Koneksi)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Login Berhasil")
                    If dr.Item(3) = "ADMIN" Then
                        FormMenu.ManageUserToolStripMenuItem.Visible = True
                    Else
                        FormMenu.ManageUserToolStripMenuItem.Visible = False
                    End If
                    Call Terbuka()
                    Tusername.Text = ""
                    Tpassword.Text = ""
                    Me.Close()
                Else
                    MsgBox("username atau password salah")
                End If
                Diskonek()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BLoginFormKeluar_Click(sender As Object, e As EventArgs) Handles BLoginFormKeluar.Click
        Me.Close()
    End Sub

    Private Sub Tpassword_TextChanged(sender As Object, e As EventArgs) Handles Tpassword.TextChanged
        Tpassword.PasswordChar = "*"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Tpassword.PasswordChar = ""
        Else
            Tpassword.PasswordChar = "*"
        End If
    End Sub
End Class
