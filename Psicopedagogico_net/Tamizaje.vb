Imports Entidades
Imports Datos

Public Class Tamizaje
    Dim misFunciones As New Funciones
    Dim Metodos As New MetodosSQL
    Dim dtTable As New DataTable
    Dim arreglo(14) As String
    Dim Grup As New Consulta_Grupos

    Private Sub Tamizaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Metodos.CargarSedes(dtTable)
            CBPlantel.DataSource = dtTable
            CBPlantel.ValueMember = "Sede"
        Catch ex As Exception
            Form_Error.RichTextBox_Error.Text = "Ocurrió un Error al Cargar Formulario Tamizaje " & My.Computer.Name & vbNewLine & ex.Message
            Form_Error.ShowDialog()
            Me.Close()

        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If misFunciones.RecorreControles(GBDatos) = True Or misFunciones.RecorreControles(PanelResultados) = True Then
                MessageBox.Show("Asegúrate de llenar los datos requeridos antes de continuar", "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                GridTamizaje.Rows.Add(txtAlumno.Text, NumEdad.Value, ComboSexo.Text, CBSuicida.Text, CBDepresion.Text,
                CBAnsiedad.Text, CBViolencia.Text, CBConsumo.Text, CBSustancias.Text, CBConductas.Text, "QUITAR")

                ' habilitarControles(False)
                txtAlumno.Focus()
                misFunciones.Limpiar_GB(PanelResultados)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridTamizaje_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTamizaje.CellContentClick
        Try
            If GridTamizaje.Rows(e.RowIndex).Cells(10).Selected Then
                GridTamizaje.Rows.RemoveAt(e.RowIndex)
                'habilitarControles(True)
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If misFunciones.RecorreControles(GBDatos) = True Then
                MessageBox.Show("Asegúrate de llenar los datos del alumno y plantel antes de continuar", "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf GridTamizaje.RowCount = 0 Then
                MessageBox.Show("Agrega los resultados del alumno antes de Guardar", "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                For i As Integer = 0 To GridTamizaje.RowCount - 1
                    llenarArrelo(i)
                    Metodos.GuardarTamizaje(arreglo)
                Next

                MessageBox.Show("Registro Guardado Correctamente", "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'habilitarControles(True)
                misFunciones.Limpiar_GB(GBDatos)
                misFunciones.Limpiar_GB(PanelResultados)
                GridTamizaje.Rows.Clear()

                BtnGraficar.Enabled = True
                BtnReporte.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub llenarArrelo(ByVal i As Integer)
        arreglo(0) = CBPlantel.Text
        arreglo(1) = txtGrupo.Text
        arreglo(2) = txtTurno.Text
        arreglo(3) = txtLugar.Text
        arreglo(4) = PickerFecha.Value
        arreglo(5) = GridTamizaje.Rows(i).Cells(0).Value
        arreglo(6) = GridTamizaje.Rows(i).Cells(1).Value
        arreglo(7) = GridTamizaje.Rows(i).Cells(2).Value
        arreglo(8) = GridTamizaje.Rows(i).Cells(3).Value
        arreglo(9) = GridTamizaje.Rows(i).Cells(4).Value
        arreglo(10) = GridTamizaje.Rows(i).Cells(5).Value
        arreglo(11) = GridTamizaje.Rows(i).Cells(6).Value
        arreglo(12) = GridTamizaje.Rows(i).Cells(7).Value & " - " & GridTamizaje.Rows(i).Cells(8).Value
        arreglo(13) = GridTamizaje.Rows(i).Cells(9).Value
        arreglo(14) = Bienvenida.lbl_nombre_usuario.Text

    End Sub

    Public Sub habilitarControles(ByVal bandera As Boolean)
        CBPlantel.Enabled = bandera
        txtTurno.Enabled = bandera
        txtGrupo.Enabled = bandera
        txtLugar.Enabled = bandera
        PickerFecha.Enabled = bandera
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            Grup.DsGrupos.Tables("DtTamizaje").Rows.Clear()

            Metodos.consultarTamizaje(Grup.DsGrupos, "")
            Dim visor As New CRVisor
            Dim cr As New rpt_Tamizaje

            cr.SetDatabaseLogon("Matriculado", "M4triculado.S3rver.")
            cr.SetDataSource(Grup.DsGrupos.Tables("DtTamizaje"))
            visor.CrystalReportViewer1.ReportSource = cr
            visor.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnGraficar_Click(sender As Object, e As EventArgs) Handles BtnGraficar.Click
        Try
            TamizajeGrafica.Show()
            TamizajeGrafica.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Psicopedagogico.Net", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridTamizaje_MouseClick(sender As Object, e As MouseEventArgs) Handles GridTamizaje.MouseClick
        Try
            If MouseButtons.Right = True Then
                Menu_Copiar.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Menu_Copiar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menu_Copiar.ItemClicked
        Try
            My.Computer.Clipboard.GetText()

            For Each line As String In Clipboard.GetText.Split(vbNewLine)
                Dim item() As String = line.Trim.Split(vbTab)

                If item(0) = "" Then
                    'nada
                Else
                    If item.Length < GridTamizaje.ColumnCount Then
                        GridTamizaje.Rows.Add(item)
                    End If
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub
End Class