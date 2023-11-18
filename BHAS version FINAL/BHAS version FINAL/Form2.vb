Public Class Form2
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MsgBox("Contact System Administrator", MessageBoxIcon.Information, "Forgot Password")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtusername.Text = "" Then
            MsgBox("Username is Empty", MessageBoxIcon.Information, "Empty Field")
        ElseIf txtpassword.Text = "" Then
            MsgBox("Password is Empty", MessageBoxIcon.Information, "Empty Field")
        ElseIf txtusername.Text = "a" And txtpassword.Text = "a" Then
            Form3.pbadmin.Visible = True
            Form3.pbguest.Visible = False
            Form3.labeladmin.Visible = True
            Form3.labelguest.Visible = False
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Username or Password is invalid", MessageBoxIcon.Error, "Invalid Credentials")
        End If
    End Sub
End Class