Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class signup
    Private connectionString As String = "Server=localhost;Database=cfk_log;UserID=root;Password=;"
    Private connection As New MySqlConnection(connectionString)

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim email As String = txtEmail.Text
        Dim passwd As String = txtpassword.Text



        Try
            connection.Open()
            Dim query As String = "INSERT INTO  User (userid,email, password ) Values(NULL,@email,@password)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("email", email)
            cmd.Parameters.AddWithValue("password", passwd)

            cmd.ExecuteNonQuery()

            If cmd.ExecuteNonQuery Then

                MessageBox.Show("Register Successful")
                Dim mainForm As New Form1()
                mainForm.Show()
                Me.Hide()
                ' Proceed to the main application or another form
            Else
                MessageBox.Show("Register Unsuccessfully")
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class