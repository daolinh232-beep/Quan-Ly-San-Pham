Imports Microsoft.Data.SqlClient

Public Class MainDangNhap
    Dim conn As SqlConnection

    Private Sub MainDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Data Source=DESKTOP-CBVLLRG\MSSQLSERVER01;Initial Catalog=QLBHQA;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        conn.Open()

        ' Kiểm tra trạng thái kết nối
        If conn.State = ConnectionState.Open Then
            MsgBox("Kết nối thành công")
        Else
            MsgBox("Lỗi kết nối")
        End If
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim da As New SqlDataAdapter("Select * From NguoiDung Where TaiKhoan='" & txttk.Text & "' AND MatKhau='" & txtmk.Text & "' ", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MsgBox("Dang Nhap Thanh Cong")
            MainSP.Show()
            Me.Hide()
        Else
            MsgBox("Sai TaiKhoan hoac MatKhau")
        End If
    End Sub
End Class
