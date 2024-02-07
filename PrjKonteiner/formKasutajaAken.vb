﻿Public Class formKasutajaAken

    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click

        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        pooraja.strTekst = txtSisendTekst.Text
        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub

    Private Sub btnPoora2_Click(sender As Object, e As EventArgs) Handles btnPoora2.Click
        Dim pooraja As PrjTekstiPooraja.ITeisendused
        pooraja = New PrjTekstiPooraja.CTekstiPooraja

        pooraja.teisendaTekst(txtSisendTekst.Text)
        txtValjundTekst2.Text = pooraja.strTekst
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
    End Sub
End Class
