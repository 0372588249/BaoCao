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
    public partial class ThemGiaoDichDinhKy : Form
    {
        DataManager dataManager = DataManager.GetDataManager();
        List<CIcon> IconListImg;
        List<CWallet> listWallets;
        List<CLoaiGiaoDich> cLoaiGiaoDiches;
        public ThemGiaoDichDinhKy()
        {
            InitializeComponent();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void ThemGiaoDichDinhKy_Load(object sender, EventArgs e)
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
                                WHERE taikhoan = '" + data.TaiKhoan+"'";

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

        private void ccbLoaiGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameimg = ((CLoaiGiaoDich)ccbLoaiGiaoDich.SelectedItem).Img;
            pbLoaiGiaoDich.Image = Commom.getImage(nameimg);
        }

        private void panelThe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLuu_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string soTien = tbTien.Text;
            string loaiGiaoDich = ((CLoaiGiaoDich)ccbLoaiGiaoDich.SelectedItem).MaLoaiGiaoDich;
            string ghiChu = tbGhiChu.Text;
            string tuNgay = dtpTuNgay.Text;
            string denNgay = dtpDenNgay.Text;
            string vi = ((CWallet)ccbLoaiVi.SelectedItem).Id;
            string tanSuat = tbTanSuat.Text;

            if (soTien == string.Empty || loaiGiaoDich == string.Empty || ghiChu == string.Empty || tuNgay == string.Empty || denNgay == string.Empty || vi == string.Empty || tanSuat ==string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO GiaoDichDinhKi(ma_vi,ma_loai_gd,so_tien,mo_ta,tan_suat,ngay_bat_dau,ngay_ket_thuc)
VALUES(N'"+ vi + "', N'"+ loaiGiaoDich + "',"+ soTien + ", N'"+ ghiChu + "','"+ tanSuat + "','"+ tuNgay + "','"+denNgay+"')";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm ví thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm ví thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }

        private void tbTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
