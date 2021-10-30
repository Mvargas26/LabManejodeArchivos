<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.mnPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnCargarClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCambiarColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnPrincipal
        '
        Me.mnPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCargarClientes, Me.mnCambiarColor, Me.mnSalir})
        Me.mnPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnPrincipal.Name = "mnPrincipal"
        Me.mnPrincipal.Size = New System.Drawing.Size(1002, 28)
        Me.mnPrincipal.TabIndex = 1
        Me.mnPrincipal.Text = "MenuStrip1"
        '
        'mnCargarClientes
        '
        Me.mnCargarClientes.Name = "mnCargarClientes"
        Me.mnCargarClientes.Size = New System.Drawing.Size(123, 24)
        Me.mnCargarClientes.Text = "Cargar Clientes"
        '
        'mnCambiarColor
        '
        Me.mnCambiarColor.Name = "mnCambiarColor"
        Me.mnCambiarColor.Size = New System.Drawing.Size(119, 24)
        Me.mnCambiarColor.Text = "Cambiar Color"
        '
        'mnSalir
        '
        Me.mnSalir.Name = "mnSalir"
        Me.mnSalir.Size = New System.Drawing.Size(52, 24)
        Me.mnSalir.Text = "Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 636)
        Me.Controls.Add(Me.mnPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Ssitema de Clientes"
        Me.mnPrincipal.ResumeLayout(False)
        Me.mnPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnPrincipal As MenuStrip
    Friend WithEvents mnCargarClientes As ToolStripMenuItem
    Friend WithEvents mnCambiarColor As ToolStripMenuItem
    Friend WithEvents mnSalir As ToolStripMenuItem
End Class
