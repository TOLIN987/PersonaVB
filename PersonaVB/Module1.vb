Module Module1

    Sub Main()
        Dim p As New Contacto()
        Dim line As String = p.Obtain_Data()
        Dim data As String() = line.Split(","c)
        p._Nombre = data(0)
        p._FechaNacimiento = DateTime.Parse(data(1))
        p._Telefono = data(2)
        Console.Clear()
        Console.WriteLine(p.ToString())
        Console.ReadKey()
    End Sub

End Module
