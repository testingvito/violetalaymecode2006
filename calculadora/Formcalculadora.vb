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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents N1 As System.Windows.Forms.Label
    Friend WithEvents N2 As System.Windows.Forms.Label
    Friend WithEvents N3 As System.Windows.Forms.Label
    Friend WithEvents TxtN1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtN2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtresp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.N1 = New System.Windows.Forms.Label
        Me.TxtN1 = New System.Windows.Forms.TextBox
        Me.TxtN2 = New System.Windows.Forms.TextBox
        Me.N2 = New System.Windows.Forms.Label
        Me.N3 = New System.Windows.Forms.Label
        Me.Txtresp = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(24, 16)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(96, 16)
        Me.N1.TabIndex = 0
        Me.N1.Text = "N1"
        '
        'TxtN1
        '
        Me.TxtN1.Location = New System.Drawing.Point(152, 16)
        Me.TxtN1.Name = "TxtN1"
        Me.TxtN1.Size = New System.Drawing.Size(128, 20)
        Me.TxtN1.TabIndex = 1
        Me.TxtN1.Text = ""
        '
        'TxtN2
        '
        Me.TxtN2.Location = New System.Drawing.Point(152, 64)
        Me.TxtN2.Name = "TxtN2"
        Me.TxtN2.Size = New System.Drawing.Size(128, 20)
        Me.TxtN2.TabIndex = 2
        Me.TxtN2.Text = ""
        '
        'N2
        '
        Me.N2.Location = New System.Drawing.Point(24, 64)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(96, 16)
        Me.N2.TabIndex = 3
        Me.N2.Text = "N2"
        '
        'N3
        '
        Me.N3.Location = New System.Drawing.Point(24, 120)
        Me.N3.Name = "N3"
        Me.N3.Size = New System.Drawing.Size(96, 16)
        Me.N3.TabIndex = 4
        Me.N3.Text = "N3"
        '
        'Txtresp
        '
        Me.Txtresp.Location = New System.Drawing.Point(152, 112)
        Me.Txtresp.Name = "Txtresp"
        Me.Txtresp.Size = New System.Drawing.Size(128, 20)
        Me.Txtresp.TabIndex = 5
        Me.Txtresp.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SUMA"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(424, 293)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtresp)
        Me.Controls.Add(Me.N3)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.TxtN2)
        Me.Controls.Add(Me.TxtN1)
        Me.Controls.Add(Me.N1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtN1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Txtresp.Text = Val(TxtN1.Text) + Val(TxtN2.Text)
        MessageBox.Show("el resultado es " & Txtresp.Text)


    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Txtresp.Text = Val(TxtN1.Text) + Val(TxtN2.Text)
        MessageBox.Show("el resultado es " & Txtresp.Text)
    End Sub
End Class
