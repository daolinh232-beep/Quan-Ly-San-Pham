<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainBanHang
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
        cboSanPham = New ComboBox()
        Label1 = New Label()
        txtSLBan = New TextBox()
        lvHoaDon = New ListView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnThemBanHang = New Button()
        btnXoaBanHang = New Button()
        btnLuuBanHang = New Button()
        txtTongTien = New TextBox()
        dtpNgayBan = New DateTimePicker()
        Label5 = New Label()
        btnThongKe = New Button()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' cboSanPham
        ' 
        cboSanPham.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        cboSanPham.FormattingEnabled = True
        cboSanPham.Location = New Point(348, 85)
        cboSanPham.Name = "cboSanPham"
        cboSanPham.Size = New Size(260, 45)
        cboSanPham.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(171, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 38)
        Label1.TabIndex = 1
        Label1.Text = "Số Lượng"
        ' 
        ' txtSLBan
        ' 
        txtSLBan.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        txtSLBan.Location = New Point(348, 157)
        txtSLBan.Name = "txtSLBan"
        txtSLBan.Size = New Size(260, 43)
        txtSLBan.TabIndex = 2
        ' 
        ' lvHoaDon
        ' 
        lvHoaDon.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvHoaDon.Location = New Point(649, 34)
        lvHoaDon.Name = "lvHoaDon"
        lvHoaDon.Size = New Size(605, 225)
        lvHoaDon.TabIndex = 3
        lvHoaDon.UseCompatibleStateImageBehavior = False
        lvHoaDon.View = View.Details
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(338, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 38)
        Label2.TabIndex = 1
        Label2.Text = "Tổng Tiền"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(171, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 38)
        Label3.TabIndex = 1
        Label3.Text = "ComboSP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(268, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(296, 60)
        Label4.TabIndex = 1
        Label4.Text = "QL Bán Hàng"
        ' 
        ' btnThemBanHang
        ' 
        btnThemBanHang.Location = New Point(171, 351)
        btnThemBanHang.Name = "btnThemBanHang"
        btnThemBanHang.Size = New Size(158, 66)
        btnThemBanHang.TabIndex = 4
        btnThemBanHang.Text = "Thêm"
        btnThemBanHang.UseVisualStyleBackColor = True
        ' 
        ' btnXoaBanHang
        ' 
        btnXoaBanHang.Location = New Point(385, 351)
        btnXoaBanHang.Name = "btnXoaBanHang"
        btnXoaBanHang.Size = New Size(158, 66)
        btnXoaBanHang.TabIndex = 4
        btnXoaBanHang.Text = "Xóa"
        btnXoaBanHang.UseVisualStyleBackColor = True
        ' 
        ' btnLuuBanHang
        ' 
        btnLuuBanHang.Location = New Point(621, 351)
        btnLuuBanHang.Name = "btnLuuBanHang"
        btnLuuBanHang.Size = New Size(158, 66)
        btnLuuBanHang.TabIndex = 4
        btnLuuBanHang.Text = "Lưu"
        btnLuuBanHang.UseVisualStyleBackColor = True
        ' 
        ' txtTongTien
        ' 
        txtTongTien.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        txtTongTien.Location = New Point(492, 283)
        txtTongTien.Name = "txtTongTien"
        txtTongTien.Size = New Size(274, 43)
        txtTongTien.TabIndex = 2
        ' 
        ' dtpNgayBan
        ' 
        dtpNgayBan.Location = New Point(348, 232)
        dtpNgayBan.Name = "dtpNgayBan"
        dtpNgayBan.Size = New Size(260, 27)
        dtpNgayBan.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label5.Location = New Point(171, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 38)
        Label5.TabIndex = 1
        Label5.Text = "Ngày Bán"
        ' 
        ' btnThongKe
        ' 
        btnThongKe.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnThongKe.Location = New Point(931, 326)
        btnThongKe.Name = "btnThongKe"
        btnThongKe.Size = New Size(244, 102)
        btnThongKe.TabIndex = 6
        btnThongKe.Text = "MainThongKe"
        btnThongKe.UseVisualStyleBackColor = True
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Mã SP"
        ColumnHeader1.Width = 80
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Tên SP"
        ColumnHeader2.Width = 130
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Size"
        ColumnHeader3.Width = 70
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Màu"
        ColumnHeader4.Width = 70
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Giá"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "SL"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Thành tiền"
        ColumnHeader7.Width = 100
        ' 
        ' MainBanHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1305, 495)
        Controls.Add(btnThongKe)
        Controls.Add(dtpNgayBan)
        Controls.Add(btnLuuBanHang)
        Controls.Add(btnXoaBanHang)
        Controls.Add(btnThemBanHang)
        Controls.Add(lvHoaDon)
        Controls.Add(txtTongTien)
        Controls.Add(txtSLBan)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(cboSanPham)
        Name = "MainBanHang"
        Text = "MainBanHang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboSanPham As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSLBan As TextBox
    Friend WithEvents lvHoaDon As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnThemBanHang As Button
    Friend WithEvents btnXoaBanHang As Button
    Friend WithEvents btnLuuBanHang As Button
    Friend WithEvents txtTongTien As TextBox
    Friend WithEvents dtpNgayBan As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThongKe As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
