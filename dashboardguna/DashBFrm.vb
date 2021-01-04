
Public Class DashBFrm
    Private Sub movIMG(sender As Object)
        Dim b As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        PictureBox1.Location = New Point(b.Location.X + 15, b.Location.Y - 26)
        PictureBox1.SendToBack()
    End Sub
    Private Sub bnbtnhome_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2Button3.CheckedChanged, Guna2Button2.CheckedChanged, Guna2Button1.CheckedChanged, bnbtnhome.CheckedChanged
        movIMG(sender)
    End Sub
End Class
