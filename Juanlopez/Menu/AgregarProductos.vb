Imports System.io
Public Class frmAgProd
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents cboProv As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.txtstock = New System.Windows.Forms.TextBox
        Me.cboProv = New System.Windows.Forms.ComboBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Producto    :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Producto   :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio                    :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock                     :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre Proveedor :"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(144, 64)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(56, 20)
        Me.txtCod.TabIndex = 5
        Me.txtCod.Text = ""
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(144, 88)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(120, 20)
        Me.txtNom.TabIndex = 6
        Me.txtNom.Text = ""
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(144, 112)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(56, 20)
        Me.txtPrecio.TabIndex = 7
        Me.txtPrecio.Text = ""
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(144, 136)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(56, 20)
        Me.txtstock.TabIndex = 8
        Me.txtstock.Text = ""
        '
        'cboProv
        '
        Me.cboProv.Location = New System.Drawing.Point(144, 160)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Size = New System.Drawing.Size(120, 21)
        Me.cboProv.TabIndex = 9
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(72, 208)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.TabIndex = 10
        Me.cmdAgregar.Text = "Agregar"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ingrese Datos del Producto"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(168, 208)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 12
        Me.cmdVolver.Text = "Volver"
        '
        'frmAgProd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 262)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgProd"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim llamar As New frmAgProd
        Dim file As StreamWriter = New StreamWriter("c:\prueba\Productos.txt", True)
        file.WriteLine(txtCod.Text & "/" & txtNom.Text & "/" & txtPrecio.Text & "/" & txtstock.Text & "/" & cboProv.Text & "/")
        file.Close()
        MessageBox.Show("Los datos Fueron grabados", " Aviso")
        Me.Finalize()
        llamar.Show()
    End Sub

    Private Sub frmAgProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file As StreamReader = New StreamReader("c:\prueba\proveedores.txt")
        Dim line As String
        Dim i As Integer
        Dim x, z As String
        line = file.ReadLine
        While line <> Nothing
            i = 1
            Do
                x = Mid(line, i, 1)
                If x = "/" Then
                    Do
                        i = i + 1
                        x = Mid(line, i, 1)
                        If x = "/" Then
                            Exit Do
                        End If
                        z = z & x
                    Loop
                End If
                If x = "/" Then
                    Exit Do
                End If
                i = i + 1
            Loop
            cboProv.Items.Add(z)
            line = file.ReadLine
            z = ""
        End While

    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Finalize()
    End Sub
End Class
