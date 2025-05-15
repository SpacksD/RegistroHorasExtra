<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorReportes
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
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton4
        '
        Me.IconButton4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton4.BackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(623, 437)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(120, 35)
        Me.IconButton4.TabIndex = 44
        Me.IconButton4.TabStop = False
        Me.IconButton4.Text = "Seleccionar"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(48, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Busqueda"
        '
        'tabla1
        '
        Me.tabla1.AllowUserToAddRows = False
        Me.tabla1.AllowUserToDeleteRows = False
        Me.tabla1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabla1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tabla1.Location = New System.Drawing.Point(51, 52)
        Me.tabla1.Name = "tabla1"
        Me.tabla1.ReadOnly = True
        Me.tabla1.RowHeadersVisible = False
        Me.tabla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla1.Size = New System.Drawing.Size(692, 370)
        Me.tabla1.TabIndex = 42
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(123, 16)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(620, 25)
        Me.TextBox5.TabIndex = 41
        '
        'BuscadorReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 482)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tabla1)
        Me.Controls.Add(Me.TextBox5)
        Me.Name = "BuscadorReportes"
        Me.Text = "BuscadorReportes"
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
End Class
