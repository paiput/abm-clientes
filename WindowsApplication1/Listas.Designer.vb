<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listas
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
        Me.ListBoxEfectivo = New System.Windows.Forms.ListBox()
        Me.ListBoxCuotas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxEfectivo
        '
        Me.ListBoxEfectivo.FormattingEnabled = True
        Me.ListBoxEfectivo.Location = New System.Drawing.Point(25, 72)
        Me.ListBoxEfectivo.Name = "ListBoxEfectivo"
        Me.ListBoxEfectivo.Size = New System.Drawing.Size(75, 95)
        Me.ListBoxEfectivo.TabIndex = 0
        '
        'ListBoxCuotas
        '
        Me.ListBoxCuotas.FormattingEnabled = True
        Me.ListBoxCuotas.Location = New System.Drawing.Point(172, 72)
        Me.ListBoxCuotas.Name = "ListBoxCuotas"
        Me.ListBoxCuotas.Size = New System.Drawing.Size(75, 95)
        Me.ListBoxCuotas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PAGO EFECTIVO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PAGO CUOTAS"
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(98, 195)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(85, 35)
        Me.ButtonVolver.TabIndex = 6
        Me.ButtonVolver.Text = "VOLVER"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        'Listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxCuotas)
        Me.Controls.Add(Me.ListBoxEfectivo)
        Me.Name = "Listas"
        Me.Text = "LISTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxEfectivo As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxCuotas As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonVolver As System.Windows.Forms.Button
End Class
