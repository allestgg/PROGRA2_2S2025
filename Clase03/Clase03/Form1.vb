Public Class Form1

    Dim nombre As String
    Dim apellido As String
    Dim edad As Long
    Dim telefono As String
    Dim password As String
    Dim codigo As String
    Dim message As String
    Dim opcion As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btEnviar.Click

        edad = CLng(tbEdad.Text)
        nombre = tbNombre.Text
        telefono = tbTelefono.Text
        codigo = tbCodigoPais.Text
        password = tbPassword.Text

        If edad >= 18 Then
            If nombre = "Nicola" And password = "1234" Then
                ' MessageBox.Show("Bienvenido al sistema!")
                message += "Bienvenido al sistema! "
            Else
                'MessageBox.Show("Credenciales Incorrectas")
                message += " | Credenciales Incorrectas "
            End If
        Else
            'MessageBox.Show("Eres menor de edad")
            message += " | Eres menor de edad "
        End If

        Select Case codigo
            Case 502
                'MessageBox.Show("Telefono guatemalteco")
                message += " | Telefono guatemalteco"
            Case 34
                'MessageBox.Show("Telefono espaniol")
                message += " | Telefono espaniol"
            Case 1
                'MessageBox.Show("Telefono canadiense")
                message += " | Telefono canadiense"
            Case 52
                'MessageBox.Show("Telefono mexicano")
                message += " | Telefono mexicano"
        End Select

        MessageBox.Show(message)

    End Sub

End Class
