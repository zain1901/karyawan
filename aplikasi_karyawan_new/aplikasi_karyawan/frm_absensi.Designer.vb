<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_absensi
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
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbltglsekarang = New System.Windows.Forms.Label
        Me.lbljamsekarang = New System.Windows.Forms.Label
        Me.lblnik = New System.Windows.Forms.Label
        Me.lblinfo = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(40, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 285)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbltglsekarang
        '
        Me.lbltglsekarang.AutoSize = True
        Me.lbltglsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltglsekarang.Location = New System.Drawing.Point(341, 41)
        Me.lbltglsekarang.Name = "lbltglsekarang"
        Me.lbltglsekarang.Size = New System.Drawing.Size(63, 20)
        Me.lbltglsekarang.TabIndex = 1
        Me.lbltglsekarang.Text = "Label1"
        '
        'lbljamsekarang
        '
        Me.lbljamsekarang.AutoSize = True
        Me.lbljamsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljamsekarang.Location = New System.Drawing.Point(341, 77)
        Me.lbljamsekarang.Name = "lbljamsekarang"
        Me.lbljamsekarang.Size = New System.Drawing.Size(63, 20)
        Me.lbljamsekarang.TabIndex = 2
        Me.lbljamsekarang.Text = "Label2"
        '
        'lblnik
        '
        Me.lblnik.AutoSize = True
        Me.lblnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnik.Location = New System.Drawing.Point(341, 111)
        Me.lblnik.Name = "lblnik"
        Me.lblnik.Size = New System.Drawing.Size(63, 20)
        Me.lblnik.TabIndex = 3
        Me.lblnik.Text = "Label3"
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(341, 145)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(63, 20)
        Me.lblinfo.TabIndex = 4
        Me.lblinfo.Text = "Label4"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(42, 322)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(240, 20)
        Me.txtnik.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 369)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.lblnik)
        Me.Controls.Add(Me.lbljamsekarang)
        Me.Controls.Add(Me.lbltglsekarang)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_absensi"
        Me.Text = "frm_absensi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltglsekarang As System.Windows.Forms.Label
    Friend WithEvents lbljamsekarang As System.Windows.Forms.Label
    Friend WithEvents lblnik As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
