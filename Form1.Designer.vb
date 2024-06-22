<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.txtSalvar = New System.Windows.Forms.TextBox
        Me.Salvar1 = New System.Windows.Forms.SaveFileDialog
        Me.Abrir1 = New System.Windows.Forms.OpenFileDialog
        Me.txtAbrir = New System.Windows.Forms.TextBox
        Me.btnAbrir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(58, 266)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(108, 34)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Criar arquivo"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtSalvar
        '
        Me.txtSalvar.Location = New System.Drawing.Point(14, 18)
        Me.txtSalvar.Multiline = True
        Me.txtSalvar.Name = "txtSalvar"
        Me.txtSalvar.Size = New System.Drawing.Size(209, 219)
        Me.txtSalvar.TabIndex = 1
        '
        'Abrir1
        '
        Me.Abrir1.FileName = "OpenFileDialog1"
        '
        'txtAbrir
        '
        Me.txtAbrir.Location = New System.Drawing.Point(278, 18)
        Me.txtAbrir.Multiline = True
        Me.txtAbrir.Name = "txtAbrir"
        Me.txtAbrir.Size = New System.Drawing.Size(209, 219)
        Me.txtAbrir.TabIndex = 3
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(322, 266)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(108, 34)
        Me.btnAbrir.TabIndex = 2
        Me.btnAbrir.Text = "Abrir arquivo"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 348)
        Me.Controls.Add(Me.txtAbrir)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.txtSalvar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtSalvar As System.Windows.Forms.TextBox
    Friend WithEvents Salvar1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Abrir1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtAbrir As System.Windows.Forms.TextBox
    Friend WithEvents btnAbrir As System.Windows.Forms.Button

End Class
