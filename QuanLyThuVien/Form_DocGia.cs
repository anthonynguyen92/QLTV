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
    public partial class Form_DocGia : Form
    {
        public Form_DocGia()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn;

        BUS_DocGia bus_DocGia = new BUS_DocGia();

        void loadLV()
        {
            DataTable dt = bus_DocGia.Get_DocGia();
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
            DocGia DocGia = new DocGia(txtHoTen.Text, dateNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtEmail.Text, dateNgayLap.Value.ToShortDateString(), dateNgayHet.Value.ToShortDateString(), txtTienNo.Text);

            if (bus_DocGia.Them(DocGia))
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
                DocGia DocGia = new DocGia(txtHoTen.Text, dateNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtEmail.Text, dateNgayLap.Value.ToShortDateString(), dateNgayHet.Value.ToShortDateString(), txtTienNo.Text);
                bus_DocGia.Sua(DocGia, listV.SelectedItems[0].SubItems[0].Text);

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
                    if (bus_DocGia.Xoa(listV.SelectedItems[0].SubItems[0].Text))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
