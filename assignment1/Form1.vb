'-----------------------------------------------------------'
'-              File Name: Form1.frm                        -
'-              Part of Project: Assignment 1               -
'-----------------------------------------------------------'
'-              Written By: Nathan Gaffney                  -
'-              Written On: 21 Jan 2020                     -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main driver for the program       -
'- The user will input pet names, owner names, pet species  -
'- the age of the pet, the units of pet's age,              -
'- the date of the last visit, and whether the pet was      -
'- spayed or neutered. After these have been entered        -
'- the user will save the entry which will then be written  -
'- to a text file. After the initial run of the program,    -
'- the data saved to the text file will be displayed        -
'------------------------------------------------------------
'- Program Purpose:                                         -
'- This program will display saved pet information to       -
'- simulate a veterinarian form. Upon loading the program   -
'- will display saved data to the user                      -
'------------------------------------------------------------
' Global Variable Dictionary (alphabetically)               -
'- (None)                                                   -
'------------------------------------------------------------

Public Class frmMain
    '------------------------------------------------------------
    '-                Subprogram Name: btnPreviousRecord_Click  -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- previous record button. It will display the information  -
    '- of the previous record. If the record is the first in the-
    '- list then a message box will be displayed alerting the   -
    '- user that it can not be displayed                        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnPreviousRecord is the sender of the event    –
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnNewPet_Click          -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- Add New Pet button. This will unlock the form and allow  -
    '- the user to input their pet's information                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnNewPet is the sender of the event            - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnNewPet_Click(sender As Object, e As EventArgs) Handles btnNewPet.Click
        frmEnableModify()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnNextRecord_Click      -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- next record button. THis button will show the information-
    '- of the next record saved if there is one. If there is no -
    '- next record a message box will be displayed to teh user  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnNextRecord is the sender of this event       - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click

    End Sub
    '------------------------------------------------------------
    '-        Subprogram Name: lstAgeUnits_SelectedIndexChanged -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- quit button.  The program will prompt if the user really –
    '- wants to quit, and if the user clicks Yes, the program   -
    '- will terminate.  If the user click No, the program will  -
    '- continue to run.                                         –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub lstAgeUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAgeUnits.SelectedIndexChanged

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnCancel_Click          -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- cancel button. This will clear the form and then lock the-
    '- entry fields.                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnCancel is the sender of the event            - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmClearForm()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnSave_Click            -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- save button. Thiswill write the input data to the text   –
    '- file                                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnSave if the sender of the event              - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: frmClearForm             -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- cancel button. THis sub program will disable the text    -
    '- fields and then change the buttons that are displayed    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None Probably)                                          -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmClearForm()
        txtPetName.Text = ""
        txtOwnerName.Text = ""
        txtSpeciesName.Text = ""
        txtAge.Text = ""
        txtLastVisit.Text = ""
        chkSpayed.Checked = False
        txtPetName.Enabled = False
        txtOwnerName.Enabled = False
        txtSpeciesName.Enabled = False
        txtAge.Enabled = False
        txtLastVisit.Enabled = False
        chkSpayed.Enabled = False
        lstAgeUnits.Enabled = False
        btnPreviousRecord.Show()
        btnNewPet.Show()
        btnNextRecord.Show()
        btnSave.Hide()
        btnCancel.Hide()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: frmEnableModify             -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- Add New Pet button. THis sub program will make the text  –
    '- text fieldseditableand change which buttons are displayed-
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None Probably)                                          -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmEnableModify()
        txtPetName.Text = ""
        txtOwnerName.Text = ""
        txtSpeciesName.Text = ""
        txtAge.Text = ""
        txtLastVisit.Text = ""
        chkSpayed.Checked = False
        txtPetName.Enabled = True
        txtOwnerName.Enabled = True
        txtSpeciesName.Enabled = True
        txtAge.Enabled = True
        txtLastVisit.Enabled = True
        chkSpayed.Enabled = True
        lstAgeUnits.Enabled = True
        btnPreviousRecord.Hide()
        btnNewPet.Hide()
        btnNextRecord.Hide()
        btnSave.Show()
        btnCancel.Show()
    End Sub
End Class
