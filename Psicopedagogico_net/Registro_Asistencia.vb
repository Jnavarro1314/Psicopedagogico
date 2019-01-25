Imports Datos
Imports Entidades
Public Class Registro_Asistencia
    Dim Datos_Metodos As New MetodosSQL
    Dim Entidades_Funciones As New Funciones
    Dim Dv As New DataView
    Private Sub Registro_Asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planteles_DataSet.Planteles' Puede moverla o quitarla según sea necesario.
        Me.PlantelesTableAdapter.Fill(Me.Planteles_DataSet.Planteles)
        cb_plantel.SelectedItem = Nothing
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim Fallo As Integer

        Entidades_Funciones.Comprovar_Llenado(Panel_Datos, Fallo)

        If Fallo > 0 Then
            MsgBox("Todos los Campos son Obligatorios", MsgBoxStyle.Exclamation)
        Else
            Datos_Metodos.Registrar_Asistencia(txt_matricula.Text.Trim, txt_folio.Text.Trim, txt_nombre_alumno.Text.Trim, cb_plantel.Text, CB_lugar.Text.Trim)
            Entidades_Funciones.Limpiar(Panel_Datos)
        End If
    End Sub

    Private Sub Button_Consulta_Click(sender As Object, e As EventArgs) Handles Button_Consulta.Click
        Try
            DataSet_Consultas.Clear()
            Datos_Metodos.Select_Registro_Asistencia(DataSet_Consultas, DateTimePicker_Inicio.Value.ToShortDateString, DateTimePicker_Final.Value.ToShortDateString)
            DataGridView_Sesiones.DataSource = DataSet_Consultas.Tables("Ps_Registro_Asistencia") ' Rellenamos la grilla con la tabla
            Dv.Table = DataSet_Consultas.Tables("Ps_Registro_Asistencia")
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar el Las citas" & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub
End Class