<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pwt_periksa
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
        Me.DGV_periksa = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_alamat_periksa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_resep_periksa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_diagnosa_periksa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_periksa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_no_antrean = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RD_perempuan = New System.Windows.Forms.RadioButton()
        Me.RD_laki = New System.Windows.Forms.RadioButton()
        Me.txt_id_periksa = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_keterangan_periksa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_dokter = New System.Windows.Forms.ComboBox()
        Me.txt_telepon_periksa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_tanggal_pemeriksaan = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV_periksa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_periksa
        '
        Me.DGV_periksa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_periksa.Location = New System.Drawing.Point(117, 558)
        Me.DGV_periksa.Name = "DGV_periksa"
        Me.DGV_periksa.RowHeadersWidth = 51
        Me.DGV_periksa.RowTemplate.Height = 24
        Me.DGV_periksa.Size = New System.Drawing.Size(604, 150)
        Me.DGV_periksa.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(386, 512)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(181, 22)
        Me.txt_cari.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 515)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "belum fungsi"
        '
        'txt_alamat_periksa
        '
        Me.txt_alamat_periksa.Location = New System.Drawing.Point(529, 411)
        Me.txt_alamat_periksa.Name = "txt_alamat_periksa"
        Me.txt_alamat_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_alamat_periksa.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(448, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Dokter"
        '
        'txt_resep_periksa
        '
        Me.txt_resep_periksa.Location = New System.Drawing.Point(529, 313)
        Me.txt_resep_periksa.Name = "txt_resep_periksa"
        Me.txt_resep_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_resep_periksa.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Resep"
        '
        'txt_diagnosa_periksa
        '
        Me.txt_diagnosa_periksa.Location = New System.Drawing.Point(529, 262)
        Me.txt_diagnosa_periksa.Name = "txt_diagnosa_periksa"
        Me.txt_diagnosa_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_diagnosa_periksa.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Diagnosa"
        '
        'txt_nama_periksa
        '
        Me.txt_nama_periksa.Location = New System.Drawing.Point(225, 360)
        Me.txt_nama_periksa.Name = "txt_nama_periksa"
        Me.txt_nama_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_nama_periksa.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Nama Pasien"
        '
        'txt_no_antrean
        '
        Me.txt_no_antrean.Location = New System.Drawing.Point(225, 310)
        Me.txt_no_antrean.Name = "txt_no_antrean"
        Me.txt_no_antrean.Size = New System.Drawing.Size(181, 22)
        Me.txt_no_antrean.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "No Antrean"
        '
        'RD_perempuan
        '
        Me.RD_perempuan.AutoSize = True
        Me.RD_perempuan.Location = New System.Drawing.Point(309, 458)
        Me.RD_perempuan.Name = "RD_perempuan"
        Me.RD_perempuan.Size = New System.Drawing.Size(98, 20)
        Me.RD_perempuan.TabIndex = 80
        Me.RD_perempuan.TabStop = True
        Me.RD_perempuan.Text = "Perempuan"
        Me.RD_perempuan.UseVisualStyleBackColor = True
        '
        'RD_laki
        '
        Me.RD_laki.AutoSize = True
        Me.RD_laki.Location = New System.Drawing.Point(225, 458)
        Me.RD_laki.Name = "RD_laki"
        Me.RD_laki.Size = New System.Drawing.Size(77, 20)
        Me.RD_laki.TabIndex = 79
        Me.RD_laki.TabStop = True
        Me.RD_laki.Text = "Laki laki"
        Me.RD_laki.UseVisualStyleBackColor = True
        '
        'txt_id_periksa
        '
        Me.txt_id_periksa.Location = New System.Drawing.Point(225, 259)
        Me.txt_id_periksa.Name = "txt_id_periksa"
        Me.txt_id_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_id_periksa.TabIndex = 78
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(520, 738)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(97, 36)
        Me.btn_tambah.TabIndex = 77
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(370, 738)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 36)
        Me.btn_edit.TabIndex = 76
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(117, 262)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 74
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(218, 738)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 36)
        Me.btn_delete.TabIndex = 75
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_keterangan_periksa
        '
        Me.txt_keterangan_periksa.Location = New System.Drawing.Point(529, 457)
        Me.txt_keterangan_periksa.Name = "txt_keterangan_periksa"
        Me.txt_keterangan_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_keterangan_periksa.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(448, 460)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Keterangan"
        '
        'cmb_dokter
        '
        Me.cmb_dokter.FormattingEnabled = True
        Me.cmb_dokter.Location = New System.Drawing.Point(529, 363)
        Me.cmb_dokter.Name = "cmb_dokter"
        Me.cmb_dokter.Size = New System.Drawing.Size(181, 24)
        Me.cmb_dokter.TabIndex = 100
        '
        'txt_telepon_periksa
        '
        Me.txt_telepon_periksa.Location = New System.Drawing.Point(226, 411)
        Me.txt_telepon_periksa.Name = "txt_telepon_periksa"
        Me.txt_telepon_periksa.Size = New System.Drawing.Size(181, 22)
        Me.txt_telepon_periksa.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Nomor telepon"
        '
        'dt_tanggal_pemeriksaan
        '
        Me.dt_tanggal_pemeriksaan.Location = New System.Drawing.Point(520, 200)
        Me.dt_tanggal_pemeriksaan.Name = "dt_tanggal_pemeriksaan"
        Me.dt_tanggal_pemeriksaan.Size = New System.Drawing.Size(200, 22)
        Me.dt_tanggal_pemeriksaan.TabIndex = 103
        '
        'pwt_periksa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dt_tanggal_pemeriksaan)
        Me.Controls.Add(Me.txt_telepon_periksa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmb_dokter)
        Me.Controls.Add(Me.txt_keterangan_periksa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGV_periksa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_alamat_periksa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_resep_periksa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_diagnosa_periksa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nama_periksa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_no_antrean)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RD_perempuan)
        Me.Controls.Add(Me.RD_laki)
        Me.Controls.Add(Me.txt_id_periksa)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Controls.Add(Me.btn_delete)
        Me.Name = "pwt_periksa"
        Me.Size = New System.Drawing.Size(850, 804)
        CType(Me.DGV_periksa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_periksa As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_alamat_periksa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_resep_periksa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_diagnosa_periksa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nama_periksa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_no_antrean As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RD_perempuan As RadioButton
    Friend WithEvents RD_laki As RadioButton
    Friend WithEvents txt_id_periksa As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_keterangan_periksa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_dokter As ComboBox
    Friend WithEvents txt_telepon_periksa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dt_tanggal_pemeriksaan As DateTimePicker
End Class
