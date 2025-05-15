Public Class Buscador
    Dim padre As Frm_Horas_Extra
    Dim Sqldata As New BaseDeDatos
    Public Sub New(Padre As Frm_Horas_Extra)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.padre = Padre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        padre.Trabajador = tabla1.SelectedCells.Item(0).Value
        RemoveHandler padre.tnombrecompleto.TextChanged, AddressOf padre.TextBox1_TextChanged
        padre.tnombrecompleto.Text = tabla1.SelectedCells.Item(2).Value
        AddHandler padre.tnombrecompleto.TextChanged, AddressOf padre.TextBox1_TextChanged
        padre.tiregular.Text = tabla1.SelectedCells.Item(3).Value
        padre.tsregular.Text = tabla1.SelectedCells.Item(4).Value
        padre.rinicio = tabla1.SelectedCells.Item(5).Value
        padre.rfinal = tabla1.SelectedCells.Item(6).Value
        Dispose()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Sqldata.BuscarTrabajador(tabla1, sender.text)
    End Sub

    Private Sub tabla1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla1.CellContentClick

    End Sub
End Class