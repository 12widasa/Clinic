<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_kasir
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
        Me.DGV_kasir = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_gaji = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_usertype_kasir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_telepon_kasir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat_kasir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_password_kasir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username_kasir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RD_perempuan = New System.Windows.Forms.RadioButton()
        Me.RD_laki = New System.Windows.Forms.RadioButton()
        Me.txt_id_kasir = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.DGV_kasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_kasir
        '
        Me.DGV_kasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_kasir.Location = New System.Drawing.Point(111, 442)
        Me.DGV_kasir.Name = "DGV_kasir"
        Me.DGV_kasir.RowHeadersWidth = 51
        Me.DGV_kasir.RowTemplate.Height = 24
        Me.DGV_kasir.Size = New System.Drawing.Size(604, 150)
        Me.DGV_kasir.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(108, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(366, 402)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(181, 22)
        Me.txt_cari.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(295, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Cari"
        '
        'txt_gaji
        '
        Me.txt_gaji.Location = New System.Drawing.Point(520, 338)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.Size = New System.Drawing.Size(181, 22)
        Me.txt_gaji.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Gaji"
        '
        'txt_usertype_kasir
        '
        Me.txt_usertype_kasir.Location = New System.Drawing.Point(520, 290)
        Me.txt_usertype_kasir.Name = "txt_usertype_kasir"
        Me.txt_usertype_kasir.ReadOnly = True
        Me.txt_usertype_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_usertype_kasir.TabIndex = 44
        Me.txt_usertype_kasir.Text = "kasir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(439, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "User type"
        '
        'txt_telepon_kasir
        '
        Me.txt_telepon_kasir.Location = New System.Drawing.Point(520, 240)
        Me.txt_telepon_kasir.Name = "txt_telepon_kasir"
        Me.txt_telepon_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_telepon_kasir.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Telepon"
        '
        'txt_alamat_kasir
        '
        Me.txt_alamat_kasir.Location = New System.Drawing.Point(520, 189)
        Me.txt_alamat_kasir.Name = "txt_alamat_kasir"
        Me.txt_alamat_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_alamat_kasir.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Alamat"
        '
        'txt_password_kasir
        '
        Me.txt_password_kasir.Location = New System.Drawing.Point(216, 287)
        Me.txt_password_kasir.Name = "txt_password_kasir"
        Me.txt_password_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_password_kasir.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Password"
        '
        'txt_username_kasir
        '
        Me.txt_username_kasir.Location = New System.Drawing.Point(216, 237)
        Me.txt_username_kasir.Name = "txt_username_kasir"
        Me.txt_username_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_username_kasir.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Username"
        '
        'RD_perempuan
        '
        Me.RD_perempuan.AutoSize = True
        Me.RD_perempuan.Location = New System.Drawing.Point(300, 340)
        Me.RD_perempuan.Name = "RD_perempuan"
        Me.RD_perempuan.Size = New System.Drawing.Size(98, 20)
        Me.RD_perempuan.TabIndex = 34
        Me.RD_perempuan.TabStop = True
        Me.RD_perempuan.Text = "Perempuan"
        Me.RD_perempuan.UseVisualStyleBackColor = True
        '
        'RD_laki
        '
        Me.RD_laki.AutoSize = True
        Me.RD_laki.Location = New System.Drawing.Point(216, 340)
        Me.RD_laki.Name = "RD_laki"
        Me.RD_laki.Size = New System.Drawing.Size(77, 20)
        Me.RD_laki.TabIndex = 33
        Me.RD_laki.TabStop = True
        Me.RD_laki.Text = "Laki laki"
        Me.RD_laki.UseVisualStyleBackColor = True
        '
        'txt_id_kasir
        '
        Me.txt_id_kasir.Location = New System.Drawing.Point(216, 186)
        Me.txt_id_kasir.Name = "txt_id_kasir"
        Me.txt_id_kasir.Size = New System.Drawing.Size(181, 22)
        Me.txt_id_kasir.TabIndex = 32
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(514, 622)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(97, 36)
        Me.btn_tambah.TabIndex = 31
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(364, 622)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 36)
        Me.btn_edit.TabIndex = 30
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(108, 189)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 28
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(212, 622)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(97, 36)
        Me.btn_delete.TabIndex = 29
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'adm_kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Controls.Add(Me.DGV_kasir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_gaji)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_usertype_kasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_telepon_kasir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_alamat_kasir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_password_kasir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_username_kasir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RD_perempuan)
        Me.Controls.Add(Me.RD_laki)
        Me.Controls.Add(Me.txt_id_kasir)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Controls.Add(Me.btn_delete)
        Me.Name = "adm_kasir"
        Me.Size = New System.Drawing.Size(850, 700)
        CType(Me.DGV_kasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_kasir As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_gaji As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_usertype_kasir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telepon_kasir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_kasir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_password_kasir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username_kasir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RD_perempuan As RadioButton
    Friend WithEvents RD_laki As RadioButton
    Friend WithEvents txt_id_kasir As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_delete As Button
End Class
