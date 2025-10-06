Imports Microsoft.Data.SqlClient

Public Class MainThongKe
    Dim conn As SqlConnection ' Biến kết nối SQL

    Private Sub MainThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mở kết nối đến CSDL
        conn = New SqlConnection("Data Source=DESKTOP-CBVLLRG\MSSQLSERVER01;Initial Catalog=QLBHQA;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        conn.Open()

        ' Xóa dữ liệu cũ trong bảng thống kê
        Dim cmd As New SqlCommand("DELETE FROM ThongKe", conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        lvThongKe.Items.Clear()
        txtTongDoanhThu.Clear()

        ' Kiểm tra ngày bắt đầu phải <= ngày kết thúc
        If dtpTuNgay.Value.Date > dtpDenNgay.Value.Date Then
            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.")
            Exit Sub
        End If

        ' Chuẩn bị câu lệnh SQL để lấy dữ liệu hóa đơn theo ngày
        Dim tong As Double = 0
        Dim sql As String = "
            SELECT CAST(NgayBan AS DATE) AS Ngay, SUM(TongTien) AS Tien
            FROM HoaDon
            WHERE CAST(NgayBan AS DATE) BETWEEN @tu AND @den
            GROUP BY CAST(NgayBan AS DATE)
            ORDER BY CAST(NgayBan AS DATE)
        "
        Dim cmd As New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@tu", dtpTuNgay.Value.Date)
        cmd.Parameters.AddWithValue("@den", dtpDenNgay.Value.Date)

        ' Đọc dữ liệu từ SQL
        Dim reader = cmd.ExecuteReader()
        Dim ds As New List(Of (Date, Double)) ' Danh sách tạm để lưu kết quả

        While reader.Read()
            Dim ngay = reader.GetDateTime(0)
            Dim tien = reader.GetDouble(1)
            ds.Add((ngay, tien)) ' Thêm vào danh sách
            tong += tien ' Cộng dồn doanh thu
        End While
        reader.Close()

        ' Hiển thị kết quả lên ListView và lưu vào bảng ThongKe
        For Each item In ds
            ' Thêm dòng vào ListView
            lvThongKe.Items.Add(New ListViewItem({item.Item1.ToString("dd/MM/yyyy"), item.Item2.ToString("N0")}))

            ' Lưu vào bảng ThongKe
            Dim cmd2 As New SqlCommand("INSERT INTO ThongKe (NgayBan, DoanhThu) VALUES (@ngay, @tien)", conn)
            cmd2.Parameters.AddWithValue("@ngay", item.Item1)
            cmd2.Parameters.AddWithValue("@tien", item.Item2)
            cmd2.ExecuteNonQuery()
        Next

        ' Hiển thị tổng doanh thu
        txtTongDoanhThu.Text = tong.ToString("N0") & " VNĐ"
    End Sub
End Class
