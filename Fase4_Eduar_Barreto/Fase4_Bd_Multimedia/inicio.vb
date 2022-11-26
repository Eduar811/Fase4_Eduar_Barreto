Public Class inicio
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If usuario.Text = "lina" And contraseña.Text = "123" Then Form1.Show()
    End Sub
End Class