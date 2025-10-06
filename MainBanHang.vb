Imports Microsoft.Data.SqlClient

Public Class MainBanHang
    Dim conn As SqlConnection
    Dim maHD As Integer = 0
    Dim tongTien As Double = 0

    Private Sub MainBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=DESKTOP-CBVLLRG\MSSQLSERVER01;Initial Catalog=QLBHQA;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        conn.Open()

        ' Xóa hóa đơn cũ khi mở form
        Dim cmdXoa As New SqlCommand("DELETE FROM HoaDon", conn)
        cmdXoa.ExecuteNonQuery()

        ' Hiển thị sản phẩm trong ComboBox
        Dim da As New SqlDataAdapter("SELECT MaSP, TenSP FROM SanPham", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        cboSanPham.DataSource = dt
        cboSanPham.DisplayMember = "TenSP"
        cboSanPham.ValueMember = "MaSP"
        cboSanPham.SelectedIndex = -1

        dtpNgayBan.Value = Now
    End Sub

    Private Sub btnThemBanHang_Click(sender As Object, e As EventArgs) Handles btnThemBanHang.Click
        If cboSanPham.SelectedIndex = -1 Or txtSLBan.Text = "" Then
            MsgBox("Vui lòng chọn sản phẩm và nhập số lượng.")
            Exit Sub
        End If

        Dim maSP As Integer = cboSanPham.SelectedValue
        Dim sl As Integer
        If Not Integer.TryParse(txtSLBan.Text, sl) Or sl <= 0 Then
            MsgBox("Số lượng không hợp lệ.")
            Exit Sub
        End If

        ' Lấy thông tin sản phẩm
        Dim tenSP As String = "", size As String = "", mau As String = ""
        Dim gia As Double = 0
        Dim cmd As New SqlCommand("SELECT * FROM SanPham WHERE MaSP=@maSP", conn)
        cmd.Parameters.AddWithValue("@maSP", maSP)
        Dim rd = cmd.ExecuteReader()
        If rd.Read() Then
            tenSP = rd("TenSP").ToString()
            size = rd("Size").ToString()
            mau = rd("Mau").ToString()
            gia = Convert.ToDouble(rd("Gia"))
        End If
        rd.Close()

        ' Tạo hóa đơn nếu chưa có
        If maHD = 0 Then
            Dim cmdHD As New SqlCommand("INSERT INTO HoaDon (TongTien, NgayBan) OUTPUT INSERTED.MaHD VALUES (0, @ngay)", conn)
            cmdHD.Parameters.AddWithValue("@ngay", dtpNgayBan.Value)
            maHD = cmdHD.ExecuteScalar()
        End If

        ' Tính tiền và thêm vào ListView
        Dim thanhTien As Double = gia * sl
        Dim item As New ListViewItem(maSP.ToString())
        item.SubItems.Add(tenSP)
        item.SubItems.Add(size)
        item.SubItems.Add(mau)
        item.SubItems.Add(gia.ToString("N0"))
        item.SubItems.Add(sl.ToString())
        item.SubItems.Add(thanhTien.ToString("N0"))
        lvHoaDon.Items.Add(item)

        tongTien += thanhTien
        txtTongTien.Text = tongTien.ToString("N0")
        txtSLBan.Clear()
    End Sub

    Private Sub btnLuuBanHang_Click(sender As Object, e As EventArgs) Handles btnLuuBanHang.Click
        If lvHoaDon.Items.Count = 0 Then
            MsgBox("Không có sản phẩm nào để lưu.")
            Exit Sub
        End If

        ' Lưu chi tiết hóa đơn
        For Each item As ListViewItem In lvHoaDon.Items
            Dim cmd As New SqlCommand("INSERT INTO ChiTietHD (MaHD, MaSP, SoLuong, ThanhTien) VALUES (@maHD, @maSP, @sl, @tt)", conn)
            cmd.Parameters.AddWithValue("@maHD", maHD)
            cmd.Parameters.AddWithValue("@maSP", Convert.ToInt32(item.SubItems(0).Text))
            cmd.Parameters.AddWithValue("@sl", Convert.ToInt32(item.SubItems(5).Text.Replace(",", "")))
            cmd.Parameters.AddWithValue("@tt", Convert.ToDouble(item.SubItems(6).Text.Replace(",", "")))
            cmd.ExecuteNonQuery()
        Next

        ' Cập nhật tổng tiền hóa đơn
        Dim cmdUpdate As New SqlCommand("UPDATE HoaDon SET TongTien=@tt WHERE MaHD=@maHD", conn)
        cmdUpdate.Parameters.AddWithValue("@tt", tongTien)
        cmdUpdate.Parameters.AddWithValue("@maHD", maHD)
        cmdUpdate.ExecuteNonQuery()

        MsgBox("Đã lưu hóa đơn.")
        lvHoaDon.Items.Clear()
        txtTongTien.Clear()
        tongTien = 0
        maHD = 0
    End Sub

    Private Sub btnXoaBanHang_Click(sender As Object, e As EventArgs) Handles btnXoaBanHang.Click
        If lvHoaDon.SelectedItems.Count = 0 Then
            MsgBox("Vui lòng chọn sản phẩm để xóa.")
            Exit Sub
        End If

        Dim item = lvHoaDon.SelectedItems(0)
        Dim maSP = Convert.ToInt32(item.SubItems(0).Text)
        Dim tt = Convert.ToDouble(item.SubItems(6).Text.Replace(",", ""))
        Dim sl = Convert.ToInt32(item.SubItems(5).Text.Replace(",", ""))

        ' Xóa khỏi bảng ChiTietHD
        Dim cmdDel As New SqlCommand("DELETE FROM ChiTietHD WHERE MaHD=@maHD AND MaSP=@maSP", conn)
        cmdDel.Parameters.AddWithValue("@maHD", maHD)
        cmdDel.Parameters.AddWithValue("@maSP", maSP)
        cmdDel.ExecuteNonQuery()

        ' Cập nhật tổng tiền
        tongTien -= tt
        txtTongTien.Text = tongTien.ToString("N0")
        item.Remove()

        Dim cmdUpdate As New SqlCommand("UPDATE HoaDon SET TongTien=@tt WHERE MaHD=@maHD", conn)
        cmdUpdate.Parameters.AddWithValue("@tt", tongTien)
        cmdUpdate.Parameters.AddWithValue("@maHD", maHD)
        cmdUpdate.ExecuteNonQuery()

        MsgBox("Đã xóa sản phẩm khỏi hóa đơn.")
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim fTK As New MainThongKe()
        fTK.Show()
    End Sub
End Class
