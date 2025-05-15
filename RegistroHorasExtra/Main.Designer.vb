<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.IconoNotificación = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuContextualPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeLiquidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriasClínicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZonaPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconoEsquina = New System.Windows.Forms.PictureBox()
        Me.Panelprincipal = New System.Windows.Forms.Panel()
        Me.BtnPruebas = New FontAwesome.Sharp.IconButton()
        Me.BtnReportes = New FontAwesome.Sharp.IconButton()
        Me.BtnHorasExtra = New FontAwesome.Sharp.IconButton()
        Me.BtnHorarios = New FontAwesome.Sharp.IconButton()
        Me.BtnPersonal = New FontAwesome.Sharp.IconButton()
        Me.inicio = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        Me.MenuContextualPrincipal.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.IconoEsquina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelprincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PanelContenedor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(193, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1606, 1006)
        Me.Panel2.TabIndex = 8
        '
        'PanelContenedor
        '
        Me.PanelContenedor.AutoScroll = True
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1606, 1006)
        Me.PanelContenedor.TabIndex = 3
        '
        'IconoNotificación
        '
        Me.IconoNotificación.Icon = CType(resources.GetObject("IconoNotificación.Icon"), System.Drawing.Icon)
        Me.IconoNotificación.Text = "Horas Extras"
        Me.IconoNotificación.Visible = True
        '
        'MenuContextualPrincipal
        '
        Me.MenuContextualPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChatToolStripMenuItem, Me.ListaDeLiquidacionesToolStripMenuItem, Me.HistoriasClínicasToolStripMenuItem, Me.ZonaPersonalToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuContextualPrincipal.Name = "MenuContextualPrincipal"
        Me.MenuContextualPrincipal.Size = New System.Drawing.Size(192, 136)
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ChatToolStripMenuItem.Text = "Pacientes en Atención"
        '
        'ListaDeLiquidacionesToolStripMenuItem
        '
        Me.ListaDeLiquidacionesToolStripMenuItem.Name = "ListaDeLiquidacionesToolStripMenuItem"
        Me.ListaDeLiquidacionesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ListaDeLiquidacionesToolStripMenuItem.Text = "Lista de Liquidaciones"
        '
        'HistoriasClínicasToolStripMenuItem
        '
        Me.HistoriasClínicasToolStripMenuItem.Name = "HistoriasClínicasToolStripMenuItem"
        Me.HistoriasClínicasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HistoriasClínicasToolStripMenuItem.Text = "Historias Clínicas"
        '
        'ZonaPersonalToolStripMenuItem
        '
        Me.ZonaPersonalToolStripMenuItem.Name = "ZonaPersonalToolStripMenuItem"
        Me.ZonaPersonalToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ZonaPersonalToolStripMenuItem.Text = "Zona Personal"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.IconoEsquina)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 99)
        Me.Panel3.TabIndex = 0
        '
        'IconoEsquina
        '
        Me.IconoEsquina.Image = CType(resources.GetObject("IconoEsquina.Image"), System.Drawing.Image)
        Me.IconoEsquina.Location = New System.Drawing.Point(58, 12)
        Me.IconoEsquina.Name = "IconoEsquina"
        Me.IconoEsquina.Size = New System.Drawing.Size(70, 70)
        Me.IconoEsquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconoEsquina.TabIndex = 0
        Me.IconoEsquina.TabStop = False
        '
        'Panelprincipal
        '
        Me.Panelprincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panelprincipal.Controls.Add(Me.BtnPruebas)
        Me.Panelprincipal.Controls.Add(Me.BtnReportes)
        Me.Panelprincipal.Controls.Add(Me.BtnHorasExtra)
        Me.Panelprincipal.Controls.Add(Me.BtnHorarios)
        Me.Panelprincipal.Controls.Add(Me.BtnPersonal)
        Me.Panelprincipal.Controls.Add(Me.inicio)
        Me.Panelprincipal.Controls.Add(Me.Panel3)
        Me.Panelprincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelprincipal.Location = New System.Drawing.Point(0, 0)
        Me.Panelprincipal.Name = "Panelprincipal"
        Me.Panelprincipal.Size = New System.Drawing.Size(193, 1006)
        Me.Panelprincipal.TabIndex = 6
        '
        'BtnPruebas
        '
        Me.BtnPruebas.BackColor = System.Drawing.Color.Transparent
        Me.BtnPruebas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPruebas.FlatAppearance.BorderSize = 0
        Me.BtnPruebas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnPruebas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPruebas.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPruebas.ForeColor = System.Drawing.Color.Tomato
        Me.BtnPruebas.IconChar = FontAwesome.Sharp.IconChar.TableList
        Me.BtnPruebas.IconColor = System.Drawing.Color.Tomato
        Me.BtnPruebas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnPruebas.IconSize = 25
        Me.BtnPruebas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPruebas.Location = New System.Drawing.Point(0, 274)
        Me.BtnPruebas.Name = "BtnPruebas"
        Me.BtnPruebas.Size = New System.Drawing.Size(193, 35)
        Me.BtnPruebas.TabIndex = 18
        Me.BtnPruebas.Text = "Datos de Prueba"
        Me.BtnPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPruebas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPruebas.UseVisualStyleBackColor = False
        '
        'BtnReportes
        '
        Me.BtnReportes.BackColor = System.Drawing.Color.Transparent
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReportes.ForeColor = System.Drawing.Color.SteelBlue
        Me.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.BtnReportes.IconColor = System.Drawing.Color.SteelBlue
        Me.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnReportes.IconSize = 25
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 239)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(193, 35)
        Me.BtnReportes.TabIndex = 17
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReportes.UseVisualStyleBackColor = False
        '
        'BtnHorasExtra
        '
        Me.BtnHorasExtra.BackColor = System.Drawing.Color.Transparent
        Me.BtnHorasExtra.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHorasExtra.FlatAppearance.BorderSize = 0
        Me.BtnHorasExtra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnHorasExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnHorasExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHorasExtra.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHorasExtra.ForeColor = System.Drawing.Color.Thistle
        Me.BtnHorasExtra.IconChar = FontAwesome.Sharp.IconChar.WaveSquare
        Me.BtnHorasExtra.IconColor = System.Drawing.Color.Thistle
        Me.BtnHorasExtra.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnHorasExtra.IconSize = 25
        Me.BtnHorasExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHorasExtra.Location = New System.Drawing.Point(0, 204)
        Me.BtnHorasExtra.Name = "BtnHorasExtra"
        Me.BtnHorasExtra.Size = New System.Drawing.Size(193, 35)
        Me.BtnHorasExtra.TabIndex = 16
        Me.BtnHorasExtra.Text = "Horas Extra"
        Me.BtnHorasExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHorasExtra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHorasExtra.UseVisualStyleBackColor = False
        '
        'BtnHorarios
        '
        Me.BtnHorarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnHorarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHorarios.FlatAppearance.BorderSize = 0
        Me.BtnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHorarios.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHorarios.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.BtnHorarios.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        Me.BtnHorarios.IconColor = System.Drawing.Color.DarkTurquoise
        Me.BtnHorarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnHorarios.IconSize = 25
        Me.BtnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHorarios.Location = New System.Drawing.Point(0, 169)
        Me.BtnHorarios.Name = "BtnHorarios"
        Me.BtnHorarios.Size = New System.Drawing.Size(193, 35)
        Me.BtnHorarios.TabIndex = 15
        Me.BtnHorarios.Text = "Horarios"
        Me.BtnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHorarios.UseVisualStyleBackColor = False
        '
        'BtnPersonal
        '
        Me.BtnPersonal.BackColor = System.Drawing.Color.Transparent
        Me.BtnPersonal.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPersonal.FlatAppearance.BorderSize = 0
        Me.BtnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersonal.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPersonal.ForeColor = System.Drawing.Color.LightGreen
        Me.BtnPersonal.IconChar = FontAwesome.Sharp.IconChar.UserGroup
        Me.BtnPersonal.IconColor = System.Drawing.Color.LightGreen
        Me.BtnPersonal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnPersonal.IconSize = 25
        Me.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPersonal.Location = New System.Drawing.Point(0, 134)
        Me.BtnPersonal.Name = "BtnPersonal"
        Me.BtnPersonal.Size = New System.Drawing.Size(193, 35)
        Me.BtnPersonal.TabIndex = 14
        Me.BtnPersonal.Text = "Personal"
        Me.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPersonal.UseVisualStyleBackColor = False
        '
        'inicio
        '
        Me.inicio.BackColor = System.Drawing.Color.Transparent
        Me.inicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.inicio.FlatAppearance.BorderSize = 0
        Me.inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inicio.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold)
        Me.inicio.ForeColor = System.Drawing.Color.LightCyan
        Me.inicio.IconChar = FontAwesome.Sharp.IconChar.Dashboard
        Me.inicio.IconColor = System.Drawing.Color.LightCyan
        Me.inicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.inicio.IconSize = 25
        Me.inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inicio.Location = New System.Drawing.Point(0, 99)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(193, 35)
        Me.inicio.TabIndex = 19
        Me.inicio.Text = "Inicio"
        Me.inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.inicio.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1799, 1006)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panelprincipal)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.Panel2.ResumeLayout(False)
        Me.MenuContextualPrincipal.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.IconoEsquina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelprincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel2 As Panel
    Friend WithEvents IconoNotificación As NotifyIcon
    Friend WithEvents MenuContextualPrincipal As ContextMenuStrip
    Friend WithEvents ChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeLiquidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriasClínicasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZonaPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconoEsquina As PictureBox
    Friend WithEvents Panelprincipal As Panel
    Friend WithEvents BtnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnHorasExtra As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnHorarios As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPersonal As FontAwesome.Sharp.IconButton
    Public WithEvents PanelContenedor As Panel
    Friend WithEvents BtnPruebas As FontAwesome.Sharp.IconButton
    Friend WithEvents inicio As FontAwesome.Sharp.IconButton
End Class
