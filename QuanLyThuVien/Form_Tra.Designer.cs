namespace QuanLyThuVien
{
    partial class Form_Tra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tra));
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvSachCo = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TriGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPhieuMuon = new System.Windows.Forms.ListView();
            this.MaPhieuMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_ten = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(644, 160);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(279, 22);
            this.dateNgayTra.TabIndex = 41;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(654, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 45);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Trả";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvSachCo
            // 
            this.lvSachCo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.TriGia});
            this.lvSachCo.HideSelection = false;
            this.lvSachCo.Location = new System.Drawing.Point(47, 449);
            this.lvSachCo.Name = "lvSachCo";
            this.lvSachCo.Size = new System.Drawing.Size(1039, 277);
            this.lvSachCo.TabIndex = 36;
            this.lvSachCo.UseCompatibleStateImageBehavior = false;
            this.lvSachCo.View = System.Windows.Forms.View.Details;
            // 
            // MaSach
            // 
            this.MaSach.Text = "Mã";
            this.MaSach.Width = 0;
            // 
            // TenSach
            // 
            this.TenSach.Text = "Tên sách";
            this.TenSach.Width = 281;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác Giả";
            this.TacGia.Width = 276;
            // 
            // TriGia
            // 
            this.TriGia.Text = "Trị giá";
            this.TriGia.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Đọc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(472, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "TRẢ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvPhieuMuon
            // 
            this.lvPhieuMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhieuMuon,
            this.NgayMuon,
            this.NgayTra,
            this.MaDocGia});
            this.lvPhieuMuon.FullRowSelect = true;
            this.lvPhieuMuon.HideSelection = false;
            this.lvPhieuMuon.Location = new System.Drawing.Point(47, 129);
            this.lvPhieuMuon.Name = "lvPhieuMuon";
            this.lvPhieuMuon.Size = new System.Drawing.Size(504, 189);
            this.lvPhieuMuon.TabIndex = 42;
            this.lvPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvPhieuMuon.View = System.Windows.Forms.View.Details;
            this.lvPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lvPhieuMuon_SelectedIndexChanged);
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.Text = "Ma";
            this.MaPhieuMuon.Width = 0;
            // 
            // NgayMuon
            // 
            this.NgayMuon.Text = "Ngày mượn";
            this.NgayMuon.Width = 150;
            // 
            // NgayTra
            // 
            this.NgayTra.Text = "Ngày trả";
            this.NgayTra.Width = 100;
            // 
            // MaDocGia
            // 
            this.MaDocGia.Text = "Đọc giả";
            this.MaDocGia.Width = 119;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýMượnToolStripMenuItem,
            this.quảnLýTrảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhânViênToolStripMenuItem.Image")));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.nhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýĐộcGiảToolStripMenuItem.Image")));
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản Lý Độc Giả";
            this.quảnLýĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýSáchToolStripMenuItem.Image")));
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýMượnToolStripMenuItem
            // 
            this.quảnLýMượnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýMượnToolStripMenuItem.Image")));
            this.quảnLýMượnToolStripMenuItem.Name = "quảnLýMượnToolStripMenuItem";
            this.quảnLýMượnToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quảnLýMượnToolStripMenuItem.Text = "Quản Lý Mượn";
            this.quảnLýMượnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnToolStripMenuItem_Click);
            // 
            // quảnLýTrảToolStripMenuItem
            // 
            this.quảnLýTrảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýTrảToolStripMenuItem.Image")));
            this.quảnLýTrảToolStripMenuItem.Name = "quảnLýTrảToolStripMenuItem";
            this.quảnLýTrảToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.quảnLýTrảToolStripMenuItem.Text = "Quản Lý Trả";
            this.quảnLýTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTrảToolStripMenuItem_Click);
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Location = new System.Drawing.Point(654, 132);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(43, 17);
            this.lb_ten.TabIndex = 44;
            this.lb_ten.Text = "name";
            // 
            // Form_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lvPhieuMuon);
            this.Controls.Add(this.dateNgayTra);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvSachCo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Tra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tra";
            this.Load += new System.EventHandler(this.Form_Tra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lvSachCo;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader TacGia;
        private System.Windows.Forms.ColumnHeader TriGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPhieuMuon;
        private System.Windows.Forms.ColumnHeader MaPhieuMuon;
        private System.Windows.Forms.ColumnHeader NgayMuon;
        private System.Windows.Forms.ColumnHeader NgayTra;
        private System.Windows.Forms.ColumnHeader MaDocGia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
        private System.Windows.Forms.Label lb_ten;
    }
}