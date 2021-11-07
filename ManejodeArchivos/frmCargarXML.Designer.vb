<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarXML
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCargarXML = New System.Windows.Forms.Button()
        Me.btnRutaXML = New System.Windows.Forms.Button()
        Me.txtRutaXML = New System.Windows.Forms.TextBox()
        Me.lblRutaXML = New System.Windows.Forms.Label()
        Me.ofdArchivoXML = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtCedulaCliente = New System.Windows.Forms.TextBox()
        Me.lblCedulaCliente = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCargarXML)
        Me.GroupBox1.Controls.Add(Me.btnRutaXML)
        Me.GroupBox1.Controls.Add(Me.txtRutaXML)
        Me.GroupBox1.Controls.Add(Me.lblRutaXML)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnCargarXML
        '
        Me.btnCargarXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCargarXML.Location = New System.Drawing.Point(631, 53)
        Me.btnCargarXML.Name = "btnCargarXML"
        Me.btnCargarXML.Size = New System.Drawing.Size(138, 43)
        Me.btnCargarXML.TabIndex = 8
        Me.btnCargarXML.Text = "Cargar XML"
        Me.btnCargarXML.UseVisualStyleBackColor = True
        '
        'btnRutaXML
        '
        Me.btnRutaXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRutaXML.Location = New System.Drawing.Point(719, 5)
        Me.btnRutaXML.Name = "btnRutaXML"
        Me.btnRutaXML.Size = New System.Drawing.Size(50, 29)
        Me.btnRutaXML.TabIndex = 7
        Me.btnRutaXML.Text = "..."
        Me.btnRutaXML.UseVisualStyleBackColor = True
        '
        'txtRutaXML
        '
        Me.txtRutaXML.Location = New System.Drawing.Point(86, 8)
        Me.txtRutaXML.Name = "txtRutaXML"
        Me.txtRutaXML.ReadOnly = True
        Me.txtRutaXML.Size = New System.Drawing.Size(587, 22)
        Me.txtRutaXML.TabIndex = 6
        '
        'lblRutaXML
        '
        Me.lblRutaXML.Location = New System.Drawing.Point(32, 7)
        Me.lblRutaXML.Name = "lblRutaXML"
        Me.lblRutaXML.Size = New System.Drawing.Size(48, 23)
        Me.lblRutaXML.TabIndex = 5
        Me.lblRutaXML.Text = "Ruta:"
        '
        'ofdArchivoXML
        '
        Me.ofdArchivoXML.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox2.Controls.Add(Me.txtCedulaCliente)
        Me.GroupBox2.Controls.Add(Me.lblCedulaCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultar Información de Cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarCliente.Location = New System.Drawing.Point(108, 94)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(138, 43)
        Me.btnBuscarCliente.TabIndex = 8
        Me.btnBuscarCliente.Text = "Buscar"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtCedulaCliente
        '
        Me.txtCedulaCliente.Location = New System.Drawing.Point(108, 50)
        Me.txtCedulaCliente.Name = "txtCedulaCliente"
        Me.txtCedulaCliente.ReadOnly = True
        Me.txtCedulaCliente.Size = New System.Drawing.Size(170, 22)
        Me.txtCedulaCliente.TabIndex = 6
        '
        'lblCedulaCliente
        '
        Me.lblCedulaCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation
        Me.lblCedulaCliente.Location = New System.Drawing.Point(6, 49)
        Me.lblCedulaCliente.Name = "lblCedulaCliente"
        Me.lblCedulaCliente.Size = New System.Drawing.Size(80, 23)
        Me.lblCedulaCliente.TabIndex = 5
        Me.lblCedulaCliente.Text = "ID Cliente:"
        '
        'frmCargarXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCargarXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar XML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargarXML As Button
    Friend WithEvents btnRutaXML As Button
    Friend WithEvents txtRutaXML As TextBox
    Friend WithEvents lblRutaXML As Label
    Friend WithEvents ofdArchivoXML As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtCedulaCliente As TextBox
    Friend WithEvents lblCedulaCliente As Label
End Class
