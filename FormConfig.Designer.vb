<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfig))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInfoPC = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtgUsuarios)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'dtgUsuarios
        '
        Me.dtgUsuarios.AllowUserToAddRows = False
        Me.dtgUsuarios.AllowUserToDeleteRows = False
        Me.dtgUsuarios.AllowUserToResizeColumns = False
        Me.dtgUsuarios.AllowUserToResizeRows = False
        Me.dtgUsuarios.BackgroundColor = System.Drawing.Color.Ivory
        Me.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsuarios.Location = New System.Drawing.Point(9, 89)
        Me.dtgUsuarios.Name = "dtgUsuarios"
        Me.dtgUsuarios.Size = New System.Drawing.Size(645, 162)
        Me.dtgUsuarios.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(90, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.ComboBox1.Location = New System.Drawing.Point(443, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(226, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 21)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PC"
        '
        'lblInfoPC
        '
        Me.lblInfoPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfoPC.Location = New System.Drawing.Point(12, 272)
        Me.lblInfoPC.Name = "lblInfoPC"
        Me.lblInfoPC.Size = New System.Drawing.Size(661, 111)
        Me.lblInfoPC.TabIndex = 1
        Me.lblInfoPC.Text = "Label4"
        Me.lblInfoPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 391)
        Me.Controls.Add(Me.lblInfoPC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormConfig"
        Me.Text = "Configuracion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgUsuarios As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInfoPC As Label
End Class
