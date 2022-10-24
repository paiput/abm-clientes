Public Class Articulos
    Dim unidades As Integer = 0

    Private Sub Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumericUpDownOtra.Hide()
    End Sub

    'crear handle de botones que cambian variable unidades

    Private Sub RadioButtonOtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonOtra.CheckedChanged
        If RadioButtonOtra.Checked Then
            NumericUpDownOtra.Show()
        Else
            NumericUpDownOtra.Hide()
        End If
    End Sub

    Private Sub ButtonContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonContinuar.Click
        Liquidacion.Show()
        Me.Hide()
    End Sub
End Class