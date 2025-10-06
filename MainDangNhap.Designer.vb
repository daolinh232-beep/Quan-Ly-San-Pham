<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txttk = New TextBox()
        txtmk = New TextBox()
        btnok = New Button()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(261, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 62)
        Label1.TabIndex = 0
        Label1.Text = "Đăng Nhập"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(130, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 31)
        Label2.TabIndex = 0
        Label2.Text = "Tài Khoản"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(131, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 31)
        Label3.TabIndex = 0
        Label3.Text = "Mật Khẩu"
        ' 
        ' txttk
        ' 
        txttk.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txttk.Location = New Point(296, 143)
        txttk.Name = "txttk"
        txttk.Size = New Size(273, 38)
        txttk.TabIndex = 1
        ' 
        ' txtmk
        ' 
        txtmk.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        txtmk.Location = New Point(296, 227)
        txtmk.Name = "txtmk"
        txtmk.Size = New Size(273, 38)
        txtmk.TabIndex = 1
        ' 
        ' btnok
        ' 
        btnok.Location = New Point(356, 305)
        btnok.Name = "btnok"
        btnok.Size = New Size(122, 65)
        btnok.TabIndex = 2
        btnok.Text = "OK"
        btnok.UseVisualStyleBackColor = True
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' MainDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnok)
        Controls.Add(txtmk)
        Controls.Add(txttk)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MainDangNhap"
        Text = "DangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents txtmk As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand

End Class
