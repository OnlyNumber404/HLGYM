Imports System.IO
Imports System.Reflection

Public Class EnvConfig

    Private Shared _values As Dictionary(Of String, String)
    Private Shared _loadedPath As String = String.Empty

    Public Shared ReadOnly Property LoadedPath As String
        Get
            Return _loadedPath
        End Get
    End Property

    ''' <summary>
    ''' Mencari lokasi file .env secara otomatis di folder output, folder project, atau folder parent.
    ''' </summary>
    Private Shared Function FindEnvPath() As String
        Dim candidateDirs As New List(Of String)()

        ' 1. Lokasi assembly HLGYM.exe (bin\Debug atau bin\Release)
        Try
            Dim asmLocation As String = Assembly.GetExecutingAssembly().Location
            If Not String.IsNullOrEmpty(asmLocation) Then
                Dim asmDir As String = Path.GetDirectoryName(asmLocation)
                If Not String.IsNullOrEmpty(asmDir) AndAlso Not candidateDirs.Contains(asmDir) Then
                    candidateDirs.Add(asmDir)
                End If
            End If
        Catch
        End Try

        ' 2. AppDomain BaseDirectory
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
        If Not String.IsNullOrEmpty(baseDir) AndAlso Not candidateDirs.Contains(baseDir) Then
            candidateDirs.Add(baseDir)
        End If

        ' 3. Current Working Directory
        Dim currentDir As String = Directory.GetCurrentDirectory()
        If Not String.IsNullOrEmpty(currentDir) AndAlso Not candidateDirs.Contains(currentDir) Then
            candidateDirs.Add(currentDir)
        End If

        ' Cek keberadaan file .env langsung di folder-folder kandidat
        For Each dirPath In candidateDirs
            Dim directPath As String = Path.Combine(dirPath, ".env")
            If File.Exists(directPath) Then
                Return directPath
            End If
        Next

        ' Cek menelusuri ke folder parent di atasnya (misal dari bin\Debug naik ke folder project HLGYM)
        For Each startDir In candidateDirs
            Dim dirInfo As New DirectoryInfo(startDir)
            While dirInfo IsNot Nothing
                Dim candidateFile As String = Path.Combine(dirInfo.FullName, ".env")
                If File.Exists(candidateFile) Then
                    Return candidateFile
                End If
                dirInfo = dirInfo.Parent
            End While
        Next

        Return Nothing
    End Function

    Public Shared Sub Load()
        _values = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

        Dim envPath As String = FindEnvPath()

        If String.IsNullOrEmpty(envPath) OrElse Not File.Exists(envPath) Then
            Throw New FileNotFoundException("File .env tidak ditemukan. Pastikan file .env berada di folder project HLGYM.")
        End If

        _loadedPath = envPath

        For Each line As String In File.ReadAllLines(envPath)
            line = line.Trim()

            ' Lewati baris kosong dan komentar
            If String.IsNullOrWhiteSpace(line) OrElse line.StartsWith("#") Then
                Continue For
            End If

            Dim separatorIndex As Integer = line.IndexOf("="c)
            If separatorIndex <= 0 Then
                Continue For
            End If

            Dim key As String = line.Substring(0, separatorIndex).Trim()
            Dim value As String = line.Substring(separatorIndex + 1).Trim()

            ' Hilangkan tanda kutip jika ada (" atau ')
            If value.Length >= 2 AndAlso
               ((value.StartsWith("""") AndAlso value.EndsWith("""")) OrElse
                (value.StartsWith("'") AndAlso value.EndsWith("'"))) Then
                value = value.Substring(1, value.Length - 2)
            End If

            _values(key) = value
        Next
    End Sub

    Public Shared Function GetValue(key As String, Optional defaultValue As String = "") As String
        If _values Is Nothing Then
            Load()
        End If

        If _values.ContainsKey(key) Then
            Return _values(key)
        End If

        Return defaultValue
    End Function

End Class
