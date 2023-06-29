<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Pn_button_title = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_list_obat = New System.Windows.Forms.Button()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.Pn_title = New System.Windows.Forms.Panel()
        Me.lbl_id_kasir = New System.Windows.Forms.Label()
        Me.lbl_nama_kasir = New System.Windows.Forms.Label()
        Me.Pn_button_title.SuspendLayout()
        Me.Pn_title.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pn_button_title
        '
        Me.Pn_button_title.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Pn_button_title.Controls.Add(Me.Button1)
        Me.Pn_button_title.Controls.Add(Me.btn_list_obat)
        Me.Pn_button_title.Controls.Add(Me.btn_transaksi)
        Me.Pn_button_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_button_title.Location = New System.Drawing.Point(0, 68)
        Me.Pn_button_title.Name = "Pn_button_title"
        Me.Pn_button_title.Size = New System.Drawing.Size(832, 80)
        Me.Pn_button_title.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "List Transaksi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_list_obat
        '
        Me.btn_list_obat.Location = New System.Drawing.Point(153, 26)
        Me.btn_list_obat.Name = "btn_list_obat"
        Me.btn_list_obat.Size = New System.Drawing.Size(97, 36)
        Me.btn_list_obat.TabIndex = 5
        Me.btn_list_obat.Text = "List Obat"
        Me.btn_list_obat.UseVisualStyleBackColor = True
        '
        'btn_transaksi
        '
        Me.btn_transaksi.Location = New System.Drawing.Point(30, 26)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(97, 36)
        Me.btn_transaksi.TabIndex = 4
        Me.btn_transaksi.Text = "Transaksi"
        Me.btn_transaksi.UseVisualStyleBackColor = True
        '
        'Pn_title
        '
        Me.Pn_title.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pn_title.Controls.Add(Me.lbl_id_kasir)
        Me.Pn_title.Controls.Add(Me.lbl_nama_kasir)
        Me.Pn_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_title.Location = New System.Drawing.Point(0, 0)
        Me.Pn_title.Name = "Pn_title"
        Me.Pn_title.Size = New System.Drawing.Size(832, 68)
        Me.Pn_title.TabIndex = 6
        '
        'lbl_id_kasir
        '
        Me.lbl_id_kasir.AutoSize = True
        Me.lbl_id_kasir.Location = New System.Drawing.Point(146, 26)
        Me.lbl_id_kasir.Name = "lbl_id_kasir"
        Me.lbl_id_kasir.Size = New System.Drawing.Size(20, 16)
        Me.lbl_id_kasir.TabIndex = 1
        Me.lbl_id_kasir.Text = "ID"
        '
        'lbl_nama_kasir
        '
        Me.lbl_nama_kasir.AutoSize = True
        Me.lbl_nama_kasir.Location = New System.Drawing.Point(27, 26)
        Me.lbl_nama_kasir.Name = "lbl_nama_kasir"
        Me.lbl_nama_kasir.Size = New System.Drawing.Size(37, 16)
        Me.lbl_nama_kasir.TabIndex = 0
        Me.lbl_nama_kasir.Text = "Kasir"
        '
        'kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 653)
        Me.Controls.Add(Me.Pn_button_title)
        Me.Controls.Add(Me.Pn_title)
        Me.Name = "kasir"
        Me.Text = "kasir"
        Me.Pn_button_title.ResumeLayout(False)
        Me.Pn_title.ResumeLayout(False)
        Me.Pn_title.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pn_button_title As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_list_obat As Button
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents Pn_title As Panel
    Friend WithEvents lbl_nama_kasir As Label
    Friend WithEvents lbl_id_kasir As Label
End Class
