<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form8))
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(200), CByte(0), CByte(0), CByte(0))
        Label1.Font = New Font("Sitka Small", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(347, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 34)
        Label1.TabIndex = 0
        Label1.Text = "Aap Har chuke ho..!!!1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(200), CByte(0), CByte(0), CByte(0))
        Label2.Font = New Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(384, 250)
        Label2.Name = "Label2"
        Label2.Size = New Size(369, 26)
        Label2.TabIndex = 1
        Label2.Text = "Apki kul Keemat Apko bhej di jayegi "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(200), CByte(0), CByte(0), CByte(0))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sitka Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(460, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 35)
        Button1.TabIndex = 2
        Button1.Text = "Phir se Khele"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(200), CByte(0), CByte(0), CByte(0))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sitka Small", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(506, 341)
        Button2.Name = "Button2"
        Button2.Size = New Size(255, 35)
        Button2.TabIndex = 3
        Button2.Text = "Nhi Khelna hummein...!"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
