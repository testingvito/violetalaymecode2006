Imports System.io
Public Class frmBusVentas
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblprod1 As System.Windows.Forms.Label
    Friend WithEvents lblPre1 As System.Windows.Forms.Label
    Friend WithEvents lblCant1 As System.Windows.Forms.Label
    Friend WithEvents lblStock1 As System.Windows.Forms.Label
    Friend WithEvents lblProd2 As System.Windows.Forms.Label
    Friend WithEvents lblPre2 As System.Windows.Forms.Label
    Friend WithEvents lblCant2 As System.Windows.Forms.Label
    Friend WithEvents lblStock2 As System.Windows.Forms.Label
    Friend WithEvents lblProd3 As System.Windows.Forms.Label
    Friend WithEvents lblPre3 As System.Windows.Forms.Label
    Friend WithEvents lblCant3 As System.Windows.Forms.Label
    Friend WithEvents lblStock3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.lblRut = New System.Windows.Forms.Label
        Me.lblNom = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblprod1 = New System.Windows.Forms.Label
        Me.lblPre1 = New System.Windows.Forms.Label
        Me.lblCant1 = New System.Windows.Forms.Label
        Me.lblStock1 = New System.Windows.Forms.Label
        Me.lblProd2 = New System.Windows.Forms.Label
        Me.lblPre2 = New System.Windows.Forms.Label
        Me.lblCant2 = New System.Windows.Forms.Label
        Me.lblStock2 = New System.Windows.Forms.Label
        Me.lblProd3 = New System.Windows.Forms.Label
        Me.lblPre3 = New System.Windows.Forms.Label
        Me.lblCant3 = New System.Windows.Forms.Label
        Me.lblStock3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Boleta"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(88, 32)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(64, 20)
        Me.txtNum.TabIndex = 1
        Me.txtNum.Text = ""
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(232, 32)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(48, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStock3)
        Me.GroupBox1.Controls.Add(Me.lblCant3)
        Me.GroupBox1.Controls.Add(Me.lblPre3)
        Me.GroupBox1.Controls.Add(Me.lblProd3)
        Me.GroupBox1.Controls.Add(Me.lblStock2)
        Me.GroupBox1.Controls.Add(Me.lblCant2)
        Me.GroupBox1.Controls.Add(Me.lblPre2)
        Me.GroupBox1.Controls.Add(Me.lblProd2)
        Me.GroupBox1.Controls.Add(Me.lblStock1)
        Me.GroupBox1.Controls.Add(Me.lblCant1)
        Me.GroupBox1.Controls.Add(Me.lblPre1)
        Me.GroupBox1.Controls.Add(Me.lblprod1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 128)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Productos"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(264, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 23)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cant."
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(160, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Productos"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(232, 64)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 12
        Me.cmdVolver.Text = "Volver"
        '
        'lblRut
        '
        Me.lblRut.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(112, 72)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.TabIndex = 13
        '
        'lblNom
        '
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(112, 96)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.TabIndex = 14
        '
        'lblFecha
        '
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(112, 120)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.TabIndex = 15
        '
        'lblTotal
        '
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(112, 144)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.TabIndex = 16
        '
        'lblprod1
        '
        Me.lblprod1.Location = New System.Drawing.Point(16, 48)
        Me.lblprod1.Name = "lblprod1"
        Me.lblprod1.Size = New System.Drawing.Size(128, 23)
        Me.lblprod1.TabIndex = 4
        '
        'lblPre1
        '
        Me.lblPre1.Location = New System.Drawing.Point(160, 48)
        Me.lblPre1.Name = "lblPre1"
        Me.lblPre1.Size = New System.Drawing.Size(40, 23)
        Me.lblPre1.TabIndex = 5
        '
        'lblCant1
        '
        Me.lblCant1.Location = New System.Drawing.Point(216, 48)
        Me.lblCant1.Name = "lblCant1"
        Me.lblCant1.Size = New System.Drawing.Size(32, 23)
        Me.lblCant1.TabIndex = 6
        '
        'lblStock1
        '
        Me.lblStock1.Location = New System.Drawing.Point(264, 48)
        Me.lblStock1.Name = "lblStock1"
        Me.lblStock1.Size = New System.Drawing.Size(40, 23)
        Me.lblStock1.TabIndex = 7
        '
        'lblProd2
        '
        Me.lblProd2.Location = New System.Drawing.Point(16, 72)
        Me.lblProd2.Name = "lblProd2"
        Me.lblProd2.Size = New System.Drawing.Size(128, 23)
        Me.lblProd2.TabIndex = 8
        '
        'lblPre2
        '
        Me.lblPre2.Location = New System.Drawing.Point(160, 72)
        Me.lblPre2.Name = "lblPre2"
        Me.lblPre2.Size = New System.Drawing.Size(40, 23)
        Me.lblPre2.TabIndex = 9
        '
        'lblCant2
        '
        Me.lblCant2.Location = New System.Drawing.Point(216, 72)
        Me.lblCant2.Name = "lblCant2"
        Me.lblCant2.Size = New System.Drawing.Size(32, 23)
        Me.lblCant2.TabIndex = 10
        '
        'lblStock2
        '
        Me.lblStock2.Location = New System.Drawing.Point(264, 72)
        Me.lblStock2.Name = "lblStock2"
        Me.lblStock2.Size = New System.Drawing.Size(40, 23)
        Me.lblStock2.TabIndex = 11
        '
        'lblProd3
        '
        Me.lblProd3.Location = New System.Drawing.Point(16, 96)
        Me.lblProd3.Name = "lblProd3"
        Me.lblProd3.Size = New System.Drawing.Size(128, 23)
        Me.lblProd3.TabIndex = 12
        '
        'lblPre3
        '
        Me.lblPre3.Location = New System.Drawing.Point(160, 96)
        Me.lblPre3.Name = "lblPre3"
        Me.lblPre3.Size = New System.Drawing.Size(40, 23)
        Me.lblPre3.TabIndex = 13
        '
        'lblCant3
        '
        Me.lblCant3.Location = New System.Drawing.Point(216, 96)
        Me.lblCant3.Name = "lblCant3"
        Me.lblCant3.Size = New System.Drawing.Size(32, 23)
        Me.lblCant3.TabIndex = 14
        '
        'lblStock3
        '
        Me.lblStock3.Location = New System.Drawing.Point(264, 96)
        Me.lblStock3.Name = "lblStock3"
        Me.lblStock3.Size = New System.Drawing.Size(40, 23)
        Me.lblStock3.TabIndex = 15
        '
        'frmBusVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 302)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBusVentas"
        Me.Text = " Buscar Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim i, j, largo As Integer
        Dim ar As StreamReader = New StreamReader("c:\prueba\detventas.txt")
        Dim li, z, x As String
        i = 1
        z = ""
        x = ""
        li = ar.ReadLine

        While li <> Nothing
            largo = Len(li)
            i = 1
            Do
                x = Mid(li, i, 1)
                If x = "/" Then
                    Exit Do
                End If
                z = z & x
                i = i + 1
            Loop
            If z = txtNum.Text Then
                i = i + 1
                MessageBox.Show(z, "dentro del if osea lo encontro")
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblRut.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblNom.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblFecha.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblprod1.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblCant1.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblPre1.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblProd2.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblCant2.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblPre2.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblProd3.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblCant3.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(li, i, 1)
                    If x = "/" Then
                        lblPre3.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop

                largo = largo - 1
                z = ""
                Do
                    x = Mid(li, largo, 1)
                    If x = "/" Then
                        lblTotal.Text = z
                        Exit Do
                    End If
                    z = x & z
                    largo = largo - 1
                Loop
                Exit Sub
            End If
            li = ar.ReadLine
            z = ""
        End While
    End Sub
End Class