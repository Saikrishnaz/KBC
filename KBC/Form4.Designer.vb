﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(443, 407)
        Button3.Name = "Button3"
        Button3.Size = New Size(315, 36)
        Button3.TabIndex = 14
        Button3.Text = "D) Primary Storage Device"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(30, 407)
        Button4.Name = "Button4"
        Button4.Size = New Size(342, 35)
        Button4.TabIndex = 13
        Button4.Text = "C) Program Handling System"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(427, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(287, 37)
        Button2.TabIndex = 12
        Button2.Text = "B) Processing Device"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(12, 366)
        Button1.Name = "Button1"
        Button1.Size = New Size(383, 37)
        Button1.TabIndex = 11
        Button1.Text = "A)Electronic  Switching Device"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(108, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(587, 29)
        Label1.TabIndex = 10
        Label1.Text = "Q3) A computer Is a  Box Full of Electronic .............. ?"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.ControlDark
        ProgressBar1.ForeColor = Color.Yellow
        ProgressBar1.Location = New Point(159, 12)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(475, 16)
        ProgressBar1.TabIndex = 15
        ProgressBar1.Value = 60
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
