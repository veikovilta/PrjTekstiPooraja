Public Class CTekstiPooraja

    Implements ITeisendused

    'atribuudid
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol
        End Get
        Set(ByVal value As Integer)
            intAlgusSymbol = value
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol
        End Get
        Set(ByVal value As Integer)
            intLoppSymbol = value
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(ByVal value As String)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.teisendaTekst
        strPooratavTekst = StrReverse(strSisendTekst)
    End Sub

    Public Function algoPooraTekst(algneStr As Object) As String Implements ITeisendused.algoPooraTekst
        Throw New NotImplementedException()
    End Function

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Return StrReverse(strPooratavTekst)
    End Function

End Class
