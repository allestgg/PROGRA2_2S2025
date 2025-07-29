Public Class Form1

    Dim nombre As String
    Dim apellido As String
    Dim dpi As Long
    Dim telefono As Single
    Dim direccion As String
    Dim guatemalteco As Boolean
    Dim graduado As Boolean

    Private Sub btEnviar_Click(sender As Object, e As EventArgs) Handles btEnviar.Click
        nombre = tbNombre.Text
        apellido = tbApellido.Text
        dpi = CLng(tbDPI.Text)
        telefono = CSng(tbTelefono.Text)
        direccion = tbDireccion.Text
        guatemalteco = rbSi.Checked
        graduado = chbGraduado.Checked

        MessageBox.Show(
            "Los datos son los siguientes: " & nombre &
            ", apellidos: " & apellido & ", " &
            "DPI: " & dpi & ", " &
            "Telefono: " & telefono & ", " &
            "Direccion: " & direccion & ", " &
            "Es guatemalteco? " & guatemalteco & ", " &
            "Es graduado? " & graduado
        )
    End Sub
End Class
