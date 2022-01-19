<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusMobil
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
        Me.BtnHapusKoleksi = New System.Windows.Forms.Button()
        Me.LbNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapusKoleksi
        '
        Me.BtnHapusKoleksi.BackColor = System.Drawing.Color.Red
        Me.BtnHapusKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusKoleksi.ForeColor = System.Drawing.Color.White
        Me.BtnHapusKoleksi.Location = New System.Drawing.Point(112, 161)
        Me.BtnHapusKoleksi.Name = "BtnHapusKoleksi"
        Me.BtnHapusKoleksi.Size = New System.Drawing.Size(104, 36)
        Me.BtnHapusKoleksi.TabIndex = 8
        Me.BtnHapusKoleksi.Text = "Hapus"
        Me.BtnHapusKoleksi.UseVisualStyleBackColor = False
        '
        'LbNama
        '
        Me.LbNama.AutoSize = True
        Me.LbNama.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbNama.Location = New System.Drawing.Point(112, 79)
        Me.LbNama.Name = "LbNama"
        Me.LbNama.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbNama.Size = New System.Drawing.Size(110, 45)
        Me.LbNama.TabIndex = 7
        Me.LbNama.Text = "Mobil"
        Me.LbNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(52, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Apakah Ingin Menghapus"
        '
        'HapusMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 244)
        Me.Controls.Add(Me.BtnHapusKoleksi)
        Me.Controls.Add(Me.LbNama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusMobil"
        Me.Text = "HapusMobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapusKoleksi As Button
    Friend WithEvents LbNama As Label
    Friend WithEvents Label1 As Label
End Class
