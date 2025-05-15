Public Class Frm_Horarios
    Dim data As New BaseDeDatos
    Dim horarioseleccionado As Integer
    Dim seleccionado As Boolean = False
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If tdescripcion.Text = "" Or thorainicio.Text = "" Or thorafin.Text = "" Or trinicio.Text = "" Or trfin.Text = "" Then
            MsgBox("Verifique los datos ingresados, e intente nuevamente, recuerde que debe llenar todos los campos", Title:="Faltan datos")
            Exit Sub
        End If
        data.InsertarHorario(tdescripcion.Text, thorainicio.Text, thorafin.Text, trinicio.Text, trfin.Text)
        data.ListarHorarios(tabla1)
        LimpiarCampos()
    End Sub

    Private Sub Frm_Horarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data.ListarHorarios(tabla1)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If tdescripcion.Text = "" Or thorainicio.Text = "" Or thorafin.Text = "" Or trinicio.Text = "" Or trfin.Text = "" Then
            MsgBox("Verifique los datos ingresados, e intente nuevamente, recuerde que debe llenar todos los campos", Title:="Faltan datos")
            Exit Sub
        End If

        If seleccionado = True Then
            data.ActualizarHorario(horarioseleccionado, tdescripcion.Text, thorainicio.Text, thorafin.Text, trinicio.Text, trfin.Text)
            MsgBox("Modificado correctamente", Title:="aviso")
            LimpiarCampos()
            seleccionado = False
            data.ListarHorarios(tabla1)
        Else
            MsgBox("Primero seleccione un registro para modificar")
        End If

    End Sub

    Private Sub tabla1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellContentClick

    End Sub

    Private Sub tabla1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        seleccionado = True
        horarioseleccionado = tabla1.SelectedCells.Item(0).Value

        If e.RowIndex = -1 Then
            Exit Sub
        End If
        tdescripcion.Text = tabla1.SelectedCells.Item(1).Value
        thorainicio.Text = tabla1.SelectedCells.Item(2).Value
        thorafin.Text = tabla1.SelectedCells.Item(3).Value
        trinicio.Text = tabla1.SelectedCells.Item(4).Value
        trfin.Text = tabla1.SelectedCells.Item(5).Value

    End Sub
    Sub LimpiarCampos()
        tdescripcion.Clear()
        thorafin.Clear()
        thorainicio.Clear()
        trfin.Clear()
        trinicio.Clear()
        tbusqueda.Clear()
        seleccionado = False
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        LimpiarCampos()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If seleccionado = True Then
            data.EliminarHorario(horarioseleccionado)
            MsgBox("Horario Eliminado Correctamente", Title:="aviso")
            LimpiarCampos()
            seleccionado = False
            data.ListarHorarios(tabla1)
        Else
            MsgBox("Primero seleccione un registro para elimminar")
        End If
    End Sub

    Private Sub tdescripcion_TextChanged(sender As Object, e As EventArgs) Handles tdescripcion.TextChanged

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim funciones As New Funcionalidades
        funciones.ExportarDataGridViewAExcelYAbrir(tabla1)
    End Sub
End Class