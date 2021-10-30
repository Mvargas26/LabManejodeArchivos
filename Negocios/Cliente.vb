Imports Datos
Imports System.Xml
Public Class Cliente
#Region "VAriables"
    Private strID As String = String.Empty
    Private strNombre As String = String.Empty
    Private strApellido As String = String.Empty
    Private strProvincia As String = String.Empty
    Private strEmail As String = String.Empty
    Private dmlMontoComprado As Decimal = 0
#End Region


#Region "Properties"
    Public Property Identificacion() As String
        Get
            Return strID
        End Get
        Set(ByVal value As String)
            strID = value
        End Set
    End Property


    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property


    Public Property Apellido() As String
        Get
            Return strApellido
        End Get
        Set(ByVal value As String)
            strApellido = value
        End Set
    End Property


    Public Property Provincia() As String
        Get
            Return strProvincia
        End Get
        Set(ByVal value As String)
            strProvincia = value
        End Set
    End Property


    Public Property CorreoElectronico() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property


    Public Property MontoComprado() As Decimal
        Get
            Return dmlMontoComprado
        End Get
        Set(ByVal value As Decimal)
            dmlMontoComprado = value
        End Set
    End Property

#End Region

#Region "Metodos "
    ''' <summary>
    ''' consulta la informacion d elas comprar realizadas por los clientes 
    ''' </summary>
    ''' <param name="RutaArchivo">
    ''' Ruta del archivo que posee la informacion de los clientes
    ''' </param>
    ''' <returns></returns>
    Public Function ConsultarComprasClientes(ByVal RutaArchivo As String) As ArrayList

        Dim iArchivo As New ArchivoTXT 'objeto qu permite leer archivo d etexto
        Dim arrDatos As ArrayList = iArchivo.Leer(RutaArchivo)

        Dim arrInfoCompras As New ArrayList ' almacena info de los clientes

        For Each strValor As String In arrDatos 'recorre cada valor que se obtiene de la lectura del archivo
            Dim arrValores() As String = strValor.Split(";") 'agregueme al arrayValores lo que tenga hasta encontrar un ;

            'aqui hacemos una validacion, de que en este caso especifico, tengalos 6 datos(osea las 6 columnas que queremos en el list view)
            'en caso de que no, no las va agregar al arraylist Datos
            If arrValores.Length = 6 Then
                Try
                    ' aqui hara la siguiente comrpbacion:
                    'si el arrvalores en la poiscion 0 esta vacio o nulo, genere una nueva excepcion
                    ' y ene ste caso como la excepcion no hace nada no lo va agregar
                    If String.IsNullOrEmpty(arrValores(0).Trim) Then
                        Throw New Exception
                    End If

                    If String.IsNullOrEmpty(arrValores(1).Trim) Then
                        Throw New Exception
                    End If

                    If String.IsNullOrEmpty(arrValores(2).Trim) Then
                        Throw New Exception
                    End If

                    If String.IsNullOrEmpty(arrValores(3).Trim) Then
                        Throw New Exception
                    End If

                    If String.IsNullOrEmpty(arrValores(4).Trim) Then
                        Throw New Exception
                    End If

                    If String.IsNullOrEmpty(arrValores(5).Trim) Then
                        Throw New Exception
                    End If

                    If Not IsNumeric(arrValores(0).Trim) Then ' si en la poscion 5 no es numerico genere la excepcion
                        Throw New Exception
                    End If

                    arrInfoCompras.Add(arrValores)
                Catch ex As Exception
                    'aca si aplica dejarlo vacio para que no haga nada
                End Try

            End If
        Next

        Return arrInfoCompras
    End Function


    ''' <summary>
    ''' Almacena la informacion de los clientes en un archivo
    ''' </summary>
    ''' <param name="RutaArchivo">
    ''' Ruta del archivo que se va guardar
    ''' </param>
    ''' <param name="ListaClientes">
    ''' lista con la informacion de los clientes que se va almacenar
    ''' </param>
    Public Sub AlmacenarInfoClientes(ByVal RutaArchivo As String, ByVal ListaClientes As List(Of Cliente)) 'aqui le decimos que nos de una lista de clientes
        Dim xmlCliente As New XmlDocument ' para llamar este objeto, se llamo a la libreria xml arriba

        'nodo raiz o nodo Padre que va tener de nombre "Clientes"
        Dim xmlNodoPrincipal As XmlNode = xmlCliente.CreateElement("Clientes")
        'luego de que creamos el nodo raiz, lo agregamos al obj xml asi:
        xmlCliente.AppendChild(xmlNodoPrincipal)


        For Each iCliente As Cliente In ListaClientes 'la variables iCliente es de tipo Cliente que se va llenar con lo que tenga ListaClientes
            Dim nodoCliente As XmlNode = xmlCliente.CreateElement("Cliente")


            With nodoCliente
                Dim nodoInformacion As XmlNode = xmlCliente.CreateElement("Identificacion")
                nodoInformacion.InnerText = iCliente.Identificacion  ' con innertext agregamos a nodoinformacion el valor que tiene identificacion
                .AppendChild(nodoInformacion)

                nodoInformacion = xmlCliente.CreateElement("Nombre") 'aqui se esta reutilizando nodoInformacion, por eso ya no se pone Dim ni as xmlNode, es elmismo pero con nueva informacion
                nodoInformacion.InnerText = iCliente.Nombre
                .AppendChild(nodoInformacion)

                nodoInformacion = xmlCliente.CreateElement("Apellidos")
                nodoInformacion.InnerText = iCliente.Apellido
                .AppendChild(nodoInformacion)

                nodoInformacion = xmlCliente.CreateElement("Provincia")
                nodoInformacion.InnerText = iCliente.Provincia
                .AppendChild(nodoInformacion)

                nodoInformacion = xmlCliente.CreateElement("Email")
                nodoInformacion.InnerText = iCliente.CorreoElectronico
                .AppendChild(nodoInformacion)

                nodoInformacion = xmlCliente.CreateElement("Monto_Comprado")
                nodoInformacion.InnerText = iCliente.MontoComprado
                .AppendChild(nodoInformacion)

            End With
            xmlNodoPrincipal.AppendChild(nodoCliente)
        Next


        Dim iArchivoXML As New ArchivosXML 'objeto de Datos
        iArchivoXML.GuardarXML(xmlCliente, RutaArchivo)

    End Sub


#End Region


End Class
