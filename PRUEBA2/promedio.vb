Public Class Form2
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
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents Txt As System.Windows.Forms.TextBox
    Friend WithEvents cmd As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents Txt6 As System.Windows.Forms.TextBox
    Friend WithEvents Txt7 As System.Windows.Forms.TextBox
    Friend WithEvents Txt8 As System.Windows.Forms.TextBox
    Friend WithEvents Txt9 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl6 As System.Windows.Forms.Label
    Friend WithEvents Lbl7 As System.Windows.Forms.Label
    Friend WithEvents Lbl8 As System.Windows.Forms.Label
    Friend WithEvents Lbl9 As System.Windows.Forms.Label
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents Txt10 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.Lbl = New System.Windows.Forms.Label
        Me.Txt = New System.Windows.Forms.TextBox
        Me.cmd = New System.Windows.Forms.Button
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Lbl2 = New System.Windows.Forms.Label
        Me.Lbl3 = New System.Windows.Forms.Label
        Me.Lbl4 = New System.Windows.Forms.Label
        Me.Lbl5 = New System.Windows.Forms.Label
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Txt3 = New System.Windows.Forms.TextBox
        Me.Txt4 = New System.Windows.Forms.TextBox
        Me.Txt5 = New System.Windows.Forms.TextBox
        Me.Txt6 = New System.Windows.Forms.TextBox
        Me.Txt7 = New System.Windows.Forms.TextBox
        Me.Txt8 = New System.Windows.Forms.TextBox
        Me.Txt9 = New System.Windows.Forms.TextBox
        Me.Lbl6 = New System.Windows.Forms.Label
        Me.Lbl7 = New System.Windows.Forms.Label
        Me.Lbl8 = New System.Windows.Forms.Label
        Me.Lbl9 = New System.Windows.Forms.Label
        Me.cmd1 = New System.Windows.Forms.Button
        Me.Txt10 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Lbl
        '
        Me.Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Lbl.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl.Location = New System.Drawing.Point(8, 8)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(80, 24)
        Me.Lbl.TabIndex = 0
        Me.Lbl.Text = "Nombre"
        '
        'Txt
        '
        Me.Txt.Location = New System.Drawing.Point(80, 8)
        Me.Txt.Name = "Txt"
        Me.Txt.Size = New System.Drawing.Size(168, 20)
        Me.Txt.TabIndex = 1
        Me.Txt.Text = ""
        '
        'cmd
        '
        Me.cmd.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Location = New System.Drawing.Point(32, 216)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(88, 24)
        Me.cmd.TabIndex = 2
        Me.cmd.Text = "PROMEDIO"
        '
        'Lbl1
        '
        Me.Lbl1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl1.Location = New System.Drawing.Point(8, 40)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(40, 24)
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "N1"
        '
        'Lbl2
        '
        Me.Lbl2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl2.Location = New System.Drawing.Point(8, 72)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(40, 24)
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "N2"
        '
        'Lbl3
        '
        Me.Lbl3.BackColor = System.Drawing.Color.Transparent
        Me.Lbl3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl3.Location = New System.Drawing.Point(8, 104)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(40, 24)
        Me.Lbl3.TabIndex = 5
        Me.Lbl3.Text = "N3"
        '
        'Lbl4
        '
        Me.Lbl4.BackColor = System.Drawing.Color.Transparent
        Me.Lbl4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl4.Location = New System.Drawing.Point(8, 144)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(40, 24)
        Me.Lbl4.TabIndex = 6
        Me.Lbl4.Text = "N4"
        '
        'Lbl5
        '
        Me.Lbl5.BackColor = System.Drawing.Color.Transparent
        Me.Lbl5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl5.Location = New System.Drawing.Point(8, 176)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(72, 24)
        Me.Lbl5.TabIndex = 7
        Me.Lbl5.Text = "NOTA"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(80, 40)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(88, 20)
        Me.Txt1.TabIndex = 8
        Me.Txt1.Text = ""
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(80, 72)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(88, 20)
        Me.Txt2.TabIndex = 9
        Me.Txt2.Text = ""
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(80, 104)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(88, 20)
        Me.Txt3.TabIndex = 10
        Me.Txt3.Text = ""
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(80, 136)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(88, 20)
        Me.Txt4.TabIndex = 11
        Me.Txt4.Text = ""
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(80, 176)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(88, 20)
        Me.Txt5.TabIndex = 12
        Me.Txt5.Text = ""
        '
        'Txt6
        '
        Me.Txt6.Location = New System.Drawing.Point(240, 40)
        Me.Txt6.Name = "Txt6"
        Me.Txt6.Size = New System.Drawing.Size(40, 20)
        Me.Txt6.TabIndex = 13
        Me.Txt6.Text = ""
        '
        'Txt7
        '
        Me.Txt7.Location = New System.Drawing.Point(240, 72)
        Me.Txt7.Name = "Txt7"
        Me.Txt7.Size = New System.Drawing.Size(40, 20)
        Me.Txt7.TabIndex = 14
        Me.Txt7.Text = ""
        '
        'Txt8
        '
        Me.Txt8.Location = New System.Drawing.Point(240, 104)
        Me.Txt8.Name = "Txt8"
        Me.Txt8.Size = New System.Drawing.Size(40, 20)
        Me.Txt8.TabIndex = 15
        Me.Txt8.Text = ""
        '
        'Txt9
        '
        Me.Txt9.Location = New System.Drawing.Point(240, 136)
        Me.Txt9.Name = "Txt9"
        Me.Txt9.Size = New System.Drawing.Size(40, 20)
        Me.Txt9.TabIndex = 16
        Me.Txt9.Text = ""
        '
        'Lbl6
        '
        Me.Lbl6.BackColor = System.Drawing.Color.Transparent
        Me.Lbl6.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl6.Location = New System.Drawing.Point(304, 40)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(24, 24)
        Me.Lbl6.TabIndex = 18
        Me.Lbl6.Text = "%"
        '
        'Lbl7
        '
        Me.Lbl7.BackColor = System.Drawing.Color.Transparent
        Me.Lbl7.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl7.Location = New System.Drawing.Point(304, 72)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(24, 24)
        Me.Lbl7.TabIndex = 19
        Me.Lbl7.Text = "%"
        '
        'Lbl8
        '
        Me.Lbl8.BackColor = System.Drawing.Color.Transparent
        Me.Lbl8.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl8.Location = New System.Drawing.Point(304, 104)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(24, 24)
        Me.Lbl8.TabIndex = 20
        Me.Lbl8.Text = "%"
        '
        'Lbl9
        '
        Me.Lbl9.BackColor = System.Drawing.Color.Transparent
        Me.Lbl9.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lbl9.Location = New System.Drawing.Point(304, 136)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(24, 24)
        Me.Lbl9.TabIndex = 21
        Me.Lbl9.Text = "%"
        '
        'cmd1
        '
        Me.cmd1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd1.Location = New System.Drawing.Point(200, 216)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(88, 24)
        Me.cmd1.TabIndex = 23
        Me.cmd1.Text = "VOLVER"
        '
        'Txt10
        '
        Me.Txt10.Location = New System.Drawing.Point(240, 176)
        Me.Txt10.Name = "Txt10"
        Me.Txt10.Size = New System.Drawing.Size(40, 20)
        Me.Txt10.TabIndex = 24
        Me.Txt10.Text = ""
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(352, 269)
        Me.Controls.Add(Me.Txt10)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.Lbl9)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Txt9)
        Me.Controls.Add(Me.Txt8)
        Me.Controls.Add(Me.Txt7)
        Me.Controls.Add(Me.Txt6)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.Txt)
        Me.Controls.Add(Me.Lbl)
        Me.Name = "Form2"
        Me.Text = "PROMEDIO"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt1.TextChanged
        Dim N1 As Decimal
        While (N1 > 0 And N1 <= 7)
            N1 = Val(Txt1.Text)
        End While

    End Sub

    Private Sub Txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt2.TextChanged
        Dim N2 As Decimal
    End Sub

    Private Sub Txt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt3.TextChanged
        Dim N3 As Decimal
    End Sub

    Private Sub Txt4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt4.TextChanged
        Dim N4 As Decimal
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        Me.Close()
    End Sub

    Private Sub Txt6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt6.TextChanged
        Dim N5 As Integer
        While (N5 > 0 And N5 < 100)
            N5 = Txt6.Text
        End While
    End Sub

    Private Sub Txt7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt7.TextChanged
        Dim N6 As Integer
        While (N6 > 0 And N6 < 100)
            N6 = Txt7.Text
        End While
    End Sub

    Private Sub Txt8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt8.TextChanged
        Dim N7 As Integer
        While (N7 > 0 And N7 < 100)
            N7 = Txt8.Text
        End While

    End Sub

    Private Sub Txt9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt9.TextChanged
        Dim N8 As Integer
        If (N8 > 0 And N8 < 100) Then
            N8 = Txt9.Text
        End If
    End Sub

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd.Click
        Dim N1 As Decimal
        Dim N2 As Decimal
        Dim N3 As Decimal
        Dim N4 As Decimal
        Dim N5 As Decimal
        Dim N6 As Decimal
        Dim N7 As Decimal
        Dim N8 As Decimal
        Dim N9 As Decimal

        N1 = Val(Txt1.Text)
        N2 = Val(Txt2.Text)
        N3 = Val(Txt3.Text)
        N4 = Val(Txt4.Text)
        N5 = Val(Txt5.Text)
        N6 = Val(Txt6.Text)
        N7 = Val(Txt7.Text)
        N8 = Val(Txt8.Text)
        N9 = Val(Txt9.Text)

        While (Txt6.Text > 0 And Txt6.Text < 100)
            Txt10.Text = Val((N5 + N6 + N7 + N8) = "100")
            Txt5.Text = Val((N1 + N2 + N3 + N4) / 4)
        End While

    End Sub

    Private Sub Txt5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt5.TextChanged
        Dim X As Integer
        X = Txt5.Text
    End Sub

    Private Sub Txt10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt10.TextChanged
        Dim N9 As Integer
        Dim N5 As Integer
        Dim N6 As Integer
        Dim N7 As Integer
        Dim N8 As Integer

        N9 = Txt10.Text
        If (N9 > 0 And N9 >= 100) Then
            N9 = Val(N5 + N6 + N7 + N8 = 100)

        End If

    End Sub

    Private Sub Txt_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt.TabIndexChanged
        Dim nombre As String
        nombre = Txt.Text
    End Sub
End Class
