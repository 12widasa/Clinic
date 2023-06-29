<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_obat
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
        Me.DGV_obat = New System.Windows.Forms.DataGridView()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_harga_obat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_types = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_obat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id_obat = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_nama_admin = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        CType(Me.DGV_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_obat
        '
        Me.DGV_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_obat.Location = New System.Drawing.Point(118, 458)
        Me.DGV_obat.Name = "DGV_obat"
        Me.DGV_obat.RowHeadersWidth = 51
        Me.DGV_obat.RowTemplate.Height = 24
        Me.DGV_obat.Size = New System.Drawing.Size(604, 150)
        Me.DGV_obat.TabIndex = 96
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(376, 292)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(181, 22)
        Me.txt_cari.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Cari"
        '
        'txt_harga_obat
        '
        Me.txt_harga_obat.Location = New System.Drawing.Point(521, 395)
        Me.txt_harga_obat.Name = "txt_harga_obat"
        Me.txt_harga_obat.Size = New System.Drawing.Size(181, 22)
        Me.txt_harga_obat.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Harga"
        '
        'txt_types
        '
        Me.txt_types.Location = New System.Drawing.Point(521, 344)
        Me.txt_types.Name = "txt_types"
        Me.txt_types.Size = New System.Drawing.Size(181, 22)
        Me.txt_types.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(440, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Tipe"
        '
        'txt_obat
        '
        Me.txt_obat.Location = New System.Drawing.Point(217, 392)
        Me.txt_obat.Name = "txt_obat"
        Me.txt_obat.Size = New System.Drawing.Size(181, 22)
        Me.txt_obat.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Nama Obat"
        '
        'txt_id_obat
        '
        Me.txt_id_obat.Location = New System.Drawing.Point(217, 341)
        Me.txt_id_obat.Name = "txt_id_obat"
        Me.txt_id_obat.Size = New System.Drawing.Size(181, 22)
        Me.txt_id_obat.TabIndex = 78
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(521, 638)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(97, 36)
        Me.btn_tambah.TabIndex = 77
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(371, 638)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(97, 36)
        Me.btn_edit.TabIndex = 76
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'lbl_nama_admin
        '
        Me.lbl_nama_admin.AutoSize = True
        Me.lbl_nama_admin.Location = New System.Drawing.Point(109, 344)
        Me.lbl_nama_admin.Name = "lbl_nama_admin"
        Me.lbl_nama_admin.Size = New System.Drawing.Size(20, 16)
        Me.lbl_nama_admin.TabIndex = 74
        Me.lbl_nama_admin.Text = "ID"
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(219, 638)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(97, 36)
        Me.btn_hapus.TabIndex = 75
        Me.btn_hapus.Text = "Delete"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'list_obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGV_obat)
        Me.Controls.Add(Me.txt_cari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_harga_obat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_types)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_obat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id_obat)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_nama_admin)
        Me.Controls.Add(Me.btn_hapus)
        Me.Name = "list_obat"
        Me.Size = New System.Drawing.Size(850, 700)
        CType(Me.DGV_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_obat As DataGridView
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_harga_obat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_types As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_obat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_obat As TextBox
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents lbl_nama_admin As Label
    Friend WithEvents btn_hapus As Button
End Class
