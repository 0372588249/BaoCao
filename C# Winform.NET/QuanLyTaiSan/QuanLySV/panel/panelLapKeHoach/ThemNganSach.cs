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

namespace QuanLySV.panel.panelLapKeHoach
{
    public partial class ThemNganSach : Form
    {
        DataManager dataManager = DataManager.GetDataManager();
        List<CIcon> IconListImg;
        List<CWallet> listWallets;
        List<CLoaiGiaoDich> cLoaiGiaoDiches;
        public ThemNganSach()
        {
            InitializeComponent();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void ThemNganSach_Load(object sender, EventArgs e)
        {
            ccbLoaiVi.DisplayMember = "NameMoneyType";
            ccbLoaiVi.ValueMember = "Id";

            ccbLoaiGiaoDich.DisplayMember = "TenLoaiGiaoDich";
            ccbLoaiGiaoDich.ValueMember = "MaLoaiGiaoDich";
            LoadccbLoaiGiaoDich();
            LoadccbVi();
            try
            {
                ccbLoaiVi.SelectedIndex = 0;

            }
            catch (Exception)
            {
            }

        }

        private void LoadccbLoaiGiaoDich()
        {
            string query = @"SELECT *
                                FROM LoaiGiaoDich
                                WHERE ma_nhom_gd = 2";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CLoaiGiaoDich cLoaiGiaoDich = new CLoaiGiaoDich(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
                    ccbLoaiGiaoDich.Text = "Chọn loại giao dịch";
                    ccbLoaiGiaoDich.Items.Add(cLoaiGiaoDich);

                }
            }
            catch (Exception ex)
            {

            }
            DB.conn.Close();
        }
        private void LoadccbVi()
        {
            Data data = dataManager.GetDetailData();
            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi
                                FROM VI
                                WHERE taikhoan = '" + data.TaiKhoan + "'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CWallet cWallet = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                    ccbLoaiVi.Items.Add(cWallet);
                }
            }
            catch (Exception ex)
            {

            }
            DB.conn.Close();
        }
        private void ccbLoaiVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameimg = ((CWallet)ccbLoaiVi.SelectedItem).Img;
            pbImgVi.Image = Commom.getImage(nameimg);
        }

        private void tbTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void llbLuu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tuNgay = dtpTuNgay.Text;
            string denNgay = dtpDenNgay.Text;
            string soTien = tbTien.Text;
            if (ccbLoaiVi.SelectedIndex == -1 || ccbLoaiGiaoDich.SelectedIndex == -1 || soTien == string.Empty || tuNgay == string.Empty || denNgay == string.Empty )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string loaiGiaoDich = ((CLoaiGiaoDich)ccbLoaiGiaoDich.SelectedItem).MaLoaiGiaoDich;
            string vi = ((CWallet)ccbLoaiVi.SelectedItem).Id;

            string query = @"INSERT INTO NganSach(ma_vi,ma_loai_gd,so_tien,ngay_bat_dau,ngay_ket_thuc)
                        VALUES(N'" + vi + "', N'" + loaiGiaoDich + "',"+ soTien + ",'" + tuNgay + "','" + denNgay + "')";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm ngân sách mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ngân sách thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }

        private void ccbLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameimg = ((CLoaiGiaoDich)ccbLoaiGiaoDich.SelectedItem).Img;
            pbLoaiGiaoDich.Image = Commom.getImage(nameimg);
        }
    }
}
