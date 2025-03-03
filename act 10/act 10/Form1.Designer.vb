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
        txtName = New TextBox()
        Button1 = New Button()
        txtID = New TextBox()
        txtAddress = New TextBox()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(294, 231)
        txtName.Name = "txtName"
        txtName.Size = New Size(202, 31)
        txtName.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(308, 132)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 70)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(586, 407)
        txtID.Name = "txtID"
        txtID.Size = New Size(202, 31)
        txtID.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(12, 407)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(202, 31)
        txtAddress.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAddress)
        Controls.Add(txtID)
        Controls.Add(Button1)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAddress As TextBox

End Class
