<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblPetSpecies = New System.Windows.Forms.Label()
        Me.lblPetAge = New System.Windows.Forms.Label()
        Me.lblDateLastVisit = New System.Windows.Forms.Label()
        Me.lblPetAgeUnits = New System.Windows.Forms.Label()
        Me.chkSpayed = New System.Windows.Forms.CheckBox()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.txtSpeciesName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.txtLastVisit = New System.Windows.Forms.TextBox()
        Me.lstAgeUnits = New System.Windows.Forms.ListBox()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnNewPet = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPetName
        '
        Me.lblPetName.AutoSize = True
        Me.lblPetName.Location = New System.Drawing.Point(35, 48)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(57, 13)
        Me.lblPetName.TabIndex = 0
        Me.lblPetName.Text = "Pet Name:"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(370, 48)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(72, 13)
        Me.lblOwnerName.TabIndex = 0
        Me.lblOwnerName.Text = "Owner Name:"
        '
        'lblPetSpecies
        '
        Me.lblPetSpecies.AutoSize = True
        Me.lblPetSpecies.Location = New System.Drawing.Point(35, 116)
        Me.lblPetSpecies.Name = "lblPetSpecies"
        Me.lblPetSpecies.Size = New System.Drawing.Size(48, 13)
        Me.lblPetSpecies.TabIndex = 0
        Me.lblPetSpecies.Text = "Species:"
        '
        'lblPetAge
        '
        Me.lblPetAge.AutoSize = True
        Me.lblPetAge.Location = New System.Drawing.Point(370, 116)
        Me.lblPetAge.Name = "lblPetAge"
        Me.lblPetAge.Size = New System.Drawing.Size(29, 13)
        Me.lblPetAge.TabIndex = 0
        Me.lblPetAge.Text = "Age:"
        '
        'lblDateLastVisit
        '
        Me.lblDateLastVisit.AutoSize = True
        Me.lblDateLastVisit.Location = New System.Drawing.Point(370, 185)
        Me.lblDateLastVisit.Name = "lblDateLastVisit"
        Me.lblDateLastVisit.Size = New System.Drawing.Size(52, 13)
        Me.lblDateLastVisit.TabIndex = 0
        Me.lblDateLastVisit.Text = "Last Visit:"
        '
        'lblPetAgeUnits
        '
        Me.lblPetAgeUnits.AutoSize = True
        Me.lblPetAgeUnits.Location = New System.Drawing.Point(670, 116)
        Me.lblPetAgeUnits.Name = "lblPetAgeUnits"
        Me.lblPetAgeUnits.Size = New System.Drawing.Size(56, 13)
        Me.lblPetAgeUnits.TabIndex = 0
        Me.lblPetAgeUnits.Text = "Age Units:"
        '
        'chkSpayed
        '
        Me.chkSpayed.AutoSize = True
        Me.chkSpayed.Enabled = False
        Me.chkSpayed.Location = New System.Drawing.Point(38, 188)
        Me.chkSpayed.Name = "chkSpayed"
        Me.chkSpayed.Size = New System.Drawing.Size(117, 17)
        Me.chkSpayed.TabIndex = 1
        Me.chkSpayed.Text = "Spayed/Neutered?"
        Me.chkSpayed.UseVisualStyleBackColor = True
        '
        'txtPetName
        '
        Me.txtPetName.Enabled = False
        Me.txtPetName.Location = New System.Drawing.Point(99, 40)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(208, 20)
        Me.txtPetName.TabIndex = 2
        '
        'txtSpeciesName
        '
        Me.txtSpeciesName.Enabled = False
        Me.txtSpeciesName.Location = New System.Drawing.Point(99, 116)
        Me.txtSpeciesName.Name = "txtSpeciesName"
        Me.txtSpeciesName.Size = New System.Drawing.Size(208, 20)
        Me.txtSpeciesName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(448, 113)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(187, 20)
        Me.txtAge.TabIndex = 2
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Enabled = False
        Me.txtOwnerName.Location = New System.Drawing.Point(448, 40)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(187, 20)
        Me.txtOwnerName.TabIndex = 2
        '
        'txtLastVisit
        '
        Me.txtLastVisit.Enabled = False
        Me.txtLastVisit.Location = New System.Drawing.Point(448, 185)
        Me.txtLastVisit.Name = "txtLastVisit"
        Me.txtLastVisit.Size = New System.Drawing.Size(194, 20)
        Me.txtLastVisit.TabIndex = 2
        '
        'lstAgeUnits
        '
        Me.lstAgeUnits.Enabled = False
        Me.lstAgeUnits.FormattingEnabled = True
        Me.lstAgeUnits.Items.AddRange(New Object() {"Months", "Years"})
        Me.lstAgeUnits.Location = New System.Drawing.Point(732, 113)
        Me.lstAgeUnits.Name = "lstAgeUnits"
        Me.lstAgeUnits.Size = New System.Drawing.Size(56, 30)
        Me.lstAgeUnits.TabIndex = 3
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.Location = New System.Drawing.Point(12, 321)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(117, 40)
        Me.btnPreviousRecord.TabIndex = 4
        Me.btnPreviousRecord.Text = "<<"
        Me.btnPreviousRecord.UseVisualStyleBackColor = True
        '
        'btnNewPet
        '
        Me.btnNewPet.Location = New System.Drawing.Point(135, 321)
        Me.btnNewPet.Name = "btnNewPet"
        Me.btnNewPet.Size = New System.Drawing.Size(530, 40)
        Me.btnNewPet.TabIndex = 4
        Me.btnNewPet.Text = "Add New Pet Record"
        Me.btnNewPet.UseVisualStyleBackColor = True
        '
        'btnNextRecord
        '
        Me.btnNextRecord.Location = New System.Drawing.Point(671, 321)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(117, 40)
        Me.btnNextRecord.TabIndex = 4
        Me.btnNextRecord.Text = ">>"
        Me.btnNextRecord.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 398)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(671, 398)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 40)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnNewPet)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.lstAgeUnits)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtSpeciesName)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.txtLastVisit)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.chkSpayed)
        Me.Controls.Add(Me.lblPetAgeUnits)
        Me.Controls.Add(Me.lblDateLastVisit)
        Me.Controls.Add(Me.lblPetAge)
        Me.Controls.Add(Me.lblPetSpecies)
        Me.Controls.Add(Me.lblOwnerName)
        Me.Controls.Add(Me.lblPetName)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPetName As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents lblPetSpecies As Label
    Friend WithEvents lblPetAge As Label
    Friend WithEvents lblDateLastVisit As Label
    Friend WithEvents lblPetAgeUnits As Label
    Friend WithEvents chkSpayed As CheckBox
    Friend WithEvents txtPetName As TextBox
    Friend WithEvents txtSpeciesName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents txtLastVisit As TextBox
    Friend WithEvents lstAgeUnits As ListBox
    Friend WithEvents btnPreviousRecord As Button
    Friend WithEvents btnNewPet As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
