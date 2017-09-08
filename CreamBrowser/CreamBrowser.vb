Public Class CreamBrowser

    Private Sub Github_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "https://github.com/jtrent238/jtrent238-System-Support"
        'WebBrowser1.Navigate("https://github.com/jtrent238/jtrent238-System-Support")

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim webPage As String = TextBox1.Text.Trim
        WebBrowser1.Navigate(webPage)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then WebBrowser1.GoForward()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoHome()
    End Sub
End Class