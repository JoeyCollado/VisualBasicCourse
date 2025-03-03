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
        lblCountry = New Label()
        txtCountry = New TextBox()
        btnGreet = New Button()
        SuspendLayout()
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(161, 176)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(172, 25)
        lblCountry.TabIndex = 0
        lblCountry.Text = "What country is dis?"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(363, 173)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(269, 31)
        txtCountry.TabIndex = 1
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(442, 252)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(106, 67)
        btnGreet.TabIndex = 2
        btnGreet.Text = "Greeting"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGreet)
        Controls.Add(txtCountry)
        Controls.Add(lblCountry)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnGreet As Button

End Class
