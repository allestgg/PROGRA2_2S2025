Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hola " & tbNombre.Text & " tu carrera es: " & tbCarrera.Text + " y tu edad es: " & tbEdad.Text)
    End Sub
End Class
