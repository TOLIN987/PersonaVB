Public Class Persona
    Protected nombre As String
    Protected fechanacimiento As DateTime?
    Public Property _Nombre As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property _FechaNacimiento As DateTime?
        Get
            Return fechanacimiento
        End Get
        Set(ByVal value As DateTime?)
            fechanacimiento = value
        End Set
    End Property

    Public ReadOnly Property _Edad As Integer
        Get
            Dim edad As Integer
            edad = DateTime.Now.Year - _FechaNacimiento.Value.Year
            Return edad
        End Get
    End Property

    Public Sub New()
        Nombre = String.Empty
        FechaNacimiento = Nothing 'DateTime.MinValue
    End Sub

    Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?)
        Me.Nombre = nombre
        Me.FechaNacimiento = fechaNacimiento
    End Sub

    Public Overrides Function ToString() As String
        Return "your name is: " & nombre.ToUpper() & vbCrLf & "Your age is " & _Edad
    End Function
End Class

