using BUS.BangCapService;
using BUS.ChiTietPhieuMuonService;
using BUS.DocGiaService;
using BUS.NhanVienService;
using BUS.PhieuMuonSachService;
using BUS.PhieuThuTienService;
using BUS.SachService;
using BUS.TraSachService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class MainMenu : Form
    {
        private readonly IBUS_BangCap _bangcap;
        private readonly IBUS_ChiTietPhieuMuon _chitietphieumuon;
        private readonly IBUS_DocGia _docgia;
        private readonly IBUS_NhanVien _nhanvien;
        private readonly IBUS_PhieuMuonSach _phieumuonsach;
        private readonly IBUS_PhieuThuTien _phieuthutien;
        private readonly IBUS_Sach _sach;
        private readonly IBUS_Tra _tra;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form_DocGia dg = new Form_DocGia();
            dg.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form_Sach s = new Form_Sach();
            s.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form_Muon s = new Form_Muon();
            s.Show();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            Form_Tra s = new Form_Tra();
            s.Show();
        }
    }
}
