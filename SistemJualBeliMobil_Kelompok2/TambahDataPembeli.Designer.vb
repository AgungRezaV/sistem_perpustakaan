﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahDataPembeli
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
        Me.ButtonTambahData = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBoxTambh = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ButtonTambahData
        '
        Me.ButtonTambahData.Location = New System.Drawing.Point(95, 243)
        Me.ButtonTambahData.Name = "ButtonTambahData"
        Me.ButtonTambahData.Size = New System.Drawing.Size(112, 23)
        Me.ButtonTambahData.TabIndex = 37
        Me.ButtonTambahData.Text = "Tambah Data"
        Me.ButtonTambahData.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 28)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Edit Data Pembeli"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(111, 113)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxNama.TabIndex = 34
        '
        'TextBoxNik
        '
        Me.TextBoxNik.Location = New System.Drawing.Point(111, 75)
        Me.TextBoxNik.Name = "TextBoxNik"
        Me.TextBoxNik.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxNik.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 21)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "NIK"
        '
        'RichTextBoxTambh
        '
        Me.RichTextBoxTambh.Location = New System.Drawing.Point(111, 141)
        Me.RichTextBoxTambh.Name = "RichTextBoxTambh"
        Me.RichTextBoxTambh.Size = New System.Drawing.Size(127, 96)
        Me.RichTextBoxTambh.TabIndex = 38
        Me.RichTextBoxTambh.Text = ""
        '
        'TambahDataPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 290)
        Me.Controls.Add(Me.RichTextBoxTambh)
        Me.Controls.Add(Me.ButtonTambahData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxNik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahDataPembeli"
        Me.Text = "TambahDataPembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonTambahData As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNik As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBoxTambh As RichTextBox
End Class
