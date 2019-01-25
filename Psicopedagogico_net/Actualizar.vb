Imports Datos
Imports System.IO

Public Class Actualizar

    Dim metodos As New MetodosSQL
    Dim ms = New System.IO.MemoryStream()

    Private Sub ListBox_datos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_datos.SelectedIndexChanged
        'HABILITA Y DESHABILITA CONTROLES
        lbl_campo1.Text = ListBox_datos.SelectedItem
        If lbl_campo1.Text = "FOTOGRAFIA" Then
            'txt_campo1.Text = ""
            ' txt_campo1.Enabled = False
            btn_foto.Visible = True
        ElseIf lbl_campo1.Text = "FECHA CANALIZACION" Then
            ' txt_campo1.Visible = False
            piker_fecha.Visible = True
        Else
            txt_campo1.Enabled = True
            btn_foto.Visible = False
            txt_campo1.Visible = True
            piker_fecha.Visible = False
        End If
        If lbl_campo1.Text = "PLANTEL" Then
            txt_campo1.Visible = False
            cb_plantel.Visible = True
        Else

            txt_campo1.Visible = True
            cb_plantel.Visible = False
        End If
        If lbl_campo1.Text = "Embarazo" Then
            txt_campo1.Visible = False
            ComboBox_Embarazo.Visible = True
        Else

            ' txt_campo1.Visible = True
            ComboBox_Embarazo.Visible = False
        End If
        If lbl_campo1.Text = "Hijos" Then
            txt_campo1.Visible = False
            ComboBox_Hijos.Visible = True
        Else

            'txt_campo1.Visible = True
            ComboBox_Hijos.Visible = False
        End If
        'VALIDA LA LONGITUD DE LOS DIFERENTES CAMPOS EN BD
        If lbl_campo1.Text = "CURP" Or lbl_campo1.Text = "GRADO" Or lbl_campo1.Text = "TURNO" Then
            txt_campo1.MaxLength = 20
        ElseIf lbl_campo1.Text = "TELEFONO" Or lbl_campo1.Text = "TRABAJA" Or lbl_campo1.Text = "P_VIVE" Or lbl_campo1.Text = "P_TRABAJA" Or lbl_campo1.Text = "M_VIVE" Or lbl_campo1.Text = "M_TRABAJA" Or lbl_campo1.Text = "MATRICULA" Then
            txt_campo1.MaxLength = 10
        ElseIf lbl_campo1.Text = "DIRECCION" Or lbl_campo1.Text = "NOMBRE" Or lbl_campo1.Text = "Embarazo" Or lbl_campo1.Text = "Hijos" Then
            txt_campo1.MaxLength = 100
        ElseIf lbl_campo1.Text = "EDAD" Or lbl_campo1.Text = "HERMANOS" Or lbl_campo1.Text = "HABITANTES" Then
            txt_campo1.MaxLength = 2
        Else
            txt_campo1.MaxLength = 500
        End If

        txt_campo1.Text = ""

    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Dim info As String = ""
        OpenFileDialog1.Filter = "JPG|*.JPG|PNG|*.png|BMP|*.bmp|Todos los Archivos|*.*" '--"*.png|*.png"
        OpenFileDialog1.Title = "Seleccione un archivo"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            info = OpenFileDialog1.FileName
            pik_foto.ImageLocation = info
            '  txt_campo1.Text = pik_foto.ImageLocation
        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim campo_actualizar As String = ""

        Try
            'HABILITA Y DESHABILITA CONTROLES
            If btn_foto.Visible = True Then
                btn_foto.Visible = False
                ' txt_campo1.Enabled = True
            ElseIf piker_fecha.Visible = True Then
                piker_fecha.Visible = False
                '   txt_campo1.Visible = True
            End If
            'VALIDA CAMPOS CORRECTOS EN BD, QUE CAMBIE EN EL LISTBOX
            If lbl_campo1.Text = "VIVE EN" Then
                campo_actualizar = "CASA"
            ElseIf lbl_campo1.Text = "HABITANTES" Then
                campo_actualizar = "FAMILIA"
            ElseIf lbl_campo1.Text = "FECHA CANALIZACION" Then
                campo_actualizar = "FECHA_CAN"
            ElseIf lbl_campo1.Text = "MOTIVO CANALIZACION" Then
                campo_actualizar = "MOTIVO_CAN"
            ElseIf lbl_campo1.Text = "LUGAR CANALIZACION" Then
                campo_actualizar = "LUGAR_CAN"
            Else
                campo_actualizar = lbl_campo1.Text
            End If

            'VALIDA LA ENTRADA DE DATOS ANTES DE GUARDAR
            If txt_folio.Text = "" Then
                MessageBox.Show("Debes indicar el folio del alumno.", "Validación de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf lbl_campo1.Text = "CAMPO A ACTUALIZAR" Then
                MessageBox.Show("Debes seleccionar una caracteristica de la lista.", "Validación de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf lbl_campo1.Text = "FOTOGRAFIA" Then
                If MessageBox.Show("¿En verdad desea CAMBIAR la información de la base de datos para este registro? " & lbl_campo1.Text, "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    pik_foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                    Dim arrImage() As Byte = ms.GetBuffer

                    metodos.actualizar_Foto(txt_folio.Text, arrImage)
                    MessageBox.Show("Registro Modificado Correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LIMPIAR()
                End If

            ElseIf txt_campo1.Text = "" Then 'And piker_fecha.Visible = False Or txt_campo1.Text = "" And btn_foto.Visible = False Then
                MessageBox.Show("Indica el nuevo valor para la característica " & lbl_campo1.Text, "Validación de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf ListBox_datos.Text = "FOLIO" And txt_campo1.Text = metodos.valida_folio(txt_campo1.Text) Then
                MessageBox.Show("Estas intentando guardar un folio que ya existe en la base de datos, para evitar duplicarlo ingresa un nuevo folio diferente", "Validación de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                txt_campo1.Focus()
            Else

                If MessageBox.Show("¿En verdad desea CAMBIAR la información de la base de datos para el registro: " & lbl_campo1.Text & "?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    '  metodos.actualizar_info(txt_folio.Text, lbl_campo1.Text, campo_actualizar)
                    metodos.actualizar_info(txt_folio.Text.Trim, campo_actualizar, txt_campo1.Text.Trim)
                    MessageBox.Show("Registro Modificado Correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LIMPIAR()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Asegurate de que el folio ingresado sea correcto o que la entrada de datos sea correcta y no tenga caracteres especiales como (' * ¨) e inténtalo nuevamente. " & ex.Message, "Validación de registro", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        'VALIDAR ADMINISTRADOR
        If lbl_plantel_usuario.Text = "LEON - RECTORIA" And txt_folio.Text = metodos.valida_folio(txt_folio.Text) Then
            CARGAR_DATOS()
            btn_actualizar.Enabled = True
        Else

            Dim valida_plantel = metodos.valida_Plantel(txt_folio.Text)
            If lbl_plantel_usuario.Text = valida_plantel Then
                CARGAR_DATOS()
                btn_actualizar.Enabled = True
            Else
                MessageBox.Show("El folio no existe ó no pertenece al plantel " & lbl_plantel_usuario.Text & ", por favor verifique el folio.", "Validando folios", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                LIMPIAR()
            End If

        End If

    End Sub

    Public Sub CARGAR_DATOS()
        'CARGAR NOMBRE E IMAGEN DEL ALUMNO
        Dim foto As Object = Nothing
        Dim imagen As Byte() = Nothing
        Dim bitmap As Bitmap
        Dim mem As MemoryStream
        Try
            metodos.ver_actualizar(txt_folio.Text, txt_alumno.Text, foto)
            imagen = foto
            mem = New MemoryStream(imagen)
            bitmap = New Bitmap(mem)
            pik_foto.Image = bitmap

        Catch ex As Exception
            pik_foto.Image = Nothing
        End Try
    End Sub

    Public Sub LIMPIAR()
        txt_folio.Text = ""
        txt_alumno.Text = ""
        txt_campo1.Text = ""
        lbl_campo1.Text = "CAMPO A ACTUALIZAR"
        btn_actualizar.Enabled = False
    End Sub

    Private Sub piker_fecha_ValueChanged(sender As Object, e As EventArgs) Handles piker_fecha.ValueChanged
        txt_campo1.Text = piker_fecha.Value.ToString("dd/MM/yy")
    End Sub


    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planteles_DataSet.Planteles' Puede moverla o quitarla según sea necesario.

        Try
            Me.PlantelesTableAdapter.Fill(Me.Planteles_DataSet.Planteles)
            'TODO: esta línea de código carga datos en la tabla 'Planteles_DataSet.Planteles' Puede moverla o quitarla según sea necesario.
            Me.PlantelesTableAdapter.Fill(Me.Planteles_DataSet.Planteles)
            lbl_plantel_usuario.Text = Bienvenida.lbl_plantel_usuario.Text
            txt_folio.Text = ""
            btn_actualizar.Enabled = False
            cb_plantel.SelectedItem = Nothing
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Actualizar" & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
       
    End Sub

    Private Sub cb_plantel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_plantel.SelectionChangeCommitted
        txt_campo1.Text = cb_plantel.Text
    End Sub

    Private Sub ComboBox_Hijos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_Hijos.SelectionChangeCommitted
        txt_campo1.Text = ComboBox_Hijos.Text
    End Sub

    Private Sub ComboBox_Embarazo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox_Embarazo.SelectionChangeCommitted
        txt_campo1.Text = ComboBox_Embarazo.Text
    End Sub
End Class