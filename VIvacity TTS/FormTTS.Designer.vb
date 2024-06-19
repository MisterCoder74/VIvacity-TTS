<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTTS))
        Me.prompttxt = New System.Windows.Forms.TextBox()
        Me.apikeytxt = New System.Windows.Forms.TextBox()
        Me.sendbtn = New System.Windows.Forms.Button()
        Me.fetchbtn = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.logtxt = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prompttxt
        '
        Me.prompttxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.prompttxt.Location = New System.Drawing.Point(0, 0)
        Me.prompttxt.Multiline = True
        Me.prompttxt.Name = "prompttxt"
        Me.prompttxt.Size = New System.Drawing.Size(763, 101)
        Me.prompttxt.TabIndex = 0
        Me.prompttxt.Text = "Insert your text here..."
        '
        'apikeytxt
        '
        Me.apikeytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apikeytxt.Location = New System.Drawing.Point(14, 147)
        Me.apikeytxt.Name = "apikeytxt"
        Me.apikeytxt.Size = New System.Drawing.Size(475, 23)
        Me.apikeytxt.TabIndex = 1
        '
        'sendbtn
        '
        Me.sendbtn.Location = New System.Drawing.Point(639, 147)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(110, 27)
        Me.sendbtn.TabIndex = 2
        Me.sendbtn.Text = "Send"
        Me.sendbtn.UseVisualStyleBackColor = True
        '
        'fetchbtn
        '
        Me.fetchbtn.Location = New System.Drawing.Point(639, 191)
        Me.fetchbtn.Name = "fetchbtn"
        Me.fetchbtn.Size = New System.Drawing.Size(110, 27)
        Me.fetchbtn.TabIndex = 3
        Me.fetchbtn.Text = "Download MP3"
        Me.fetchbtn.UseVisualStyleBackColor = True
        Me.fetchbtn.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 260)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(489, 277)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'logtxt
        '
        Me.logtxt.Location = New System.Drawing.Point(497, 260)
        Me.logtxt.Multiline = True
        Me.logtxt.Name = "logtxt"
        Me.logtxt.Size = New System.Drawing.Size(265, 277)
        Me.logtxt.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"alloy", "echo", "fable", "onyx", "nova", "shimmer"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 23)
        Me.ComboBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Voice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "OpanAI API Key"
        '
        'FormTTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(763, 539)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.logtxt)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.fetchbtn)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.apikeytxt)
        Me.Controls.Add(Me.prompttxt)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTTS"
        Me.Text = "Vivacity Text to Speech Client"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prompttxt As System.Windows.Forms.TextBox
    Friend WithEvents apikeytxt As System.Windows.Forms.TextBox
    Friend WithEvents sendbtn As System.Windows.Forms.Button
    Friend WithEvents fetchbtn As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents logtxt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
