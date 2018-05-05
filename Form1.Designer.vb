<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Enumerar = New System.Windows.Forms.Button
        Me.Alfabetizar = New System.Windows.Forms.Button
        Me.Mayusculas = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Enumerar
        '
        Me.Enumerar.Location = New System.Drawing.Point(18, 12)
        Me.Enumerar.Name = "Enumerar"
        Me.Enumerar.Size = New System.Drawing.Size(75, 23)
        Me.Enumerar.TabIndex = 0
        Me.Enumerar.Text = "Enumerar"
        Me.Enumerar.UseVisualStyleBackColor = True
        '
        'Alfabetizar
        '
        Me.Alfabetizar.Location = New System.Drawing.Point(99, 12)
        Me.Alfabetizar.Name = "Alfabetizar"
        Me.Alfabetizar.Size = New System.Drawing.Size(83, 23)
        Me.Alfabetizar.TabIndex = 1
        Me.Alfabetizar.Text = "Alfabetizar"
        Me.Alfabetizar.UseVisualStyleBackColor = True
        '
        'Mayusculas
        '
        Me.Mayusculas.Location = New System.Drawing.Point(197, 12)
        Me.Mayusculas.Name = "Mayusculas"
        Me.Mayusculas.Size = New System.Drawing.Size(75, 23)
        Me.Mayusculas.TabIndex = 2
        Me.Mayusculas.Text = "Mayusculas"
        Me.Mayusculas.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 229)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 20)
        Me.TextBox1.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(18, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 160)
        Me.ListBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mayusculas)
        Me.Controls.Add(Me.Alfabetizar)
        Me.Controls.Add(Me.Enumerar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Enumerar As System.Windows.Forms.Button
    Friend WithEvents Alfabetizar As System.Windows.Forms.Button
    Friend WithEvents Mayusculas As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
