Imports System.Windows.Forms
Imports System.Net.Mail
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Funciones

    Dim miControl As Object

    Public Sub Limpiar_Form(ByVal form As Form)
        For Each miControl In form.Controls
            If miControl.GetType Is GetType(TextBox) Then
                miControl.Clear()
            End If
        Next
    End Sub

    Public Sub Limpiar_GB(ByVal Grupo As Control)
        'Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(TextBox) Then
                miControl.Clear()
            ElseIf miControl.GetType Is GetType(ComboBox) Then
                'DirectCast(miControl, ComboBox).SelectedIndex = Nothing    --DropDownList
                DirectCast(miControl, ComboBox).Text = ""
            End If
        Next
    End Sub

    Public Function RecorreControles(ByVal Coleccion As Control)
        Dim vacio As Boolean

        For Each miControl In Coleccion.Controls
            If miControl.GetType Is GetType(TextBox) Then
                If DirectCast(miControl, TextBox).Text = "" Then
                    vacio = True
                End If
            ElseIf miControl.GetType Is GetType(ComboBox) Then
                If DirectCast(miControl, ComboBox).Text = "" Then
                    vacio = True
                End If
            End If
        Next

        Return vacio
    End Function
    Public Function Envio_Correo_Error(Mensaje As String, Plantel As String, usuario As String) As Boolean
        'Enviar Correo--------------------------------------------------------------------------------------
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        Dim correo As String = "jnavarro1314@gmail.com"
        Dim asunto As String = "Error Usuario " & usuario
        Dim info As String = usuario & " " & Plantel & vbNewLine & Mensaje

        'info = "Corte de caja de: " & asunto 'Contenido del Mensaje

        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential("Reporte.error1314@gmail.com", "df0013149")
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(correo) 'Cuenta de Correo al que se le quiere enviar el e-mail
        _Message.From = New System.Net.Mail.MailAddress("Reporte.error1314@gmail.com", "Informe error PSICOPEDAGOGICO", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = asunto 'Sujeto del e-mail
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = info 'contenido del mail
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = False
        '_Message.Attachments.Add(New Attachment(reporte))
        '_Message.Attachments.Add(New Attachment(Manual))
        ' ENVIO
        Try
            _SMTP.Send(_Message)
            Return True
        Catch ex As System.Net.Mail.SmtpException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje No Enviado")
            Return False
        End Try

    End Function

    Public Function Comprovar_Llenado(Panel As Panel, ByRef Fallo As Integer) As Integer
        For Each obj As Object In Panel.Controls
            If obj.tag = "Cn" Then
                If obj.text = Nothing Then
                    obj.backColor = Color.LightSkyBlue
                    obj.focus()
                    Fallo = Fallo + 1
                Else : obj.backColor = Color.White
                End If
            End If
        Next
        Return Fallo
    End Function
    Public Sub Limpiar(Panel As Panel)
        For Each obj As Object In Panel.Controls
            If obj.tag = "Cn" Then
                obj.text = Nothing
                obj.backColor = Color.White
            End If
        Next
    End Sub
    Function xls(ByVal DGridView As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DGridView.ColumnCount
            Dim NRow As Integer = DGridView.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DGridView.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DGridView.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
End Class


