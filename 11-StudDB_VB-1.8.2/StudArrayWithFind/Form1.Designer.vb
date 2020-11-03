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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnFindStud = New System.Windows.Forms.Button()
        Me.txtTextItem = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTestIndex = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FindStudBySurname = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(12, 83)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(121, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date of Birth 1998-2005 (you can type d/mm/yyyy)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender (""m"" or ""f"")"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(12, 136)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 20)
        Me.txtGender.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average Mk (0-100)"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(121, 136)
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(100, 20)
        Me.txtAvMk.TabIndex = 4
        '
        'btnAddStud
        '
        Me.btnAddStud.Location = New System.Drawing.Point(438, 86)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(144, 23)
        Me.btnAddStud.TabIndex = 11
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'lstStud
        '
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.Location = New System.Drawing.Point(12, 219)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(533, 160)
        Me.lstStud.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of entered students (for testing)"
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(375, 136)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 6
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(227, 136)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone (10 digits)"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(227, 83)
        Me.txtDOB.MaxDate = New Date(2004, 12, 31, 0, 0, 0, 0)
        Me.txtDOB.MinDate = New Date(1998, 1, 1, 0, 0, 0, 0)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(205, 20)
        Me.txtDOB.TabIndex = 2
        Me.txtDOB.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'btnFindStud
        '
        Me.btnFindStud.Location = New System.Drawing.Point(438, 115)
        Me.btnFindStud.Name = "btnFindStud"
        Me.btnFindStud.Size = New System.Drawing.Size(144, 23)
        Me.btnFindStud.TabIndex = 12
        Me.btnFindStud.Text = "Find Student"
        Me.btnFindStud.UseVisualStyleBackColor = True
        '
        'txtTextItem
        '
        Me.txtTextItem.Location = New System.Drawing.Point(12, 180)
        Me.txtTextItem.Name = "txtTextItem"
        Me.txtTextItem.Size = New System.Drawing.Size(342, 20)
        Me.txtTextItem.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Test field for selected element in list box"
        '
        'txtTestIndex
        '
        Me.txtTestIndex.Location = New System.Drawing.Point(360, 180)
        Me.txtTestIndex.Name = "txtTestIndex"
        Me.txtTestIndex.Size = New System.Drawing.Size(65, 20)
        Me.txtTestIndex.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(358, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Element Index"
        '
        'FindStudBySurname
        '
        Me.FindStudBySurname.Location = New System.Drawing.Point(438, 144)
        Me.FindStudBySurname.Name = "FindStudBySurname"
        Me.FindStudBySurname.Size = New System.Drawing.Size(144, 23)
        Me.FindStudBySurname.TabIndex = 22
        Me.FindStudBySurname.Text = "Find Student by Surname"
        Me.FindStudBySurname.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 391)
        Me.Controls.Add(Me.FindStudBySurname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTestIndex)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTextItem)
        Me.Controls.Add(Me.btnFindStud)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "v1.8.3 Student entry form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvMk As TextBox
    Friend WithEvents btnAddStud As Button


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents btnFindStud As Button
    Friend WithEvents txtTextItem As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTestIndex As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents FindStudBySurname As Button
End Class
