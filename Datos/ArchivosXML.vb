Imports System.Xml 'se necesita esta libreria para usar xmlDocument

Public Class ArchivosXML
    Public Sub GuardarXML(ByVal xmlArchivo As XmlDocument, ByVal RutaArchivo As String) 'me va guardar el archivo xmlArchivo que es de tipo xmlDocument
        xmlArchivo.Save(RutaArchivo)
    End Sub

    Public Sub GuardarXML(ByVal EstructuraXML As String, ByVal RutaArchivo As String)
        Dim xmlArchivo As New XmlDocument
        xmlArchivo.Save(RutaArchivo)
    End Sub

End Class
