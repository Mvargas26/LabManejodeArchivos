Public Class frmPrincipal
    Private Sub mnCargarClientes_Click(sender As Object, e As EventArgs) Handles mnCargarClientes.Click
        Try
            'muetra la pantalla carga clientes al ususario
            Dim frmPantalla As New frmCargaClientes
            With frmPantalla
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text) 'me.text muestra el texto y el titulo de la pantalla
        End Try
    End Sub

    Private Sub mnCambiarColor_Click(sender As Object, e As EventArgs) Handles mnCambiarColor.Click
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub mnSalir_Click(sender As Object, e As EventArgs) Handles mnSalir.Click
        Me.Close()
    End Sub
End Class
