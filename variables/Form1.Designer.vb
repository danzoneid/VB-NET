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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rInput = New System.Windows.Forms.TextBox()
        Me.calc = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.result)
        Me.Panel1.Controls.Add(Me.calc)
        Me.Panel1.Controls.Add(Me.rInput)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 179)
        Me.Panel1.TabIndex = 0
        '
        'rInput
        '
        Me.rInput.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rInput.Location = New System.Drawing.Point(16, 18)
        Me.rInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rInput.Name = "rInput"
        Me.rInput.Size = New System.Drawing.Size(116, 30)
        Me.rInput.TabIndex = 0
        '
        'calc
        '
        Me.calc.Location = New System.Drawing.Point(150, 18)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(85, 30)
        Me.calc.TabIndex = 1
        Me.calc.Text = "CALCULATE"
        Me.calc.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.result.Location = New System.Drawing.Point(16, 77)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(219, 93)
        Me.result.TabIndex = 2
        Me.result.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Circle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rInput As TextBox
    Friend WithEvents result As Label
    Friend WithEvents calc As Button
End Class
