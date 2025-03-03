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
        btn1 = New Button()
        TextBoxFirstName = New TextBox()
        lblFirstName = New Label()
        TextBoxLastName = New TextBox()
        lblLastName = New Label()
        TextBoxGender = New TextBox()
        lblGender = New Label()
        OccupationListBox = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(302, 219)
        btn1.Name = "btn1"
        btn1.Size = New Size(162, 114)
        btn1.TabIndex = 0
        btn1.Text = "Go"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' TextBoxFirstName
        ' 
        TextBoxFirstName.Location = New Point(251, 40)
        TextBoxFirstName.Name = "TextBoxFirstName"
        TextBoxFirstName.Size = New Size(213, 31)
        TextBoxFirstName.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(113, 46)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.Location = New Point(251, 85)
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(213, 31)
        TextBoxLastName.TabIndex = 3
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(113, 88)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 25)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        ' 
        ' TextBoxGender
        ' 
        TextBoxGender.Location = New Point(251, 138)
        TextBoxGender.Name = "TextBoxGender"
        TextBoxGender.Size = New Size(213, 31)
        TextBoxGender.TabIndex = 5
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(113, 138)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(69, 25)
        lblGender.TabIndex = 6
        lblGender.Text = "Gender"
        ' 
        ' OccupationListBox
        ' 
        OccupationListBox.FormattingEnabled = True
        OccupationListBox.ItemHeight = 25
        OccupationListBox.Items.AddRange(New Object() {"Doctor", "God", "Programmer", "Student", "Teacher", "Degen", "Unemployed"})
        OccupationListBox.Location = New Point(611, 56)
        OccupationListBox.Name = "OccupationListBox"
        OccupationListBox.Size = New Size(156, 179)
        OccupationListBox.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(637, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 8
        Label1.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(OccupationListBox)
        Controls.Add(lblGender)
        Controls.Add(TextBoxGender)
        Controls.Add(lblLastName)
        Controls.Add(TextBoxLastName)
        Controls.Add(lblFirstName)
        Controls.Add(TextBoxFirstName)
        Controls.Add(btn1)
        Name = "Form1"
        Text = "Occupation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents TextBoxGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents OccupationListBox As ListBox
    Friend WithEvents Label1 As Label

End Class
