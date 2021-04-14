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
        Me.lblTeks = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTeks
        '
        Me.lblTeks.AccessibleName = "lblTeks"
        Me.lblTeks.AutoSize = True
        Me.lblTeks.Location = New System.Drawing.Point(337, 142)
        Me.lblTeks.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblTeks.Name = "lblTeks"
        Me.lblTeks.Size = New System.Drawing.Size(100, 13)
        Me.lblTeks.TabIndex = 0
        Me.lblTeks.Text = "label 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTeks)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeks As Label
End Class
