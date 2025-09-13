Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim INICIO As DateTime

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbltiempo As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Lbl2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl3 = New System.Windows.Forms.Label
        Me.cmd1 = New System.Windows.Forms.Button
        Me.cmd2 = New System.Windows.Forms.Button
        Me.Lbl4 = New System.Windows.Forms.Label
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Lbltiempo = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.Location = New System.Drawing.Point(40, 16)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(120, 16)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "EQUIPO LOCAL"
        '
        'Lbl2
        '
        Me.Lbl2.Location = New System.Drawing.Point(40, 72)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(120, 16)
        Me.Lbl2.TabIndex = 1
        Me.Lbl2.Text = "EQUIPO VISITA"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"CATOLICA", "COLO COLO", "U DE CHILE", "OTROS"})
        Me.ComboBox1.Location = New System.Drawing.Point(32, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"COBRELOA", "OTROS", "ETC"})
        Me.ComboBox2.Location = New System.Drawing.Point(32, 96)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Timer1
        '
        '
        'Lbl3
        '
        Me.Lbl3.Location = New System.Drawing.Point(296, 16)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(56, 24)
        Me.Lbl3.TabIndex = 4
        Me.Lbl3.Text = "TIEMPO"
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(32, 80)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(112, 24)
        Me.cmd1.TabIndex = 5
        Me.cmd1.Text = "GOL"
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(32, 120)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(112, 24)
        Me.cmd2.TabIndex = 6
        Me.cmd2.Text = "T. AMARILLA"
        '
        'Lbl4
        '
        Me.Lbl4.Location = New System.Drawing.Point(192, 16)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(48, 16)
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = "GOLES"
        Me.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(192, 40)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(48, 20)
        Me.Txt1.TabIndex = 9
        Me.Txt1.Text = ""
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(192, 96)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(48, 20)
        Me.Txt2.TabIndex = 10
        Me.Txt2.Text = ""
        '
        'Lbltiempo
        '
        Me.Lbltiempo.Location = New System.Drawing.Point(296, 48)
        Me.Lbltiempo.Name = "Lbltiempo"
        Me.Lbltiempo.Size = New System.Drawing.Size(64, 24)
        Me.Lbltiempo.TabIndex = 11
        Me.Lbltiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(440, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(112, 264)
        Me.ListBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(440, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "HISTORIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.cmd1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 184)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOCAL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "T.ROJA"
        '
        'ComboBox3
        '
        Me.ComboBox3.Items.AddRange(New Object() {"COBRELOA", "OTROS", "ETC"})
        Me.ComboBox3.Location = New System.Drawing.Point(16, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "jugador"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 184)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VISITA"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "T. AMARILLA"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 24)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "T.ROJA"
        '
        'ComboBox4
        '
        Me.ComboBox4.Items.AddRange(New Object() {"COBRELOA", "OTROS", "ETC"})
        Me.ComboBox4.Location = New System.Drawing.Point(16, 40)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox4.TabIndex = 15
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 24)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "GOL"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "jugador"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 349)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Lbltiempo)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "FUTBOL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lbl4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl4.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SEG, MIN As Integer
        SEG = DateDiff(DateInterval.Second, INICIO, DateTime.Now)
        MIN = SEG \ 60
        Lbltiempo.Text = Format(MIN, "00") & ":" & Format(SEG, "00")
    End Sub

    Private Sub Txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt1.TextChanged
        Dim txt1 As Integer
    End Sub

    Private Sub Txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2.TextChanged
        Dim txt2 As Integer
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim jugador As Char


    End Sub
End Class
