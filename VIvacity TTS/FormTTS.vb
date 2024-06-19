Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization ' Per il parsing JSON
Imports System.Windows.Forms ' Per MessageBox
Imports System.IO ' Per StreamReader
Imports System.Threading.Tasks

Public Class FormTTS
    Dim requestBody As String
    Dim responseBytes As Byte()
    Private Sub sendbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendbtn.Click

        Dim apikey As String = apikeytxt.Text
        Dim prompt As String = prompttxt.Text
        Dim selectedVoice As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), String.Empty)
        System.Net.ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
        If Not String.IsNullOrEmpty(prompt) Then
            requestBody = "{""model"": ""tts-1"", ""input"": """ & prompt & """, ""voice"": """ & selectedVoice & """}"

            Dim client As New WebClient()
            client.Headers.Add("Authorization", "Bearer " & apikey)
            client.Headers.Add("Content-Type", "application/json")
            logtxt.Text = "Sending request...." & vbCrLf & "Request grammar: " & requestBody & vbCrLf
            responseBytes = client.UploadData("https://api.openai.com/v1/audio/speech", "POST", System.Text.Encoding.UTF8.GetBytes(requestBody))
            logtxt.Text += "Response received, now playing audio." & vbCrLf
            logtxt.Text += "Click 'Download MP3' to save the file to your disk" & vbCrLf
            Dim tempAudioFilePath As String = Path.Combine(Path.GetTempPath(), "temp_audio.mp3")

            ' Cancella il file temporaneo se esiste già
            If File.Exists(tempAudioFilePath) Then
                File.Delete(tempAudioFilePath)
            End If

            File.WriteAllBytes(tempAudioFilePath, responseBytes)

            AxWindowsMediaPlayer1.URL = tempAudioFilePath
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            fetchbtn.Visible = True
        Else
            MessageBox.Show("Please insert a text prompt before converting.")
        End If
    End Sub


    Private Sub prompttxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prompttxt.Click
        prompttxt.Text = ""
    End Sub

    Private Sub fetchbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchbtn.Click
        Using dialog As New SaveFileDialog()
            dialog.Filter = "Audio files|*.mp3"
            dialog.Title = "Save Audio File"
            dialog.FileName = "output_audio.mp3"

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim saveFilePath As String = dialog.FileName
                If File.Exists(saveFilePath) Then
                    File.Delete(saveFilePath)
                End If

                File.WriteAllBytes(saveFilePath, responseBytes)

                logtxt.Text += "File saved." & vbCrLf
            End If
        End Using
    End Sub
End Class
