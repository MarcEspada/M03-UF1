Public Class Form2

    Private Sub GenerarBtn_Click(sender As Object, e As EventArgs) Handles GenerarBtn.Click
        Dim minimo As Integer
        Dim maximo As Integer
        Dim aleatorio As New Random

        minimo = CInt(TextBox1.Text)
        maximo = CInt(TextBox2.Text)

        Label3.Text = aleatorio.Next(minimo, maximo)
    End Sub
End Class