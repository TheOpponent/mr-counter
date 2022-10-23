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
        Me.Score1Plus1Button = New System.Windows.Forms.Button()
        Me.Score1Minus1Button = New System.Windows.Forms.Button()
        Me.Score1Label = New System.Windows.Forms.Label()
        Me.Score1TextBox = New System.Windows.Forms.TextBox()
        Me.Score1SetButton = New System.Windows.Forms.Button()
        Me.Score2PlusButton = New System.Windows.Forms.Button()
        Me.Score2Minus1Button = New System.Windows.Forms.Button()
        Me.Score2Label = New System.Windows.Forms.Label()
        Me.Score2TextBox = New System.Windows.Forms.TextBox()
        Me.Score2SetButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Score1Plus1Button
        '
        Me.Score1Plus1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score1Plus1Button.Location = New System.Drawing.Point(221, 19)
        Me.Score1Plus1Button.Name = "Score1Plus1Button"
        Me.Score1Plus1Button.Size = New System.Drawing.Size(44, 64)
        Me.Score1Plus1Button.TabIndex = 1
        Me.Score1Plus1Button.Text = "+"
        Me.Score1Plus1Button.UseVisualStyleBackColor = True
        '
        'Score1Minus1Button
        '
        Me.Score1Minus1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score1Minus1Button.Location = New System.Drawing.Point(6, 19)
        Me.Score1Minus1Button.Name = "Score1Minus1Button"
        Me.Score1Minus1Button.Size = New System.Drawing.Size(47, 64)
        Me.Score1Minus1Button.TabIndex = 0
        Me.Score1Minus1Button.Text = "-"
        Me.Score1Minus1Button.UseVisualStyleBackColor = True
        '
        'Score1Label
        '
        Me.Score1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score1Label.Location = New System.Drawing.Point(59, 19)
        Me.Score1Label.Name = "Label1"
        Me.Score1Label.Size = New System.Drawing.Size(156, 64)
        Me.Score1Label.TabIndex = 2
        Me.Score1Label.Text = Score1
        Me.Score1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Score1TextBox
        '
        Me.Score1TextBox.Location = New System.Drawing.Point(58, 86)
        Me.Score1TextBox.Name = "Score1TextBox"
        Me.Score1TextBox.Size = New System.Drawing.Size(74, 20)
        Me.Score1TextBox.TabIndex = 3
        '
        'Score1SetButton
        '
        Me.Score1SetButton.Location = New System.Drawing.Point(138, 84)
        Me.Score1SetButton.Name = "Button3"
        Me.Score1SetButton.Size = New System.Drawing.Size(75, 23)
        Me.Score1SetButton.TabIndex = 4
        Me.Score1SetButton.Text = "Set"
        Me.Score1SetButton.UseVisualStyleBackColor = True
        '
        'Score2PlusButton
        '
        Me.Score2PlusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score2PlusButton.Location = New System.Drawing.Point(221, 19)
        Me.Score2PlusButton.Name = "Score2PlusButton"
        Me.Score2PlusButton.Size = New System.Drawing.Size(44, 64)
        Me.Score2PlusButton.TabIndex = 8
        Me.Score2PlusButton.Text = "+"
        Me.Score2PlusButton.UseVisualStyleBackColor = True
        '
        'Score2Minus1Button
        '
        Me.Score2Minus1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score2Minus1Button.Location = New System.Drawing.Point(6, 19)
        Me.Score2Minus1Button.Name = "Score2Minus1Button"
        Me.Score2Minus1Button.Size = New System.Drawing.Size(47, 64)
        Me.Score2Minus1Button.TabIndex = 7
        Me.Score2Minus1Button.Text = "-"
        Me.Score2Minus1Button.UseVisualStyleBackColor = True
        '
        'Score2Label
        '
        Me.Score2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score2Label.Location = New System.Drawing.Point(59, 19)
        Me.Score2Label.Name = "Score2Label"
        Me.Score2Label.Size = New System.Drawing.Size(156, 64)
        Me.Score2Label.TabIndex = 2
        Me.Score2Label.Text = Score2
        Me.Score2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Score2TextBox
        '
        Me.Score2TextBox.Location = New System.Drawing.Point(58, 86)
        Me.Score2TextBox.Name = "Score2TextBox"
        Me.Score2TextBox.Size = New System.Drawing.Size(74, 20)
        Me.Score2TextBox.TabIndex = 9
        '
        'Score2SetButton
        '
        Me.Score2SetButton.Location = New System.Drawing.Point(138, 84)
        Me.Score2SetButton.Name = "Score2SetButton"
        Me.Score2SetButton.Size = New System.Drawing.Size(75, 23)
        Me.Score2SetButton.TabIndex = 10
        Me.Score2SetButton.Text = "Set"
        Me.Score2SetButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpButton.Location = New System.Drawing.Point(70, 138)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(74, 34)
        Me.UpButton.TabIndex = 5
        Me.UpButton.Text = "↑"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownButton.Location = New System.Drawing.Point(153, 138)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(74, 34)
        Me.DownButton.TabIndex = 6
        Me.DownButton.Text = "↓"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Score1Minus1Button)
        Me.GroupBox1.Controls.Add(Me.Score1Label)
        Me.GroupBox1.Controls.Add(Me.Score1SetButton)
        Me.GroupBox1.Controls.Add(Me.Score1Plus1Button)
        Me.GroupBox1.Controls.Add(Me.Score1TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Score 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Score2Minus1Button)
        Me.GroupBox2.Controls.Add(Me.Score2Label)
        Me.GroupBox2.Controls.Add(Me.Score2SetButton)
        Me.GroupBox2.Controls.Add(Me.Score2PlusButton)
        Me.GroupBox2.Controls.Add(Me.Score2TextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 120)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Score 2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 305)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Mr. Counter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Score1Minus1Button As Button
    Friend WithEvents Score1Label As Label
    Friend WithEvents Score1TextBox As TextBox
    Friend WithEvents Score1SetButton As Button
    Friend WithEvents Score1Plus1Button As Button
    Friend WithEvents Score2PlusButton As Button
    Friend WithEvents Score2Minus1Button As Button
    Friend WithEvents Score2Label As Label
    Friend WithEvents Score2TextBox As TextBox
    Friend WithEvents Score2SetButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
