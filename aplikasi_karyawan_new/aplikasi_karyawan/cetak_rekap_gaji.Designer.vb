<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak_rekap_gaji
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
        Me.dtpdari = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Sampai = New System.Windows.Forms.Label
        Me.dtpsampai = New System.Windows.Forms.DateTimePicker
        Me.btncetak = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtpdari
        '
        Me.dtpdari.CustomFormat = "yyyy-MM-dd"
        Me.dtpdari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdari.Location = New System.Drawing.Point(42, 45)
        Me.dtpdari.Name = "dtpdari"
        Me.dtpdari.Size = New System.Drawing.Size(200, 20)
        Me.dtpdari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dari"
        '
        'Sampai
        '
        Me.Sampai.AutoSize = True
        Me.Sampai.Location = New System.Drawing.Point(39, 87)
        Me.Sampai.Name = "Sampai"
        Me.Sampai.Size = New System.Drawing.Size(42, 13)
        Me.Sampai.TabIndex = 3
        Me.Sampai.Text = "Sampai"
        '
        'dtpsampai
        '
        Me.dtpsampai.CustomFormat = "yyyy-MM-dd"
        Me.dtpsampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsampai.Location = New System.Drawing.Point(42, 103)
        Me.dtpsampai.Name = "dtpsampai"
        Me.dtpsampai.Size = New System.Drawing.Size(200, 20)
        Me.dtpsampai.TabIndex = 4
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(244, 172)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(116, 26)
        Me.btncetak.TabIndex = 5
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'cetak_rekap_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 226)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.dtpsampai)
        Me.Controls.Add(Me.Sampai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpdari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "cetak_rekap_gaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cetak Rekap Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpdari As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sampai As System.Windows.Forms.Label
    Friend WithEvents dtpsampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncetak As System.Windows.Forms.Button
End Class
