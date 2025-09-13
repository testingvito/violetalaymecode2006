Public Class calc
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
    Friend WithEvents N1 As System.Windows.Forms.TextBox
    Friend WithEvents division As System.Windows.Forms.Button
    Friend WithEvents multi As System.Windows.Forms.Button
    Friend WithEvents igual As System.Windows.Forms.Button
    Friend WithEvents resta As System.Windows.Forms.Button
    Friend WithEvents suma As System.Windows.Forms.Button
    Friend WithEvents x8 As System.Windows.Forms.Button
    Friend WithEvents x9 As System.Windows.Forms.Button
    Friend WithEvents x10 As System.Windows.Forms.Button
    Friend WithEvents x5 As System.Windows.Forms.Button
    Friend WithEvents x6 As System.Windows.Forms.Button
    Friend WithEvents x7 As System.Windows.Forms.Button
    Friend WithEvents x2 As System.Windows.Forms.Button
    Friend WithEvents x3 As System.Windows.Forms.Button
    Friend WithEvents x4 As System.Windows.Forms.Button
    Friend WithEvents x1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.N1 = New System.Windows.Forms.TextBox
        Me.x8 = New System.Windows.Forms.Button
        Me.x9 = New System.Windows.Forms.Button
        Me.x10 = New System.Windows.Forms.Button
        Me.division = New System.Windows.Forms.Button
        Me.x5 = New System.Windows.Forms.Button
        Me.x6 = New System.Windows.Forms.Button
        Me.x7 = New System.Windows.Forms.Button
        Me.multi = New System.Windows.Forms.Button
        Me.x2 = New System.Windows.Forms.Button
        Me.x3 = New System.Windows.Forms.Button
        Me.x4 = New System.Windows.Forms.Button
        Me.resta = New System.Windows.Forms.Button
        Me.x1 = New System.Windows.Forms.Button
        Me.igual = New System.Windows.Forms.Button
        Me.suma = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(32, 24)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(224, 20)
        Me.N1.TabIndex = 0
        Me.N1.Text = ""
        Me.N1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'x8
        '
        Me.x8.Location = New System.Drawing.Point(24, 64)
        Me.x8.Name = "x8"
        Me.x8.Size = New System.Drawing.Size(48, 32)
        Me.x8.TabIndex = 1
        Me.x8.Text = "7"
        '
        'x9
        '
        Me.x9.Location = New System.Drawing.Point(88, 64)
        Me.x9.Name = "x9"
        Me.x9.Size = New System.Drawing.Size(48, 32)
        Me.x9.TabIndex = 2
        Me.x9.Text = "8"
        '
        'x10
        '
        Me.x10.Location = New System.Drawing.Point(152, 64)
        Me.x10.Name = "x10"
        Me.x10.Size = New System.Drawing.Size(48, 32)
        Me.x10.TabIndex = 3
        Me.x10.Text = "9"
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(216, 64)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(48, 32)
        Me.division.TabIndex = 4
        Me.division.Text = "/"
        '
        'x5
        '
        Me.x5.Location = New System.Drawing.Point(24, 120)
        Me.x5.Name = "x5"
        Me.x5.Size = New System.Drawing.Size(48, 32)
        Me.x5.TabIndex = 5
        Me.x5.Text = "4"
        '
        'x6
        '
        Me.x6.Location = New System.Drawing.Point(88, 120)
        Me.x6.Name = "x6"
        Me.x6.Size = New System.Drawing.Size(48, 32)
        Me.x6.TabIndex = 6
        Me.x6.Text = "5"
        '
        'x7
        '
        Me.x7.Location = New System.Drawing.Point(152, 120)
        Me.x7.Name = "x7"
        Me.x7.Size = New System.Drawing.Size(48, 32)
        Me.x7.TabIndex = 7
        Me.x7.Text = "6"
        '
        'multi
        '
        Me.multi.Location = New System.Drawing.Point(216, 120)
        Me.multi.Name = "multi"
        Me.multi.Size = New System.Drawing.Size(48, 32)
        Me.multi.TabIndex = 8
        Me.multi.Text = "*"
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(24, 176)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(48, 32)
        Me.x2.TabIndex = 9
        Me.x2.Text = "1"
        '
        'x3
        '
        Me.x3.Location = New System.Drawing.Point(88, 176)
        Me.x3.Name = "x3"
        Me.x3.Size = New System.Drawing.Size(48, 32)
        Me.x3.TabIndex = 10
        Me.x3.Text = "2"
        '
        'x4
        '
        Me.x4.Location = New System.Drawing.Point(152, 176)
        Me.x4.Name = "x4"
        Me.x4.Size = New System.Drawing.Size(48, 32)
        Me.x4.TabIndex = 11
        Me.x4.Text = "3"
        '
        'resta
        '
        Me.resta.Location = New System.Drawing.Point(216, 176)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(48, 32)
        Me.resta.TabIndex = 12
        Me.resta.Text = "-"
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(24, 224)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(48, 32)
        Me.x1.TabIndex = 13
        Me.x1.Text = "0"
        '
        'igual
        '
        Me.igual.Location = New System.Drawing.Point(88, 224)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(112, 32)
        Me.igual.TabIndex = 14
        Me.igual.Text = "="
        '
        'suma
        '
        Me.suma.Location = New System.Drawing.Point(216, 224)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(48, 32)
        Me.suma.TabIndex = 15
        Me.suma.Text = "+"
        '
        'calc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.x4)
        Me.Controls.Add(Me.x3)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.multi)
        Me.Controls.Add(Me.x7)
        Me.Controls.Add(Me.x6)
        Me.Controls.Add(Me.x5)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.x10)
        Me.Controls.Add(Me.x9)
        Me.Controls.Add(Me.x8)
        Me.Controls.Add(Me.N1)
        Me.Name = "calc"
        Me.Text = "calc"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x2.Click
        Dim x As Integer
        N1.Text = 1
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x3.Click
        Dim z As Integer
        N1.Text = 2
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resta.Click

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x4.Click
        Dim x As Integer
        N1.Text = 3
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x5.Click
        Dim x As Integer
        N1.Text = 4
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x6.Click
        Dim x As Integer
        N1.Text = 5
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x7.Click
        Dim x As Integer
        N1.Text = 6
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x8.Click
        Dim x As Integer
        N1.Text = 7

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x9.Click
        Dim x As Integer
        N1.Text = 8
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x10.Click
        Dim x As Integer
        N1.Text = 9
    End Sub

    Private Sub igual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles igual.Click
        Dim igual As Integer
        N1.Text = igual
    End Sub

    Private Sub division_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles division.Click
        Dim t As Integer
    End Sub

    Private Sub x1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x1.Click
        Dim x As Integer
        N1.Text = 0
    End Sub

    Private Sub N1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.TextChanged

    End Sub
End Class
