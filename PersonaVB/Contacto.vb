Friend Class Contacto
    Inherits Persona
    Private telefono As String
    Public Property _Telefono As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        telefono = String.Empty
    End Sub

    Public Sub New(ByVal nombre As String, ByVal fechaNacimiento As DateTime?, ByVal telefono As String)
        MyBase.New(nombre, fechaNacimiento)
        Me.telefono = telefono
    End Sub

    Public Function Obtain_Data() As String
        Dim line As String
        Dim com As Char = ","
        Console.WriteLine("Type your name")
        line = Console.ReadLine()

        Dim dateTime As DateTime
        Dim validation As Boolean = False
        While True
            Console.WriteLine("Type your birthdate format(DD/MM/YYY)")
            validation = DateTime.TryParse(Console.ReadLine(), dateTime)
            If validation = True Then
                Exit While
            End If
        End While

        line = line + com + dateTime
        Console.WriteLine("Type your Phonenumber")
        line = line + com + Console.ReadLine()
        Return line
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & vbCrLf & "Your phonenumber is: " & telefono
    End Function
End Class



