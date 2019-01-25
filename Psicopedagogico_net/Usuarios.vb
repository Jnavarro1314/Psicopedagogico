Imports Datos
Imports Entidades
Imports System.IO

Public Class Usuarios
    Dim Funciones As New Funciones
    Dim Metodos As New MetodosSQL
    Dim ms = New System.IO.MemoryStream()   '--FOTO
    Dim nombre, apellido As String

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim foto As Object = Nothing
        Dim imagen As Byte() = Nothing
        Dim bitmap As Bitmap
        Dim mem As MemoryStream
        Try
            If txtNumEmp.Text = "" Then
                MessageBox.Show("Ingresa el número del empleado a buscar", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Metodos.ConsultarBDSaii(txtNumEmp.Text, nombre, apellido, txtPlantel.Text, txtDepto.Text, txtPuesto.Text, foto, txtClave.Text)

                If nombre = "" Then
                    MessageBox.Show("El número de empleado no se encontró en la base de datos como ejecutivo, no existe en el departamento o no esta Activo, intenta con otro número o verifica con Capital humano el estado del ejecutivo", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    limpiar()
                    BtnGuardar.Enabled = False
                Else
                    txtNombre.Text = nombre & " " & apellido
                    imagen = foto
                    mem = New MemoryStream(imagen)
                    bitmap = New Bitmap(mem)
                    PictureBox1.Image = bitmap
                    BtnGuardar.Enabled = True
                    nombre = ""
                    apellido = ""
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim validaUs As String = ""
            Metodos.ConsultarPermisos(txtNumEmp.Text, validaUs, "")

            If validaUs <> "" Then
                MessageBox.Show("Este usuario ya cuenta con permisos, puedes verificarlo en el menu -consultas-, categoría -usuarios-", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'ElseIf txtClave.Text = "" Then
                '    MessageBox.Show("Ingresa la contraseña", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtCorreo.Text = "" Then
                MessageBox.Show("Ingresa el correo INSTITUCIONAL", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf CBCuenta.Text = "" Then
                MessageBox.Show("Selecciona un permiso para el usuario", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If ValidarEmail(txtCorreo.Text) = False Then
                    MessageBox.Show("Ingresa un correo válido", "Validando Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Metodos.RegistrarPermisos(txtNumEmp.Text, CBCuenta.Text, txtCorreo.Text, txtClave.Text)
                    MessageBox.Show("Usuario Registrado Correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    limpiar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function ValidarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Public Sub limpiar()
        Try
            Funciones.Limpiar_Form(Me)
            Funciones.Limpiar_GB(GB_1)
            PictureBox1.Image = My.Resources.usuario1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class