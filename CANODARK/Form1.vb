Public Class frmPrincipal
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblContrase�a As System.Windows.Forms.Label
    Friend WithEvents cmdValidar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtContrase�a As System.Windows.Forms.TextBox
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblContrase�a = New System.Windows.Forms.Label
        Me.cmdValidar = New System.Windows.Forms.Button
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtContrase�a = New System.Windows.Forms.TextBox
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(24, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblContrase�a
        '
        Me.lblContrase�a.Location = New System.Drawing.Point(24, 88)
        Me.lblContrase�a.Name = "lblContrase�a"
        Me.lblContrase�a.TabIndex = 1
        Me.lblContrase�a.Text = "Contrase�a"
        '
        'cmdValidar
        '
        Me.cmdValidar.Location = New System.Drawing.Point(152, 152)
        Me.cmdValidar.Name = "cmdValidar"
        Me.cmdValidar.TabIndex = 2
        Me.cmdValidar.Text = "Validar"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(144, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Text = ""
        '
        'txtContrase�a
        '
        Me.txtContrase�a.Location = New System.Drawing.Point(144, 88)
        Me.txtContrase�a.Name = "txtContrase�a"
        Me.txtContrase�a.TabIndex = 4
        Me.txtContrase�a.Text = ""
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(152, 208)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.txtContrase�a)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmdValidar)
        Me.Controls.Add(Me.lblContrase�a)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmPrincipal"
        Me.Text = "PAGINA PRINCIPAL"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Dim nombre As String
    End Sub

    Private Sub txtContrase�a_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrase�a.TextChanged
        Dim contrase�a As Integer
    End Sub

    Private Sub cmdValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValidar.Click
        Dim nombre As String
        Dim x As Integer
        Dim llamar As New frmMenu
        nombre = "curso"
        x = "123"
        If txtNombre.Text = nombre Then
            If txtContrase�a.Text = x Then
                MessageBox.Show("Bienvenido")
                llamar.Show()
                Me.Finalize()
            Else
                MessageBox.Show("No puede iniciar sesion")
                txtContrase�a.Focus()
                txtContrase�a.Text = ("")
                txtNombre.Focus()
                txtNombre.Text = ("")
            End If
        Else
            MessageBox.Show("No puede iniciar sesion")
            txtNombre.Focus()
            txtNombre.Text = ("")
            txtContrase�a.Focus()
            txtContrase�a.Text = ("")
        End If
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
