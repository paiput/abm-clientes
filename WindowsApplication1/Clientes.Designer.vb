<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonEfectivo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCuotas = New System.Windows.Forms.RadioButton()
        Me.ButtonCarga = New System.Windows.Forms.Button()
        Me.ButtonVerListas = New System.Windows.Forms.Button()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonFin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL CLIENTE"
        '
        'TextBoxNombreCliente
        '
        Me.TextBoxNombreCliente.Location = New System.Drawing.Point(117, 74)
        Me.TextBoxNombreCliente.Name = "TextBoxNombreCliente"
        Me.TextBoxNombreCliente.Size = New System.Drawing.Size(157, 22)
        Me.TextBoxNombreCliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forma de Pago"
        '
        'RadioButtonEfectivo
        '
        Me.RadioButtonEfectivo.AutoSize = True
        Me.RadioButtonEfectivo.Location = New System.Drawing.Point(190, 146)
        Me.RadioButtonEfectivo.Name = "RadioButtonEfectivo"
        Me.RadioButtonEfectivo.Size = New System.Drawing.Size(79, 21)
        Me.RadioButtonEfectivo.TabIndex = 3
        Me.RadioButtonEfectivo.TabStop = True
        Me.RadioButtonEfectivo.Text = "Efectivo"
        Me.RadioButtonEfectivo.UseVisualStyleBackColor = True
        '
        'RadioButtonCuotas
        '
        Me.RadioButtonCuotas.AutoSize = True
        Me.RadioButtonCuotas.Location = New System.Drawing.Point(190, 173)
        Me.RadioButtonCuotas.Name = "RadioButtonCuotas"
        Me.RadioButtonCuotas.Size = New System.Drawing.Size(94, 21)
        Me.RadioButtonCuotas.TabIndex = 4
        Me.RadioButtonCuotas.TabStop = True
        Me.RadioButtonCuotas.Text = "En Cuotas"
        Me.RadioButtonCuotas.UseVisualStyleBackColor = True
        '
        'ButtonCarga
        '
        Me.ButtonCarga.Location = New System.Drawing.Point(14, 240)
        Me.ButtonCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCarga.Name = "ButtonCarga"
        Me.ButtonCarga.Size = New System.Drawing.Size(113, 43)
        Me.ButtonCarga.TabIndex = 7
        Me.ButtonCarga.Text = "CARGA"
        Me.ButtonCarga.UseVisualStyleBackColor = True
        '
        'ButtonVerListas
        '
        Me.ButtonVerListas.Location = New System.Drawing.Point(135, 240)
        Me.ButtonVerListas.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonVerListas.Name = "ButtonVerListas"
        Me.ButtonVerListas.Size = New System.Drawing.Size(113, 43)
        Me.ButtonVerListas.TabIndex = 8
        Me.ButtonVerListas.Text = "VER LISTAS"
        Me.ButtonVerListas.UseVisualStyleBackColor = True
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.Location = New System.Drawing.Point(256, 240)
        Me.ButtonSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(113, 43)
        Me.ButtonSiguiente.TabIndex = 9
        Me.ButtonSiguiente.Text = "SIGUIENTE"
        Me.ButtonSiguiente.UseVisualStyleBackColor = True
        '
        'ButtonFin
        '
        Me.ButtonFin.Location = New System.Drawing.Point(135, 291)
        Me.ButtonFin.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonFin.Name = "ButtonFin"
        Me.ButtonFin.Size = New System.Drawing.Size(113, 43)
        Me.ButtonFin.TabIndex = 10
        Me.ButtonFin.Text = "FIN"
        Me.ButtonFin.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.ButtonFin)
        Me.Controls.Add(Me.ButtonSiguiente)
        Me.Controls.Add(Me.ButtonVerListas)
        Me.Controls.Add(Me.ButtonCarga)
        Me.Controls.Add(Me.RadioButtonCuotas)
        Me.Controls.Add(Me.RadioButtonEfectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombreCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "CARGA DE CLIENTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonEfectivo As RadioButton
    Friend WithEvents RadioButtonCuotas As RadioButton
    Friend WithEvents ButtonCarga As Button
    Friend WithEvents ButtonVerListas As Button
    Friend WithEvents ButtonSiguiente As Button
    Friend WithEvents ButtonFin As Button
End Class
