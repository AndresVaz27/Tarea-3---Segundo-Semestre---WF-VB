Imports System.Drawing.Text

Public Class Persona

    Protected nombre As String
    Protected fechaNacimiento As DateTime?

    Public Property nombre_ As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public ReadOnly Property Edad() As String
        Get
            Dim edad_ As String
            edad_ = DateTime.Now.Year - fechaNacimiento.Value.Year
            Return edad_
        End Get
    End Property

    Public Property fechanacimiento_ As DateTime?
        Get
            Return fechaNacimiento
        End Get
        Set(value As DateTime?)
            fechaNacimiento = value
        End Set
    End Property
    Sub Persona(nombre_, fechanacimiento_)
        nombre = nombre_
        fechaNacimiento = fechanacimiento_
    End Sub
    Public Overrides Function ToString() As String
        Return nombre.ToUpper() & " " + Edad
    End Function

End Class
