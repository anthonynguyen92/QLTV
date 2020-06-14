using BUS.BangCapService;
using BUS.ChiTietPhieuMuonService;
using BUS.DocGiaService;
using BUS.DTO;
using BUS.NhanVienService;
using BUS.PhieuMuonSachService;
using BUS.PhieuThuTienService;
using BUS.SachService;
using BUS.TraSachService;
using System;
using System.Data;
using System.Windows.Forms;


namespace QuanLyThuVien
{
    public partial class Form_DocGia : Form
    {
        private readonly IBUS_BangCap _bangcap;
        private readonly IBUS_ChiTietPhieuMuon _chitietphieumuon;
        private readonly IBUS_DocGia _docgia;
        private readonly IBUS_NhanVien _nhanvien;
        private readonly IBUS_PhieuMuonSach _phieumuonsach;
        private readonly IBUS_PhieuThuTien _phieuthutien;
        private readonly IBUS_Sach _sach;
        private readonly IBUS_Tra _tra;

        public Form_DocGia(IBUS_DocGia docgia, IBUS_ChiTietPhieuMuon chitietphieumuon, IBUS_BangCap bangcap, IBUS_NhanVien nhanvien,
            IBUS_PhieuMuonSach phieumuonsach, IBUS_PhieuThuTien phieuthutien, IBUS_Sach sach, IBUS_Tra tra)
        {
            InitializeComponent();
            _docgia = docgia;
            _chitietphieumuon = chitietphieumuon;
            _bangcap = bangcap;
            _nhanvien = nhanvien;
            _phieumuonsach = phieumuonsach;
            _phieuthutien = phieuthutien;
            _sach = sach;
            _tra = tra;
        }

        void loadLV()
        {
            DataTable dt = _docgia.Get_DocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lv = new ListViewItem(dt.Rows[i]["MaDocGia"].ToString());
                lv.SubItems.Add(dt.Rows[i][1].ToString());
                lv.SubItems.Add(dt.Rows[i][2].ToString());
                lv.SubItems.Add(dt.Rows[i][3].ToString());
                lv.SubItems.Add(dt.Rows[i][4].ToString());
                lv.SubItems.Add(dt.Rows[i][5].ToString());
                lv.SubItems.Add(dt.Rows[i][6].ToString());
                lv.SubItems.Add(dt.Rows[i][7].ToString());

                listV.Items.Add(lv);
            }
        }

        private void Form_DocGia_Load(object sender, EventArgs e)
        {
            //load data lên listview
            loadLV();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            DocGiaDTO DocGia = new DocGiaDTO(9, txtHoTen.Text, dateNgaySinh.Value,
                txtDiaChi.Text, txtEmail.Text, dateNgayLap.Value, dateNgayHet.Value, Int32.Parse(txtTienNo.Text));

            if (_docgia.Them(DocGia) > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Thêm thất bại!");

            listV.Items.Clear();
            loadLV();
        }
        private void dk_Number(TextBox txt)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ Nhập số.");
                txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            }
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            dk_Number(txtTienNo);
            if (txtHoTen.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "" && txtTienNo.Text != "")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        void textRong()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTienNo.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                DocGiaDTO DocGia = new DocGiaDTO(Int32.Parse(listV.SelectedItems[0].SubItems[0].Text), txtHoTen.Text, dateNgaySinh.Value,
                    txtDiaChi.Text, txtEmail.Text, dateNgayLap.Value, dateNgayHet.Value, Int32.Parse(txtTienNo.Text));
                _docgia.Sua(DocGia, listV.SelectedItems[0].SubItems[0].Text);

                listV.Items.Clear();
                loadLV();

                textRong();
            }
            else
                MessageBox.Show("Phải chọn nhân viên cần sửa!");
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Có chắc xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (_docgia.Xoa(listV.SelectedItems[0].SubItems[0].Text) > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa độc giả này!");
                    }

                    listV.Items.Clear();
                    loadLV();

                    textRong();
                }
            }
            else
                MessageBox.Show("Phải chọn nhân viên cần xóa!");
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                txtHoTen.Text = listV.SelectedItems[0].SubItems[1].Text;
                dateNgaySinh.Text = listV.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = listV.SelectedItems[0].SubItems[3].Text;
                txtEmail.Text = listV.SelectedItems[0].SubItems[4].Text;
                dateNgayLap.Text = listV.SelectedItems[0].SubItems[5].Text;
                dateNgayHet.Text = listV.SelectedItems[0].SubItems[6].Text;
                txtTienNo.Text = listV.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien nv = new Form_NhanVien();
            nv.Show();
            this.Dispose(false);
        }
        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DocGia dg = new Form_DocGia(_docgia,_chitietphieumuon,_bangcap,_nhanvien,_phieumuonsach,_phieuthutien,_sach,_tra);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
