Public Class boleta
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents cmd4 As System.Windows.Forms.Button
    Friend WithEvents cmd5 As System.Windows.Forms.Button
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Lbl2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Lbl3 = New System.Windows.Forms.Label
        Me.Lbl4 = New System.Windows.Forms.Label
        Me.Lbl5 = New System.Windows.Forms.Label
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Txt3 = New System.Windows.Forms.TextBox
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.cmd3 = New System.Windows.Forms.Button
        Me.cmd4 = New System.Windows.Forms.Button
        Me.cmd5 = New System.Windows.Forms.Button
        Me.Txt4 = New System.Windows.Forms.TextBox
        Me.Lbl6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.Location = New System.Drawing.Point(16, 24)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(72, 16)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Nº Boleta"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(88, 24)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(80, 20)
        Me.Txt1.TabIndex = 1
        Me.Txt1.Text = ""
        '
        'Lbl2
        '
        Me.Lbl2.Location = New System.Drawing.Point(16, 64)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(104, 32)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "Cliente(Opcional)"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(16, 216)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(440, 69)
        Me.ListBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(120, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"super 8", "chocolate", "coca cola", "cafe", "te", "galletas"})
        Me.ComboBox2.Location = New System.Drawing.Point(120, 104)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'Lbl3
        '
        Me.Lbl3.Location = New System.Drawing.Point(16, 104)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(88, 24)
        Me.Lbl3.TabIndex = 6
        Me.Lbl3.Text = "Producto"
        '
        'Lbl4
        '
        Me.Lbl4.Location = New System.Drawing.Point(16, 144)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(88, 24)
        Me.Lbl4.TabIndex = 7
        Me.Lbl4.Text = "Precio"
        '
        'Lbl5
        '
        Me.Lbl5.Location = New System.Drawing.Point(16, 176)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(88, 24)
        Me.Lbl5.TabIndex = 8
        Me.Lbl5.Text = "Cantidad"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(120, 144)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(80, 20)
        Me.Txt2.TabIndex = 9
        Me.Txt2.Text = ""
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(120, 176)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(80, 20)
        Me.Txt3.TabIndex = 10
        Me.Txt3.Text = ""
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(288, 64)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(168, 24)
        Me.cmd1.TabIndex = 11
        Me.cmd1.Text = "Agregar Cliente"
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(288, 104)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(168, 24)
        Me.cmd2.TabIndex = 12
        Me.cmd2.Text = "Agregar Producto"
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(288, 144)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(168, 24)
        Me.cmd3.TabIndex = 13
        Me.cmd3.Text = "Agregar a la venta"
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(24, 304)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(120, 24)
        Me.cmd4.TabIndex = 14
        Me.cmd4.Text = "Generar Venta"
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(192, 304)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(104, 24)
        Me.cmd5.TabIndex = 15
        Me.cmd5.Text = "Calcular"
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(376, 304)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(80, 20)
        Me.Txt4.TabIndex = 16
        Me.Txt4.Text = ""
        '
        'Lbl6
        '
        Me.Lbl6.Location = New System.Drawing.Point(328, 304)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(40, 24)
        Me.Lbl6.TabIndex = 17
        Me.Lbl6.Text = "Total"
        '
        'boleta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 365)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl1)
        Me.Name = "boleta"
        Me.Text = "boleta"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt1.TextChanged
        

    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        Dim suma As Integer
        suma = suma + 1
        Txt1.Text = suma
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim llama As New boleta
        Dim file As StreamWriter = New StreamWriter("c:\prueba\clientes.txt", True)
        Dim line As String
        file.WriteLine(txtRut.Text & "/" & txtNom.Text & "/" & txtDir.Text & "/" & txtTel.Text & "/" & cboComuna.Text & "/" & txtMail.Text & "/")
        file.Close()
        MessageBox.Show("Los datos Fueron grabados", " Aviso")
        Me.Finalize()
        llama.Show()
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click

    End Sub
End Class
