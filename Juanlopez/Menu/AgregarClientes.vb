Imports System.IO
Public Class frmAgcli
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
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents cboComuna As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRut = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.cboComuna = New System.Windows.Forms.ComboBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Datos del Cliente"
        '
        'lblRut
        '
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRut.Location = New System.Drawing.Point(40, 72)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.TabIndex = 1
        Me.lblRut.Text = "Rut                    :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(40, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre              :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(40, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Direccion           :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(40, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefono            :"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(40, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Comuna             :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(40, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "E - mail               :"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(128, 72)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(72, 20)
        Me.txtRut.TabIndex = 7
        Me.txtRut.Text = ""
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(128, 96)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.TabIndex = 8
        Me.txtNom.Text = ""
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(128, 144)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(64, 20)
        Me.txtTel.TabIndex = 9
        Me.txtTel.Text = ""
        '
        'txtDir
        '
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(128, 120)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.TabIndex = 10
        Me.txtDir.Text = ""
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(128, 192)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(136, 20)
        Me.txtMail.TabIndex = 11
        Me.txtMail.Text = ""
        '
        'cboComuna
        '
        Me.cboComuna.Location = New System.Drawing.Point(128, 168)
        Me.cboComuna.Name = "cboComuna"
        Me.cboComuna.Size = New System.Drawing.Size(104, 21)
        Me.cboComuna.TabIndex = 12
        '
        'cmdAgregar
        '
        Me.cmdAgregar.ForeColor = System.Drawing.Color.Black
        Me.cmdAgregar.Location = New System.Drawing.Point(64, 240)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.TabIndex = 13
        Me.cmdAgregar.Text = "Agregar"
        '
        'cmdVolver
        '
        Me.cmdVolver.ForeColor = System.Drawing.Color.Black
        Me.cmdVolver.Location = New System.Drawing.Point(168, 240)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 14
        Me.cmdVolver.Text = "Volver"
        '
        'frmAgcli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 294)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cboComuna)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Name = "frmAgcli"
        Me.Text = " Agregar Clientes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAgcli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file As StreamReader = New StreamReader("c:\prueba\comunas.txt")
        Dim line As String
        line = File.ReadLine
        While line <> Nothing
            cboComuna.Items.Add(line)
            line = file.ReadLine
        End While
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Finalize()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim llama As New frmAgcli
        Dim file As StreamWriter = New StreamWriter("c:\prueba\clientes.txt", True)
        Dim line As String
        file.WriteLine(txtRut.Text & "/" & txtNom.Text & "/" & txtDir.Text & "/" & txtTel.Text & "/" & cboComuna.Text & "/" & txtMail.Text & "/")
        file.Close()
        MessageBox.Show("Los datos Fueron grabados", " Aviso")
        Me.Finalize()
        llama.Show()
    End Sub

    Private Sub txtRut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRut.TextChanged

    End Sub

    Private Sub cboComuna_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboComuna.SelectedIndexChanged

    End Sub
End Class
