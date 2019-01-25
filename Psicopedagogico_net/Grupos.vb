Imports Datos

Public Class Grupos

    Public FormPadre As String
    Dim Metodos As New MetodosSQL
    Dim dtTable As New DataTable
    Dim usuario, segundos, minutos, var_id As String
    Public Property Consulta_GruposDsGrupos As Object

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Metodos.CargarSedes(dtTable)
            CB_Sedes.DataSource = dtTable
            CB_Sedes.DisplayMember = "Sede"

            If FormPadre = "Bienvenida" Then
                usuario = Bienvenida.lbl_nombre_usuario.Text
            Else
                Btn_Guardar.Enabled = False

                'DsGrupos.Tables.Add(Grup.DsGrupos.Tables(0))

                var_id = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("ID_GRUPO").ToString 'Consulta_Grupos.dt.Rows(0)("ID_GRUPO").ToString
                txt_tema.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("TEMA").ToString
                CB_Sedes.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PLANTEL").ToString
                txt_ciudad.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("CIUDAD").ToString
                txt_Estado.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("ESTADO").ToString
                cb_nivel.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("NIVEL_EDUCATIVO").ToString
                txt_especialidad.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("ESPECIALIDAD").ToString
                txt_ponente.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PON_NOMBRE").ToString
                txt_titulo.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PON_TITULO").ToString
                txt_ponente_esp.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PON_ESPECIALIDAD").ToString
                txt_telefono.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PON_TELEFONO").ToString
                txt_Experiencia.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("PON_EXPERIENCIA").ToString
                txt_institucion.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("INSTITUCION").ToString
                txt_Responsable1.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("RES1_NOMBRE").ToString
                txt_Puesto1.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("RES1_PUESTO").ToString
                txt_Responsable2.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("RES2_NOMBRE").ToString
                txt_Puesto2.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("RES2_PUESTO").ToString
                NumPlantel.Value = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("ALUM_PLANTEL")
                NumBeneficiados.Value = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("ALUM_BENEFICIADOS")
                Piker_fecha.Value = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("FECHA").ToString
                Piker_hora.Value = Piker_fecha.Value & " " & Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("HORA").ToString
                txt_observaciones.Text = Consulta_Grupos.DsGrupos.Tables(0).Rows(0)("OBSERVACIONES").ToString
                ' Consulta_Grupos.Close()
            End If

        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Grupos " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub CB_Sedes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Sedes.SelectedIndexChanged
        Metodos.filtro_plantel(CB_Sedes.Text, txt_ciudad.Text, txt_Estado.Text)
    End Sub

    Private Sub Btn_Graficar_Click(sender As Object, e As EventArgs) Handles Btn_Graficar.Click
        Try
            Chart1.Series("Series1").Points.Clear()
            If NumBeneficiados.Value = 0 Or NumPlantel.Value = 0 Then
                MessageBox.Show("Ingresa un número de alumnos", "Validando datos de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf NumBeneficiados.Value > NumPlantel.Value Then
                MessageBox.Show("El número de alumnos beneficiados no debe ser mayor al numero de alumnos en el plantel", "Validando datos de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'CALCULAR LOS NO BENEFICIADOS
                Dim NOBeneficiados As Integer
                NOBeneficiados = NumPlantel.Value - NumBeneficiados.Value

                'CALCULAR PORCENTAJE
                Dim Porcentaje_beneficiados, porcentaje_NoBeneficiados As Double
                Porcentaje_beneficiados = (NumBeneficiados.Value * 100) / NumPlantel.Value
                porcentaje_NoBeneficiados = 100 - Porcentaje_beneficiados

                Chart1.Series("Series1").Points.AddXY("", NumBeneficiados.Value)
                Chart1.Series("Series1").Points.AddXY("", NOBeneficiados)

                Chart1.Series("Series1").Points(0).LegendText = "SI - " & Porcentaje_beneficiados.ToString("##,##0.00") & "%"
                Chart1.Series("Series1").Points(1).LegendText = "NO - " & porcentaje_NoBeneficiados.ToString("##,##0.00") & "%"

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Acude con el administrador del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            If txt_tema.Text = "" Or txt_no_vacios(GB_Plantel) = True Or txt_no_vacios(GB_Ponente) = True Or txt_no_vacios(GB_Resp) = True Or NumPlantel.Value = 0 Or NumBeneficiados.Value = 0 Or txt_observaciones.Text = "" Then
                MessageBox.Show("Asegurate de llenar todas las casillas", "Validando datos de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf NumBeneficiados.Value > NumPlantel.Value Then
                MessageBox.Show("El número de alumnos beneficiados no debe ser mayor al numero de alumnos en el plantel", "Validando datos de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                '---SEGUNDOS
                If Piker_hora.Value.Second < 10 Then
                    segundos = "0" & Piker_hora.Value.Second
                Else
                    segundos = Piker_hora.Value.Second
                End If
                '---MINUTOS
                If Piker_hora.Value.Minute < 10 Then
                    minutos = "0" & Piker_hora.Value.Minute
                Else
                    minutos = Piker_hora.Value.Minute
                End If

                Metodos.insert_grafico(txt_tema.Text, CB_Sedes.Text, txt_ciudad.Text, txt_Estado.Text, cb_nivel.Text, txt_especialidad.Text, txt_ponente.Text, txt_titulo.Text,
                        txt_ponente_esp.Text, txt_telefono.Text, txt_Experiencia.Text, txt_institucion.Text, txt_Responsable1.Text, txt_Puesto1.Text, txt_Responsable2.Text,
                        txt_Puesto2.Text, NumPlantel.Value, NumBeneficiados.Value, Piker_fecha.Value.ToShortDateString,
                        Piker_hora.Value.Hour & ":" & minutos & ":" & segundos, txt_observaciones.Text, usuario)

                MessageBox.Show("Guardado Correctamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                limpiar_campos()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Acude con el administrador del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Public Function txt_no_vacios(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Or miControl.GetType Is GetType(System.Windows.Forms.ComboBox) Then
                If miControl.text = "" Then
                    vacios = True
                    Exit For
                End If
            End If
        Next
        Return vacios
    End Function

    Public Function limpiar(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Or miControl.GetType Is GetType(System.Windows.Forms.ComboBox) Then
                miControl.text = ""
            End If
        Next
        Return vacios
    End Function

    Public Sub limpiar_campos()
        limpiar(GB_Plantel)
        limpiar(GB_Ponente)
        limpiar(GB_Resp)
        NumPlantel.Value = 0
        NumBeneficiados.Value = 0
        txt_tema.Text = ""
        txt_observaciones.Text = ""
    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        limpiar_campos()
    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Consulta_Grupos.Show()
        Consulta_Grupos.BringToFront()
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Dim form As New CRVisor
        Dim cr As New rpt_Grupos

        Try
            cr.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            cr.SetDataSource(Consulta_Grupos.DsGrupos)
            form.CrystalReportViewer1.ReportSource = cr
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cb_nivel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_nivel.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub
End Class