Public Class CTekstiPooraja

    Implements ITeisendused

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property strTekst As Integer Implements ITeisendused.strTekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Sub tesiendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.tesiendaTekst
        Throw New NotImplementedException()
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Throw New NotImplementedException()
    End Function

End Class
