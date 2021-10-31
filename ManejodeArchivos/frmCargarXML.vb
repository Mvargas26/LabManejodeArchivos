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
End Class