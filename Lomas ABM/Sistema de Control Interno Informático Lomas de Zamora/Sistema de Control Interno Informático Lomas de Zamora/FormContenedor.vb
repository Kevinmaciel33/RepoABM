Imports System.Data.OleDb
Imports System.IO
Imports System.Runtime.InteropServices

Public Class FormContenedor

#Region "DECLARACIONES"

    Private Const rutalogs As String = "\\PC-SERVER\db\scilogs\AccesoLog_{0}.txt"
    Dim strFile As String = String.Format(rutalogs, DateTime.Today.ToString("dd-MMM-yyyy"))

    Dim username As String
    Dim password As String

#End Region

#Region "CARGA INICIAL"

    Private Sub FormContenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objConexion As OleDbConnection
        objConexion = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\PC-SERVER\db\ParqueBaronDB.mdb;Persist Security Info=True;Jet OLEDB:Database Password=parbadb5178")

        BtnInicio.Enabled = False
        BtnReclamos.Enabled = True
        BtnPañol.Enabled = False
        BtnEmpleados.Enabled = False
        BtnObras.Enabled = False
        BtnAyuda.Enabled = False
        BtnAcercade.Enabled = False

        If (Not System.IO.Directory.Exists("\\PC-SERVER\db\scilogs")) Then
            System.IO.Directory.CreateDirectory("\\PC-SERVER\db\scilogs")
        End If

        Try
            objConexion.Open()
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos, verifique si posee conexión a la red, si el problema persiste contacte al servicio técnico. Error: " & ex.Message, "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.ExitThread()
        End Try
        objConexion.Close()
        MessageBox.Show("Se ha conectado exitosamente a la base de datos", "Conexion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        username = TextBoxUser.Text
        password = TextBoxPass.Text

        '  If Me.UsuariosTableAdapter.ScalarQueryLogin(username, password) Then
        TextBoxUser.Clear()
        TextBoxPass.Clear()
        BtnInicio.Enabled = True
        BtnReclamos.Enabled = True
        BtnPañol.Enabled = True
        BtnEmpleados.Enabled = True
        BtnObras.Enabled = True
        BtnAyuda.Enabled = True
        BtnAcercade.Enabled = True

        AbrirFormEnPanel(Of FormInicio)()
        BtnInicio.BackColor = Color.FromArgb(200, 80, 115)

        If username = "empleado1" Then
            File.AppendAllText(strFile, String.Format(vbCrLf & vbCrLf & "☑☑☑ Acceso garantizado a Empleado1. | Fecha y hora: {0} ☑☑☑", Date.Now))
        ElseIf username = "empleado2" Then
            File.AppendAllText(strFile, String.Format(vbCrLf & vbCrLf & "☑☑☑ Acceso garantizado a Empleado2. | Fecha y hora: {0} ☑☑☑", Date.Now))
        End If

        '   Else
        File.AppendAllText(strFile, String.Format(vbCrLf & vbCrLf & "☒☒☒ Se ha introducido una contraseña incorrecta. Acceso NO garantizado. Fecha y hora: {0} ", Date.Now))
        File.AppendAllText(strFile, String.Format(vbCrLf & "Usuario :" & username & " | Contraseña: " & password & " ☒☒☒"))
        MessageBox.Show("Usuario y/o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '   End If
    End Sub

#End Region

#Region "FUNCIONALIDADES FORM"

#Region "TAMAÑO FORM"
    '----------------------------------------------------------------------------------------------------------------
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------------------------------------------------------------------------------------------------------

    '----------------------------------------------------------------------------------------------------------------
    'DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------------------------------------------------------------------------------------------------------
    'COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    '----------------------------------------------------------------------------------------------------------------
#End Region

#Region "GENERAR BARRA DE TITULO"
    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove, LabelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

#Region "CERRAR DE FORMA SEGURA / BOTONES DE CONTROl"

    Dim lx, ly As Integer
    Dim sh, sw As Integer

    Private Sub FormContenedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'CIERRO TODO DE FORMA SEGURA CON ALT+F4
        Dim dialog As DialogResult
        dialog = MessageBox.Show("¿Realmente desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If dialog = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            File.AppendAllText(strFile, String.Format(vbCrLf & "ⓍⓍⓍ El programa ha sido cerrado. | Fecha y hora: {0} ⓍⓍⓍ", Date.Now))
            Application.ExitThread()
        End If
    End Sub

    Private Sub ImgCloseTitulo_Click(sender As Object, e As EventArgs) Handles ImgCloseTitulo.Click
        If MessageBox.Show("¿Realmente desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            File.AppendAllText(strFile, String.Format(vbCrLf & "ⓍⓍⓍ El programa ha sido cerrado. | Fecha y hora: {0} ⓍⓍⓍ", Date.Now))
            Application.ExitThread()
        End If
    End Sub

    Private Sub ImgRestoreTitulo_Click(sender As Object, e As EventArgs) Handles ImgRestoreTitulo.Click
        ImgRestoreTitulo.Visible = False
        ImgMaximizeTitulo.Visible = True
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
    End Sub

    Private Sub ImgMaximizeTitulo_Click(sender As Object, e As EventArgs) Handles ImgMaximizeTitulo.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        ImgRestoreTitulo.Visible = True
        ImgMaximizeTitulo.Visible = False

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    Private Sub ImgMinimizeTitulo_Click(sender As Object, e As EventArgs) Handles ImgMinimizeTitulo.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#End Region

#Region "METODO PARA ABRIR DENTRO DEL PANEL"
    Private Sub AbrirFormEnPanel(Of Forms As {Form, New})()
        Dim formulario As Form
        formulario = PanelForm.Controls.OfType(Of Forms)().FirstOrDefault()

        If formulario Is Nothing Then
            formulario = New Forms()
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            PanelForm.Controls.Add(formulario)
            PanelForm.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        AbrirFormEnPanel(Of FormInicio)()
        BtnInicio.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnReclamos_Click(sender As Object, e As EventArgs) Handles BtnReclamos.Click
        AbrirFormEnPanel(Of FormReclamos)()
        BtnReclamos.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnPañol_Click(sender As Object, e As EventArgs) Handles BtnPañol.Click
        AbrirFormEnPanel(Of FormPañol)()
        BtnPañol.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        AbrirFormEnPanel(Of FormEmpleados)()
        BtnEmpleados.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnObras_Click(sender As Object, e As EventArgs) Handles BtnObras.Click
        AbrirFormEnPanel(Of FormObras)()
        BtnObras.BackColor = Color.FromArgb(200, 80, 115)
    End Sub

    Private Sub BtnAyuda_Click(sender As Object, e As EventArgs) Handles BtnAyuda.Click
        AbrirFormEnPanel(Of FormAyuda)()
        BtnAyuda.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnAcercade_Click(sender As Object, e As EventArgs) Handles BtnAcercade.Click
        AbrirFormEnPanel(Of FormAcercade)()
        BtnAcercade.BackColor = Color.FromArgb(200, 80, 115)
    End Sub
    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        AbrirFormEnPanel(Of FormReportesReclamos)()
        BtnAcercade.BackColor = Color.FromArgb(200, 80, 115)
    End Sub

#End Region
End Class

