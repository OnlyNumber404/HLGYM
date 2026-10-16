Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public DBA As DBAccess

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                EnvConfig.Load()

                Dim server As String = EnvConfig.GetValue("DB_Server")
                Dim dbName As String = EnvConfig.GetValue("DB_DatabaseName")
                Dim dbUser As String = EnvConfig.GetValue("DB_Username")
                Dim dbPassword As String = EnvConfig.GetValue("DB_Password")

                DBA = New DBAccess(server, "", dbName, dbUser, dbPassword)
            Catch ex As Exception
                MessageBox.Show("Gagal memuat konfigurasi dari .env:" & vbCrLf & ex.Message, "Error Konfigurasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
