Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop

Public Class FormatosDeInfo
    Dim conexion As New Conexion
    Dim metodos As New Metodos
    Public Sub funcionMessageError(ByRef variable As String)
        Dim mensaje As String
        mensaje = New String(Chr(0), 349)
        fError(variable, mensaje, 350)
        MessageBox.Show(mensaje)
    End Sub
    Private Sub CBTextoPlano_CheckedChanged(sender As Object, e As EventArgs) Handles CBTextoPlano.CheckedChanged
        If CBTextoPlano.Checked = True Then
            If OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rutaArchivo = OFDArchivosDeDatos.FileName

                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                palabraEnArreglo = Split(fileReader, TBSimbolo.Text)
                For index = 0 To palabraEnArreglo.Length - 1
                    MsgBox(palabraEnArreglo(index))
                Next


            ElseIf OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                MessageBox.Show("Error")
            End If
        End If
    End Sub


    Private Sub CBExcel_CheckedChanged(sender As Object, e As EventArgs) Handles CBExcel.CheckedChanged
        If CBExcel.Checked = True Then
            If OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                rutaArchivo = OFDArchivosDeDatos.FileName
                metodos.RecorrerExcel()

            ElseIf OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                MessageBox.Show("Error")
            End If
        End If
    End Sub

    Private Sub CBXml_CheckedChanged(sender As Object, e As EventArgs) Handles CBXml.CheckedChanged
        'If CBXml.Checked = True Then
        '    If OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        rutaArchivo = OFDArchivosDeDatos.FileName

        '        MsgBox(rutaArchivo)

        '    ElseIf OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
        '        MessageBox.Show("Error")
        '    End If
        'End If
    End Sub

    Private Sub CBBd_CheckedChanged(sender As Object, e As EventArgs) Handles CBBd.CheckedChanged
        'Aqui pido loa info para conectarme a bd
    End Sub

    Private Sub CBManual_CheckedChanged(sender As Object, e As EventArgs) Handles CBManual.CheckedChanged
        'Aqui conecto con la vista del formulario "Form"
        If CBManual.Checked = True Then
            Me.Hide()
            Inicio.Show()
        End If
    End Sub

    Private Sub FormatosDeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.AbrirConexion()
    End Sub
End Class