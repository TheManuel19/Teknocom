Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Public Class ListBD
    Dim conexion As New Conexion

    Public Sub funcionMessageError(ByRef variable As String)
        Dim mensaje As String
        mensaje = New String(Chr(0), 349)
        fError(variable, mensaje, 350)
        MessageBox.Show(mensaje)
    End Sub
    Private Sub DGVEmpresas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEmpresas.CellClick
        formularioInicio = New Inicio
        Dim partesdelaruta() As String
        Dim i As Integer
        Dim linea As String = Nothing
        Dim nombre As String

        With DGVEmpresas
            For i = DGVEmpresas.CurrentRow.Index To DGVEmpresas.Rows.Count - 1
                If i = DGVEmpresas.CurrentRow.Index Then
                    linea = .Rows(i).Cells(0).Value
                    partesdelaruta = Split(linea, "\")
                    nombre = partesdelaruta(3)
                    base = nombre
                End If
            Next
        End With
        Me.Hide()
        FormatosDeInfo.Show()
    End Sub

    Private Sub BTNConectarDB_Click(sender As Object, e As EventArgs) Handles BTNConectarDB.Click
        instancia = TBInstancia.Text
        idUser = TBIdUser.Text
        password = TBPassword.Text
        conexion.AbrirConexion()
        Dim query As String = "SELECT CRUTADATOS FROM Empresas"
        Dim dt As New DataSet
        conexion.consultas(query, dt)
        DGVEmpresas.DataSource = dt.Tables(0)
    End Sub

    Private Sub ListBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Directory.SetCurrentDirectory("C:\Program Files (x86)\Compac\COMERCIAL\")
        fSetNombrePAQ("CONTPAQ I Comercial")

        fAbreEmpresa("C:\Compac\Empresas\adEmpresa_prueba")
    End Sub
End Class
