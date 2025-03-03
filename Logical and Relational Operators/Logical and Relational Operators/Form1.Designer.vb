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
        btnGrade = New Button()
        lblGrade = New Label()
        txtGrade = New TextBox()
        SuspendLayout()
        ' 
        ' btnGrade
        ' 
        btnGrade.Location = New Point(214, 217)
        btnGrade.Name = "btnGrade"
        btnGrade.Size = New Size(127, 83)
        btnGrade.TabIndex = 0
        btnGrade.Text = "Get Grade"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(182, 149)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(202, 25)
        lblGrade.TabIndex = 1
        lblGrade.Text = "Enter Examination Score"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(424, 149)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(62, 31)
        txtGrade.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGrade)
        Controls.Add(lblGrade)
        Controls.Add(btnGrade)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGrade As Button
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtGrade As TextBox

End Class
