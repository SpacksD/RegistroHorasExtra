<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.tabla1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelperiodo = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.cmesg = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cañog = New System.Windows.Forms.TextBox()
        Me.paneltrabajador = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cañot = New System.Windows.Forms.TextBox()
        Me.cmest = New System.Windows.Forms.ComboBox()
        Me.tnombrecompleto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_Contenedor.SuspendLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelperiodo.SuspendLayout()
        Me.paneltrabajador.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(772, 540)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(102, 35)
        Me.IconButton4.TabIndex = 35
        Me.IconButton4.TabStop = False
        Me.IconButton4.Text = "Imprimir"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.Controls.Add(Me.tabla1)
        Me.Panel_Contenedor.Controls.Add(Me.Label3)
        Me.Panel_Contenedor.Controls.Add(Me.IconButton4)
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contenedor.Location = New System.Drawing.Point(0, 99)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(1027, 598)
        Me.Panel_Contenedor.TabIndex = 3
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabla1.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabla1.Location = New System.Drawing.Point(182, 232)
        Me.tabla1.MultiSelect = False
        Me.tabla1.Name = "tabla1"
        Me.tabla1.ReadOnly = True
        Me.tabla1.RowHeadersVisible = False
        Me.tabla1.RowHeadersWidth = 45
        Me.tabla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla1.Size = New System.Drawing.Size(692, 289)
        Me.tabla1.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(489, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 26)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Resultados"
        '
        'panelperiodo
        '
        Me.panelperiodo.Controls.Add(Me.IconButton2)
        Me.panelperiodo.Controls.Add(Me.cmesg)
        Me.panelperiodo.Controls.Add(Me.Label8)
        Me.panelperiodo.Controls.Add(Me.Label9)
        Me.panelperiodo.Controls.Add(Me.Label10)
        Me.panelperiodo.Controls.Add(Me.cañog)
        Me.panelperiodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelperiodo.Location = New System.Drawing.Point(0, 99)
        Me.panelperiodo.Name = "panelperiodo"
        Me.panelperiodo.Size = New System.Drawing.Size(1027, 97)
        Me.panelperiodo.TabIndex = 54
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
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(717, 55)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(157, 35)
        Me.IconButton2.TabIndex = 59
        Me.IconButton2.TabStop = False
        Me.IconButton2.Text = "Buscar Registros"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'cmesg
        '
        Me.cmesg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmesg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmesg.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmesg.FormattingEnabled = True
        Me.cmesg.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmesg.Location = New System.Drawing.Point(221, 61)
        Me.cmesg.Name = "cmesg"
        Me.cmesg.Size = New System.Drawing.Size(121, 25)
        Me.cmesg.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(379, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Año"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(218, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Mes"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(193, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Periodo"
        '
        'cañog
        '
        Me.cañog.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cañog.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cañog.Location = New System.Drawing.Point(382, 61)
        Me.cañog.Name = "cañog"
        Me.cañog.Size = New System.Drawing.Size(93, 24)
        Me.cañog.TabIndex = 51
        '
        'paneltrabajador
        '
        Me.paneltrabajador.Controls.Add(Me.IconButton1)
        Me.paneltrabajador.Controls.Add(Me.Label4)
        Me.paneltrabajador.Controls.Add(Me.Label5)
        Me.paneltrabajador.Controls.Add(Me.cañot)
        Me.paneltrabajador.Controls.Add(Me.cmest)
        Me.paneltrabajador.Controls.Add(Me.tnombrecompleto)
        Me.paneltrabajador.Controls.Add(Me.Label2)
        Me.paneltrabajador.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltrabajador.Location = New System.Drawing.Point(0, 196)
        Me.paneltrabajador.Name = "paneltrabajador"
        Me.paneltrabajador.Size = New System.Drawing.Size(1027, 129)
        Me.paneltrabajador.TabIndex = 52
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
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(717, 81)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(157, 35)
        Me.IconButton1.TabIndex = 58
        Me.IconButton1.TabStop = False
        Me.IconButton1.Text = "Buscar Registros"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(379, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Año"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(218, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Mes"
        '
        'cañot
        '
        Me.cañot.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cañot.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cañot.Location = New System.Drawing.Point(382, 87)
        Me.cañot.Name = "cañot"
        Me.cañot.Size = New System.Drawing.Size(93, 24)
        Me.cañot.TabIndex = 55
        '
        'cmest
        '
        Me.cmest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmest.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmest.FormattingEnabled = True
        Me.cmest.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmest.Location = New System.Drawing.Point(221, 87)
        Me.cmest.Name = "cmest"
        Me.cmest.Size = New System.Drawing.Size(121, 25)
        Me.cmest.TabIndex = 54
        '
        'tnombrecompleto
        '
        Me.tnombrecompleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tnombrecompleto.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnombrecompleto.Location = New System.Drawing.Point(221, 40)
        Me.tnombrecompleto.Name = "tnombrecompleto"
        Me.tnombrecompleto.Size = New System.Drawing.Size(653, 24)
        Me.tnombrecompleto.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(193, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Trabajador"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.r1)
        Me.Panel2.Controls.Add(Me.r2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1027, 99)
        Me.Panel2.TabIndex = 55
        '
        'r1
        '
        Me.r1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.r1.AutoSize = True
        Me.r1.Checked = True
        Me.r1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.ForeColor = System.Drawing.SystemColors.Control
        Me.r1.Location = New System.Drawing.Point(196, 58)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(87, 21)
        Me.r1.TabIndex = 47
        Me.r1.TabStop = True
        Me.r1.Text = "Trabajador"
        Me.r1.UseVisualStyleBackColor = True
        '
        'r2
        '
        Me.r2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.r2.AutoSize = True
        Me.r2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.ForeColor = System.Drawing.SystemColors.Control
        Me.r2.Location = New System.Drawing.Point(308, 58)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(69, 21)
        Me.r2.TabIndex = 48
        Me.r2.Text = "Periodo"
        Me.r2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(201, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Filtrar por:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(439, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 26)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Reportes"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 697)
        Me.Controls.Add(Me.paneltrabajador)
        Me.Controls.Add(Me.panelperiodo)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.Panel_Contenedor.ResumeLayout(False)
        Me.Panel_Contenedor.PerformLayout()
        CType(Me.tabla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelperiodo.ResumeLayout(False)
        Me.panelperiodo.PerformLayout()
        Me.paneltrabajador.ResumeLayout(False)
        Me.paneltrabajador.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents r1 As RadioButton
    Friend WithEvents r2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents panelperiodo As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cañog As TextBox
    Friend WithEvents paneltrabajador As Panel
    Friend WithEvents tnombrecompleto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tabla1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cañot As TextBox
    Friend WithEvents cmest As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents cmesg As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
