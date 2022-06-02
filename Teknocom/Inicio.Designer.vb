<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CBInactivo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CBListaDePrecios = New System.Windows.Forms.ComboBox()
        Me.CBVentasACredito = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CBFacturarATeceros = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TBNombreLargo = New System.Windows.Forms.TextBox()
        Me.TBRFC = New System.Windows.Forms.TextBox()
        Me.TBDenomComercial = New System.Windows.Forms.TextBox()
        Me.TBMonedaCliente = New System.Windows.Forms.TextBox()
        Me.TBCurp = New System.Windows.Forms.TextBox()
        Me.TBReprLegal = New System.Windows.Forms.TextBox()
        Me.TBMonedaDoctos = New System.Windows.Forms.TextBox()
        Me.TBClas1Cliente = New System.Windows.Forms.TextBox()
        Me.TBClas2Cliente = New System.Windows.Forms.TextBox()
        Me.TBClas3Cliente = New System.Windows.Forms.TextBox()
        Me.TBClas4Cliente = New System.Windows.Forms.TextBox()
        Me.TBClas5Cliente = New System.Windows.Forms.TextBox()
        Me.TBClas6Cliente = New System.Windows.Forms.TextBox()
        Me.TBDescuento = New System.Windows.Forms.TextBox()
        Me.TBSaldoActual = New System.Windows.Forms.TextBox()
        Me.TBIva = New System.Windows.Forms.TextBox()
        Me.TBIesps = New System.Windows.Forms.TextBox()
        Me.TBImpuesto3 = New System.Windows.Forms.TextBox()
        Me.TBRetencionIsr = New System.Windows.Forms.TextBox()
        Me.TBRetencionIva = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(713, 636)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 1
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 572)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TBRetencionIva)
        Me.TabPage1.Controls.Add(Me.TBRetencionIsr)
        Me.TabPage1.Controls.Add(Me.TBImpuesto3)
        Me.TabPage1.Controls.Add(Me.TBIesps)
        Me.TabPage1.Controls.Add(Me.TBIva)
        Me.TabPage1.Controls.Add(Me.TBSaldoActual)
        Me.TabPage1.Controls.Add(Me.TBDescuento)
        Me.TabPage1.Controls.Add(Me.TBClas6Cliente)
        Me.TabPage1.Controls.Add(Me.TBClas5Cliente)
        Me.TabPage1.Controls.Add(Me.TBClas4Cliente)
        Me.TabPage1.Controls.Add(Me.TBClas3Cliente)
        Me.TabPage1.Controls.Add(Me.TBClas2Cliente)
        Me.TabPage1.Controls.Add(Me.TBClas1Cliente)
        Me.TabPage1.Controls.Add(Me.TBMonedaDoctos)
        Me.TabPage1.Controls.Add(Me.TBReprLegal)
        Me.TabPage1.Controls.Add(Me.TBCurp)
        Me.TabPage1.Controls.Add(Me.TBMonedaCliente)
        Me.TabPage1.Controls.Add(Me.TBDenomComercial)
        Me.TabPage1.Controls.Add(Me.TBRFC)
        Me.TabPage1.Controls.Add(Me.TBNombreLargo)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.CBFacturarATeceros)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.CBVentasACredito)
        Me.TabPage1.Controls.Add(Me.CBListaDePrecios)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CBInactivo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TBNombre)
        Me.TabPage1.Controls.Add(Me.TBCodigo)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 546)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CBInactivo
        '
        Me.CBInactivo.AutoSize = True
        Me.CBInactivo.Location = New System.Drawing.Point(422, 74)
        Me.CBInactivo.Name = "CBInactivo"
        Me.CBInactivo.Size = New System.Drawing.Size(64, 17)
        Me.CBInactivo.TabIndex = 7
        Me.CBInactivo.Text = "Inactivo"
        Me.CBInactivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de registro:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(422, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre Largo:"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(87, 44)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(194, 20)
        Me.TBNombre.TabIndex = 3
        '
        'TBCodigo
        '
        Me.TBCodigo.Location = New System.Drawing.Point(82, 20)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(74, 20)
        Me.TBCodigo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:*"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 52)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Datos del cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "RFC:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Denom. comercial:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Moneda del cliente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "CURP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Repr. Legal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Moneda en Doctos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(425, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Clasificación 1 del cliente:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(425, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Clasificación 2 del cliente:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(425, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Clasificación 3 del cliente:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(425, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Clasificación 4 del cliente:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(425, 257)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Clasificación 5 del cliente:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(425, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Clasificación 6 del cliente:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(428, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Clasificacion"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(21, 322)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Datos comerciales"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 354)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Lista de precios:"
        '
        'CBListaDePrecios
        '
        Me.CBListaDePrecios.FormattingEnabled = True
        Me.CBListaDePrecios.Location = New System.Drawing.Point(114, 351)
        Me.CBListaDePrecios.Name = "CBListaDePrecios"
        Me.CBListaDePrecios.Size = New System.Drawing.Size(121, 21)
        Me.CBListaDePrecios.TabIndex = 24
        '
        'CBVentasACredito
        '
        Me.CBVentasACredito.AutoSize = True
        Me.CBVentasACredito.Location = New System.Drawing.Point(27, 381)
        Me.CBVentasACredito.Name = "CBVentasACredito"
        Me.CBVentasACredito.Size = New System.Drawing.Size(103, 17)
        Me.CBVentasACredito.TabIndex = 25
        Me.CBVentasACredito.Text = "Ventas a credito"
        Me.CBVentasACredito.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 405)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Descuento:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(428, 354)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 13)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Saldo actual:"
        '
        'CBFacturarATeceros
        '
        Me.CBFacturarATeceros.AutoSize = True
        Me.CBFacturarATeceros.Location = New System.Drawing.Point(431, 381)
        Me.CBFacturarATeceros.Name = "CBFacturarATeceros"
        Me.CBFacturarATeceros.Size = New System.Drawing.Size(115, 17)
        Me.CBFacturarATeceros.TabIndex = 28
        Me.CBFacturarATeceros.Text = "Facturar a terceros"
        Me.CBFacturarATeceros.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(24, 435)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Impuestos y retenciones"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(24, 466)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "I.V.A:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 492)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "I.E.S.P.S:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(24, 514)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Impuesto 3:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(428, 466)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 13)
        Me.Label27.TabIndex = 33
        Me.Label27.Text = "Retención  I.S.R:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(428, 492)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 13)
        Me.Label28.TabIndex = 34
        Me.Label28.Text = "Retención I.V.A:"
        '
        'TBNombreLargo
        '
        Me.TBNombreLargo.Location = New System.Drawing.Point(104, 67)
        Me.TBNombreLargo.Name = "TBNombreLargo"
        Me.TBNombreLargo.Size = New System.Drawing.Size(312, 20)
        Me.TBNombreLargo.TabIndex = 35
        '
        'TBRFC
        '
        Me.TBRFC.Location = New System.Drawing.Point(62, 154)
        Me.TBRFC.Name = "TBRFC"
        Me.TBRFC.Size = New System.Drawing.Size(219, 20)
        Me.TBRFC.TabIndex = 36
        '
        'TBDenomComercial
        '
        Me.TBDenomComercial.Location = New System.Drawing.Point(126, 183)
        Me.TBDenomComercial.Name = "TBDenomComercial"
        Me.TBDenomComercial.Size = New System.Drawing.Size(155, 20)
        Me.TBDenomComercial.TabIndex = 37
        '
        'TBMonedaCliente
        '
        Me.TBMonedaCliente.Location = New System.Drawing.Point(131, 208)
        Me.TBMonedaCliente.Name = "TBMonedaCliente"
        Me.TBMonedaCliente.Size = New System.Drawing.Size(150, 20)
        Me.TBMonedaCliente.TabIndex = 38
        '
        'TBCurp
        '
        Me.TBCurp.Location = New System.Drawing.Point(71, 234)
        Me.TBCurp.Name = "TBCurp"
        Me.TBCurp.Size = New System.Drawing.Size(210, 20)
        Me.TBCurp.TabIndex = 39
        '
        'TBReprLegal
        '
        Me.TBReprLegal.Location = New System.Drawing.Point(96, 257)
        Me.TBReprLegal.Name = "TBReprLegal"
        Me.TBReprLegal.Size = New System.Drawing.Size(185, 20)
        Me.TBReprLegal.TabIndex = 40
        '
        'TBMonedaDoctos
        '
        Me.TBMonedaDoctos.Location = New System.Drawing.Point(132, 284)
        Me.TBMonedaDoctos.Name = "TBMonedaDoctos"
        Me.TBMonedaDoctos.Size = New System.Drawing.Size(149, 20)
        Me.TBMonedaDoctos.TabIndex = 41
        '
        'TBClas1Cliente
        '
        Me.TBClas1Cliente.Location = New System.Drawing.Point(561, 158)
        Me.TBClas1Cliente.Name = "TBClas1Cliente"
        Me.TBClas1Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas1Cliente.TabIndex = 42
        '
        'TBClas2Cliente
        '
        Me.TBClas2Cliente.Location = New System.Drawing.Point(561, 182)
        Me.TBClas2Cliente.Name = "TBClas2Cliente"
        Me.TBClas2Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas2Cliente.TabIndex = 43
        '
        'TBClas3Cliente
        '
        Me.TBClas3Cliente.Location = New System.Drawing.Point(561, 209)
        Me.TBClas3Cliente.Name = "TBClas3Cliente"
        Me.TBClas3Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas3Cliente.TabIndex = 44
        '
        'TBClas4Cliente
        '
        Me.TBClas4Cliente.Location = New System.Drawing.Point(561, 233)
        Me.TBClas4Cliente.Name = "TBClas4Cliente"
        Me.TBClas4Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas4Cliente.TabIndex = 45
        '
        'TBClas5Cliente
        '
        Me.TBClas5Cliente.Location = New System.Drawing.Point(561, 256)
        Me.TBClas5Cliente.Name = "TBClas5Cliente"
        Me.TBClas5Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas5Cliente.TabIndex = 46
        '
        'TBClas6Cliente
        '
        Me.TBClas6Cliente.Location = New System.Drawing.Point(561, 282)
        Me.TBClas6Cliente.Name = "TBClas6Cliente"
        Me.TBClas6Cliente.Size = New System.Drawing.Size(100, 20)
        Me.TBClas6Cliente.TabIndex = 47
        '
        'TBDescuento
        '
        Me.TBDescuento.Location = New System.Drawing.Point(96, 405)
        Me.TBDescuento.Name = "TBDescuento"
        Me.TBDescuento.Size = New System.Drawing.Size(139, 20)
        Me.TBDescuento.TabIndex = 48
        '
        'TBSaldoActual
        '
        Me.TBSaldoActual.Location = New System.Drawing.Point(517, 351)
        Me.TBSaldoActual.Name = "TBSaldoActual"
        Me.TBSaldoActual.Size = New System.Drawing.Size(144, 20)
        Me.TBSaldoActual.TabIndex = 49
        '
        'TBIva
        '
        Me.TBIva.Location = New System.Drawing.Point(64, 463)
        Me.TBIva.Name = "TBIva"
        Me.TBIva.Size = New System.Drawing.Size(171, 20)
        Me.TBIva.TabIndex = 50
        '
        'TBIesps
        '
        Me.TBIesps.Location = New System.Drawing.Point(84, 488)
        Me.TBIesps.Name = "TBIesps"
        Me.TBIesps.Size = New System.Drawing.Size(151, 20)
        Me.TBIesps.TabIndex = 51
        '
        'TBImpuesto3
        '
        Me.TBImpuesto3.Location = New System.Drawing.Point(93, 514)
        Me.TBImpuesto3.Name = "TBImpuesto3"
        Me.TBImpuesto3.Size = New System.Drawing.Size(142, 20)
        Me.TBImpuesto3.TabIndex = 52
        '
        'TBRetencionIsr
        '
        Me.TBRetencionIsr.Location = New System.Drawing.Point(524, 465)
        Me.TBRetencionIsr.Name = "TBRetencionIsr"
        Me.TBRetencionIsr.Size = New System.Drawing.Size(137, 20)
        Me.TBRetencionIsr.TabIndex = 53
        '
        'TBRetencionIva
        '
        Me.TBRetencionIva.Location = New System.Drawing.Point(520, 492)
        Me.TBRetencionIva.Name = "TBRetencionIva"
        Me.TBRetencionIva.Size = New System.Drawing.Size(100, 20)
        Me.TBRetencionIva.TabIndex = 54
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 671)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNSalir)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNSalir As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBInactivo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TBRetencionIva As TextBox
    Friend WithEvents TBRetencionIsr As TextBox
    Friend WithEvents TBImpuesto3 As TextBox
    Friend WithEvents TBIesps As TextBox
    Friend WithEvents TBIva As TextBox
    Friend WithEvents TBSaldoActual As TextBox
    Friend WithEvents TBDescuento As TextBox
    Friend WithEvents TBClas6Cliente As TextBox
    Friend WithEvents TBClas5Cliente As TextBox
    Friend WithEvents TBClas4Cliente As TextBox
    Friend WithEvents TBClas3Cliente As TextBox
    Friend WithEvents TBClas2Cliente As TextBox
    Friend WithEvents TBClas1Cliente As TextBox
    Friend WithEvents TBMonedaDoctos As TextBox
    Friend WithEvents TBReprLegal As TextBox
    Friend WithEvents TBCurp As TextBox
    Friend WithEvents TBMonedaCliente As TextBox
    Friend WithEvents TBDenomComercial As TextBox
    Friend WithEvents TBRFC As TextBox
    Friend WithEvents TBNombreLargo As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents CBFacturarATeceros As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CBVentasACredito As CheckBox
    Friend WithEvents CBListaDePrecios As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
