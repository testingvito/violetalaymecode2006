Public Class frmTrasformar
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
    Friend WithEvents lblPalabras As System.Windows.Forms.Label
    Friend WithEvents txtPalabras As System.Windows.Forms.TextBox
    Friend WithEvents cmdMayusculas As System.Windows.Forms.Button
    Friend WithEvents cmdMinusculas As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdNueva As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPalabras = New System.Windows.Forms.Label
        Me.txtPalabras = New System.Windows.Forms.TextBox
        Me.cmdMayusculas = New System.Windows.Forms.Button
        Me.cmdMinusculas = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdNueva = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblPalabras
        '
        Me.lblPalabras.Location = New System.Drawing.Point(16, 16)
        Me.lblPalabras.Name = "lblPalabras"
        Me.lblPalabras.TabIndex = 0
        Me.lblPalabras.Text = "Palabras"
        '
        'txtPalabras
        '
        Me.txtPalabras.Location = New System.Drawing.Point(120, 16)
        Me.txtPalabras.Name = "txtPalabras"
        Me.txtPalabras.Size = New System.Drawing.Size(336, 20)
        Me.txtPalabras.TabIndex = 1
        Me.txtPalabras.Text = ""
        '
        'cmdMayusculas
        '
        Me.cmdMayusculas.Location = New System.Drawing.Point(128, 96)
        Me.cmdMayusculas.Name = "cmdMayusculas"
        Me.cmdMayusculas.Size = New System.Drawing.Size(112, 23)
        Me.cmdMayusculas.TabIndex = 2
        Me.cmdMayusculas.Text = "A mayusculas"
        '
        'cmdMinusculas
        '
        Me.cmdMinusculas.Location = New System.Drawing.Point(296, 96)
        Me.cmdMinusculas.Name = "cmdMinusculas"
        Me.cmdMinusculas.Size = New System.Drawing.Size(128, 23)
        Me.cmdMinusculas.TabIndex = 3
        Me.cmdMinusculas.Text = "A Minusculas"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(8, 152)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        '
        'cmdNueva
        '
        Me.cmdNueva.Location = New System.Drawing.Point(296, 152)
        Me.cmdNueva.Name = "cmdNueva"
        Me.cmdNueva.Size = New System.Drawing.Size(128, 24)
        Me.cmdNueva.TabIndex = 5
        Me.cmdNueva.Text = "Nueva Palabra"
        '
        'frmTrasformar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 197)
        Me.Controls.Add(Me.cmdNueva)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdMinusculas)
        Me.Controls.Add(Me.cmdMayusculas)
        Me.Controls.Add(Me.txtPalabras)
        Me.Controls.Add(Me.lblPalabras)
        Me.Name = "frmTrasformar"
        Me.Text = "Trasformar"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdMayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMayusculas.Click
        txtPalabras.Text = UCase(txtPalabras.Text)
    End Sub

    Private Sub cmdMinusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMinusculas.Click
        txtPalabras.Text = LCase(txtPalabras.Text)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNueva.Click
        txtPalabras.Focus()
        txtPalabras.Text = ""
    End Sub
End Class
