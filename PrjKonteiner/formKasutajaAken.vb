Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formKasutajaAken

    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click

        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        Dim algoPooraja As PrjTekstiPooraja.ITeisendused
        algoPooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        Dim loppStr As String

        If cpAlgo.Checked Then
            loppStr = algoPooraja.algoPooraTekst(txtSisendTekst.Text)
            txtValjundTekst1.Text = loppStr
        Else
            pooraja.strTekst = txtSisendTekst.Text
            txtValjundTekst1.Text = pooraja.pooraTekst()
        End If
    End Sub

    Private Sub btnPoora2_Click(sender As Object, e As EventArgs) Handles btnPoora2.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        Dim algoPooraja As PrjTekstiPooraja.ITeisendused
        algoPooraja = New PrjTekstiPooraja.CAlgoritmilinePooraja

        Dim loppStr As String

        If cpAlgo.Checked Then
            loppStr = algoPooraja.algoPooraTekst(txtSisendTekst.Text)
            txtValjundTekst2.Text = loppStr
        Else
            pooraja.teisendaTekst(txtSisendTekst.Text)
            txtValjundTekst2.Text = pooraja.strTekst
        End If

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        timerUuenda.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick

        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst

    End Sub

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        lblSisendTekst.Text = Len(txtSisendTekst.Text)

        Dim vowels As Integer

        For i As Integer = 0 To Len(txtSisendTekst.Text) - 1
            Dim c As String = txtSisendTekst.Text(i)
            If c Like "[aeiouüõöä]" Then
                vowels = vowels + 1
            End If
        Next

        lblVowels.Text = vowels

    End Sub
End Class
