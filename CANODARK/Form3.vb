Public Class frmComparar
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
    Friend WithEvents lblN1 As System.Windows.Forms.Label
    Friend WithEvents lblN2 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdComparar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblN1 = New System.Windows.Forms.Label
        Me.lblN2 = New System.Windows.Forms.Label
        Me.txtN1 = New System.Windows.Forms.TextBox
        Me.txtN2 = New System.Windows.Forms.TextBox
        Me.cmdComparar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblN1
        '
        Me.lblN1.Location = New System.Drawing.Point(32, 32)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "Numero 1"
        '
        'lblN2
        '
        Me.lblN2.Location = New System.Drawing.Point(32, 80)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.TabIndex = 1
        Me.lblN2.Text = "Numero 2"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(160, 32)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.TabIndex = 2
        Me.txtN1.Text = ""
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(160, 80)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.TabIndex = 3
        Me.txtN2.Text = ""
        '
        'cmdComparar
        '
        Me.cmdComparar.Location = New System.Drawing.Point(176, 136)
        Me.cmdComparar.Name = "cmdComparar"
        Me.cmdComparar.TabIndex = 4
        Me.cmdComparar.Text = "Comparar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(176, 200)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.Text = "Salir"
        '
        'frmComparar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdComparar)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblN1)
        Me.Name = "frmComparar"
        Me.Text = "Comparar Mayor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdComparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComparar.Click
        
        If txtN1.Text > txtN2.Text Then
            MessageBox.Show("el valor mayor es:" & txtN1.Text)
        Else
            If txtN1.Text < txtN2.Text Then
                MessageBox.Show("el valor mayor es:" & txtN2.Text)
            Else
                MessageBox.Show("los valores son iguales")
            End If
        End If
        txtN1.Focus()
        txtN1.Text = ""
        txtN2.Focus()
        txtN2.Text = ""
    End Sub

    Private Sub txtN1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN1.TextChanged
        Dim numero1 As Integer
    End Sub

    Private Sub txtN2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN2.TextChanged
        Dim numero2 As Integer
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class
