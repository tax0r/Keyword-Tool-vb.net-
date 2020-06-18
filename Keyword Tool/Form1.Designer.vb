<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ThirteenForm1 = New Keyword_Tool.ThirteenForm()
        Me.categoryComboBox = New Keyword_Tool.ThirteenComboBox()
        Me.spacesCheckBox = New Keyword_Tool.ThirteenCheckBox()
        Me.providersLabel = New System.Windows.Forms.Label()
        Me.shareButton = New Keyword_Tool.ThirteenCheckBox()
        Me.ThirteenControlBox1 = New Keyword_Tool.ThirteenControlBox()
        Me.outputTextBox = New Keyword_Tool.ThirteenTextBox()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.mailProviderTextBox = New Keyword_Tool.ThirteenTextBox()
        Me.exportButton = New Keyword_Tool.ThirteenButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stopButton = New Keyword_Tool.ThirteenButton()
        Me.startButton = New Keyword_Tool.ThirteenButton()
        Me.keywordTextBox = New Keyword_Tool.ThirteenTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mailProvidersTextBox = New Keyword_Tool.ThirteenTextBox()
        Me.ThirteenForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.Violet
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = Keyword_Tool.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.categoryComboBox)
        Me.ThirteenForm1.Controls.Add(Me.spacesCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.providersLabel)
        Me.ThirteenForm1.Controls.Add(Me.shareButton)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenControlBox1)
        Me.ThirteenForm1.Controls.Add(Me.outputTextBox)
        Me.ThirteenForm1.Controls.Add(Me.statusLabel)
        Me.ThirteenForm1.Controls.Add(Me.mailProviderTextBox)
        Me.ThirteenForm1.Controls.Add(Me.exportButton)
        Me.ThirteenForm1.Controls.Add(Me.Label2)
        Me.ThirteenForm1.Controls.Add(Me.Label1)
        Me.ThirteenForm1.Controls.Add(Me.stopButton)
        Me.ThirteenForm1.Controls.Add(Me.startButton)
        Me.ThirteenForm1.Controls.Add(Me.keywordTextBox)
        Me.ThirteenForm1.Controls.Add(Me.Label3)
        Me.ThirteenForm1.Controls.Add(Me.mailProvidersTextBox)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(571, 489)
        Me.ThirteenForm1.TabIndex = 1
        Me.ThirteenForm1.Text = "Keyword Tool - By iLoveJan ❤"
        '
        'categoryComboBox
        '
        Me.categoryComboBox.AccentColor = System.Drawing.Color.DodgerBlue
        Me.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.categoryComboBox.ColorScheme = Keyword_Tool.ThirteenComboBox.ColorSchemes.Dark
        Me.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoryComboBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.categoryComboBox.ForeColor = System.Drawing.Color.White
        Me.categoryComboBox.FormattingEnabled = True
        Me.categoryComboBox.Items.AddRange(New Object() {"Generic", "Education", "Both"})
        Me.categoryComboBox.Location = New System.Drawing.Point(312, 140)
        Me.categoryComboBox.Name = "categoryComboBox"
        Me.categoryComboBox.Size = New System.Drawing.Size(97, 26)
        Me.categoryComboBox.TabIndex = 57
        '
        'spacesCheckBox
        '
        Me.spacesCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.spacesCheckBox.Checked = True
        Me.spacesCheckBox.ColorScheme = Keyword_Tool.ThirteenCheckBox.ColorSchemes.Dark
        Me.spacesCheckBox.ForeColor = System.Drawing.Color.White
        Me.spacesCheckBox.Location = New System.Drawing.Point(312, 195)
        Me.spacesCheckBox.Name = "spacesCheckBox"
        Me.spacesCheckBox.Size = New System.Drawing.Size(64, 17)
        Me.spacesCheckBox.TabIndex = 56
        Me.spacesCheckBox.Text = "Spaces"
        '
        'providersLabel
        '
        Me.providersLabel.AutoSize = True
        Me.providersLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.providersLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.providersLabel.Location = New System.Drawing.Point(309, 228)
        Me.providersLabel.Name = "providersLabel"
        Me.providersLabel.Size = New System.Drawing.Size(67, 13)
        Me.providersLabel.TabIndex = 55
        Me.providersLabel.Text = "Providers:"
        '
        'shareButton
        '
        Me.shareButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.shareButton.Checked = True
        Me.shareButton.ColorScheme = Keyword_Tool.ThirteenCheckBox.ColorSchemes.Dark
        Me.shareButton.ForeColor = System.Drawing.Color.White
        Me.shareButton.Location = New System.Drawing.Point(312, 172)
        Me.shareButton.Name = "shareButton"
        Me.shareButton.Size = New System.Drawing.Size(57, 17)
        Me.shareButton.TabIndex = 52
        Me.shareButton.Text = "Share"
        '
        'ThirteenControlBox1
        '
        Me.ThirteenControlBox1.AccentColor = System.Drawing.Color.Violet
        Me.ThirteenControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenControlBox1.ColorScheme = Keyword_Tool.ThirteenControlBox.ColorSchemes.Dark
        Me.ThirteenControlBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenControlBox1.Location = New System.Drawing.Point(471, 0)
        Me.ThirteenControlBox1.Name = "ThirteenControlBox1"
        Me.ThirteenControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ThirteenControlBox1.TabIndex = 51
        Me.ThirteenControlBox1.Text = "ThirteenControlBox1"
        '
        'outputTextBox
        '
        Me.outputTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputTextBox.ColorScheme = Keyword_Tool.ThirteenTextBox.ColorSchemes.Dark
        Me.outputTextBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTextBox.ForeColor = System.Drawing.Color.White
        Me.outputTextBox.Location = New System.Drawing.Point(415, 53)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(144, 424)
        Me.outputTextBox.TabIndex = 48
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(309, 215)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(49, 13)
        Me.statusLabel.TabIndex = 47
        Me.statusLabel.Text = "Status:"
        '
        'mailProviderTextBox
        '
        Me.mailProviderTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.mailProviderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mailProviderTextBox.ColorScheme = Keyword_Tool.ThirteenTextBox.ColorSchemes.Dark
        Me.mailProviderTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.mailProviderTextBox.ForeColor = System.Drawing.Color.White
        Me.mailProviderTextBox.Location = New System.Drawing.Point(308, 457)
        Me.mailProviderTextBox.Multiline = True
        Me.mailProviderTextBox.Name = "mailProviderTextBox"
        Me.mailProviderTextBox.Size = New System.Drawing.Size(0, 0)
        Me.mailProviderTextBox.TabIndex = 46
        Me.mailProviderTextBox.Text = resources.GetString("mailProviderTextBox.Text")
        '
        'exportButton
        '
        Me.exportButton.AccentColor = System.Drawing.Color.Violet
        Me.exportButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.exportButton.ColorScheme = Keyword_Tool.ThirteenButton.ColorSchemes.Dark
        Me.exportButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.exportButton.ForeColor = System.Drawing.Color.White
        Me.exportButton.Location = New System.Drawing.Point(312, 111)
        Me.exportButton.Name = "exportButton"
        Me.exportButton.Size = New System.Drawing.Size(97, 23)
        Me.exportButton.TabIndex = 45
        Me.exportButton.Text = "Export"
        Me.exportButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Output:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Keywords:"
        '
        'stopButton
        '
        Me.stopButton.AccentColor = System.Drawing.Color.Violet
        Me.stopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.stopButton.ColorScheme = Keyword_Tool.ThirteenButton.ColorSchemes.Dark
        Me.stopButton.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.stopButton.ForeColor = System.Drawing.Color.White
        Me.stopButton.Location = New System.Drawing.Point(312, 82)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(97, 23)
        Me.stopButton.TabIndex = 42
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = False
        '
        'startButton
        '
        Me.startButton.AccentColor = System.Drawing.Color.Violet
        Me.startButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.startButton.ColorScheme = Keyword_Tool.ThirteenButton.ColorSchemes.Dark
        Me.startButton.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.ForeColor = System.Drawing.Color.White
        Me.startButton.Location = New System.Drawing.Point(312, 53)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(97, 23)
        Me.startButton.TabIndex = 41
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'keywordTextBox
        '
        Me.keywordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.keywordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.keywordTextBox.ColorScheme = Keyword_Tool.ThirteenTextBox.ColorSchemes.Dark
        Me.keywordTextBox.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.keywordTextBox.ForeColor = System.Drawing.Color.White
        Me.keywordTextBox.Location = New System.Drawing.Point(12, 53)
        Me.keywordTextBox.Multiline = True
        Me.keywordTextBox.Name = "keywordTextBox"
        Me.keywordTextBox.Size = New System.Drawing.Size(144, 424)
        Me.keywordTextBox.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Mail Providers:"
        '
        'mailProvidersTextBox
        '
        Me.mailProvidersTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.mailProvidersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mailProvidersTextBox.ColorScheme = Keyword_Tool.ThirteenTextBox.ColorSchemes.Dark
        Me.mailProvidersTextBox.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.mailProvidersTextBox.ForeColor = System.Drawing.Color.White
        Me.mailProvidersTextBox.Location = New System.Drawing.Point(162, 53)
        Me.mailProvidersTextBox.Multiline = True
        Me.mailProvidersTextBox.Name = "mailProvidersTextBox"
        Me.mailProvidersTextBox.Size = New System.Drawing.Size(144, 424)
        Me.mailProvidersTextBox.TabIndex = 49
        Me.mailProvidersTextBox.Text = resources.GetString("mailProvidersTextBox.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 489)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Keyword Tool - By iLoveJan"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThirteenForm1 As Keyword_Tool.ThirteenForm
    Friend WithEvents shareButton As Keyword_Tool.ThirteenCheckBox
    Friend WithEvents ThirteenControlBox1 As Keyword_Tool.ThirteenControlBox
    Friend WithEvents outputTextBox As Keyword_Tool.ThirteenTextBox
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents mailProviderTextBox As Keyword_Tool.ThirteenTextBox
    Friend WithEvents exportButton As Keyword_Tool.ThirteenButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stopButton As Keyword_Tool.ThirteenButton
    Friend WithEvents startButton As Keyword_Tool.ThirteenButton
    Friend WithEvents keywordTextBox As Keyword_Tool.ThirteenTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mailProvidersTextBox As Keyword_Tool.ThirteenTextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents providersLabel As System.Windows.Forms.Label
    Friend WithEvents spacesCheckBox As Keyword_Tool.ThirteenCheckBox
    Friend WithEvents categoryComboBox As Keyword_Tool.ThirteenComboBox

End Class
