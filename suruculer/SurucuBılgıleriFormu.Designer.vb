<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurucuBılgıleriFormu
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
        Me.SurucuComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BilgiTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YenilePictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.YenilePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SurucuComboBox1
        '
        Me.SurucuComboBox1.FormattingEnabled = True
        Me.SurucuComboBox1.Location = New System.Drawing.Point(50, 82)
        Me.SurucuComboBox1.Name = "SurucuComboBox1"
        Me.SurucuComboBox1.Size = New System.Drawing.Size(173, 33)
        Me.SurucuComboBox1.TabIndex = 0
        '
        'BilgiTextBox1
        '
        Me.BilgiTextBox1.Location = New System.Drawing.Point(50, 158)
        Me.BilgiTextBox1.Multiline = True
        Me.BilgiTextBox1.Name = "BilgiTextBox1"
        Me.BilgiTextBox1.Size = New System.Drawing.Size(579, 435)
        Me.BilgiTextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sürücüler"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SürücüBilgileri"
        '
        'YenilePictureBox1
        '
        Me.YenilePictureBox1.Image = Global.suruculer.My.Resources.Resources._24
        Me.YenilePictureBox1.Location = New System.Drawing.Point(235, 82)
        Me.YenilePictureBox1.Name = "YenilePictureBox1"
        Me.YenilePictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.YenilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.YenilePictureBox1.TabIndex = 1
        Me.YenilePictureBox1.TabStop = False
        '
        'SurucuBılgıleriFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BilgiTextBox1)
        Me.Controls.Add(Me.YenilePictureBox1)
        Me.Controls.Add(Me.SurucuComboBox1)
        Me.Name = "SurucuBılgıleriFormu"
        Me.Text = "Sürücü Bilgileri"
        CType(Me.YenilePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SurucuComboBox1 As ComboBox
    Friend WithEvents YenilePictureBox1 As PictureBox
    Friend WithEvents BilgiTextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
