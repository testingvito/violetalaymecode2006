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
    Friend WithEvents Txtingtexto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd3 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Txtingtexto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.cmd3 = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.SuspendLayout()
        '
        'Txtingtexto
        '
        Me.Txtingtexto.Location = New System.Drawing.Point(48, 48)
        Me.Txtingtexto.Name = "Txtingtexto"
        Me.Txtingtexto.Size = New System.Drawing.Size(256, 20)
        Me.Txtingtexto.TabIndex = 0
        Me.Txtingtexto.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INGRESE TEXTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(48, 112)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(112, 48)
        Me.cmd1.TabIndex = 2
        Me.cmd1.Text = "COLOR DE FUENTE"
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(48, 176)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(112, 48)
        Me.cmd2.TabIndex = 3
        Me.cmd2.Text = "COLOR DE FONDO"
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(200, 112)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(104, 80)
        Me.cmd3.TabIndex = 4
        Me.cmd3.Text = "CAMBIA FUENTE"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 325)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtingtexto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        ColorDialog1.ShowDialog()
        Txtingtexto.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        ColorDialog1.ShowDialog()
        Txtingtexto.BackColor = ColorDialog1.Color
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        FontDialog1.ShowDialog()
        Txtingtexto.Font = FontDialog1.Font

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
