<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.testLabel = New System.Windows.Forms.Label()
        Me.testLabel2 = New System.Windows.Forms.Label()
        Me.testBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 871)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'testLabel
        '
        Me.testLabel.AutoSize = True
        Me.testLabel.Location = New System.Drawing.Point(465, 879)
        Me.testLabel.Name = "testLabel"
        Me.testLabel.Size = New System.Drawing.Size(41, 15)
        Me.testLabel.TabIndex = 1
        Me.testLabel.Text = "Label1"
        '
        'testLabel2
        '
        Me.testLabel2.AutoSize = True
        Me.testLabel2.Location = New System.Drawing.Point(571, 879)
        Me.testLabel2.Name = "testLabel2"
        Me.testLabel2.Size = New System.Drawing.Size(41, 15)
        Me.testLabel2.TabIndex = 2
        Me.testLabel2.Text = "Label1"
        '
        'testBox1
        '
        Me.testBox1.Location = New System.Drawing.Point(268, 871)
        Me.testBox1.Name = "testBox1"
        Me.testBox1.Size = New System.Drawing.Size(147, 23)
        Me.testBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(718, 871)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 71)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1044, 1061)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.testBox1)
        Me.Controls.Add(Me.testLabel2)
        Me.Controls.Add(Me.testLabel)
        Me.Controls.Add(Me.Button1)
        Me.Name = "mainForm"
        Me.Text = "Backetology"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents testLabel As Label
    Friend WithEvents testLabel2 As Label
    Friend WithEvents testBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
