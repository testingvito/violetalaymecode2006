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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtcaja As System.Windows.Forms.TextBox
    Friend WithEvents Rdazul As System.Windows.Forms.RadioButton
    Friend WithEvents Rdrojo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdverde As System.Windows.Forms.RadioButton
    Friend WithEvents Rdamarillo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdvioleta As System.Windows.Forms.RadioButton
    Friend WithEvents Rdabajo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdarriba As System.Windows.Forms.RadioButton
    Friend WithEvents cmd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Txtcaja = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Rdamarillo = New System.Windows.Forms.RadioButton
        Me.Rdverde = New System.Windows.Forms.RadioButton
        Me.Rdrojo = New System.Windows.Forms.RadioButton
        Me.Rdazul = New System.Windows.Forms.RadioButton
        Me.Rdvioleta = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Rdabajo = New System.Windows.Forms.RadioButton
        Me.Rdarriba = New System.Windows.Forms.RadioButton
        Me.cmd = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtcaja
        '
        Me.Txtcaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcaja.Location = New System.Drawing.Point(232, 32)
        Me.Txtcaja.Multiline = True
        Me.Txtcaja.Name = "Txtcaja"
        Me.Txtcaja.Size = New System.Drawing.Size(168, 80)
        Me.Txtcaja.TabIndex = 0
        Me.Txtcaja.Text = ""
        Me.Txtcaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rdamarillo)
        Me.GroupBox1.Controls.Add(Me.Rdverde)
        Me.GroupBox1.Controls.Add(Me.Rdrojo)
        Me.GroupBox1.Controls.Add(Me.Rdazul)
        Me.GroupBox1.Controls.Add(Me.Rdvioleta)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "colores"
        '
        'Rdamarillo
        '
        Me.Rdamarillo.Location = New System.Drawing.Point(16, 112)
        Me.Rdamarillo.Name = "Rdamarillo"
        Me.Rdamarillo.Size = New System.Drawing.Size(112, 32)
        Me.Rdamarillo.TabIndex = 3
        Me.Rdamarillo.Text = "Amarillo"
        '
        'Rdverde
        '
        Me.Rdverde.Location = New System.Drawing.Point(16, 88)
        Me.Rdverde.Name = "Rdverde"
        Me.Rdverde.Size = New System.Drawing.Size(112, 32)
        Me.Rdverde.TabIndex = 2
        Me.Rdverde.Text = "Verde"
        '
        'Rdrojo
        '
        Me.Rdrojo.Location = New System.Drawing.Point(16, 56)
        Me.Rdrojo.Name = "Rdrojo"
        Me.Rdrojo.Size = New System.Drawing.Size(112, 32)
        Me.Rdrojo.TabIndex = 1
        Me.Rdrojo.Text = "Rojo"
        '
        'Rdazul
        '
        Me.Rdazul.Location = New System.Drawing.Point(16, 24)
        Me.Rdazul.Name = "Rdazul"
        Me.Rdazul.Size = New System.Drawing.Size(112, 32)
        Me.Rdazul.TabIndex = 0
        Me.Rdazul.Text = "Azul"
        '
        'Rdvioleta
        '
        Me.Rdvioleta.Location = New System.Drawing.Point(16, 144)
        Me.Rdvioleta.Name = "Rdvioleta"
        Me.Rdvioleta.Size = New System.Drawing.Size(112, 32)
        Me.Rdvioleta.TabIndex = 4
        Me.Rdvioleta.Text = "Violeta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rdabajo)
        Me.GroupBox2.Controls.Add(Me.Rdarriba)
        Me.GroupBox2.Controls.Add(Me.cmd)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 128)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "posiciones"
        '
        'Rdabajo
        '
        Me.Rdabajo.Location = New System.Drawing.Point(16, 56)
        Me.Rdabajo.Name = "Rdabajo"
        Me.Rdabajo.Size = New System.Drawing.Size(112, 32)
        Me.Rdabajo.TabIndex = 1
        Me.Rdabajo.Text = "Abajo"
        '
        'Rdarriba
        '
        Me.Rdarriba.Location = New System.Drawing.Point(16, 24)
        Me.Rdarriba.Name = "Rdarriba"
        Me.Rdarriba.Size = New System.Drawing.Size(112, 32)
        Me.Rdarriba.TabIndex = 0
        Me.Rdarriba.Text = "Arriba"
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Location = New System.Drawing.Point(8, 96)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(128, 24)
        Me.cmd.TabIndex = 6
        Me.cmd.Text = "presiona aqui"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 366)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txtcaja)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Txtcaja.Top = 100

    End Sub

    Private Sub Rdazul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdazul.CheckedChanged
        Txtcaja.BackColor = Txtcaja.BackColor.Blue
    End Sub

    Private Sub Rdrojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdrojo.CheckedChanged
        Txtcaja.BackColor = Txtcaja.BackColor.Red

    End Sub

    Private Sub Rdverde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdverde.CheckedChanged
        Txtcaja.BackColor = Txtcaja.BackColor.Green
    End Sub

    Private Sub Rdamarillo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdamarillo.CheckedChanged
        Txtcaja.BackColor = Txtcaja.BackColor.Yellow
    End Sub

    Private Sub Rdvioleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdvioleta.CheckedChanged
        Txtcaja.BackColor = Txtcaja.BackColor.Violet
    End Sub

    Private Sub Rdarriba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdarriba.CheckedChanged
        Txtcaja.Top = 50
    End Sub

    Private Sub Rdabajo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdabajo.CheckedChanged
        Txtcaja.Top = 200
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Txtcaja.Text = "VICTOR"
        Txtcaja.TextAlign = Txtcaja.TextAlign.Center

    End Sub

    Private Sub Txtcaja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcaja.TextChanged

    End Sub

    Private Sub cmd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd.DoubleClick
        MessageBox.Show("YA DEJA DE HACER CLICK", " Aviso")

    End Sub
End Class
