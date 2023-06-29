<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perawat
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
        Me.Pn_button_title = New System.Windows.Forms.Panel()
        Me.btn_periksa = New System.Windows.Forms.Button()
        Me.btn_beranda = New System.Windows.Forms.Button()
        Me.Pn_title = New System.Windows.Forms.Panel()
        Me.lbl_id_perawat = New System.Windows.Forms.Label()
        Me.lbl_nama_perawat = New System.Windows.Forms.Label()
        Me.Pn_button_title.SuspendLayout()
        Me.Pn_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pn_button_title
        '
        Me.Pn_button_title.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_button_title.Controls.Add(Me.btn_periksa)
        Me.Pn_button_title.Controls.Add(Me.btn_beranda)
        Me.Pn_button_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_button_title.Location = New System.Drawing.Point(0, 68)
        Me.Pn_button_title.Name = "Pn_button_title"
        Me.Pn_button_title.Size = New System.Drawing.Size(832, 80)
        Me.Pn_button_title.TabIndex = 7
        '
        'btn_periksa
        '
        Me.btn_periksa.Location = New System.Drawing.Point(153, 26)
        Me.btn_periksa.Name = "btn_periksa"
        Me.btn_periksa.Size = New System.Drawing.Size(97, 36)
        Me.btn_periksa.TabIndex = 5
        Me.btn_periksa.Text = "Periksa"
        Me.btn_periksa.UseVisualStyleBackColor = True
        '
        'btn_beranda
        '
        Me.btn_beranda.Location = New System.Drawing.Point(30, 26)
        Me.btn_beranda.Name = "btn_beranda"
        Me.btn_beranda.Size = New System.Drawing.Size(97, 36)
        Me.btn_beranda.TabIndex = 4
        Me.btn_beranda.Text = "Beranda"
        Me.btn_beranda.UseVisualStyleBackColor = True
        '
        'Pn_title
        '
        Me.Pn_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pn_title.Controls.Add(Me.lbl_id_perawat)
        Me.Pn_title.Controls.Add(Me.lbl_nama_perawat)
        Me.Pn_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_title.Location = New System.Drawing.Point(0, 0)
        Me.Pn_title.Name = "Pn_title"
        Me.Pn_title.Size = New System.Drawing.Size(832, 68)
        Me.Pn_title.TabIndex = 6
        '
        'lbl_id_perawat
        '
        Me.lbl_id_perawat.AutoSize = True
        Me.lbl_id_perawat.Location = New System.Drawing.Point(146, 27)
        Me.lbl_id_perawat.Name = "lbl_id_perawat"
        Me.lbl_id_perawat.Size = New System.Drawing.Size(20, 16)
        Me.lbl_id_perawat.TabIndex = 3
        Me.lbl_id_perawat.Text = "ID"
        '
        'lbl_nama_perawat
        '
        Me.lbl_nama_perawat.AutoSize = True
        Me.lbl_nama_perawat.Location = New System.Drawing.Point(27, 27)
        Me.lbl_nama_perawat.Name = "lbl_nama_perawat"
        Me.lbl_nama_perawat.Size = New System.Drawing.Size(56, 16)
        Me.lbl_nama_perawat.TabIndex = 2
        Me.lbl_nama_perawat.Text = "Perawat"
        '
        'perawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 757)
        Me.Controls.Add(Me.Pn_button_title)
        Me.Controls.Add(Me.Pn_title)
        Me.Name = "perawat"
        Me.Text = "perawat"
        Me.Pn_button_title.ResumeLayout(False)
        Me.Pn_title.ResumeLayout(False)
        Me.Pn_title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pn_button_title As Panel
    Friend WithEvents btn_periksa As Button
    Friend WithEvents btn_beranda As Button
    Friend WithEvents Pn_title As Panel
    Friend WithEvents lbl_id_perawat As Label
    Friend WithEvents lbl_nama_perawat As Label
End Class
