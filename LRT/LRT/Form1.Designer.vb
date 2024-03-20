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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.desti1CB = New System.Windows.Forms.ComboBox()
        Me.destiLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.desti2CB = New System.Windows.Forms.ComboBox()
        Me.dicLbl = New System.Windows.Forms.Label()
        Me.discCB = New System.Windows.Forms.ComboBox()
        Me.extBtn = New System.Windows.Forms.Button()
        Me.procBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grosslbl = New System.Windows.Forms.Label()
        Me.disclbl = New System.Windows.Forms.Label()
        Me.netlbl = New System.Windows.Forms.Label()
        Me.fromlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Light Rail Transit"
        '
        'desti1CB
        '
        Me.desti1CB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.desti1CB.BackColor = System.Drawing.SystemColors.Window
        Me.desti1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.desti1CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.desti1CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.desti1CB.FormattingEnabled = True
        Me.desti1CB.Items.AddRange(New Object() {"Dagupan City", "Urdaneta City", "Rosales", "Paniqui", "Moncada", "Tarlac City", "Concepcion", "Capas", "Bamban", "Mabalacat City", "Angeles"})
        Me.desti1CB.Location = New System.Drawing.Point(103, 132)
        Me.desti1CB.Name = "desti1CB"
        Me.desti1CB.Size = New System.Drawing.Size(141, 26)
        Me.desti1CB.TabIndex = 5
        '
        'destiLbl
        '
        Me.destiLbl.AutoSize = True
        Me.destiLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destiLbl.Location = New System.Drawing.Point(143, 105)
        Me.destiLbl.Name = "destiLbl"
        Me.destiLbl.Size = New System.Drawing.Size(60, 24)
        Me.destiLbl.TabIndex = 7
        Me.destiLbl.Text = "From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(159, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "To"
        '
        'desti2CB
        '
        Me.desti2CB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.desti2CB.BackColor = System.Drawing.SystemColors.Window
        Me.desti2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.desti2CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.desti2CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.desti2CB.FormattingEnabled = True
        Me.desti2CB.Items.AddRange(New Object() {"Dagupan City", "Urdaneta City", "Rosales", "Paniqui", "Moncada", "Tarlac City", "Concepcion", "Capas", "Bamban", "Mabalacat City", "Angeles"})
        Me.desti2CB.Location = New System.Drawing.Point(103, 213)
        Me.desti2CB.Name = "desti2CB"
        Me.desti2CB.Size = New System.Drawing.Size(141, 26)
        Me.desti2CB.TabIndex = 9
        '
        'dicLbl
        '
        Me.dicLbl.AutoSize = True
        Me.dicLbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dicLbl.Location = New System.Drawing.Point(388, 105)
        Me.dicLbl.Name = "dicLbl"
        Me.dicLbl.Size = New System.Drawing.Size(88, 24)
        Me.dicLbl.TabIndex = 10
        Me.dicLbl.Text = "Discount"
        '
        'discCB
        '
        Me.discCB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.discCB.BackColor = System.Drawing.SystemColors.Window
        Me.discCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.discCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.discCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.discCB.FormattingEnabled = True
        Me.discCB.Items.AddRange(New Object() {"No Discount", "Government Employee", "Student", "Senior Citizen", "Children"})
        Me.discCB.Location = New System.Drawing.Point(362, 132)
        Me.discCB.Name = "discCB"
        Me.discCB.Size = New System.Drawing.Size(141, 26)
        Me.discCB.TabIndex = 11
        '
        'extBtn
        '
        Me.extBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.extBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extBtn.Location = New System.Drawing.Point(215, 170)
        Me.extBtn.Name = "extBtn"
        Me.extBtn.Size = New System.Drawing.Size(94, 35)
        Me.extBtn.TabIndex = 12
        Me.extBtn.Text = "Close"
        Me.extBtn.UseVisualStyleBackColor = True
        '
        'procBtn
        '
        Me.procBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.procBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.procBtn.Location = New System.Drawing.Point(362, 204)
        Me.procBtn.Name = "procBtn"
        Me.procBtn.Size = New System.Drawing.Size(131, 35)
        Me.procBtn.TabIndex = 13
        Me.procBtn.Text = "Process"
        Me.procBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.LRT.My.Resources.Resources.images_removebg_preview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 41)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.grosslbl)
        Me.Panel1.Controls.Add(Me.disclbl)
        Me.Panel1.Controls.Add(Me.netlbl)
        Me.Panel1.Controls.Add(Me.fromlbl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.extBtn)
        Me.Panel1.Location = New System.Drawing.Point(52, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 222)
        Me.Panel1.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(362, 137)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 25)
        Me.TextBox6.TabIndex = 23
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(69, 137)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(134, 25)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(362, 63)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 25)
        Me.TextBox4.TabIndex = 21
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(362, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 25)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(169, -53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(69, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(134, 25)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "To:"
        '
        'grosslbl
        '
        Me.grosslbl.AutoSize = True
        Me.grosslbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grosslbl.Location = New System.Drawing.Point(267, 62)
        Me.grosslbl.Name = "grosslbl"
        Me.grosslbl.Size = New System.Drawing.Size(89, 19)
        Me.grosslbl.TabIndex = 16
        Me.grosslbl.Text = "Gross Fare:"
        '
        'disclbl
        '
        Me.disclbl.AutoSize = True
        Me.disclbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disclbl.Location = New System.Drawing.Point(267, 96)
        Me.disclbl.Name = "disclbl"
        Me.disclbl.Size = New System.Drawing.Size(73, 19)
        Me.disclbl.TabIndex = 15
        Me.disclbl.Text = "Discount:"
        '
        'netlbl
        '
        Me.netlbl.AutoSize = True
        Me.netlbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netlbl.Location = New System.Drawing.Point(266, 134)
        Me.netlbl.Name = "netlbl"
        Me.netlbl.Size = New System.Drawing.Size(74, 19)
        Me.netlbl.TabIndex = 14
        Me.netlbl.Text = "Net Fare:"
        '
        'fromlbl
        '
        Me.fromlbl.AutoSize = True
        Me.fromlbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromlbl.Location = New System.Drawing.Point(107, 55)
        Me.fromlbl.Name = "fromlbl"
        Me.fromlbl.Size = New System.Drawing.Size(60, 22)
        Me.fromlbl.TabIndex = 13
        Me.fromlbl.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(196, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 49)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ticket"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.procBtn)
        Me.Controls.Add(Me.discCB)
        Me.Controls.Add(Me.dicLbl)
        Me.Controls.Add(Me.desti2CB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.destiLbl)
        Me.Controls.Add(Me.desti1CB)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents desti1CB As ComboBox
    Friend WithEvents destiLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents desti2CB As ComboBox
    Friend WithEvents dicLbl As Label
    Friend WithEvents discCB As ComboBox
    Friend WithEvents extBtn As Button
    Friend WithEvents procBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grosslbl As Label
    Friend WithEvents disclbl As Label
    Friend WithEvents netlbl As Label
    Friend WithEvents fromlbl As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
