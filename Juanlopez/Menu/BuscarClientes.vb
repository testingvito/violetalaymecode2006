Imports System.IO

Public Class frmBusCli
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
    Friend WithEvents lblRut_ As System.Windows.Forms.Label
    Friend WithEvents lblNom_ As System.Windows.Forms.Label
    Friend WithEvents lblDir_ As System.Windows.Forms.Label
    Friend WithEvents lblTel_ As System.Windows.Forms.Label
    Friend WithEvents lblCom_ As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents lblMail_ As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblCom As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblRut_ = New System.Windows.Forms.Label
        Me.lblNom_ = New System.Windows.Forms.Label
        Me.lblDir_ = New System.Windows.Forms.Label
        Me.lblTel_ = New System.Windows.Forms.Label
        Me.lblCom_ = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.lblMail_ = New System.Windows.Forms.Label
        Me.lblNom = New System.Windows.Forms.Label
        Me.lblDir = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.lblCom = New System.Windows.Forms.Label
        Me.lblMail = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdBuscar = New System.Windows.Forms.Button
        Me.cmdVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblRut_
        '
        Me.lblRut_.Location = New System.Drawing.Point(32, 64)
        Me.lblRut_.Name = "lblRut_"
        Me.lblRut_.TabIndex = 0
        Me.lblRut_.Text = "Rut                   :"
        '
        'lblNom_
        '
        Me.lblNom_.Location = New System.Drawing.Point(32, 88)
        Me.lblNom_.Name = "lblNom_"
        Me.lblNom_.TabIndex = 1
        Me.lblNom_.Text = "Nombre            :"
        '
        'lblDir_
        '
        Me.lblDir_.Location = New System.Drawing.Point(32, 112)
        Me.lblDir_.Name = "lblDir_"
        Me.lblDir_.TabIndex = 2
        Me.lblDir_.Text = "Direccion         :"
        '
        'lblTel_
        '
        Me.lblTel_.Location = New System.Drawing.Point(32, 136)
        Me.lblTel_.Name = "lblTel_"
        Me.lblTel_.TabIndex = 3
        Me.lblTel_.Text = "Telefono          :"
        '
        'lblCom_
        '
        Me.lblCom_.Location = New System.Drawing.Point(32, 160)
        Me.lblCom_.Name = "lblCom_"
        Me.lblCom_.TabIndex = 4
        Me.lblCom_.Text = "Comuna           :"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(120, 64)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(72, 20)
        Me.txtRut.TabIndex = 5
        Me.txtRut.Text = ""
        '
        'lblMail_
        '
        Me.lblMail_.Location = New System.Drawing.Point(32, 184)
        Me.lblMail_.Name = "lblMail_"
        Me.lblMail_.TabIndex = 6
        Me.lblMail_.Text = "E - Mail            :"
        '
        'lblNom
        '
        Me.lblNom.Location = New System.Drawing.Point(120, 88)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(144, 23)
        Me.lblNom.TabIndex = 7
        '
        'lblDir
        '
        Me.lblDir.Location = New System.Drawing.Point(120, 112)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(144, 23)
        Me.lblDir.TabIndex = 8
        '
        'lblTel
        '
        Me.lblTel.Location = New System.Drawing.Point(120, 136)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(72, 23)
        Me.lblTel.TabIndex = 9
        '
        'lblCom
        '
        Me.lblCom.Location = New System.Drawing.Point(120, 160)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(144, 23)
        Me.lblCom.TabIndex = 10
        '
        'lblMail
        '
        Me.lblMail.Location = New System.Drawing.Point(120, 184)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(176, 23)
        Me.lblMail.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Buscar Clientes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(64, 224)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.TabIndex = 14
        Me.cmdBuscar.Text = "Buscar"
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(168, 224)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.TabIndex = 15
        Me.cmdVolver.Text = "Volver"
        '
        'frmBusCli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 270)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblCom)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblMail_)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.lblCom_)
        Me.Controls.Add(Me.lblTel_)
        Me.Controls.Add(Me.lblDir_)
        Me.Controls.Add(Me.lblNom_)
        Me.Controls.Add(Me.lblRut_)
        Me.Name = "frmBusCli"
        Me.Text = " Buscar Clientes"
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
                i = i + 1
                z = ""
                Do
                    x = Mid(line, i, 1)
                    If x = "/" Then
                        lblCom.Text = z
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
                        lblMail.Text = z
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
