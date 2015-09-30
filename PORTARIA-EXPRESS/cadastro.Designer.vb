<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FAZERLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(471, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FAZERLOToolStripMenuItem})
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.USUARIOToolStripMenuItem.Text = "USUARIO"
        '
        'FAZERLOToolStripMenuItem
        '
        Me.FAZERLOToolStripMenuItem.Name = "FAZERLOToolStripMenuItem"
        Me.FAZERLOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FAZERLOToolStripMenuItem.Text = "SAIR"
        '
        'cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 306)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cadastro"
        Me.Text = "CADASTRO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents USUARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FAZERLOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
