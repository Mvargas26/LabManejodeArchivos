Imports System.IO
Public Class frmCargaClientes
    Private Sub btnCargarArchivo_Click(sender As Object, e As EventArgs) Handles btnCargarArchivo.Click
        Try
            'antes de cualquier cosa limpiamos el list view
            Me.lisvDatosCargados.Items.Clear()

            ' en esta validacion usando la clase String.nullorempty nos aseguramos que ya este la ruta, sino el ExitSub
            'evitara que siga ejecutando lo de abajo
            If String.IsNullOrEmpty(Me.txtRuta.Text.Trim) Then
                MessageBox.Show("Aun no selecciona una ruta para el Archivo a leer")
                Exit Sub
            End If

            Dim strRuta As String = Me.txtRuta.Text.Trim

            'validamos que el archivo aun exista en la ruta indicada
            '(para usar File en esta clase tambien se debe importar System.IO)
            If File.Exists(strRuta) Then
                Dim iArchivo As New Negocios.Cliente 'objeto de la clase cliente del proyecto negocio
                Dim listDatos As ArrayList = iArchivo.ConsultarComprasClientes(strRuta)

                For Each strDato() As String In listDatos
                    Dim itmValor As New ListViewItem

                    With itmValor
                        .Text = strDato(0) ' esta es la primer columna, mostramos lo que trae strDato en la posicion 0
                        .SubItems.Add(strDato(1))
                        .SubItems.Add(strDato(2))
                        .SubItems.Add(strDato(3))
                        .SubItems.Add(strDato(4))
                        .SubItems.Add(strDato(5))
                    End With

                    Me.lisvDatosCargados.Items.Add(itmValor)
                Next

                'ajusta el ancho de la columna
                For Each dc As ColumnHeader In Me.lisvDatosCargados.Columns
                    dc.Width = -2
                Next

            Else
                MessageBox.Show("El archivo no existe en esta Ruta")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Try
            ' si le dieron ok al openfile, carga esa ruta a txtruta
            If Me.ofdArchivo.ShowDialog = DialogResult.OK Then
                Me.txtRuta.Text = Me.ofdArchivo.FileName '.filename me da la ruta completa
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnGuardarXML_Click(sender As Object, e As EventArgs) Handles btnGuardarXML.Click
        Try
            Dim strRutaArchivo As String = Me.txtRuta.Text
            strRutaArchivo = strRutaArchivo.Replace(".txt", ".xml")

            Dim listaClientes As New List(Of Negocios.Cliente)

            For Each item As ListViewItem In Me.lisvDatosCargados.Items
                listaClientes.Add(New Negocios.Cliente With {
                .Identificacion = item.Text,
                .Nombre = item.SubItems(1).Text,
                .Apellido = item.SubItems(2).Text,
                .Provincia = item.SubItems(3).Text,
                .CorreoElectronico = item.SubItems(4).Text,
                .MontoComprado = CDec(item.SubItems(5).Text)})
            Next

            Dim iGuardarClientes As New Negocios.Cliente 'llamada al metodo en la capa de negocios
            iGuardarClientes.AlmacenarInfoClientes(strRutaArchivo, listaClientes)
            MessageBox.Show("Almacenado el cliente correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub grpCargarArchivo_Enter(sender As Object, e As EventArgs) Handles grpCargarArchivo.Enter

    End Sub
End Class