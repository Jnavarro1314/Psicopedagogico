<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.ToolStrip_Titulo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.lbl_nombre_usuario = New System.Windows.Forms.Label()
        Me.lbl_plantel_usuario = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lbl_cuenta = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LinkDescarga = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker_Cargar_Actualizador = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker_Inventariar = New System.ComponentModel.BackgroundWorker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStrip_Admin = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Control_Atencion = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Menu_capturar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_consultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_imprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_grupos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamizajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_sintesis = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_graficar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton_Control_Cred = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.CredencialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlataformaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LíneaDeRespuestasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton_Herramientas = New System.Windows.Forms.ToolStripButton()
        Me.link_registro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip_Titulo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_Admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip_Titulo
        '
        Me.ToolStrip_Titulo.AutoSize = False
        Me.ToolStrip_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ToolStrip_Titulo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Titulo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_Titulo.Name = "ToolStrip_Titulo"
        Me.ToolStrip_Titulo.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip_Titulo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip_Titulo.Size = New System.Drawing.Size(1450, 44)
        Me.ToolStrip_Titulo.TabIndex = 65
        Me.ToolStrip_Titulo.Text = "Titulo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(198, 41)
        Me.ToolStripLabel1.Text = "Bienvenido al Sistema"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(1272, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 19)
        Me.LinkLabel1.TabIndex = 71
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Salir"
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_puesto.Location = New System.Drawing.Point(1070, 81)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(70, 19)
        Me.lbl_puesto.TabIndex = 73
        Me.lbl_puesto.Text = "PLANTEL:"
        '
        'lbl_nombre_usuario
        '
        Me.lbl_nombre_usuario.AutoSize = True
        Me.lbl_nombre_usuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_usuario.Location = New System.Drawing.Point(1146, 62)
        Me.lbl_nombre_usuario.Name = "lbl_nombre_usuario"
        Me.lbl_nombre_usuario.Size = New System.Drawing.Size(17, 19)
        Me.lbl_nombre_usuario.TabIndex = 74
        Me.lbl_nombre_usuario.Text = "_"
        '
        'lbl_plantel_usuario
        '
        Me.lbl_plantel_usuario.AutoSize = True
        Me.lbl_plantel_usuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plantel_usuario.Location = New System.Drawing.Point(1146, 81)
        Me.lbl_plantel_usuario.Name = "lbl_plantel_usuario"
        Me.lbl_plantel_usuario.Size = New System.Drawing.Size(17, 19)
        Me.lbl_plantel_usuario.TabIndex = 75
        Me.lbl_plantel_usuario.Text = "_"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 667)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1450, 28)
        Me.ToolStrip1.TabIndex = 76
        Me.ToolStrip1.Text = "Titulo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(532, 25)
        Me.ToolStripLabel2.Text = "Departamento Psicopedagógico.         Sistema de captura de información          " &
    "   "
        '
        'lbl_cuenta
        '
        Me.lbl_cuenta.AutoSize = True
        Me.lbl_cuenta.BackColor = System.Drawing.Color.White
        Me.lbl_cuenta.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuenta.ForeColor = System.Drawing.Color.Black
        Me.lbl_cuenta.Location = New System.Drawing.Point(1240, 109)
        Me.lbl_cuenta.Name = "lbl_cuenta"
        Me.lbl_cuenta.Size = New System.Drawing.Size(17, 19)
        Me.lbl_cuenta.TabIndex = 79
        Me.lbl_cuenta.Text = "_"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.BackColor = System.Drawing.Color.Silver
        Me.lbl_version.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_version.ForeColor = System.Drawing.Color.White
        Me.lbl_version.Location = New System.Drawing.Point(1396, 669)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(38, 19)
        Me.lbl_version.TabIndex = 79
        Me.lbl_version.Text = "V2.4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 464)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(202, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_usuario.Location = New System.Drawing.Point(1031, 62)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(109, 19)
        Me.lbl_usuario.TabIndex = 72
        Me.lbl_usuario.Text = "         USUARIO:"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkDescarga
        '
        Me.LinkDescarga.AutoSize = True
        Me.LinkDescarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LinkDescarga.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LinkDescarga.LinkColor = System.Drawing.Color.White
        Me.LinkDescarga.Location = New System.Drawing.Point(1123, 9)
        Me.LinkDescarga.Name = "LinkDescarga"
        Me.LinkDescarga.Size = New System.Drawing.Size(128, 19)
        Me.LinkDescarga.TabIndex = 86
        Me.LinkDescarga.TabStop = True
        Me.LinkDescarga.Text = "Descargar Manual"
        '
        'BackgroundWorker_Cargar_Actualizador
        '
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1406, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 51)
        Me.Button1.TabIndex = 87
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSubir
        '
        Me.BtnSubir.Image = CType(resources.GetObject("BtnSubir.Image"), System.Drawing.Image)
        Me.BtnSubir.Location = New System.Drawing.Point(1406, 62)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(42, 38)
        Me.BtnSubir.TabIndex = 84
        Me.BtnSubir.UseVisualStyleBackColor = True
        Me.BtnSubir.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1450, 623)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker_Inventariar
        '
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1406, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 51)
        Me.Button2.TabIndex = 88
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStrip_Admin
        '
        Me.ToolStrip_Admin.AutoSize = False
        Me.ToolStrip_Admin.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStrip_Admin.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip_Admin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_Admin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip_Admin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.Control_Atencion, Me.ToolStripDropDownButton_Control_Cred, Me.ToolStripSeparator7, Me.ToolStripDropDownButton_Herramientas, Me.link_registro, Me.ToolStripButton2})
        Me.ToolStrip_Admin.Location = New System.Drawing.Point(0, 44)
        Me.ToolStrip_Admin.Name = "ToolStrip_Admin"
        Me.ToolStrip_Admin.Size = New System.Drawing.Size(990, 60)
        Me.ToolStrip_Admin.TabIndex = 403
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(0, 57)
        '
        'Control_Atencion
        '
        Me.Control_Atencion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_capturar, Me.Menu_consultar, Me.Menu_imprimir, Me.Menu_actualizar, Me.Menu_grupos, Me.TamizajeToolStripMenuItem, Me.Menu_sintesis, Me.Menu_graficar, Me.ToolStripMenuItem1})
        Me.Control_Atencion.Image = CType(resources.GetObject("Control_Atencion.Image"), System.Drawing.Image)
        Me.Control_Atencion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Control_Atencion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Control_Atencion.Name = "Control_Atencion"
        Me.Control_Atencion.Size = New System.Drawing.Size(177, 57)
        Me.Control_Atencion.Text = "Base de Datos Atencion"
        Me.Control_Atencion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Menu_capturar
        '
        Me.Menu_capturar.Image = CType(resources.GetObject("Menu_capturar.Image"), System.Drawing.Image)
        Me.Menu_capturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_capturar.Name = "Menu_capturar"
        Me.Menu_capturar.Size = New System.Drawing.Size(247, 38)
        Me.Menu_capturar.Text = "Capturar"
        '
        'Menu_consultar
        '
        Me.Menu_consultar.Image = CType(resources.GetObject("Menu_consultar.Image"), System.Drawing.Image)
        Me.Menu_consultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_consultar.Name = "Menu_consultar"
        Me.Menu_consultar.Size = New System.Drawing.Size(247, 38)
        Me.Menu_consultar.Text = "Consultar"
        '
        'Menu_imprimir
        '
        Me.Menu_imprimir.Image = CType(resources.GetObject("Menu_imprimir.Image"), System.Drawing.Image)
        Me.Menu_imprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_imprimir.Name = "Menu_imprimir"
        Me.Menu_imprimir.Size = New System.Drawing.Size(247, 38)
        Me.Menu_imprimir.Text = "Imprimir Formato"
        '
        'Menu_actualizar
        '
        Me.Menu_actualizar.Image = CType(resources.GetObject("Menu_actualizar.Image"), System.Drawing.Image)
        Me.Menu_actualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_actualizar.Name = "Menu_actualizar"
        Me.Menu_actualizar.Size = New System.Drawing.Size(247, 38)
        Me.Menu_actualizar.Text = "Actualizar"
        '
        'Menu_grupos
        '
        Me.Menu_grupos.Image = CType(resources.GetObject("Menu_grupos.Image"), System.Drawing.Image)
        Me.Menu_grupos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_grupos.Name = "Menu_grupos"
        Me.Menu_grupos.Size = New System.Drawing.Size(247, 38)
        Me.Menu_grupos.Text = "Atención a Grupos"
        '
        'TamizajeToolStripMenuItem
        '
        Me.TamizajeToolStripMenuItem.Image = CType(resources.GetObject("TamizajeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TamizajeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TamizajeToolStripMenuItem.Name = "TamizajeToolStripMenuItem"
        Me.TamizajeToolStripMenuItem.Size = New System.Drawing.Size(247, 38)
        Me.TamizajeToolStripMenuItem.Text = "Resultados de Tamizaje"
        '
        'Menu_sintesis
        '
        Me.Menu_sintesis.Image = CType(resources.GetObject("Menu_sintesis.Image"), System.Drawing.Image)
        Me.Menu_sintesis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_sintesis.Name = "Menu_sintesis"
        Me.Menu_sintesis.Size = New System.Drawing.Size(247, 38)
        Me.Menu_sintesis.Text = "Síntesis Semanal"
        '
        'Menu_graficar
        '
        Me.Menu_graficar.Image = CType(resources.GetObject("Menu_graficar.Image"), System.Drawing.Image)
        Me.Menu_graficar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Menu_graficar.Name = "Menu_graficar"
        Me.Menu_graficar.Size = New System.Drawing.Size(247, 38)
        Me.Menu_graficar.Text = "Graficar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(247, 38)
        Me.ToolStripMenuItem1.Text = "Registro de Asistencia"
        '
        'ToolStripDropDownButton_Control_Cred
        '
        Me.ToolStripDropDownButton_Control_Cred.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator12, Me.CredencialesToolStripMenuItem, Me.ToolStripSeparator14})
        Me.ToolStripDropDownButton_Control_Cred.Image = CType(resources.GetObject("ToolStripDropDownButton_Control_Cred.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton_Control_Cred.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton_Control_Cred.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton_Control_Cred.Name = "ToolStripDropDownButton_Control_Cred"
        Me.ToolStripDropDownButton_Control_Cred.Size = New System.Drawing.Size(158, 57)
        Me.ToolStripDropDownButton_Control_Cred.Text = "Cuestionarios Online"
        Me.ToolStripDropDownButton_Control_Cred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(379, 6)
        '
        'CredencialesToolStripMenuItem
        '
        Me.CredencialesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlataformaWebToolStripMenuItem, Me.LíneaDeRespuestasToolStripMenuItem, Me.ResultadosToolStripMenuItem})
        Me.CredencialesToolStripMenuItem.Image = CType(resources.GetObject("CredencialesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CredencialesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CredencialesToolStripMenuItem.Name = "CredencialesToolStripMenuItem"
        Me.CredencialesToolStripMenuItem.Size = New System.Drawing.Size(382, 38)
        Me.CredencialesToolStripMenuItem.Text = "DETECCIÓN DE NECESIDADES ACADÉMICAS "
        '
        'PlataformaWebToolStripMenuItem
        '
        Me.PlataformaWebToolStripMenuItem.Image = CType(resources.GetObject("PlataformaWebToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlataformaWebToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlataformaWebToolStripMenuItem.Name = "PlataformaWebToolStripMenuItem"
        Me.PlataformaWebToolStripMenuItem.Size = New System.Drawing.Size(295, 38)
        Me.PlataformaWebToolStripMenuItem.Text = "Plataforma Web"
        '
        'LíneaDeRespuestasToolStripMenuItem
        '
        Me.LíneaDeRespuestasToolStripMenuItem.Image = CType(resources.GetObject("LíneaDeRespuestasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LíneaDeRespuestasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LíneaDeRespuestasToolStripMenuItem.Name = "LíneaDeRespuestasToolStripMenuItem"
        Me.LíneaDeRespuestasToolStripMenuItem.Size = New System.Drawing.Size(295, 38)
        Me.LíneaDeRespuestasToolStripMenuItem.Text = "Línea de Respuestas"
        '
        'ResultadosToolStripMenuItem
        '
        Me.ResultadosToolStripMenuItem.Image = CType(resources.GetObject("ResultadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResultadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResultadosToolStripMenuItem.Name = "ResultadosToolStripMenuItem"
        Me.ResultadosToolStripMenuItem.Size = New System.Drawing.Size(295, 38)
        Me.ResultadosToolStripMenuItem.Text = "Resultados, Conteos y Gráficas"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(379, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 60)
        '
        'ToolStripDropDownButton_Herramientas
        '
        Me.ToolStripDropDownButton_Herramientas.AutoSize = False
        Me.ToolStripDropDownButton_Herramientas.Image = CType(resources.GetObject("ToolStripDropDownButton_Herramientas.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton_Herramientas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton_Herramientas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton_Herramientas.Name = "ToolStripDropDownButton_Herramientas"
        Me.ToolStripDropDownButton_Herramientas.Size = New System.Drawing.Size(125, 60)
        Me.ToolStripDropDownButton_Herramientas.Text = "Herramientas"
        Me.ToolStripDropDownButton_Herramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'link_registro
        '
        Me.link_registro.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_registro.Image = CType(resources.GetObject("link_registro.Image"), System.Drawing.Image)
        Me.link_registro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.link_registro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.link_registro.Name = "link_registro"
        Me.link_registro.Size = New System.Drawing.Size(70, 57)
        Me.link_registro.Text = "Usuarios"
        Me.link_registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(75, 57)
        Me.ToolStripButton2.Text = "AcercaDe"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1450, 695)
        Me.Controls.Add(Me.ToolStrip_Admin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkDescarga)
        Me.Controls.Add(Me.BtnSubir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.lbl_cuenta)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbl_plantel_usuario)
        Me.Controls.Add(Me.lbl_nombre_usuario)
        Me.Controls.Add(Me.lbl_puesto)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ToolStrip_Titulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.ToolStrip_Titulo.ResumeLayout(False)
        Me.ToolStrip_Titulo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_Admin.ResumeLayout(False)
        Me.ToolStrip_Admin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip_Titulo As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_plantel_usuario As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbl_cuenta As System.Windows.Forms.Label
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents BtnSubir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LinkDescarga As LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker_Cargar_Actualizador As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker_Inventariar As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip_Admin As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Control_Atencion As ToolStripDropDownButton
    Friend WithEvents Menu_capturar As ToolStripMenuItem
    Friend WithEvents Menu_consultar As ToolStripMenuItem
    Friend WithEvents Menu_imprimir As ToolStripMenuItem
    Friend WithEvents Menu_actualizar As ToolStripMenuItem
    Friend WithEvents Menu_grupos As ToolStripMenuItem
    Friend WithEvents TamizajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_sintesis As ToolStripMenuItem
    Friend WithEvents Menu_graficar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton_Control_Cred As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents CredencialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton_Herramientas As ToolStripButton
    Friend WithEvents link_registro As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents PlataformaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LíneaDeRespuestasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResultadosToolStripMenuItem As ToolStripMenuItem
End Class
