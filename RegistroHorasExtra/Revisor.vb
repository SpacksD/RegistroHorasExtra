Public Class Revisor
    Dim data As New BaseDeDatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With data
            .InsertarHorario("Turno Mañana", "08:00", "16:00", "12:00", "13:00")
            .InsertarHorario("Turno Tarde", "12:00", "20:00", "15:00", "16:00")

            .InsertarPersonal("JUAN PÉREZ", "12345678", "JUANPEREZ@EXAMPLE.COM", "ANALISTA DE DATOS", "912345678", "2500", "Activo", 1)
            .InsertarPersonal("MARÍA LÓPEZ", "98765432", "MARIALOPEZ@EXAMPLE.COM", "GERENTE DE VENTAS", "987654321", "3500", "Activo", 1)
            .InsertarPersonal("CARLOS GARCÍA", "56789123", "CARLOSGARCIA@EXAMPLE.COM", "DESARROLLADOR SENIOR", "954433221", "4000", "Activo", 1)
            .InsertarPersonal("ANA MARTÍNEZ", "45678901", "ANAMARTINEZ@EXAMPLE.COM", "DISEÑADOR GRÁFICO", "932211445", "2800", "Activo", 1)
            .InsertarPersonal("PEDRO RODRÍGUEZ", "78901234", "PEDRORODRIGUEZ@EXAMPLE.COM", "ANALISTA FINANCIERO", "92334455", "3800", "Activo", 1)
            .InsertarPersonal("LAURA FERNÁNDEZ", "34567890", "LAURAFERNANDEZ@EXAMPLE.COM", "CONSULTOR DE RECURSOS HUMANOS", "998776655", "3200", "Activo", 2)
            .InsertarPersonal("JAVIER SÁNCHEZ", "65432109", "JAVIERSANCHEZ@EXAMPLE.COM", "INGENIERO DE SOFTWARE", "967889900", "4200", "Activo", 1)
            .InsertarPersonal("SOFÍA PÉREZ", "21098765", "SOFIAPEREZ@EXAMPLE.COM", "MARKETING MANAGER", "912233445", "3700", "Activo", 1)
            .InsertarPersonal("DANIEL GÓMEZ", "43210987", "DANIELGOMEZ@EXAMPLE.COM", "PROJECT MANAGER", "978899011", "4500", "Activo", 1)
            .InsertarPersonal("ELENA RUIZ", "87654321", "ELENARUIZ@EXAMPLE.COM", "ADMINISTRATIVO", "934455667", "2500", "Activo", 1)
            .InsertarPersonal("DIEGO CASTRO", "54321098", "DIEGOCASTRO@EXAMPLE.COM", "DESARROLLADOR WEB", "967788899", "3800", "Activo", 1)
            .ListarPersonal(tabla1)
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        data.ElminarBaseDeDatos()
        data.CreateDatabase()
    End Sub
    Private Function CalcularMontoExtra(sueldo As Integer, minutosExtra As Integer) As Double
        Dim montoExtra As Double = sueldo / 30 / 8 / 60 * minutosExtra
        Return Math.Round(montoExtra, 2)
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With data
            .InsertarHorasExtra(1, "05:30", "17:45", "20240701", 1, 315, 54.69)
            .InsertarHorasExtra(2, "06:15", "18:30", "20240515", 1, 315, 76.56)
            .InsertarHorasExtra(3, "07:45", "19:15", "20240710", 1, 270, 75)
            .InsertarHorasExtra(4, "05:00", "21:00", "20240720", 0, 480, 93.33)
            .InsertarHorasExtra(5, "08:00", "22:00", "20240705", 1, 420, 110.83)
            .InsertarHorasExtra(6, "06:45", "20:30", "20240925", 0, 345, 76.67)
            .InsertarHorasExtra(7, "05:15", "17:00", "20240603", 1, 285, 83.13)
            .InsertarHorasExtra(8, "07:30", "18:45", "20240518", 0, 195, 50.1)
            .InsertarHorasExtra(9, "06:00", "19:00", "20240612", 1, 360, 112.5)
            .InsertarHorasExtra(10, "07:00", "20:15", "20240622", 0, 315, 54.69)
            .InsertarHorasExtra(11, "05:45", "21:30", "20240808", 1, 525, 138.54)
            .ListarHorasExtra(tabla1)
        End With
    End Sub
End Class