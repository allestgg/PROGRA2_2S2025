<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lbCursosAprobados = New Label()
        clbCursosAprobados = New CheckedListBox()
        Label12 = New Label()
        chbGraduado = New CheckBox()
        btEnviar = New Button()
        GroupBox1 = New GroupBox()
        rbNo = New RadioButton()
        rbSi = New RadioButton()
        tbDireccion = New TextBox()
        tbTelefono = New TextBox()
        tbDPI = New TextBox()
        tbApellido = New TextBox()
        tbNombre = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(lbCursosAprobados)
        Panel1.Controls.Add(clbCursosAprobados)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(chbGraduado)
        Panel1.Controls.Add(btEnviar)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(tbDireccion)
        Panel1.Controls.Add(tbTelefono)
        Panel1.Controls.Add(tbDPI)
        Panel1.Controls.Add(tbApellido)
        Panel1.Controls.Add(tbNombre)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(537, 583)
        Panel1.TabIndex = 0
        ' 
        ' lbCursosAprobados
        ' 
        lbCursosAprobados.AutoSize = True
        lbCursosAprobados.Location = New Point(328, 378)
        lbCursosAprobados.Name = "lbCursosAprobados"
        lbCursosAprobados.Size = New Size(104, 15)
        lbCursosAprobados.TabIndex = 19
        lbCursosAprobados.Text = "Cursos Aprobados"
        ' 
        ' clbCursosAprobados
        ' 
        clbCursosAprobados.FormattingEnabled = True
        clbCursosAprobados.Items.AddRange(New Object() {"Mate Basica 1", "Mate Basica 2", "Intermedia 1", "Intermedia 2", "Intermedia 3"})
        clbCursosAprobados.Location = New Point(329, 405)
        clbCursosAprobados.Name = "clbCursosAprobados"
        clbCursosAprobados.Size = New Size(120, 94)
        clbCursosAprobados.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(49, 434)
        Label12.Name = "Label12"
        Label12.Size = New Size(157, 15)
        Label12.TabIndex = 17
        Label12.Text = "Se graduo de la universidad?"
        ' 
        ' chbGraduado
        ' 
        chbGraduado.AutoSize = True
        chbGraduado.Location = New Point(52, 467)
        chbGraduado.Name = "chbGraduado"
        chbGraduado.Size = New Size(78, 19)
        chbGraduado.TabIndex = 16
        chbGraduado.Text = "Graduado"
        chbGraduado.UseVisualStyleBackColor = True
        ' 
        ' btEnviar
        ' 
        btEnviar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btEnviar.Location = New Point(38, 519)
        btEnviar.Name = "btEnviar"
        btEnviar.Size = New Size(236, 23)
        btEnviar.TabIndex = 15
        btEnviar.Text = "Enviar"
        btEnviar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbNo)
        GroupBox1.Controls.Add(rbSi)
        GroupBox1.Location = New Point(52, 382)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 41)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' rbNo
        ' 
        rbNo.AutoSize = True
        rbNo.Location = New Point(118, 13)
        rbNo.Name = "rbNo"
        rbNo.Size = New Size(41, 19)
        rbNo.TabIndex = 13
        rbNo.TabStop = True
        rbNo.Text = "No"
        rbNo.UseVisualStyleBackColor = True
        ' 
        ' rbSi
        ' 
        rbSi.AutoSize = True
        rbSi.Location = New Point(26, 13)
        rbSi.Name = "rbSi"
        rbSi.Size = New Size(34, 19)
        rbSi.TabIndex = 12
        rbSi.TabStop = True
        rbSi.Text = "Si"
        rbSi.UseVisualStyleBackColor = True
        ' 
        ' tbDireccion
        ' 
        tbDireccion.Location = New Point(47, 327)
        tbDireccion.Name = "tbDireccion"
        tbDireccion.Size = New Size(235, 23)
        tbDireccion.TabIndex = 11
        ' 
        ' tbTelefono
        ' 
        tbTelefono.Location = New Point(47, 271)
        tbTelefono.Name = "tbTelefono"
        tbTelefono.Size = New Size(235, 23)
        tbTelefono.TabIndex = 10
        ' 
        ' tbDPI
        ' 
        tbDPI.Location = New Point(47, 215)
        tbDPI.Name = "tbDPI"
        tbDPI.Size = New Size(235, 23)
        tbDPI.TabIndex = 9
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(52, 157)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(235, 23)
        tbApellido.TabIndex = 8
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(52, 104)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(235, 23)
        tbNombre.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(47, 364)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 15)
        Label7.TabIndex = 6
        Label7.Text = "Es Guatemalteco?"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(49, 309)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 5
        Label6.Text = "Direccion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 15)
        Label5.TabIndex = 4
        Label5.Text = "Numero Telefono"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 3
        Label4.Text = "No. DPI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("JetBrains Mono SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(38, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 31)
        Label1.TabIndex = 0
        Label1.Text = "FORMULARIO CLASE 2"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(533, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(266, 583)
        Panel2.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(27, 218)
        Label11.Name = "Label11"
        Label11.Size = New Size(180, 15)
        Label11.TabIndex = 3
        Label11.Text = "Curso: Programacion de Comp 2"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 183)
        Label10.Name = "Label10"
        Label10.Size = New Size(173, 15)
        Label10.TabIndex = 2
        Label10.Text = "Carrera: Ing Ciencias y Sistemas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(27, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 15)
        Label9.TabIndex = 1
        Label9.Text = "Nombre: Allan Sitan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("JetBrains Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(27, 106)
        Label8.Name = "Label8"
        Label8.Size = New Size(192, 17)
        Label8.TabIndex = 0
        Label8.Text = "Datos del Desarrollador"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 586)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDPI As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btEnviar As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label12 As Label
    Private chbGraduado As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbCursosAprobados As Label
    Private clbCursosAprobados As CheckedListBox
End Class
