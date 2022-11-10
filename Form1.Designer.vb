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
        Me.RBTexto = New System.Windows.Forms.RadioButton()
        Me.RBArchivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBEntrada = New System.Windows.Forms.TextBox()
        Me.LblEntrada = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.PnlRespuestas = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.PnlRespuestas.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBTexto
        '
        Me.RBTexto.AutoSize = True
        Me.RBTexto.Location = New System.Drawing.Point(6, 21)
        Me.RBTexto.Name = "RBTexto"
        Me.RBTexto.Size = New System.Drawing.Size(64, 24)
        Me.RBTexto.TabIndex = 0
        Me.RBTexto.TabStop = True
        Me.RBTexto.Text = "texto"
        Me.RBTexto.UseVisualStyleBackColor = True
        '
        'RBArchivo
        '
        Me.RBArchivo.AutoSize = True
        Me.RBArchivo.Location = New System.Drawing.Point(76, 21)
        Me.RBArchivo.Name = "RBArchivo"
        Me.RBArchivo.Size = New System.Drawing.Size(80, 24)
        Me.RBArchivo.TabIndex = 1
        Me.RBArchivo.TabStop = True
        Me.RBArchivo.Text = "Archivo"
        Me.RBArchivo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTexto)
        Me.GroupBox1.Controls.Add(Me.RBArchivo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección"
        '
        'TBEntrada
        '
        Me.TBEntrada.Location = New System.Drawing.Point(84, 75)
        Me.TBEntrada.Name = "TBEntrada"
        Me.TBEntrada.Size = New System.Drawing.Size(1230, 27)
        Me.TBEntrada.TabIndex = 3
        '
        'LblEntrada
        '
        Me.LblEntrada.AutoSize = True
        Me.LblEntrada.Location = New System.Drawing.Point(18, 78)
        Me.LblEntrada.Name = "LblEntrada"
        Me.LblEntrada.Size = New System.Drawing.Size(60, 20)
        Me.LblEntrada.TabIndex = 4
        Me.LblEntrada.Text = "Entrada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MD5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SHA1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SHA384"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SHA256"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SHA512"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1201, 27)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(107, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1201, 27)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1201, 27)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(107, 130)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(1201, 27)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(107, 168)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(1201, 27)
        Me.TextBox5.TabIndex = 15
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(190, 12)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(110, 60)
        Me.BtnSeleccionar.TabIndex = 17
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(320, 12)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(980, 60)
        Me.BtnCalcular.TabIndex = 18
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'PnlRespuestas
        '
        Me.PnlRespuestas.Controls.Add(Me.TextBox1)
        Me.PnlRespuestas.Controls.Add(Me.Label1)
        Me.PnlRespuestas.Controls.Add(Me.Label2)
        Me.PnlRespuestas.Controls.Add(Me.TextBox5)
        Me.PnlRespuestas.Controls.Add(Me.Label4)
        Me.PnlRespuestas.Controls.Add(Me.TextBox4)
        Me.PnlRespuestas.Controls.Add(Me.Label3)
        Me.PnlRespuestas.Controls.Add(Me.TextBox3)
        Me.PnlRespuestas.Controls.Add(Me.Label6)
        Me.PnlRespuestas.Controls.Add(Me.TextBox2)
        Me.PnlRespuestas.Location = New System.Drawing.Point(0, 124)
        Me.PnlRespuestas.Name = "PnlRespuestas"
        Me.PnlRespuestas.Size = New System.Drawing.Size(1320, 219)
        Me.PnlRespuestas.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1320, 507)
        Me.Controls.Add(Me.PnlRespuestas)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.LblEntrada)
        Me.Controls.Add(Me.TBEntrada)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlRespuestas.ResumeLayout(False)
        Me.PnlRespuestas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBTexto As RadioButton
    Friend WithEvents RBArchivo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBEntrada As TextBox
    Friend WithEvents LblEntrada As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents PnlRespuestas As Panel
End Class
