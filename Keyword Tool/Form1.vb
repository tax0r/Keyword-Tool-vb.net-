Public Class Form1

    Dim onOff As Boolean = False

    Dim thread As System.Threading.Thread



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Icon = New Icon(Me.GetType(), "Goescat-Macaron-Terminator.ico")
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        onOff = True
        thread = New System.Threading.Thread(AddressOf main)
        thread.Start()
    End Sub

    Private Sub main()
        If (onOff = True) Then
            If (keywordTextBox.Text.Length > 0) Then
                statusLabel.Text = "Status: started"
                statusLabel.Update()
                outputTextBox.Text = ""
                Dim Input As String() = keywordTextBox.Text.Split(New [Char]() {CChar(vbCrLf)})
                For Each keyword As String In Input
                    Dim Mails As String() = mailProvidersTextBox.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                    For Each mail As String In Mails
                        Dim finalOutput As String = keyword + "@" + mail + vbNewLine
                        outputTextBox.Text += finalOutput
                        outputTextBox.Update()
                    Next
                Next
                statusLabel.Text = "Status: done"
            Else
                statusLabel.Text = "Status: empty"
            End If
        End If
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Try
            thread.Abort()
            statusLabel.Text = "Status: stopped"
        Catch ex As Exception
            MsgBox("Click 'Start' first!")
        End Try
    End Sub

    Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportButton.Click
        If (outputTextBox.Text.Length > 0) Then
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, outputTextBox.Text)
        Else
            MsgBox("Click 'Start' first!")
        End If
    End Sub
End Class
