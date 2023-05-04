Public Class Form1
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P As Double = HomeValue.Text
        Dim I As Double = (Interest.Text / 100) / 12
        Dim N As Double = LoanTerm.Text * 12
        Dim Z As Double = (1 + I) ^ N
        Dim D As Double = DownPayment.Text / 100
        Dim B As Double = P * D
        Dim T As Double = P * (Tax.Text / 1000)
        Dim M As Double = (P - B) * ((I * Z) / (Z - 1))

        MonthlyAmount.Text = M + (T / 12)
        YearlyAmount.Text = (M * 12) + T

        DownPaymentAmount.Text = B
        PropertyTaxAmount.Text = T






    End Sub


End Class
