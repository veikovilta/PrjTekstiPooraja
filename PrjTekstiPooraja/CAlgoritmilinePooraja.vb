Public Class CAlgoritmilinePooraja

    Implements ITeisendused

    Private strPooratavTekst As String

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
            Return strPooratavTekst
        End Get
        Set(ByVal value As String)
            strPooratavTekst = value
        End Set
    End Property

    Public Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst

        For i As Integer = strSisendTekst.Length - 1 To 0 Step -1
            strPooratavTekst &= strSisendTekst(i)
        Next

    End Sub

    Public Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Dim loppStr As String = ""

        For i As Integer = strPooratavTekst.Length - 1 To 0 Step -1
            loppStr &= strPooratavTekst(i)
        Next

        Return loppStr
    End Function

End Class
