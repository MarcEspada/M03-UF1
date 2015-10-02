Public Class Form1
    Dim op1 As Integer = 0
    Dim op2 As Integer = 0
    Dim resultadosuma As Integer = 0
    Dim resultadoresta As Integer = 0
    Dim resultadomultiplicacion As Integer = 0

    Private Sub Suma_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultadosuma = op1 + op2

        Label1.Text = resultadosuma.ToString()
    End Sub

    Private Sub RestaBtn_Click(sender As Object, e As EventArgs) Handles RestaBtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultadoresta = op1 - op2

        Label1.Text = resultadoresta.ToString()
    End Sub

    Private Sub MultiplicaBtn_Click(sender As Object, e As EventArgs) Handles MultiplicaBtn.Click

        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultadomultiplicacion = op1 * op2

        Label1.Text = resultadomultiplicacion.ToString()

    End Sub
End Class
