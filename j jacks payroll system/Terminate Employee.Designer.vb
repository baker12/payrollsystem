﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminateEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCurrentlyEmployed = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTerminated = New System.Windows.Forms.ListBox()
        Me.btnAddTerm = New System.Windows.Forms.Button()
        Me.btnRemoveTerm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(356, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Terminate Employee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCurrentlyEmployed
        '
        Me.lbCurrentlyEmployed.FormattingEnabled = True
        Me.lbCurrentlyEmployed.Location = New System.Drawing.Point(39, 100)
        Me.lbCurrentlyEmployed.Name = "lbCurrentlyEmployed"
        Me.lbCurrentlyEmployed.Size = New System.Drawing.Size(232, 173)
        Me.lbCurrentlyEmployed.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Currently Employed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "To be Terminated:"
        '
        'lbTerminated
        '
        Me.lbTerminated.FormattingEnabled = True
        Me.lbTerminated.Location = New System.Drawing.Point(462, 100)
        Me.lbTerminated.Name = "lbTerminated"
        Me.lbTerminated.Size = New System.Drawing.Size(232, 173)
        Me.lbTerminated.TabIndex = 14
        '
        'btnAddTerm
        '
        Me.btnAddTerm.Location = New System.Drawing.Point(317, 125)
        Me.btnAddTerm.Name = "btnAddTerm"
        Me.btnAddTerm.Size = New System.Drawing.Size(114, 23)
        Me.btnAddTerm.TabIndex = 15
        Me.btnAddTerm.Text = "Add ->"
        Me.btnAddTerm.UseVisualStyleBackColor = True
        '
        'btnRemoveTerm
        '
        Me.btnRemoveTerm.Location = New System.Drawing.Point(317, 157)
        Me.btnRemoveTerm.Name = "btnRemoveTerm"
        Me.btnRemoveTerm.Size = New System.Drawing.Size(114, 23)
        Me.btnRemoveTerm.TabIndex = 16
        Me.btnRemoveTerm.Text = "<-Remove"
        Me.btnRemoveTerm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(167, 299)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(488, 299)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(104, 26)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'TerminateEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 337)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnRemoveTerm)
        Me.Controls.Add(Me.btnAddTerm)
        Me.Controls.Add(Me.lbTerminated)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbCurrentlyEmployed)
        Me.Controls.Add(Me.Label4)
        Me.Name = "TerminateEmployee"
        Me.Text = "TerminateEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbCurrentlyEmployed As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbTerminated As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTerm As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTerm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
