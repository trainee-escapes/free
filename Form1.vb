Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello from the form!")
        HelperModule.PrintMessageFromModule()
    End Sub
End Class
