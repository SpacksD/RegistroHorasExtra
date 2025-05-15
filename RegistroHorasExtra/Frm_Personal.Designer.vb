<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Personal
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
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.c0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chorario = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tdoc = New System.Windows.Forms.TextBox()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.testado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tsueldo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tcargo = New System.Windows.Forms.TextBox()
        Me.tnombrecompleto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.ttelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbusqueda = New System.Windows.Forms.TextBox()
        Me.Panel_Contenedor.SuspendLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel_Contenedor.Size = New System.Drawing.Size(1366, 913)
        Me.Panel_Contenedor.TabIndex = 0
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
        Me.tabla1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c0, Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla1.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabla1.Location = New System.Drawing.Point(356, 343)
        Me.tabla1.MultiSelect = False
        Me.tabla1.Name = "tabla1"
        Me.tabla1.ReadOnly = True
        Me.tabla1.RowHeadersVisible = False
        Me.tabla1.RowHeadersWidth = 45
        Me.tabla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla1.Size = New System.Drawing.Size(724, 339)
        Me.tabla1.TabIndex = 13
        '
        'c0
        '
        Me.c0.HeaderText = "ID_Personal"
        Me.c0.Name = "c0"
        Me.c0.ReadOnly = True
        '
        'c1
        '
        Me.c1.HeaderText = "Nro. Documento"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        '
        'c2
        '
        Me.c2.HeaderText = "Nombre Completo"
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        '
        'c3
        '
        Me.c3.HeaderText = "Correo Electrónico"
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        '
        'c4
        '
        Me.c4.HeaderText = "Cargo"
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'c5
        '
        Me.c5.HeaderText = "Teléfono"
        Me.c5.Name = "c5"
        Me.c5.ReadOnly = True
        '
        'c6
        '
        Me.c6.HeaderText = "Sueldo"
        Me.c6.Name = "c6"
        Me.c6.ReadOnly = True
        '
        'c7
        '
        Me.c7.HeaderText = "Estado"
        Me.c7.Name = "c7"
        Me.c7.ReadOnly = True
        '
        'IconButton4
        '
        Me.IconButton4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton4.BackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(937, 688)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(143, 35)
        Me.IconButton4.TabIndex = 16
        Me.IconButton4.TabStop = False
        Me.IconButton4.Text = "Exportar a Excel"
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
        Me.Label6.Location = New System.Drawing.Point(353, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Busqueda"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chorario)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tdoc)
        Me.Panel1.Controls.Add(Me.IconButton5)
        Me.Panel1.Controls.Add(Me.IconButton3)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.testado)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tsueldo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tcargo)
        Me.Panel1.Controls.Add(Me.tnombrecompleto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.temail)
        Me.Panel1.Controls.Add(Me.ttelefono)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 287)
        Me.Panel1.TabIndex = 34
        '
        'chorario
        '
        Me.chorario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chorario.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.chorario.FormattingEnabled = True
        Me.chorario.Location = New System.Drawing.Point(480, 194)
        Me.chorario.Name = "chorario"
        Me.chorario.Size = New System.Drawing.Size(364, 25)
        Me.chorario.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(353, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Horario"
        '
        'tdoc
        '
        Me.tdoc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tdoc.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdoc.Location = New System.Drawing.Point(934, 85)
        Me.tdoc.Name = "tdoc"
        Me.tdoc.Size = New System.Drawing.Size(146, 24)
        Me.tdoc.TabIndex = 2
        '
        'IconButton5
        '
        Me.IconButton5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton5.BackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.UserMinus
        Me.IconButton5.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(748, 240)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Size = New System.Drawing.Size(115, 35)
        Me.IconButton5.TabIndex = 10
        Me.IconButton5.TabStop = False
        Me.IconButton5.Text = "Eliminar"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.IconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(355, 240)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(115, 35)
        Me.IconButton3.TabIndex = 8
        Me.IconButton3.TabStop = False
        Me.IconButton3.Text = "Nuevo"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGear
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(531, 240)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(115, 35)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.TabStop = False
        Me.IconButton1.Text = "Modificar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(934, 240)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(115, 35)
        Me.IconButton2.TabIndex = 11
        Me.IconButton2.TabStop = False
        Me.IconButton2.Text = "Limpiar"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(850, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Nro. Doc."
        '
        'testado
        '
        Me.testado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.testado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.testado.Font = New System.Drawing.Font("Palatino Linotype", 9.0!)
        Me.testado.FormattingEnabled = True
        Me.testado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.testado.Location = New System.Drawing.Point(933, 158)
        Me.testado.Name = "testado"
        Me.testado.Size = New System.Drawing.Size(147, 25)
        Me.testado.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(869, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(629, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Sueldo"
        '
        'tsueldo
        '
        Me.tsueldo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tsueldo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsueldo.Location = New System.Drawing.Point(698, 160)
        Me.tsueldo.Name = "tsueldo"
        Me.tsueldo.Size = New System.Drawing.Size(146, 24)
        Me.tsueldo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(578, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 26)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Mantenimiento del Personal"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(352, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre Completo"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(869, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Cargo"
        '
        'tcargo
        '
        Me.tcargo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tcargo.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcargo.Location = New System.Drawing.Point(934, 120)
        Me.tcargo.Name = "tcargo"
        Me.tcargo.Size = New System.Drawing.Size(146, 24)
        Me.tcargo.TabIndex = 4
        '
        'tnombrecompleto
        '
        Me.tnombrecompleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tnombrecompleto.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombrecompleto.Location = New System.Drawing.Point(480, 85)
        Me.tnombrecompleto.Name = "tnombrecompleto"
        Me.tnombrecompleto.Size = New System.Drawing.Size(364, 24)
        Me.tnombrecompleto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(353, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Teléfono"
        '
        'temail
        '
        Me.temail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.temail.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temail.Location = New System.Drawing.Point(480, 121)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(364, 24)
        Me.temail.TabIndex = 3
        '
        'ttelefono
        '
        Me.ttelefono.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ttelefono.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttelefono.Location = New System.Drawing.Point(480, 158)
        Me.ttelefono.Name = "ttelefono"
        Me.ttelefono.Size = New System.Drawing.Size(128, 24)
        Me.ttelefono.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(352, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Correo Electrónico"
        '
        'tbusqueda
        '
        Me.tbusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbusqueda.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbusqueda.Location = New System.Drawing.Point(480, 306)
        Me.tbusqueda.Name = "tbusqueda"
        Me.tbusqueda.Size = New System.Drawing.Size(567, 24)
        Me.tbusqueda.TabIndex = 12
        '
        'Frm_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 913)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Name = "Frm_Personal"
        Me.Text = "Frm_Personal"
        Me.Panel_Contenedor.ResumeLayout(False)
        Me.Panel_Contenedor.PerformLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents tnombrecompleto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tcargo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ttelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents temail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tbusqueda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tsueldo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents testado As ComboBox
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents tdoc As TextBox
    Friend WithEvents c0 As DataGridViewTextBoxColumn
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents c6 As DataGridViewTextBoxColumn
    Friend WithEvents c7 As DataGridViewTextBoxColumn
    Friend WithEvents chorario As ComboBox
    Friend WithEvents Label10 As Label
End Class
