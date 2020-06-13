using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form_Sach : Form
    {
        public Form_Sach()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn;
        //String cnStr = @"Data Source=DESKTOP-LDSNN2N\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        //QLTVDataContext QLTVData;

        BUS_Sach bus_Sach = new BUS_Sach();

        void loadLV()
        {
            DataTable dt = bus_Sach.Get_Sach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lv = new ListViewItem(dt.Rows[i]["MaSach"].ToString());
                lv.SubItems.Add(dt.Rows[i][1].ToString());
                lv.SubItems.Add(dt.Rows[i][2].ToString());
                lv.SubItems.Add(dt.Rows[i][3].ToString());
                lv.SubItems.Add(dt.Rows[i][4].ToString());
                lv.SubItems.Add(dt.Rows[i][5].ToString());
                lv.SubItems.Add(dt.Rows[i][6].ToString());

                listV.Items.Add(lv);
            }

            //sqlConn = new SqlConnection(cnStr);
            //QLTVData = new QLTVDataContext(sqlConn);
            //var sql = QLTVData.GetTable<Sach>().Select(p => p);
            //foreach (var i in sql)
            //{
            //    ListViewItem lv = new ListViewItem(new[] { i.MaSach.ToString(), i.TenSach.ToString(), i.TacGia.ToString(), i.NamXuatBan.ToString(), i.NhaXuatBan.ToString(), i.TriGia.ToString(), i.NgayNhap.ToString() });
            //    listV.Items.Add(lv);
            //}
        }

        private void Form_Sach_Load(object sender, EventArgs e)
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
            Sach Sach = new Sach(txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtTriGia.Text, dateNgayNhap.Value.ToShortDateString());

            if (bus_Sach.Them(Sach))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
                MessageBox.Show("Thêm thất bại!");

            listV.Items.Clear();
            loadLV();

            //Sach _Sach = new Sach();
            //_Sach.TenSach = txtTenSach.Text.ToString();
            //_Sach.TacGia = txtTacGia.Text.ToString();
            //_Sach.NamXuatBan = Int32.Parse(txtNamXuatBan.Text);
            //_Sach.NhaXuatBan = txtNhaXuatBan.Text.ToString();
            //_Sach.TriGia = Int32.Parse(txtTriGia.Text);
            //_Sach.NgayNhap = dateNgayNhap.Value;
            //QLTVData.Saches.InsertOnSubmit(_Sach);
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
            dk_Number(txtNamXuatBan);
            dk_Number(txtTriGia);
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNamXuatBan.Text != "" && txtNhaXuatBan.Text != "" && txtTriGia.Text != "")
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
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNamXuatBan.Text = "";
            txtNhaXuatBan.Text = "";
            txtTriGia.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (listV.SelectedItems.Count > 0)
            {
                Sach Sach = new Sach(txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtTriGia.Text, dateNgayNhap.Value.ToShortDateString());
                bus_Sach.Sua(Sach, listV.SelectedItems[0].SubItems[0].Text);

                listV.Items.Clear();
                loadLV();

                textRong();
            }
            else
                MessageBox.Show("Phải chọn nhân viên cần sửa!");

            //if (listV.SelectedItems.Count > 0)
            //{
            //    Sach _Sach = QLTVData.Saches.FirstOrDefault(p => p.MaSach.Equals(Int32.Parse(listV.SelectedItems[0].SubItems[0].Text)));
            //    _Sach.TenSach = txtTenSach.Text.ToString();
            //    _Sach.TacGia = txtTacGia.Text.ToString();
            //    _Sach.NamXuatBan = Int32.Parse(txtNamXuatBan.Text);
            //    _Sach.NhaXuatBan = txtNhaXuatBan.Text.ToString();
            //    _Sach.TriGia = Int32.Parse(txtTriGia.Text);
            //    _Sach.NgayNhap = dateNgayNhap.Value;
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
                    bus_Sach.Xoa(listV.SelectedItems[0].SubItems[0].Text);

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
            //        Sach _Sach = QLTVData.Saches.FirstOrDefault(p => p.MaSach.Equals(Int32.Parse(listV.SelectedItems[0].SubItems[0].Text)));
            //        QLTVData.Saches.DeleteOnSubmit(_Sach);
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
                txtTenSach.Text = listV.SelectedItems[0].SubItems[1].Text;
                txtTacGia.Text = listV.SelectedItems[0].SubItems[2].Text;
                txtNamXuatBan.Text = listV.SelectedItems[0].SubItems[3].Text;
                txtNhaXuatBan.Text = listV.SelectedItems[0].SubItems[4].Text;
                txtTriGia.Text = listV.SelectedItems[0].SubItems[5].Text;
                dateNgayNhap.Text = listV.SelectedItems[0].SubItems[6].Text;
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