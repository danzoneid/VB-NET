Public Class Form1
    Dim a, b, c, d As Integer
    Dim ast, bs, cs, ds As String
    Dim determinan As Integer
    Dim aI, bI, cI, dI As Double
    Dim dividedDeterminan As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If inputAForm.Text.Length = 0 Or inputBForm.Text.Length = 0 Or inputCForm.Text.Length = 0 Or inputDForm.Text.Length = 0 Then
            MsgBox("ISI INPUT TERLEBIH DAHULU!")

        Else
            preA.Text = inputAForm.Text
            preB.Text = inputBForm.Text
            preC.Text = inputCForm.Text
            preD.Text = inputDForm.Text

            ast = preA.Text
            bs = preB.Text
            cs = preC.Text
            ds = preD.Text

            a = CInt(ast)
            b = CInt(bs)
            c = CInt(cs)
            d = CInt(ds)
        End If
    End Sub

    Private Sub proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proses.Click
        If inputAForm.Text.Length = 0 Or inputBForm.Text.Length = 0 Or inputCForm.Text.Length = 0 Or inputDForm.Text.Length = 0 Then
            MsgBox("ISI INPUT TERLEBIH DAHULU!")

        Else
            preA.Text = inputAForm.Text
            preC.Text = inputCForm.Text
            preB.Text = inputBForm.Text
            preD.Text = inputDForm.Text

            ast = preA.Text
            bs = preB.Text
            cs = preC.Text
            ds = preD.Text

            a = CInt(ast)
            b = CInt(bs)
            c = CInt(cs)
            d = CInt(ds)
        End If

        'determinan
        determinan = (a * d) - (b * c)
        'menampilkan output ke DESAIN GUI
        oDetForm.Text = determinan

        'invers
        dividedDeterminan = CDbl(1 / determinan)
        aI = dividedDeterminan * d
        bI = dividedDeterminan * (-b)
        cI = dividedDeterminan * (-c)
        dI = dividedDeterminan * a
        'OUTPUT INVERS
        oInversA.Text = aI
        oInversB.Text = bI
        oInversC.Text = cI
        oInversD.Text = dI


    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        inputAForm.Text = ""
        inputBForm.Text = ""
        inputCForm.Text = ""
        inputDForm.Text = ""

        preA.Text = 0
        preB.Text = 0
        preC.Text = 0
        preD.Text = 0

        oDetForm.Text = 0

        oInversA.Text = 0
        oInversB.Text = 0
        oInversC.Text = 0
        oInversD.Text = 0

    End Sub
End Class
