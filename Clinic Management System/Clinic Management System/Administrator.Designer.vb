<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.Pn_button_title = New System.Windows.Forms.Panel()
        Me.btn_kasir = New System.Windows.Forms.Button()
        Me.btn_perawat = New System.Windows.Forms.Button()
        Me.btn_dokter = New System.Windows.Forms.Button()
        Me.btn_beranda = New System.Windows.Forms.Button()
        Me.Pn_title = New System.Windows.Forms.Panel()
        Me.Pn_button_title.SuspendLayout()
        Me.Pn_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(12, 18)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(45, 16)
        Me.lbl_nama_admin.TabIndex = 0
        Me.lbl_nama_admin.Text = "Admin"
        '
        'Pn_button_title
        '
        Me.Pn_button_title.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_button_title.Controls.Add(Me.btn_kasir)
        Me.Pn_button_title.Controls.Add(Me.btn_perawat)
        Me.Pn_button_title.Controls.Add(Me.btn_dokter)
        Me.Pn_button_title.Controls.Add(Me.btn_beranda)
        Me.Pn_button_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_button_title.Location = New System.Drawing.Point(0, 68)
        Me.Pn_button_title.Name = "Pn_button_title"
        Me.Pn_button_title.Size = New System.Drawing.Size(832, 80)
        Me.Pn_button_title.TabIndex = 5
        '
        'btn_kasir
        '
        Me.btn_kasir.Location = New System.Drawing.Point(396, 26)
        Me.btn_kasir.Name = "btn_kasir"
        Me.btn_kasir.Size = New System.Drawing.Size(97, 36)
        Me.btn_kasir.TabIndex = 7
        Me.btn_kasir.Text = "Kasir"
        Me.btn_kasir.UseVisualStyleBackColor = True
        '
        'btn_perawat
        '
        Me.btn_perawat.Location = New System.Drawing.Point(273, 26)
        Me.btn_perawat.Name = "btn_perawat"
        Me.btn_perawat.Size = New System.Drawing.Size(97, 36)
        Me.btn_perawat.TabIndex = 6
        Me.btn_perawat.Text = "Perawat"
        Me.btn_perawat.UseVisualStyleBackColor = True
        '
        'btn_dokter
        '
        Me.btn_dokter.Location = New System.Drawing.Point(153, 26)
        Me.btn_dokter.Name = "btn_dokter"
        Me.btn_dokter.Size = New System.Drawing.Size(97, 36)
        Me.btn_dokter.TabIndex = 5
        Me.btn_dokter.Text = "Dokter"
        Me.btn_dokter.UseVisualStyleBackColor = True
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
        Me.Pn_title.Controls.Add(Me.lbl_nama_admin)
        Me.Pn_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_title.Location = New System.Drawing.Point(0, 0)
        Me.Pn_title.Name = "Pn_title"
        Me.Pn_title.Size = New System.Drawing.Size(832, 68)
        Me.Pn_title.TabIndex = 4
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 653)
        Me.Controls.Add(Me.Pn_button_title)
        Me.Controls.Add(Me.Pn_title)
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        Me.Pn_button_title.ResumeLayout(False)
        Me.Pn_title.ResumeLayout(False)
        Me.Pn_title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents Pn_button_title As Panel
    Friend WithEvents btn_kasir As Button
    Friend WithEvents btn_perawat As Button
    Friend WithEvents btn_dokter As Button
    Friend WithEvents btn_beranda As Button
    Friend WithEvents Pn_title As Panel
End Class
