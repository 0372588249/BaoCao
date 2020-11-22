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
    public partial class ChiTietNganSach : Form
    {
        public string iD_Vi;
        public string iD_Loai_Gd;
        public string so_tien_da_chi;
        public ChiTietNganSach(string id_vi, string id_loai_gd, string so_tien)
        {
            InitializeComponent();
            iD_Vi = id_vi;
            iD_Loai_Gd = id_loai_gd;
            so_tien_da_chi = so_tien;
        }

        private void ChiTietNganSach_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {

            string query = @"SELECT so_tien, ngay_bat_dau, ngay_ket_thuc FROM NganSach
                            WHERE ma_vi = " + iD_Vi + " AND ma_loai_gd = "+ iD_Loai_Gd + "";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                llbSoTien.Text = Commom.getMoneyStr(rd[0].ToString());
                llbNgayBD.Text = Commom.getDate(rd[1].ToString());
                llbNgayKT.Text = Commom.getDate(rd[2].ToString());

            }
            DB.conn.Close();
            getLoaiGD(iD_Loai_Gd);
            getVi(iD_Vi);
            lbSoTienDaChi.Text = so_tien_da_chi;

        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llbXoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc muốn xóa giao dịch này !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.No)
            {
                return;
            }

            string query = @"DELETE NganSach WHERE ma_vi ='"+ iD_Vi + "' AND ma_loai_gd = '"+ iD_Loai_Gd + "'";

            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }
        }


        public void getLoaiGD(string ma)
        {
            string name = "", img = "";
            string query = @"SELECT ten_loai_gd, img
                                        FROM LoaiGiaoDich
                                        WHERE ma_loai_gd = '" + ma + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                name = rd[0].ToString();
                img = rd[1].ToString();

            }
            DB.conn.Close();

            llbLoaiGiaoDich.Text = name;
            pbLoaiGiaoDich.Image = Commom.getImage(img);
        }

        public void getVi(string ma)
        {
            string name = "", img = "", donvi = "";
            string query = @"SELECT ten_vi, img, don_vi
                                        FROM VI
                                        WHERE ma_vi = '" + ma + "'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                name = rd[0].ToString();
                img = rd[1].ToString();
                donvi = rd[2].ToString();
            }
            DB.conn.Close();
            llbVi.Text = name;
            pbImgVi.Image = Commom.getImage(img);
            if(donvi == "VND")
            {
                pbSoTien.Image = Commom.getImage("vnd.PNG");
            }
            else
            {
                pbSoTien.Image = Commom.getImage("usd.PNG");
            }
        }
    }
}
