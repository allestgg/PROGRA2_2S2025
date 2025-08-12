Public Class Form1

    Dim equipoSeleccionado As String
    Dim cantidadS As Long
    Dim cantidadM As Long
    Dim cantidadL As Long
    Dim factura As String

    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        ' cbEquipo.SelectedIndex = -1
        tbTallaS.Text = ""
        tbTallaM.Text = ""
        tbTallaL.Text = ""
    End Sub

    Private Sub btComprar_Click(sender As Object, e As EventArgs) Handles btComprar.Click
        cantidadS = CLng(tbTallaS.Text)
        cantidadM = CLng(tbTallaM.Text)
        cantidadL = CLng(tbTallaL.Text)

        If rbBarcelona.Checked Then
            Dim totalS = cantidadS * 550
            Dim totalM = cantidadM * 570
            Dim totalL = cantidadL * 590
            Dim total = totalS + totalM + totalL

            factura = "Cantidad Camisetas Talla S: " & cantidadS & " subtotal camisetas S: " & totalS & vbCrLf &
                      "Cantidad Camisetas M: " & cantidadM & " Subtotal Camisetas M: " & totalM & vbCrLf &
                      "Cantidad Camisetas L: " & cantidadL & " Subtotal camisetas L: " & totalL & vbCrLf &
                      "Total compra: " & total

            tbFactura.Text = factura
        End If


    End Sub
End Class
