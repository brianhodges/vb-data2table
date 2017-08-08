Module Module1

    Sub Main()
        Dim c1 As New Country("USA", "350 million")
        Dim c2 As New Country("China", "1.4 billion")
        Dim c3 As New Country("Russia", "145 million")
        Dim countries = New Country() {c1, c2, c3}

        Console.WriteLine("DUMP:")
        Console.WriteLine("[")
        For Each country As Country In countries
            Console.WriteLine(vbTab + "{ ""Name"":""" + country.Name + """, ""Population"":""" + country.Population + """}")
        Next
        Console.WriteLine("]")

        Console.WriteLine()
        Console.WriteLine("SANITIZED:")
        For Each country As Country In countries
            Console.WriteLine("{:Name => " + country.Name + ", :Population => " + country.Population + "}")
        Next

        Console.WriteLine()
        Console.WriteLine("TABLE:")
        Dim header As String = "Countries | Population"
        Console.WriteLine(header)
        Console.WriteLine(StrDup(Len(header), "-"))
        For Each country As Country In countries
            Console.WriteLine(country.Name + StrDup((Len("Countries ") - Len(country.Name)), " ") + "|" + country.Population)
        Next

        Console.WriteLine()
        Console.WriteLine("Press any key to exit:")
        Console.ReadKey()
    End Sub

    Public Class Country
        Private title, pop As String

        Public Sub New(ByVal Name As String, Population As String)
            Me.Name = Name
            Me.Population = Population
        End Sub

        Public Property Name() As String
            Get
                Return title
            End Get
            Set(ByVal Value As String)
                title = Value
            End Set
        End Property

        Public Property Population() As String
            Get
                Return pop
            End Get
            Set(ByVal Value As String)
                pop = Value
            End Set
        End Property
    End Class

End Module
