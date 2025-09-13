Public Class Frm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblrut As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents Lbldireccion As System.Windows.Forms.Label
    Friend WithEvents Lblcomuna As System.Windows.Forms.Label
    Friend WithEvents Lblproducto As System.Windows.Forms.Label
    Friend WithEvents Lblcantidad As System.Windows.Forms.Label
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtComuna As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarp As System.Windows.Forms.Button
    Friend WithEvents cmdNewventa As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lstLista As System.Windows.Forms.ListBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lblrut = New System.Windows.Forms.Label
        Me.Lblnombre = New System.Windows.Forms.Label
        Me.Lbldireccion = New System.Windows.Forms.Label
        Me.Lblcomuna = New System.Windows.Forms.Label
        Me.lstLista = New System.Windows.Forms.ListBox
        Me.CboProducto = New System.Windows.Forms.ComboBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdAgregarp = New System.Windows.Forms.Button
        Me.Lblproducto = New System.Windows.Forms.Label
        Me.Lblcantidad = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtComuna = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.cmdNewventa = New System.Windows.Forms.Button
        Me.Lbltotal = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.cmdNext = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESTAURANTE COMIDA EXPRESS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblrut
        '
        Me.Lblrut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrut.Location = New System.Drawing.Point(24, 56)
        Me.Lblrut.Name = "Lblrut"
        Me.Lblrut.Size = New System.Drawing.Size(64, 16)
        Me.Lblrut.TabIndex = 1
        Me.Lblrut.Text = "Rut cliente"
        '
        'Lblnombre
        '
        Me.Lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnombre.Location = New System.Drawing.Point(24, 88)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(64, 16)
        Me.Lblnombre.TabIndex = 2
        Me.Lblnombre.Text = "Nombre"
        '
        'Lbldireccion
        '
        Me.Lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldireccion.Location = New System.Drawing.Point(24, 120)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(64, 16)
        Me.Lbldireccion.TabIndex = 3
        Me.Lbldireccion.Text = "Direccion"
        '
        'Lblcomuna
        '
        Me.Lblcomuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcomuna.Location = New System.Drawing.Point(24, 152)
        Me.Lblcomuna.Name = "Lblcomuna"
        Me.Lblcomuna.Size = New System.Drawing.Size(64, 16)
        Me.Lblcomuna.TabIndex = 4
        Me.Lblcomuna.Text = "Comuna"
        '
        'lstLista
        '
        Me.lstLista.Location = New System.Drawing.Point(8, 104)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(384, 69)
        Me.lstLista.TabIndex = 5
        '
        'CboProducto
        '
        Me.CboProducto.Items.AddRange(New Object() {"cola cola", "sprite", "fanta", "super ocho", "chocolate", "alfajor", "tuareg", "cafe", "te", "otras galletas"})
        Me.CboProducto.Location = New System.Drawing.Point(64, 16)
        Me.CboProducto.Name = "CboProducto"
        Me.CboProducto.Size = New System.Drawing.Size(208, 21)
        Me.CboProducto.TabIndex = 6
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(280, 56)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(96, 24)
        Me.cmdBuscar.TabIndex = 7
        Me.cmdBuscar.Text = "BUSCAR"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(280, 128)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(104, 24)
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = "AGREGAR"
        '
        'cmdAgregarp
        '
        Me.cmdAgregarp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarp.Location = New System.Drawing.Point(280, 16)
        Me.cmdAgregarp.Name = "cmdAgregarp"
        Me.cmdAgregarp.Size = New System.Drawing.Size(104, 24)
        Me.cmdAgregarp.TabIndex = 9
        Me.cmdAgregarp.Text = "AGREGAR"
        '
        'Lblproducto
        '
        Me.Lblproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblproducto.Location = New System.Drawing.Point(8, 16)
        Me.Lblproducto.Name = "Lblproducto"
        Me.Lblproducto.Size = New System.Drawing.Size(56, 24)
        Me.Lblproducto.TabIndex = 10
        Me.Lblproducto.Text = "Producto"
        '
        'Lblcantidad
        '
        Me.Lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcantidad.Location = New System.Drawing.Point(8, 48)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(64, 24)
        Me.Lblcantidad.TabIndex = 11
        Me.Lblcantidad.Text = "Cantidad"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(88, 56)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(112, 20)
        Me.txtRut.TabIndex = 12
        Me.txtRut.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(88, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 13
        Me.txtNombre.Text = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(88, 120)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(160, 20)
        Me.txtDireccion.TabIndex = 14
        Me.txtDireccion.Text = ""
        '
        'txtComuna
        '
        Me.txtComuna.Location = New System.Drawing.Point(88, 152)
        Me.txtComuna.Name = "txtComuna"
        Me.txtComuna.Size = New System.Drawing.Size(160, 20)
        Me.txtComuna.TabIndex = 15
        Me.txtComuna.Text = ""
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(72, 48)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(56, 20)
        Me.txtCantidad.TabIndex = 16
        Me.txtCantidad.Text = ""
        '
        'cmdNewventa
        '
        Me.cmdNewventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewventa.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.cmdNewventa.Location = New System.Drawing.Point(16, 424)
        Me.cmdNewventa.Name = "cmdNewventa"
        Me.cmdNewventa.Size = New System.Drawing.Size(104, 24)
        Me.cmdNewventa.TabIndex = 17
        Me.cmdNewventa.Text = "NUEVA VENTA"
        '
        'Lbltotal
        '
        Me.Lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal.Location = New System.Drawing.Point(240, 184)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(48, 16)
        Me.Lbltotal.TabIndex = 18
        Me.Lbltotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(296, 184)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(88, 20)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lstLista)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Lbltotal)
        Me.GroupBox1.Controls.Add(Me.Lblcantidad)
        Me.GroupBox1.Controls.Add(Me.Lblproducto)
        Me.GroupBox1.Controls.Add(Me.CboProducto)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.cmdAgregarp)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 208)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(296, 424)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(112, 24)
        Me.cmdNext.TabIndex = 21
        Me.cmdNext.Text = "NEXT"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(72, 72)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(56, 20)
        Me.txtprecio.TabIndex = 21
        Me.txtprecio.Text = ""
        '
        'Frm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 461)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtComuna)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Lblcomuna)
        Me.Controls.Add(Me.Lbldireccion)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.Lblrut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdNewventa)
        Me.Name = "Frm"
        Me.Text = "Formulario"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Dim agregar As String
        Dim mat As SaveFileDialog
        SaveFileDialog1.Filter = ""

        SaveFileDialog1.Filter = agregar

        SaveFileDialog1.ShowDialog()
        agregar = (txtRut.Text & "/" & txtNombre.Text & "/" & txtDireccion.Text & "/" & "/" & txtComuna.Text & "/")
        txtRut.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtComuna.Text = ""
        MessageBox.Show("sus datos fueron guardados", " Aviso")

    End Sub

    Private Sub Cmdbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmdagregarp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarp.Click

        lstLista.Items.Add(CboProducto.SelectedItem & "               " & txtCantidad.Text & "               " & txtprecio.Text)
        txtCantidad.Text = ""
        txtprecio.Text = ""
        txtTotal.Text = Val(txtCantidad.Text) * Val(txtprecio.Text)

    End Sub

    Private Sub CbBproducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProducto.SelectedIndexChanged

    End Sub

    Private Sub Cmdnewventa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewventa.Click

        Dim nuevo As New Frm
        Me.Finalize()
        nuevo.Show()
        Dim venta As Integer
        venta = venta + 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Dim alfa As New frmRent
        alfa.Show()
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub
End Class
