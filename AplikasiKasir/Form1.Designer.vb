<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tot = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.hp = New System.Windows.Forms.Label()
        Me.np = New System.Windows.Forms.Label()
        Me.cbkode = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ds = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.jmh = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bsim = New System.Windows.Forms.Button()
        Me.bclose = New System.Windows.Forms.Button()
        Me.bres = New System.Windows.Forms.Button()
        Me.bpro = New System.Windows.Forms.Button()
        Me.jm = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 69)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tot)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(103, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(719, 69)
        Me.Panel2.TabIndex = 1
        '
        'tot
        '
        Me.tot.AutoSize = True
        Me.tot.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.tot.Location = New System.Drawing.Point(471, 5)
        Me.tot.Name = "tot"
        Me.tot.Size = New System.Drawing.Size(44, 58)
        Me.tot.TabIndex = 1
        Me.tot.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(302, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL Rp."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.jm)
        Me.Panel3.Controls.Add(Me.RadioButton3)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.hp)
        Me.Panel3.Controls.Add(Me.np)
        Me.Panel3.Controls.Add(Me.cbkode)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(12, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(381, 363)
        Me.Panel3.TabIndex = 2
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(278, 300)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(50, 19)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "10 %"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(217, 300)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(44, 19)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "5 %"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(158, 300)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 19)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "0 %"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'hp
        '
        Me.hp.AutoSize = True
        Me.hp.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.hp.Location = New System.Drawing.Point(158, 158)
        Me.hp.Name = "hp"
        Me.hp.Size = New System.Drawing.Size(24, 30)
        Me.hp.TabIndex = 7
        Me.hp.Text = "0"
        '
        'np
        '
        Me.np.AutoSize = True
        Me.np.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.np.Location = New System.Drawing.Point(158, 87)
        Me.np.Name = "np"
        Me.np.Size = New System.Drawing.Size(214, 30)
        Me.np.TabIndex = 6
        Me.np.Text = "Contoh Nama Produk"
        '
        'cbkode
        '
        Me.cbkode.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cbkode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbkode.FormattingEnabled = True
        Me.cbkode.Location = New System.Drawing.Point(158, 27)
        Me.cbkode.Name = "cbkode"
        Me.cbkode.Size = New System.Drawing.Size(151, 23)
        Me.cbkode.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(6, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(6, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Harga Rp."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Produk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Produk"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ds)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.jmh)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(399, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(423, 188)
        Me.Panel4.TabIndex = 3
        '
        'ds
        '
        Me.ds.AutoSize = True
        Me.ds.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ds.Location = New System.Drawing.Point(189, 88)
        Me.ds.Name = "ds"
        Me.ds.Size = New System.Drawing.Size(24, 30)
        Me.ds.TabIndex = 11
        Me.ds.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(6, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 30)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Diskon Harga Rp."
        '
        'jmh
        '
        Me.jmh.AutoSize = True
        Me.jmh.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.jmh.Location = New System.Drawing.Point(189, 21)
        Me.jmh.Name = "jmh"
        Me.jmh.Size = New System.Drawing.Size(24, 30)
        Me.jmh.TabIndex = 9
        Me.jmh.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(6, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 30)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Jumlah Harga Rp."
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.bsim)
        Me.Panel5.Controls.Add(Me.bclose)
        Me.Panel5.Controls.Add(Me.bres)
        Me.Panel5.Controls.Add(Me.bpro)
        Me.Panel5.Location = New System.Drawing.Point(399, 282)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(423, 168)
        Me.Panel5.TabIndex = 4
        '
        'bsim
        '
        Me.bsim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.bsim.FlatAppearance.BorderSize = 0
        Me.bsim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsim.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bsim.Location = New System.Drawing.Point(236, 23)
        Me.bsim.Name = "bsim"
        Me.bsim.Size = New System.Drawing.Size(150, 50)
        Me.bsim.TabIndex = 4
        Me.bsim.Text = "SIMPAN"
        Me.bsim.UseVisualStyleBackColor = False
        '
        'bclose
        '
        Me.bclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.bclose.FlatAppearance.BorderSize = 0
        Me.bclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclose.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bclose.Location = New System.Drawing.Point(236, 79)
        Me.bclose.Name = "bclose"
        Me.bclose.Size = New System.Drawing.Size(150, 50)
        Me.bclose.TabIndex = 2
        Me.bclose.Text = "TUTUP"
        Me.bclose.UseVisualStyleBackColor = False
        '
        'bres
        '
        Me.bres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bres.FlatAppearance.BorderSize = 0
        Me.bres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bres.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bres.Location = New System.Drawing.Point(33, 79)
        Me.bres.Name = "bres"
        Me.bres.Size = New System.Drawing.Size(150, 50)
        Me.bres.TabIndex = 1
        Me.bres.Text = "ULANG"
        Me.bres.UseVisualStyleBackColor = False
        '
        'bpro
        '
        Me.bpro.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.bpro.FlatAppearance.BorderSize = 0
        Me.bpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bpro.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bpro.Location = New System.Drawing.Point(33, 23)
        Me.bpro.Name = "bpro"
        Me.bpro.Size = New System.Drawing.Size(150, 50)
        Me.bpro.TabIndex = 0
        Me.bpro.Text = "PROSES"
        Me.bpro.UseVisualStyleBackColor = False
        '
        'jm
        '
        Me.jm.Location = New System.Drawing.Point(158, 225)
        Me.jm.Name = "jm"
        Me.jm.Size = New System.Drawing.Size(151, 23)
        Me.jm.TabIndex = 12
        '
        'Form1
        '
        Me.AccessibleDescription = "Apps Kasir "
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(834, 461)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tot As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents hp As Label
    Friend WithEvents np As Label
    Friend WithEvents cbkode As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ds As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents jmh As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents bsim As Button
    Friend WithEvents bclose As Button
    Friend WithEvents bres As Button
    Friend WithEvents bpro As Button
    Friend WithEvents jm As TextBox
End Class
