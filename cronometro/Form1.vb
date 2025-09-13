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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbltiempo As System.Windows.Forms.Label
    Friend WithEvents cmdiniciar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbltiempo = New System.Windows.Forms.Label
        Me.cmdiniciar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Lbltiempo
        '
        Me.Lbltiempo.Location = New System.Drawing.Point(40, 32)
        Me.Lbltiempo.Name = "Lbltiempo"
        Me.Lbltiempo.Size = New System.Drawing.Size(80, 32)
        Me.Lbltiempo.TabIndex = 0
        Me.Lbltiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdiniciar
        '
        Me.cmdiniciar.Location = New System.Drawing.Point(40, 88)
        Me.cmdiniciar.Name = "cmdiniciar"
        Me.cmdiniciar.Size = New System.Drawing.Size(80, 32)
        Me.cmdiniciar.TabIndex = 1
        Me.cmdiniciar.Text = "INICIAR"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(168, 157)
        Me.Controls.Add(Me.cmdiniciar)
        Me.Controls.Add(Me.Lbltiempo)
        Me.Name = "Form1"
        Me.Text = "TIMER"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim SEG, MIN As Integer
        SEG = DateDiff(DateInterval.Second, INICIO, DateTime.Now)
        MIN = SEG \ 60
        Lbltiempo.Text = Format(MIN, "00") & ":" & Format(SEG, "00")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdiniciar.Click
        If Timer1.Enabled = False Then
            cmdiniciar.Text = "PARAR"
            Timer1.Enabled = True
            INICIO = DateTime.Now
        Else
            Timer1.Enabled = False
            cmdiniciar.Text = "INICIAR"
        End If
    End Sub

    Private Sub Lbltiempo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbltiempo.Click

    End Sub
End Class
