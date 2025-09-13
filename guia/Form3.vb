Public Class menu
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.MainMenu1 = New System.Windows.Forms.MainMenu
Me.MenuItem1 = New System.Windows.Forms.MenuItem
Me.MenuItem2 = New System.Windows.Forms.MenuItem
Me.MenuItem3 = New System.Windows.Forms.MenuItem
Me.MenuItem4 = New System.Windows.Forms.MenuItem
'
'MainMenu1
'
Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem4})
'
'MenuItem1
'
Me.MenuItem1.Index = 0
Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
Me.MenuItem1.Text = "ejemplo"
'
'MenuItem2
'
Me.MenuItem2.Index = 0
Me.MenuItem2.Text = "-"
'
'MenuItem3
'
Me.MenuItem3.Index = 1
Me.MenuItem3.Text = "cmd"
'
'MenuItem4
'
Me.MenuItem4.Index = 1
Me.MenuItem4.Text = ""
'
'menu
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.ClientSize = New System.Drawing.Size(292, 273)
Me.Menu = Me.MainMenu1
Me.Name = "menu"
Me.Text = "Form3"

    End Sub

#End Region

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
