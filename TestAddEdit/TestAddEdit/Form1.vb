Imports Npgsql
Public Class Form1

    Public Sub ConnectToDatabase()
        Dim connectionString As String = "Host=10.0.21.71;Port=5432;Username=postgres;Password=root;Database=hms"
        Dim query As String = "SELECT * FROM shmc.patient_details Limit 10"

        Using conn As New NpgsqlConnection(connectionString)
            Try
                conn.Open()
                MessageBox.Show("Connected")

                Dim dataAdapter As New NpgsqlDataAdapter(query, conn)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class

