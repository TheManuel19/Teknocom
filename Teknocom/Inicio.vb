Public Class Inicio
    Dim conexion As New Conexion
    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        conexion.cerrarConexion()
        Me.Hide()
        ListBD.Show()


    End Sub

End Class