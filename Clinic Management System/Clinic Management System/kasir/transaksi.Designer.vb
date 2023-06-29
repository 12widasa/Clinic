<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
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
        Me.txt_no_antrean = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_diagnosa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nama_pasien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_pasien = New System.Windows.Forms.TextBox()
        Me.btn_bayar = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total_transaksi = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_tambahan = New System.Windows.Forms.ComboBox()
        CType(Me.DGV_kasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_kasir
        '
        Me.DGV_kasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_kasir.Location = New System.Drawing.Point(115, 465)
        Me.DGV_kasir.Name = "DGV_kasir"
        Me.DGV_kasir.RowHeadersWidth = 51
        Me.DGV_kasir.RowTemplate.Height = 24
        Me.DGV_kasir.Size = New System.Drawing.Size(604, 150)
        Me.DGV_kasir.TabIndex = 110
        '
        'txt_no_antrean
        '
        Me.txt_no_antrean.Location = New System.Drawing.Point(338, 215)
        Me.txt_no_antrean.Name = "txt_no_antrean"
        Me.txt_no_antrean.Size = New System.Drawing.Size(181, 22)
        Me.txt_no_antrean.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(243, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Cari Pasien"
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(560, 330)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(159, 22)
        Me.txt_alamat.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Alamat"
        '
        'txt_diagnosa
        '
        Me.txt_diagnosa.Location = New System.Drawing.Point(560, 279)
        Me.txt_diagnosa.Name = "txt_diagnosa"
        Me.txt_diagnosa.Size = New System.Drawing.Size(159, 22)
        Me.txt_diagnosa.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Diagnosa"
        '
        'txt_nama_pasien
        '
        Me.txt_nama_pasien.Location = New System.Drawing.Point(220, 327)
        Me.txt_nama_pasien.Name = "txt_nama_pasien"
        Me.txt_nama_pasien.Size = New System.Drawing.Size(163, 22)
        Me.txt_nama_pasien.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Nama Pasien"
        '
        'txt_id_pasien
        '
        Me.txt_id_pasien.Location = New System.Drawing.Point(220, 276)
        Me.txt_id_pasien.Name = "txt_id_pasien"
        Me.txt_id_pasien.Size = New System.Drawing.Size(163, 22)
        Me.txt_id_pasien.TabIndex = 101
        '
        'btn_bayar
        '
        Me.btn_bayar.Location = New System.Drawing.Point(594, 639)
        Me.btn_bayar.Name = "btn_bayar"
        Me.btn_bayar.Size = New System.Drawing.Size(97, 36)
        Me.btn_bayar.TabIndex = 100
        Me.btn_bayar.Text = "Bayar"
        Me.btn_bayar.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(476, 639)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(97, 36)
        Me.btn_clear.TabIndex = 99
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(112, 279)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 97
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(542, 212)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(94, 29)
        Me.btn_cari.TabIndex = 111
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Total"
        '
        'lbl_total_transaksi
        '
        Me.lbl_total_transaksi.AutoSize = True
        Me.lbl_total_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_transaksi.Location = New System.Drawing.Point(239, 405)
        Me.lbl_total_transaksi.Name = "lbl_total_transaksi"
        Me.lbl_total_transaksi.Size = New System.Drawing.Size(59, 38)
        Me.lbl_total_transaksi.TabIndex = 113
        Me.lbl_total_transaksi.Text = "Rp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Biaya Tambahan"
        '
        'cmb_tambahan
        '
        Me.cmb_tambahan.FormattingEnabled = True
        Me.cmb_tambahan.Location = New System.Drawing.Point(560, 380)
        Me.cmb_tambahan.Name = "cmb_tambahan"
        Me.cmb_tambahan.Size = New System.Drawing.Size(159, 24)
        Me.cmb_tambahan.TabIndex = 115
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmb_tambahan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_total_transaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cari)
        Me.Controls.Add(Me.DGV_kasir)
        Me.Controls.Add(Me.txt_no_antrean)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_diagnosa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_nama_pasien)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id_pasien)
        Me.Controls.Add(Me.btn_bayar)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Name = "transaksi"
        Me.Size = New System.Drawing.Size(850, 700)
        CType(Me.DGV_kasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_kasir As DataGridView
    Friend WithEvents txt_no_antrean As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_diagnosa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nama_pasien As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_pasien As TextBox
    Friend WithEvents btn_bayar As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_cari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_total_transaksi As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_tambahan As ComboBox
End Class
