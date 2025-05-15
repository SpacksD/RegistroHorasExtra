<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Horarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.c0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trfin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trinicio = New System.Windows.Forms.TextBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.thorafin = New System.Windows.Forms.TextBox()
        Me.tdescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.thorainicio = New System.Windows.Forms.TextBox()
        Me.Panel_Contenedor.SuspendLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbusqueda
        '
        Me.tbusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.tbusqueda.Location = New System.Drawing.Point(323, 293)
        Me.tbusqueda.Name = "tbusqueda"
        Me.tbusqueda.Size = New System.Drawing.Size(628, 24)
        Me.tbusqueda.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(224, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Descripción"
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
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(808, 648)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(143, 35)
        Me.IconButton4.TabIndex = 35
        Me.IconButton4.TabStop = False
        Me.IconButton4.Text = "Exportar a Excel"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Controls.Add(Me.tabla1)
        Me.Panel_Contenedor.Controls.Add(Me.IconButton4)
        Me.Panel_Contenedor.Controls.Add(Me.Label6)
        Me.Panel_Contenedor.Controls.Add(Me.Panel1)
        Me.Panel_Contenedor.Controls.Add(Me.tbusqueda)
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contenedor.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(1177, 897)
        Me.Panel_Contenedor.TabIndex = 1
        '
        'tabla1
        '
        Me.tabla1.AllowUserToAddRows = False
        Me.tabla1.AllowUserToDeleteRows = False
        Me.tabla1.AllowUserToResizeColumns = False
        Me.tabla1.AllowUserToResizeRows = False
        Me.tabla1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.tabla1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c0, Me.c1, Me.c2, Me.c3, Me.c4, Me.c5})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla1.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabla1.Location = New System.Drawing.Point(227, 323)
        Me.tabla1.MultiSelect = False
        Me.tabla1.Name = "tabla1"
        Me.tabla1.ReadOnly = True
        Me.tabla1.RowHeadersVisible = False
        Me.tabla1.RowHeadersWidth = 45
        Me.tabla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla1.Size = New System.Drawing.Size(724, 319)
        Me.tabla1.TabIndex = 36
        '
        'c0
        '
        Me.c0.HeaderText = "ID_Horario"
        Me.c0.Name = "c0"
        Me.c0.ReadOnly = True
        '
        'c1
        '
        Me.c1.HeaderText = "Descripción"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        '
        'c2
        '
        Me.c2.HeaderText = "Inicio Turno"
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        '
        'c3
        '
        Me.c3.HeaderText = "Fin Turno"
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        '
        'c4
        '
        Me.c4.HeaderText = "Inicio Refrigerio"
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'c5
        '
        Me.c5.HeaderText = "Fin Refrigerio"
        Me.c5.Name = "c5"
        Me.c5.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(224, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Busqueda"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.trfin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.trinicio)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.IconButton5)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.thorafin)
        Me.Panel1.Controls.Add(Me.tdescripcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.thorainicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1177, 268)
        Me.Panel1.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(500, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Fin Refrigerio"
        '
        'trfin
        '
        Me.trfin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.trfin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trfin.Location = New System.Drawing.Point(611, 167)
        Me.trfin.Name = "trfin"
        Me.trfin.Size = New System.Drawing.Size(142, 24)
        Me.trfin.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(225, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Inicio Refrigerio"
        '
        'trinicio
        '
        Me.trinicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.trinicio.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trinicio.Location = New System.Drawing.Point(339, 169)
        Me.trinicio.Name = "trinicio"
        Me.trinicio.Size = New System.Drawing.Size(143, 24)
        Me.trinicio.TabIndex = 44
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(837, 221)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(115, 35)
        Me.IconButton2.TabIndex = 42
        Me.IconButton2.TabStop = False
        Me.IconButton2.Text = "Limpiar"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton5.BackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus
        Me.IconButton5.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(626, 221)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(115, 35)
        Me.IconButton5.TabIndex = 43
        Me.IconButton5.TabStop = False
        Me.IconButton5.Text = "Eliminar"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(408, 221)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(115, 35)
        Me.IconButton1.TabIndex = 41
        Me.IconButton1.TabStop = False
        Me.IconButton1.Text = "Modificar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus
        Me.IconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(227, 221)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(115, 35)
        Me.IconButton3.TabIndex = 40
        Me.IconButton3.TabStop = False
        Me.IconButton3.Text = "Nuevo"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(479, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 26)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Mantenimiento de Horarios"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(500, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fin del Turno"
        '
        'thorafin
        '
        Me.thorafin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.thorafin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thorafin.Location = New System.Drawing.Point(611, 124)
        Me.thorafin.Name = "thorafin"
        Me.thorafin.Size = New System.Drawing.Size(142, 24)
        Me.thorafin.TabIndex = 30
        '
        'tdescripcion
        '
        Me.tdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tdescripcion.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdescripcion.Location = New System.Drawing.Point(339, 85)
        Me.tdescripcion.Name = "tdescripcion"
        Me.tdescripcion.Size = New System.Drawing.Size(612, 24)
        Me.tdescripcion.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(224, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Inicio Turno"
        '
        'thorainicio
        '
        Me.thorainicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.thorainicio.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thorainicio.Location = New System.Drawing.Point(339, 124)
        Me.thorainicio.Name = "thorainicio"
        Me.thorainicio.Size = New System.Drawing.Size(143, 24)
        Me.thorainicio.TabIndex = 28
        '
        'Frm_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1177, 897)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Name = "Frm_Horarios"
        Me.Text = "Frm_Horarios"
        Me.Panel_Contenedor.ResumeLayout(False)
        Me.Panel_Contenedor.PerformLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents thorafin As TextBox
    Friend WithEvents tdescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents thorainicio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents trinicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents trfin As TextBox
    Friend WithEvents c0 As DataGridViewTextBoxColumn
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
End Class
