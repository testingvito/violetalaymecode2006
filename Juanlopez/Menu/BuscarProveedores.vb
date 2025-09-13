Imports System.io
Public Class frmBusProv
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
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents lblCod_ As System.Windows.Forms.Label
    Friend WithEvents lblNom_ As System.Windows.Forms.Label
    Friend WithEvents lblDir_ As System.Windows.Forms.Label
    Friend WithEvents lblTel_ As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCod_ = New System.Windows.Forms.Label
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.lblNom_ = New System.Windows.Forms.Label
        Me.lblDir_ = New System.Windows.Forms.Label
        Me.lblTel_ = New System.Windows.Forms.Label
        Me.lblNom = New System.Windows.Forms.Label
        Me.lblDir = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Proveedores"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCod_
        '
        Me.lblCod_.Location = New System.Drawing.Point(40, 64)
        Me.lblCod_.Name = "lblCod_"
        Me.lblCod_.Size = New System.Drawing.Size(104, 23)
        Me.lblCod_.TabIndex = 1
        Me.lblCod_.Text = "Cod. Proveedor     :"
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(144, 64)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(64, 20)
        Me.txtcod.TabIndex = 2
        Me.txtcod.Text = ""
        '
        'lblNom_
        '
        Me.lblNom_.Location = New System.Drawing.Point(40, 88)
        Me.lblNom_.Name = "lblNom_"
        Me.lblNom_.TabIndex = 3
        Me.lblNom_.Text = "Nombre                 :"
        '
        'lblDir_
        '
        Me.lblDir_.Location = New System.Drawing.Point(40, 112)
        Me.lblDir_.Name = "lblDir_"
        Me.lblDir_.TabIndex = 4
        Me.lblDir_.Text = "Direccion              :"
        '
        'lblTel_
        '
        Me.lblTel_.Location = New System.Drawing.Point(40, 136)
        Me.lblTel_.Name = "lblTel_"
        Me.lblTel_.TabIndex = 5
        Me.lblTel_.Text = "Telefono               :"
        '
        'lblNom
        '
        Me.lblNom.Location = New System.Drawing.Point(144, 88)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(136, 23)
        Me.lblNom.TabIndex = 6
        '
        'lblDir
        '
        Me.lblDir.Location = New System.Drawing.Point(144, 112)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(136, 23)
        Me.lblDir.TabIndex = 7
        '
        'lblTel
        '
        Me.lblTel.Location = New System.Drawing.Point(144, 136)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(64, 23)
        Me.lblTel.TabIndex = 8
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(64, 176)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.TabIndex = 9
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(160, 176)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 10
        Me.cmdVolver.Text = "Volver"
        '
        'frmBusProv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 230)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblTel_)
        Me.Controls.Add(Me.lblDir_)
        Me.Controls.Add(Me.lblNom_)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.lblCod_)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBusProv"
        Me.Text = " Buscar Proveedores"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

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
                    Exit Do
                End If
                z = z & x
                i = i + 1
            Loop

            If z = txtcod.Text Then
                i = i + 1
                z = ""
                Do
                    x = Mid(line, i, 1)
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
                    x = Mid(line, i, 1)
                    If x = "/" Then
                        lblDir.Text = z
                        Exit Do
                    End If
                    z = z & x
                    i = i + 1
                Loop
                i = i + 1
                z = ""
                Do
                    x = Mid(line, i, 1)
                    If x = "/" Then
                        lblTel.Text = z
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


    End Sub

    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Finalize()
    End Sub
End Class
