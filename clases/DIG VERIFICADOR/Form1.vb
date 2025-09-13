Public Class Frm1
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(64, 64)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(112, 20)
        Me.Txt1.TabIndex = 1
        Me.Txt1.Text = ""
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(192, 64)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(24, 20)
        Me.Txt2.TabIndex = 2
        Me.Txt2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ACEPTAR"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ingrese el Rut"
        '
        'Frm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 197)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm1"
        Me.Text = "DIG VERIFICADOR"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt1.TextChanged
        Dim X, resp As Integer
        X = 0
        While (X > 0 And X < 100)
            resp = resp + 1
            Txt2.Text = Txt1.Text + resp
        End While

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As Boolean
        m = True
        m = False
        If m = True Then
            MessageBox.Show("es verdadera")
        Else
            MessageBox.Show("es falso vuelva a ingresar")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2.TextChanged

    End Sub
End Class
