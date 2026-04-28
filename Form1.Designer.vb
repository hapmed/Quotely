<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddFolio = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgIndice = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox10)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Index Detail"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label7)
        Me.GroupBox10.Location = New System.Drawing.Point(490, 71)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(100, 45)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(697, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Location = New System.Drawing.Point(118, 71)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(366, 45)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(360, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(100, 45)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Vigencia"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Location = New System.Drawing.Point(490, 20)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Contacto"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(224, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(260, 45)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Empresa"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(118, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(100, 45)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 45)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Folio"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 511)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 50)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddFolio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnConfig)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(885, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnAddFolio
        '
        Me.btnAddFolio.Location = New System.Drawing.Point(3, 3)
        Me.btnAddFolio.Name = "btnAddFolio"
        Me.btnAddFolio.Size = New System.Drawing.Size(120, 23)
        Me.btnAddFolio.TabIndex = 0
        Me.btnAddFolio.Text = "A&gregar"
        Me.btnAddFolio.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Abrir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Editar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(381, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(120, 23)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Eliminia&r"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(507, 3)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(120, 23)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "&Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(633, 3)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(120, 23)
        Me.btnConfig.TabIndex = 5
        Me.btnConfig.Text = "C&onfiguracion"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(759, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtgIndice)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(891, 389)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Index"
        '
        'dtgIndice
        '
        Me.dtgIndice.AllowUserToAddRows = False
        Me.dtgIndice.AllowUserToDeleteRows = False
        Me.dtgIndice.BackgroundColor = System.Drawing.Color.Ivory
        Me.dtgIndice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgIndice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgIndice.Location = New System.Drawing.Point(3, 17)
        Me.dtgIndice.Name = "dtgIndice"
        Me.dtgIndice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgIndice.Size = New System.Drawing.Size(885, 369)
        Me.dtgIndice.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Quotely"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAddFolio As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtgIndice As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
