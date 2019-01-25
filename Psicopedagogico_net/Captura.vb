Imports Datos
Imports System.IO

Public Class Captura

    Dim info(50) As String
    Dim metodos As New MetodosSQL
    Dim ms = New System.IO.MemoryStream()
    Dim cargo_imagen As Boolean = False
    Dim tiene_hnos As String
    Dim tiene_fam As String
    Dim consumo_sustancias As String
    Dim usuario As String
    Dim edad_padre, edad_madre As String
    Dim DtTable As New DataTable


    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click

        Dim direccion As String = ""
        Dim arrImage() As Byte
        Dim folio_sn_espacios = Trim(txt_folio.Text)

        Try
            If cb_sustancias.Text = "OTRO, ESPECIFIQUE" Then
                consumo_sustancias = txt_sustancias.Text
            Else
                consumo_sustancias = cb_sustancias.Text
            End If

            If CB_Baja.Text = "ACEPTO EL SERVICIO" Then
                If txt_matricula.Text = "" Or txt_folio.Text = "" Then
                    MessageBox.Show("Ásegúrate de llenar el folio y matricula del alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_alumno) = True Or txt_no_vacios(Panel_escolares_alumno) = True Or txt_no_vacios(Panel_Contacto) = True Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos del Alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_padre) = True Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos del Padre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_madre) = True Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos de la Madre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_vivienda) = True Or txt_no_vacios(Panel_canalizacion) = True Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos de Canalización y vivienda", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_Riesgo) = True Or txt_no_vacios(Panel_adiccion_alumno) = True Or Chk_crisis.Checked = True And txt_crisis.Text = "" Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos Psicometricos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf folio_sn_espacios = metodos.valida_folio(folio_sn_espacios) Then
                    MessageBox.Show("Estas intentando guardar un FOLIO que ya esta registrado, intenta nuevamente con un folio distinto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_folio.Focus()
                ElseIf txt_matricula.Text = metodos.valida_matricula(txt_matricula.Text) Then
                    MessageBox.Show("Estas intentando guardar una MATRICULA que ya esta registrada, intenta nuevamente con una matricula distinta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_matricula.Focus()
                Else
                    direccion = txt_calle.Text & " " & txt_numero.Text & " " & cb_pte.Text & ", Col. " & CB_colonia.Text & " CP. " & txt_cp.Text

                    If cargo_imagen = True Then
                        pik_foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                        arrImage = ms.GetBuffer
                        metodos.imagen(folio_sn_espacios, arrImage)
                    Else
                        metodos.imagen(folio_sn_espacios, "S/I")
                    End If

                    metodos.insertar_info(folio_sn_espacios, txt_nombre_alumno.Text, num_edad_alumno.Value, txt_curp.Text, direccion, txt_telefono.Text,
                                                          cb_ciudad.Text, cb_plantel.Text, cb_grado_alumno.Text, cb_especialidad.Text, cb_turno.Text,
                                                          cb_discapacidad_alumno.Text, cb_adiccion_alumno.Text, cb_enfermedad_alumno.Text, cb_trabaja_alumno.Text,
                                                          cb_sexo.Text, cb_vive_con.Text,
                                                          cb_vive_padre.Text, txt_nombre_padre.Text, txt_edad_padre.Text, cb_grado_padre.Text, cb_civil_padre.Text,
                                                          cb_discapacidad_padre.Text, cb_adiccion_padre.Text, cb_enfermedad_padre.Text, txt_religion_padre.Text,
                                                          cb_trabaja_padre.Text, txt_labor_padre.Text,
                                                          cb_vive_madre.Text, txt_nombre_madre.Text, txt_edad_madre.Text, cb_grado_madre.Text, cb_civil_madre.Text,
                                                          cb_discapacidad_madre.Text, cb_adiccion_madre.Text, cb_enfermedad_madre.Text, txt_religion_madre.Text,
                                                          cb_trabaja_madre.Text, txt_labor_madre.Text,
                                                          tiene_hnos, CB_vivienda.Text, tiene_fam,
                                                          txt_matricula.Text, Piker_fecha.Value.ToShortDateString, txt_motivo.Text, CB_atencion.Text,
                                                          CB_motivo.Text, CB_lugar.Text, txt_unidad.Text,
                                                          cb_violencia.Text & " " & cb_bullying.Text, consumo_sustancias, cb_depresion.Text, cb_transtorno.Text, cb_deficit.Text, txt_crisis.Text,
                                                          usuario, ComboBox_Embarazo.Text, ComboBox_Hijos.Text)
                    MessageBox.Show("Guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar_todo()
                End If
            Else
                If txt_matricula.Text = "" Or txt_folio.Text = "" Then
                    MessageBox.Show("Ásegúrate de llenar el folio y matricula del alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txt_no_vacios(Panel_alumno) = True Or txt_no_vacios(Panel_escolares_alumno) = True Or txt_no_vacios(Panel_Contacto) = True Then
                    MessageBox.Show("Ásegúrate de llenar todos los datos del Alumno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf folio_sn_espacios = metodos.valida_folio(folio_sn_espacios) Then
                    MessageBox.Show("Estas intentando guardar un FOLIO que ya esta registrado, intenta nuevamente con un folio distinto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_folio.Focus()
                ElseIf txt_matricula.Text = metodos.valida_matricula(txt_matricula.Text) Then
                    MessageBox.Show("Estas intentando guardar una MATRICULA que ya esta registrada, intenta nuevamente con una matricula distinta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txt_matricula.Focus()
                Else
                    direccion = txt_calle.Text & " " & txt_numero.Text & " " & cb_pte.Text & ", Col. " & CB_colonia.Text & " CP. " & txt_cp.Text

                    If cargo_imagen = True Then
                        pik_foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                        arrImage = ms.GetBuffer
                        metodos.imagen(folio_sn_espacios, arrImage)
                    Else
                        metodos.imagen(folio_sn_espacios, "S/I")
                    End If
                    metodos.insertar_info(folio_sn_espacios, txt_nombre_alumno.Text, num_edad_alumno.Value, txt_curp.Text, direccion, txt_telefono.Text,
                    cb_ciudad.Text, cb_plantel.Text, cb_grado_alumno.Text, cb_especialidad.Text, cb_turno.Text, CB_Baja.Text, CB_Baja.Text, CB_Baja.Text,
                    "BAJA", cb_sexo.Text, "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA",
                    "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", txt_matricula.Text,
                    Piker_fecha.Value.ToShortDateString, txt_motivo.Text, "BAJA", CB_Baja.Text, "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", "BAJA", usuario, "N/A", "S/I")

                    MessageBox.Show("Guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar_todo()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function txt_no_vacios(ByVal Grupo As Windows.Forms.Panel)
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

    Public Function limpiar_campos(ByVal Grupo As Windows.Forms.Panel)
        Dim miControl As Object
        Dim vacios As Boolean = False
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Or miControl.GetType Is GetType(System.Windows.Forms.ComboBox) Then
                miControl.text = ""
            End If
        Next
        Return vacios
    End Function

    Public Sub limpiar_todo()
        limpiar_campos(Panel_alumno)
        limpiar_campos(Panel_Contacto)
        limpiar_campos(Panel_escolares_alumno)
        limpiar_campos(Panel_adiccion_alumno)
        limpiar_campos(Panel_padre)
        limpiar_campos(Panel_madre)
        limpiar_campos(Panel_vivienda)
        limpiar_campos(Panel_canalizacion)
        limpiar_campos(Panel_Riesgo)
        txt_matricula.Text = ""
        txt_folio.Text = ""
        tiene_hnos = "S/I"
        tiene_fam = "S/I"
    End Sub

    Private Sub cb_ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ciudad.SelectedIndexChanged

        metodos.FiltroXCiudad(cb_ciudad.Text, DtTable)
        cb_plantel.DataSource = DtTable
        cb_plantel.ValueMember = "Sede"
    End Sub

    Private Sub Btn_Foto_Click(sender As Object, e As EventArgs) Handles Btn_Foto.Click
        Dim info As String = ""
        OpenFileDialog1.Filter = "JPG|*.JPG|PNG|*.png|BMP|*.bmp|Todos los Archivos|*.*" '--"*.png|*.png"
        OpenFileDialog1.Title = "Seleccione un archivo"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            info = OpenFileDialog1.FileName
            pik_foto.ImageLocation = info
            cargo_imagen = True
        End If
    End Sub

    Private Sub cb_vive_padre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_vive_padre.SelectedIndexChanged
        If cb_vive_padre.Text <> "VIVO" Then
            deshabilitar_padre()
        Else
            habilitar_padre()
        End If
    End Sub

    Public Sub deshabilitar_padre()
        txt_nombre_padre.Text = "N/A"
        txt_edad_padre.Text = "N/A"
        'edad_padre = "N/A"
        cb_grado_padre.Text = "N/A"
        cb_civil_padre.Text = "N/A"
        cb_discapacidad_padre.Text = "N/A"
        cb_adiccion_padre.Text = "N/A"
        cb_enfermedad_padre.Text = "N/A"
        txt_religion_padre.Text = "N/A"
        cb_trabaja_padre.Text = "N/A"
        txt_labor_padre.Text = "N/A"
        Panel_padre.Enabled = False
    End Sub

    Public Sub habilitar_padre()
        'edad_padre = num_edad_padre.Value
        Panel_padre.Enabled = True
        limpiar_campos(Panel_padre)
    End Sub

    Private Sub cb_vive_madre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_vive_madre.SelectedIndexChanged
        If cb_vive_madre.Text <> "VIVO" Then
            deshabilitar_madre()
        Else
            habilitar_madre()
        End If
    End Sub

    Public Sub deshabilitar_madre()
        txt_nombre_madre.Text = "N/A"
        txt_edad_madre.Text = "N/A"
        'edad_madre = "N/A"
        cb_grado_madre.Text = "N/A"
        cb_civil_madre.Text = "N/A"
        cb_discapacidad_madre.Text = "N/A"
        cb_adiccion_madre.Text = "N/A"
        cb_enfermedad_madre.Text = "N/A"
        txt_religion_madre.Text = "N/A"
        cb_trabaja_madre.Text = "N/A"
        txt_labor_madre.Text = "N/A"
        Panel_madre.Enabled = False
    End Sub

    Public Sub habilitar_madre()
        'edad_madre = num_edad_madre.Value
        Panel_madre.Enabled = True
        limpiar_campos(Panel_madre)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar_todo()
    End Sub

    Private Sub CB_colonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_colonia.KeyPress, cb_discapacidad_alumno.KeyPress, cb_adiccion_alumno.KeyPress, cb_vive_con.KeyPress, cb_enfermedad_alumno.KeyPress, cb_especialidad.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_grado_padre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_grado_padre.KeyPress, cb_civil_padre.KeyPress, cb_discapacidad_padre.KeyPress, cb_adiccion_padre.KeyPress, cb_enfermedad_padre.KeyPress, cb_trabaja_padre.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_grado_madre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_grado_madre.KeyPress, cb_civil_madre.KeyPress, cb_discapacidad_madre.KeyPress, cb_adiccion_madre.KeyPress, cb_enfermedad_madre.KeyPress, cb_trabaja_madre.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub CB_motivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_motivo.KeyPress, CB_lugar.KeyPress, CB_atencion.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub chk_hnos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_hnos.CheckedChanged
        If chk_hnos.Checked = True Then
            num_hermanos.Enabled = False
            tiene_hnos = chk_hnos.Text
        Else
            num_hermanos.Enabled = True
        End If
    End Sub

    Private Sub chk_fam_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fam.CheckedChanged
        If chk_fam.Checked = True Then
            num_familia.Enabled = False
            tiene_fam = chk_fam.Text
        Else
            num_familia.Enabled = True
        End If
    End Sub

    Private Sub num_hermanos_ValueChanged(sender As Object, e As EventArgs) Handles num_hermanos.ValueChanged
        tiene_hnos = num_hermanos.Value.ToString
    End Sub

    Private Sub num_familia_ValueChanged(sender As Object, e As EventArgs) Handles num_familia.ValueChanged
        tiene_fam = num_familia.Value.ToString
    End Sub

    Private Sub Captura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tiene_fam = "S/I"
            tiene_hnos = "S/I"
            usuario = Bienvenida.lbl_nombre_usuario.Text
            CB_Baja.SelectedItem = "ACEPTO EL SERVICIO"
            cb_bullying.SelectedItem = " "
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Captura " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub


    Private Sub cb_sustancias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sustancias.SelectedIndexChanged
        If cb_sustancias.Text = "OTRO, ESPECIFIQUE" Then
            txt_sustancias.Enabled = True
        Else
            txt_sustancias.Enabled = False
            txt_sustancias.Text = "..."
        End If
    End Sub

    Private Sub Chk_crisis_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_crisis.CheckedChanged
        If Chk_crisis.Checked = True Then
            txt_crisis.Enabled = True
            txt_crisis.Text = ""
        Else
            txt_crisis.Enabled = False
            txt_crisis.Text = "NO"
        End If
    End Sub

    Private Sub cb_violencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_violencia.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_sustancias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_sustancias.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_transtorno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_transtorno.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_deficit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_deficit.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub cb_depresion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_depresion.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub CB_Baja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Baja.SelectedIndexChanged
        If CB_Baja.SelectedItem = "DADO DE BAJA" Or CB_Baja.SelectedItem = "RECHAZO EL SERVICIO" Or CB_Baja.SelectedItem = "BAJA POR INASISTENCIA" Then
            Panel_adiccion_alumno.Enabled = False
            Panel_Riesgo.Enabled = False
            Panel_Sociales.Enabled = False
            Panel_vivienda.Enabled = False
            habilitar_panel_canalizacion(False)
        Else
            Panel_adiccion_alumno.Enabled = True
            Panel_Riesgo.Enabled = True
            Panel_Sociales.Enabled = True
            Panel_vivienda.Enabled = True
            habilitar_panel_canalizacion(True)
        End If
    End Sub

    Private Sub cb_violencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_violencia.SelectedIndexChanged
        If cb_violencia.SelectedItem = "BULLYING" Then
            cb_bullying.Enabled = True
        Else
            cb_bullying.Enabled = False
        End If
    End Sub

    Public Sub habilitar_panel_canalizacion(bandera As Boolean)
        Piker_fecha.Enabled = bandera
        ' txt_motivo.Enabled = bandera  '****
        CB_motivo.Enabled = bandera
        CB_lugar.Enabled = bandera
        txt_unidad.Enabled = bandera
        CB_atencion.Enabled = bandera
    End Sub
End Class