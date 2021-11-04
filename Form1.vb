Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim principal As Integer
        Dim roi As Double
        Dim simpleinterest As Double
        Dim compoundinterest As Double
        Dim temp As Double

        Dim i As Integer

        principal = 1000
        roi = 5
        temp = principal

        simpleinterest = (principal * roi) / 100
        ListBox1.Items.Add("" & vbTab & "SIMPLE" & vbTab & "               COMPOUND" & vbNewLine)
        ListBox1.Items.Add("YEAR" & "      INTEREST" & "             INTEREST")
        For i = 1 To 9
            compoundinterest = temp * (1 + roi / 100)
            principal = (principal + simpleinterest)
            ListBox1.Items.Add(i.ToString() + vbTab + FormatCurrency(principal).ToString() + vbTab + FormatCurrency(compoundinterest, "1.99").ToString() + vbNewLine)
            temp = compoundinterest
        Next

    End Sub
End Class
