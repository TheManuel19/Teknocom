<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormatosDeInfo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CBTextoPlano = New System.Windows.Forms.CheckBox()
        Me.CBExcel = New System.Windows.Forms.CheckBox()
        Me.CBXml = New System.Windows.Forms.CheckBox()
        Me.CBBd = New System.Windows.Forms.CheckBox()
        Me.CBManual = New System.Windows.Forms.CheckBox()
        Me.OFDArchivosDeDatos = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBSimbolo = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBTextoPlano
        '
        Me.CBTextoPlano.AutoSize = True
        Me.CBTextoPlano.Location = New System.Drawing.Point(45, 10)
        Me.CBTextoPlano.Name = "CBTextoPlano"
        Me.CBTextoPlano.Size = New System.Drawing.Size(152, 17)
        Me.CBTextoPlano.TabIndex = 7
        Me.CBTextoPlano.Text = "Archivo de texto plano (txt)"
        Me.CBTextoPlano.UseVisualStyleBackColor = True
        '
        'CBExcel
        '
        Me.CBExcel.AutoSize = True
        Me.CBExcel.Location = New System.Drawing.Point(45, 33)
        Me.CBExcel.Name = "CBExcel"
        Me.CBExcel.Size = New System.Drawing.Size(106, 17)
        Me.CBExcel.TabIndex = 8
        Me.CBExcel.Text = "Archivo de Excel"
        Me.CBExcel.UseVisualStyleBackColor = True
        '
        'CBXml
        '
        Me.CBXml.AutoSize = True
        Me.CBXml.Location = New System.Drawing.Point(45, 56)
        Me.CBXml.Name = "CBXml"
        Me.CBXml.Size = New System.Drawing.Size(87, 17)
        Me.CBXml.TabIndex = 9
        Me.CBXml.Text = "Archivo XML"
        Me.CBXml.UseVisualStyleBackColor = True
        '
        'CBBd
        '
        Me.CBBd.AutoSize = True
        Me.CBBd.Location = New System.Drawing.Point(45, 79)
        Me.CBBd.Name = "CBBd"
        Me.CBBd.Size = New System.Drawing.Size(100, 17)
        Me.CBBd.TabIndex = 10
        Me.CBBd.Text = "Acceso a datos"
        Me.CBBd.UseVisualStyleBackColor = True
        '
        'CBManual
        '
        Me.CBManual.AutoSize = True
        Me.CBManual.Location = New System.Drawing.Point(45, 102)
        Me.CBManual.Name = "CBManual"
        Me.CBManual.Size = New System.Drawing.Size(100, 17)
        Me.CBManual.TabIndex = 11
        Me.CBManual.Text = "Entrada manual"
        Me.CBManual.UseVisualStyleBackColor = True
        '
        'OFDArchivosDeDatos
        '
        Me.OFDArchivosDeDatos.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 53)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Simbolo separador"
        '
        'TBSimbolo
        '
        Me.TBSimbolo.Location = New System.Drawing.Point(330, 10)
        Me.TBSimbolo.Name = "TBSimbolo"
        Me.TBSimbolo.Size = New System.Drawing.Size(20, 20)
        Me.TBSimbolo.TabIndex = 14
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, -2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBTextoPlano)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TBSimbolo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBExcel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBXml)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBBd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBManual)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 381)
        Me.SplitContainer1.SplitterDistance = 144
        Me.SplitContainer1.TabIndex = 15
        '
        'FormatosDeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormatosDeInfo"
        Me.Text = "FormatosDeInfo"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CBTextoPlano As CheckBox
    Friend WithEvents CBExcel As CheckBox
    Friend WithEvents CBXml As CheckBox
    Friend WithEvents CBBd As CheckBox
    Friend WithEvents CBManual As CheckBox
    Friend WithEvents OFDArchivosDeDatos As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TBSimbolo As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
