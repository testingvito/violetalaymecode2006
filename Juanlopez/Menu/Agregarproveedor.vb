Imports System.io
Public Class frmAgprov
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
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lblprov As System.Windows.Forms.Label
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCod = New System.Windows.Forms.Label
        Me.lblNom = New System.Windows.Forms.Label
        Me.lblDir = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.lblprov = New System.Windows.Forms.Label
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.Location = New System.Drawing.Point(32, 72)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(112, 23)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Codigo Proveedor    :"
        '
        'lblNom
        '
        Me.lblNom.Location = New System.Drawing.Point(32, 96)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(112, 23)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nombre Proveedor   :"
        '
        'lblDir
        '
        Me.lblDir.Location = New System.Drawing.Point(32, 120)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(112, 23)
        Me.lblDir.TabIndex = 2
        Me.lblDir.Text = "Direccion                  :"
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(32, 144)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(112, 23)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono                   :"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(144, 64)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(56, 20)
        Me.txtCod.TabIndex = 4
        Me.txtCod.Text = ""
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(144, 88)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(128, 20)
        Me.txtNom.TabIndex = 5
        Me.txtNom.Text = ""
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(144, 112)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(128, 20)
        Me.txtDir.TabIndex = 6
        Me.txtDir.Text = ""
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(144, 136)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(56, 20)
        Me.txtTel.TabIndex = 7
        Me.txtTel.Text = ""
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(72, 192)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = "Agregar"
        '
        'lblprov
        '
        Me.lblprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprov.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblprov.Location = New System.Drawing.Point(64, 24)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(184, 23)
        Me.lblprov.TabIndex = 9
        Me.lblprov.Text = "Ingrese Datos del Proveedor"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(168, 192)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 10
        Me.cmdVolver.Text = "Volver"
        '
        'frmAgprov
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 246)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.lblprov)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCod)
        Me.Name = "frmAgprov"
        Me.Text = " Agregar Proveedor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim file As StreamWriter = New StreamWriter("c:\prueba\proveedores.txt", True)
        file.WriteLine(txtCod.Text & "/" & txtNom.Text & "/" & txtDir.Text & "/" & txtTel.Text & "/")
        file.Close()
        MessageBox.Show("Los datos Fueron grabados", " Aviso")
        Me.Finalize()
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Finalize()
    End Sub
End Class
