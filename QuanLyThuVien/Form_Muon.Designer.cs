namespace QuanLyThuVien
{
    partial class Form_Muon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Muon));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSachCo = new System.Windows.Forms.ListView();
            this.MaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TriGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.lvSachMuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(446, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "MƯỢN SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(465, 110);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(200, 24);
            this.cmbDocGia.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Đọc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày mượn";
            // 
            // lvSachCo
            // 
            this.lvSachCo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.TriGia});
            this.lvSachCo.FullRowSelect = true;
            this.lvSachCo.HideSelection = false;
            this.lvSachCo.Location = new System.Drawing.Point(29, 284);
            this.lvSachCo.Name = "lvSachCo";
            this.lvSachCo.Size = new System.Drawing.Size(436, 426);
            this.lvSachCo.TabIndex = 25;
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
            this.TenSach.Width = 127;
            // 
            // TacGia
            // 
            this.TacGia.Text = "Tác Giả";
            this.TacGia.Width = 161;
            // 
            // TriGia
            // 
            this.TriGia.Text = "Trị giá";
            this.TriGia.Width = 118;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(499, 425);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(117, 41);
            this.btnThemSach.TabIndex = 27;
            this.btnThemSach.Text = ">>";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(499, 538);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(117, 41);
            this.btnTraSach.TabIndex = 28;
            this.btnTraSach.Text = "<<";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // lvSachMuon
            // 
            this.lvSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSachMuon.FullRowSelect = true;
            this.lvSachMuon.HideSelection = false;
            this.lvSachMuon.Location = new System.Drawing.Point(660, 284);
            this.lvSachMuon.Name = "lvSachMuon";
            this.lvSachMuon.Size = new System.Drawing.Size(436, 426);
            this.lvSachMuon.TabIndex = 29;
            this.lvSachMuon.UseCompatibleStateImageBehavior = false;
            this.lvSachMuon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tác Giả";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trị giá";
            this.columnHeader4.Width = 118;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(475, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(172, 45);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Mượn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayMuon.Location = new System.Drawing.Point(465, 141);
            this.dateNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(279, 22);
            this.dateNgayMuon.TabIndex = 31;
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
            this.menuStrip1.TabIndex = 32;
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
            // Form_Muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateNgayMuon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvSachMuon);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.lvSachCo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDocGia);
            this.Controls.Add(this.label1);
            this.Name = "Form_Muon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Muon";
            this.Load += new System.EventHandler(this.Form_Muon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSachCo;
        private System.Windows.Forms.ColumnHeader MaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.ColumnHeader TenSach;
        private System.Windows.Forms.ColumnHeader TacGia;
        private System.Windows.Forms.ColumnHeader TriGia;
        private System.Windows.Forms.ListView lvSachMuon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
    }
}