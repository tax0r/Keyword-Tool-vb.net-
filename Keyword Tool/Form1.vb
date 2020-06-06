Imports xNet

Public Class Form1

    Dim onOff As Boolean = False
    Dim sharingAllowed As Boolean = True

    Dim thread As System.Threading.Thread

    Dim counter As Integer = 0

    Function getMailProviders() As String
        'https://pastebin.com/raw/n0fsBKWz
        Using request As New HttpRequest
            request.UserAgent = Http.ChromeUserAgent
            Dim response As String = request.Get("https://pastebin.com/raw/n0fsBKWz").ToString
            Return response
        End Using
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        'Me.Icon = New Icon(Me.GetType(), "Goescat-Macaron-Terminator.ico")
        mailProvidersTextBox.Text = getMailProviders()
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
                Dim Input As String() = keywordTextBox.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                For Each keyword As String In Input
                    Dim Mails As String() = mailProvidersTextBox.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                    For Each mail As String In Mails
                        counter = counter + 1
                        Dim finalOutput As String = keyword + "@" + mail + vbNewLine
                        outputTextBox.Text += finalOutput
                        outputTextBox.Update()

                        Dim icrement As Integer = counter / 1
                    Next
                Next
                statusLabel.Text = "Status: done"
                If (sharingAllowed = True) Then
                    postPaste(outputTextBox.Text, Environment.UserName + " | " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                End If
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

    Private Sub postPaste(paste As String, title As String)
        Using request As New HttpRequest
            request.UserAgent = Http.ChromeUserAgent

            request.AddParam("lang", "")
            request.AddParam("text", paste)
            request.AddParam("expire", "-1")
            request.AddParam("password", "")
            request.AddParam("title", title)

            Dim cookiedict As New CookieDictionary(False)

            cookiedict.Add("__cfduid", "df1327ec41c18acb594f3c7a892b5b51e1590488585")
            cookiedict.Add("authentication", "MTU5MTQ1OTQzM3xjZV9FZzF2STJkbTFBRTZwS1Y3MEh1OGlJejJFOUdiWm9jejBXMWxuNEstRnRtaUIzaFg1aWhpSDFlNkxoZEZnWkw2cTFrVm85N0IyaUF5bDJFdzRYUHdneDVoRlQzcmF3VzdHQ3hGZWpZRmhudVJhUHJkZk91TF84enJ3eVlCUTN1UHdFYk9kTHBZWVliWTRIODNNeFlNUnJBYXVJeHFLSVNVbDB3PT18apgBJvUws1CiYG9Xrl8bWS3_9PtN_5l8kGK0NFL0FKE")
            cookiedict.Add("session", "MTU5MTQ1OTQzM3xOd3dBTkRWVFVsZE1RVVJFU1ZKQlYxUldVa1pGV0ZSWFVWazFNMFJPTkVoWVRsWklRMDlLV1RaQlRWQlRUVXcyVkVWSVFVY3lTMUU9fEh3FhfbjNfISGuQUg9QoCWoJmWf0f4JXk1jCG2ArtqW")

            request.Cookies = cookiedict

            request.Post("https://ghostbin.co/paste/new")
        End Using
    End Sub

    Private Sub shareButton_CheckedChanged(sender As Object) Handles shareButton.CheckedChanged
        If (sharingAllowed = True) Then
            sharingAllowed = False
        Else
            sharingAllowed = True
        End If
    End Sub
End Class