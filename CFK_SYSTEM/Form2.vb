Imports System.Net.Http
Imports System.Text
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim apiUrl As String = "https://sandbox.safaricom.co.ke/v1/ussdpush/get-msisdn"
        Dim apiKey As String = "cPQZLcKwpYUE5hnPz9D8N0aaqTMGJH3hYh7tSHisy12MSETj"

        Using client As New HttpClient()
            ' authorization header
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & apiKey)

            Dim requestPayload As New StringContent("
                                                {
                                                   ""primaryShortCode"":""55555"",
                                                   ""receiverShortCode"":""454545"",
                                                   ""amount"":""100"",
                                                   ""paymentRef"":""paymentRef"",
                                                   ""callbackUrl"":""http://..../result"",
                                                   ""partnerName"":""CFK FAST FOOD"",
                                                   ""RequestRefID"":""{{random Unique Identifer For Each Request}}""
                                                }", Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, requestPayload)

            ' Check the response status
            If response.IsSuccessStatusCode Then
                Dim result As String = Await response.Content.ReadAsStringAsync()
                ' Process the result as needed
            Else
                MessageBox.Show($"Error: {response.StatusCode}")
            End If
        End Using
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub
End Class