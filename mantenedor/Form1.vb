Imports System.Data.OleDb
Public Class Form1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdEliminar = New System.Windows.Forms.Button
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodCli = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(24, 208)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(88, 24)
        Me.cmdAgregar.TabIndex = 0
        Me.cmdAgregar.Text = "Agregar"
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(136, 208)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(88, 24)
        Me.cmdModificar.TabIndex = 1
        Me.cmdModificar.Text = "Modificar"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Location = New System.Drawing.Point(248, 208)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(88, 24)
        Me.cmdEliminar.TabIndex = 2
        Me.cmdEliminar.Text = "Eliminar"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(168, 64)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(128, 26)
        Me.txtNom.TabIndex = 3
        Me.txtNom.Text = ""
        '
        'txtDir
        '
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(168, 96)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(128, 26)
        Me.txtDir.TabIndex = 4
        Me.txtDir.Text = ""
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(168, 128)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(128, 26)
        Me.txtTel.TabIndex = 5
        Me.txtTel.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(360, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(104, 204)
        Me.ListBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Telefono"
        '
        'txtCodCli
        '
        Me.txtCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCli.Location = New System.Drawing.Point(168, 32)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(128, 26)
        Me.txtCodCli.TabIndex = 10
        Me.txtCodCli.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Codigo Cliente"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 358)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim cmd As Data.OleDb.OleDbCommand
        Dim Cnn As Data.OleDb.OleDbConnection
        Cnn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Clientes.mdb")
        Cnn.Open()
        cmd = New OleDb.OleDbCommand("AgregarCliente", Cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("parametroCodCli", txtCodCli.Text)
        cmd.Parameters.Add("parametroNom", txtNom.Text)
        cmd.Parameters.Add("parametroTel", txtTel.Text)
        cmd.Parameters.Add("parametroDir", txtDir.Text)
        cmd.ExecuteNonQuery()
        Cnn.Close()
        CargaClientes()
        Limpia()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim cmd As Data.OleDb.OleDbCommand
        Dim Cnn As Data.OleDb.OleDbConnection
        Dim cSql As String
        Cnn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Clientes.mdb")
        Cnn.Open()
        cSql = "UPDATE Clientes SET " & _
        "clientes.codcli = " & txtCodCli.Text & _
        ", Clientes.Nom ='" & txtNom.Text & _
        "', Clientes.Dir ='" & txtDir.Text & _
        "', Clientes.tel ='" & txtTel.Text & _
        "' WHERE Clientes.CodCli=" & Val(txtCodCli.Text)
        cmd = New OleDb.OleDbCommand(cSql, Cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        Cnn.Close()
        CargaClientes()
        Limpia()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim cmd As Data.OleDb.OleDbCommand
        Dim Cnn As Data.OleDb.OleDbConnection
        Dim csql As String
        Cnn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Clientes.mdb")
        Cnn.Open()
        csql = "DELETE(Clientes.Codcli)FROM(Clientes)WHERE Clientes.CodCli=" & txtCodCli.Text
        cmd = New OleDb.OleDbCommand(csql, Cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        Cnn.Close()
        CargaClientes()
        Limpia()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaClientes()
    End Sub
    Sub CargaClientes()
        ListBox1.Items.Clear()
        Dim cnn As OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i, n As Integer
        cnn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\clientes.mdb;")
        cmd = New OleDb.OleDbDataAdapter("SELECT * FROM Clientes order by codcli", cnn)
        dt = New DataTable
        cmd.Fill(dt)
        n = dt.Rows.Count
        If n = 0 Then
            Console.WriteLine("No hay registros.")
        Else
            For i = 0 To n - 1
                ListBox1.Items.Add(dt.Rows(i).Item("codcli"))
            Next
        End If
        cnn.Close()
    End Sub
    Sub Limpia()
        txtNom.Clear()
        txtCodCli.Clear()
        txtDir.Clear()
        txtTel.Clear()
    End Sub



    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim cmd As New OleDbCommand
        Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\clientes.mdb;")
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Clientes where CodCli= " & ListBox1.SelectedItem
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            txtCodCli.Text = dr.GetValue(0)
            txtNom.Text = dr.GetString(1)
            txtDir.Text = dr.GetString(2)
            txtTel.Text = dr.GetString(3)
        End While
        dr.Close()
        cnn.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
