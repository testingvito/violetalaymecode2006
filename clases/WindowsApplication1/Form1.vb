Public Class frmValida
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
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents cmdValida As System.Windows.Forms.Button
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtDig As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.cmdValida = New System.Windows.Forms.Button
        Me.lblRut = New System.Windows.Forms.Label
        Me.txtDig = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(64, 48)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(96, 20)
        Me.txtRut.TabIndex = 0
        Me.txtRut.Text = ""
        '
        'cmdValida
        '
        Me.cmdValida.Location = New System.Drawing.Point(112, 96)
        Me.cmdValida.Name = "cmdValida"
        Me.cmdValida.TabIndex = 1
        Me.cmdValida.Text = "Validar"
        '
        'lblRut
        '
        Me.lblRut.Location = New System.Drawing.Point(32, 48)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(32, 23)
        Me.lblRut.TabIndex = 2
        Me.lblRut.Text = "Rut"
        '
        'txtDig
        '
        Me.txtDig.Location = New System.Drawing.Point(168, 48)
        Me.txtDig.Name = "txtDig"
        Me.txtDig.Size = New System.Drawing.Size(24, 20)
        Me.txtDig.TabIndex = 3
        Me.txtDig.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        '
        'frmValida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(232, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDig)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.cmdValida)
        Me.Controls.Add(Me.txtRut)
        Me.Name = "frmValida"
        Me.Text = "Validacion De rut"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdValida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValida.Click
        Dim x As Integer
        Dim a As Integer
        Dim y As Integer
        Dim con As Integer
        Dim suma As Integer
        Dim c As Integer
        x = Val(txtRut.Text)
        con = Len(txtRut.Text)
        c = 2
        Do
            a = x Mod 10
            x = x / 10
            y = a * c
            suma = suma + y
            c = c + 1
            con = con - 1
        Loop Until (con = 0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim x, con As Integer
        x = Val(txtRut.Text)
        con = 8
        Do
            x = x / 10
            MessageBox.Show(x, "x")
            con -= 1
        Loop Until (con = 0)
    End Sub
End Class
