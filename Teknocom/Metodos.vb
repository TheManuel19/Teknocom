Imports System.IO
Imports System.Text
Public Class Metodos
    Dim conexion As New Conexion
    Public Sub funcionMessageError(ByRef variable As String)
        Dim mensaje As String
        mensaje = New String(Chr(0), 349)
        fError(variable, mensaje, 350)
        MessageBox.Show(mensaje)
    End Sub
    Public Sub RecorrerExcel()
        conexion.AbrirConexion()
        Dim vString1 As String = ""
        Dim CONTENIDO As String = "-"
        Dim Fila As Long = 2
        Dim idDocumento As Integer = 0
        Dim idMovimiento As Integer = 0
        Dim er As Integer

        Try
            Dim oExcel As Object
            Dim oLibro As Object
            Dim oHoja As Object
            Dim oRango As Object

            oExcel = CreateObject("Excel.Application")
            '   oLibro = oExcel.Workbooks.Add
            oLibro = oExcel.Workbooks.Open(rutaArchivo)
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

                MsgBox(idMonedaCliente & "idMonedaCliente")
                fSetDatoCteProv("CIDMONEDA", idMonedaCliente)

                codigoDelCliente = arreglo(12)
                MsgBox(codigoDelCliente & "codigoDelCliente")
                fSetDatoCteProv("CCODIGOCLIENTE", codigoDelCliente)

                nombreRazonSocialCliente = arreglo(13)
                MsgBox(nombreRazonSocialCliente & "nombreRazonSocialCliente")
                fSetDatoCteProv("CRAZONSOCIAL", nombreRazonSocialCliente)

                denomComercialCliente = arreglo(14)
                MsgBox(denomComercialCliente & "denomComercialCliente")
                fSetDatoCteProv("CDENCOMERCIAL", denomComercialCliente)

                rfcCliente = arreglo(15)
                MsgBox(rfcCliente & "rfcCliente")
                fSetDatoCteProv("CRFC", rfcCliente)

                claveUsoCDFI = arreglo(16)
                MsgBox(claveUsoCDFI & "claveUsoCDFI")
                fSetDatoCteProv("CUSOCFDI", claveUsoCDFI)

                ClaveRegimenFiscalDocumento = arreglo(4)
                MsgBox(ClaveRegimenFiscalDocumento & "ClaveRegimenFiscalDocumento")
                fSetDatoCteProv("CREGIMFISC", ClaveRegimenFiscalDocumento)

                'fSetDatoCteProv("[CMETODOPAG]",)
                Dim q = DateAndTime.Now()
                fSetDatoCteProv("CFECHAALTA", q.ToString("MM/dd/yyyy"))
                fSetDatoCteProv("CESTATUS", 1) ' Estatus se marca en uno porque es 1 de activo
                fSetDatoCteProv("CTIPOCLIENTE", 1) ' Tipo de cliente o proveedor 1 = Cliente 2 = Cliente/Proveedor 3 = Proveedor
                fSetDatoCteProv("CLISTAPRECIOCLIENTE", 1)
                fSetDatoCteProv("CBANVENTACREDITO", 1)
                er = fGuardaCteProv()
                funcionMessageError(er)
                query = ""
                dt.Clear()

                'insertar domicilio del cliente
                Dim idclienteparaEnlazarConDomicilio As String = Nothing
                query = "SELECT CIDCLIENTEPROVEEDOR FROM admClientes WHERE CCODIGOCLIENTE ='" & codigoDelCliente & "'"
                conexion.consultas(query, dt)
                idclienteparaEnlazarConDomicilio = dt.Tables(0).Rows(0)(0).ToString
                fInsertaDireccion()
                MsgBox(idclienteparaEnlazarConDomicilio & "idclienteparaEnlazarConDomicilio")
                fSetDatoDireccion("CIDCATALOGO", idclienteparaEnlazarConDomicilio)

                fSetDatoDireccion("CTIPOCATALOGO", 1) ' Define el tipo del catalogo asociado 1 = Clientes 2 = Proveedores 3 = Documentos 4 = Empresas

                calleCliente = arreglo(18)
                MsgBox(calleCliente & "calleCliente")
                fSetDatoDireccion("CNOMBRECALLE", calleCliente)

                numExteriorCliente = arreglo(19)
                MsgBox(numExteriorCliente & "numExteriorCliente")
                fSetDatoDireccion("CNUMEROEXTERIOR", numExteriorCliente)

                coloniaCliente = arreglo(20)
                MsgBox(coloniaCliente & "coloniaCliente")
                fSetDatoDireccion("CCOLONIA", coloniaCliente)

                codigoPostalCliente = arreglo(21)
                MsgBox(codigoPostalCliente & "codigoPostalCliente")
                fSetDatoDireccion("CCODIGOPOSTAL", codigoPostalCliente)

                municipioCliente = arreglo(22)
                MsgBox(municipioCliente & "municipioCliente")
                fSetDatoDireccion("CMUNICIPIO", municipioCliente)

                estadoCliente = arreglo(23)
                MsgBox(estadoCliente & "estadoCliente")
                fSetDatoDireccion("CESTADO", estadoCliente)

                paisCliente = arreglo(24)
                MsgBox(paisCliente & "paisCliente")
                fSetDatoDireccion("CPAIS", paisCliente)

                Dim r = DateAndTime.Now()
                fSetDatoDireccion("CTIMESTAMP", r.ToString("MM/dd/yyyy"))
                er = fGuardaDireccion()
                funcionMessageError(er)

                query = ""
                dt.Clear()

                'Aqui doy de alta una unidad de medida
                fInsertaUnidad()

                claveDeLaUnidad = arreglo(27)
                MsgBox(claveDeLaUnidad & "claveDeLaUnidad")
                fSetDatoUnidad("CCLAVEINT", claveDeLaUnidad)

                nombreDeLaUnida = arreglo(26)
                MsgBox(nombreDeLaUnida & "nombreDeLaUnida")
                fSetDatoUnidad("CNOMBREUNIDAD", nombreDeLaUnida)

                er = fGuardaUnidad()
                funcionMessageError(er)

                query = ""
                dt.Clear()

                'Aqui doy de alta un producto
                Dim idDelaUnidadDeMedida As Integer = Nothing
                Dim codigo As String = "15"
                query = "SELECT CIDUNIDAD FROM admUnidadesMedidaPeso WHERE CCLAVEINT ='" & claveDeLaUnidad & "'"
                conexion.consultas(query, dt)
                idDelaUnidadDeMedida = dt.Tables(0).Rows(0)(0).ToString
                fInsertaProducto()

                fSetDatoProducto("CCODIGOPRODUCTO", codigo)

                claveDeProducto = arreglo(28)
                MsgBox(claveDeProducto & "claveDeProducto")
                fSetDatoProducto("CCLAVESAT", claveDeProducto)

                nombreProductoOServicio = arreglo(29)
                MsgBox(nombreProductoOServicio & "nombreProductoOServicio")
                fSetDatoProducto("CNOMBREPRODUCTO", nombreProductoOServicio)

                MsgBox(idDelaUnidadDeMedida & "idDelaUnidadDeMedida")
                fSetDatoProducto("CIDUNIDADBASE", idDelaUnidadDeMedida)
                fSetDatoProducto("CSTATUSPRODUCTO", 1)
                fSetDatoProducto("CTIPOPRODUCTO", 3) ' Tipo del Producto: 1 = Producto 2 = Paquete 3 = Servicio
                er = fGuardaProducto()
                funcionMessageError(er)

                query = ""
                dt.Clear()

                'claveDeTipoDeComprobandeDocumento = arreglo(1)
                'LugarDeExpedicionDocumento = arreglo(3)
                'ClaveRegimenFiscalDocumento = arreglo(4)
                'ClaveFormaDePagoDocumento = arreglo(6)
                'ClaveMetodoDePagoDocumento = arreglo(8)


                'Asiganacion de datos a variables para la creacion del documento
                '----------------------------------------------------------------------------------------------------------
                Dim documento As New tDocumento
                Dim serie As String = "37"
                Dim concepto As String = "4"
                Dim folio As Integer = 0
                fSiguienteFolio(concepto, serie, folio)

                'Asigno bytes o inicializo los bytes que voy a inicializar
                '----------------------------------------------------------------------------------------------------------
                documento.aCodConcepto = New Byte(kLongCodigo - 1) {}
                documento.aCodigoCteProv = New Byte(kLongCodigo - 1) {}
                documento.aSerie = New Byte(kLongCodigo - 1) {}
                documento.aMoneda = idMonedaCliente
                documento.aFolio = folio

                '----------------------------------------------------------------------------------------------------------
                Dim codificador As New UTF8Encoding()
                codificador.GetBytes(codigoDelCliente, 0, codigoDelCliente.Length, documento.aCodigoCteProv, 0)
                codificador.GetBytes(concepto, 0, concepto.Length, documento.aCodConcepto, 0)
                codificador.GetBytes(serie, 0, serie.Length, documento.aSerie, 0)
                er = fAltaDocumento(idDocumento, documento)
                funcionMessageError(er)
                MsgBox(idDocumento)
                ' Damos de alta el movimiento para el documento
                '----------------------------------------------------------------------------------------------------------
                Dim movimiento As New tMovimiento
                Dim precioUnitario As Double
                precioUnitario = arreglo(31)
                Dim codigoAlmacen As String = "1"
                Dim unidades As Double
                unidades = arreglo(25)

                'claveDeTipoDeComprobandeDocumento = arreglo(1)
                'LugarDeExpedicionDocumento = arreglo(3)
                'ClaveFormaDePagoDocumento = arreglo(6) va en el documento
                'ClaveMetodoDePagoDocumento = arreglo(8)
                movimiento.aCodProdSer = New Byte(kLongCodigo - 1) {}
                movimiento.aPrecio = precioUnitario
                movimiento.aUnidades = unidades
                movimiento.aCodAlmacen = New Byte(kLongCodigo - 1) {}

                MsgBox(codigo)
                codificador.GetBytes(codigo, 0, codigo.Length, movimiento.aCodProdSer, 0)
                codificador.GetBytes(codigoAlmacen.Trim, 0, codigoAlmacen.Length, movimiento.aCodAlmacen, 0)
                er = fAltaMovimiento(idDocumento, idMovimiento, movimiento)
                funcionMessageError(er)

                'Dim llave As New tLlaveDocto
                'llave.aCodConcepto = New Byte(kLongCodigo - 1) {}
                'llave.aSerie = New Byte(kLongSeries - 1) {}
                'llave.aFolio = folio

                'codificador.GetBytes(concepto.Trim, 0, concepto.Length, llave.aCodConcepto, 0)
                'codificador.GetBytes(serie.Trim, 0, serie.Length, llave.aSerie, 0)
                'fBuscaDocumento(llave)

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
            Inicio.Show()
        Catch ex As Exception
            MsgBox(ex.Message & "Buscar error")
        End Try
    End Sub
End Class
