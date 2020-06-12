<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnContar = New System.Windows.Forms.Button()
        Me.GrillaDatos = New System.Windows.Forms.DataGridView()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        CType(Me.GrillaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(133, 378)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(90, 29)
        Me.btnContar.TabIndex = 33
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'GrillaDatos
        '
        Me.GrillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaDatos.Location = New System.Drawing.Point(284, 12)
        Me.GrillaDatos.Name = "GrillaDatos"
        Me.GrillaDatos.Size = New System.Drawing.Size(504, 410)
        Me.GrillaDatos.TabIndex = 32
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(133, 308)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(90, 29)
        Me.btnSiguiente.TabIndex = 31
        Me.btnSiguiente.Text = "Siuiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(133, 343)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(90, 29)
        Me.btnListar.TabIndex = 30
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(133, 273)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 29)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(133, 238)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 29)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(133, 203)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 29)
        Me.btnModificar.TabIndex = 27
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(31, 142)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 16)
        Me.lblEmail.TabIndex = 26
        Me.lblEmail.Text = "Email"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(31, 107)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 16)
        Me.lblApellido.TabIndex = 25
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(31, 70)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(99, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(159, 20)
        Me.txtEmail.TabIndex = 23
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(99, 107)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(159, 20)
        Me.txtApellido.TabIndex = 22
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(99, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(159, 20)
        Me.txtNombre.TabIndex = 21
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(31, 35)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 16)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(99, 35)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(159, 20)
        Me.txtID.TabIndex = 19
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(133, 168)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(90, 29)
        Me.BtnInsertar.TabIndex = 18
        Me.BtnInsertar.Text = "Inserta"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.GrillaDatos)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContar As Button
    Friend WithEvents GrillaDatos As DataGridView
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents BtnInsertar As Button
End Class
