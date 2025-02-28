<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalcApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextBox = New TextBox()
        Button0 = New Button()
        Button9 = New Button()
        ButtonMultiply = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        ButtonMinus = New Button()
        ButtonPlus = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        ButtonDivide = New Button()
        ButtonPercent = New Button()
        ButtonDel = New Button()
        ButtonClear = New Button()
        ButtonEquals = New Button()
        ButtonDot = New Button()
        LabelOperator = New Label()
        SuspendLayout()
        ' 
        ' TextBox
        ' 
        TextBox.AllowDrop = True
        TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox.BackColor = SystemColors.WindowText
        TextBox.Font = New Font("Segoe UI", 16F)
        TextBox.ForeColor = SystemColors.Window
        TextBox.Location = New Point(-3, 0)
        TextBox.Multiline = True
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(527, 252)
        TextBox.TabIndex = 0
        TextBox.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button0
        ' 
        Button0.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button0.Font = New Font("Segoe UI", 14F)
        Button0.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button0.Location = New Point(1, 587)
        Button0.Name = "Button0"
        Button0.Size = New Size(243, 53)
        Button0.TabIndex = 1
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button9.Font = New Font("Segoe UI", 14F)
        Button9.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button9.Location = New Point(270, 353)
        Button9.Name = "Button9"
        Button9.Size = New Size(112, 44)
        Button9.TabIndex = 2
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' ButtonMultiply
        ' 
        ButtonMultiply.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonMultiply.Font = New Font("Segoe UI", 14F)
        ButtonMultiply.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonMultiply.Location = New Point(415, 353)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(112, 44)
        ButtonMultiply.TabIndex = 3
        ButtonMultiply.Text = "×"
        ButtonMultiply.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Font = New Font("Segoe UI", 14F)
        Button4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button4.Location = New Point(1, 435)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 46)
        Button4.TabIndex = 4
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.Font = New Font("Segoe UI", 14F)
        Button5.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button5.Location = New Point(132, 435)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 46)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button6.Font = New Font("Segoe UI", 14F)
        Button6.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button6.Location = New Point(270, 435)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 46)
        Button6.TabIndex = 6
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' ButtonMinus
        ' 
        ButtonMinus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonMinus.Font = New Font("Segoe UI", 14F)
        ButtonMinus.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonMinus.Location = New Point(415, 435)
        ButtonMinus.Name = "ButtonMinus"
        ButtonMinus.Size = New Size(112, 46)
        ButtonMinus.TabIndex = 7
        ButtonMinus.Text = "-"
        ButtonMinus.UseVisualStyleBackColor = False
        ' 
        ' ButtonPlus
        ' 
        ButtonPlus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonPlus.Font = New Font("Segoe UI", 14F)
        ButtonPlus.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonPlus.Location = New Point(415, 510)
        ButtonPlus.Name = "ButtonPlus"
        ButtonPlus.Size = New Size(112, 48)
        ButtonPlus.TabIndex = 8
        ButtonPlus.Text = "+"
        ButtonPlus.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Font = New Font("Segoe UI", 14F)
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Location = New Point(270, 510)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 48)
        Button3.TabIndex = 9
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("Segoe UI", 14F)
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(132, 510)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 48)
        Button2.TabIndex = 10
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Segoe UI", 14F)
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(1, 510)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 48)
        Button1.TabIndex = 11
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button8.Font = New Font("Segoe UI", 14F)
        Button8.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button8.Location = New Point(132, 353)
        Button8.Name = "Button8"
        Button8.Size = New Size(112, 44)
        Button8.TabIndex = 12
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button7.Font = New Font("Segoe UI", 14F)
        Button7.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button7.Location = New Point(1, 353)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 44)
        Button7.TabIndex = 13
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ButtonDivide
        ' 
        ButtonDivide.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonDivide.Font = New Font("Segoe UI", 14F)
        ButtonDivide.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonDivide.Location = New Point(415, 266)
        ButtonDivide.Name = "ButtonDivide"
        ButtonDivide.Size = New Size(112, 46)
        ButtonDivide.TabIndex = 14
        ButtonDivide.Text = "÷"
        ButtonDivide.UseVisualStyleBackColor = False
        ' 
        ' ButtonPercent
        ' 
        ButtonPercent.BackColor = Color.Silver
        ButtonPercent.Font = New Font("Segoe UI", 14F)
        ButtonPercent.ForeColor = SystemColors.ActiveCaptionText
        ButtonPercent.Location = New Point(270, 266)
        ButtonPercent.Name = "ButtonPercent"
        ButtonPercent.Size = New Size(112, 46)
        ButtonPercent.TabIndex = 15
        ButtonPercent.Text = "%"
        ButtonPercent.UseVisualStyleBackColor = False
        ' 
        ' ButtonDel
        ' 
        ButtonDel.BackColor = Color.Silver
        ButtonDel.Font = New Font("Segoe UI", 14F)
        ButtonDel.ForeColor = SystemColors.ActiveCaptionText
        ButtonDel.Location = New Point(132, 266)
        ButtonDel.Name = "ButtonDel"
        ButtonDel.Size = New Size(112, 46)
        ButtonDel.TabIndex = 16
        ButtonDel.Text = "DEL"
        ButtonDel.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.Silver
        ButtonClear.Font = New Font("Segoe UI", 14F)
        ButtonClear.ForeColor = SystemColors.ActiveCaptionText
        ButtonClear.Location = New Point(1, 266)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(112, 46)
        ButtonClear.TabIndex = 17
        ButtonClear.Text = "C"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonEquals
        ' 
        ButtonEquals.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonEquals.Font = New Font("Segoe UI", 14F)
        ButtonEquals.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonEquals.Location = New Point(415, 587)
        ButtonEquals.Name = "ButtonEquals"
        ButtonEquals.Size = New Size(112, 53)
        ButtonEquals.TabIndex = 18
        ButtonEquals.Text = "="
        ButtonEquals.UseVisualStyleBackColor = False
        ' 
        ' ButtonDot
        ' 
        ButtonDot.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ButtonDot.Font = New Font("Segoe UI", 14F)
        ButtonDot.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ButtonDot.Location = New Point(270, 587)
        ButtonDot.Name = "ButtonDot"
        ButtonDot.Size = New Size(112, 53)
        ButtonDot.TabIndex = 19
        ButtonDot.Text = "."
        ButtonDot.UseVisualStyleBackColor = False
        ' 
        ' LabelOperator
        ' 
        LabelOperator.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        LabelOperator.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelOperator.ForeColor = SystemColors.ButtonHighlight
        LabelOperator.Location = New Point(433, 203)
        LabelOperator.Name = "LabelOperator"
        LabelOperator.Size = New Size(94, 38)
        LabelOperator.TabIndex = 20
        LabelOperator.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CalcApp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(526, 652)
        Controls.Add(LabelOperator)
        Controls.Add(ButtonDot)
        Controls.Add(ButtonEquals)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonDel)
        Controls.Add(ButtonPercent)
        Controls.Add(ButtonDivide)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(ButtonPlus)
        Controls.Add(ButtonMinus)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(ButtonMultiply)
        Controls.Add(Button9)
        Controls.Add(Button0)
        Controls.Add(TextBox)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "CalcApp"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox As TextBox
    Friend WithEvents Button0 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonPlus As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonPercent As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEquals As Button
    Friend WithEvents ButtonDot As Button
    Friend WithEvents LabelOperator As Label

End Class
