Public Class frmRent
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarcliente As System.Windows.Forms.Button
    Friend WithEvents cmdBsucararriendo As System.Windows.Forms.Button
    Friend WithEvents cmdCalcular As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscarestadistica As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtKlporlitro As System.Windows.Forms.TextBox
    Friend WithEvents txtNdias As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdRentar As System.Windows.Forms.Button
    Friend WithEvents txtKlvehiculo As System.Windows.Forms.TextBox
    Friend WithEvents txtKlrecorrido As System.Windows.Forms.TextBox
    Friend WithEvents txtArriendorealizado As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasarrendados As System.Windows.Forms.TextBox
    Friend WithEvents txtAcumulado As System.Windows.Forms.TextBox
    Friend WithEvents Seleccion As System.Windows.Forms.ComboBox
    Friend WithEvents vehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents vehiculo2 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdAgregarcliente = New System.Windows.Forms.Button
        Me.cmdBsucararriendo = New System.Windows.Forms.Button
        Me.cmdCalcular = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdBuscarestadistica = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtNdias = New System.Windows.Forms.TextBox
        Me.txtKlporlitro = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Seleccion = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdRentar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.vehiculo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtKlvehiculo = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtAcumulado = New System.Windows.Forms.TextBox
        Me.txtDiasarrendados = New System.Windows.Forms.TextBox
        Me.txtArriendorealizado = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.vehiculo2 = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtKlrecorrido = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(144, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RENT A CAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rut"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(80, 40)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(152, 20)
        Me.txtRut.TabIndex = 2
        Me.txtRut.Text = ""
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(368, 40)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(104, 24)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Text = "BUSCAR"
        '
        'cmdAgregarcliente
        '
        Me.cmdAgregarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarcliente.Location = New System.Drawing.Point(368, 72)
        Me.cmdAgregarcliente.Name = "cmdAgregarcliente"
        Me.cmdAgregarcliente.Size = New System.Drawing.Size(104, 40)
        Me.cmdAgregarcliente.TabIndex = 4
        Me.cmdAgregarcliente.Text = "AGREGAR CLIENTE"
        '
        'cmdBsucararriendo
        '
        Me.cmdBsucararriendo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBsucararriendo.Location = New System.Drawing.Point(288, 24)
        Me.cmdBsucararriendo.Name = "cmdBsucararriendo"
        Me.cmdBsucararriendo.Size = New System.Drawing.Size(144, 24)
        Me.cmdBsucararriendo.TabIndex = 5
        Me.cmdBsucararriendo.Text = "BUSCAR ARRIENDO"
        '
        'cmdCalcular
        '
        Me.cmdCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcular.Location = New System.Drawing.Point(240, 112)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.Size = New System.Drawing.Size(104, 24)
        Me.cmdCalcular.TabIndex = 6
        Me.cmdCalcular.Text = "CALCULAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(240, 152)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 24)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "CANCELAR"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(376, 24)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(104, 24)
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = "AGREGAR"
        '
        'cmdBuscarestadistica
        '
        Me.cmdBuscarestadistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscarestadistica.Location = New System.Drawing.Point(376, 24)
        Me.cmdBuscarestadistica.Name = "cmdBuscarestadistica"
        Me.cmdBuscarestadistica.Size = New System.Drawing.Size(104, 24)
        Me.cmdBuscarestadistica.TabIndex = 9
        Me.cmdBuscarestadistica.Text = "BUSCAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtNdias)
        Me.GroupBox1.Controls.Add(Me.txtKlporlitro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Seleccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdBsucararriendo)
        Me.GroupBox1.Controls.Add(Me.cmdCalcular)
        Me.GroupBox1.Controls.Add(Me.cmdRentar)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 192)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arriendo vehiculo"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(88, 112)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(136, 20)
        Me.txtTotal.TabIndex = 24
        Me.txtTotal.Text = ""
        '
        'txtNdias
        '
        Me.txtNdias.Location = New System.Drawing.Point(88, 80)
        Me.txtNdias.Name = "txtNdias"
        Me.txtNdias.Size = New System.Drawing.Size(136, 20)
        Me.txtNdias.TabIndex = 23
        Me.txtNdias.Text = ""
        '
        'txtKlporlitro
        '
        Me.txtKlporlitro.Location = New System.Drawing.Point(88, 56)
        Me.txtKlporlitro.Name = "txtKlporlitro"
        Me.txtKlporlitro.Size = New System.Drawing.Size(136, 20)
        Me.txtKlporlitro.TabIndex = 22
        Me.txtKlporlitro.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Nº dias"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 26)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "kilometros por litro"
        '
        'Seleccion
        '
        Me.Seleccion.Location = New System.Drawing.Point(88, 24)
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.Size = New System.Drawing.Size(192, 21)
        Me.Seleccion.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 26)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "selecion de vehiculo"
        '
        'cmdRentar
        '
        Me.cmdRentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRentar.Location = New System.Drawing.Point(96, 152)
        Me.cmdRentar.Name = "cmdRentar"
        Me.cmdRentar.Size = New System.Drawing.Size(104, 24)
        Me.cmdRentar.TabIndex = 17
        Me.cmdRentar.Text = "RENTAR"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 14
        Me.txtNombre.Text = ""
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(80, 88)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(152, 20)
        Me.txtDireccion.TabIndex = 15
        Me.txtDireccion.Text = ""
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(80, 112)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(152, 20)
        Me.txttelefono.TabIndex = 16
        Me.txttelefono.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.vehiculo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtKlvehiculo)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 56)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devolucion"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "vehiculo"
        '
        'vehiculo
        '
        Me.vehiculo.Location = New System.Drawing.Point(64, 24)
        Me.vehiculo.Name = "vehiculo"
        Me.vehiculo.Size = New System.Drawing.Size(192, 21)
        Me.vehiculo.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 26)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "kilometros vehiculo"
        '
        'txtKlvehiculo
        '
        Me.txtKlvehiculo.Location = New System.Drawing.Point(312, 24)
        Me.txtKlvehiculo.Name = "txtKlvehiculo"
        Me.txtKlvehiculo.Size = New System.Drawing.Size(56, 20)
        Me.txtKlvehiculo.TabIndex = 25
        Me.txtKlvehiculo.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAcumulado)
        Me.GroupBox3.Controls.Add(Me.txtDiasarrendados)
        Me.GroupBox3.Controls.Add(Me.txtArriendorealizado)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cmdBuscarestadistica)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.vehiculo2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtKlrecorrido)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 152)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadisticas"
        '
        'txtAcumulado
        '
        Me.txtAcumulado.Location = New System.Drawing.Point(152, 120)
        Me.txtAcumulado.Name = "txtAcumulado"
        Me.txtAcumulado.Size = New System.Drawing.Size(136, 20)
        Me.txtAcumulado.TabIndex = 31
        Me.txtAcumulado.Text = ""
        '
        'txtDiasarrendados
        '
        Me.txtDiasarrendados.Location = New System.Drawing.Point(152, 96)
        Me.txtDiasarrendados.Name = "txtDiasarrendados"
        Me.txtDiasarrendados.Size = New System.Drawing.Size(136, 20)
        Me.txtDiasarrendados.TabIndex = 30
        Me.txtDiasarrendados.Text = ""
        '
        'txtArriendorealizado
        '
        Me.txtArriendorealizado.Location = New System.Drawing.Point(152, 72)
        Me.txtArriendorealizado.Name = "txtArriendorealizado"
        Me.txtArriendorealizado.Size = New System.Drawing.Size(136, 20)
        Me.txtArriendorealizado.TabIndex = 29
        Me.txtArriendorealizado.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(24, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "dinero acumulado"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(24, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "dias arrendados"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(24, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "arriendos realizados"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(24, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "vehiculo"
        '
        'vehiculo2
        '
        Me.vehiculo2.Location = New System.Drawing.Point(152, 24)
        Me.vehiculo2.Name = "vehiculo2"
        Me.vehiculo2.Size = New System.Drawing.Size(192, 21)
        Me.vehiculo2.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(24, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "kilometros recorrido"
        '
        'txtKlrecorrido
        '
        Me.txtKlrecorrido.Location = New System.Drawing.Point(152, 48)
        Me.txtKlrecorrido.Name = "txtKlrecorrido"
        Me.txtKlrecorrido.Size = New System.Drawing.Size(136, 20)
        Me.txtKlrecorrido.TabIndex = 25
        Me.txtKlrecorrido.Text = ""
        '
        'frmRent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 565)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAgregarcliente)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRent"
        Me.Text = "RENTA A CAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Dim nuevo As New Frm
        Me.Finalize()
        nuevo.Show()
    End Sub
End Class
