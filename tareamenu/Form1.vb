Public Class frmMnuprincipal
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents FrmMenu As System.Windows.Forms.MenuItem
    Friend WithEvents FrmGuia2a As System.Windows.Forms.MenuItem
    Friend WithEvents FrmGuia2b As System.Windows.Forms.MenuItem
    Friend WithEvents frmSalir As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.FrmMenu = New System.Windows.Forms.MenuItem
        Me.FrmGuia2a = New System.Windows.Forms.MenuItem
        Me.FrmGuia2b = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.frmSalir = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FrmMenu})
        '
        'FrmMenu
        '
        Me.FrmMenu.Index = 0
        Me.FrmMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FrmGuia2a, Me.FrmGuia2b, Me.MenuItem4, Me.frmSalir})
        Me.FrmMenu.Text = "ejercicios"
        '
        'FrmGuia2a
        '
        Me.FrmGuia2a.Index = 0
        Me.FrmGuia2a.Text = "guia2a"
        '
        'FrmGuia2b
        '
        Me.FrmGuia2b.Index = 1
        Me.FrmGuia2b.Text = "guia2b"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "-"
        '
        'frmSalir
        '
        Me.frmSalir.Index = 3
        Me.frmSalir.Text = "salir"
        '
        'frmMnuprincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMnuprincipal"
        Me.Text = "Form1"

    End Sub

#End Region

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmGuia2a.Click
        Dim alfa As New FrmEjercicioguia1
        alfa.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmGuia2b.Click
        Dim alfa As New FrmEjercicioguia2
        alfa.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSalir.Click
        Me.Close()
    End Sub
End Class
