Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now, "HH:mm:ss")
    End Sub
End Class