Imports System.Data.SqlClient

Public Class DBAccess
    Private SqlConn As SqlConnection
    Dim ServerAddress As String
    Dim DBInstance As String
    Dim DBName As String
    Dim UserDB As String
    Dim PassDB As String

    Public Sub New(serverAddress As String, dBInstance As String, dBName As String, userDB As String, passDB As String)
        Me.ServerAddress = serverAddress
        Me.DBInstance = dBInstance
        Me.DBName = dBName
        Me.UserDB = userDB
        Me.PassDB = passDB
    End Sub

    Private Sub OpenSQLConn()
        Dim dataSource As String
        If Not String.IsNullOrEmpty(DBInstance) Then
            dataSource = If(String.IsNullOrEmpty(ServerAddress), ".", ServerAddress) & "\" & DBInstance
        Else
            dataSource = If(String.IsNullOrEmpty(ServerAddress), ".", ServerAddress)
        End If

        SqlConn = New SqlConnection(
            "Data Source=" & dataSource & ";" &
            "Database= " & DBName & ";" &
            "User Id= " & UserDB & ";" &
            "Password= " & PassDB & ";")

        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.Open()
        ElseIf SqlConn.State = ConnectionState.Broken Then
            SqlConn.Close()
            SqlConn.Open()
        End If
    End Sub

    Private Sub CloseSQLConn()
        If SqlConn IsNot Nothing AndAlso SqlConn.State <> ConnectionState.Closed Then
            SqlConn.Close()
        End If
    End Sub

    Public Function UserList() As DataTable
        Dim DT As New DataTable
        Try
            OpenSQLConn()
            Dim DA As New SqlDataAdapter("sp_User_GetAll", SqlConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            MessageBox.Show("Error DBA.User_GetAll: " & ex.Message, "Error DBA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function UserInsert(User As Users) As String
        Try
            OpenSQLConn()
            Dim SQLCmd As New SqlCommand("sp_User_Create", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = User.Username
            SQLCmd.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 255).Value = User.PasswordHash
            SQLCmd.Parameters.Add("@FullName", SqlDbType.VarChar, 100).Value = User.FullName
            SQLCmd.Parameters.Add("@Role", SqlDbType.VarChar, 20).Value = If(String.IsNullOrWhiteSpace(User.Role), "Staff", User.Role)

            If User.Gambar IsNot Nothing AndAlso User.Gambar.Length > 0 Then
                SQLCmd.Parameters.Add("@Gambar", SqlDbType.Image).Value = User.Gambar
            Else
                SQLCmd.Parameters.Add("@Gambar", SqlDbType.Image).Value = DBNull.Value
            End If

            SQLCmd.ExecuteNonQuery()
            Return "Sukses"
        Catch ex As Exception
            MessageBox.Show("Error DBA.User_Create: " & ex.Message, "Error DBA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function

    Public Function UserHapus(IdUser As Integer) As String
        Try
            OpenSQLConn()
            Dim SQLCmd As New SqlCommand("sp_User_Delete", SqlConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@UserID", SqlDbType.Int).Value = IdUser

            SQLCmd.ExecuteNonQuery()
            Return "Sukses"

        Catch ex As Exception
            MessageBox.Show("Error DBA.User_Delete: " & ex.Message, "Error DBA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Gagal"
        Finally
            CloseSQLConn()
        End Try
    End Function
End Class
