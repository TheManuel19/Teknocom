Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient

Public Class Conexion
    Dim Conexion As New SqlConnection

    Public Function AbrirConexion() As Boolean
        Try
            Conexion = New SqlConnection("Server=" & instancia & ";database=" & base & ";User Id=" & idUser & ";Password=" & password)
            Conexion.Open()
            AbrirConexion = True
        Catch ex As Exception
            AbrirConexion = False
            MessageBox.Show("Error " & ex.ToString)
            ListBD.Show()
        End Try
        Return AbrirConexion
    End Function

    Public Function cerrarConexion() As Boolean
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
            cerrarConexion = True
        Catch ex As Exception
            cerrarConexion = False
        End Try
        Return cerrarConexion

    End Function


    Public Function consultas(ByVal query As String, ByRef DTtable As DataSet) As Boolean
        DTtable = New DataSet
        Dim cmd2 As New SqlDataAdapter(query, Conexion)
        Try
            cmd2.Fill(DTtable)
            consultas = True
        Catch ex As Exception
            consultas = False
            MessageBox.Show("Error " & ex.ToString)
        End Try
        Return consultas
    End Function

    Public Function crud(ByVal query As String, ByRef DTtable As DataSet) As Boolean
        DTtable = New DataSet
        Dim cmd2 As New SqlCommand(query, Conexion)
        Try
            cmd2.ExecuteNonQuery()
            crud = True
        Catch ex As Exception
            crud = False
            MessageBox.Show("Error " & ex.ToString)
        End Try
        Return crud
    End Function

End Class
