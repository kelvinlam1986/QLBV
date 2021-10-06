
namespace QLBV.WinForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKetNoiDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGiaTriMacDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuQuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnMuaHang = new System.Windows.Forms.ToolStripButton();
            this.btnBanHang = new System.Windows.Forms.ToolStripButton();
            this.btnKhoHang = new System.Windows.Forms.ToolStripButton();
            this.btnThuChi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNgay = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGio = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTenDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDockLeft = new C1.Win.C1Command.C1CommandDock();
            this.TabLeft = new C1.Win.C1Command.C1DockingTab();
            this.TabMenu = new C1.Win.C1Command.C1DockingTabPage();
            this.TVMenu = new System.Windows.Forms.TreeView();
            this.pLeftBottom = new System.Windows.Forms.Panel();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MnuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDockLeft)).BeginInit();
            this.btnDockLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabLeft)).BeginInit();
            this.TabLeft.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.pLeftBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHeThong,
            this.MnuHelp});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(994, 24);
            this.MnuMain.TabIndex = 1;
            this.MnuMain.Text = "&Hệ thống";
            // 
            // MnuHeThong
            // 
            this.MnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDangNhap,
            this.MnuDoiMatKhau,
            this.MnuKetNoiDuLieu,
            this.MnuGiaTriMacDinh,
            this.toolStripSeparator1,
            this.MnuQuanLyNguoiDung,
            this.MnuThoat});
            this.MnuHeThong.Name = "MnuHeThong";
            this.MnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.MnuHeThong.Text = "&Hệ thống";
            // 
            // MnuDangNhap
            // 
            this.MnuDangNhap.Name = "MnuDangNhap";
            this.MnuDangNhap.Size = new System.Drawing.Size(180, 22);
            this.MnuDangNhap.Text = "Đăng &nhập";
            // 
            // MnuDoiMatKhau
            // 
            this.MnuDoiMatKhau.Name = "MnuDoiMatKhau";
            this.MnuDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.MnuDoiMatKhau.Text = "Đổi &mật khẩu";
            // 
            // MnuKetNoiDuLieu
            // 
            this.MnuKetNoiDuLieu.Name = "MnuKetNoiDuLieu";
            this.MnuKetNoiDuLieu.Size = new System.Drawing.Size(180, 22);
            this.MnuKetNoiDuLieu.Text = "&Kết nối dữ liệu";
            // 
            // MnuGiaTriMacDinh
            // 
            this.MnuGiaTriMacDinh.Name = "MnuGiaTriMacDinh";
            this.MnuGiaTriMacDinh.Size = new System.Drawing.Size(180, 22);
            this.MnuGiaTriMacDinh.Text = "Giá trị mặc định";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuQuanLyNguoiDung
            // 
            this.MnuQuanLyNguoiDung.Name = "MnuQuanLyNguoiDung";
            this.MnuQuanLyNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.MnuQuanLyNguoiDung.Text = "Quản lý người dùng";
            // 
            // MnuThoat
            // 
            this.MnuThoat.Name = "MnuThoat";
            this.MnuThoat.Size = new System.Drawing.Size(180, 22);
            this.MnuThoat.Text = "&Thoát";
            // 
            // MnuHelp
            // 
            this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHuongDanSuDung,
            this.MnuThongTinPhanMem});
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(61, 20);
            this.MnuHelp.Text = "Giúp đỡ";
            // 
            // MnuHuongDanSuDung
            // 
            this.MnuHuongDanSuDung.Name = "MnuHuongDanSuDung";
            this.MnuHuongDanSuDung.Size = new System.Drawing.Size(186, 22);
            this.MnuHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // MnuThongTinPhanMem
            // 
            this.MnuThongTinPhanMem.Name = "MnuThongTinPhanMem";
            this.MnuThongTinPhanMem.Size = new System.Drawing.Size(186, 22);
            this.MnuThongTinPhanMem.Text = "Thông tin phần mềm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnMuaHang,
            this.btnBanHang,
            this.btnKhoHang,
            this.btnThuChi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnMuaHang
            // 
            this.BtnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnMuaHang.Image")));
            this.BtnMuaHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMuaHang.Name = "BtnMuaHang";
            this.BtnMuaHang.Size = new System.Drawing.Size(81, 22);
            this.BtnMuaHang.Text = "Mua hàng";
            // 
            // btnBanHang
            // 
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(77, 22);
            this.btnBanHang.Text = "Bán hàng";
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoHang.Image")));
            this.btnKhoHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Size = new System.Drawing.Size(78, 22);
            this.btnKhoHang.Text = "Kho hàng";
            // 
            // btnThuChi
            // 
            this.btnThuChi.Image = ((System.Drawing.Image)(resources.GetObject("btnThuChi.Image")));
            this.btnThuChi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThuChi.Name = "btnThuChi";
            this.btnThuChi.Size = new System.Drawing.Size(66, 22);
            this.btnThuChi.Text = "Thu chi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblNgay,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblGio,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.lblTenDangNhap});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(994, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Ngày: ";
            // 
            // lblNgay
            // 
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel3.Text = "Giờ: ";
            // 
            // lblGio
            // 
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel5.Text = "Tên đăng nhập: ";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDockLeft
            // 
            this.btnDockLeft.Controls.Add(this.TabLeft);
            this.btnDockLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDockLeft.Id = 1;
            this.btnDockLeft.Location = new System.Drawing.Point(0, 49);
            this.btnDockLeft.Name = "btnDockLeft";
            this.btnDockLeft.Size = new System.Drawing.Size(300, 464);
            // 
            // TabLeft
            // 
            this.TabLeft.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabLeft.AllowDrop = true;
            this.TabLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabLeft.CanAutoHide = true;
            this.TabLeft.CanCloseTabs = true;
            this.TabLeft.CanMoveTabs = true;
            this.TabLeft.Controls.Add(this.TabMenu);
            this.TabLeft.Location = new System.Drawing.Point(0, 0);
            this.TabLeft.Name = "TabLeft";
            this.TabLeft.ShowCaption = true;
            this.TabLeft.Size = new System.Drawing.Size(297, 464);
            this.TabLeft.TabIndex = 0;
            this.TabLeft.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.TabLeft.TabsSpacing = 5;
            // 
            // TabMenu
            // 
            this.TabMenu.CaptionVisible = true;
            this.TabMenu.Controls.Add(this.pLeftBottom);
            this.TabMenu.Controls.Add(this.TVMenu);
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Size = new System.Drawing.Size(294, 440);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.Text = "Menu";
            // 
            // TVMenu
            // 
            this.TVMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVMenu.Location = new System.Drawing.Point(0, 24);
            this.TVMenu.Name = "TVMenu";
            this.TVMenu.Size = new System.Drawing.Size(294, 416);
            this.TVMenu.TabIndex = 0;
            // 
            // pLeftBottom
            // 
            this.pLeftBottom.Controls.Add(this.button1);
            this.pLeftBottom.Controls.Add(this.btnDanhMuc);
            this.pLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLeftBottom.Location = new System.Drawing.Point(0, 360);
            this.pLeftBottom.Name = "pLeftBottom";
            this.pLeftBottom.Size = new System.Drawing.Size(294, 80);
            this.pLeftBottom.TabIndex = 1;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 40);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(294, 40);
            this.btnDanhMuc.TabIndex = 0;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 535);
            this.Controls.Add(this.btnDockLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MnuMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "CHUONG TRINH QUAN LY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDockLeft)).EndInit();
            this.btnDockLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabLeft)).EndInit();
            this.TabLeft.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.pLeftBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem MnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem MnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem MnuKetNoiDuLieu;
        private System.Windows.Forms.ToolStripMenuItem MnuGiaTriMacDinh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuQuanLyNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem MnuThoat;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem MnuThongTinPhanMem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnMuaHang;
        private System.Windows.Forms.ToolStripButton btnBanHang;
        private System.Windows.Forms.ToolStripButton btnKhoHang;
        private System.Windows.Forms.ToolStripButton btnThuChi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblNgay;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblGio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTenDangNhap;
        private C1.Win.C1Command.C1CommandDock btnDockLeft;
        private C1.Win.C1Command.C1DockingTab TabLeft;
        private C1.Win.C1Command.C1DockingTabPage TabMenu;
        private System.Windows.Forms.TreeView TVMenu;
        private System.Windows.Forms.Panel pLeftBottom;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button button1;
    }
}