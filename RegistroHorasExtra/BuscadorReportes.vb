Public Class BuscadorReportes
    Dim padre As Reportes
    Dim Sqldata As New BaseDeDatos
    Public Sub New(Padre As Reportes)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.padre = Padre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub BuscadorReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        padre.Trabajador = tabla1.SelectedCells.Item(0).Value
        RemoveHandler padre.tnombrecompleto.TextChanged, AddressOf padre.tnombrecompleto_TextChanged
        padre.tnombrecompleto.Text = tabla1.SelectedCells.Item(2).Value
        AddHandler padre.tnombrecompleto.TextChanged, AddressOf padre.tnombrecompleto_TextChanged

        Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Sqldata.BuscarTrabajador(tabla1, sender.text)
    End Sub
End Class