<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_perawat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DGV_perawat = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_gaji = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_usertype_perawat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telepon_perawat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat_perawat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_password_perawat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username_perawat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RD_pwt_perempuan = New System.Windows.Forms.RadioButton()
        Me.RD_pwt_laki = New System.Windows.Forms.RadioButton()
        Me.txt_id_perawat = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.DGV_perawat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_perawat
        '
        Me.DGV_perawat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_perawat.Location = New System.Drawing.Point(114, 452)
        Me.DGV_perawat.Name = "DGV_perawat"
        Me.DGV_perawat.RowHeadersWidth = 51
        Me.DGV_perawat.RowTemplate.Height = 24
        Me.DGV_perawat.Size = New System.Drawing.Size(604, 150)
        Me.DGV_perawat.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(369, 412)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(181, 22)
        Me.txt_cari.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Cari"
        '
        'txt_gaji
        '
        Me.txt_gaji.Location = New System.Drawing.Point(523, 348)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.Size = New System.Drawing.Size(181, 22)
        Me.txt_gaji.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Gaji"
        '
        'txt_usertype_perawat
        '
        Me.txt_usertype_perawat.Location = New System.Drawing.Point(523, 300)
        Me.txt_usertype_perawat.Name = "txt_usertype_perawat"
        Me.txt_usertype_perawat.ReadOnly = True
        Me.txt_usertype_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_usertype_perawat.TabIndex = 67
        Me.txt_usertype_perawat.Text = "perawat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "User type"
        '
        'txt_telepon_perawat
        '
        Me.txt_telepon_perawat.Location = New System.Drawing.Point(523, 250)
        Me.txt_telepon_perawat.Name = "txt_telepon_perawat"
        Me.txt_telepon_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_telepon_perawat.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Telepon"
        '
        'txt_alamat_perawat
        '
        Me.txt_alamat_perawat.Location = New System.Drawing.Point(523, 199)
        Me.txt_alamat_perawat.Name = "txt_alamat_perawat"
        Me.txt_alamat_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_alamat_perawat.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Alamat"
        '
        'txt_password_perawat
        '
        Me.txt_password_perawat.Location = New System.Drawing.Point(219, 297)
        Me.txt_password_perawat.Name = "txt_password_perawat"
        Me.txt_password_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_password_perawat.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Password"
        '
        'txt_username_perawat
        '
        Me.txt_username_perawat.Location = New System.Drawing.Point(219, 247)
        Me.txt_username_perawat.Name = "txt_username_perawat"
        Me.txt_username_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_username_perawat.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Username"
        '
        'RD_pwt_perempuan
        '
        Me.RD_pwt_perempuan.AutoSize = True
        Me.RD_pwt_perempuan.Location = New System.Drawing.Point(303, 350)
        Me.RD_pwt_perempuan.Name = "RD_pwt_perempuan"
        Me.RD_pwt_perempuan.Size = New System.Drawing.Size(98, 20)
        Me.RD_pwt_perempuan.TabIndex = 57
        Me.RD_pwt_perempuan.TabStop = True
        Me.RD_pwt_perempuan.Text = "Perempuan"
        Me.RD_pwt_perempuan.UseVisualStyleBackColor = True
        '
        'RD_pwt_laki
        '
        Me.RD_pwt_laki.AutoSize = True
        Me.RD_pwt_laki.Location = New System.Drawing.Point(219, 350)
        Me.RD_pwt_laki.Name = "RD_pwt_laki"
        Me.RD_pwt_laki.Size = New System.Drawing.Size(77, 20)
        Me.RD_pwt_laki.TabIndex = 56
        Me.RD_pwt_laki.TabStop = True
        Me.RD_pwt_laki.Text = "Laki laki"
        Me.RD_pwt_laki.UseVisualStyleBackColor = True
        '
        'txt_id_perawat
        '
        Me.txt_id_perawat.Location = New System.Drawing.Point(219, 196)
        Me.txt_id_perawat.Name = "txt_id_perawat"
        Me.txt_id_perawat.Size = New System.Drawing.Size(181, 22)
        Me.txt_id_perawat.TabIndex = 55
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(517, 632)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(97, 36)
        Me.btn_tambah.TabIndex = 54
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(367, 632)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 36)
        Me.btn_edit.TabIndex = 53
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(111, 199)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 51
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(215, 632)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 36)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'adm_perawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.DGV_perawat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_gaji)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_usertype_perawat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_telepon_perawat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_alamat_perawat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_password_perawat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_username_perawat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RD_pwt_perempuan)
        Me.Controls.Add(Me.RD_pwt_laki)
        Me.Controls.Add(Me.txt_id_perawat)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Controls.Add(Me.btn_delete)
        Me.Name = "adm_perawat"
        Me.Size = New System.Drawing.Size(850, 700)
        CType(Me.DGV_perawat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_perawat As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_gaji As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_usertype_perawat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telepon_perawat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_perawat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_password_perawat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username_perawat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RD_pwt_perempuan As RadioButton
    Friend WithEvents RD_pwt_laki As RadioButton
    Friend WithEvents txt_id_perawat As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_delete As Button
End Class
