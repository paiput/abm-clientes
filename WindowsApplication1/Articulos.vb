Public Class Articulos
    Dim unidades As Integer = 0
    Dim precioUnitario As Integer = 0

    Public Function GetPrecioUnitario()
        Return precioUnitario
    End Function

    Public Function GetUnidades()
        Return unidades
    End Function

    Public Function GetPrecioEfectivo()
        Return (precioUnitario * unidades) * 0.9
    End Function

    Public Function GetPrecioCuotas()
        Return (precioUnitario * unidades) * 1.15
    End Function

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
        LabelPrecioEfectivo.Visible = True
        LabelPrecioCuotas.Visible = True
        LabelPrecioEfectivo.Text = "Precio en efectivo: $" + GetPrecioEfectivo().ToString()
        LabelPrecioCuotas.Text = "Precio en cuotas: $" + GetPrecioCuotas().ToString()
    End Sub

    Private Sub ButtonContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonContinuar.Click
        If unidades = 0 Or ComboBoxArticulos.Text = "" Or precioUnitario = 0 Then
            MsgBox("Especificar articulo, unidades, y precio para continuar")
            Return
        End If
        Liquidacion.Show()
        Me.Close()
    End Sub
End Class