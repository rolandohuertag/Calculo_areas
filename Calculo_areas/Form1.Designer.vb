<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtlado = New System.Windows.Forms.TextBox()
        Me.Cuadrado = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrespuesta = New System.Windows.Forms.TextBox()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rectangulo = New System.Windows.Forms.RadioButton()
        Me.triangulo = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lado:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtlado
        '
        Me.txtlado.Location = New System.Drawing.Point(79, 18)
        Me.txtlado.Name = "txtlado"
        Me.txtlado.Size = New System.Drawing.Size(100, 20)
        Me.txtlado.TabIndex = 2
        '
        'Cuadrado
        '
        Me.Cuadrado.AutoSize = True
        Me.Cuadrado.Location = New System.Drawing.Point(16, 31)
        Me.Cuadrado.Name = "Cuadrado"
        Me.Cuadrado.Size = New System.Drawing.Size(71, 17)
        Me.Cuadrado.TabIndex = 3
        Me.Cuadrado.TabStop = True
        Me.Cuadrado.Text = "Cuadrado"
        Me.Cuadrado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ÁREA:"
        '
        'txtrespuesta
        '
        Me.txtrespuesta.Location = New System.Drawing.Point(100, 89)
        Me.txtrespuesta.Name = "txtrespuesta"
        Me.txtrespuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtrespuesta.TabIndex = 5
        '
        'Cerrar
        '
        Me.Cerrar.Location = New System.Drawing.Point(207, 45)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Cerrar.TabIndex = 6
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.triangulo)
        Me.GroupBox1.Controls.Add(Me.rectangulo)
        Me.GroupBox1.Controls.Add(Me.Cuadrado)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Figura"
        '
        'rectangulo
        '
        Me.rectangulo.AutoSize = True
        Me.rectangulo.Location = New System.Drawing.Point(106, 31)
        Me.rectangulo.Name = "rectangulo"
        Me.rectangulo.Size = New System.Drawing.Size(80, 17)
        Me.rectangulo.TabIndex = 4
        Me.rectangulo.TabStop = True
        Me.rectangulo.Text = "Rectángulo"
        Me.rectangulo.UseVisualStyleBackColor = True
        '
        'triangulo
        '
        Me.triangulo.AutoSize = True
        Me.triangulo.Location = New System.Drawing.Point(16, 63)
        Me.triangulo.Name = "triangulo"
        Me.triangulo.Size = New System.Drawing.Size(69, 17)
        Me.triangulo.TabIndex = 5
        Me.triangulo.TabStop = True
        Me.triangulo.Text = "Triángulo"
        Me.triangulo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Altura:"
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(79, 47)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(100, 20)
        Me.txtaltura.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 234)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.txtrespuesta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculo de Areas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtlado As TextBox
    Friend WithEvents Cuadrado As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrespuesta As TextBox
    Friend WithEvents Cerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents triangulo As RadioButton
    Friend WithEvents rectangulo As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtaltura As TextBox
End Class
