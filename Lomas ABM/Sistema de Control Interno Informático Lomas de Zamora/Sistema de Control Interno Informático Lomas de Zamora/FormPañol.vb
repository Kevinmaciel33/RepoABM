Public Class FormPañol
    Private Sub FormPañol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ParqueBaronDBDataSet.inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.ParqueBaronDBDataSet.inventario)
        TxtSearch.Clear()

        ComboBox1.Items.Add("Barrido")
        ComboBox1.Items.Add("Basura")
        ComboBox1.Items.Add("Ramas")
        ComboBox1.Items.Add("Troncos")
        ComboBox1.Items.Add("Hidrica")
        ComboBox1.Items.Add("Zanjeo")
        ComboBox1.Items.Add("Luminaria")
        ComboBox1.Items.Add("Despeje luminico")
        ComboBox1.Items.Add("Animales muertos")
        ComboBox1.SelectedIndex = 0

        ComboSearch.Items.Add("Tipo")
        ComboSearch.Items.Add("Nombre")
        ComboSearch.Items.Add("Descripcion")
        ComboSearch.Items.Add("Localizacion")
        ComboSearch.Items.Add("Cantidad")
        ComboSearch.Items.Add("Serial")
        ComboSearch.SelectedIndex = 0

    End Sub

#Region "BOTONES"

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Button1.Enabled = False
        BtnBorrar.Enabled = False
        Try
            Me.InventarioBindingSource.Filter = Nothing
            Me.InventarioTableAdapter.Fill(Me.ParqueBaronDBDataSet.inventario)
            Me.TextBox1.Focus()

            If Me.BtnNuevo.Text = "Nuevo" Then
                Me.InventarioBindingSource.AddNew()
                Me.BtnNuevo.Text = "Cancelar"
            Else
                Me.InventarioBindingSource.EndEdit()
                Me.BtnNuevo.Text = "Nuevo"
                Button1.Enabled = True
                BtnBorrar.Enabled = True
                Me.InventarioTableAdapter.Fill(Me.ParqueBaronDBDataSet.inventario)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("No se pudo conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim result As New DialogResult
            result = MessageBox.Show("¿Desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Me.Validate()
                Me.InventarioBindingSource.EndEdit()
                Me.InventarioTableAdapter.Update(Me.ParqueBaronDBDataSet.inventario)
                MessageBox.Show("Los cambios han sido exitosos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refresh data
                Me.InventarioTableAdapter.Fill(Me.ParqueBaronDBDataSet.inventario)
                Me.BtnNuevo.Text = "Nuevo"
            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos, reintente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Button1.Enabled = True
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If Me.BtnNuevo.Text = "Cancelar" Then
            Exit Sub
        End If

        If Not DataGridView1.Rows.Count = 0 Then
            Try
                Dim result As DialogResult
                result = MessageBox.Show("¿Seguro quiere borrar esto?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Me.InventarioBindingSource.RemoveCurrent()
                    Me.InventarioBindingSource.EndEdit()
                    Me.InventarioTableAdapter.Update(Me.ParqueBaronDBDataSet.inventario)

                End If


            Catch ex As Exception
                MessageBox.Show("No se pudo conectar con la base de datos, reintente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnLim_Click(sender As Object, e As EventArgs) Handles BtnLim.Click
        InventarioBindingSource.Filter = Nothing
    End Sub
#End Region

#Region "BUSCAR"
    Private Sub NotFound()

        Dim txtS As TextBox = TxtSearch
        With txtS
            .BackColor = Color.White
            .Select()
            .SelectAll()
        End With

        If DataGridView1.DataSource Is Nothing Then
            InventarioBindingSource.Filter = Nothing
            Exit Sub
        End If


        Dim dgv As DataGridView = DataGridView1
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tsearch As String
        On Error GoTo SearchErr

        If TxtSearch.Text = "" Then
            Call NotFound()
            Exit Sub

        Else

            Dim cantFind As String = TxtSearch.Text
            Tsearch = ComboSearch.Text

            ' InasistenciasBindingSource.Filter = "(Convert(Nombre, 'System.String') LIKE '" & TxtSearch.Text & "')" &
            '     "OR (Asignatura LIKE '" & TxtSearch.Text & "') 
            '     Or (Dia LIKE '" & TxtSearch.Text & "')" &
            '     "OR (año LIKE '" & TxtSearch.Text & "')"

            Select Case Tsearch
                Case "Tipo"
                    InventarioBindingSource.Filter = "(Convert(Tipo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Nombre"
                    InventarioBindingSource.Filter = "(Convert(Nombre, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Descripcion"
                    InventarioBindingSource.Filter = "(Convert(Descripcion, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Localizacion"
                    InventarioBindingSource.Filter = "(Convert(Localizacion, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Cantidad"
                    InventarioBindingSource.Filter = "(Convert(Cantidad, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "DNI"
                    InventarioBindingSource.Filter = "(Convert(Serial, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Todo"
                    InventarioBindingSource.Filter = "(Convert(Tipo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Nombre LIKE '" & TxtSearch.Text & "%" & "') Or (Descripcion LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Localizacion LIKE '" & TxtSearch.Text & "%" & "') Or (Cantidad LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Serial LIKE '" & TxtSearch.Text & "%" & "')"

            End Select


            If InventarioBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = InventarioBindingSource
                End With

            Else

                Me.NotFound()

                MsgBox("--> " & cantFind & vbNewLine &
                       "La busqueda no arrojó resultados.",
                       MsgBoxStyle.Information, "Advertencia")

                InventarioBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = InventarioBindingSource
                End With

            End If

        End If

ErrExit:
        Exit Sub
SearchErr:
        MsgBox("Error en la busqueda" & Err.Number & vbNewLine &
               "Verifique su conexión con la base de datos o intente más tarde" & Err.Description, MsgBoxStyle.Critical,
               "Error al buscar")
        Resume ErrExit
    End Sub
#End Region
End Class