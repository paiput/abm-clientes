Public Class Clientes
    Private Sub ButtonCarga_Click(sender As Object, e As EventArgs) Handles ButtonCarga.Click
        If TextBoxNombreCliente.Text = "" Then
            MsgBox("Falta cargar el nombre del cliente")
            Return
        End If
        If Not RadioButtonEfectivo.Checked And Not RadioButtonCuotas.Checked Then
            MsgBox("Falta especificar el metodo de pago")
            Return
        End If
        Dim cliente As String = TextBoxNombreCliente.Text
        If Listas.ListBoxEfectivo.Items.Contains(cliente) Or Listas.ListBoxCuotas.Items.Contains(cliente) Then
            MsgBox("El cliente ya esta registrado")
            Return
        End If
        If RadioButtonEfectivo.Checked Then
            Listas.ListBoxEfectivo.Items.Add(cliente)
        ElseIf RadioButtonCuotas.Checked Then
            Listas.ListBoxCuotas.Items.Add(cliente)
        End If
        TextBoxNombreCliente.Text = ""
        RadioButtonEfectivo.Checked = False
        RadioButtonCuotas.Checked = False
    End Sub

    Private Sub ButtonVerListas_Click(sender As Object, e As EventArgs) Handles ButtonVerListas.Click
        Listas.Show()
    End Sub

    Private Sub ButtonSiguiente_Click(sender As Object, e As EventArgs) Handles ButtonSiguiente.Click
        Articulos.Show()
    End Sub

    Private Sub ButtonFin_Click(sender As Object, e As EventArgs) Handles ButtonFin.Click
        Me.Close()
    End Sub
End Class