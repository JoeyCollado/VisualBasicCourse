Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.
        Me.Text = "tutorialspont.com"
    End Sub

    Private Sub txtID_MouseEnter(sender As Object, e As EventArgs)
        'code for handling mouse enter on ID textbox
        txtID.BackColor = Color.CornflowerBlue
        txtID.ForeColor = Color.White
    End Sub

    Private Sub txtID_MouseLeave(sender As Object, e As EventArgs)
        'code for handling mouse leave on ID textbox
        txtID.BackColor = Color.White
        txtID.ForeColor = Color.Blue
    End Sub

    Private Sub txtName_MouseEnter(sender As Object, e As EventArgs) _
    Handles txtName.MouseEnter
        'code for handling mouse enter on Name textbox
        txtName.BackColor = Color.CornflowerBlue
        txtName.ForeColor = Color.White

    End Sub

    Private Sub txtName_MouseLeave(sender As Object, e As EventArgs) _
    Handles txtName.MouseLeave
        'code for handling mouse leave on Name textbox
        txtName.BackColor = Color.White
        txtName.ForeColor = Color.Blue
    End Sub

    Private Sub txtAddress_MouseEnter(sender As Object, e As EventArgs)
        'code for handling mouse enter on Address textbox
        txtAddress.BackColor = Color.CornflowerBlue
        txtAddress.ForeColor = Color.White
    End Sub

    Private Sub txtAddress_MouseLeave(sender As Object, e As EventArgs)
        'code for handling mouse leave on Address textbox
        txtAddress.BackColor = Color.White
        txtAddress.ForeColor = Color.Blue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        MsgBox("Thank you " & txtName.Text & ", for your kind cooperation")
    End Sub

End Class
