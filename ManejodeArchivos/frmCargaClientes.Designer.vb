<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCargarArchivo = New System.Windows.Forms.GroupBox()
        Me.btnGuardarXML = New System.Windows.Forms.Button()
        Me.btnCargarArchivo = New System.Windows.Forms.Button()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lisvDatosCargados = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProvincia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMonto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.grpCargarArchivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCargarArchivo
        '
        Me.grpCargarArchivo.Controls.Add(Me.btnGuardarXML)
        Me.grpCargarArchivo.Controls.Add(Me.btnCargarArchivo)
        Me.grpCargarArchivo.Controls.Add(Me.btnRuta)
        Me.grpCargarArchivo.Controls.Add(Me.txtRuta)
        Me.grpCargarArchivo.Controls.Add(Me.lblRuta)
        Me.grpCargarArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCargarArchivo.Location = New System.Drawing.Point(0, 0)
        Me.grpCargarArchivo.Name = "grpCargarArchivo"
        Me.grpCargarArchivo.Size = New System.Drawing.Size(756, 136)
        Me.grpCargarArchivo.TabIndex = 0
        Me.grpCargarArchivo.TabStop = False
        '
        'btnGuardarXML
        '
        Me.btnGuardarXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarXML.Location = New System.Drawing.Point(606, 59)
        Me.btnGuardarXML.Name = "btnGuardarXML"
        Me.btnGuardarXML.Size = New System.Drawing.Size(138, 43)
        Me.btnGuardarXML.TabIndex = 4
        Me.btnGuardarXML.Text = "Guardar XML"
        Me.btnGuardarXML.UseVisualStyleBackColor = True
        '
        'btnCargarArchivo
        '
        Me.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarArchivo.Location = New System.Drawing.Point(438, 59)
        Me.btnCargarArchivo.Name = "btnCargarArchivo"
        Me.btnCargarArchivo.Size = New System.Drawing.Size(138, 43)
        Me.btnCargarArchivo.TabIndex = 3
        Me.btnCargarArchivo.Text = "CargarArchivo"
        Me.btnCargarArchivo.UseVisualStyleBackColor = True
        '
        'btnRuta
        '
        Me.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRuta.Location = New System.Drawing.Point(694, 11)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(50, 29)
        Me.btnRuta.TabIndex = 2
        Me.btnRuta.Text = "..."
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(61, 14)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(587, 22)
        Me.txtRuta.TabIndex = 1
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(7, 13)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(48, 23)
        Me.lblRuta.TabIndex = 0
        Me.lblRuta.Text = "Ruta:"
        '
        'lisvDatosCargados
        '
        Me.lisvDatosCargados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colNombre, Me.colApellido, Me.colProvincia, Me.colCorreo, Me.colMonto})
        Me.lisvDatosCargados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lisvDatosCargados.GridLines = True
        Me.lisvDatosCargados.HideSelection = False
        Me.lisvDatosCargados.Location = New System.Drawing.Point(0, 136)
        Me.lisvDatosCargados.Name = "lisvDatosCargados"
        Me.lisvDatosCargados.Size = New System.Drawing.Size(756, 334)
        Me.lisvDatosCargados.TabIndex = 1
        Me.lisvDatosCargados.UseCompatibleStateImageBehavior = False
        Me.lisvDatosCargados.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 100
        '
        'colNombre
        '
        Me.colNombre.Text = "Nombre"
        Me.colNombre.Width = 100
        '
        'colApellido
        '
        Me.colApellido.Text = "Apellido"
        Me.colApellido.Width = 100
        '
        'colProvincia
        '
        Me.colProvincia.Text = "Provincia"
        Me.colProvincia.Width = 100
        '
        'colCorreo
        '
        Me.colCorreo.Text = "Correo"
        Me.colCorreo.Width = 100
        '
        'colMonto
        '
        Me.colMonto.Text = "Monto"
        Me.colMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colMonto.Width = 100
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        '
        'frmCargaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 470)
        Me.Controls.Add(Me.lisvDatosCargados)
        Me.Controls.Add(Me.grpCargarArchivo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Clientes"
        Me.grpCargarArchivo.ResumeLayout(False)
        Me.grpCargarArchivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCargarArchivo As GroupBox
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents lblRuta As Label
    Friend WithEvents btnCargarArchivo As Button
    Friend WithEvents btnRuta As Button
    Friend WithEvents lisvDatosCargados As ListView
    Friend WithEvents ofdArchivo As OpenFileDialog
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colNombre As ColumnHeader
    Friend WithEvents colApellido As ColumnHeader
    Friend WithEvents colProvincia As ColumnHeader
    Friend WithEvents colCorreo As ColumnHeader
    Friend WithEvents colMonto As ColumnHeader
    Friend WithEvents btnGuardarXML As Button
End Class
