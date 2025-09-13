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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents N1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents N2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Cmd1 As System.Windows.Forms.Button
    Friend WithEvents Cmd2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Cmd3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cmd1 = New System.Windows.Forms.Button
        Me.N1 = New System.Windows.Forms.NumericUpDown
        Me.N2 = New System.Windows.Forms.NumericUpDown
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Cmd2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Cmd3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.N1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd1
        '
        Me.Cmd1.Location = New System.Drawing.Point(288, 40)
        Me.Cmd1.Name = "Cmd1"
        Me.Cmd1.Size = New System.Drawing.Size(80, 24)
        Me.Cmd1.TabIndex = 0
        Me.Cmd1.Text = "SALIR"
        '
        'N1
        '
        Me.N1.Location = New System.Drawing.Point(272, 160)
        Me.N1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.N1.Name = "N1"
        Me.N1.TabIndex = 2
        Me.N1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'N2
        '
        Me.N2.Location = New System.Drawing.Point(272, 200)
        Me.N2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.N2.Name = "N2"
        Me.N2.TabIndex = 3
        Me.N2.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Cmd2
        '
        Me.Cmd2.Location = New System.Drawing.Point(288, 80)
        Me.Cmd2.Name = "Cmd2"
        Me.Cmd2.Size = New System.Drawing.Size(80, 24)
        Me.Cmd2.TabIndex = 6
        Me.Cmd2.Text = "Maximizar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Normal"
        '
        'OpenFileDialog1
        '
        '
        'SaveFileDialog1
        '
        '
        'Cmd3
        '
        Me.Cmd3.Location = New System.Drawing.Point(32, 280)
        Me.Cmd3.Name = "Cmd3"
        Me.Cmd3.Size = New System.Drawing.Size(128, 23)
        Me.Cmd3.TabIndex = 8
        Me.Cmd3.Text = "seleccionar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Guardar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 333)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cmd3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cmd2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.N2)
        Me.Controls.Add(Me.N1)
        Me.Controls.Add(Me.Cmd1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.N1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.ValueChanged
        PictureBox1.Size = New Size(N1.Value, N2.Value)
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim imagen As Bitmap
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        imagen = New Bitmap("C:\guapa.jpg")
        PictureBox1.Image = imagen

    End Sub

    Private Sub N2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.ValueChanged
        PictureBox1.Size = New Size(N1.Value, N2.Value)
    End Sub

    Private Sub Cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd2.Click
        Dim imagen As Bitmap
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        imagen = New Bitmap("C:\guapa.jpg")
        PictureBox1.Image = imagen
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim imagen As Bitmap
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        imagen = New Bitmap("C:\guapa.jpg")
        PictureBox1.Image = imagen
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd3.Click
        Dim imagen As Bitmap
        OpenFileDialog1.Filter = "archi|*.jpg"
        OpenFileDialog1.ShowDialog()
        imagen = New Bitmap(OpenFileDialog1.FileName)
        PictureBox1.Image = imagen
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim save As SaveFileDialog
        Dim imagen As Bitmap

        SaveFileDialog1.Filter = "es mi prueba|*.jpg"
        SaveFileDialog1.ShowDialog()
        save = New SaveFileDialog
        MessageBox.Show("Los datos Fueron guardados", " Aviso")
        Me.Finalize()
    End Sub
End Class
