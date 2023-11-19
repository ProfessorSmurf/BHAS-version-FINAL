Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnguest.Click
        Form3.pbadmin.Visible = False
        Form3.labelguest.Visible = True
        Form3.labeladmin.Visible = False
        Form3.pbguest.Visible = True
        Form3.Show()
    End Sub
End Class
