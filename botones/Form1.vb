Public Class Form1
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "aceptar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "fecha"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 48)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 309)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ok As Boolean
        ok = True
        ok = False
        If ok = True Then
            MessageBox.Show("la variable es verdadera")
        Else

            MessageBox.Show("la variable es falsa")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fecha As Date
        fecha = #3/30/2006#
        fecha = Now()
        MessageBox.Show("la fecha y hora actual")

    End Sub
End Class
