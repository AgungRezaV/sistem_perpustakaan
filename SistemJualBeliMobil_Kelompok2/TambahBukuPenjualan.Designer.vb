﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBukuPenjualan
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
        Me.LblTmbhBuku = New System.Windows.Forms.Label()
        Me.LblMobilID = New System.Windows.Forms.Label()
        Me.LblHargaTerjual = New System.Windows.Forms.Label()
        Me.LblPembeliID = New System.Windows.Forms.Label()
        Me.LblTanggalJual = New System.Windows.Forms.Label()
        Me.TextBoxMobilTerjual = New System.Windows.Forms.TextBox()
        Me.TextBoxMerekMobil = New System.Windows.Forms.TextBox()
        Me.TxtBoxHargaTerjual = New System.Windows.Forms.TextBox()
        Me.DateTimePickerJual = New System.Windows.Forms.DateTimePicker()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTmbhBuku
        '
        Me.LblTmbhBuku.AutoSize = True
        Me.LblTmbhBuku.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTmbhBuku.Location = New System.Drawing.Point(99, 24)
        Me.LblTmbhBuku.Name = "LblTmbhBuku"
        Me.LblTmbhBuku.Size = New System.Drawing.Size(227, 30)
        Me.LblTmbhBuku.TabIndex = 1
        Me.LblTmbhBuku.Text = "Tambah Buku Penjualan"
        '
        'LblMobilID
        '
        Me.LblMobilID.AutoSize = True
        Me.LblMobilID.Location = New System.Drawing.Point(19, 80)
        Me.LblMobilID.Name = "LblMobilID"
        Me.LblMobilID.Size = New System.Drawing.Size(81, 13)
        Me.LblMobilID.TabIndex = 2
        Me.LblMobilID.Text = "ID Mobil Terjual"
        '
        'LblHargaTerjual
        '
        Me.LblHargaTerjual.AutoSize = True
        Me.LblHargaTerjual.Location = New System.Drawing.Point(19, 155)
        Me.LblHargaTerjual.Name = "LblHargaTerjual"
        Me.LblHargaTerjual.Size = New System.Drawing.Size(71, 13)
        Me.LblHargaTerjual.TabIndex = 6
        Me.LblHargaTerjual.Text = "Harga Terjual"
        '
        'LblPembeliID
        '
        Me.LblPembeliID.AutoSize = True
        Me.LblPembeliID.Location = New System.Drawing.Point(18, 117)
        Me.LblPembeliID.Name = "LblPembeliID"
        Me.LblPembeliID.Size = New System.Drawing.Size(58, 13)
        Me.LblPembeliID.TabIndex = 7
        Me.LblPembeliID.Text = "ID Pembeli"
        '
        'LblTanggalJual
        '
        Me.LblTanggalJual.AutoSize = True
        Me.LblTanggalJual.Location = New System.Drawing.Point(19, 189)
        Me.LblTanggalJual.Name = "LblTanggalJual"
        Me.LblTanggalJual.Size = New System.Drawing.Size(81, 13)
        Me.LblTanggalJual.TabIndex = 8
        Me.LblTanggalJual.Text = "Tanggal Terjual"
        '
        'TextBoxMobilTerjual
        '
        Me.TextBoxMobilTerjual.Location = New System.Drawing.Point(159, 77)
        Me.TextBoxMobilTerjual.Name = "TextBoxMobilTerjual"
        Me.TextBoxMobilTerjual.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxMobilTerjual.TabIndex = 14
        '
        'TextBoxMerekMobil
        '
        Me.TextBoxMerekMobil.Location = New System.Drawing.Point(159, 114)
        Me.TextBoxMerekMobil.Name = "TextBoxMerekMobil"
        Me.TextBoxMerekMobil.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxMerekMobil.TabIndex = 15
        '
        'TxtBoxHargaTerjual
        '
        Me.TxtBoxHargaTerjual.Location = New System.Drawing.Point(159, 152)
        Me.TxtBoxHargaTerjual.Name = "TxtBoxHargaTerjual"
        Me.TxtBoxHargaTerjual.Size = New System.Drawing.Size(250, 20)
        Me.TxtBoxHargaTerjual.TabIndex = 16
        '
        'DateTimePickerJual
        '
        Me.DateTimePickerJual.Location = New System.Drawing.Point(159, 189)
        Me.DateTimePickerJual.Name = "DateTimePickerJual"
        Me.DateTimePickerJual.Size = New System.Drawing.Size(250, 20)
        Me.DateTimePickerJual.TabIndex = 19
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.Location = New System.Drawing.Point(22, 266)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(387, 46)
        Me.ButtonTambah.TabIndex = 23
        Me.ButtonTambah.Text = "Tambah "
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'TambahBukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 367)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DateTimePickerJual)
        Me.Controls.Add(Me.TxtBoxHargaTerjual)
        Me.Controls.Add(Me.TextBoxMerekMobil)
        Me.Controls.Add(Me.TextBoxMobilTerjual)
        Me.Controls.Add(Me.LblTanggalJual)
        Me.Controls.Add(Me.LblPembeliID)
        Me.Controls.Add(Me.LblHargaTerjual)
        Me.Controls.Add(Me.LblMobilID)
        Me.Controls.Add(Me.LblTmbhBuku)
        Me.Name = "TambahBukuPenjualan"
        Me.Text = "TambahBukuPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTmbhBuku As Label
    Friend WithEvents LblMobilID As Label
    Friend WithEvents LblHargaTerjual As Label
    Friend WithEvents LblPembeliID As Label
    Friend WithEvents LblTanggalJual As Label
    Friend WithEvents TextBoxMobilTerjual As TextBox
    Friend WithEvents TextBoxMerekMobil As TextBox
    Friend WithEvents TxtBoxHargaTerjual As TextBox
    Friend WithEvents DateTimePickerJual As DateTimePicker
    Friend WithEvents ButtonTambah As Button
End Class
