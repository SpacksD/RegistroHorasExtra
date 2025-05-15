<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Revisor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generar Horarios y Trabajadores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tabla1
        '
        Me.tabla1.AllowUserToResizeColumns = False
        Me.tabla1.AllowUserToResizeRows = False
        Me.tabla1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.tabla1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla1.DefaultCellStyle = DataGridViewCellStyle9
        Me.tabla1.Location = New System.Drawing.Point(166, 138)
        Me.tabla1.MultiSelect = False
        Me.tabla1.Name = "tabla1"
        Me.tabla1.ReadOnly = True
        Me.tabla1.RowHeadersVisible = False
        Me.tabla1.RowHeadersWidth = 45
        Me.tabla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla1.Size = New System.Drawing.Size(724, 449)
        Me.tabla1.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 39)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Generar Registros"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(570, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(276, 96)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Reiniciar Base de Datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Revisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1164, 677)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tabla1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Revisor"
        Me.Text = "Revisor"
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
