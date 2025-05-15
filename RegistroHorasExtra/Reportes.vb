Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SQLite

Public Class Reportes
    Public trabajador As Integer
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged
        panelperiodo.Visible = False
        paneltrabajador.Visible = True


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles r2.CheckedChanged
        paneltrabajador.Visible = False
        panelperiodo.Visible = True

    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cañot.Text = Date.Now.Year
        If Date.Now.Month = 1 Or Date.Now.Month = 12 Then
            cmest.SelectedIndex = 1
        Else
            cmest.SelectedIndex = Date.Now.Month - 1
        End If
        'generales
        cañog.Text = Date.Now.Year
        If Date.Now.Month = 1 Or Date.Now.Month = 12 Then
            cmesg.SelectedIndex = 1
        Else
            cmesg.SelectedIndex = Date.Now.Month - 1
        End If

    End Sub

    Public Sub tnombrecompleto_TextChanged(sender As Object, e As EventArgs) Handles tnombrecompleto.TextChanged
        Dim buscardordata As New BuscadorReportes(Me)
        buscardordata.TextBox5.Text = sender.text
        buscardordata.TextBox5.Focus()
        buscardordata.TextBox5.SelectionLength = 0
        buscardordata.TextBox5.SelectionStart = buscardordata.TextBox5.SelectionLength + 1
        buscardordata.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim SqlScripts = New BaseDeDatos
        Dim cargador As New Form
        Dim visor As New CrystalDecisions.Windows.Forms.CrystalReportViewer
        cargador.Controls.Add(visor)
        visor.Dock = DockStyle.Fill
        visor.ShowCloseButton = False
        visor.ShowGroupTreeButton = False
        visor.ShowCopyButton = False
        visor.ShowLogo = False
        visor.ShowParameterPanelButton = False
        visor.ShowRefreshButton = False
        visor.ShowGotoPageButton = False
        visor.ShowTextSearchButton = False
        cargador.ShowIcon = False
        Dim mes As Integer

        If r1.Checked Then
            If cmest.SelectedIndex = 12 Then
                mes = 1
            Else
                mes = cmest.SelectedIndex + 1
            End If
            SqlScripts.CargarReportePersonal(SqlScripts.CargarDatosPersonal(trabajador, mes, cañot.Text), visor, mes, cañot.Text, trabajador)
            cargador.Text = "Reporte Generado"
            cargador.WindowState = FormWindowState.Maximized
            cargador.Show()
        ElseIf r2.Checked Then
            If cmesg.SelectedIndex = 12 Then
                mes = 1
            Else
                mes = cmesg.SelectedIndex + 1
            End If
            SqlScripts.CargarReporteGeneral(SqlScripts.CargarDatosGeneral(trabajador, mes, cañog.Text), visor, mes, cañog.Text)
            cargador.Text = "Reporte Generado"
            cargador.WindowState = FormWindowState.Maximized
            cargador.Show()
        End If




    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim SqlScripts = New BaseDeDatos
        Dim mes As Integer
        If cmest.SelectedIndex = 12 Then
            mes = 1
        Else
            mes = cmest.SelectedIndex + 1
        End If
        SqlScripts.ListarReporteHorasExtraPersonal(tabla1, trabajador, mes, cañot.Text)
        tabla1.AutoResizeColumns()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim SqlScripts = New BaseDeDatos
        Dim mes As Integer
        If cmesg.SelectedIndex = 12 Then
            mes = 1
        Else
            mes = cmesg.SelectedIndex + 1
        End If
        SqlScripts.ListarReporteHorasExtraGeneral(tabla1, mes, cañot.Text)
        tabla1.AutoResizeColumns()
    End Sub

    Private Sub cañog_TextChanged(sender As Object, e As EventArgs) Handles cañog.TextChanged

    End Sub

    Private Sub cañog_LostFocus(sender As Object, e As EventArgs) Handles cañog.LostFocus
        If IsNumeric(sender.text) = False Then
            MsgBox("Verifique el año ingresado e intente nuevamente")
            cañog.Focus()
        End If
    End Sub

    Private Sub cañot_TextChanged(sender As Object, e As EventArgs) Handles cañot.TextChanged

    End Sub

    Private Sub cañot_LostFocus(sender As Object, e As EventArgs) Handles cañot.LostFocus
        If IsNumeric(sender.text) = False Then
            MsgBox("Verifique el año ingresado e intente nuevamente")
            cañot.Focus()
        End If
    End Sub
End Class