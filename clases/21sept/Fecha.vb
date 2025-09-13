Public Class Fecha
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "fecha"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(272, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(272, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "siguiente"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(272, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "volver"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(40, 240)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 32)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Button6"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(40, 288)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(176, 32)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Button7"
        '
        'Fecha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 341)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Fecha"
        Me.Text = "Fecha"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ALFA As New boleta
        ALFA.SHOW()
    End Sub
End Class
