Imports System.IO
Imports System.Drawing.Imaging

Public Class frmUserInsert
    Dim MyParent As frm_UserAllList

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(MyParent As frm_UserAllList)
        InitializeComponent()
        Me.MyParent = MyParent
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnCloseHeader_Click(sender As Object, e As EventArgs) Handles btnCloseHeader.Click
        Close()
    End Sub

    Private Sub frmUserInsert_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtUsername.Clear()
        txtFullName.Clear()
        txtRole.Text = "Staff"
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        chkShowPassword.Checked = False

        If picProfile.Image IsNot Nothing Then
            picProfile.Image.Dispose()
            picProfile.Image = Nothing
        End If

        txtUsername.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Try
            ofd.Multiselect = False
            ofd.Title = "Pilih Gambar"
            ofd.Filter = "Berkas Gambar (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim fileInfo As New FileInfo(ofd.FileName)
                Dim maxsize As Long = 2 * 1024 * 1024 ' 2MB

                If fileInfo.Length > maxsize Then
                    MessageBox.Show("Maksimal ukuran gambar adalah 2MB", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Using fs As New FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)
                        Using tempImg As Image = Image.FromStream(fs)
                            picProfile.Image = New Bitmap(tempImg)
                        End Using
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error Memilih Gambar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password tidak sama!", "Password Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Focus()
            Exit Sub
        End If

        Dim user As New Users
        Dim security As New Security

        user.Username = Trim(txtUsername.Text)
        user.PasswordHash = security.GetHash(txtPassword.Text)
        user.FullName = Trim(txtFullName.Text)
        user.Role = Trim(txtRole.Text)

        If picProfile.Image IsNot Nothing Then
            Try
                Using ms As New MemoryStream()
                    picProfile.Image.Save(ms, ImageFormat.Jpeg)
                    user.Gambar = ms.ToArray()
                End Using
            Catch ex As Exception
                user.Gambar = Nothing
            End Try
        Else
            user.Gambar = Nothing
        End If

        Dim hasil As String = My.Application.DBA.UserInsert(user)

        If hasil = "Sukses" Then
            MessageBox.Show("User berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MyParent IsNot Nothing Then
                MyParent.RefreshData()
            End If
            Close()
        Else
            MessageBox.Show("Gagal menyimpan user ke database.", "Error Tambah User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
