﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnGo = New Button()
        variables = New Button()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(304, 117)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(192, 148)
        btnGo.TabIndex = 0
        btnGo.Text = "GO"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' variables
        ' 
        variables.Location = New Point(63, 117)
        variables.Name = "variables"
        variables.Size = New Size(192, 148)
        variables.TabIndex = 1
        variables.Text = "btnVariables"
        variables.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(variables)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents variables As Button

End Class
