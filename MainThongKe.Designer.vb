<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainThongKe
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
        lvThongKe = New ListView()
        btnThongKe = New Button()
        dtpTuNgay = New DateTimePicker()
        dtpDenNgay = New DateTimePicker()
        txtTongDoanhThu = New TextBox()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(462, 60)
        Label1.TabIndex = 0
        Label1.Text = "Thống Kê Doanh Thu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(87, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 38)
        Label2.TabIndex = 0
        Label2.Text = "Từ Ngày"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(78, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 38)
        Label3.TabIndex = 0
        Label3.Text = "Đến Ngày"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        Label4.Location = New Point(30, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(237, 38)
        Label4.TabIndex = 0
        Label4.Text = "Tổng Doanh Thu"
        ' 
        ' lvThongKe
        ' 
        lvThongKe.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lvThongKe.Location = New Point(620, 81)
        lvThongKe.Name = "lvThongKe"
        lvThongKe.Size = New Size(371, 247)
        lvThongKe.TabIndex = 1
        lvThongKe.UseCompatibleStateImageBehavior = False
        lvThongKe.View = View.Details
        ' 
        ' btnThongKe
        ' 
        btnThongKe.Location = New Point(487, 372)
        btnThongKe.Name = "btnThongKe"
        btnThongKe.Size = New Size(199, 70)
        btnThongKe.TabIndex = 2
        btnThongKe.Text = "Thống Kê"
        btnThongKe.UseVisualStyleBackColor = True
        ' 
        ' dtpTuNgay
        ' 
        dtpTuNgay.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        dtpTuNgay.Location = New Point(287, 112)
        dtpTuNgay.Name = "dtpTuNgay"
        dtpTuNgay.Size = New Size(302, 31)
        dtpTuNgay.TabIndex = 3
        ' 
        ' dtpDenNgay
        ' 
        dtpDenNgay.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        dtpDenNgay.Location = New Point(287, 201)
        dtpDenNgay.Name = "dtpDenNgay"
        dtpDenNgay.Size = New Size(302, 31)
        dtpDenNgay.TabIndex = 3
        ' 
        ' txtTongDoanhThu
        ' 
        txtTongDoanhThu.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold)
        txtTongDoanhThu.Location = New Point(287, 285)
        txtTongDoanhThu.Name = "txtTongDoanhThu"
        txtTongDoanhThu.Size = New Size(302, 43)
        txtTongDoanhThu.TabIndex = 4
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Ngày Bán"
        ColumnHeader1.Width = 120
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Tổng Tiền"
        ColumnHeader2.Width = 150
        ' 
        ' MainThongKe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1157, 514)
        Controls.Add(txtTongDoanhThu)
        Controls.Add(dtpDenNgay)
        Controls.Add(dtpTuNgay)
        Controls.Add(btnThongKe)
        Controls.Add(lvThongKe)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MainThongKe"
        Text = "MainThongKe"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lvThongKe As ListView
    Friend WithEvents btnThongKe As Button
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents txtTongDoanhThu As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
