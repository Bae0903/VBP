<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.JumlahPelajar = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.JumlahPelajar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(342, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Check"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'JumlahPelajar
        '
        Me.JumlahPelajar.AccessibleName = "JumlahPelajar"
        Me.JumlahPelajar.Location = New System.Drawing.Point(321, 153)
        Me.JumlahPelajar.Name = "JumlahPelajar"
        Me.JumlahPelajar.Size = New System.Drawing.Size(120, 20)
        Me.JumlahPelajar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 216)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JumlahPelajar)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.JumlahPelajar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents JumlahPelajar As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
