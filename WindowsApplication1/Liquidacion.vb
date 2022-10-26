Public Class Liquidacion
    Dim cliente As String
    Dim lista As String
    Dim precio As Integer

    Private Sub ButtonVerListas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerListas.Click
        Dim result As DialogResult = MessageBox.Show("¿Desea realizar el pago?", "Confirmacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If lista = "efectivo" Then
                Listas.ListBoxEfectivo.Items.Remove(cliente)
            ElseIf lista = "cuotas" Then
                Listas.ListBoxCuotas.Items.Remove(cliente)
            End If
            MsgBox($"El cliente ha sido eliminado de la lista de pago en {lista}")
        End If
        Clientes.Show()
        Me.Close()
    End Sub

    Private Sub Liquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente = InputBox("Ingrese nombre del cliente")
        While Not Listas.ListBoxEfectivo.Items.Contains(cliente) And Not Listas.ListBoxCuotas.Items.Contains(cliente)
            MsgBox("El cliente ingresado no se encuentra en las listas")
            cliente = InputBox("Ingrese nombre del cliente")
        End While
        If Listas.ListBoxEfectivo.Items.Contains(cliente) Then
            lista = "efectivo"
            precio = Articulos.GetPrecioEfectivo()
        Else
            lista = "cuotas"
            precio = Articulos.GetPrecioCuotas()
        End If
        TextBoxNombreCliente.Text = cliente
        TextBoxNombreArticulo.Text = Articulos.ComboBoxArticulos.Text
        TextBoxCantYPrecio.Text = $"{Articulos.GetUnidades()} x ${Articulos.GetPrecioUnitario()}"
        TextBoxTotal.Text = "$" + precio.ToString()
    End Sub
End Class