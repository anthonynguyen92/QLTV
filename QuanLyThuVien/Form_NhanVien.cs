using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using BUS;
using DTO;

namespace QuanLyThuVien
{
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn;
        //String cnStr = @"Data Source=H-Minh;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        //QLTVDataContext QLTVData;

        BUS_BangCap bus_BangCap = new BUS_BangCap();
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();

        void loadLV()
        {

            DataTable dt = bus_NhanVien.Get_NhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lv = new ListViewItem(dt.Rows[i]["MaNhanVien"].ToString());
                lv.SubItems.Add(dt.Rows[i][1].ToString());
                lv.SubItems.Add(dt.Rows[i][2].ToString());
                lv.SubItems.Add(dt.Rows[i][3].ToString());
                lv.SubItems.Add(dt.Rows[i][4].ToString());
                lv.SubItems.Add(dt.Rows[i][5].ToString());

                listV.Items.Add(lv);
            }

            //sqlConn = new SqlConnection(cnStr);
            //QLTVData = new QLTVDataContext(sqlConn);
            //var sql = QLTVData.GetTable<NhanVien>().Select(p => p);
            //foreach (var i in sql)
            //{
            //    ListViewItem lv = new ListViewItem(new[] {i.MaNhanVien.ToString(), i.HoTenNhanVien.ToString(), i.NgaySinh.ToString(), i.DiaChi.ToString(), i.DienThoai.ToString(), i.MaBangCap.ToString() });
            //    listV.Items.Add(lv);
            //}
        }

        void loadComboBox()
        {
            DataTable dt = bus_BangCap.Get_BangCap();
            for (int i = 0; i < dt.Rows.Count; i++)
                cmbBangCap.Items.Add(dt.Rows[i][1].ToString());
            cmbBangCap.Text = dt.Rows[0][1].ToString();
            //sqlConn = new SqlConnection(cnStr);
            //QLTVData = new QLTVDataContext(sqlConn);
            //var sql = QLTVData.GetTable<BangCap>().Select(p => p.TenBangCap);
            //cmbBangCap.DataSource = sql;
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            //load data lên listview
            loadLV();

            //load tên bằng cấp lên combobox
            //cmbBangCap.DataSource = bus_BangCap.Get_BangCap();
            //cmbBangCap.DisplayMember = "TenBangCap";
            //cmbBangCap.ValueMember = "MaBangCap";
            loadComboBox();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(txtHoTen.Text, dateNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtDienThoai.Text, bus_BangCap.Get_MaBangCap(cmbBangCap.SelectedItem.ToString()));

            if (bus_NhanVien.Them(nhanVien))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Thêm thất bại!");

            listV.Items.Clear();
            loadLV();

            //sqlConn = new SqlConnection(cnStr);
            //QLTVData = new QLTVDataContext(sqlConn);
            //NhanVien nv = new NhanVien();
            //nv.HoTenNhanVien = txtHoTen.Text.ToString();
            //nv.NgaySinh = dateNgaySinh.Value;
            //nv.DiaChi = txtDiaChi.Text.ToString();
            //nv.DienThoai = Int32.Parse(txtDienThoai.Text);
            //var sql = from p in QLTVData.GetTable<BangCap>()
            //          where p.TenBangCap.Contains(cmbBangCap.SelectedItem.ToString())
            //          select p.MaBangCap;
            //foreach (var i in sql)
            //{
            //    nv.MaBangCap = i;
            //}
            //QLTVData.NhanViens.InsertOnSubmit(nv);
            //QLTVData.SubmitChanges();
            //listV.Items.Clear();
            //loadLV();

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
            dk_Number(txtDienThoai);
            if (txtHoTen.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "")
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
            txtDienThoai.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                NhanVien nhanVien = new NhanVien(txtHoTen.Text, dateNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtDienThoai.Text, bus_BangCap.Get_MaBangCap(cmbBangCap.SelectedItem.ToString()));
                bus_NhanVien.Sua(nhanVien, listV.SelectedItems[0].SubItems[0].Text);

                listV.Items.Clear();
                loadLV();

                textRong();
            }
            else
                MessageBox.Show("Phải chọn nhân viên cần sửa!");

            //if (listV.SelectedItems.Count > 0)
            //{
            //    NhanVien nv = QLTVData.NhanViens.FirstOrDefault(p => p.MaNhanVien.Equals(Int32.Parse(listV.SelectedItems[0].SubItems[0].Text)));
            //    nv.HoTenNhanVien = txtHoTen.Text.ToString();
            //    nv.NgaySinh = dateNgaySinh.Value;
            //    nv.DiaChi = txtDiaChi.Text.ToString();
            //    nv.DienThoai = Int32.Parse(txtDienThoai.Text);
            //    var sql = from p in QLTVData.GetTable<BangCap>()
            //              where p.TenBangCap.Contains(cmbBangCap.SelectedItem.ToString())
            //              select p.MaBangCap;
            //    foreach (var i in sql)
            //    {
            //        nv.MaBangCap = i;
            //    }
            //    QLTVData.SubmitChanges();
            //    listV.Items.Clear();
            //    loadLV();

            //    textRong();
            //}
            //else
            //    MessageBox.Show("Phải chọn nhân viên cần sửa!");
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Có chắc xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bus_NhanVien.Xoa(listV.SelectedItems[0].SubItems[0].Text);

                    listV.Items.Clear();
                    loadLV();

                    textRong();
                }
            }
            else
                MessageBox.Show("Phải chọn nhân viên cần xóa!");

            //if (listV.SelectedItems.Count > 0)
            //{
            //    DialogResult dr = MessageBox.Show("Có chắc xóa không?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            //    if (dr == DialogResult.Yes)
            //    {
            //        NhanVien nv = QLTVData.NhanViens.FirstOrDefault(p => p.MaNhanVien.Equals(Int32.Parse(listV.SelectedItems[0].SubItems[0].Text)));
            //        QLTVData.NhanViens.DeleteOnSubmit(nv);
            //        QLTVData.SubmitChanges();
            //        listV.Items.Clear();
            //        loadLV();
            //    }
            //}
            //else
            //    MessageBox.Show("Phải chọn nhân viên cần xóa!");
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                txtHoTen.Text = listV.SelectedItems[0].SubItems[1].Text;
                dateNgaySinh.Text = listV.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = listV.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text = listV.SelectedItems[0].SubItems[4].Text;
                DataTable dt = bus_BangCap.Get_BangCap();
                cmbBangCap.Text = dt.Rows[Int32.Parse(listV.SelectedItems[0].SubItems[5].Text)-1][1].ToString();
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
