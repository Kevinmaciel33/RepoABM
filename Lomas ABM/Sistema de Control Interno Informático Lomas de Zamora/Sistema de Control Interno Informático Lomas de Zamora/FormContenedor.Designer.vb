<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContenedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContenedor))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.GroupBoxLogin = New System.Windows.Forms.GroupBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSaludo = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnAcercade = New System.Windows.Forms.Button()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.BtnObras = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnPañol = New System.Windows.Forms.Button()
        Me.BtnReclamos = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.ImgRestoreTitulo = New System.Windows.Forms.PictureBox()
        Me.ImgMinimizeTitulo = New System.Windows.Forms.PictureBox()
        Me.ImgMaximizeTitulo = New System.Windows.Forms.PictureBox()
        Me.ImgCloseTitulo = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        Me.GroupBoxLogin.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.ImgRestoreTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMinimizeTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMaximizeTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCloseTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelForm)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1280, 720)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.White
        Me.PanelForm.Controls.Add(Me.GroupBoxLogin)
        Me.PanelForm.Controls.Add(Me.LabelSaludo)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(200, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1080, 680)
        Me.PanelForm.TabIndex = 2
        '
        'GroupBoxLogin
        '
        Me.GroupBoxLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLogin.Controls.Add(Me.BtnLogin)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxPass)
        Me.GroupBoxLogin.Controls.Add(Me.Label2)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxUser)
        Me.GroupBoxLogin.Controls.Add(Me.Label1)
        Me.GroupBoxLogin.Location = New System.Drawing.Point(162, 164)
        Me.GroupBoxLogin.Name = "GroupBoxLogin"
        Me.GroupBoxLogin.Size = New System.Drawing.Size(762, 504)
        Me.GroupBoxLogin.TabIndex = 1
        Me.GroupBoxLogin.TabStop = False
        Me.GroupBoxLogin.Text = "Ingresar"
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.Location = New System.Drawing.Point(155, 296)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLogin.Size = New System.Drawing.Size(458, 70)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "INGRESAR"
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPass.Location = New System.Drawing.Point(308, 220)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPass.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxPass.TabIndex = 3
        Me.TextBoxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUser.Location = New System.Drawing.Point(308, 145)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'LabelSaludo
        '
        Me.LabelSaludo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LabelSaludo.AutoSize = True
        Me.LabelSaludo.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaludo.Location = New System.Drawing.Point(156, 10)
        Me.LabelSaludo.Name = "LabelSaludo"
        Me.LabelSaludo.Size = New System.Drawing.Size(768, 108)
        Me.LabelSaludo.TabIndex = 0
        Me.LabelSaludo.Text = "Bienvenido al sistema de control interno informático " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de la Municipalidad de Lom" &
    "as De Zamora." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para continuar ingrese sus credenciales."
        Me.LabelSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnAcercade)
        Me.PanelMenu.Controls.Add(Me.BtnAyuda)
        Me.PanelMenu.Controls.Add(Me.BtnObras)
        Me.PanelMenu.Controls.Add(Me.BtnEmpleados)
        Me.PanelMenu.Controls.Add(Me.BtnPañol)
        Me.PanelMenu.Controls.Add(Me.BtnReclamos)
        Me.PanelMenu.Controls.Add(Me.BtnInicio)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 680)
        Me.PanelMenu.TabIndex = 1
        '
        'BtnAcercade
        '
        Me.BtnAcercade.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAcercade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAcercade.FlatAppearance.BorderSize = 0
        Me.BtnAcercade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnAcercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnAcercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcercade.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcercade.ForeColor = System.Drawing.Color.White
        Me.BtnAcercade.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.love
        Me.BtnAcercade.Location = New System.Drawing.Point(0, 610)
        Me.BtnAcercade.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAcercade.Name = "BtnAcercade"
        Me.BtnAcercade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAcercade.Size = New System.Drawing.Size(200, 70)
        Me.BtnAcercade.TabIndex = 6
        Me.BtnAcercade.Text = "Acerca de..."
        Me.BtnAcercade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAcercade.UseVisualStyleBackColor = True
        '
        'BtnAyuda
        '
        Me.BtnAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAyuda.FlatAppearance.BorderSize = 0
        Me.BtnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAyuda.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAyuda.ForeColor = System.Drawing.Color.White
        Me.BtnAyuda.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.info
        Me.BtnAyuda.Location = New System.Drawing.Point(0, 530)
        Me.BtnAyuda.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAyuda.Size = New System.Drawing.Size(200, 70)
        Me.BtnAyuda.TabIndex = 5
        Me.BtnAyuda.Text = "Ayuda        "
        Me.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnAyuda.UseVisualStyleBackColor = True
        '
        'BtnObras
        '
        Me.BtnObras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnObras.FlatAppearance.BorderSize = 0
        Me.BtnObras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnObras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnObras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnObras.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnObras.ForeColor = System.Drawing.Color.White
        Me.BtnObras.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.bulldozer
        Me.BtnObras.Location = New System.Drawing.Point(0, 314)
        Me.BtnObras.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnObras.Name = "BtnObras"
        Me.BtnObras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnObras.Size = New System.Drawing.Size(200, 70)
        Me.BtnObras.TabIndex = 4
        Me.BtnObras.Text = "Obras         "
        Me.BtnObras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnObras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnObras.UseVisualStyleBackColor = True
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.ForeColor = System.Drawing.Color.White
        Me.BtnEmpleados.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.remito
        Me.BtnEmpleados.Location = New System.Drawing.Point(0, 234)
        Me.BtnEmpleados.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEmpleados.Size = New System.Drawing.Size(200, 70)
        Me.BtnEmpleados.TabIndex = 3
        Me.BtnEmpleados.Text = "Remito       "
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'BtnPañol
        '
        Me.BtnPañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPañol.FlatAppearance.BorderSize = 0
        Me.BtnPañol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnPañol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnPañol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPañol.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPañol.ForeColor = System.Drawing.Color.White
        Me.BtnPañol.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.storage
        Me.BtnPañol.Location = New System.Drawing.Point(0, 154)
        Me.BtnPañol.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnPañol.Name = "BtnPañol"
        Me.BtnPañol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPañol.Size = New System.Drawing.Size(200, 70)
        Me.BtnPañol.TabIndex = 2
        Me.BtnPañol.Text = "Inventario  "
        Me.BtnPañol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPañol.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPañol.UseVisualStyleBackColor = True
        '
        'BtnReclamos
        '
        Me.BtnReclamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnReclamos.FlatAppearance.BorderSize = 0
        Me.BtnReclamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnReclamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReclamos.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReclamos.ForeColor = System.Drawing.Color.White
        Me.BtnReclamos.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.claim
        Me.BtnReclamos.Location = New System.Drawing.Point(0, 76)
        Me.BtnReclamos.Name = "BtnReclamos"
        Me.BtnReclamos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnReclamos.Size = New System.Drawing.Size(200, 70)
        Me.BtnReclamos.TabIndex = 1
        Me.BtnReclamos.Text = "Reclamos   "
        Me.BtnReclamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnReclamos.UseVisualStyleBackColor = True
        '
        'BtnInicio
        '
        Me.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.ForeColor = System.Drawing.Color.White
        Me.BtnInicio.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.usability
        Me.BtnInicio.Location = New System.Drawing.Point(0, 0)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnInicio.Size = New System.Drawing.Size(200, 70)
        Me.BtnInicio.TabIndex = 0
        Me.BtnInicio.Text = "Inicio          "
        Me.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.LabelTitulo)
        Me.PanelBarraTitulo.Controls.Add(Me.ImgRestoreTitulo)
        Me.PanelBarraTitulo.Controls.Add(Me.ImgMinimizeTitulo)
        Me.PanelBarraTitulo.Controls.Add(Me.ImgMaximizeTitulo)
        Me.PanelBarraTitulo.Controls.Add(Me.ImgCloseTitulo)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1280, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'LabelTitulo
        '
        Me.LabelTitulo.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.White
        Me.LabelTitulo.Location = New System.Drawing.Point(5, 5)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(712, 30)
        Me.LabelTitulo.TabIndex = 4
        Me.LabelTitulo.Text = "Sistema de Control Interno Informático - Lomas De Zamora"
        '
        'ImgRestoreTitulo
        '
        Me.ImgRestoreTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgRestoreTitulo.Image = CType(resources.GetObject("ImgRestoreTitulo.Image"), System.Drawing.Image)
        Me.ImgRestoreTitulo.Location = New System.Drawing.Point(1230, 12)
        Me.ImgRestoreTitulo.Name = "ImgRestoreTitulo"
        Me.ImgRestoreTitulo.Size = New System.Drawing.Size(16, 16)
        Me.ImgRestoreTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImgRestoreTitulo.TabIndex = 3
        Me.ImgRestoreTitulo.TabStop = False
        Me.ImgRestoreTitulo.Visible = False
        '
        'ImgMinimizeTitulo
        '
        Me.ImgMinimizeTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgMinimizeTitulo.Image = CType(resources.GetObject("ImgMinimizeTitulo.Image"), System.Drawing.Image)
        Me.ImgMinimizeTitulo.Location = New System.Drawing.Point(1208, 12)
        Me.ImgMinimizeTitulo.Name = "ImgMinimizeTitulo"
        Me.ImgMinimizeTitulo.Size = New System.Drawing.Size(16, 16)
        Me.ImgMinimizeTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImgMinimizeTitulo.TabIndex = 2
        Me.ImgMinimizeTitulo.TabStop = False
        '
        'ImgMaximizeTitulo
        '
        Me.ImgMaximizeTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgMaximizeTitulo.Image = CType(resources.GetObject("ImgMaximizeTitulo.Image"), System.Drawing.Image)
        Me.ImgMaximizeTitulo.Location = New System.Drawing.Point(1230, 12)
        Me.ImgMaximizeTitulo.Name = "ImgMaximizeTitulo"
        Me.ImgMaximizeTitulo.Size = New System.Drawing.Size(16, 16)
        Me.ImgMaximizeTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImgMaximizeTitulo.TabIndex = 1
        Me.ImgMaximizeTitulo.TabStop = False
        '
        'ImgCloseTitulo
        '
        Me.ImgCloseTitulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgCloseTitulo.Image = Global.Sistema_de_Control_Interno_Informático_Lomas_de_Zamora.My.Resources.Resources.Close
        Me.ImgCloseTitulo.Location = New System.Drawing.Point(1252, 12)
        Me.ImgCloseTitulo.Name = "ImgCloseTitulo"
        Me.ImgCloseTitulo.Size = New System.Drawing.Size(16, 16)
        Me.ImgCloseTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImgCloseTitulo.TabIndex = 0
        Me.ImgCloseTitulo.TabStop = False
        '
        'FormContenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 720)
        Me.Name = "FormContenedor"
        Me.Text = "Sistema de Control Interno - LDZ"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.GroupBoxLogin.ResumeLayout(False)
        Me.GroupBoxLogin.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.ImgRestoreTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMinimizeTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMaximizeTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCloseTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ImgCloseTitulo As PictureBox
    Friend WithEvents BtnInicio As Button
    Friend WithEvents BtnReclamos As Button
    Friend WithEvents BtnPañol As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnObras As Button
    Friend WithEvents BtnAcercade As Button
    Friend WithEvents BtnAyuda As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents ImgRestoreTitulo As PictureBox
    Friend WithEvents ImgMinimizeTitulo As PictureBox
    Friend WithEvents ImgMaximizeTitulo As PictureBox
    Friend WithEvents LabelSaludo As Label
    Friend WithEvents GroupBoxLogin As GroupBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents Label2 As Label
End Class
