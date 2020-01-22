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
    Dim lstPetList As New List(Of udtPetInformation)
    'This variable is the index of the currently selected pet
    Dim intPetIndex As Integer
    '------------------------------------------------------------
    '-                Subprogram Name: frmForm1_Load            -
    '------------------------------------------------------------
    '-                Written By: Nathan Gaffney                -
    '-                Written On: 21 Jan 2020                   -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the form loads        -
    '- it will check to see if the text file exists and if not  -
    '- it will create the file                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – btnPreviousRecord is the sender of the event    –
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- objMyStreamWriter - Makes the file if not exist          -
    '------------------------------------------------------------
    Private Sub frmForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.FileExists("pets.txt") Then
            Dim objMyStreamWriter As System.IO.StreamWriter =
                                         System.IO.File.CreateText("pets.txt")
            objMyStreamWriter.Close()
        Else

            readInformation()
            displayInformation(lstPetList(0))
        End If
    End Sub

    Private Sub displayInformation(theSelectedPet As udtPetInformation)
        txtPetName.Text = theSelectedPet.getStrPetName()
        txtOwnerName.Text = theSelectedPet.getStrOwnerName()
        txtSpeciesName.Text = theSelectedPet.getStrPetSpecies()
        txtAge.Text = theSelectedPet.getStrPetAge()
        lstAgeUnits.SelectedIndex = theSelectedPet.getIntAgeUnits()
        chkSpayed.Checked = theSelectedPet.getBlnBirthControl()
        txtLastVisit.Text = theSelectedPet.getStrLastVisit()
    End Sub

    Private Sub readInformation()
        Dim objMyStreamReader As System.IO.StreamReader
        Dim strLineContents As String
        Dim intAgeUnitEquivalent As Integer
        Dim blnBirthControlEquivalent As Boolean
        objMyStreamReader = System.IO.File.OpenText("pets.txt")
        While Not (objMyStreamReader.EndOfStream)
            strLineContents = objMyStreamReader.ReadLine()
            Dim strContents() As String = Split(strLineContents, [vbTab])
            lstPetList.Add(New udtPetInformation(strContents(0), strContents(1), strContents(2), strContents(3),
                                                 intAgeUnitEquivalent, blnBirthControlEquivalent, strContents(6)))
        End While
        objMyStreamReader.Close()
    End Sub
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
        If intPetIndex - 1 < 0 Then
            MessageBox.Show("Can't move past first record.")
        Else
            intPetIndex -= 1
            displayInformation(lstPetList(intPetIndex))
        End If
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
        If intPetIndex + 1 >= lstPetList.Count Then
            MessageBox.Show("Can't move past last record.")
        Else
            intPetIndex += 1
            displayInformation(lstPetList(intPetIndex))
        End If
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
        Dim strPetName = txtPetName.Text
        Dim strOwnerName = txtOwnerName.Text
        Dim strSpecies = txtSpeciesName.Text
        Dim strPetAge = txtAge.Text
        Dim intAgeUnits = lstAgeUnits.SelectedIndex
        Dim blnBirthControl = chkSpayed.Checked
        Dim strLastVisit = txtLastVisit.Text
        intPetIndex += 1
        lstPetList.Add(New udtPetInformation(strPetName, strOwnerName, strSpecies,
                                             strPetAge, intAgeUnits, blnBirthControl, strLastVisit))
        frmClearForm()
        writeInformation(lstPetList(intPetIndex))
        displayInformation(lstPetList(lstPetList.Count - 1))
    End Sub

    Private Sub writeInformation(theSelectedPet As udtPetInformation)
        Dim objStremWriter As New System.IO.StreamWriter("pets.txt", True)
        objStremWriter.WriteLine(theSelectedPet.ToString)
        objStremWriter.Close()
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
Public Class udtPetInformation
    Private Property strPetName As String
    Private Property strOwnerName As String
    Private Property strPetSpecies As String
    Private Property strPetAge As String
    Private Property intAgeUnits As Integer
    Private Property blnBirthControl As Boolean
    Private Property strLastVisit As String
    Public Function getStrPetName()
        Return strPetName
    End Function
    Public Function getStrOwnerName()
        Return strOwnerName
    End Function
    Public Function getStrPetSpecies()
        Return strPetSpecies
    End Function
    Public Function getStrPetAge()
        Return strPetAge
    End Function
    Public Function getIntAgeUnits()
        Return intAgeUnits
    End Function
    Public Function getBlnBirthControl()
        Return blnBirthControl
    End Function
    Public Function getStrLastVisit()
        Return strLastVisit
    End Function
    Public Sub New(strPetName As String, strOwnerName As String, strPetSpecies As String, strPetAge As String, intAgeUnits As Integer, blnBirthControl As Boolean, strLastVisit As String)
        Me.strPetName = strPetName
        Me.strOwnerName = strOwnerName
        Me.strPetSpecies = strPetSpecies
        Me.strPetAge = strPetAge
        Me.intAgeUnits = intAgeUnits
        Me.blnBirthControl = blnBirthControl
        Me.strLastVisit = strLastVisit
    End Sub

    Public Overrides Function ToString() As String
        Dim strIntAgeUnits As String
        Dim strBirthControl As String
        If intAgeUnits >= 0 Then
            strIntAgeUnits = "years"
        Else
            strIntAgeUnits = "months"
        End If
        If blnBirthControl Then
            strBirthControl = "True"
        Else
            strBirthControl = "False"
        End If

        Return strPetName & vbTab & strOwnerName & vbTab &
           strPetSpecies & vbTab & strPetAge & vbTab &
           strIntAgeUnits & vbTab & strBirthControl & vbTab &
           strLastVisit
    End Function
End Class