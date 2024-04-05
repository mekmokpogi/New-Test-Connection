Imports Npgsql
Public Class Form1

    Public Sub ConnectToDatabase()
        Dim connectionString As String = "Host=10.0.21.71;Port=5432;Username=postgres;Password=root;Database=hms"
        Using conn As New NpgsqlConnection(connectionString)
            Try
                conn.Open()
                MessageBox.Show("Connected")
            Catch ex As Exception
                MessageBox.Show("Not Connected")
            End Try
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectToDatabase()
    End Sub
End Class

