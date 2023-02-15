Public Class Form1
    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim x As Contacto
        x = New Contacto()
        x.fechanacimiento_ = DateTime.Parse("2003/01/01")
        x.nombre_ = txtNombre.Text
        x.telefono_ = txtTelefono.Text

        lblImpresion.Text = x.ToString()

    End Sub
End Class
