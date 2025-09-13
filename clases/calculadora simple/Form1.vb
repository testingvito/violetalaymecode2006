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
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdsuma As System.Windows.Forms.Button
    Friend WithEvents cmdresta As System.Windows.Forms.Button
    Friend WithEvents cmdmulti As System.Windows.Forms.Button
    Friend WithEvents cmddiv As System.Windows.Forms.Button
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtresultado As System.Windows.Forms.TextBox
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtresultado = New System.Windows.Forms.TextBox
        Me.cmdsuma = New System.Windows.Forms.Button
        Me.cmdresta = New System.Windows.Forms.Button
        Me.cmdmulti = New System.Windows.Forms.Button
        Me.cmddiv = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(24, 32)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(56, 48)
        Me.Txt1.TabIndex = 0
        Me.Txt1.Text = ""
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2.Location = New System.Drawing.Point(152, 32)
        Me.Txt2.Multiline = True
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(56, 48)
        Me.Txt2.TabIndex = 1
        Me.Txt2.Text = ""
        Me.Txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(104, 32)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(32, 40)
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtresultado
        '
        Me.Txtresultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtresultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtresultado.Location = New System.Drawing.Point(296, 32)
        Me.Txtresultado.Multiline = True
        Me.Txtresultado.Name = "Txtresultado"
        Me.Txtresultado.Size = New System.Drawing.Size(56, 48)
        Me.Txtresultado.TabIndex = 4
        Me.Txtresultado.Text = ""
        Me.Txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdsuma
        '
        Me.cmdsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsuma.Location = New System.Drawing.Point(16, 128)
        Me.cmdsuma.Name = "cmdsuma"
        Me.cmdsuma.Size = New System.Drawing.Size(72, 32)
        Me.cmdsuma.TabIndex = 5
        Me.cmdsuma.Text = "+"
        '
        'cmdresta
        '
        Me.cmdresta.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdresta.Location = New System.Drawing.Point(112, 128)
        Me.cmdresta.Name = "cmdresta"
        Me.cmdresta.Size = New System.Drawing.Size(72, 32)
        Me.cmdresta.TabIndex = 6
        Me.cmdresta.Text = "-"
        '
        'cmdmulti
        '
        Me.cmdmulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmulti.Location = New System.Drawing.Point(200, 128)
        Me.cmdmulti.Name = "cmdmulti"
        Me.cmdmulti.Size = New System.Drawing.Size(72, 32)
        Me.cmdmulti.TabIndex = 7
        Me.cmdmulti.Text = "*"
        Me.cmdmulti.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmddiv
        '
        Me.cmddiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddiv.Location = New System.Drawing.Point(296, 128)
        Me.cmddiv.Name = "cmddiv"
        Me.cmddiv.Size = New System.Drawing.Size(72, 32)
        Me.cmddiv.TabIndex = 8
        Me.cmddiv.Text = "/"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 222)
        Me.Controls.Add(Me.cmddiv)
        Me.Controls.Add(Me.cmdmulti)
        Me.Controls.Add(Me.cmdresta)
        Me.Controls.Add(Me.cmdsuma)
        Me.Controls.Add(Me.Txtresultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "calculadora"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdsuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsuma.Click
        Txtresultado.Text = Val(Txt1.Text) + Val(Txt2.Text)
        Lbl1.Text = "+"

    End Sub

    Private Sub cmdresta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdresta.Click
        Txtresultado.Text = Val(Txt1.Text) - Val(Txt2.Text)
        Lbl1.Text = "-"
    End Sub

    Private Sub cmdmulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmulti.Click
        Txtresultado.Text = Val(Txt1.Text) * Val(Txt2.Text)
        Lbl1.Text = "*"
    End Sub

    Private Sub cmddiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddiv.Click
        Txtresultado.Text = Val(Txt1.Text) / Val(Txt2.Text)
        Lbl1.Text = "/"
    End Sub
End Class
