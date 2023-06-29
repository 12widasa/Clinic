<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_dokter
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
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_id_dokter = New System.Windows.Forms.TextBox()
        Me.RD_dkt_laki = New System.Windows.Forms.RadioButton()
        Me.RD_dkt_perempuan = New System.Windows.Forms.RadioButton()
        Me.txt_nama_dokter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_spesialisasi_dokter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usertype_dokter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telepon_dokter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat_dokter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_gaji = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV_dokter = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_dokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(104, 193)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 5
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(208, 626)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 36)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(360, 626)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 36)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(510, 626)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(97, 36)
        Me.btn_tambah.TabIndex = 8
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'txt_id_dokter
        '
        Me.txt_id_dokter.Location = New System.Drawing.Point(212, 190)
        Me.txt_id_dokter.Name = "txt_id_dokter"
        Me.txt_id_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_id_dokter.TabIndex = 9
        '
        'RD_dkt_laki
        '
        Me.RD_dkt_laki.AutoSize = True
        Me.RD_dkt_laki.Location = New System.Drawing.Point(212, 344)
        Me.RD_dkt_laki.Name = "RD_dkt_laki"
        Me.RD_dkt_laki.Size = New System.Drawing.Size(77, 20)
        Me.RD_dkt_laki.TabIndex = 10
        Me.RD_dkt_laki.TabStop = True
        Me.RD_dkt_laki.Text = "Laki laki"
        Me.RD_dkt_laki.UseVisualStyleBackColor = True
        '
        'RD_dkt_perempuan
        '
        Me.RD_dkt_perempuan.AutoSize = True
        Me.RD_dkt_perempuan.Location = New System.Drawing.Point(296, 344)
        Me.RD_dkt_perempuan.Name = "RD_dkt_perempuan"
        Me.RD_dkt_perempuan.Size = New System.Drawing.Size(98, 20)
        Me.RD_dkt_perempuan.TabIndex = 11
        Me.RD_dkt_perempuan.TabStop = True
        Me.RD_dkt_perempuan.Text = "Perempuan"
        Me.RD_dkt_perempuan.UseVisualStyleBackColor = True
        '
        'txt_nama_dokter
        '
        Me.txt_nama_dokter.Location = New System.Drawing.Point(212, 241)
        Me.txt_nama_dokter.Name = "txt_nama_dokter"
        Me.txt_nama_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_nama_dokter.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama"
        '
        'txt_spesialisasi_dokter
        '
        Me.txt_spesialisasi_dokter.Location = New System.Drawing.Point(212, 291)
        Me.txt_spesialisasi_dokter.Name = "txt_spesialisasi_dokter"
        Me.txt_spesialisasi_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_spesialisasi_dokter.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Spesialisasi"
        '
        'txt_usertype_dokter
        '
        Me.txt_usertype_dokter.Location = New System.Drawing.Point(516, 294)
        Me.txt_usertype_dokter.Name = "txt_usertype_dokter"
        Me.txt_usertype_dokter.ReadOnly = True
        Me.txt_usertype_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_usertype_dokter.TabIndex = 21
        Me.txt_usertype_dokter.Text = "dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "User type"
        '
        'txt_telepon_dokter
        '
        Me.txt_telepon_dokter.Location = New System.Drawing.Point(516, 244)
        Me.txt_telepon_dokter.Name = "txt_telepon_dokter"
        Me.txt_telepon_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_telepon_dokter.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Telepon"
        '
        'txt_alamat_dokter
        '
        Me.txt_alamat_dokter.Location = New System.Drawing.Point(516, 193)
        Me.txt_alamat_dokter.Name = "txt_alamat_dokter"
        Me.txt_alamat_dokter.Size = New System.Drawing.Size(181, 22)
        Me.txt_alamat_dokter.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(435, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Alamat"
        '
        'txt_gaji
        '
        Me.txt_gaji.Location = New System.Drawing.Point(516, 342)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.Size = New System.Drawing.Size(181, 22)
        Me.txt_gaji.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(435, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Gaji"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(362, 406)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(181, 22)
        Me.txt_cari.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Jenis Kelamin"
        '
        'DGV_dokter
        '
        Me.DGV_dokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_dokter.Location = New System.Drawing.Point(107, 446)
        Me.DGV_dokter.Name = "DGV_dokter"
        Me.DGV_dokter.RowHeadersWidth = 51
        Me.DGV_dokter.RowTemplate.Height = 24
        Me.DGV_dokter.Size = New System.Drawing.Size(604, 150)
        Me.DGV_dokter.TabIndex = 27
        '
        'adm_dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.DGV_dokter)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_gaji)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_usertype_dokter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_telepon_dokter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_alamat_dokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_spesialisasi_dokter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama_dokter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RD_dkt_perempuan)
        Me.Controls.Add(Me.RD_dkt_laki)
        Me.Controls.Add(Me.txt_id_dokter)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Controls.Add(Me.btn_delete)
        Me.Name = "adm_dokter"
        Me.Size = New System.Drawing.Size(850, 700)
        CType(Me.DGV_dokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_id_dokter As TextBox
    Friend WithEvents RD_dkt_laki As RadioButton
    Friend WithEvents RD_dkt_perempuan As RadioButton
    Friend WithEvents txt_nama_dokter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_spesialisasi_dokter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usertype_dokter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telepon_dokter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_dokter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_gaji As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV_dokter As DataGridView
End Class
