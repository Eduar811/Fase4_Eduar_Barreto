<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BaseDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDatosEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultimediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tematica2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDatosToolStripMenuItem, Me.MultimediaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BaseDatosToolStripMenuItem
        '
        Me.BaseDatosToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise
        Me.BaseDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseDatosEstudiantesToolStripMenuItem})
        Me.BaseDatosToolStripMenuItem.Name = "BaseDatosToolStripMenuItem"
        Me.BaseDatosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.BaseDatosToolStripMenuItem.Text = "Base_Datos"
        '
        'BaseDatosEstudiantesToolStripMenuItem
        '
        Me.BaseDatosEstudiantesToolStripMenuItem.Name = "BaseDatosEstudiantesToolStripMenuItem"
        Me.BaseDatosEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.BaseDatosEstudiantesToolStripMenuItem.Text = "Base_Datos_Estudiantes"
        '
        'MultimediaToolStripMenuItem
        '
        Me.MultimediaToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue
        Me.MultimediaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tematica2ToolStripMenuItem})
        Me.MultimediaToolStripMenuItem.Name = "MultimediaToolStripMenuItem"
        Me.MultimediaToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MultimediaToolStripMenuItem.Text = "Multimedia"
        '
        'Tematica2ToolStripMenuItem
        '
        Me.Tematica2ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Tematica2ToolStripMenuItem.Name = "Tematica2ToolStripMenuItem"
        Me.Tematica2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Tematica2ToolStripMenuItem.Text = "Tema_5"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(453, 110)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "   Fase 4 -Diseño prototipo con " & Global.Microsoft.VisualBasic.ChrW(10) & "       componente multimedia."
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(28, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 21)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Ciclos de programacion"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(43, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Ingresa aqui"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(373, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 26)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Registrate aqui"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(12, 225)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(295, 23)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Text = "Presentado por: Eduar Alexis Barreto Castaño"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(12, 268)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 23)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "Grupo 201416_31"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BaseDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDatosEstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultimediaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tematica2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
