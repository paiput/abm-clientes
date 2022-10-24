<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.LabelFormaPago = New System.Windows.Forms.Label()
        Me.RadioButtonEfectivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCuotas = New System.Windows.Forms.RadioButton()
        Me.ButtonCarga = New System.Windows.Forms.Button()
        Me.ButtonVerListas = New System.Windows.Forms.Button()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonFin = New System.Windows.Forms.Button()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Location = New System.Drawing.Point(92, 38)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(126, 13)
        Me.LabelNombreCliente.TabIndex = 0
        Me.LabelNombreCliente.Text = "NOMBRE DEL CLIENTE"
        '
        'LabelFormaPago
        '
        Me.LabelFormaPago.AutoSize = True
        Me.LabelFormaPago.Location = New System.Drawing.Point(65, 130)
        Me.LabelFormaPago.Name = "LabelFormaPago"
        Me.LabelFormaPago.Size = New System.Drawing.Size(78, 13)
        Me.LabelFormaPago.TabIndex = 1
        Me.LabelFormaPago.Text = "Forma de pago"
        '
        'RadioButtonEfectivo
        '
        Me.RadioButtonEfectivo.AutoSize = True
        Me.RadioButtonEfectivo.Location = New System.Drawing.Point(161, 117)
        Me.RadioButtonEfectivo.Name = "RadioButtonEfectivo"
        Me.RadioButtonEfectivo.Size = New System.Drawing.Size(79, 17)
        Me.RadioButtonEfectivo.TabIndex = 2
        Me.RadioButtonEfectivo.TabStop = True
        Me.RadioButtonEfectivo.Text = "En efectivo"
        Me.RadioButtonEfectivo.UseVisualStyleBackColor = True
        '
        'RadioButtonCuotas
        '
        Me.RadioButtonCuotas.AutoSize = True
        Me.RadioButtonCuotas.Location = New System.Drawing.Point(161, 140)
        Me.RadioButtonCuotas.Name = "RadioButtonCuotas"
        Me.RadioButtonCuotas.Size = New System.Drawing.Size(73, 17)
        Me.RadioButtonCuotas.TabIndex = 3
        Me.RadioButtonCuotas.TabStop = True
        Me.RadioButtonCuotas.Text = "En cuotas"
        Me.RadioButtonCuotas.UseVisualStyleBackColor = True
        '
        'ButtonCarga
        '
        Me.ButtonCarga.Location = New System.Drawing.Point(21, 188)
        Me.ButtonCarga.Name = "ButtonCarga"
        Me.ButtonCarga.Size = New System.Drawing.Size(85, 35)
        Me.ButtonCarga.TabIndex = 4
        Me.ButtonCarga.Text = "CARGA"
        Me.ButtonCarga.UseVisualStyleBackColor = True
        '
        'ButtonVerListas
        '
        Me.ButtonVerListas.Location = New System.Drawing.Point(112, 188)
        Me.ButtonVerListas.Name = "ButtonVerListas"
        Me.ButtonVerListas.Size = New System.Drawing.Size(85, 35)
        Me.ButtonVerListas.TabIndex = 5
        Me.ButtonVerListas.Text = "VER LISTAS"
        Me.ButtonVerListas.UseVisualStyleBackColor = True
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.Location = New System.Drawing.Point(202, 188)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(85, 35)
        Me.ButtonSiguiente.TabIndex = 6
        Me.ButtonSiguiente.Text = "SIGUIENTE"
        Me.ButtonSiguiente.UseVisualStyleBackColor = True
        '
        'ButtonFin
        '
        Me.ButtonFin.Location = New System.Drawing.Point(112, 229)
        Me.ButtonFin.Name = "ButtonFin"
        Me.ButtonFin.Size = New System.Drawing.Size(85, 35)
        Me.ButtonFin.TabIndex = 7
        Me.ButtonFin.Text = "FIN"
        Me.ButtonFin.UseVisualStyleBackColor = True
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(95, 65)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(123, 22)
        Me.TextBoxNombreCliente.TabIndex = 8
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 286)
        Me.Controls.Add(Me.TextBoxNombreCliente)
        Me.Controls.Add(Me.ButtonFin)
        Me.Controls.Add(Me.ButtonSiguiente)
        Me.Controls.Add(Me.ButtonVerListas)
        Me.Controls.Add(Me.ButtonCarga)
        Me.Controls.Add(Me.RadioButtonCuotas)
        Me.Controls.Add(Me.RadioButtonEfectivo)
        Me.Controls.Add(Me.LabelFormaPago)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Name = "FormClientes"
        Me.Text = "CARGA DE CLIENTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelNombreCliente As System.Windows.Forms.Label
    Friend WithEvents LabelFormaPago As System.Windows.Forms.Label
    Friend WithEvents RadioButtonEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCuotas As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonCarga As System.Windows.Forms.Button
    Friend WithEvents ButtonVerListas As System.Windows.Forms.Button
    Friend WithEvents ButtonSiguiente As System.Windows.Forms.Button
    Friend WithEvents ButtonFin As System.Windows.Forms.Button
    Friend WithEvents TextBoxNombreCliente As System.Windows.Forms.TextBox

End Class
