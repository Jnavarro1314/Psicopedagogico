Imports System.Data.SqlClient
Imports System.IO

Public Class MetodosSQL
    Dim SQL_CConexion As New Conexion
    Dim ccadena As New SqlConnection
    Dim oDataReader As SqlDataReader
    Dim sql As String
    Dim cmd As SqlCommand
    Dim SQL_Conexion As New Conexion

    Public Sub valida_version(ByRef vers, ByRef url)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        sql = "Select * from Versiones where Id_Programa=2"
        Dim cmd As New SqlCommand(sql, ccadena)
        oDataReader = cmd.ExecuteReader()
        While oDataReader.Read()
            vers = oDataReader("Version_Prog")
            url = oDataReader("URL")
        End While
        oDataReader.Close()
        ccadena.Close()
    End Sub

    Public Sub RegistrarPermisos(ByVal NumEmp, ByVal Permiso, ByVal correo, ByVal Clave)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        sql = "INSERT INTO Ps_Permisos VALUES(" & NumEmp & ",'" & Permiso & "','" & correo & "','" & Clave & "')"
        cmd = New SqlCommand(sql, ccadena)
        cmd.ExecuteNonQuery()
        ccadena.Close()
    End Sub
    Public Sub Descargar_Fotos()
        Dim dt As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dt)
        ccadena = SQL_Conexion.SQL_Corporativo
        ccadena.Open()
        Dim da As New SqlDataAdapter("select Fotografia,RutaFoto,Nombre, No from Empleados where status = 'ACTIVO' and no = 2253", ccadena)

        da.Fill(dt)

        ccadena.Close()

        For Each datarow In dt.Rows

            Dim Extencion As String = datarow.item(3) & Path.GetExtension(datarow.item(1))
            Dim nSave As String = "E:\Fotos\" & Extencion '& nombreFicheroBDD

            Dim arrImg() As Byte = datarow.item(0)

            Dim ms As MemoryStream = New MemoryStream(arrImg)
            Dim fs As FileStream = New FileStream(nSave, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

            ms.WriteTo(fs)

            fs.Flush()
            fs.Close()
            ms.Close()
            ' Grid.Rows.Add(Extencion, datarow.item(2), datarow.item(3), datarow.item(5), datarow.item(6))
        Next
        MsgBox("Echo")
    End Sub

    Public Sub RegistrarUsuario(ByVal nombre, ByVal apellidos, ByVal plantel, ByVal depto, ByVal puesto, ByVal tipo_cuenta, ByVal usuario, ByVal clave)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        sql = "insert into Ps_Usuarios values('" & nombre & "','" & apellidos & "','" & plantel & "','" & depto & "','" &
            puesto & "','" & tipo_cuenta & "','" & usuario & "','" & clave & "','ACTIVO')"
        Dim cmd As New SqlCommand(sql, ccadena)
        cmd.ExecuteNonQuery()
        ccadena.Close()
    End Sub

    Public Function valida_usuarios_duplicados(ByVal usuario)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim us As String = ""
        sql = "select usuario from Ps_Usuarios where usuario='" & usuario & "'"
        Dim cmd As New SqlCommand(sql, ccadena)
        oDataReader = cmd.ExecuteReader()
        While oDataReader.Read()
            us = oDataReader("usuario")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return us
    End Function

    'Public Sub valida_usuario(ByVal usuario, ByVal clave, ByRef campo1, ByRef campo2, ByVal clase, ByRef tipo_cuenta, ByRef estatus)
    '    ccadena.Close()
    '    ccadena = SQL_CConexion.SQL_Conexion
    '    ccadena.Open()

    '    If clase = "Acceso" Then
    '        sql = "select usuario as campo1,clave as campo2,cuenta, estatus from Ps_Usuarios where usuario='" &
    '            usuario & "' and clave='" & clave & "'"
    '    Else
    '        sql = "select nombre+' '+apellidos as campo1, plantel as campo2,cuenta, estatus from Ps_Usuarios where usuario='" &
    '            usuario & "' and clave='" & clave & "'"
    '    End If

    '    Dim cmd As New SqlCommand(sql, ccadena)
    '    oDataReader = cmd.ExecuteReader()
    '    While oDataReader.Read()
    '        campo1 = oDataReader("campo1")
    '        campo2 = oDataReader("campo2")
    '        tipo_cuenta = oDataReader("cuenta")
    '        estatus = oDataReader("estatus")
    '    End While
    '    oDataReader.Close()
    '    ccadena.Close()
    'End Sub

    'VALIDAR USUARIO PARA VER LOS RESULTADOS - saii
    Public Sub ConsultarBDSaii(ByVal NumEmp, ByRef nombre, ByRef apellidos, ByRef sede, ByRef depto, ByRef puesto, ByRef foto, ByRef clave)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Corporativo
        ccadena.Open()

        If foto = "Login" Then
            sql = "select idd+ClaveEmp as clave,nombres,apaterno+' '+amaterno as apellidos,sede,departamento,puesto,fotografia from Empleados  where status<>'baja' AND no=" & NumEmp
        Else
            sql = "select idd+ClaveEmp as clave,nombres,apaterno+' '+amaterno as apellidos,sede,departamento,puesto,fotografia from Empleados  where (departamento ='DESARROLLO INTEGRAL' AND PUESTO <>'COORDINADOR' AND Status<>'BAJA' AND no = " & NumEmp & ") OR (PUESTO = 'PSICOPEDAGOGO' AND Status<>'BAJA' AND no = " & NumEmp & ") "
        End If

        Dim cmd As New SqlCommand(sql, ccadena)
        oDataReader = cmd.ExecuteReader()
        While oDataReader.Read()
            foto = oDataReader("fotografia")
            nombre = oDataReader("nombres")
            apellidos = oDataReader("apellidos")
            sede = oDataReader("sede")
            depto = oDataReader("departamento")
            puesto = oDataReader("puesto")
            clave = oDataReader("clave")
        End While
        oDataReader.Close()
        ccadena.Close()
    End Sub

    Public Sub ConsultarPermisos(ByVal NumEmp, ByRef Permiso, ByRef Clave)
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "select permiso,clave from Ps_Permisos where no=" & NumEmp
        Try
            cmd = New SqlCommand(sql, ccadena)
            oDataReader = cmd.ExecuteReader()
            While oDataReader.Read()
                Permiso = oDataReader("permiso")
                Clave = oDataReader("clave")
            End While
            oDataReader.Close()
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub insertar_info(ByVal a, b, c, d, e, f, g, h, i, j, k, l, ll, m, n, ñ, o, p, q, r, rr, s, t, u, v, w, x, y, z, aa, ab, ac, ad,
                             ae, af, ag, ah, ai, aj, ak, al, am, b1, b2, b3, b4, C1, C2, C3, d1, d2, d3, d4, d5, d6, usuario, Embarazo, hijos)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        sql = "insert into Ps_Info_alumno values('" & a & "',(SELECT CONVERT(VARCHAR(10), GETDATE(), 105)),'" & b & "'," & c & ",'" & d & "','" & e & "','" & f & "','" &
            g & "','" & h & "','" & i & "','" & j & "','" & k & "','" & l & "','" & ll & "','" & m & "','" & n & "','" & ñ & "','" & o & "','" & p & "','" & q & "','" &
            r & "','" & rr & "','" & s & "','" & t & "','" & u & "','" & v & "','" & w & "','" & x & "','" & y & "','" & z & "','" & aa & "','" & ab & "','" & ac & "','" &
            ad & "','" & ae & "','" & af & "','" & ag & "','" & ah & "','" & ai & "','" & aj & "','" & ak & "','" & al & "','" & am & "','" & b1 & "','" & b2 & "','" &
            b3 & "','" & b4 & "','" & C1 & "','" & C2 & "','" & C3 & "','" & d1 & "','" & d2 & "','" & d3 & "','" & d4 & "','" & d5 & "','" & d6 & "','" & usuario & "','" & Embarazo & "','" & hijos & "')"
        Dim cmd As New SqlCommand(sql, ccadena)
        cmd.ExecuteNonQuery()
        ccadena.Close()
        'am y ak
    End Sub

    Public Sub imagen(ByVal folio, ByVal imagen)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        If imagen = "S/I" Then
            sql = "INSERT INTO Ps_Imagen(imagen,folio) VALUES(@foto,'" & folio & "')"
            Dim cmd As New SqlCommand(sql, ccadena)
            cmd.Parameters.Add("@foto", SqlDbType.VarChar)
            cmd.Parameters("@foto").Value = imagen
            cmd.ExecuteNonQuery()
        Else
            sql = "INSERT INTO Ps_Imagen(imagen,folio) VALUES(@foto,'" & folio & "')"
            Dim cmd As New SqlCommand(sql, ccadena)
            cmd.Parameters.Add("@foto", SqlDbType.Image)
            cmd.Parameters("@foto").Value = imagen
            cmd.ExecuteNonQuery()
        End If

        ccadena.Close()
    End Sub

    Public Function total(ByVal plantel)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim registros As String = ""
        If plantel = "LEON - RECTORIA" Then
            sql = "select COUNT(folio) as registros from Ps_Info_alumno"
        Else
            sql = "select COUNT(folio) as registros from Ps_Info_alumno where plantel='" & plantel & "'"
        End If
        Dim cmd As New SqlCommand(sql, ccadena)
        oDataReader = cmd.ExecuteReader()
        While oDataReader.Read()
            registros = oDataReader("registros")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return registros
    End Function

    Public Sub estadisticas(ByVal plantel, ByRef discapacidad, ByRef adiccion, ByRef enfermedad, ByVal Inicio, ByVal Final)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim sql1 As String = "select COUNT(folio) as discapacidad from Ps_Info_alumno where discapacidad <> 'NINGUNA' and discapacidad <> 'S/I' and plantel='" & plantel & "' and fecha_captura between '" & Inicio & "' and '" & Final & "' "
        Dim cmd1 As New SqlCommand(sql1, ccadena)
        oDataReader = cmd1.ExecuteReader()
        While oDataReader.Read()
            discapacidad = oDataReader("discapacidad")
        End While
        oDataReader.Close()

        Dim sql2 As String = "select COUNT(folio) as adiccion from Ps_Info_alumno where adiccion <> 'NINGUNA' and adiccion <> 'S/I' and plantel='" & plantel & "' and fecha_captura between '" & Inicio & "' and '" & Final & "'  "
        Dim cmd2 As New SqlCommand(sql2, ccadena)
        oDataReader = cmd2.ExecuteReader()
        While oDataReader.Read()
            adiccion = oDataReader("adiccion")
        End While
        oDataReader.Close()

        Dim sql3 As String = "select COUNT(folio) as enfermedad from Ps_Info_alumno where enfermedad <> 'NINGUNA' and enfermedad <> 'S/I' and plantel='" & plantel & "' and fecha_captura between '" & Inicio & "' and '" & Final & "'  "
        Dim cmd3 As New SqlCommand(sql3, ccadena)
        oDataReader = cmd3.ExecuteReader()
        While oDataReader.Read()
            enfermedad = oDataReader("enfermedad")
        End While
        oDataReader.Close()
        ccadena.Close()
    End Sub


    'GRAFICA POR PLANTEL DE TODOS LOS CAMPOS

    Public Sub obtener_datos_grafica(ByVal valor As String, ByVal campo1 As String, ByVal condicion As String, ByRef ds As DataSet, ByVal Inicio As String, ByVal Final As String)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        If condicion = "TODO" Then
            sql = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno  where fecha_captura between '" & Inicio & "' and '" & Final & "' " &
                 "group by " & campo1 & " having COUNT(" & campo1 & ") >0"
        Else
            sql = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno where " &
                condicion & "='" & valor & "' and  fecha_captura between '" & Inicio & "' and '" & Final & "' group by " & campo1 & " having COUNT(" & campo1 & ") >0"
        End If

        Dim da As New SqlDataAdapter(sql, ccadena)
        da.Fill(ds.Tables("DtGraficos"))


        ccadena.Close()
    End Sub
    'Public Sub obtener_datos_grafica(ByVal valor As String, ByVal campo1 As String, ByVal condicion As String, ByRef dt As DataTable)
    '    ccadena.Close()
    '    ccadena = SQL_CConexion.SQL_Conexion
    '    ccadena.Open()

    '    If condicion = "TODO" Then
    '        sql = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno " &
    '             "group by " & campo1 & " having COUNT(" & campo1 & ") >0"
    '    Else
    '        sql = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno where " &
    '            condicion & "='" & valor & "' group by " & campo1 & " having COUNT(" & campo1 & ") >0"
    '    End If

    '    Dim da As New SqlDataAdapter(sql, ccadena)
    '    da.Fill(dt)


    '    ccadena.Close()
    'End Sub

    Public Sub obtener_datos_multiple(ByVal valor As String, ByVal campo1 As String, ByVal condicion As String, dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim sql1 As String
        If condicion = "TODO" Then
            sql1 = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno group by " & campo1 & " having COUNT(" & campo1 & ") >0"
        Else
            sql1 = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno where " &
                condicion & "='" & valor & "' group by " & campo1 & " having COUNT(" & campo1 & ") >0"
        End If

        Dim da As New SqlDataAdapter(sql1, ccadena)
        da.Fill(dt)
        ccadena.Close()
    End Sub

    'Public Sub obtener_datos_multiple(ByVal plantel As String, ByVal campo1 As String, dt As DataTable)
    '    ccadena.Close()
    '    ccadena = SQL_CConexion.SQL_Conexion
    '    ccadena.Open()
    '    Dim sql1 As String
    '    sql1 = "SELECT " & campo1 & " as campo1,COUNT(" & campo1 & ") as cuantos FROM Ps_Info_alumno where plantel='" & plantel & "' " &
    '            "group by " & campo1 & " having COUNT(" & campo1 & ") >0"
    '    Dim da As New SqlDataAdapter(sql1, ccadena)
    '    da.Fill(dt)
    '    ccadena.Close()
    'End Sub

    Public Sub obtener_datos_multiple2(ByVal plantel As String, ByVal campo1 As String, ByVal campo2 As String, ByVal campo3 As String,
                                       dt As DataTable, ByVal VAR1 As String, ByVal VAR2 As String, ByVal VAR3 As String)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "select " & campo1 & " as campo1," & campo2 & " as campo2," & campo3 & " as campo3, COUNT(" & campo1 & ") as cuantos " &
        "from Ps_Info_alumno where plantel='" & plantel & "' " &
        "and  " & campo1 & " ='" & VAR1 & "' and  " & campo2 & " ='" & VAR2 & "' and  " & campo3 & " ='" & VAR3 & "' " &
        "group by " & campo1 & " ," & campo2 & "," & campo3 & " having COUNT(" & campo1 & ") >0"

        Dim da As New SqlDataAdapter(sql, ccadena)
        da.Fill(dt)
        ccadena.Close()
    End Sub


    'PROCEDIMIENTO PARA FORMATO DE CANALIZACION
    Public Sub proc_consulta(ByVal folio As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_Canalizacion", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@folio_alumno", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@folio_alumno").Value = folio

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub proc_verTodo(ByVal folio As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_ver_todo", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@folio", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@folio").Value = folio

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub proc_verPorPlantel(ByVal campo As String, ByVal valor As String, ByRef dt As DataSet)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        ' dt = New DataSet
        Dim da As New SqlDataAdapter("Ps_Ver_por_plantel", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@campo", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@campo").Value = campo
        da.SelectCommand.Parameters.Add("@valor", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@valor").Value = valor

        da.Fill(dt, "DTInformacion")
        ' da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub proc_Estadisticas(ByVal problema As String, ByVal plantel As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_Estadisticas", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@problema", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@problema").Value = problema
        da.SelectCommand.Parameters.Add("@plantel", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@plantel").Value = plantel

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Function valida_folio(ByVal codigo)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim codigo_repetido As String = ""
        sql = "SELECT folio FROM Ps_Info_alumno where folio= '" & codigo & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            codigo_repetido = oDataReader("folio")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return codigo_repetido
    End Function

    Public Function valida_matricula(ByVal codigo)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim codigo_repetido As String = ""
        sql = "SELECT matricula FROM Ps_Info_alumno where matricula= '" & codigo & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            codigo_repetido = oDataReader("matricula")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return codigo_repetido
    End Function
    'VER NOMBRE DEL ALUMNO Y FOTOGRAFIA
    Public Sub ver_actualizar(ByVal codigo, ByRef nombre, ByRef foto)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "SELECT a.nombre,i.imagen as 'foto_png' FROM Ps_Info_alumno as a join ps_Imagen as i on a.folio=i.folio where a.folio='" & codigo & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            nombre = oDataReader("nombre")
            foto = oDataReader("foto_png")
        End While
        oDataReader.Close()
        ccadena.Close()
    End Sub

    'ACTUALIZAR
    Public Sub actualizar_info(ByVal codigo, ByVal campo1, ByVal textbox)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "UPDATE Ps_Info_alumno set " & campo1 & "='" & textbox & "' where folio= '" & codigo & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        cmd_dir.ExecuteNonQuery()
        ccadena.Close()
    End Sub

    'VERIFICAR FOLIO Y PLANTEL USUARIO INVITADO
    Public Function valida_Plantel(ByVal codigo)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim plantel As String = ""

        sql = "SELECT plantel FROM Ps_Info_alumno where folio= '" & codigo & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            plantel = oDataReader("plantel")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return plantel
    End Function


    'ACTUALIZAR FOTO
    Public Sub actualizar_Foto(ByVal codigo, ByVal imagen)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim eliminar As String = ""
        ' sql = "UPDATE IMAGEN set imagen=@foto where folio='" & codigo & "'"
        eliminar = "delete from Ps_Imagen where folio='" & codigo & "'"
        Dim cmd_dir As New SqlCommand(eliminar, ccadena)
        cmd_dir.ExecuteNonQuery()

        sql = "insert into Ps_Imagen values('" & codigo & "',@foto)"
        Dim cmd As New SqlCommand(sql, ccadena)
        cmd.Parameters.Add("@foto", SqlDbType.Image)
        cmd.Parameters("@foto").Value = imagen
        cmd.ExecuteNonQuery()
        ccadena.Close()
    End Sub

    Public Sub ver_usuarios(ByVal plantel As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        sql = "select No as 'Número de Empleado',Clave as 'Contraseña',Permiso,Correo from Ps_Permisos order by id"

        'If plantel = "" Then
        '    sql = "select plantel AS PLANTEL, nombre as NOMBRE,apellidos AS APELLIDOS,usuario AS USUARIO, " &
        '        " clave AS CONTRASEÑA, cuenta AS CUENTA, departamento AS DEPARTAMENTO, puesto AS PUESTO from Ps_Usuarios " &
        '        " WHERE estatus='ACTIVO' order by id"
        'Else
        '    sql = "select plantel AS PLANTEL, nombre as NOMBRE,apellidos AS APELLIDOS,usuario AS USUARIO, " &
        '        " clave AS CONTRASEÑA, cuenta AS CUENTA, departamento AS DEPARTAMENTO, puesto AS PUESTO from Ps_Usuarios" &
        '        " where estatus='ACTIVO' and plantel='" & plantel & "' order by id"
        'End If
        dt = New DataTable
        Dim da As New SqlDataAdapter(sql, ccadena)
        da.SelectCommand.CommandType = CommandType.Text

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub quitar_dela_lista(ByVal usuario)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim vaciar As String
        'vaciar = "update Ps_Usuarios set estatus='INACTIVO' where usuario='" & usuario & "'"
        vaciar = "delete from Ps_Permisos where no=" & usuario
        Dim cmd_insert As New SqlCommand(vaciar, ccadena)
        cmd_insert.ExecuteNonQuery()
        ccadena.Close()
    End Sub

    Public Function verifica_folio_Actualizar()
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim plantel As String = ""

        sql = "SELECT folio FROM Ps_Info_alumno"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            plantel = oDataReader("folio")
        End While
        oDataReader.Close()
        ccadena.Close()
        Return plantel
    End Function

    Public Sub proc_sintesis(ByVal fecha_inicio As String, ByVal fecha_fin As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_Sintesis_semanal", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        da.SelectCommand.Parameters.Add("@fecha_final", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@fecha_final").Value = fecha_fin

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub PROC_SINTESIS2(ByVal fecha_inicio As String, ByVal fecha_fin As String, ByRef dt As DataTable, ByVal plantel As String)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_Sintesis_semanal", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        da.SelectCommand.Parameters.Add("@fecha_final", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@fecha_final").Value = fecha_fin
        da.SelectCommand.Parameters.Add("@ciudad", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@ciudad").Value = plantel

        da.Fill(dt)
        ccadena.Close()
    End Sub



    Public Sub ciudad_invitado(ByVal ciudad As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "select distinct plantel from Ps_Info_alumno where plantel like'%" & ciudad & "%'"
        dt = New DataTable
        Dim da As New SqlDataAdapter(sql, ccadena)
        da.SelectCommand.CommandType = CommandType.Text

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub invitado_vertodo(ByVal ciudad As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "select folio as 'FOLIO',matricula AS 'MATRICULA', nombre as 'NOMBRE', edad as 'EDAD',curp as 'CURP',direccion AS 'DIRECCION'," &
              "telefono AS 'TELEFONO', ciudad AS 'CIUDAD', plantel AS 'PLANTEL',grado AS 'GRADO',especialidad AS 'ESPECIALIDAD'," &
              "turno AS 'TURNO', discapacidad AS 'DISCAPACIDAD', adiccion AS 'ADICCION',enfermedad AS 'ENFERMEDAD'," &
              "trabaja AS 'TRABAJA',sexo AS 'SEXO',vive_con AS 'VIVE CON'," &
              "p_vive AS 'PADRE VIVE',p_nombre AS 'NOMBRE PADRE',p_edad AS 'EDAD PADRE', p_grado AS 'ESTUDIOS PADRE'," &
              "p_EdoCivil AS 'EDO.CIVIL PADRE', p_discapacidad AS 'DISCAPACIDAD PADRE', p_adiccion AS 'ADICCION PADRE'," &
              "p_enfermedad AS 'ENFERMEDAD PADRE',p_religion AS 'RELIGION PADRE', p_trabaja AS 'EL PADRE TRABAJA'," &
              "p_labor AS 'LABOR PADRE', " &
              "m_vive AS 'MADRE VIVE', m_nombre AS 'NOMBRE MADRE', m_edad AS 'EDAD MADRE',m_grado AS 'ESTUDIOS MADRE'," &
              "m_EdoCivil AS 'EDO.CIVIL MADRE', m_discapacidad AS 'DISCAPACIDAD MADRE', m_adiccion AS 'ADICCION MADRE'," &
              "m_enfermedad AS 'ENFERMEDAD MADRE',m_religion AS 'RELIGION MADRE', m_trabaja as 'MADRE TRABAJA'," &
              "m_labor AS 'LABOR MADRE'," &
              "hermanos AS 'TOTAL HERMANOS',casa AS 'VIVIE EN CASA', familia AS 'CANT.HABITANTES'," &
              "fecha_can AS 'FECHA CANALIZACION', motivo_can AS 'MOTIVO CANALIZACION', atencion AS 'ATENCION'," &
              "motivo_consulta as 'MOTIVO CONSULTA', lugar_can as 'LUGAR CANALIZACION', unidad as 'UNIDAD'" &
              "  ,violencia as 'VIOLENCIA',consumo_sustancias AS 'CONSUMO DE SUSTANCIAS',depresion AS 'DEPRESION'," &
              "transtornos_alimentacion AS 'TRANSTORNOS DE ALIMENTACION',deficit_atencion AS 'DEFICIT DE ATENCION'," &
              "intervencion_crisis AS 'INTERVENCION EN CRISIS'" &
              " where plantel like'%" & ciudad & "%' order by fecha_captura,plantel"
        dt = New DataTable
        Dim da As New SqlDataAdapter(sql, ccadena)
        da.SelectCommand.CommandType = CommandType.Text

        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub ConsultaRectoria(ByVal plantel As String, ByRef dt As DataSet)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()

        sql = "select nombre as 'NOMBRE', curp as 'CURP',direccion AS 'DIRECCION', ciudad AS 'CIUDAD', " &
            "plantel AS 'PLANTEL',grado AS 'GRADO',especialidad AS 'ESPECIALIDAD',  turno AS 'TURNO', " &
            "fecha_can AS 'FECHA CANALIZACION', motivo_can AS 'MOTIVO CANALIZACION' " &
            "from Ps_Info_alumno where plantel='" & plantel & "'"
        ' dt = New DataTable
        Dim da As New SqlDataAdapter(sql, ccadena)
        da.SelectCommand.CommandType = CommandType.Text

        da.Fill(dt, "DTInformacion")
        ccadena.Close()
    End Sub

    Public Sub filtro_plantel(ByVal plantel, ByRef ciudad, ByRef estado)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Sedes
        ccadena.Open()

        sql = "select Ciudad,EstadoRegion from Planteles where Sede='" & plantel & "'"
        Dim cmd_dir As New SqlCommand(sql, ccadena)
        oDataReader = cmd_dir.ExecuteReader()
        While oDataReader.Read()
            ciudad = oDataReader("Ciudad")
            estado = oDataReader("EstadoRegion")
        End While
        oDataReader.Close()
        ccadena.Close()
    End Sub

    Public Sub CargarSedes(ByRef dt As DataTable)
        Try
            ccadena = SQL_CConexion.SQL_Sedes
            ccadena.Open()
            dt = New DataTable
            'sql = "SELECT distinct Ciudad,Sede FROM dbo.Planteles order by sede"
            sql = "select Sede from Planteles order by sede"
            Dim dataadapter As New SqlDataAdapter(sql, ccadena)
            dataadapter.Fill(dt)
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub
    Public Sub ciudades(ByRef dt As DataTable)
        Try
            ccadena = SQL_CConexion.SQL_Sedes
            ccadena.Open()
            dt = New DataTable
            sql = "SELECT distinct Ciudad FROM dbo.Planteles order by ciudad"
            Dim dataadapter As New SqlDataAdapter(sql, ccadena)
            dataadapter.Fill(dt)
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub FiltroXCiudad(ByVal ciudad As String, ByRef dt As DataTable)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Sedes
        ccadena.Open()
        sql = "select sede from planteles where ciudad='" & ciudad & "' order by sede"
        dt = New DataTable
        Dim da As New SqlDataAdapter(sql, ccadena)
        da.SelectCommand.CommandType = CommandType.Text
        da.Fill(dt)
        ccadena.Close()
    End Sub

    Public Sub insert_grafico(ByVal TEMA, ByVal PLANTEL, ByVal CD, ByVal EDO, ByVal NIVEL, ByVal ESPEC, ByVal NOMBRE, ByVal TITULO, ByVal PON_ESPEC,
                              ByVal TEL, ByVal EXPER, ByVal INST, ByVal RES1_N, ByVal RES1_P, ByVal RES2_N, ByVal RES2_P, ByVal TOT1, ByVal TOT2,
                              ByVal FECHA, ByVal HORA, ByRef OBSERV, ByVal USUARIO)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim INSERT As String = "INSERT INTO PS_Grupos VALUES('" & TEMA & "','" & PLANTEL & "','" & CD & "','" & EDO & "','" & NIVEL & "','" & ESPEC &
            "','" & NOMBRE & "','" & TITULO & "','" & PON_ESPEC & "','" & TEL & "','" & EXPER & "','" & INST & "','" & RES1_N & "','" & RES1_P & "','" &
            RES2_N & "','" & RES2_P & "'," & TOT1 & "," & TOT2 & ",'" & FECHA & "','" & HORA & "','" & OBSERV & "','" & USUARIO & "',GETDATE())"
        Dim cmd_insert As New SqlCommand(INSERT, ccadena)
        cmd_insert.ExecuteNonQuery()
        ccadena.Close()
    End Sub

    Public Sub ConsultaGrupos(ByVal ID As String, ByVal plantel As String, ByVal fecha_inicio As String, ByVal fecha_fin As String, ByVal tema As String, ByRef dt As DataSet)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        'dt = New DataTable
        Dim da As New SqlDataAdapter("Ps_ProcGrupos", ccadena)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@ID").Value = ID
        da.SelectCommand.Parameters.Add("@PLANTEL", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@PLANTEL").Value = plantel

        da.SelectCommand.Parameters.Add("@FECHA1", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@FECHA1").Value = fecha_inicio
        da.SelectCommand.Parameters.Add("@FECHA2", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@FECHA2").Value = fecha_fin
        da.SelectCommand.Parameters.Add("@TEMA", SqlDbType.VarChar)
        da.SelectCommand.Parameters("@TEMA").Value = tema

        da.Fill(dt, "InfoGrupos")
        ccadena.Close()
    End Sub

    '---GUARDAR MANUAL PDF
    Public Sub GuardarManual(ByVal pdf)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()

            sql = "UPDATE Versiones SET Instalador=@foto WHERE Id_Programa=2"
            Dim cmd As New SqlCommand(sql, ccadena)
            cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = pdf
            'cmd.Parameters("@foto").Value = pdf()
            cmd.ExecuteNonQuery()
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub DescargarManual(ByRef Manual)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()
            sql = "SELECT Instalador FROM Versiones WHERE Id_Programa=2"
            Dim comand As New SqlCommand(sql, ccadena)
            oDataReader = comand.ExecuteReader()
            While oDataReader.Read()
                Manual = oDataReader("Instalador")
            End While
            oDataReader.Close()
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub GuardarTamizaje(ByVal array() As String)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()

            sql = "Insert into Ps_Tamizaje values('" & array(0) & "','" & array(1) & "','" & array(2) & "','" & array(3) & "','" & array(4) & "','" &
            array(5) & "','" & array(6) & "','" & array(7) & "','" & array(8) & "','" & array(9) & "','" & array(10) & "','" & array(11) & "','" &
            array(12) & "','" & array(13) & "',GETDATE(),'" & array(14) & "')"

            Dim comand As New SqlCommand(sql, ccadena)
            comand.ExecuteNonQuery()
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub consultarTamizaje(ByRef ds As DataSet, ByVal plantel As String)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()

            If plantel = "" Then
                sql = "Select * from Ps_Tamizaje"
            Else
                sql = "Select * from Ps_Tamizaje where plantel='" & plantel & "'"
            End If

            Dim da As New SqlDataAdapter(sql, ccadena)
            da.Fill(ds.Tables("DtTamizaje"))

            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try

    End Sub

    Public Sub ConsultaVariable(ByRef dt As DataTable, ByVal campo As String, ByVal tabla As String, ByVal plantel As String)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()
            dt = New DataTable

            If plantel = "" Then
                sql = "Select distinct " & campo & " from " & tabla
            Else
                sql = "Select distinct " & campo & " from " & tabla & " where plantel='" & plantel & "'"
            End If

            Dim da As New SqlDataAdapter(sql, ccadena)
            da.Fill(dt)

            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub

    Public Sub GraficaRTamizaje(ByRef dt As DataTable, ByVal factor As String, ByVal sede As String)
        Try
            ccadena = SQL_CConexion.SQL_Conexion
            ccadena.Open()
            dt = New DataTable
            sql = "select " & factor & " as Factor,count(" & factor & ") as Total FROM Ps_Tamizaje where plantel='" &
                sede & "' group by " & factor & ""

            Dim da As New SqlDataAdapter(sql, ccadena)
            da.Fill(dt)
            ccadena.Close()
        Catch ex As Exception
            ccadena.Close()
        End Try
    End Sub
    Public Sub Descargar_Instalador(savetofolder As String, ByRef N_Instalador As String)
        ccadena = SQL_Conexion.SQL_Conexion
        Try
            Using ccadena = SQL_Conexion.SQL_Conexion
                Using cmd As SqlCommand = ccadena.CreateCommand
                    ccadena.Open()

                    cmd.CommandText = "select [Instalador],[N_Instalador] from Versiones where Nombre_Prog = 'PSICOPEDAGOGICO'"
                    cmd.CommandTimeout = 100000

                    Dim reader As SqlDataReader = Nothing

                    reader = cmd.ExecuteReader
                    reader.Read()

                    Dim nombreFicheroBDD As String = reader.Item(1)
                    N_Instalador = nombreFicheroBDD
                    Dim nSave As String = savetofolder & nombreFicheroBDD

                    Dim arrImg() As Byte = reader.Item(0)

                    Dim ms As MemoryStream = New MemoryStream(arrImg)
                    Dim fs As FileStream = New FileStream(nSave, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

                    ms.WriteTo(fs)

                    fs.Flush()
                    fs.Close()
                    ms.Close()
                    ccadena.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            ccadena.Close()
        End Try
    End Sub
    Public Sub Cargar_Instalador_ASiS(RutaDestino As String)

        Dim ms As MemoryStream = New MemoryStream()
        Dim fs As FileStream = New FileStream(RutaDestino, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

        ms.SetLength(fs.Length)
        fs.Read(ms.GetBuffer(), 0, fs.Length)
        Try
            Dim ArrDoc() As Byte = ms.GetBuffer()
            ms.Flush()
            fs.Close()

            ccadena = SQL_Conexion.SQL_Conexion
            ccadena.Open()

            Using cmd As SqlCommand = ccadena.CreateCommand()

                cmd.CommandText = "UPdate Versiones set [Instalador] = @Documento, [N_Instalador] = @N_Documento where Nombre_Prog = 'PSICOPEDAGOGICO'"
                cmd.Parameters.Add("@Documento", SqlDbType.VarBinary).Value = ArrDoc
                cmd.Parameters.Add("@N_Documento", SqlDbType.VarChar).Value = Path.GetFileName(RutaDestino)


                cmd.ExecuteNonQuery()
            End Using
            ms.Close()
            ccadena.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            ms.Close()
            ccadena.Close()
        End Try
    End Sub
    Public Sub Nuevo_Inventario(N_Serie As String, Nombre_PC As String, Tarjeta_Madre As String, DiscosDuros As String, Ram As String, Procesador As String, SO As String, IP_Local As String, IP_Publica As String, Fecha_Inventario As String, Plantel As String, Usuario As String)
        ccadena = SQL_Conexion.SQL_Conexion
        ccadena.Open()
        Try
            Dim Adapter As New SqlDataAdapter
            Adapter = New SqlDataAdapter("Insert into Inventario_CPU Values('" & N_Serie & "','" & Nombre_PC & "', '" & Tarjeta_Madre & "', '" & DiscosDuros & "','" & Ram & "','" & Procesador & "','" & SO & "', '" & IP_Local & "','" & IP_Publica & "','" & Fecha_Inventario & "', '" & Plantel & "','" & Usuario & "')", ccadena)
            Dim data As New DataSet
            Adapter.Fill(data, "Usuario")
            ccadena.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            ccadena.Close()
        End Try
    End Sub
    Public Sub Registrar_Asistencia(ByVal Matricula, ByVal Folio, ByVal Nombre, ByVal Plantel, ByVal Lugar_Atencion)
        ccadena.Close()
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Try
            sql = "insert into Ps_Registro_Asistencia values('" & Matricula & "','" & Folio & "','" & Nombre & "','" & Plantel & "','" & Lugar_Atencion & "', getdate())"
            Dim cmd As New SqlCommand(sql, ccadena)
            cmd.ExecuteNonQuery()
            ccadena.Close()
            MsgBox("Registro Guardado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se puedo guardar Intentelo nuevamente " & ex.Message, MsgBoxStyle.Critical)
            ccadena.Close()
        End Try
    End Sub
    Public Sub Select_Registro_Asistencia(ByRef tabla As Object, inicio As String, Final As String)
        ccadena = SQL_CConexion.SQL_Conexion
        ccadena.Open()
        Dim data As New DataSet
        Dim Linea As String
        Linea = "select [Matricula],[Folio],[Nombre],[Plantel],[Lugar_Atencion],[Fecha_Registro] from Ps_Registro_Asistencia where Fecha_Registro between '" & inicio & "' and '" & Final & "' order by id_Registro"

        Dim buscar As New SqlDataAdapter
        buscar = New SqlDataAdapter(Linea, ccadena)
        buscar.Fill(tabla, "Ps_Registro_Asistencia")
        'tabla.DataSource = data.Tables("x")
        ccadena.Close()
    End Sub

End Class
