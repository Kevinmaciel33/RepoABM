Public Class FormReclamos

#Region "BOTONES"

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Button1.Enabled = False
        BtnBorrar.Enabled = False
        Try
            Me.ReclamosBindingSource.Filter = Nothing
            Me.ReclamosTableAdapter.Fill(Me.ParqueBaronDBDataSet.reclamos)
            Me.TextBox1.Focus()

            If Me.BtnNuevo.Text = "Nuevo" Then
                Me.ReclamosBindingSource.AddNew()
                Me.BtnNuevo.Text = "Cancelar"
            Else
                Me.ReclamosBindingSource.EndEdit()
                Me.BtnNuevo.Text = "Nuevo"
                Button1.Enabled = True
                BtnBorrar.Enabled = True
                Me.ReclamosTableAdapter.Fill(Me.ParqueBaronDBDataSet.reclamos)
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
                Me.ReclamosBindingSource.EndEdit()
                Me.ReclamosTableAdapter.Update(Me.ParqueBaronDBDataSet.reclamos)
                MessageBox.Show("Los cambios han sido exitosos", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Refresh data
                Me.ReclamosTableAdapter.Fill(Me.ParqueBaronDBDataSet.reclamos)
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
                    Me.ReclamosBindingSource.RemoveCurrent()
                    Me.ReclamosBindingSource.EndEdit()
                    Me.ReclamosTableAdapter.Update(Me.ParqueBaronDBDataSet.reclamos)

                End If


            Catch ex As Exception
                MessageBox.Show("No se pudo conectar con la base de datos, reintente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnLim_Click(sender As Object, e As EventArgs) Handles BtnLim.Click
        ReclamosBindingSource.Filter = Nothing
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
            ReclamosBindingSource.Filter = Nothing
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
                Case "Todo"
                    ReclamosBindingSource.Filter = "(Convert(NumReclamo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Número reclamo"
                    ReclamosBindingSource.Filter = "(Convert(NumReclamo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Tipo de reclamo"
                    ReclamosBindingSource.Filter = "(Convert(TipoReclamo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Apellido"
                    ReclamosBindingSource.Filter = "(Convert(Apellido, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Nombre"
                    ReclamosBindingSource.Filter = "(Convert(Nombre, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "DNI"
                    ReclamosBindingSource.Filter = "(Convert(DNI, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Dirección"
                    ReclamosBindingSource.Filter = "(Convert(Direccion, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Telefono"
                    ReclamosBindingSource.Filter = "(Convert(Telefono, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Fecha"
                    ReclamosBindingSource.Filter = "(Convert(Fecha, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Observaciones"
                    ReclamosBindingSource.Filter = "(Convert(Fecha, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')"
                Case "Todo"
                    ReclamosBindingSource.Filter = "(Convert(NumReclamo, 'System.String') LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (TipoReclamo LIKE '" & TxtSearch.Text & "%" & "') Or (Apellido LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Nombre LIKE '" & TxtSearch.Text & "%" & "') Or (DNI LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Direccion LIKE '" & TxtSearch.Text & "%" & "') Or (Telefono LIKE '" & TxtSearch.Text & "%" & "')" &
                 "OR (Fecha LIKE '" & TxtSearch.Text & "%" & "')"

            End Select


            If ReclamosBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = ReclamosBindingSource
                End With

            Else

                Me.NotFound()

                MsgBox("--> " & cantFind & vbNewLine &
                       "La busqueda no arrojó resultados.",
                       MsgBoxStyle.Information, "Advertencia")

                ReclamosBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = ReclamosBindingSource
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

    Private Sub FormReclamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ParqueBaronDBDataSet.reclamos' Puede moverla o quitarla según sea necesario.
        Me.ReclamosTableAdapter.Fill(Me.ParqueBaronDBDataSet.reclamos)

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

        ComboSearch.Items.Add("Número reclamo")
        ComboSearch.Items.Add("Tipo de reclamo")
        ComboSearch.Items.Add("Nombre")
        ComboSearch.Items.Add("Apellido")
        ComboSearch.Items.Add("DNI")
        ComboSearch.Items.Add("Dirección")
        ComboSearch.Items.Add("Fecha")
        ComboSearch.Items.Add("Observaciones")
        ComboSearch.SelectedIndex = 0

    End Sub

#Region "SOLO NUMEROS"
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
#End Region
End Class