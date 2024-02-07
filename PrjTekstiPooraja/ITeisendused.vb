Public Interface ITeisendused

    Property intAlgus As Integer
    Property intLopp As Integer
    Property strTekst As String

    Function pooraTekst() As String
    Sub teisendaTekst(ByRef strSisendTekst As String)

    Function algoPooraTekst(ByVal algneStr) As String

End Interface