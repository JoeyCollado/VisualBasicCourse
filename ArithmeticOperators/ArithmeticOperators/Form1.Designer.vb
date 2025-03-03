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
        txtBoxNumber1 = New TextBox()
        txtBoxNumber2 = New TextBox()
        lblNumber1 = New Label()
        lblNumber2 = New Label()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' txtBoxNumber1
        ' 
        txtBoxNumber1.Location = New Point(352, 98)
        txtBoxNumber1.Name = "txtBoxNumber1"
        txtBoxNumber1.Size = New Size(233, 31)
        txtBoxNumber1.TabIndex = 0
        ' 
        ' txtBoxNumber2
        ' 
        txtBoxNumber2.Location = New Point(354, 181)
        txtBoxNumber2.Name = "txtBoxNumber2"
        txtBoxNumber2.Size = New Size(233, 31)
        txtBoxNumber2.TabIndex = 1
        ' 
        ' lblNumber1
        ' 
        lblNumber1.AutoSize = True
        lblNumber1.Location = New Point(215, 101)
        lblNumber1.Name = "lblNumber1"
        lblNumber1.Size = New Size(97, 25)
        lblNumber1.TabIndex = 2
        lblNumber1.Text = "Number 1 "
        ' 
        ' lblNumber2
        ' 
        lblNumber2.AutoSize = True
        lblNumber2.Location = New Point(214, 182)
        lblNumber2.Name = "lblNumber2"
        lblNumber2.Size = New Size(92, 25)
        lblNumber2.TabIndex = 3
        lblNumber2.Text = "Number 2"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(371, 259)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(199, 77)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(lblNumber2)
        Controls.Add(lblNumber1)
        Controls.Add(txtBoxNumber2)
        Controls.Add(txtBoxNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBoxNumber1 As TextBox
    Friend WithEvents txtBoxNumber2 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnCalculate As Button

End Class
