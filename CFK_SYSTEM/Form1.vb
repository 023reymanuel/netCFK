Imports System.Net
Imports MySql.Data.MySqlClient
Public Class Form1
    Private connectionString As String = "Server=localhost;Database=cfk_log;UserID=root;Password=;"
    Private connection As New MySqlConnection(connectionString)
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Function IsValidUser(username As String, password As String) As Boolean
        ' Implement your actual authentication logic here
        ' For simplicity, using hardcoded value
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text


        Try
            connection.Open()
            Dim query As String = "SELECT * FROM User WHERE email=@email and password=@password"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("email", username)
            cmd.Parameters.AddWithValue("password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
           
            If reader.Read() Then

                MsgBox("Login Successful")
                Dim mainForm As New Form2()
                mainForm.Show()
                Me.Hide()
                ' Proceed to the main application or another form
            Else
                MessageBox.Show("Invalid Login Credentials")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try




    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsername_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
