Imports System.Text.RegularExpressions
Imports ClosedXML.Excel.CalcEngine

Public Class Frm_Horas_Extra
    Public Trabajador, registro As Integer
    Public hinicio, hfinal, rinicio, rfinal As String


    Private Sub tiregular_TextChanged(sender As Object, e As EventArgs) Handles tiregular.TextChanged, tsregular.TextChanged
        If Trim(sender.text = "") Then
            sender.backcolor = sender.DefaultBackColor
        Else
            sender.backcolor = Color.LightGreen
        End If
    End Sub
    Function FechaEnString(datetimep As DateTimePicker) As String
        Return datetimep.Value.ToString("yyyyMMdd")
    End Function
    Function EsFormatoVálido(input As String) As Boolean
        Dim timePattern As String = "^\d{2}:\d{2}$"
        Dim regex As New Regex(timePattern)

        If regex.IsMatch(input) Then
            Dim parts() As String = input.Split(":")
            Dim hours As Integer = Convert.ToInt32(parts(0))
            Dim minutes As Integer = Convert.ToInt32(parts(1))

            If hours >= 0 AndAlso hours <= 23 AndAlso minutes >= 0 AndAlso minutes <= 59 Then
                Return True
            End If
        End If

        Return False
    End Function
    Function ValidarCampos() As Boolean
        If Len(Trim(tnombrecompleto.Text)) = 0 Then
            MsgBox("Verifique el trabajador e intente nuevamente", Title:="Faltan Datos")
            Return False
        End If
        If Trabajador = 0 Then
            MsgBox("Verifique el trabajador e intente nuevamente", Title:="Faltan Datos")
            Return False
        End If
        If tiregular.Text = "" Or tsregular.Text = "" Or tinicio.Text = "" Or tfin.Text = "" Then
            MsgBox("Verifique los datos de la hora de ingreso y salida regular", Title:="Faltan Datos")
            Return False
        End If
        Dim time1 As TimeSpan
        Dim time2 As TimeSpan
        Try
            time1 = TimeSpan.Parse(tinicio.Text)
            time2 = TimeSpan.Parse(tfin.Text)
        Catch ex As Exception
            MsgBox("Verifique el formato del as fechas ingresadas e intente nuevamente")
            Return False
        End Try

        If time1 > time2 Or time1 = time2 Then
            MsgBox("Las hora de ingreso no puede ser mayor o igual a la hora de salida, si el registro es de un día para otro, considere el fin de este día a las 23:59 hroas e inicie un nuevo registro al día siguiente con ingreso a las 00:00 horas")
        Else

        End If
        If Len(Trim(rinicio)) = 0 And Len(Trim(rfinal)) = 0 Then
            MsgBox("Los datos del refrigerio no están cargados correctamente, vefirique el registro del trabajador e intente nuevamente", Title:="Faltan Datos")
            Return False
        End If
        Return True
    End Function
    Function ValidarFormato() As Boolean
        If EsFormatoVálido(tiregular.Text) = False Or EsFormatoVálido(tsregular.Text) = False Or EsFormatoVálido(tinicio.Text) = False Or EsFormatoVálido(tfin.Text) = False Then
            MsgBox("Verifique el formato de la hora en los campos correspondientes, recuerde que el formato es en 24 horas", Title:="Faltan Datos")
            Return False
        End If
        Return True
    End Function
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        'validaciones de campos
        If Not ValidarCampos() Then
            Exit Sub
        End If
        If Not ValidarFormato() Then
            Exit Sub
        End If
        'nueva instancia para las consultas de sql
        Dim data = New BaseDeDatos()
        Dim refri As Integer
        If crefri.Checked Then
            refri = 1
        Else
            refri = 0
        End If
        Dim sueldo As Double
        If IsNothing(data.DevolverSueldo(Trabajador)) Then
            Exit Sub
        Else
            sueldo = data.DevolverSueldo(Trabajador)
        End If
        Dim tiemporegulardeinicio As TimeSpan = TimeSpan.Parse(tiregular.Text)
        Dim tiemporegulardesalida As TimeSpan = TimeSpan.Parse(tsregular.Text)
        Dim tiempoingreso As TimeSpan = TimeSpan.Parse(tinicio.Text)
        Dim tiemposalida As TimeSpan = TimeSpan.Parse(tfin.Text)
        Dim inicioderegrigerio As TimeSpan = TimeSpan.Parse(rinicio)
        Dim finderegrigerio As TimeSpan = TimeSpan.Parse(rfinal)
        Dim tiempoTrabajado As TimeSpan = tiemposalida - tiempoingreso
        Dim tiempoRefrigerio As TimeSpan = finderegrigerio - inicioderegrigerio
        Dim tiempoRegularTrabajado As TimeSpan = tiemporegulardesalida - tiemporegulardeinicio
        Dim horasExtras As TimeSpan
        If refri = 1 Then
            horasExtras = (tiempoTrabajado - tiempoRegularTrabajado) + tiempoRefrigerio
        Else
            horasExtras = (tiempoTrabajado - tiempoRegularTrabajado)
        End If
        If horasExtras < TimeSpan.Zero Then
            horasExtras = TimeSpan.Zero
        End If
        Dim minutosExtras As Integer = CInt(horasExtras.TotalMinutes)
        Dim totalMinutosExtras As Integer = minutosExtras
        MsgBox(sueldo & " - " & totalMinutosExtras)
        Dim montoextra = (((sueldo / 30) / 8) / 60) * totalMinutosExtras
        montoextra = Math.Round(montoextra, 2, MidpointRounding.AwayFromZero)
        data.InsertarHorasExtra(Trabajador, tinicio.Text, tfin.Text, FechaEnString(tfecha), refri, totalMinutosExtras, montoextra)
        data.ListarHorasExtra(tabla1)
        limpiar()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim funciones As New Funcionalidades
        funciones.ExportarDataGridViewAExcelYAbrir(tabla1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub tinicio_TextChanged(sender As Object, e As EventArgs) Handles tinicio.TextChanged, tfin.TextChanged
        If Trim(sender.text = "") Then
            sender.backcolor = Color.IndianRed
        Else
            sender.backcolor = sender.DefaultBackColor
        End If
    End Sub

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tnombrecompleto.TextChanged
        Dim buscardordata As New Buscador(Me)
        buscardordata.TextBox5.Text = sender.text
        buscardordata.TextBox5.Focus()
        buscardordata.TextBox5.SelectionLength = 0
        buscardordata.TextBox5.SelectionStart = buscardordata.TextBox5.SelectionLength + 1
        buscardordata.Show()
    End Sub

    Private Sub Frm_Horas_Extra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data = New BaseDeDatos()
        tinicio.BackColor = Color.IndianRed
        tfin.BackColor = Color.IndianRed
        data.ListarHorasExtra(tabla1)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Dim data = New BaseDeDatos()
        If IsNothing(registro) Or registro = "0" Then
            MsgBox("Primero selecccione un registro")
        Else
            data.EliminarHorasExtra(registro)
            data.ListarHorasExtra(tabla1)
        End If
        limpiar()
    End Sub

    Sub limpiar()
        RemoveHandler tnombrecompleto.TextChanged, AddressOf TextBox1_TextChanged
        tnombrecompleto.Clear()
        AddHandler tnombrecompleto.TextChanged, AddressOf TextBox1_TextChanged
        registro = 0
        Trabajador = 0
        tinicio.Clear()
        tfin.Clear()
        tiregular.Clear()
        tsregular.Clear()
        hinicio = ""
        hfinal = ""
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        limpiar()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim data = New BaseDeDatos()
        If sender.text = "" Then
            data.ListarHorasExtra(tabla1)
        Else
            data.BuscarEnHorasExtra(tabla1, sender.text)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub tabla1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellContentClick

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Not ValidarCampos() Then
            Exit Sub
        End If
        If Not ValidarFormato() Then
            Exit Sub
        End If
        'nueva instancia para las consultas de sql
        Dim data = New BaseDeDatos()
        Dim refri As Integer
        If crefri.Checked Then
            refri = 1
        Else
            refri = 0
        End If
        Dim sueldo As Double
        If IsNothing(data.DevolverSueldo(Trabajador)) Then
            Exit Sub
        Else
            sueldo = data.DevolverSueldo(Trabajador)
        End If
        Dim tiemporegulardeinicio As TimeSpan = TimeSpan.Parse(tiregular.Text)
        Dim tiemporegulardesalida As TimeSpan = TimeSpan.Parse(tsregular.Text)
        Dim tiempoingreso As TimeSpan = TimeSpan.Parse(tinicio.Text)
        Dim tiemposalida As TimeSpan = TimeSpan.Parse(tfin.Text)
        Dim inicioderegrigerio As TimeSpan = TimeSpan.Parse(rinicio)
        Dim finderegrigerio As TimeSpan = TimeSpan.Parse(rfinal)
        Dim tiempoTrabajado As TimeSpan = tiemposalida - tiempoingreso
        Dim tiempoRefrigerio As TimeSpan = finderegrigerio - inicioderegrigerio
        Dim tiempoRegularTrabajado As TimeSpan = tiemporegulardesalida - tiemporegulardeinicio
        Dim horasExtras As TimeSpan
        If refri = 1 Then
            horasExtras = (tiempoTrabajado - tiempoRegularTrabajado) + tiempoRefrigerio
        Else
            horasExtras = (tiempoTrabajado - tiempoRegularTrabajado)
        End If
        If horasExtras < TimeSpan.Zero Then
            horasExtras = TimeSpan.Zero
        End If
        Dim minutosExtras As Integer = CInt(horasExtras.TotalMinutes)
        Dim totalMinutosExtras As Integer = minutosExtras
        Dim montoextra = (((sueldo / 30) / 8) / 60) * totalMinutosExtras
        montoextra = Math.Round(montoextra, 2, MidpointRounding.AwayFromZero)
        data.ActualizarHorasExtra(registro, Trabajador, tinicio.Text, tfin.Text, FechaEnString(tfecha), refri, totalMinutosExtras, montoextra)
        data.ListarHorasExtra(tabla1)
        limpiar()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        Dim data = New BaseDeDatos()
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        Dim codigo As Integer
        codigo = data.DevolverId_Personal(tabla1.SelectedCells.Item(1).Value)
        registro = tabla1.SelectedCells.Item(0).Value
        Trabajador = codigo
        Dim datoshorario = data.DevolverDatosHorario(Trabajador)
        rinicio = datoshorario(0)(0)
        rfinal = datoshorario(0)(1)
        tiregular.Text = datoshorario(0)(2)
        tsregular.Text = datoshorario(0)(3)
        RemoveHandler tnombrecompleto.TextChanged, AddressOf TextBox1_TextChanged
        tnombrecompleto.Text = data.DevolverNombreCompletoPersonal(codigo)
        AddHandler tnombrecompleto.TextChanged, AddressOf TextBox1_TextChanged
        tinicio.Text = tabla1.SelectedCells.Item(2).Value
        tfin.Text = tabla1.SelectedCells.Item(3).Value
        tfecha.Value = Date.Parse(tabla1.SelectedCells.Item(4).Value)
        If tabla1.SelectedCells.Item(5).Value = "1" Then
            crefri.Checked = True
        Else
            crefri.Checked = False
        End If

    End Sub

    Private Sub tabla1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        tabla1.AutoResizeColumns()
    End Sub

    Private Sub tabla1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        tabla1.AutoResizeColumns()
    End Sub
End Class