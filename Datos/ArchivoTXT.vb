Imports System.IO
Public Class ArchivoTXT
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="RutaArchivo"></param>
    ''' <returns></returns>

    Public Function Leer(ByVal RutaArchivo As String) As ArrayList 'el arraylist es una coleccion vectorial autoadministrada
        'Dim iconexion As New ConexionSQL
        'iconexion.ProbarConexion()

        Dim listDatos As New ArrayList
        Dim srContenido As New StreamReader(RutaArchivo) 'obj de tipo stremreader que nos va permitir leer linea a linea

        While srContenido.Peek >= 0 'mientras .peek(devuelve siguiente caracter, 1 si hay, 0 si no) sea mayor o = 0 ejecute el while
            Dim strDato As String = srContenido.ReadLine 'leame la linea donde se encuentra el peek
            listDatos.Add(strDato)
        End While

        Return listDatos
    End Function ' // fin funcion Leer

End Class
