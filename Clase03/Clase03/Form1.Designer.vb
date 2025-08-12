<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbCodigoPais = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.tbCodigoPais)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbPassword)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbNombre)
        Me.Panel1.Controls.Add(Me.tbApellido)
        Me.Panel1.Controls.Add(Me.tbEdad)
        Me.Panel1.Controls.Add(Me.tbTelefono)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbEdad)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btEnviar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 802)
        Me.Panel1.TabIndex = 0
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(76, 132)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(295, 20)
        Me.tbNombre.TabIndex = 9
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(76, 197)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(295, 20)
        Me.tbApellido.TabIndex = 8
        '
        'tbEdad
        '
        Me.tbEdad.Location = New System.Drawing.Point(76, 263)
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.Size = New System.Drawing.Size(295, 20)
        Me.tbEdad.TabIndex = 7
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(76, 378)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(295, 20)
        Me.tbTelefono.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Numero de Telefono"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEdad.Location = New System.Drawing.Point(73, 244)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(40, 16)
        Me.lbEdad.TabIndex = 4
        Me.lbEdad.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'btEnviar
        '
        Me.btEnviar.BackColor = System.Drawing.Color.YellowGreen
        Me.btEnviar.Location = New System.Drawing.Point(76, 496)
        Me.btEnviar.Name = "btEnviar"
        Me.btEnviar.Size = New System.Drawing.Size(187, 23)
        Me.btEnviar.TabIndex = 1
        Me.btEnviar.Text = "ENVIAR"
        Me.btEnviar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("JetBrains Mono NL Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulario Clase 03"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(812, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 802)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password"
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(76, 457)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(295, 20)
        Me.tbPassword.TabIndex = 11
        '
        'tbCodigoPais
        '
        Me.tbCodigoPais.Location = New System.Drawing.Point(76, 326)
        Me.tbCodigoPais.Name = "tbCodigoPais"
        Me.tbCodigoPais.Size = New System.Drawing.Size(295, 20)
        Me.tbCodigoPais.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Codigo Pais"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 805)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btEnviar As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigoPais As TextBox
    Friend WithEvents Label6 As Label
End Class
