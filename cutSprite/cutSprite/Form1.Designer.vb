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
        Me.btArquivo = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pc1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtQCol = New System.Windows.Forms.TextBox
        Me.txtQLin = New System.Windows.Forms.TextBox
        Me.btCortar = New System.Windows.Forms.Button
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTLin = New System.Windows.Forms.TextBox
        Me.txtTCol = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.rQtd = New System.Windows.Forms.RadioButton
        Me.rTam = New System.Windows.Forms.RadioButton
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.pcTransp = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.pc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btArquivo
        '
        Me.btArquivo.Location = New System.Drawing.Point(12, 12)
        Me.btArquivo.Name = "btArquivo"
        Me.btArquivo.Size = New System.Drawing.Size(236, 23)
        Me.btArquivo.TabIndex = 0
        Me.btArquivo.Text = "Arquivo"
        Me.btArquivo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pc1)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 317)
        Me.Panel1.TabIndex = 1
        '
        'pc1
        '
        Me.pc1.Location = New System.Drawing.Point(3, 3)
        Me.pc1.Name = "pc1"
        Me.pc1.Size = New System.Drawing.Size(100, 50)
        Me.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pc1.TabIndex = 0
        Me.pc1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(254, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Colunas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQCol
        '
        Me.txtQCol.Location = New System.Drawing.Point(309, 75)
        Me.txtQCol.Name = "txtQCol"
        Me.txtQCol.Size = New System.Drawing.Size(54, 20)
        Me.txtQCol.TabIndex = 4
        '
        'txtQLin
        '
        Me.txtQLin.Location = New System.Drawing.Point(309, 101)
        Me.txtQLin.Name = "txtQLin"
        Me.txtQLin.Size = New System.Drawing.Size(54, 20)
        Me.txtQLin.TabIndex = 5
        '
        'btCortar
        '
        Me.btCortar.Location = New System.Drawing.Point(257, 335)
        Me.btCortar.Name = "btCortar"
        Me.btCortar.Size = New System.Drawing.Size(105, 23)
        Me.btCortar.TabIndex = 6
        Me.btCortar.Text = "Cortar"
        Me.btCortar.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.Filter = "Arquivo PNG (*.png)|*.png"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(254, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Linhas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(254, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Linhas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTLin
        '
        Me.txtTLin.Enabled = False
        Me.txtTLin.Location = New System.Drawing.Point(309, 229)
        Me.txtTLin.Name = "txtTLin"
        Me.txtTLin.Size = New System.Drawing.Size(54, 20)
        Me.txtTLin.TabIndex = 11
        '
        'txtTCol
        '
        Me.txtTCol.Enabled = False
        Me.txtTCol.Location = New System.Drawing.Point(309, 203)
        Me.txtTCol.Name = "txtTCol"
        Me.txtTCol.Size = New System.Drawing.Size(54, 20)
        Me.txtTCol.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(254, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Colunas:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rQtd
        '
        Me.rQtd.AutoSize = True
        Me.rQtd.Checked = True
        Me.rQtd.Location = New System.Drawing.Point(257, 44)
        Me.rQtd.Name = "rQtd"
        Me.rQtd.Size = New System.Drawing.Size(80, 17)
        Me.rQtd.TabIndex = 13
        Me.rQtd.TabStop = True
        Me.rQtd.Text = "Quantidade"
        Me.rQtd.UseVisualStyleBackColor = True
        '
        'rTam
        '
        Me.rTam.AutoSize = True
        Me.rTam.Location = New System.Drawing.Point(257, 170)
        Me.rTam.Name = "rTam"
        Me.rTam.Size = New System.Drawing.Size(70, 17)
        Me.rTam.TabIndex = 14
        Me.rTam.Text = "Tamanho"
        Me.rTam.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(254, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cor transp.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pcTransp
        '
        Me.pcTransp.Location = New System.Drawing.Point(319, 269)
        Me.pcTransp.Name = "pcTransp"
        Me.pcTransp.Size = New System.Drawing.Size(40, 40)
        Me.pcTransp.TabIndex = 16
        Me.pcTransp.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 370)
        Me.Controls.Add(Me.pcTransp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rTam)
        Me.Controls.Add(Me.rQtd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTLin)
        Me.Controls.Add(Me.txtTCol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btCortar)
        Me.Controls.Add(Me.txtQLin)
        Me.Controls.Add(Me.txtQCol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btArquivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Cut Sprite"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcTransp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btArquivo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQCol As System.Windows.Forms.TextBox
    Friend WithEvents txtQLin As System.Windows.Forms.TextBox
    Friend WithEvents pc1 As System.Windows.Forms.PictureBox
    Friend WithEvents btCortar As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTLin As System.Windows.Forms.TextBox
    Friend WithEvents txtTCol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rQtd As System.Windows.Forms.RadioButton
    Friend WithEvents rTam As System.Windows.Forms.RadioButton
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pcTransp As System.Windows.Forms.PictureBox

End Class
