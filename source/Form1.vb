Public Class Settings
    Dim realurl As String

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Viewer.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Viewer.TopMost = True
        Else
            Viewer.TopMost = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = False Then
            Viewer.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Else
            Viewer.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        realurl = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        realurl = Replace(realurl, "watch?v=", "v/")

        realurl += "?autoplay=1"

        If CheckBox2.Checked = True Then
            realurl += "&loop=1"
        End If

        If CheckBox3.Checked = True Then
            realurl += "&controls=1"
        Else
            realurl += "&controls=0"
        End If

        Viewer.WebBrowser1.Navigate(realurl)
    End Sub
End Class
