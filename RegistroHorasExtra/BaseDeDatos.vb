Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports CrystalDecisions.CrystalReports.Engine
Imports DocumentFormat.OpenXml.Office2010.Excel
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class BaseDeDatos
    Private ReadOnly connectionString As String

    Public Sub New()
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "BaseDeDatos.db")
        connectionString = $"Data Source={databasePath};Version=3;"
    End Sub

    Public Sub ElminarBaseDeDatos()
        Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "BaseDeDatos.db")
        If IO.File.Exists(databasePath) Then
            IO.File.Delete(databasePath)
            MsgBox("Archivo de base de datos eliminado correctamente.", MsgBoxStyle.Information, "Operación exitosa")
        Else
            MsgBox("El archivo de base de datos no existe.", MsgBoxStyle.Information, "Información")
        End If
    End Sub

    Public Sub CreateDatabase()
        Dim databaseFile As String = connectionString.Replace("Data Source=", "").Replace(";Version=3;", "")
        If Not IO.File.Exists(databaseFile) Then
            SQLiteConnection.CreateFile(databaseFile)
            CreateTableHorarios()
            CreateTablePersonal()
            CreateTablehoras_Extra()
        End If
    End Sub
#Region "Personal"
    Public Sub CreateTablePersonal()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "
                    CREATE TABLE IF NOT EXISTS Personal (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        NombreCompleto TEXT NOT NULL,
                        NroDoc TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        Cargo TEXT NOT NULL,
                        Telefono TEXT NOT NULL,
                        Sueldo TEXT NOT NULL,
                        Estado TEXT NOT NULL,
                        Id_Horario INTEGER,
                        FOREIGN KEY (Id_Horario) REFERENCES Horarios(Id) ON DELETE RESTRICT
                    );"
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function DevolverNombreCompletoPersonal(dato As String) As String
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand("SELECT NombreCompleto AS 'Nombre Completo' from Personal where Id = '" & dato & "'", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt(0)(0)
                End Using
            End Using
        End Using
    End Function
    Public Sub InsertarPersonal(nombrecompleto As String, nrodoc As String, email As String, cargo As String, telefono As String, sueldo As String, estado As String, horario As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "SELECT COUNT(*) FROM Personal WHERE NombreCompleto = @NombreCompleto AND NroDoc = @NroDoc"
                cmd.Parameters.AddWithValue("@NombreCompleto", nombrecompleto)
                cmd.Parameters.AddWithValue("@NroDoc", nrodoc)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MsgBox("Ya existe una persona con esos datos", Title:="Aviso")
                    Exit Sub
                Else
                    cmd.CommandText = "INSERT INTO Personal (NombreCompleto, NroDoc, Email, Cargo, Telefono, Sueldo, Estado, Id_Horario) VALUES (@NombreCompleto, @NroDoc, @Email, @Cargo, @Telefono, @Sueldo, @Estado, @Id_Horario);"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombrecompleto)
                    cmd.Parameters.AddWithValue("@NroDoc", nrodoc)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Cargo", cargo)
                    cmd.Parameters.AddWithValue("@Telefono", telefono)
                    cmd.Parameters.AddWithValue("@Sueldo", sueldo)
                    cmd.Parameters.AddWithValue("@Estado", estado)
                    cmd.Parameters.AddWithValue("@Id_Horario", horario)
                    cmd.ExecuteNonQuery()
                End If
            End Using
        End Using
    End Sub

    Public Sub ActualizarPersonal(Id_Personal As Integer, nrodoc As String, nombrecompleto As String, email As String, cargo As String, telefono As String, sueldo As String, estado As String, horario As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "UPDATE Personal SET 
                    NombreCompleto = @NombreCompleto, 
                    NroDoc = @NroDoc, 
                    Email = @Email, 
                    Cargo = @Cargo, 
                    Telefono = @Telefono, 
                    Sueldo = @Sueldo, 
                    Estado = @Estado, 
                    Id_Horario = @Id_Horario 
                    WHERE Id = @Id_Personal"
                cmd.Parameters.AddWithValue("@NombreCompleto", nombrecompleto)
                cmd.Parameters.AddWithValue("@NroDoc", nrodoc)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Cargo", cargo)
                cmd.Parameters.AddWithValue("@Telefono", telefono)
                cmd.Parameters.AddWithValue("@Sueldo", sueldo)
                cmd.Parameters.AddWithValue("@Estado", estado)
                cmd.Parameters.AddWithValue("@Id_Horario", horario)
                cmd.Parameters.AddWithValue("@Id_Personal", Id_Personal)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub EliminarPersonal(Id_Personal As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "DELETE FROM Personal WHERE Id = @Id_Personal"
                cmd.Parameters.AddWithValue("@Id_Personal", Id_Personal)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ListarPersonal(dgv As DataGridView)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand("SELECT Id AS ID_Personal, NroDoc AS 'Nro. Documento', NombreCompleto AS 'Nombre Completo', Email AS 'Correo Electrónico', Cargo, Telefono AS Teléfono, Sueldo, Estado, (SELECT descripcion from Horarios where Id = Id_Horario) as Horario FROM Personal", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Public Sub FiltrarPersonal(dgv As DataGridView, dato As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand("SELECT Id AS ID_Personal, NroDoc AS 'Nro. Documento', NombreCompleto AS 'Nombre Completo', Email AS 'Correo Electrónico', Cargo, Telefono AS Teléfono, Sueldo, Estado, (SELECT descripcion from Horarios where Id = Id_Horario) as Horario FROM Personal WHERE NroDoc LIKE @Dato OR NombreCompleto LIKE @Dato", conn)
                cmd.Parameters.AddWithValue("@Dato", "%" & dato & "%")
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
#End Region

#Region "Horarios"
    Public Sub CreateTableHorarios()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "
                    CREATE TABLE IF NOT EXISTS Horarios (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Descripcion TEXT NOT NULL,
                        InicioTurno TEXT NOT NULL,
                        FinTurno TEXT NOT NULL,
                        InicioRefrigerio TEXT NOT NULL,
                        FinRefrigerio TEXT NOT NULL
                    );"
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertarHorario(Descripcion As String, InicioTurno As String, FinTurno As String, InicioRefrigerio As String, FinRefrigerio As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "INSERT INTO Horarios (Descripcion, InicioTurno, FinTurno, InicioRefrigerio, FinRefrigerio) VALUES (@Descripcion, @InicioTurno, @FinTurno, @InicioRefrigerio, @FinRefrigerio);"
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                cmd.Parameters.AddWithValue("@InicioTurno", InicioTurno)
                cmd.Parameters.AddWithValue("@FinTurno", FinTurno)
                cmd.Parameters.AddWithValue("@InicioRefrigerio", InicioRefrigerio)
                cmd.Parameters.AddWithValue("@FinRefrigerio", FinRefrigerio)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ActualizarHorario(Id As Integer, Descripcion As String, InicioTurno As String, FinTurno As String, InicioRefrigerio As String, FinRefrigerio As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "UPDATE Horarios SET Descripcion = @Descripcion, InicioTurno = @InicioTurno, FinTurno = @FinTurno, InicioRefrigerio = @InicioRefrigerio, FinRefrigerio = @FinRefrigerio WHERE Id = @Id;"
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
                cmd.Parameters.AddWithValue("@InicioTurno", InicioTurno)
                cmd.Parameters.AddWithValue("@FinTurno", FinTurno)
                cmd.Parameters.AddWithValue("@InicioRefrigerio", InicioRefrigerio)
                cmd.Parameters.AddWithValue("@FinRefrigerio", FinRefrigerio)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub EliminarHorario(Id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "DELETE FROM Horarios WHERE Id = @Id;"
                cmd.Parameters.AddWithValue("@Id", Id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ListarHorarios(dgv As DataGridView)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand("SELECT Id as ID_Horario, Descripcion, InicioTurno, FinTurno, InicioRefrigerio, FinRefrigerio FROM Horarios", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Sub ListarHorariosEnComboBox(dgv As ComboBox)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Items.Clear()
            Using cmd As New SQLiteCommand("SELECT Descripcion FROM Horarios", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    For Each filita As DataRow In dt.Rows
                        dgv.Items.Add(filita(0))
                    Next

                End Using
            End Using
        End Using
    End Sub

    Public Function DevolverIdHorario(nombre_horario) As String
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand("SELECT Id from Horarios where Descripcion = '" & nombre_horario & "'", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt(0)(0)
                End Using
            End Using
        End Using
    End Function


    Function DevolverId_Personal(datos As String) As String
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "SELECT id from personal where NombreCompleto = '" + datos + "';"
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    Return dt(0)(0)
                End Using
            End Using
        End Using

    End Function
    Public Sub FiltrarHorarios(dgv As DataGridView, dato As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand("SELECT Id as ID_Horario, Descripcion, InicioTurno, FinTurno, InicioRefrigerio, FinRefrigerio FROM Horarios WHERE Descripcion LIKE @dato OR InicioTurno LIKE @dato OR FinTurno LIKE @dato OR InicioRefrigerio LIKE @dato OR FinRefrigerio LIKE @dato", conn)
                cmd.Parameters.AddWithValue("@dato", "%" & dato & "%")
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
#End Region
#Region "Horas Extra"
    Public Sub CreateTablehoras_Extra()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "
                    CREATE TABLE IF NOT EXISTS Horas_Extra (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Id_Trabajador INTEGER not null,
                        InicioTurno TEXT NOT NULL,
                        FinTurno TEXT NOT NULL,
                        Fecha DATE not null,
                        UsoRefrigerio INTEGER not null,
                        Tiempo_Extra REAL not null,
                        Monto_Extra REAL not null,
                        FOREIGN KEY (Id_Trabajador) REFERENCES Personal(Id)
                    );"
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub DropTableHorasExtra()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "DROP TABLE IF EXISTS Horas_Extra;"
                cmd.ExecuteNonQuery()
                MsgBox("dropeada")
            End Using
        End Using
    End Sub
    Public Sub ListarHorasExtra(dgv As DataGridView)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "SELECT id,(select NombreCompleto from personal where id = id_trabajador) as Trabajador,InicioTurno,FinTurno,Fecha,UsoRefrigerio,Tiempo_Extra as 'Minutos Extra',Monto_Extra as Monto FROM Horas_Extra;"
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Sub BuscarEnHorasExtra(dgv As DataGridView, dato As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "SELECT id,(select NombreCompleto from personal where id = id_trabajador) as Trabajador,InicioTurno,FinTurno,Fecha,UsoRefrigerio,Tiempo_Extra as 'Minutos Extra',Monto_Extra as Monto FROM Horas_Extra where (select NombreCompleto from personal where id = id_trabajador) like'%" + dato + "%';"
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Sub InsertarHorasExtra(Id_Trabajador As Integer, InicioTurno As String, FinTurno As String, Fecha As String, UsoRefrigerio As Integer, Tiempo_Extra As String, Monto_Extra As Double)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "INSERT INTO Horas_Extra (Id_Trabajador, InicioTurno, FinTurno, Fecha, UsoRefrigerio, Tiempo_Extra, Monto_Extra) VALUES (@Id_Trabajador, @InicioTurno, @FinTurno, @Fecha, @UsoRefrigerio, @Tiempo_Extra, @Monto_Extra);"
                cmd.Parameters.AddWithValue("@Id_Trabajador", Id_Trabajador)
                cmd.Parameters.AddWithValue("@InicioTurno", InicioTurno)
                cmd.Parameters.AddWithValue("@FinTurno", FinTurno)
                cmd.Parameters.AddWithValue("@Fecha", Fecha)
                cmd.Parameters.AddWithValue("@UsoRefrigerio", UsoRefrigerio)
                cmd.Parameters.AddWithValue("@Tiempo_Extra", Tiempo_Extra)
                cmd.Parameters.AddWithValue("@Monto_Extra", Monto_Extra)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ActualizarHorasExtra(id As Integer, Id_Trabajador As Integer, InicioTurno As String, FinTurno As String, Fecha As String, UsoRefrigerio As Integer, Tiempo_Extra As String, Monto_Extra As Double)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "UPDATE Horas_Extra SET InicioTurno = @InicioTurno, FinTurno = @FinTurno, Fecha = @Fecha, UsoRefrigerio = @UsoRefrigerio, Tiempo_Extra = @Tiempo_Extra, Monto_Extra = @Monto_Extra WHERE Id = @Id;"
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.Parameters.AddWithValue("@Id_Trabajador", Id_Trabajador)
                cmd.Parameters.AddWithValue("@InicioTurno", InicioTurno)
                cmd.Parameters.AddWithValue("@FinTurno", FinTurno)
                cmd.Parameters.AddWithValue("@Fecha", Fecha)
                cmd.Parameters.AddWithValue("@UsoRefrigerio", UsoRefrigerio)
                cmd.Parameters.AddWithValue("@Tiempo_Extra", Tiempo_Extra)
                cmd.Parameters.AddWithValue("@Monto_Extra", Monto_Extra)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub EliminarHorasExtra(id As Integer)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "DELETE FROM Horas_Extra WHERE Id = @Id;"
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function DevolverSueldo(id_personal) As Double
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand("
            SELECT SUELDO FROM PERSONAL WHERE ID = '" & id_personal & "'", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    If dt Is Nothing Then
                        MsgBox("no se encontró un sueldo")
                        Return Nothing
                    Else
                        Return dt(0)(0)
                    End If
                End Using
            End Using
        End Using
    End Function
    Public Function DevolverDatosHorario(id_personal) As DataTable
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand("SELECT InicioRefrigerio,FinRefrigerio,InicioTurno,FinTurno from horarios h join personal p on h.id = p.Id_Horario where p.id = '" & id_personal & "'", conn)
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    If dt Is Nothing Then
                        MsgBox("No hay un horario asignado al trabajador, revise el registro del personal e intente nuevamente")
                        Return Nothing
                    Else
                        Return dt
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Sub BuscarTrabajador(dgv As DataGridView, dato As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand("
            SELECT 
                Personal.Id as Código,
                NroDoc as Documento,
                NombreCompleto as 'Nombre Completo',
                InicioTurno,
                FinTurno,
                InicioRefrigerio,
                FinRefrigerio
            FROM 
                Personal 
            JOIN 
                Horarios 
            ON 
                Horarios.Id = Personal.Id_Horario
            WHERE 
                NombreCompleto LIKE @dato 
            OR 
                NroDoc LIKE @dato;", conn)
                cmd.Parameters.AddWithValue("@dato", "%" & dato & "%")

                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
#End Region
#Region "Reportes"
    Public Sub ListarReporteHorasExtraPersonal(dgv As DataGridView, id As String, mes As String, año As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            ' Asegúrate de que el mes tenga dos dígitos
            mes = mes.PadLeft(2, "0"c)
            ' Construir la consulta SQL
            Dim query As String = "SELECT " &
            "(SELECT NombreCompleto FROM Personal WHERE id = Id_Trabajador) AS Trabajador, " &
            "InicioTurno, FinTurno, Fecha, UsoRefrigerio, Monto_Extra " &
            "FROM Horas_Extra WHERE id_Trabajador = '" & id & "' and Fecha like '%" & año & mes & "%'"
            Using cmd As New SQLiteCommand(query, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Sub ListarReporteHorasExtraGeneral(dgv As DataGridView, mes As String, año As String)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            ' Asegúrate de que el mes tenga dos dígitos
            mes = mes.PadLeft(2, "0"c)
            ' Construir la consulta SQL
            Dim query As String = "SELECT " &
            "(SELECT NombreCompleto FROM Personal WHERE id = Id_Trabajador) AS Trabajador, " &
            "(SELECT NroDoc FROM Personal WHERE id = Id_Trabajador) AS Documento, Monto_Extra " &
            "FROM Horas_Extra WHERE Fecha like '%" & año & mes & "%'"
            Using cmd As New SQLiteCommand(query, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Sub ListarVisor(dgv, query)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = query
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Sub ListarReporteHorasExtraPeriodo(dgv As DataGridView)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            dgv.Columns.Clear()
            Using cmd As New SQLiteCommand(conn)
                cmd.CommandText = "SELECT * FROM Horas_Extra;"
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    dgv.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Public Function CargarDatosPersonal(id As String, mes As String, año As String) As DataSet
        Dim dataSet As New DataSet()
        mes = mes.PadLeft(2, "0"c)
        Using conn As New SQLiteConnection(connectionString)
            Dim query As String = "SELECT " &
            "(SELECT NombreCompleto FROM Personal WHERE id = Id_Trabajador) AS Trabajador, " &
            "(SELECT NroDoc FROM Personal WHERE id = Id_Trabajador) AS Documento, " &
            "InicioTurno AS Inicio_Turno, FinTurno AS Fin_Turno, Fecha, UsoRefrigerio AS Uso_Refrigerio, Monto_Extra AS MontoExtra " &
            "FROM Horas_Extra WHERE id_Trabajador = '" & id & "' and Fecha like '%" & año & mes & "%'"
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    dataSet.Load(reader, LoadOption.OverwriteChanges, "Personal")
                End Using
            End Using
        End Using

        Return dataSet
    End Function
    Public Function CargarDatosGeneral(id As String, mes As String, año As String) As DataSet
        Dim dataSet As New DataSet()
        mes = mes.PadLeft(2, "0"c)
        Using conn As New SQLiteConnection(connectionString)
            Dim query As String = "SELECT " &
            "(SELECT NombreCompleto FROM Personal WHERE id = Id_Trabajador) AS Trabajador, " &
            "(SELECT NroDoc FROM Personal WHERE id = Id_Trabajador) AS Documento, " &
            "Monto_Extra AS MontoExtra " &
            "FROM Horas_Extra WHERE Fecha like '%" & año & mes & "%'"
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    dataSet.Load(reader, LoadOption.OverwriteChanges, "Periodo")
                End Using
            End Using
        End Using

        Return dataSet
    End Function
    Public Function CargarDatosGeneralChart(id As String, mes As String, año As String) As DataTable
        Dim dataTable As New DataTable()
        mes = mes.PadLeft(2, "0"c)

        Using conn As New SQLiteConnection(connectionString)
            Dim query As String = "SELECT " &
    "(SELECT NombreCompleto FROM Personal WHERE id = Id_Trabajador) AS Trabajador, " &
    "SUM(Monto_Extra) AS MontoExtra " &
    "FROM Horas_Extra " &
    "WHERE Fecha LIKE '%" & año & mes & "%' " &
    "GROUP BY Id_Trabajador"
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    dataTable.Load(reader)
                End Using
            End Using
        End Using

        Return dataTable
    End Function
    Public Function CargarMontoTotalPersonal(id As String, mes As String, año As String) As String
        Dim totalMontoExtra As String = "0.00"
        mes = mes.PadLeft(2, "0"c)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT SUM(Monto_Extra) AS TotalMontoExtra " &
                              "FROM Horas_Extra " &
                              "WHERE id_Trabajador = @id AND Fecha LIKE '%" & año & mes & "%'"
            Clipboard.SetText(query)
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Dim totalDecimal As Decimal = Convert.ToDecimal(result)
                    totalMontoExtra = "TOTAL: S/ " & totalDecimal.ToString("0.00")
                End If
            End Using
        End Using

        Return totalMontoExtra
    End Function
    Public Function CargarMontoTotalGeneral(mes As String, año As String) As String
        Dim totalMontoExtra As String = "0.00"
        mes = mes.PadLeft(2, "0"c)
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT SUM(Monto_Extra) AS TotalMontoExtra " &
                              "FROM Horas_Extra " &
                              "WHERE Fecha LIKE '%" & año & mes & "%'"
            Clipboard.SetText(query)
            Using cmd As New SQLiteCommand(query, conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Dim totalDecimal As Decimal = Convert.ToDecimal(result)
                    totalMontoExtra = "TOTAL: S/ " & totalDecimal.ToString("0.00")
                End If
            End Using
        End Using

        Return totalMontoExtra
    End Function

    Public Sub CargarReportePersonal(dataSet As DataSet, CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, mes As String, año As String, idtrabajador As Integer)
        mes = mes.PadLeft(2, "0"c)
        Dim report As New ReportePersonal
        report.SetDataSource(dataSet)
        report.SetParameterValue("MES", mes)
        report.SetParameterValue("AÑO", año)
        Dim montototal = CargarMontoTotalPersonal(idtrabajador, mes, año)
        report.SetParameterValue("TOTAL", montototal)
        CrystalReportViewer.ReportSource = report
        CrystalReportViewer.Refresh()
    End Sub
    Public Sub CargarReporteGeneral(dataSet As DataSet, CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, mes As String, año As String)
        mes = mes.PadLeft(2, "0"c)
        Dim report As New ReporteGeneral
        report.SetDataSource(dataSet)
        report.SetParameterValue("MES", mes)
        report.SetParameterValue("AÑO", año)
        Dim montototal = CargarMontoTotalGeneral(mes, año)
        report.SetParameterValue("TOTAL", montototal)
        CrystalReportViewer.ReportSource = report
        CrystalReportViewer.Refresh()
    End Sub
#End Region

End Class


