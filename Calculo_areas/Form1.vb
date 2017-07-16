Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim lado, altura As Integer
        lado = Val(txtlado.Text)
        altura = Val(txtaltura.Text)

        If Cuadrado.Checked = True Then
            txtrespuesta.Text = lado * lado
        End If

        If rectangulo.Checked = True Then
            txtrespuesta.Text = lado * altura
        End If

        If triangulo.Checked = True Then
            txtrespuesta.Text = (lado * altura) / 2


        End If





    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtaltura.Enabled = False



    End Sub

    Private Sub rectangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rectangulo.CheckedChanged

        Label1.Text = "Base"
        txtaltura.Enabled = True


    End Sub

    Private Sub Cuadrado_CheckedChanged(sender As Object, e As EventArgs) Handles Cuadrado.CheckedChanged
        txtaltura.Text = " "
        txtlado.Text = " "
        txtrespuesta.Text = " "
        Label1.Text = "Lado"
        txtaltura.Enabled = False


    End Sub

    Private Sub triangulo_CheckedChanged(sender As Object, e As EventArgs) Handles triangulo.CheckedChanged

        txtaltura.Text = " "
        txtlado.Text = " "
        txtrespuesta.Text = " "
        Label1.Text = "Base"
        txtaltura.Enabled = True


    End Sub
End Class
