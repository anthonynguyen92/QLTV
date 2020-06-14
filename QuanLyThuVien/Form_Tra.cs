using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BangCapService;
using BUS.ChiTietPhieuMuonService;
using BUS.DocGiaService;
using BUS.NhanVienService;
using BUS.PhieuMuonSachService;
using BUS.PhieuThuTienService;
using BUS.SachService;
using BUS.TraSachService;
using DTO;

namespace QuanLyThuVien
{
    public partial class Form_Tra : Form
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
        BUS_Tra bus_Tra = new BUS_Tra();
        public Form_Tra()
        {
            InitializeComponent();
        }
        //void loadComboBox()
        //{
        //    DataTable dt = bus_Tra.Get_DocGiaMuon();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //        cmbDocGia.Items.Add(dt.Rows[i][1].ToString());
        //    if(cmbDocGia.Items.Count != 0)
        //        cmbDocGia.Text = dt.Rows[0][1].ToString();
        //}
        void loadLVPhieuMuon()
        {

            DataTable dt = bus_PhieuMuonSach.Get_PhieuMuonSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lv = new ListViewItem(dt.Rows[i]["MaPhieuMuon"].ToString());
                lv.SubItems.Add(dt.Rows[i][1].ToString());
                lv.SubItems.Add(dt.Rows[i][2].ToString());
                lv.SubItems.Add(bus_DocGia.Get_TenDocGia(dt.Rows[i][3].ToString()));
                if (lv.SubItems[2].Text == "")
                {
                    lvPhieuMuon.Items.Add(lv);
                }
            }
        }
        private void Form_Tra_Load(object sender, EventArgs e)
        {
            //loadComboBox();
            loadLVPhieuMuon();
        }


        private void check()
        {
            if (lvPhieuMuon.SelectedItems.Count > 0 && lvSachCo.Items.Count > 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }
        //private void btnThemSach_Click(object sender, EventArgs e)
        //{
        //    if (lvSachCo.Items.Count > 0)
        //    {
        //        foreach (ListViewItem item in lvSachCo.Items)
        //        {
        //            ListViewItem lv = new ListViewItem(item.SubItems[0].Text);
        //            lv.SubItems.Add(item.SubItems[1].Text);
        //            lv.SubItems.Add(item.SubItems[2].Text);
        //            lv.SubItems.Add(item.SubItems[3].Text);
        //            lvSachMuon.Items.Add(lv);
        //            item.Remove();
        //        }
        //    }
        //    check();
        //}

        //private void btnTraSach_Click(object sender, EventArgs e)
        //{
        //    if (lvSachMuon.Items.Count > 0)
        //    {
        //        foreach (ListViewItem item in lvSachMuon.Items)
        //        {
        //            ListViewItem lv = new ListViewItem(item.SubItems[0].Text);
        //            lv.SubItems.Add(item.SubItems[1].Text);
        //            lv.SubItems.Add(item.SubItems[2].Text);
        //            lv.SubItems.Add(item.SubItems[3].Text);
        //            lvSachCo.Items.Add(lv);
        //            item.Remove();
        //        }
        //    }
        //    check();
        //}
        private void lvPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            lvSachCo.Items.Clear();
            if (lvPhieuMuon.SelectedItems.Count > 0)
            {
                lb_ten.Text = lvPhieuMuon.SelectedItems[0].SubItems[3].Text;
                DataTable dt = bus_Tra.Get_SachMuon(lvPhieuMuon.SelectedItems[0].SubItems[0].Text);
                
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ListViewItem lv = new ListViewItem(dt.Rows[i]["MaSach"].ToString());
                        lv.SubItems.Add(dt.Rows[i][1].ToString());
                        lv.SubItems.Add(dt.Rows[i][2].ToString());
                        lv.SubItems.Add(dt.Rows[i][5].ToString());
                        lvSachCo.Items.Add(lv);
                    }
                }
            }
            check();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_PhieuMuonSach.ThemNgayTra(lvPhieuMuon.SelectedItems[0].SubItems[0].Text, dateNgayTra.Value.ToShortDateString()))
            {
                MessageBox.Show("Trả thành công!");
                lvPhieuMuon.Items.Clear();
                loadLVPhieuMuon();
            }
            else
                MessageBox.Show("Trả thất bại!");
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
