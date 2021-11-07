Public Class frmCargarXML
    Private Sub btnRutaXML_Click(sender As Object, e As EventArgs) Handles btnRutaXML.Click
        Try

            If Me.ofdArchivoXML.ShowDialog = DialogResult.OK Then
                Me.txtRutaXML.Text = Me.ofdArchivoXML.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim busqueda As String
        busqueda = txtCedulaCliente.Text

    End Sub

    Private Sub btnCargarXML_Click(sender As Object, e As EventArgs) Handles btnCargarXML.Click
        Dim objCliente As New Negocios.Cliente
        'objCliente.LeerXML(txtRutaXML.Text)
        'objCliente.MostrarElXML()
    End Sub
End Class