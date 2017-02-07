Public Class InterfazPig

    Dim puntaje As Integer = 0
    Dim puntajeParcial As Integer = 0
    Dim puntajeJugador As Integer = 0
    Dim puntajeMaquina As Integer = 0
    Dim parcial As Integer = 0




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbPuntos.Click

    End Sub

    Private Sub InterfazPig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDados_TextChanged(sender As Object, e As EventArgs) Handles txtDados.TextChanged




    End Sub

    Private Sub btnTirar_Click(sender As Object, e As EventArgs) Handles btnTirar.Click

        'Dim Num As Integer = random()
        'Dim tiradas As Integer

        'Num = Int(6 - 1) * Rnd() + 1 'numero ramdon



        'txtDados.Text = Num

        'txtPuntaje.Text = Val(txtPuntaje.Text) + Num


        'If txtDados.Text = 1 And tiradas <= (tiradas / 2) Then

        'txtPuntaje.Text = 0
        'txtDados.Text = ""
        'MessageBox.Show("Su turno Finalizo :( , es turno del computador :)  !!!! ")

        'turnoCompu()

        'End If
        turnoJugador()


    End Sub

    Private Sub btnTirarMaquina_Click(sender As Object, e As EventArgs) Handles btnTirarMaquina.Click

        'txtPuntaje.Text += Val(txtPuntaje.Text)
        'txtPuntaje.Text = 0
        'txtPuntaje.Text = ""


        'If txtDados.Text = 1 Then
        ' MessageBox.Show("Su turno termino :( , es turno del jugador 1")

        ' turnoCompu()

        'End If

        'Dim ale As Integer = random()
        'Dim tiradas As Integer
        'ale = Int(6 - 1) * Rnd() + 1
        'txtDados.Text = ale
        'txtPuntaje.Text = Val(txtPuntaje.Text) + ale





        'If txtDados.Text = 1 And tiradas <= (tiradas / 2) Then

        'txtPuntaje.Text = 0
        'txtDados.Text = ""
        'MessageBox.Show("Su turno termino :( , es turno del jugador 1")
        'turnoJugador()

        'End If
        turnoCompu()

    End Sub

    Sub turnoCompu()
        'Dim conta As Integer = 0
        'Dim tiradas As Integer = 0
        'Dim bandera As Integer = 0

        'While conta <= (tiradas / 2) + 1

        'End While
        Dim ale As Integer = random()
        Dim tiradas As Integer
        'tiradas = Int(5 - 2) * Rnd() + 1
        ale = Int(6 - 1) * Rnd() + 1
        txtDados.Text = ale
        txtPuntaje.Text = Val(txtPuntaje.Text) + ale

        If txtDados.Text = 1 And tiradas <= (tiradas / 2) Then

            txtPuntaje.Text = 0
            txtDados.Text = ""
            MessageBox.Show("Su turno termino :( , es turno del jugador 1")
            'turnoJugador()

        End If
    End Sub
    Sub turnoJugador()
        Dim Num As Integer = random()
        Dim tiradas As Integer
        'tiradas = Int(5 - 2) * Rnd() + 1

        Num = Int(6 - 1) * Rnd() + 1 'numero ramdon



        txtDados.Text = Num

        txtPuntaje.Text = Val(txtPuntaje.Text) + Num


        If txtDados.Text = 1 And tiradas <= (tiradas / 2) Then

            txtPuntaje.Text = 0
            txtDados.Text = ""
            MessageBox.Show("Su turno Finalizo :( , es turno del computador :)  !!!! ")

            'turnoCompu()

        End If

    End Sub

    Function random() As Integer

        Randomize()
        Dim Num As Integer = CInt(Math.Floor((1 - 2 + 1) * Rnd())) + 1
        Return Num 

    End Function



    Private Sub txtPuntaje_TextChanged(sender As Object, e As EventArgs) Handles txtPuntaje.TextChanged







    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click

        txtSumaPuntos.Text = Val(txtPuntaje.Text) + Val(txtSumaPuntos.Text)

        txtPuntaje.Text = 0
        txtDados.Text = ""
        If txtSumaPuntos.Text >= 100 Then
            MessageBox.Show("FELICIDADES HAZ GANADO EL JUEGO  ! ! ! ! ! ! ! ! ! ! ")
            txtSumaPuntos.Text = ""
            txtPuntosMaquina.Text = ""
            txtPuntaje.Text = ""
            txtDados.Text = ""
            MessageBox.Show("Desea realizar otra partida")

        End If





    End Sub

    Private Sub btnDetenermeMaq_Click(sender As Object, e As EventArgs) Handles btnDetenermeMaq.Click

        txtPuntosMaquina.Text = Val(txtPuntaje.Text) + Val(txtPuntosMaquina.Text)
        txtPuntaje.Text = 0
        txtDados.Text = ""
        If txtPuntosMaquina.Text >= 100 Then
            MessageBox.Show("FELICIDADES HAZ GANADO EL JUEGO   ! ! ! ! ! ! ! ! ! ! ! ! !")
            txtPuntosMaquina.Text = ""
            txtSumaPuntos.Text = ""
            txtPuntaje.Text = ""
            txtDados.Text = ""
            MessageBox.Show("Desea realizar otra partida")
        End If



    End Sub

    Private Sub txtSumaPuntos_TextChanged(sender As Object, e As EventArgs) Handles txtSumaPuntos.TextChanged

    End Sub

    Private Sub txtPuntosMaquina_TextChanged(sender As Object, e As EventArgs) Handles txtPuntosMaquina.TextChanged

    End Sub
End Class
