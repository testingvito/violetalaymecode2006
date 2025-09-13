Public Class Form1
    Inherits System.Windows.Forms.Form
    Public brojo, bverde, bazul, bvioleta As Integer
    Public frojo, fverde, fazul, fvioleta As Integer

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HSB1 As System.Windows.Forms.HScrollBar
    Friend WithEvents HSB2 As System.Windows.Forms.HScrollBar
    Friend WithEvents HSB3 As System.Windows.Forms.HScrollBar
    Friend WithEvents Rdfondo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdtexto As System.Windows.Forms.RadioButton
    Friend WithEvents cmdsalir As System.Windows.Forms.Button
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents HSB4 As System.Windows.Forms.HScrollBar
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents optcolor As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Rdfondo = New System.Windows.Forms.RadioButton
        Me.Rdtexto = New System.Windows.Forms.RadioButton
        Me.Txt1 = New System.Windows.Forms.TextBox
        Me.cmdsalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt2 = New System.Windows.Forms.TextBox
        Me.HSB1 = New System.Windows.Forms.HScrollBar
        Me.HSB2 = New System.Windows.Forms.HScrollBar
        Me.HSB3 = New System.Windows.Forms.HScrollBar
        Me.HSB4 = New System.Windows.Forms.HScrollBar
        Me.Txt3 = New System.Windows.Forms.TextBox
        Me.Txt4 = New System.Windows.Forms.TextBox
        Me.Txt5 = New System.Windows.Forms.TextBox
        Me.optcolor = New System.Windows.Forms.GroupBox
        Me.optcolor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rdfondo
        '
        Me.Rdfondo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdfondo.Location = New System.Drawing.Point(16, 16)
        Me.Rdfondo.Name = "Rdfondo"
        Me.Rdfondo.Size = New System.Drawing.Size(88, 24)
        Me.Rdfondo.TabIndex = 0
        Me.Rdfondo.Text = "Fondo"
        '
        'Rdtexto
        '
        Me.Rdtexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdtexto.Location = New System.Drawing.Point(144, 16)
        Me.Rdtexto.Name = "Rdtexto"
        Me.Rdtexto.Size = New System.Drawing.Size(88, 24)
        Me.Rdtexto.TabIndex = 1
        Me.Rdtexto.Text = "Texto"
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(32, 24)
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(384, 80)
        Me.Txt1.TabIndex = 2
        Me.Txt1.Text = ""
        '
        'cmdsalir
        '
        Me.cmdsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsalir.Location = New System.Drawing.Point(304, 136)
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(104, 32)
        Me.cmdsalir.TabIndex = 3
        Me.cmdsalir.Text = "SALIR"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rojo"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Verde"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Azul"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Violeta"
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(360, 192)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(48, 20)
        Me.Txt2.TabIndex = 8
        Me.Txt2.Text = ""
        '
        'HSB1
        '
        Me.HSB1.LargeChange = 16
        Me.HSB1.Location = New System.Drawing.Point(96, 192)
        Me.HSB1.Maximum = 255
        Me.HSB1.Name = "HSB1"
        Me.HSB1.Size = New System.Drawing.Size(248, 24)
        Me.HSB1.TabIndex = 9
        '
        'HSB2
        '
        Me.HSB2.LargeChange = 16
        Me.HSB2.Location = New System.Drawing.Point(96, 224)
        Me.HSB2.Maximum = 255
        Me.HSB2.Name = "HSB2"
        Me.HSB2.Size = New System.Drawing.Size(248, 24)
        Me.HSB2.TabIndex = 10
        '
        'HSB3
        '
        Me.HSB3.LargeChange = 16
        Me.HSB3.Location = New System.Drawing.Point(96, 256)
        Me.HSB3.Maximum = 255
        Me.HSB3.Name = "HSB3"
        Me.HSB3.Size = New System.Drawing.Size(248, 24)
        Me.HSB3.TabIndex = 11
        '
        'HSB4
        '
        Me.HSB4.LargeChange = 16
        Me.HSB4.Location = New System.Drawing.Point(96, 288)
        Me.HSB4.Maximum = 255
        Me.HSB4.Name = "HSB4"
        Me.HSB4.Size = New System.Drawing.Size(248, 24)
        Me.HSB4.TabIndex = 12
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(360, 224)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(48, 20)
        Me.Txt3.TabIndex = 13
        Me.Txt3.Text = ""
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(360, 264)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(48, 20)
        Me.Txt4.TabIndex = 14
        Me.Txt4.Text = ""
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(360, 296)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(48, 20)
        Me.Txt5.TabIndex = 15
        Me.Txt5.Text = ""
        '
        'optcolor
        '
        Me.optcolor.Controls.Add(Me.Rdtexto)
        Me.optcolor.Controls.Add(Me.Rdfondo)
        Me.optcolor.Location = New System.Drawing.Point(32, 128)
        Me.optcolor.Name = "optcolor"
        Me.optcolor.Size = New System.Drawing.Size(256, 48)
        Me.optcolor.TabIndex = 16
        Me.optcolor.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 350)
        Me.Controls.Add(Me.optcolor)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.HSB4)
        Me.Controls.Add(Me.HSB3)
        Me.Controls.Add(Me.HSB2)
        Me.Controls.Add(Me.HSB1)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdsalir)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.optcolor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub HScrollBar4_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSB4.Scroll
        If rbfondo(0).value = True Then
            Txt1.BackColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        Else
            Txt1.ForeColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        End If
    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        brojo = 0
        bverde = 0
        bazul = 0
        bvioleta = 0
        frojo = 255
        fverde = 255
        fazul = 255
        fvioleta = 255
        Txt1.BackColor = RGB(BROJO, BVERDE, BAZUL, BVIOLETA)
        Txt1.ForeColor = RGB(frojo, fverde, fazul, fvioleta)

    End Sub

    Private Sub Rdfondo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdfondo.CheckedChanged

        frojo = HSB1(0).value



    End Sub

    Private Sub HSB1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSB1.Scroll
        
    End Sub

    Private Sub Rdtexto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdtexto.CheckedChanged

    End Sub

    Private Sub HSB2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSB2.Scroll
        If rbfondo(0).value = True Then
            Txt1.BackColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        Else
            Txt1.ForeColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        End If
    End Sub

    Private Sub HSB3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HSB3.Scroll
        If rbfondo(0).value = True Then
            Txt1.BackColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        Else
            Txt1.ForeColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        End If
    End Sub

    Private Sub HSB1_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles HSB1.ChangeUICues
        If rbfondo(0).value = True Then
            Txt1.BackColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        Else
            Txt1.ForeColor = RGB(HSB1(0).value, HSB2(1).value, HSB3(2).value, HSB4(3).value)
            Dim i As Integer
            For i = 0 To 2
                Txt1.Text = hsb(i).value
            Next
        End If
    End Sub

    Private Sub optcolor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optcolor.Enter

    End Sub

    Private Sub optcolor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optcolor.Click
        If index = 0 Then
            frojo = HSB1(0).value
            fverde = HSB2(1).value
            fazul = HSB2(3).value
            fvioleta = HSB3(4).value
            HSB1(0).value = brojo
            HSB2(1).value = bverde
            HSB3(2).value = bazul
            HSB4(3).value = bvioleta
        Else
            brojo = HSB1(0).value
            bverde = HSB2(1).value
            bazul = HSB2(3).value
            bvioleta = HSB3(4).value
            HSB1(0).value = frojo
            HSB2(1).value = fverde
            HSB3(2).value = fazul
            HSB4(3).value = fvioleta

        End If
    End Sub
End Class
