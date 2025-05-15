Imports System.IO
Imports ClosedXML.Excel


Public Class Funcionalidades
    Public Sub ExportarDataGridViewAExcelYAbrir(dgv As DataGridView)
        ' Crear un archivo temporal
        Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() & ".xlsx")

        ' Crear un nuevo libro de trabajo
        Dim workbook As New XLWorkbook()
        Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Datos")

        ' Añadir los nombres de las columnas
        For col As Integer = 0 To dgv.Columns.Count - 1
            worksheet.Cell(1, col + 1).Value = dgv.Columns(col).HeaderText
        Next

        ' Añadir las filas de datos
        For row As Integer = 0 To dgv.Rows.Count - 1
            For col As Integer = 0 To dgv.Columns.Count - 1
                ' Convertir el valor de la celda a string antes de asignarlo a la celda de Excel
                worksheet.Cell(row + 2, col + 1).Value = dgv.Rows(row).Cells(col).Value?.ToString()
            Next
        Next

        ' Guardar el archivo en la ubicación temporal
        workbook.SaveAs(tempFilePath)

        ' Abrir el archivo Excel
        Process.Start(New ProcessStartInfo(tempFilePath) With {.UseShellExecute = True})
    End Sub
End Class
