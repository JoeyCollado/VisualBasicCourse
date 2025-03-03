Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'inputbox prompts the user to enter an input 

        'Dim stFirst_name As String

        'stFirst_name = InputBox("please enter your first name")

        'MsgBox("hello " & stFirst_name)

        ''you can add item on the list box by going to the items property

        ''
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = TextBoxFirstName.Text 'basically here were assigning the textbox named "lblFirstName" to the variable stFirstName and the .text means it will accept text properties
        stLastName = TextBoxLastName.Text
        stGender = TextBoxGender.Text

        stOccupation = OccupationListBox.SelectedItem

        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''this shows when you double click the form itself not the buttons or any elements
        ''any code that is written here will run immediately after the application is stopped but
        '' before the form appears on the screen

        OccupationListBox.Items.Add("Dinasour") 'here we are adding items to the list box programatically means in code


    End Sub
End Class
