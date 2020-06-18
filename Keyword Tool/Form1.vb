Imports xNet
Imports System.Threading

Public Class Form1

    Dim onOff As Boolean = False
    Dim sharingAllowed As Boolean = True

    Private _obj As Object = New Object

    Dim mailCounter As Integer = 0
    Dim keywordCounter As Integer = 0
    Dim counter As Integer = 0

    Function getMailProviders() As String
        Using request As New HttpRequest
            request.UserAgent = Http.ChromeUserAgent
            'Generic 0
            'Education 1
            'Both 2
            If (categoryComboBox.SelectedIndex = 0) Then
                Dim response As String = request.Get("https://pastebin.com/raw/nrA5vTZV").ToString
                Return response
            ElseIf (categoryComboBox.SelectedIndex = 1) Then
                Dim response As String = request.Get("https://pastebin.com/raw/vAZziswk").ToString
                Return response
            ElseIf (categoryComboBox.SelectedIndex = 2) Then
                Dim response As String = request.Get("https://pastebin.com/raw/n0fsBKWz").ToString
                Return response
            End If
            Return request.Get("https://pastebin.com/raw/nrA5vTZV").ToString
        End Using
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        mailProvidersTextBox.Text = getMailProviders()
        For Each mail In Me.mailProvidersTextBox.Lines
            mailCounter = mailCounter + 1
        Next mail
        providersLabel.Text = "Providers: " & mailCounter
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        onOff = True

        For Each keyword In Me.keywordTextBox.Lines
            keywordCounter = keywordCounter + 1
        Next keyword

        'Dim w As WaitCallback = New WaitCallback(AddressOf main)

        'For i As Integer = 0 To 100
        '    ThreadPool.QueueUserWorkItem(w)
        'Next

        'Dim TT As New Thread(AddressOf main)
        'TT.Start()

        newMain()

    End Sub

    Private Async Sub main()
        Dim checked As Boolean
        If (spacesCheckBox.Checked) Then
            checked = True
        Else
            checked = False
        End If
        If (onOff = True) Then
            If (keywordTextBox.Text.Length > 0) Then
                statusLabel.Text = "Status: started"
                statusLabel.Update()
                outputTextBox.Text = ""
                For Each keyword In Me.keywordTextBox.Lines
                    Dim mail As String
                    For Each mail In Me.mailProvidersTextBox.Lines
                        If (checked) Then
                            Monitor.Enter(_obj)
                            Dim finalOutput As String = keyword & " @" & mail & vbNewLine
                            Monitor.Exit(_obj)
                            outputTextBox.Text += finalOutput
                            outputTextBox.Update()
                        Else
                            Monitor.Enter(_obj)
                            Dim finalOutput As String = keyword & "@" & mail & vbNewLine
                            Monitor.Exit(_obj)
                            outputTextBox.Text += finalOutput
                            outputTextBox.Update()
                        End If
                    Next mail
                Next keyword
                statusLabel.Text = "Status: done"
                Thread.CurrentThread.Abort()
                Await Task.Delay(1)
                MsgBox("DONE!")
                If (sharingAllowed = True) Then
                    postPaste(outputTextBox.Text, Environment.UserName + " | " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                End If
            Else
                statusLabel.Text = "Status: empty"
            End If
        End If
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        If (Thread.CurrentThread.IsAlive) Then
            Thread.CurrentThread.Abort()
        End If
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

    Private Sub keywordTextBox_TextChanged(sender As Object, e As EventArgs) Handles keywordTextBox.TextChanged
        If (keywordTextBox.Text.Contains(" ")) Then
            keywordTextBox.Text = keywordTextBox.Text.Replace(" ", "")
        End If
    End Sub

    Private Async Sub newMain()



        Dim checked As Boolean
        If (spacesCheckBox.Checked) Then
            checked = True
        Else
            checked = False
        End If

        Dim stopWatch As New Stopwatch()

        If (onOff) Then
            If (keywordTextBox.Text.Length > 0) Then

                'Create threads for each keyword individually
                statusLabel.Text = "Status: started"
                statusLabel.Update()
                outputTextBox.Text = ""

                stopWatch.Start()

                For Each keyword In Me.keywordTextBox.Lines

                    Dim TT As New Thread(AddressOf main)

                    TT.Start()

                    For Each mail In Me.mailProvidersTextBox.Lines
                        'Checks if it should put a space or not
                        If (checked) Then
                            Monitor.Enter(_obj)
                            Dim finalOutput As String = keyword & " @" & mail & vbNewLine
                            Monitor.Exit(_obj)

                            outputTextBox.Text += finalOutput
                            outputTextBox.Update()
                        Else
                            Monitor.Enter(_obj)
                            Dim finalOutput As String = keyword & "@" & mail & vbNewLine
                            Monitor.Exit(_obj)

                            outputTextBox.Text += finalOutput
                            outputTextBox.Update()
                        End If
                        Await Task.Delay(1)
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub categoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoryComboBox.SelectedIndexChanged
        mailProvidersTextBox.Text = getMailProviders()
        For Each mail In Me.mailProvidersTextBox.Lines
            mailCounter = mailCounter + 1
        Next mail
        providersLabel.Text = "Providers: " & mailCounter
    End Sub
End Class