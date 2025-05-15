Imports System.Security.Policy

Public Class DashBoard
    Sub CargarGràfico(mes)
        ' Obtener datos del SQLScripts
        Dim SqlScripts As New BaseDeDatos
        Chart1.DataSource = SqlScripts.CargarDatosGeneralChart(1, mes, Date.Now.Year)
        If SqlScripts.CargarDatosGeneralChart(1, mes, Date.Now.Year).Rows.Count = 0 Then
            Chart1.Visible = False
            ldetalle.Text = "En este mes no hay registro de horas extra"
            ldetalle.Visible = True
        Else
            Chart1.Visible = True
            ldetalle.Visible = False
        End If
        ' Configurar propiedades del Chart
        With Chart1
            .Series.Clear() ' Limpiar series anteriores
            .Series.Add("Monto Extra") ' Agregar una serie para MontoExtra
            ' Establecer color y fuente de las etiquetas de la serie
            .Series("Monto Extra").IsVisibleInLegend = False
            .Series("Monto Extra").XValueMember = "Trabajador" ' Columna para valores X
            .Series("Monto Extra").YValueMembers = "MontoExtra" ' Columna para valores Y
            .Series("Monto Extra").ChartType = DataVisualization.Charting.SeriesChartType.Column ' Tipo de gráfico (columnas)
            ' Habilitar etiquetas de datos y configurar su apariencia
            .Series("Monto Extra").IsValueShownAsLabel = True
            .Series("Monto Extra").LabelForeColor = Color.Black
            .Series("Monto Extra").Font = New Font("Arial", 10, FontStyle.Bold)

            ' Configurar área del gráfico y ejes
            With .ChartAreas(0)
                .AxisX.Interval = 1 ' Intervalo de las etiquetas del eje X
                .AxisX.Title = "Trabajador" ' Título del eje X
                .AxisX.TitleForeColor = Color.White
                .AxisX.TitleFont = New Font("Arial", 12, FontStyle.Bold)
                .AxisX.LabelStyle.ForeColor = Color.White
                .AxisX.LabelStyle.Font = New Font("Arial", 10, FontStyle.Regular)

                .AxisY.Title = "Monto Extra" ' Título del eje Y
                .AxisY.TitleForeColor = Color.White
                .AxisY.TitleFont = New Font("Arial", 12, FontStyle.Bold)
                .AxisY.LabelStyle.ForeColor = Color.White
                .AxisY.LabelStyle.Font = New Font("Arial", 10, FontStyle.Regular)
            End With

            .Refresh() ' Refrescar el gráfico
        End With
    End Sub
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Date.Now.Month = 1 Or Date.Now.Month = 12 Then
            cmesg.SelectedIndex = 1
        Else
            cmesg.SelectedIndex = Date.Now.Month - 1
        End If

    End Sub

    Private Sub cmesg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmesg.SelectedIndexChanged
        Dim mes As Integer
        If cmesg.SelectedIndex = 12 Then
            mes = 1
        Else
            mes = cmesg.SelectedIndex + 1
        End If
        CargarGràfico(mes)
    End Sub
End Class