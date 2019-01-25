Imports System.IO
Imports System.Math
Imports InfoSistema
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Management
Imports Datos

Public Class Inventario
    Dim info As New irInforSistema
    Dim Datos_Metodos As New MetodosSQL
    Public Usuario As String
    Public Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Usuario.Text = Bienvenida.lbl_nombre_usuario.Text
        Label_Plantel.Text = Bienvenida.lbl_plantel_usuario.Text
        Dim ejemplo As String = info.TotalDiscoDuro


        Dim drives As DriveInfo() = DriveInfo.GetDrives()

        For Each drive As DriveInfo In drives
            If drive.IsReady Then
                If RichTextBox_DiscosDuros.Text = Nothing Then
                    RichTextBox_DiscosDuros.Text = "Nombre: " & drive.Name & " Etiqueta: " & drive.VolumeLabel.ToString & vbNewLine & "Tamaño Total: " & Round(Convert.ToDouble(Val(Val(Val(drive.TotalSize) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine & "Espacio Libre: " & Round(Convert.ToDouble(Val(Val(Val(drive.TotalFreeSpace) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine & "Espacio Usado: " & Round(Convert.ToDouble(Val(Val(Val(Val(drive.TotalSize) - Val(drive.TotalFreeSpace)) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine
                Else
                    RichTextBox_DiscosDuros.Text = RichTextBox_DiscosDuros.Text & vbNewLine & "Nombre: " & drive.Name & " Etiqueta: " & drive.VolumeLabel.ToString & vbNewLine & "Tamaño Total: " & Round(Convert.ToDouble(Val(Val(Val(drive.TotalSize) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine & "Espacio Libre: " & Round(Convert.ToDouble(Val(Val(Val(drive.TotalFreeSpace) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine & "Espacio Usado: " & Round(Convert.ToDouble(Val(Val(Val(Val(drive.TotalSize) - Val(drive.TotalFreeSpace)) / 1024) / 1024) / 1024), 2) & "GB" & vbNewLine
                End If

            End If
        Next
        Label_Ram.Text = Round(Convert.ToDouble(Val(Val(Val(info.TotalMemoriaFisica) / 1024) / 1024) / 1024), 2) & " GB"
        Label_Nombre.Text = info.NombreComputador
        Label_Procesador.Text = info.NombreProcesador
        Label_SO.Text = info.NombreSistemaOperativo
        Label_IPLocal.Text = getIp()
        Label_Tarjeta_Madre.Text = info.DescripcionTarjetaVideo

        ' MsgBox(getIp() & "  ")
        Dim mos As New ManagementObjectSearcher("root\CIMV2", _
                                        "SELECT * FROM Win32_BaseBoard")

        For Each mo As ManagementObject In mos.Get()
            Try
                Label_Serie.Text = mo.GetPropertyValue("SerialNumber").ToString

                Label_Tarjeta_Madre.Text = "Marca: " & _
                                        mo.GetPropertyValue("Manufacturer").ToString & " " & _
                "Modelo: " & _
                                        mo.GetPropertyValue("Product").ToString
            Catch
            End Try
        Next
        Try
            Dim MIWEBCLIENT As New WebClient
            Dim MIHTML As String = MIWEBCLIENT.DownloadString("http://www.cualesmiip.com/")
            Dim MIIP As String = MIHTML
            MIIP = MIIP.Remove(0, MIIP.IndexOf("Tu IP real es") + 14)
            MIIP = MIIP.Substring(0, MIIP.IndexOf("(") - 1)
            Label_IPPublica.Text = MIIP
        Catch ex As Exception
            MsgBox("PROBLEMAS CON LA IP PUBLICA")
        End Try
        Dim readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\TeamViewer", "ClientID", Nothing)
        Label_IPLocal.Text = Label_IPLocal.Text & " - " & readValue
        ' MsgBox("The value is " & readValue)
    End Sub
    Public Function getIp() As String
        Dim valorIp As String
        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()

        Return valorIp
    End Function

    Public Sub Button_Guardar_Click(sender As Object, e As EventArgs) Handles Button_Guardar.Click
        Dim mensaje As MsgBoxResult
        If Not File.Exists("C:\PSICOPEDAGOGICO\FechaInventario_CPU.txt") Then
            'Directory.CreateDirectory("C:\ASiS\Inventario_CPU.txt")
            Dim ruta As String = "C:\PSICOPEDAGOGICO\FechaInventario_CPU.txt"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(DateTime.Now.ToString)
            escritor.Flush()
            escritor.Close()
            Datos_Metodos.Nuevo_Inventario(Label_Serie.Text, Label_Nombre.Text, Label_Tarjeta_Madre.Text, RichTextBox_DiscosDuros.Text, Label_Ram.Text, Label_Procesador.Text,
                                           Label_SO.Text, Label_IPLocal.Text, Label_IPPublica.Text, DateTime.Now.ToShortDateString, Bienvenida.lbl_plantel_usuario.Text, Usuario)
            MsgBox("Inventariada", MsgBoxStyle.Information)

        Else
            Dim fulltext As String = File.ReadAllText("C:\PSICOPEDAGOGICO\Inventario_CPU.txt")
            Dim partes() As String = fulltext.Split(Environment.NewLine)
            Dim ultimalinea As String = partes(partes.Length - 1)
            mensaje = MsgBox("El Ultimo Inventario de esta maquina fue el " & ultimalinea & " ¿ Estas Seguro Inventariar Nuevamente ?", MsgBoxStyle.YesNo, "Inventario CPU")
            If mensaje = vbYes Then
                'Index.BackgroundImage = Nothing
                Using file As New IO.StreamWriter("C:\PSICOPEDAGOGICO\FechaInventario_CPU.txt")
                    file.Flush()
                End Using
                Dim ruta As String = "C:\PSICOPEDAGOGICO\FechaInventario_CPU.txt"
                Dim escritor As StreamWriter
                escritor = File.AppendText(ruta)
                escritor.Write(DateTime.Now.ToString)
                escritor.Flush()
                escritor.Close()
                Datos_Metodos.Nuevo_Inventario(Label_Serie.Text, Label_Nombre.Text, Label_Tarjeta_Madre.Text, RichTextBox_DiscosDuros.Text, Label_Ram.Text, Label_Procesador.Text,
                                           Label_SO.Text, Label_IPLocal.Text, Label_IPPublica.Text, DateTime.Now.ToShortDateString, Bienvenida.lbl_plantel_usuario.Text, Bienvenida.lbl_nombre_usuario.Text)
                MsgBox("Inventariada Nuevamente", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class