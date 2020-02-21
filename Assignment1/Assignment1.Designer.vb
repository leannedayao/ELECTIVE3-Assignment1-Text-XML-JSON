<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assignment1
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddTextBox = New System.Windows.Forms.TextBox()
        Me.TextBtn = New System.Windows.Forms.Button()
        Me.XmlBtn = New System.Windows.Forms.Button()
        Me.JsonBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(31, 32)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(65, 23)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name :"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(31, 89)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(49, 23)
        Me.AgeLabel.TabIndex = 1
        Me.AgeLabel.Text = "Age :"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(31, 144)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(79, 23)
        Me.AddressLabel.TabIndex = 2
        Me.AddressLabel.Text = "Address :"
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(164, 29)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(292, 30)
        Me.NameTextBox.TabIndex = 3
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(164, 85)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(292, 30)
        Me.AgeTextBox.TabIndex = 4
        '
        'AddTextBox
        '
        Me.AddTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTextBox.Location = New System.Drawing.Point(164, 144)
        Me.AddTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddTextBox.Multiline = True
        Me.AddTextBox.Name = "AddTextBox"
        Me.AddTextBox.Size = New System.Drawing.Size(292, 70)
        Me.AddTextBox.TabIndex = 5
        '
        'TextBtn
        '
        Me.TextBtn.AutoSize = True
        Me.TextBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.TextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TextBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBtn.Location = New System.Drawing.Point(35, 256)
        Me.TextBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBtn.Name = "TextBtn"
        Me.TextBtn.Size = New System.Drawing.Size(100, 35)
        Me.TextBtn.TabIndex = 6
        Me.TextBtn.Text = "Text"
        Me.TextBtn.UseVisualStyleBackColor = False
        '
        'XmlBtn
        '
        Me.XmlBtn.AutoSize = True
        Me.XmlBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XmlBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.XmlBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.XmlBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.XmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XmlBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XmlBtn.Location = New System.Drawing.Point(196, 256)
        Me.XmlBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.XmlBtn.Name = "XmlBtn"
        Me.XmlBtn.Size = New System.Drawing.Size(100, 35)
        Me.XmlBtn.TabIndex = 7
        Me.XmlBtn.Text = "XML"
        Me.XmlBtn.UseVisualStyleBackColor = False
        '
        'JsonBtn
        '
        Me.JsonBtn.AutoSize = True
        Me.JsonBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.JsonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.JsonBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.JsonBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.JsonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JsonBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JsonBtn.Location = New System.Drawing.Point(357, 256)
        Me.JsonBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.JsonBtn.Name = "JsonBtn"
        Me.JsonBtn.Size = New System.Drawing.Size(100, 35)
        Me.JsonBtn.TabIndex = 8
        Me.JsonBtn.Text = "JSON"
        Me.JsonBtn.UseVisualStyleBackColor = False
        '
        'Assignment1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(498, 323)
        Me.Controls.Add(Me.JsonBtn)
        Me.Controls.Add(Me.XmlBtn)
        Me.Controls.Add(Me.TextBtn)
        Me.Controls.Add(Me.AddTextBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Assignment1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment No. 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AddTextBox As TextBox
    Friend WithEvents TextBtn As Button
    Friend WithEvents XmlBtn As Button
    Friend WithEvents JsonBtn As Button
End Class
