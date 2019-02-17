Public Class Form1
    Dim actualData As String = Nothing
    Dim spacerData As String = Nothing
    Dim headerData As String = Nothing
    Dim dummyData As String = Nothing

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualData = "This is the fake data. Something went wrong. (Maybe you didn't extract the data?)"
        dummyData = "This is the fake data. Something went very wrong."
        headerData = "Self-coded Data:"
        spacerData = " "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        actualData = "This is the real data. The file size is: 16,384."
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Label2.Text = headerData + spacerData + actualData
        Catch
            MsgBox("Something went wrong.")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Test GOAT file: The file size should be: 16,384.")
    End Sub
End Class
