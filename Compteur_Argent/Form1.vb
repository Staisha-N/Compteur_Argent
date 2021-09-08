Public Class Form1
    Private Sub btnAdditionner_Click(sender As Object, e As EventArgs) Handles btnAdditionner.Click

        Dim intQuarter As Integer
        Dim intDime As Integer
        Dim intNickel As Integer
        Dim intPenny As Integer

        intQuarter = Val(txtQuarters.Text)
        intDime = Val(txtDimes.Text)
        intNickel = Val(txtNickels.Text)
        intPenny = Val(txtPennies.Text)

        Call Compte(intQuarter, intDime, intNickel, intPenny)


    End Sub

    Sub Compte(ByVal nombreUn As Integer, ByVal nombreDeux As Integer, ByVal nombreTrois As Integer, ByVal nombreQuatre As Integer)

        Dim MonnaieQuarters As Double
        Dim MonnaieDimes As Double
        Dim MonnaieNickels As Double
        Dim MonnaiePennies As Double
        Dim MonnaieTotale As Double

        MonnaieQuarters = nombreUn * 25 / 100
        MonnaieDimes = nombreDeux * 10 / 100
        MonnaieNickels = nombreTrois * 5 / 100
        MonnaiePennies = nombreQuatre / 100

        MonnaieTotale = MonnaieQuarters + MonnaieDimes + MonnaieNickels + MonnaiePennies

        Me.lblMonnaie.Text = "Total en monnaie : " & Format(MonnaieTotale, "0.00") & "$"

    End Sub

    Private Sub txtDimes_TextChanged(sender As Object, e As EventArgs) Handles txtDimes.TextChanged
        Me.lblMonnaie.Text = "---"
    End Sub

    Private Sub txtNickels_TextChanged(sender As Object, e As EventArgs) Handles txtNickels.TextChanged
        Me.lblMonnaie.Text = "---"
    End Sub

    Private Sub txtPennies_TextChanged(sender As Object, e As EventArgs) Handles txtPennies.TextChanged
        Me.lblMonnaie.Text = "---"
    End Sub

    Private Sub txtQuarters_TextChanged(sender As Object, e As EventArgs) Handles txtQuarters.TextChanged
        Me.lblMonnaie.Text = "---"
    End Sub
End Class
