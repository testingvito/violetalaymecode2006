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
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents validaRut As System.Windows.Forms.Button
    Friend WithEvents digC As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.validaRut = New System.Windows.Forms.Button
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.digC = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'validaRut
        '
        Me.validaRut.Location = New System.Drawing.Point(88, 64)
        Me.validaRut.Name = "validaRut"
        Me.validaRut.Size = New System.Drawing.Size(88, 32)
        Me.validaRut.TabIndex = 0
        Me.validaRut.Text = "VALIDAR"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(88, 16)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(160, 20)
        Me.txtRut.TabIndex = 1
        Me.txtRut.Text = ""
        '
        'digC
        '
        Me.digC.Location = New System.Drawing.Point(8, 16)
        Me.digC.Name = "digC"
        Me.digC.Size = New System.Drawing.Size(72, 16)
        Me.digC.TabIndex = 2
        Me.digC.Text = "RUT"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 149)
        Me.Controls.Add(Me.digC)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.validaRut)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtRut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRut.TextChanged
        

    End Sub

    Private Sub validaRut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validaRut.Click
        Dim validarut As Boolean
        validarut = True
        validaRut = False
        If (validaRut(txtRut.Text)) = True Then
            txtRut.ForeColor = Color.Blue
        Else
            txtRut.ForeColor = Color.Red
        End If

        If (digC = digitRut) Then
            validaRut = True
        Else
            validaRut = False
        End If
    End Sub
End Class
