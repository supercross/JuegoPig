Public Class InterfazPig
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbPuntos.Click

    End Sub

    Private Sub InterfazPig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDados_TextChanged(sender As Object, e As EventArgs) Handles txtDados.TextChanged




    End Sub

    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click

        Dim Num As Integer
        Num = Int(6 - 1) * Rnd() + 1

        txtDados.Text = Num


        txtPuntaje.Text = Num


        'For i = 0 To txtDados
        txtPuntaje.Text = Val(Num) + 1
        'Next



        If txtDados.Text = 1 Then
            MessageBox.Show("Su turno a terminado :( , es turno del computador :)  !!!! ")
        End If


    End Sub

    Private Sub btnTirarMaquina_Click(sender As Object, e As EventArgs) Handles btnTirarMaquina.Click

        Dim ale As Integer
        ale = Int(6 - 1) * Rnd() + 1
        txtDados.Text = ale


        ale = ale + ale

        txtPuntaje.Text = ale

        If txtDados.Text = 6 Then
            MessageBox.Show("Su turno termino :( , es turno del jugador 1")
        End If

    End Sub

    Private Sub txtPuntaje_TextChanged(sender As Object, e As EventArgs) Handles txtPuntaje.TextChanged


        'txtPuntaje.Clear()



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click

        txtSumaPuntos.Text = txtPuntaje.Text


    End Sub

    Private Sub btnDetenermeMaq_Click(sender As Object, e As EventArgs) Handles btnDetenermeMaq.Click

        txtPuntosMaquina.Text = txtPuntaje.Text

    End Sub

    Private Sub txtSumaPuntos_TextChanged(sender As Object, e As EventArgs) Handles txtSumaPuntos.TextChanged

    End Sub

    Private Sub txtPuntosMaquina_TextChanged(sender As Object, e As EventArgs) Handles txtPuntosMaquina.TextChanged

    End Sub
End Class
