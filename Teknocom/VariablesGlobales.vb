Module VariablesGlobales
    Public rutaArchivo As String = Nothing

    Public instancia As String
    Public base As String = "CompacWAdmin"
    Public idUser As String
    Public password As String
    Public formularioInicio

    ' Variables para dar de alta Producto, clientes, domicilios, unidades de medida, documentos y movimientos
    Public arreglo() As String

    'Variables para dar de alta documento, personas y productos
    'datos para dar de alta un cliente
    Public claveMonedaCliente As String = Nothing
    Public idMonedaCliente As Integer = Nothing
    Public codigoDelCliente As String = Nothing
    Public nombreRazonSocialCliente As String = Nothing
    Public denomComercialCliente As String = Nothing
    Public rfcCliente As String = Nothing
    Public claveUsoCDFI As String = Nothing

    'datos para dar de alta el domicilio del cliente
    Public calleCliente As String = Nothing
    Public numExteriorCliente As Integer = Nothing
    Public coloniaCliente As String = Nothing
    Public codigoPostalCliente As Integer = Nothing
    Public municipioCliente As String = Nothing
    Public estadoCliente As String = Nothing
    Public paisCliente As String = Nothing

    'datos para dar de alta producto
    Public claveDeProducto As String = Nothing
    Public nombreProductoOServicio As String = Nothing

    'datos para dar de alta una unidad
    Public claveDeLaUnidad As String = Nothing
    Public nombreDeLaUnida As String = Nothing

    'datos para dar de alta un documento
    Public claveDeTipoDeComprobandeDocumento As String = Nothing
    Public LugarDeExpedicionDocumento As Integer = Nothing
    Public ClaveRegimenFiscalDocumento As Integer = Nothing
    Public ClaveFormaDePagoDocumento As Integer = Nothing
    Public ClaveMetodoDePagoDocumento As String = Nothing

    Public palabraEnArreglo() As String = Nothing
End Module
