Public Class frm
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
    Friend WithEvents lblAnom As System.Windows.Forms.Label
    Friend WithEvents lblLista As System.Windows.Forms.Label
    Friend WithEvents lblSelec As System.Windows.Forms.Label
    Friend WithEvents cmdAgr As System.Windows.Forms.Button
    Friend WithEvents Button2cmdSelect As System.Windows.Forms.Button
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents cboNombres As System.Windows.Forms.ComboBox
    Friend WithEvents txtSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents lstNombres As System.Windows.Forms.ListBox
    Friend WithEvents cmdCargar As System.Windows.Forms.Button
    Friend WithEvents pctFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ofdabrir As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblAnom = New System.Windows.Forms.Label
        Me.lblLista = New System.Windows.Forms.Label
        Me.lblSelec = New System.Windows.Forms.Label
        Me.cmdAgr = New System.Windows.Forms.Button
        Me.Button2cmdSelect = New System.Windows.Forms.Button
        Me.txtNom = New System.Windows.Forms.TextBox
        Me.cboNombres = New System.Windows.Forms.ComboBox
        Me.txtSeleccionado = New System.Windows.Forms.TextBox
        Me.lstNombres = New System.Windows.Forms.ListBox
        Me.pctFoto = New System.Windows.Forms.PictureBox
        Me.cmdCargar = New System.Windows.Forms.Button
        Me.ofdabrir = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'lblAnom
        '
        Me.lblAnom.Location = New System.Drawing.Point(64, 48)
        Me.lblAnom.Name = "lblAnom"
        Me.lblAnom.TabIndex = 0
        Me.lblAnom.Text = "Agregar Nombres"
        '
        'lblLista
        '
        Me.lblLista.Location = New System.Drawing.Point(64, 112)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.TabIndex = 1
        Me.lblLista.Text = "Lista de Nombres"
        '
        'lblSelec
        '
        Me.lblSelec.Location = New System.Drawing.Point(64, 184)
        Me.lblSelec.Name = "lblSelec"
        Me.lblSelec.Size = New System.Drawing.Size(128, 23)
        Me.lblSelec.TabIndex = 2
        Me.lblSelec.Text = "Nombre Seleccionado"
        '
        'cmdAgr
        '
        Me.cmdAgr.Location = New System.Drawing.Point(224, 80)
        Me.cmdAgr.Name = "cmdAgr"
        Me.cmdAgr.TabIndex = 3
        Me.cmdAgr.Text = "Agregar"
        '
        'Button2cmdSelect
        '
        Me.Button2cmdSelect.Location = New System.Drawing.Point(224, 112)
        Me.Button2cmdSelect.Name = "Button2cmdSelect"
        Me.Button2cmdSelect.TabIndex = 4
        Me.Button2cmdSelect.Text = "Seleccionar"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(64, 80)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.TabIndex = 5
        Me.txtNom.Text = ""
        '
        'cboNombres
        '
        Me.cboNombres.Location = New System.Drawing.Point(64, 136)
        Me.cboNombres.Name = "cboNombres"
        Me.cboNombres.Size = New System.Drawing.Size(121, 21)
        Me.cboNombres.TabIndex = 6
        '
        'txtSeleccionado
        '
        Me.txtSeleccionado.Location = New System.Drawing.Point(64, 216)
        Me.txtSeleccionado.Name = "txtSeleccionado"
        Me.txtSeleccionado.TabIndex = 7
        Me.txtSeleccionado.Text = ""
        '
        'lstNombres
        '
        Me.lstNombres.Location = New System.Drawing.Point(320, 72)
        Me.lstNombres.Name = "lstNombres"
        Me.lstNombres.Size = New System.Drawing.Size(120, 69)
        Me.lstNombres.TabIndex = 8
        '
        'pctFoto
        '
        Me.pctFoto.Location = New System.Drawing.Point(328, 152)
        Me.pctFoto.Name = "pctFoto"
        Me.pctFoto.Size = New System.Drawing.Size(112, 96)
        Me.pctFoto.TabIndex = 9
        Me.pctFoto.TabStop = False
        '
        'cmdCargar
        '
        Me.cmdCargar.Location = New System.Drawing.Point(344, 256)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.TabIndex = 10
        Me.cmdCargar.Text = "Cargar"
        '
        'ofdabrir
        '
        '
        'frm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 317)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.pctFoto)
        Me.Controls.Add(Me.lstNombres)
        Me.Controls.Add(Me.txtSeleccionado)
        Me.Controls.Add(Me.cboNombres)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Button2cmdSelect)
        Me.Controls.Add(Me.cmdAgr)
        Me.Controls.Add(Me.lblSelec)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.lblAnom)
        Me.Name = "frm"
        Me.Text = "04-05"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        cboNombres.Items.Add(txtNom.Text)
        lstNombres.Items.Add(txtNom.Text)
        txtNom.Text = " "
    End Sub

    Private Sub Button2cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2cmdSelect.Click
        txtSeleccionado.Text = lstNombres.GetItemText(lstNombres.SelectedItem)

    End Sub

    Private Sub lstNombres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNombres.SelectedIndexChanged

    End Sub

    Private Sub cmdCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargar.Click
        Dim foto As Bitmap
        ofdabrir.Filter = "archivo de imagen dado en el curso|*.jpg|imagen de bits|*.bmp"
        ofdabrir.ShowDialog()
        foto = New Bitmap(ofdabrir.FileName)
        pctFoto.Image = foto
        pctFoto.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofdabrir.FileOk

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pctFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctFoto.Click

    End Sub

    Private Sub cboNombres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNombres.SelectedIndexChanged

    End Sub

    Private Sub txtSeleccionado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeleccionado.TextChanged

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

    End Sub
End Class
