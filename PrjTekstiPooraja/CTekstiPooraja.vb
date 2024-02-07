﻿Public Class CTekstiPooraja

    Implements ITeisendused

    'atribuudid
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As Integer

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

    Private Property strTekst As Integer Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(ByVal value As Integer)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub tesiendaTekst(ByRef strSisendTekst As String) _
        Implements ITeisendused.tesiendaTekst
        strPooratavTekst = StrReverse(strPooratavTekst)
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Return StrReverse(strPooratavTekst)
    End Function

End Class
