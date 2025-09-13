Imports System.io
Public Class frmIngVenta
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
    Friend WithEvents lblNventa As System.Windows.Forms.Label
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRut_ As System.Windows.Forms.Label
    Friend WithEvents lblNom_ As System.Windows.Forms.Label
    Friend WithEvents lblFecha_ As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblFech As System.Windows.Forms.Label
    Friend WithEvents cboProd3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboProd1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboProd2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtSub3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSub2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSub1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPre3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPre1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCan3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCan2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCan1 As System.Windows.Forms.TextBox
    Friend WithEvents boxprod As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblNventa = New System.Windows.Forms.Label
        Me.lblRut_ = New System.Windows.Forms.Label
        Me.lblNom_ = New System.Windows.Forms.Label
        Me.lblFecha_ = New System.Windows.Forms.Label
        Me.boxprod = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSub3 = New System.Windows.Forms.TextBox
        Me.txtSub2 = New System.Windows.Forms.TextBox
        Me.txtSub1 = New System.Windows.Forms.TextBox
        Me.txtPre3 = New System.Windows.Forms.TextBox
        Me.txtPre2 = New System.Windows.Forms.TextBox
        Me.txtPre1 = New System.Windows.Forms.TextBox
        Me.txtCan3 = New System.Windows.Forms.TextBox
        Me.txtCan2 = New System.Windows.Forms.TextBox
        Me.txtCan1 = New System.Windows.Forms.TextBox
        Me.cboProd3 = New System.Windows.Forms.ComboBox
        Me.cboProd2 = New System.Windows.Forms.ComboBox
        Me.cboProd1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblnum = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.lblNom = New System.Windows.Forms.Label
        Me.lblFech = New System.Windows.Forms.Label
        Me.cmdGrabar = New System.Windows.Forms.Button
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.boxprod.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNventa
        '
        Me.lblNventa.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblNventa.Location = New System.Drawing.Point(16, 16)
        Me.lblNventa.Name = "lblNventa"
        Me.lblNventa.TabIndex = 0
        Me.lblNventa.Text = "Nº  Venta        :"
        Me.lblNventa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRut_
        '
        Me.lblRut_.Location = New System.Drawing.Point(16, 40)
        Me.lblRut_.Name = "lblRut_"
        Me.lblRut_.TabIndex = 1
        Me.lblRut_.Text = "Rut                  :"
        Me.lblRut_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNom_
        '
        Me.lblNom_.Location = New System.Drawing.Point(16, 64)
        Me.lblNom_.Name = "lblNom_"
        Me.lblNom_.TabIndex = 2
        Me.lblNom_.Text = "Nombre           :"
        Me.lblNom_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha_
        '
        Me.lblFecha_.Location = New System.Drawing.Point(16, 88)
        Me.lblFecha_.Name = "lblFecha_"
        Me.lblFecha_.TabIndex = 3
        Me.lblFecha_.Text = "Fecha             :"
        Me.lblFecha_.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'boxprod
        '
        Me.boxprod.Controls.Add(Me.txtTotal)
        Me.boxprod.Controls.Add(Me.Label5)
        Me.boxprod.Controls.Add(Me.txtSub3)
        Me.boxprod.Controls.Add(Me.txtSub2)
        Me.boxprod.Controls.Add(Me.txtSub1)
        Me.boxprod.Controls.Add(Me.txtPre3)
        Me.boxprod.Controls.Add(Me.txtPre2)
        Me.boxprod.Controls.Add(Me.txtPre1)
        Me.boxprod.Controls.Add(Me.txtCan3)
        Me.boxprod.Controls.Add(Me.txtCan2)
        Me.boxprod.Controls.Add(Me.txtCan1)
        Me.boxprod.Controls.Add(Me.cboProd3)
        Me.boxprod.Controls.Add(Me.cboProd2)
        Me.boxprod.Controls.Add(Me.cboProd1)
        Me.boxprod.Controls.Add(Me.Label4)
        Me.boxprod.Controls.Add(Me.Label3)
        Me.boxprod.Controls.Add(Me.Label2)
        Me.boxprod.Controls.Add(Me.Label1)
        Me.boxprod.Enabled = False
        Me.boxprod.Location = New System.Drawing.Point(8, 128)
        Me.boxprod.Name = "boxprod"
        Me.boxprod.Size = New System.Drawing.Size(416, 176)
        Me.boxprod.TabIndex = 4
        Me.boxprod.TabStop = False
        Me.boxprod.Text = " Productos"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(312, 120)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(88, 20)
        Me.txtTotal.TabIndex = 17
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(248, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total"
        '
        'txtSub3
        '
        Me.txtSub3.Location = New System.Drawing.Point(312, 96)
        Me.txtSub3.Name = "txtSub3"
        Me.txtSub3.Size = New System.Drawing.Size(88, 20)
        Me.txtSub3.TabIndex = 15
        Me.txtSub3.Text = ""
        Me.txtSub3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSub2
        '
        Me.txtSub2.Location = New System.Drawing.Point(312, 72)
        Me.txtSub2.Name = "txtSub2"
        Me.txtSub2.Size = New System.Drawing.Size(88, 20)
        Me.txtSub2.TabIndex = 14
        Me.txtSub2.Text = ""
        Me.txtSub2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSub1
        '
        Me.txtSub1.Location = New System.Drawing.Point(312, 48)
        Me.txtSub1.Name = "txtSub1"
        Me.txtSub1.Size = New System.Drawing.Size(88, 20)
        Me.txtSub1.TabIndex = 13
        Me.txtSub1.Text = ""
        Me.txtSub1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPre3
        '
        Me.txtPre3.Location = New System.Drawing.Point(224, 96)
        Me.txtPre3.Name = "txtPre3"
        Me.txtPre3.Size = New System.Drawing.Size(80, 20)
        Me.txtPre3.TabIndex = 12
        Me.txtPre3.Text = ""
        Me.txtPre3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPre2
        '
        Me.txtPre2.Location = New System.Drawing.Point(224, 72)
        Me.txtPre2.Name = "txtPre2"
        Me.txtPre2.Size = New System.Drawing.Size(80, 20)
        Me.txtPre2.TabIndex = 11
        Me.txtPre2.Text = ""
        Me.txtPre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPre1
        '
        Me.txtPre1.Location = New System.Drawing.Point(224, 48)
        Me.txtPre1.Name = "txtPre1"
        Me.txtPre1.Size = New System.Drawing.Size(80, 20)
        Me.txtPre1.TabIndex = 10
        Me.txtPre1.Text = ""
        Me.txtPre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCan3
        '
        Me.txtCan3.Location = New System.Drawing.Point(184, 96)
        Me.txtCan3.Name = "txtCan3"
        Me.txtCan3.Size = New System.Drawing.Size(32, 20)
        Me.txtCan3.TabIndex = 9
        Me.txtCan3.Text = ""
        Me.txtCan3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCan2
        '
        Me.txtCan2.Location = New System.Drawing.Point(184, 72)
        Me.txtCan2.Name = "txtCan2"
        Me.txtCan2.Size = New System.Drawing.Size(32, 20)
        Me.txtCan2.TabIndex = 8
        Me.txtCan2.Text = ""
        Me.txtCan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCan1
        '
        Me.txtCan1.Location = New System.Drawing.Point(184, 48)
        Me.txtCan1.Name = "txtCan1"
        Me.txtCan1.Size = New System.Drawing.Size(32, 20)
        Me.txtCan1.TabIndex = 7
        Me.txtCan1.Text = ""
        Me.txtCan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboProd3
        '
        Me.cboProd3.Location = New System.Drawing.Point(16, 96)
        Me.cboProd3.Name = "cboProd3"
        Me.cboProd3.Size = New System.Drawing.Size(160, 21)
        Me.cboProd3.TabIndex = 6
        '
        'cboProd2
        '
        Me.cboProd2.Location = New System.Drawing.Point(16, 72)
        Me.cboProd2.Name = "cboProd2"
        Me.cboProd2.Size = New System.Drawing.Size(160, 21)
        Me.cboProd2.TabIndex = 5
        '
        'cboProd1
        '
        Me.cboProd1.Location = New System.Drawing.Point(16, 48)
        Me.cboProd1.Name = "cboProd1"
        Me.cboProd1.Size = New System.Drawing.Size(160, 21)
        Me.cboProd1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cant."
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'lblnum
        '
        Me.lblnum.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblnum.Location = New System.Drawing.Point(104, 16)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(48, 23)
        Me.lblnum.TabIndex = 5
        Me.lblnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(104, 40)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(72, 20)
        Me.txtRut.TabIndex = 6
        Me.txtRut.Text = ""
        Me.txtRut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(288, 24)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 24)
        Me.cmdBuscar.TabIndex = 9
        Me.cmdBuscar.Text = "Buscar"
        '
        'lblNom
        '
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(104, 64)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(160, 23)
        Me.lblNom.TabIndex = 10
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFech
        '
        Me.lblFech.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblFech.Location = New System.Drawing.Point(104, 88)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(80, 23)
        Me.lblFech.TabIndex = 11
        Me.lblFech.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(288, 48)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.TabIndex = 12
        Me.cmdGrabar.Text = "Grabar"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(288, 72)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 13
        Me.cmdVolver.Text = "Volver"
        '
        'frmIngVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 318)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.lblFech)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.boxprod)
        Me.Controls.Add(Me.lblFecha_)
        Me.Controls.Add(Me.lblNom_)
        Me.Controls.Add(Me.lblRut_)
        Me.Controls.Add(Me.lblNventa)
        Me.Name = "frmIngVenta"
        Me.Text = " Ingresar Venta"
        Me.boxprod.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim file As StreamReader = New StreamReader("c:\prueba\clientes.txt")
        Dim line As String
        Dim i As Integer
        Dim x, z As String
        line = file.ReadLine
        While line <> Nothing
            i = 1
            Do
                x = Mid(line, i, 1)
                If x = "/" Then
                    Exit Do
                End If
                z = z & x
                i = i + 1
            Loop
            If z = txtRut.Text Then
                i = i + 1
                z = ""
                Do
                    x = Mid(line, i, 1)
                    If x = "/" Then
                        lblNom.Text = z
                        boxprod.Enabled = True
                        cmdBuscar.Enabled = False
                        txtRut.Enabled = False
                        cmdGrabar.Enabled = True
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                Exit While
            End If
            line = file.ReadLine
            z = ""
        End While


        '    Else
        '        MessageBox.Show("El Rut no existe")
        '        txtRut.Text = ""
        '        txtRut.Focus()
        '        Exit Sub
        '    End If
        '    line = file.ReadLine
        '    z = ""
        'End While
    End Sub

    Private Sub frmIngVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyDate As Date
        MyDate = Today
        lblFech.Text = MyDate

        Dim file As StreamReader = New StreamReader("c:\prueba\productos.txt")
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


            cboProd1.Items.Add(z)
            cboProd2.Items.Add(z)
            cboProd3.Items.Add(z)
            line = file.ReadLine
            z = ""
        End While

        Dim ar As StreamReader = New StreamReader("c:\prueba\ventas.txt")
        Dim li, li1 As String
        i = 1
        z = ""
        x = ""

        Do
            li = ar.ReadLine
            If li = Nothing Then
                Exit Do
            End If
            li1 = li
        Loop
        Do
            x = Mid(li1, i, 1)
            If x = "/" Then
                Exit Do
            End If
            z = z & x
            i = i + 1
        Loop
        lblnum.Text = Val(z) + 1
        ar.Close()


    End Sub

    Private Sub cboProd1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProd1.SelectedIndexChanged
        txtPre1.Text = precio(cboProd1.Text)
    End Sub
    Private Sub cboProd2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProd2.SelectedIndexChanged
        txtPre2.Text = precio(cboProd2.Text)
    End Sub
    Private Sub cboProd3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProd3.SelectedIndexChanged
        txtPre3.Text = precio(cboProd3.Text)
    End Sub
    Function precio(ByVal a As String) As String
        Dim file As StreamReader = New StreamReader("c:\prueba\productos.txt")
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
            If a = z Then
                z = ""
                Do
                    i = i + 1
                    x = Mid(line, i, 1)
                    If x = "/" Then
                        precio = z
                        Exit Function
                    End If
                    z = z & x
                Loop
            End If
            z = ""
            line = file.ReadLine
        End While

    End Function

    Private Sub txtCan1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCan1.TextChanged
        txtSub1.Text = Val(txtCan1.Text) * Val(txtPre1.Text)
        txtTotal.Text = Val(txtSub1.Text)
    End Sub

    Private Sub txtCan2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCan2.TextChanged
        txtSub2.Text = Val(txtCan2.Text) * Val(txtPre2.Text)
        txtTotal.Text = Val(txtSub1.Text) + Val(txtSub2.Text)
    End Sub

    Private Sub txtCan3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCan3.TextChanged
        txtSub3.Text = Val(txtCan3.Text) * Val(txtPre3.Text)
        txtTotal.Text = Val(txtSub1.Text) + Val(txtSub2.Text) + Val(txtSub3.Text)
    End Sub

    Private Sub cmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrabar.Click

        Dim bole As StreamWriter = New StreamWriter("c:\prueba\detventas.txt", True)
        Dim ar As StreamWriter = New StreamWriter("c:\prueba\ventas.txt", True)
        Dim num As String
        bole.WriteLine(lblnum.Text & "/" & txtRut.Text & "/" & lblNom.Text & "/" & lblFech.Text & "/" & cboProd1.Text & "/" & txtCan1.Text & "/" & txtPre1.Text & "/" & txtSub1.Text & "/" & cboProd2.Text & "/" & txtCan2.Text & "/" & txtPre2.Text & "/" & txtSub2.Text & "/" & cboProd3.Text & "/" & txtCan3.Text & "/" & txtPre3.Text & "/" & txtSub3.Text & "/" & txtTotal.Text & "/")
        ar.WriteLine(lblnum.Text & "/" & txtRut.Text & "/" & lblNom.Text & "/" & lblFech.Text & "/" & txtTotal.Text & "/")
        bole.Close()
        ar.Close()
        MessageBox.Show("Los datos Fueron grabados", " Aviso")
        Me.Finalize()
    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Finalize()
    End Sub
End Class
