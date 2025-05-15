Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.Windows.Interop
Imports FontAwesome.Sharp

Public Class Main
    Private paneloculto As Boolean
    Public Property Xpos As Double
    Public Property Ypos As Double
    Dim data As New BaseDeDatos

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data.CreateDatabase()
#If DEBUG Then
        BtnPruebas.Visible = True
#Else
    BtnPruebas.Visible = False
#End If
        PanelContenedor.Controls.Clear()
        Dim dash As New DashBoard With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        Pintar(inicio)
        PanelContenedor.Controls.Add(dash)
        dash.Dock = DockStyle.Fill
        dash.Show()
    End Sub
    Sub Mostrarpanel()
        paneloculto = False
        BtnPersonal.Text = "Personal"
        BtnHorarios.Text = "Horarios"
        BtnHorasExtra.Text = "Horas Extras"
        BtnReportes.Text = "Reportes"
        inicio.Text = "Inicio"
        BtnPruebas.Text = "Datos de Prueba"
    End Sub
    Sub AumentarPanel()
        IconoEsquina.Size = New Size(70, 70)
        Panelprincipal.Size = New Size(193, 193)
        Xpos = (Panel3.Width / 2) - (IconoEsquina.Width / 2)
        Ypos = (Panel3.Height / 2) - (IconoEsquina.Height / 2)
        IconoEsquina.Location = New Point(Xpos, Ypos)
    End Sub
    Sub Reducirpanel()
        Panelprincipal.Size = New Size(40, 193)
        IconoEsquina.Size = New Size(30, 30)
        Xpos = (Panel3.Width / 2) - (IconoEsquina.Width / 2)
        Ypos = (Panel3.Height / 2) - (IconoEsquina.Height / 2)
        IconoEsquina.Location = New Point(Xpos, Ypos)
    End Sub

    Sub Ocultarpanel()
        paneloculto = True
        BtnPersonal.Text = ""
        BtnHorarios.Text = ""
        BtnHorasExtra.Text = ""
        BtnReportes.Text = ""
        inicio.Text = ""
        BtnPruebas.Text = ""
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles IconoEsquina.Click
        If paneloculto = True Then
            Mostrarpanel()
            AumentarPanel()
        Else
            Ocultarpanel()
            Reducirpanel()
            ' aqui pendiente ocultar - PENDIENTE REEMPLAZOS EN DNI
        End If
    End Sub

    Private Sub BtnPersonal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPersonal_Click_1(sender As Object, e As EventArgs) Handles BtnPersonal.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        Dim personal As New Frm_Personal With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(personal)
        personal.Dock = DockStyle.Fill
        personal.Show()
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        Dim Horarios As New Frm_Horarios With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(Horarios)
        Horarios.Dock = DockStyle.Fill
        Horarios.Show()
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        Dim Horarios As New Reportes With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(Horarios)
        Horarios.Dock = DockStyle.Fill
        Horarios.Show()
    End Sub

    Private Sub BtnHorasExtra_Click(sender As Object, e As EventArgs) Handles BtnHorasExtra.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        Dim Horarios As New Frm_Horas_Extra With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(Horarios)
        Horarios.Dock = DockStyle.Fill
        Horarios.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnPruebas.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        Dim revisador As New Revisor With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(revisador)
        revisador.Dock = DockStyle.Fill
        revisador.Show()
    End Sub
    Sub Despintar()
        inicio.BackColor = Color.Transparent
        BtnPersonal.BackColor = Color.Transparent
        BtnHorarios.BackColor = Color.Transparent
        BtnHorasExtra.BackColor = Color.Transparent
        BtnReportes.BackColor = Color.Transparent
        BtnPruebas.BackColor = Color.Transparent
    End Sub
    Sub Pintar(sender As IconButton)
        Despintar()
        sender.BackColor = Color.FromArgb(0, 68, 84)
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles inicio.Click
        Pintar(sender)
        PanelContenedor.Controls.Clear()
        ' Crear instancia del formulario Dashboard
        Dim dash As New DashBoard With {
            .TopLevel = False,
            .ControlBox = False,
            .FormBorderStyle = FormBorderStyle.None
        }
        PanelContenedor.Controls.Add(dash)
        dash.Dock = DockStyle.Fill
        dash.Show()
    End Sub
End Class