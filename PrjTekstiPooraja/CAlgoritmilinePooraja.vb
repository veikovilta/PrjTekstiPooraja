Public Class CAlgoritmilinePooraja

    Implements ITeisendused

    Public Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property strTekst As String Implements ITeisendused.strTekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        Throw New NotImplementedException()
    End Sub

    Public Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Throw New NotImplementedException()
    End Function

    Public Function algoPooraTekst(algneStr As Object) As String Implements ITeisendused.algoPooraTekst

        Dim loppStr As String = algneStr
        Dim counter As Integer = 0

        For i As Integer = algneStr.Length - 1 To 0 Step -1
            loppStr &= Str(i)
        Next

        Return loppStr

    End Function
End Class
