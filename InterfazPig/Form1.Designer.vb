<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InterfazPig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfazPig))
        Me.txtSumaPuntos = New System.Windows.Forms.TextBox()
        Me.txtPuntosMaquina = New System.Windows.Forms.TextBox()
        Me.txtPuntaje = New System.Windows.Forms.TextBox()
        Me.txtDados = New System.Windows.Forms.TextBox()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.btnTirarMaquina = New System.Windows.Forms.Button()
        Me.lbPuntos = New System.Windows.Forms.Label()
        Me.lbPuntosMaquina = New System.Windows.Forms.Label()
        Me.lbPuntaje = New System.Windows.Forms.Label()
        Me.lbdado = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.btnDetenermeMaq = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSumaPuntos
        '
        Me.txtSumaPuntos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSumaPuntos.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumaPuntos.Location = New System.Drawing.Point(76, 65)
        Me.txtSumaPuntos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSumaPuntos.Name = "txtSumaPuntos"
        Me.txtSumaPuntos.Size = New System.Drawing.Size(74, 29)
        Me.txtSumaPuntos.TabIndex = 0
        Me.txtSumaPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPuntosMaquina
        '
        Me.txtPuntosMaquina.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPuntosMaquina.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuntosMaquina.Location = New System.Drawing.Point(470, 65)
        Me.txtPuntosMaquina.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPuntosMaquina.Name = "txtPuntosMaquina"
        Me.txtPuntosMaquina.Size = New System.Drawing.Size(90, 29)
        Me.txtPuntosMaquina.TabIndex = 1
        Me.txtPuntosMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPuntaje
        '
        Me.txtPuntaje.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPuntaje.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPuntaje.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPuntaje.Location = New System.Drawing.Point(288, 193)
        Me.txtPuntaje.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPuntaje.Name = "txtPuntaje"
        Me.txtPuntaje.Size = New System.Drawing.Size(88, 29)
        Me.txtPuntaje.TabIndex = 2
        Me.txtPuntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDados
        '
        Me.txtDados.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDados.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDados.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtDados.Location = New System.Drawing.Point(288, 285)
        Me.txtDados.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDados.Name = "txtDados"
        Me.txtDados.Size = New System.Drawing.Size(88, 29)
        Me.txtDados.TabIndex = 3
        Me.txtDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTirar
        '
        Me.btnTirar.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirar.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTirar.Location = New System.Drawing.Point(60, 364)
        Me.btnTirar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(100, 46)
        Me.btnTirar.TabIndex = 4
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = True
        '
        'btnTirarMaquina
        '
        Me.btnTirarMaquina.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarMaquina.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTirarMaquina.Location = New System.Drawing.Point(441, 364)
        Me.btnTirarMaquina.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTirarMaquina.Name = "btnTirarMaquina"
        Me.btnTirarMaquina.Size = New System.Drawing.Size(133, 46)
        Me.btnTirarMaquina.TabIndex = 5
        Me.btnTirarMaquina.Text = "Tirar 2"
        Me.btnTirarMaquina.UseVisualStyleBackColor = True
        '
        'lbPuntos
        '
        Me.lbPuntos.AutoSize = True
        Me.lbPuntos.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntos.ForeColor = System.Drawing.Color.YellowGreen
        Me.lbPuntos.Location = New System.Drawing.Point(89, 27)
        Me.lbPuntos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPuntos.Name = "lbPuntos"
        Me.lbPuntos.Size = New System.Drawing.Size(61, 20)
        Me.lbPuntos.TabIndex = 6
        Me.lbPuntos.Text = "Puntos"
        '
        'lbPuntosMaquina
        '
        Me.lbPuntosMaquina.AutoSize = True
        Me.lbPuntosMaquina.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntosMaquina.ForeColor = System.Drawing.Color.YellowGreen
        Me.lbPuntosMaquina.Location = New System.Drawing.Point(456, 27)
        Me.lbPuntosMaquina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPuntosMaquina.Name = "lbPuntosMaquina"
        Me.lbPuntosMaquina.Size = New System.Drawing.Size(129, 20)
        Me.lbPuntosMaquina.TabIndex = 7
        Me.lbPuntosMaquina.Text = "Puntos Maquina"
        '
        'lbPuntaje
        '
        Me.lbPuntaje.AutoSize = True
        Me.lbPuntaje.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPuntaje.ForeColor = System.Drawing.Color.YellowGreen
        Me.lbPuntaje.Location = New System.Drawing.Point(297, 170)
        Me.lbPuntaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPuntaje.Name = "lbPuntaje"
        Me.lbPuntaje.Size = New System.Drawing.Size(65, 20)
        Me.lbPuntaje.TabIndex = 8
        Me.lbPuntaje.Text = "Puntaje"
        '
        'lbdado
        '
        Me.lbdado.AutoSize = True
        Me.lbdado.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdado.ForeColor = System.Drawing.Color.YellowGreen
        Me.lbdado.Location = New System.Drawing.Point(297, 262)
        Me.lbdado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbdado.Name = "lbdado"
        Me.lbdado.Size = New System.Drawing.Size(48, 20)
        Me.lbdado.TabIndex = 9
        Me.lbdado.Text = "Dado"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Maroon
        Me.btnSalir.Location = New System.Drawing.Point(301, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 32)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnDetener
        '
        Me.btnDetener.Location = New System.Drawing.Point(192, 122)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(83, 26)
        Me.btnDetener.TabIndex = 11
        Me.btnDetener.Text = "Detenerme"
        Me.btnDetener.UseVisualStyleBackColor = True
        '
        'btnDetenermeMaq
        '
        Me.btnDetenermeMaq.Location = New System.Drawing.Point(403, 122)
        Me.btnDetenermeMaq.Name = "btnDetenermeMaq"
        Me.btnDetenermeMaq.Size = New System.Drawing.Size(84, 26)
        Me.btnDetenermeMaq.TabIndex = 12
        Me.btnDetenermeMaq.Text = "Detenerme"
        Me.btnDetenermeMaq.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(4, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'InterfazPig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(612, 416)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDetenermeMaq)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lbdado)
        Me.Controls.Add(Me.lbPuntaje)
        Me.Controls.Add(Me.lbPuntosMaquina)
        Me.Controls.Add(Me.lbPuntos)
        Me.Controls.Add(Me.btnTirarMaquina)
        Me.Controls.Add(Me.btnTirar)
        Me.Controls.Add(Me.txtDados)
        Me.Controls.Add(Me.txtPuntaje)
        Me.Controls.Add(Me.txtPuntosMaquina)
        Me.Controls.Add(Me.txtSumaPuntos)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "InterfazPig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego Pig "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSumaPuntos As TextBox
    Friend WithEvents txtPuntosMaquina As TextBox
    Friend WithEvents txtPuntaje As TextBox
    Friend WithEvents txtDados As TextBox
    Friend WithEvents btnTirar As Button
    Friend WithEvents btnTirarMaquina As Button
    Friend WithEvents lbPuntos As Label
    Friend WithEvents lbPuntosMaquina As Label
    Friend WithEvents lbPuntaje As Label
    Friend WithEvents lbdado As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnDetener As Button
    Friend WithEvents btnDetenermeMaq As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
