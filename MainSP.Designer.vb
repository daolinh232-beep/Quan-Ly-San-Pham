<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainSP
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtTenSP = New TextBox()
        txtSize = New TextBox()
        txtGia = New TextBox()
        txtMau = New TextBox()
        Label6 = New Label()
        txtSoLuong = New TextBox()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        Label7 = New Label()
        txtMaSP = New TextBox()
        lvSanPham = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        btnBanHang = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(248, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 60)
        Label1.TabIndex = 0
        Label1.Text = "QL Sản Phẩm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label2.Location = New Point(91, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 41)
        Label2.TabIndex = 0
        Label2.Text = "Tên SP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label3.Location = New Point(100, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 41)
        Label3.TabIndex = 0
        Label3.Text = "Size"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label4.Location = New Point(100, 312)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 41)
        Label4.TabIndex = 0
        Label4.Text = "Giá"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label5.Location = New Point(100, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 41)
        Label5.TabIndex = 0
        Label5.Text = "Màu"
        ' 
        ' txtTenSP
        ' 
        txtTenSP.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtTenSP.Location = New Point(248, 155)
        txtTenSP.Name = "txtTenSP"
        txtTenSP.Size = New Size(344, 38)
        txtTenSP.TabIndex = 1
        ' 
        ' txtSize
        ' 
        txtSize.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtSize.Location = New Point(248, 208)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(344, 38)
        txtSize.TabIndex = 1
        ' 
        ' txtGia
        ' 
        txtGia.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtGia.Location = New Point(248, 317)
        txtGia.Name = "txtGia"
        txtGia.Size = New Size(344, 38)
        txtGia.TabIndex = 1
        ' 
        ' txtMau
        ' 
        txtMau.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtMau.Location = New Point(248, 257)
        txtMau.Name = "txtMau"
        txtMau.Size = New Size(344, 38)
        txtMau.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label6.Location = New Point(72, 375)
        Label6.Name = "Label6"
        Label6.Size = New Size(152, 41)
        Label6.TabIndex = 0
        Label6.Text = "Số Lượng"
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtSoLuong.Location = New Point(248, 380)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(344, 38)
        txtSoLuong.TabIndex = 1
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(111, 454)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(176, 52)
        btnThem.TabIndex = 2
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(319, 454)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(176, 52)
        btnSua.TabIndex = 2
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(551, 454)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(176, 52)
        btnXoa.TabIndex = 2
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label7.Location = New Point(91, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 41)
        Label7.TabIndex = 0
        Label7.Text = "Mã SP"
        ' 
        ' txtMaSP
        ' 
        txtMaSP.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtMaSP.Location = New Point(248, 91)
        txtMaSP.Name = "txtMaSP"
        txtMaSP.Size = New Size(344, 38)
        txtMaSP.TabIndex = 1
        ' 
        ' lvSanPham
        ' 
        lvSanPham.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        lvSanPham.Location = New Point(671, 105)
        lvSanPham.Name = "lvSanPham"
        lvSanPham.Size = New Size(451, 287)
        lvSanPham.TabIndex = 4
        lvSanPham.UseCompatibleStateImageBehavior = False
        lvSanPham.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Tên SP"
        ColumnHeader1.Width = 110
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Size"
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Màu"
        ColumnHeader3.Width = 80
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Giá"
        ColumnHeader4.Width = 80
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Số lượng"
        ColumnHeader5.Width = 80
        ' 
        ' btnBanHang
        ' 
        btnBanHang.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBanHang.Location = New Point(854, 423)
        btnBanHang.Name = "btnBanHang"
        btnBanHang.Size = New Size(193, 92)
        btnBanHang.TabIndex = 5
        btnBanHang.Text = "MainBanHang"
        btnBanHang.UseVisualStyleBackColor = True
        ' 
        ' MainSP
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1224, 550)
        Controls.Add(btnBanHang)
        Controls.Add(lvSanPham)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(txtSoLuong)
        Controls.Add(txtMau)
        Controls.Add(txtGia)
        Controls.Add(txtSize)
        Controls.Add(Label6)
        Controls.Add(txtMaSP)
        Controls.Add(txtTenSP)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MainSP"
        Text = "MainSP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtGia As TextBox
    Friend WithEvents txtMau As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lvSanPham As ListView
    Friend WithEvents btnBanHang As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
