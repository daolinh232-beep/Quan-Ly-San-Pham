
Imports Microsoft.Data.SqlClient

Public Class MainSP
    Dim conn As SqlConnection
    Dim dtSanPham As DataTable

    Private Sub MainSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=DESKTOP-CBVLLRG\MSSQLSERVER01;Initial Catalog=QLBHQA;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        conn.Open()

        ' Kiểm tra kết nối
        If conn.State <> ConnectionState.Open Then
            MsgBox("Lỗi kết nối")
            Exit Sub
        End If
        LoadSanPham() ' Gọi hàm để tải sản phẩm vào ListView
    End Sub

    Private Sub LoadSanPham()
        lvSanPham.Items.Clear() ' Xóa dữ liệu cũ trong ListView

        Dim cmd As New SqlCommand("SELECT MaSP, TenSP, Size, Mau, Gia, SoLuong FROM SanPham", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim item As New ListViewItem(reader("TenSP").ToString())
            item.SubItems.Add(reader("Size").ToString())
            item.SubItems.Add(reader("Mau").ToString())
            item.SubItems.Add(reader("Gia").ToString())
            item.SubItems.Add(reader("SoLuong").ToString())
            item.Tag = reader("MaSP")
            lvSanPham.Items.Add(item)
        End While

        reader.Close()
    End Sub


    ' ======== THÊM SP ==========
    '
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtTenSP.Text = "" Or txtSize.Text = "" Or txtMau.Text = "" Or txtGia.Text = "" Or txtSoLuong.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin sản phẩm.")
        Else
            Dim gia As Double
            Dim sl As Integer

            If Not Double.TryParse(txtGia.Text, gia) Then
                MsgBox("Giá không hợp lệ.")
                Exit Sub
            End If

            If Not Integer.TryParse(txtSoLuong.Text, sl) Then
                MsgBox("Số lượng không hợp lệ.")
                Exit Sub
            End If

            Dim cmd As SqlCommand
            cmd = New SqlCommand("INSERT INTO SanPham (TenSP, Size, Mau, Gia, SoLuong) VALUES (@ten, @size, @mau, @gia, @sl)", conn)
            cmd.Parameters.AddWithValue("@ten", txtTenSP.Text)
            cmd.Parameters.AddWithValue("@size", txtSize.Text)
            cmd.Parameters.AddWithValue("@mau", txtMau.Text)
            cmd.Parameters.AddWithValue("@gia", gia)
            cmd.Parameters.AddWithValue("@sl", sl)
            cmd.ExecuteNonQuery()

            MsgBox("Thêm sản phẩm thành công.")

            ClearFields()
            LoadSanPham()
        End If
    End Sub


    ' ========= SỬA SP ===========

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If lvSanPham.SelectedItems.Count = 0 Then
            MsgBox("Vui lòng chọn sản phẩm cần sửa.")
        ElseIf txtTenSP.Text = "" Or txtSize.Text = "" Or txtMau.Text = "" Or txtGia.Text = "" Or txtSoLuong.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin.")
        Else
            Dim gia As Double
            Dim sl As Integer

            If Not Double.TryParse(txtGia.Text, gia) Then
                MsgBox("Giá không hợp lệ.")
                Exit Sub
            End If

            If Not Integer.TryParse(txtSoLuong.Text, sl) Then
                MsgBox("Số lượng không hợp lệ.")
                Exit Sub
            End If

            Dim maSP As Integer = lvSanPham.SelectedItems(0).Tag

            Dim cmd As SqlCommand
            cmd = New SqlCommand("UPDATE SanPham SET TenSP = @ten, Size = @size, Mau = @mau, Gia = @gia, SoLuong = @sl WHERE MaSP = @ma", conn)
            cmd.Parameters.AddWithValue("@ten", txtTenSP.Text)
            cmd.Parameters.AddWithValue("@size", txtSize.Text)
            cmd.Parameters.AddWithValue("@mau", txtMau.Text)
            cmd.Parameters.AddWithValue("@gia", gia)
            cmd.Parameters.AddWithValue("@sl", sl)
            cmd.Parameters.AddWithValue("@ma", maSP)
            cmd.ExecuteNonQuery()

            MsgBox("Sửa sản phẩm thành công.")

            ClearFields()
            LoadSanPham()
        End If
    End Sub


    ' ========= XÓA SP ===========

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If lvSanPham.SelectedItems.Count = 0 Then
            MsgBox("Vui lòng chọn sản phẩm cần xóa.")
        Else
            Dim kq As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo)
            If kq = DialogResult.No Then Exit Sub

            Dim maSP As Integer = lvSanPham.SelectedItems(0).Tag

            Dim cmd As SqlCommand
            cmd = New SqlCommand("DELETE FROM SanPham WHERE MaSP = @ma", conn)
            cmd.Parameters.AddWithValue("@ma", maSP)
            cmd.ExecuteNonQuery()

            MsgBox("Xóa sản phẩm thành công.")
            LoadSanPham()
        End If
    End Sub
    ' ======= XÓA Ô NHẬP =========

    Private Sub ClearFields()
        txtTenSP.Clear()
        txtSize.Clear()
        txtMau.Clear()
        txtGia.Clear()
        txtSoLuong.Clear()
    End Sub

    ' ===== CHUYỂN SANG BÁN =====
    Private Sub btnBanHang_Click(sender As Object, e As EventArgs) Handles btnBanHang.Click
        Dim formBanHang As New MainBanHang()
        formBanHang.Show()
    End Sub
End Class
