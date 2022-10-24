Public Class Articulos
    Dim unidades As Integer = 0
    Dim precioUnitario As Integer = 0
    Dim precio = 0
    Dim precioEfectivo As Integer = 0
    Dim precioCuotas As Integer = 0

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        unidades = 6
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        unidades = 12
    End Sub

    Private Sub RadioButtonOtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOtra.CheckedChanged
        If RadioButtonOtra.Checked Then
            NumericUpDownOtra.Visible = True
        Else
            NumericUpDownOtra.Visible = False
            unidades = 0
        End If
    End Sub
    Private Sub NumericUpDownOtra_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownOtra.ValueChanged
        unidades = NumericUpDownOtra.Value
    End Sub

    Private Sub NumericUpDownPrecio_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownPrecio.ValueChanged
        precioUnitario = NumericUpDownPrecio.Value
    End Sub

    Private Sub ButtonCalculo_Click(sender As Object, e As EventArgs) Handles ButtonCalculo.Click
        If unidades = 0 Then
            MsgBox("Falta especificar unidades")
            Return
        End If
        If NumericUpDownPrecio.Value = 0 Then
            MsgBox("Falta especificar el precio por unidad")
            Return
        End If
        precio = precioUnitario * unidades
        precioEfectivo = precio * 0.9
        precioCuotas = precio * 1.15
        LabelPrecioEfectivo.Visible = True
        LabelPrecioCuotas.Visible = True
        LabelPrecioEfectivo.Text = "Precio en efectivo: $" + precioEfectivo.ToString()
        LabelPrecioCuotas.Text = "Precio en cuotas: $" + precioCuotas.ToString()
    End Sub

    Private Sub ButtonContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonContinuar.Click
        Liquidacion.Show()
        Me.Hide()
    End Sub
End Class