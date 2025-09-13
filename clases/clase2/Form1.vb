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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(32, 24)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 24)
        Me.cmd1.TabIndex = 0
        Me.cmd1.Text = "GENERAR"
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(32, 112)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(88, 24)
        Me.cmd2.TabIndex = 1
        Me.cmd2.Text = "SUMAR"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(32, 64)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(152, 20)
        Me.Txt2.TabIndex = 2
        Me.Txt2.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Resultado"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(136, 24)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(48, 20)
        Me.Txt1.TabIndex = 4
        Me.Txt1.Text = ""
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(136, 152)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(48, 20)
        Me.Txt3.TabIndex = 5
        Me.Txt3.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 205)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Dim arr(Txt1.Text = 1) As Integer
        Dim i As Integer
        For i = 0 To Txt1.Text - 1
            arr(i) = (i + 1) * 2
            Txt1.Text = Txt1.Text & arr(i)
        Next
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        Dim arr() As Integer
        Dim i, r As Integer
        For i = 0 To Txt2.Text - 1
            r = r + arr(i)
        Next
        Txt2.Text = r
    End Sub
End Class
