Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop

Public Class FormatosDeInfo
    Dim conexion As New Conexion
    Dim rutaArchivo As String
    Dim palabraEnArreglo() As String

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
    Private Sub RecorrerExcel()
        Dim arreglo() As String
        Dim vString1 As String = ""
        Dim CONTENIDO As String = "-"
        Dim Fila As Long = 2
        Dim idDocumento As Integer = 0
        Dim idMovimiento As Integer = 0

        'Variables para dar de alta documento, personas y productos
        'datos para dar de alta un cliente
        Dim claveMonedaCliente As String = Nothing
        Dim idMonedaCliente As Integer = Nothing
        Dim codigoDelCliente As String = Nothing
        Dim nombreRazonSocialCliente As String = Nothing
        Dim denomComercialCliente As String = Nothing
        Dim rfcCliente As String = Nothing
        Dim claveUsoCDFI As String = Nothing

        'datos para dar de alta el domicilio del cliente
        Dim calleCliente As String = Nothing
        Dim numExteriorCliente As Integer = Nothing
        Dim coloniaCliente As String = Nothing
        Dim codigoPostalCliente As Integer = Nothing
        Dim municipioCliente As String = Nothing
        Dim estadoCliente As String = Nothing
        Dim paisCliente As String = Nothing

        'datos para dar de alta producto
        Dim claveDeProducto As String = Nothing
        Dim nombreProductoOServicio As String = Nothing

        'datos para dar de alta una unidad
        Dim claveDeLaUnidad As String = Nothing
        Dim nombreDeLaUnida As String = Nothing

        'datos para dar de alta un documento
        Dim claveDeTipoDeComprobandeDocumento As String = Nothing
        Dim LugarDeExpedicionDocumento As Integer = Nothing
        Dim ClaveRegimenFiscalDocumento As Integer = Nothing
        Dim ClaveFormaDePagoDocumento As Integer = Nothing
        Dim ClaveMetodoDePagoDocumento As String = Nothing


        Try
            Dim oExcel As Object
            Dim oLibro As Object
            Dim oHoja As Object
            Dim oRango As Object

            oExcel = CreateObject("Excel.Application")
            '   oLibro = oExcel.Workbooks.Add
            oLibro = oExcel.Workbooks.Open("C:\Users\Grupo TeknoSoft\Downloads\Layout Sumiya Facturas Agua (29).xlsx")
            'oHoja = oLibro.ActiveSheet ' ABRE LA HOJA PRIMERA
            oHoja = oLibro.Sheets("Plantilla")

            While CONTENIDO <> ""
                vString1 = vString1 & oHoja.Cells(Fila, 1).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 2).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 3).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 4).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 5).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 6).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 7).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 8).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 9).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 10).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 11).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 12).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 13).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 14).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 15).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 16).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 17).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 18).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 19).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 20).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 21).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 22).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 23).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 24).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 25).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 26).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 27).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 28).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 29).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 30).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 31).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 32).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 33).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 34).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 35).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 36).value
                vString1 = vString1 & "|"
                vString1 = vString1 & oHoja.Cells(Fila, 37).value
                vString1 = vString1 & "|"
                arreglo = Split(vString1, "|")

                'insertar clientes
                fInsertaCteProv()
                claveMonedaCliente = arreglo(10)
                Dim query As String = "SELECT CIDMONEDA FROM admMonedas WHERE CCLAVESAT ='" & claveMonedaCliente & "'"
                Dim dt As New DataSet
                conexion.consultas(query, dt)
                idMonedaCliente = dt.Tables(0).Rows(0)(0).ToString
                fSetDatoCteProv("CIDMONEDA", idMonedaCliente)
                codigoDelCliente = arreglo(12)
                fSetDatoCteProv("CCODIGOCLIENTE", codigoDelCliente)
                nombreRazonSocialCliente = arreglo(13)
                fSetDatoCteProv("CRAZONSOCIAL", nombreRazonSocialCliente)
                denomComercialCliente = arreglo(14)
                fSetDatoCteProv("CDENCOMERCIAL", denomComercialCliente)
                rfcCliente = arreglo(15)
                fSetDatoCteProv("CRFC", rfcCliente)
                claveUsoCDFI = arreglo(16)
                fSetDatoCteProv("CUSOCFDI", claveUsoCDFI)
                Dim q = DateAndTime.Now()
                fSetDatoCteProv("CFECHAALTA", q.ToString("MM/dd/yyyy"))
                fSetDatoCteProv("CESTATUS", 1) ' Estatus se marca en uno porque es 1 de activo
                fSetDatoCteProv("CTIPOCLIENTE", 1) ' Tipo de cliente o proveedor 1 = Cliente 2 = Cliente/Proveedor 3 = Proveedor
                fSetDatoCteProv("CLISTAPRECIOCLIENTE", 1)
                fSetDatoCteProv("CBANVENTACREDITO", 1)
                fGuardaCteProv()
                query = ""
                dt.Clear()

                'insertar domicilio del cliente
                Dim idclienteparaEnlazarConDomicilio As String = Nothing
                query = "SELECT CIDCLIENTEPROVEEDOR FROM admClientes WHERE CCODIGOCLIENTE ='" & codigoDelCliente & "'"
                conexion.consultas(query, dt)
                idclienteparaEnlazarConDomicilio = dt.Tables(0).Rows(0)(0).ToString
                fInsertaDireccion()
                fSetDatoDireccion("CIDCATALOGO", idclienteparaEnlazarConDomicilio)
                fSetDatoDireccion("CTIPOCATALOGO", 1) ' Define el tipo del catalogo asociado 1 = Clientes 2 = Proveedores 3 = Documentos 4 = Empresas
                calleCliente = arreglo(18)
                fSetDatoDireccion("CNOMBRECALLE", calleCliente)
                numExteriorCliente = arreglo(19)
                fSetDatoDireccion("CNUMEROEXTERIOR", numExteriorCliente)
                coloniaCliente = arreglo(20)
                fSetDatoDireccion("CCOLONIA", coloniaCliente)
                codigoPostalCliente = arreglo(21)
                fSetDatoDireccion("CCODIGOPOSTAL", codigoPostalCliente)
                municipioCliente = arreglo(22)
                fSetDatoDireccion("CMUNICIPIO", municipioCliente)
                estadoCliente = arreglo(23)
                fSetDatoDireccion("CESTADO", estadoCliente)
                paisCliente = arreglo(24)
                fSetDatoDireccion("CPAIS", paisCliente)
                Dim r = DateAndTime.Now()
                fSetDatoDireccion("CTIMESTAMP", r.ToString("MM/dd/yyyy"))
                fGuardaDireccion()
                query = ""
                dt.Clear()

                Dim z As Integer = Nothing
                'Aqui doy de alta una unidad de medida
                fInsertaUnidad()
                claveDeLaUnidad = arreglo(27)
                fSetDatoUnidad("CCLAVEINT", claveDeLaUnidad)
                nombreDeLaUnida = arreglo(26)
                fSetDatoUnidad("CNOMBREUNIDAD", nombreDeLaUnida)
                fGuardaUnidad()

                query = ""
                dt.Clear()

                'Aqui doy de alta un producto
                Dim idDelaUnidadDeMedida As Integer = Nothing
                query = "SELECT CIDUNIDAD FROM admUnidadesMedidaPeso WHERE CCLAVEINT ='" & claveDeLaUnidad & "'"
                conexion.consultas(query, dt)
                idDelaUnidadDeMedida = dt.Tables(0).Rows(0)(0).ToString
                fInsertaProducto()
                claveDeProducto = arreglo(28)
                fSetDatoProducto("CCODIGOPRODUCTO", claveDeProducto)
                nombreProductoOServicio = arreglo(29)
                fSetDatoProducto("CNOMBREPRODUCTO", nombreProductoOServicio)
                fSetDatoProducto("CIDUNIDADBASE", idDelaUnidadDeMedida)
                fSetDatoProducto("CSTATUSPRODUCTO", 1)
                fSetDatoProducto("CTIPOPRODUCTO", 3) ' Tipo del Producto: 1 = Producto 2 = Paquete 3 = Servicio
                fGuardaProducto()
                query = ""
                dt.Clear()

                claveDeTipoDeComprobandeDocumento = arreglo(1)
                LugarDeExpedicionDocumento = arreglo(3)
                ClaveRegimenFiscalDocumento = arreglo(4)
                ClaveFormaDePagoDocumento = arreglo(6)
                ClaveMetodoDePagoDocumento = arreglo(8)
                Dim er As Integer
                Dim serie As String = "M"
                'Asiganacion de datos a variables para la creacion del documento
                '----------------------------------------------------------------------------------------------------------
                Dim documento As New tDocumento
                Dim concepto As String = "4"
                Dim folio As Integer = 0
                fSiguienteFolio(concepto, serie, folio)



                'Asigno bytes o inicializo los bytes que voy a inicializar
                '----------------------------------------------------------------------------------------------------------
                documento.aCodConcepto = New Byte(kLongCodigo - 1) {}
                documento.aCodigoCteProv = New Byte(kLongCodigo - 1) {}
                documento.aSerie = New Byte(kLongSeries - 1) {}
                documento.aMoneda = idMonedaCliente
                documento.aFolio = folio

                '----------------------------------------------------------------------------------------------------------
                Dim codificador As New UTF8Encoding()
                codificador.GetBytes(codigoDelCliente.Trim, 0, codigoDelCliente.Length, documento.aCodigoCteProv, 0)
                codificador.GetBytes(concepto.Trim, 0, concepto.Length, documento.aCodConcepto, 0)
                codificador.GetBytes(serie.Trim, 0, serie.Length, documento.aSerie, 0)
                er = fAltaDocumento(idDocumento, documento)
                funcionMessageError(er)

                ' Damos de alta el movimiento para el documento
                '----------------------------------------------------------------------------------------------------------
                Dim movimiento As New tMovimiento
                Dim precioUnitario As Double
                precioUnitario = arreglo(31)
                Dim unidades As Double
                unidades = arreglo(25)
                'claveDeTipoDeComprobandeDocumento = arreglo(1)
                'LugarDeExpedicionDocumento = arreglo(3)
                'ClaveRegimenFiscalDocumento = arreglo(4)
                'ClaveFormaDePagoDocumento = arreglo(6)
                'ClaveMetodoDePagoDocumento = arreglo(8)
                movimiento.aCodProdSer = New Byte(kLongCodigo - 1) {}
                movimiento.aPrecio = precioUnitario
                movimiento.aUnidades = unidades

                codificador.GetBytes(claveDeProducto.Trim, 0, claveDeProducto.Length, movimiento.aCodProdSer, 0)
                er = fAltaMovimiento(idDocumento, idMovimiento, movimiento)
                funcionMessageError(er)

                vString1 = Nothing
                arreglo = Nothing
                Fila = Fila + 1
                CONTENIDO = oHoja.Cells(Fila, 1).value
            End While

            oRango = Nothing
            oHoja = Nothing
            oLibro = Nothing
            oExcel.quit()
            oExcel = Nothing
        Catch ex As Exception
            MsgBox(ex.Message & "Buscar error")
        End Try
    End Sub

    Private Sub CBExcel_CheckedChanged(sender As Object, e As EventArgs) Handles CBExcel.CheckedChanged
        'Lee_Excel()
        RecorrerExcel()
        'If CBExcel.Checked = True Then
        '    If OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Dim nombre As OpenFileDialog



        '    ElseIf OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
        '        MessageBox.Show("Error")
        '    End If
        'End If
    End Sub

    Private Sub CBXml_CheckedChanged(sender As Object, e As EventArgs) Handles CBXml.CheckedChanged
        If CBXml.Checked = True Then
            If OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                '    MessageBox.Show("Funcion correcta")
                '    Label1.Text = OpenFileDialog1.FileName
                'rutaArchivo = OFDArchivosDeDatos.FileName

                '    Dim fileReader As String
                '    fileReader = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                '    MsgBox(fileReader)

            ElseIf OFDArchivosDeDatos.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
                MessageBox.Show("Error")
            End If
        End If
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