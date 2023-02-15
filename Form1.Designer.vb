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
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFNums = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.SystemColors.Menu
        Me.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuestion.Location = New System.Drawing.Point(259, 67)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(286, 71)
        Me.txtQuestion.TabIndex = 0
        Me.txtQuestion.Text = "Do you know the French words for the numbers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 through 5?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the buttons bel" &
    "ow to see them." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(184, 162)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(45, 25)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(560, 162)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(45, 25)
        Me.btn5.TabIndex = 2
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(466, 162)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(45, 25)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(372, 162)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(45, 25)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(278, 162)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(45, 25)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(354, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFNums
        '
        Me.txtFNums.BackColor = System.Drawing.SystemColors.Menu
        Me.txtFNums.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFNums.Location = New System.Drawing.Point(321, 214)
        Me.txtFNums.Name = "txtFNums"
        Me.txtFNums.Size = New System.Drawing.Size(145, 16)
        Me.txtFNums.TabIndex = 7
        Me.txtFNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFNums)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtQuestion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFNums As TextBox
End Class
