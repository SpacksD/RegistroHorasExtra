Public Class Frm_Personal
    Dim data As New BaseDeDatos
    Dim PersonalSeleccionado As Integer
    Dim seleccionado As Boolean = False
    Dim funciones As New Funcionalidades
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If tnombrecompleto.Text = "" Or tdoc.Text = "" Or tcargo.Text = "" Or tsueldo.Text = "" Then
            MsgBox("Verifique los datos: nombre completo, número de documento, cargo o sueldo e intente nuevamente")
            Exit Sub
        End If
        data.InsertarPersonal(
            tnombrecompleto.Text, tdoc.Text, temail.Text, tcargo.Text, ttelefono.Text, tsueldo.Text, testado.Text, data.DevolverIdHorario(chorario.Text))
        LimpiarCampos()
        data.ListarPersonal(tabla1)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If tnombrecompleto.Text = "" Or tdoc.Text = "" Or tcargo.Text = "" Or tsueldo.Text = "" Then
            MsgBox("Verifique los datos: nombre completo, número de documento, cargo o sueldo e intente nuevamente")
            Exit Sub
        End If
        If seleccionado = True Then
            data.ActualizarPersonal(
            PersonalSeleccionado, tdoc.Text, tnombrecompleto.Text, temail.Text, tcargo.Text, ttelefono.Text, tsueldo.Text, testado.Text, data.DevolverIdHorario(chorario.Text))
            seleccionado = False
            LimpiarCampos()
            data.ListarPersonal(tabla1)
        Else
            MsgBox("Primero seleccione un registro para modificar")
        End If

    End Sub

    Private Sub Frm_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data.ListarPersonal(tabla1)
        data.ListarHorariosEnComboBox(chorario)
    End Sub

    Private Sub tabla1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If
        PersonalSeleccionado = tabla1.SelectedCells.Item(0).Value
        seleccionado = True
        tdoc.Text = tabla1.SelectedCells.Item(1).Value
        tnombrecompleto.Text = tabla1.SelectedCells.Item(2).Value
        temail.Text = tabla1.SelectedCells.Item(3).Value
        tcargo.Text = tabla1.SelectedCells.Item(4).Value
        ttelefono.Text = tabla1.SelectedCells.Item(5).Value
        tsueldo.Text = tabla1.SelectedCells.Item(6).Value
        For Each item As Object In testado.Items
            If tabla1.SelectedCells(7).Value.ToString().ToLower = item.ToString().ToLower() Then
                testado.SelectedItem = item
                Exit For
            End If
        Next
        For Each item As Object In chorario.Items
            If tabla1.SelectedCells(8).Value.ToString().ToLower = item.ToString().ToLower() Then
                chorario.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    Private Sub tsueldo_TextChanged(sender As Object, e As EventArgs) Handles tsueldo.TextChanged
        If sender.text = "" Then
            Exit Sub
        End If
        If IsNumeric(sender.text) = False Then
            MsgBox("Verifique el sueldo e intente nuevamente", Title:="Monto del sueldo incorrecto")
            tsueldo.Focus()
        End If
    End Sub
    Sub LimpiarCampos()
        tnombrecompleto.Clear()
        tdoc.Clear()
        ttelefono.Clear()
        temail.Clear()
        testado.SelectedIndex = 0
        tcargo.Clear()
        tsueldo.Clear()
        tbusqueda.Clear()
        seleccionado = False
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If seleccionado = True Then

            If MsgBox("¿Está seguro que desea eliminar el trabajador del registro?", Buttons:=MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                data.EliminarPersonal(PersonalSeleccionado)
                seleccionado = False
                data.ListarPersonal(tabla1)
            End If

        Else
            MsgBox("Primero seleccione un registro para eliminar")
        End If

    End Sub

    Private Sub tsueldo_LostFocus(sender As Object, e As EventArgs) Handles tsueldo.LostFocus

    End Sub

    Private Sub tbusqueda_TextChanged(sender As Object, e As EventArgs) Handles tbusqueda.TextChanged
        data.FiltrarPersonal(tabla1, sender.text)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        LimpiarCampos()
    End Sub

    Private Sub tabla1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellContentClick

    End Sub

    Private Sub temail_TextChanged(sender As Object, e As EventArgs) Handles temail.TextChanged

    End Sub

    Private Sub temail_LostFocus(sender As Object, e As EventArgs) Handles temail.LostFocus
        If sender.text = "" Then
            Exit Sub
        End If
        If sender.text.ToString.Contains("@") = False Then
            MsgBox("EL correo electrónico debe contener el signo "" @ "", verifique e intente nuevamente")
            sender.Focus
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        funciones.ExportarDataGridViewAExcelYAbrir(tabla1)
    End Sub

    Private Sub Panel_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Contenedor.Paint

    End Sub
End Class