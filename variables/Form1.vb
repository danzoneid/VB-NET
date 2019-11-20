Public Class Form1
    Private r As Decimal
    Private l@, phi@

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        If r Mod 7 = 0 Then
            phi = 22 / 7D
        ElseIf r Mod 7 <> 0 Then
            phi = 3.14D
        End If

        'result
        l = phi * (r ^ 2)
        result.Text = l.ToString()
    End Sub



    REM when content/s changed
    Private Sub rInput_TextChanged(sender As Object, e As EventArgs) Handles rInput.TextChanged
        r = CDec(rInput.Text)
    End Sub
End Class
