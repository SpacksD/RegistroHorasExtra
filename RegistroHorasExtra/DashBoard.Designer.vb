<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos = New RegistroHorasExtra.Datos()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmesg = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ldetalle = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.PeriodoBindingSource
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-29, 216)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(1013, 415)
        Me.Chart1.TabIndex = 0
        '
        'PeriodoBindingSource
        '
        Me.PeriodoBindingSource.DataMember = "Periodo"
        Me.PeriodoBindingSource.DataSource = Me.DatosBindingSource
        '
        'DatosBindingSource
        '
        Me.DatosBindingSource.DataSource = Me.Datos
        Me.DatosBindingSource.Position = 0
        '
        'Datos
        '
        Me.Datos.DataSetName = "Datos"
        Me.Datos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(308, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 26)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Gráfico - Horas Extra"
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.DatosBindingSource
        '
        'cmesg
        '
        Me.cmesg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmesg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmesg.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmesg.FormattingEnabled = True
        Me.cmesg.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cmesg.Location = New System.Drawing.Point(15, 185)
        Me.cmesg.Name = "cmesg"
        Me.cmesg.Size = New System.Drawing.Size(181, 25)
        Me.cmesg.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 26)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Mes"
        '
        'ldetalle
        '
        Me.ldetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ldetalle.AutoSize = True
        Me.ldetalle.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ldetalle.Location = New System.Drawing.Point(202, 184)
        Me.ldetalle.Name = "ldetalle"
        Me.ldetalle.Size = New System.Drawing.Size(77, 26)
        Me.ldetalle.TabIndex = 58
        Me.ldetalle.Text = "Detalle"
        Me.ldetalle.Visible = False
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 795)
        Me.Controls.Add(Me.ldetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmesg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "DashBoard"
        Me.Text = "DashBoard"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents DatosBindingSource As BindingSource
    Friend WithEvents Datos As Datos
    Friend WithEvents PeriodoBindingSource As BindingSource
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents cmesg As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ldetalle As Label
End Class
