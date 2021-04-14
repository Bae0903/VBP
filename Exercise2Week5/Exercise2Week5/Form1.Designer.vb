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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelOutput = New System.Windows.Forms.Label()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelCurrency = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelOutput
        '
        Me.LabelOutput.AccessibleName = "LabelOutput"
        Me.LabelOutput.AutoSize = True
        Me.LabelOutput.Location = New System.Drawing.Point(337, 237)
        Me.LabelOutput.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LabelOutput.Name = "LabelOutput"
        Me.LabelOutput.Size = New System.Drawing.Size(100, 13)
        Me.LabelOutput.TabIndex = 1
        '
        'txtbox
        '
        Me.txtbox.AccessibleName = "txtbox"
        Me.txtbox.Location = New System.Drawing.Point(340, 159)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(100, 20)
        Me.txtbox.TabIndex = 2
        '
        'LabelDate
        '
        Me.LabelDate.AccessibleName = "LabelDate"
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Location = New System.Drawing.Point(337, 261)
        Me.LabelDate.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(100, 13)
        Me.LabelDate.TabIndex = 3
        '
        'LabelCurrency
        '
        Me.LabelCurrency.AccessibleName = "LabelCurrency"
        Me.LabelCurrency.AutoSize = True
        Me.LabelCurrency.Location = New System.Drawing.Point(337, 291)
        Me.LabelCurrency.MinimumSize = New System.Drawing.Size(100, 0)
        Me.LabelCurrency.Name = "LabelCurrency"
        Me.LabelCurrency.Size = New System.Drawing.Size(100, 13)
        Me.LabelCurrency.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 94)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Confirm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(303, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Confirm2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(105, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtbox3
        '
        Me.txtbox3.AccessibleName = "txtbox3"
        Me.txtbox3.Location = New System.Drawing.Point(93, 159)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(100, 20)
        Me.txtbox3.TabIndex = 9
        '
        'txtbox2
        '
        Me.txtbox2.AccessibleName = "txtbox2"
        Me.txtbox2.Location = New System.Drawing.Point(93, 133)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 20)
        Me.txtbox2.TabIndex = 10
        '
        'Form1
        '
        Me.AccessibleName = "Form1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCurrency)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.LabelOutput)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelOutput As Label
    Friend WithEvents txtbox As TextBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelCurrency As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents txtbox2 As TextBox
End Class
