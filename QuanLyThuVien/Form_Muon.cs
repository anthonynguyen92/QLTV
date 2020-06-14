using BUS.BangCapService;
using BUS.ChiTietPhieuMuonService;
using BUS.DocGiaService;
using BUS.NhanVienService;
using BUS.PhieuMuonSachService;
using BUS.PhieuThuTienService;
using BUS.SachService;
using BUS.TraSachService;
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form_Muon : Form
    {

        private readonly IBUS_BangCap _bangcap;
        private readonly IBUS_ChiTietPhieuMuon _chitietphieumuon;
        private readonly IBUS_DocGia _docgia;
        private readonly IBUS_NhanVien _nhanvien;
        private readonly IBUS_PhieuMuonSach _phieumuonsach;
        private readonly IBUS_PhieuThuTien _phieuthutien;
        private readonly IBUS_Sach _sach;
        private readonly IBUS_Tra _tra;

        SqlConnection sqlConn;
        //String cnStr = @"Data Source=H-Minh;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        BUS_Sach bus_Sach = new BUS_Sach();
        BUS_DocGia bus_DocGia = new BUS_DocGia();
        BUS_PhieuMuonSach bus_PhieuMuonSach = new BUS_PhieuMuonSach();
        BUS_ChiTietPhieuMuon bus_ChiTietPhieuMuon = new BUS_ChiTietPhieuMuon();

        public Form_Muon()
        {
            InitializeComponent();
        }

        void loadLV()
        {

            DataTable dt = bus_Sach.Get_Sach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lv = new ListViewItem(dt.Rows[i]["MaSach"].ToString());
                lv.SubItems.Add(dt.Rows[i][1].ToString());
                lv.SubItems.Add(dt.Rows[i][2].ToString());
                lv.SubItems.Add(dt.Rows[i][5].ToString());

                lvSachCo.Items.Add(lv);
            }
        }
        void loadComboBox()
        {
            DataTable dt = bus_DocGia.Get_DocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbDocGia.Items.Add(dt.Rows[i][1].ToString());
            cmbDocGia.Text = dt.Rows[0][1].ToString();
        }

        private void Form_Muon_Load(object sender, EventArgs e)
        {
            loadLV();
            loadComboBox();
        }
        private void check()
        {
            if (lvSachMuon.Items.Count == 0)
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (lvSachCo.SelectedItems.Count > 0)
            {
                ListViewItem lv = new ListViewItem(lvSachCo.SelectedItems[0].SubItems[0].Text);
                lv.SubItems.Add(lvSachCo.SelectedItems[0].SubItems[1].Text);
                lv.SubItems.Add(lvSachCo.SelectedItems[0].SubItems[2].Text);
                lv.SubItems.Add(lvSachCo.SelectedItems[0].SubItems[3].Text);
                lvSachMuon.Items.Add(lv);
                lvSachCo.SelectedItems[0].Remove();
            }
            check();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {

            if (lvSachMuon.SelectedItems.Count > 0)
            {
                ListViewItem lv = new ListViewItem(lvSachMuon.SelectedItems[0].SubItems[0].Text);
                lv.SubItems.Add(lvSachMuon.SelectedItems[0].SubItems[1].Text);
                lv.SubItems.Add(lvSachMuon.SelectedItems[0].SubItems[2].Text);
                lv.SubItems.Add(lvSachMuon.SelectedItems[0].SubItems[3].Text);
                lvSachCo.Items.Add(lv);
                lvSachMuon.SelectedItems[0].Remove();
            }
            check();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuMuonSach phieuMuonSach = new PhieuMuonSach(dateNgayMuon.Value.ToShortDateString(), null, bus_DocGia.Get_MaDocGia(cmbDocGia.SelectedItem.ToString()));

            if (bus_PhieuMuonSach.Them(phieuMuonSach))
            {
                for (int i = 0; i < lvSachMuon.Items.Count; i++)
                {
                    ChiTietPhieuMuon chiTietPhieuMuon = new ChiTietPhieuMuon(Int32.Parse(lvSachMuon.Items[i].SubItems[0].Text), bus_PhieuMuonSach.Get_MaCuoi());
                    //if (bus_ChiTietPhieuMuon.Them(chiTietPhieuMuon)) { }
                    bus_ChiTietPhieuMuon.Them(chiTietPhieuMuon);
                }
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
            this.Dispose(false);
        }
        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DocGia dg = new Form_DocGia();
            dg.Show();
            this.Dispose(false);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sach s = new Form_Sach();
            s.Show();
            this.Dispose(false);
        }

        private void quảnLýMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Muon m = new Form_Muon();
            m.Show();
            this.Dispose(false);
        }

        private void quảnLýTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tra t = new Form_Tra();
            t.Show();
            this.Dispose(false);
        }
    }
}
