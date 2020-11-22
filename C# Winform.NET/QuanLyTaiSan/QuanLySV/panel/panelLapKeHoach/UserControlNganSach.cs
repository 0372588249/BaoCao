using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySV.panel.panelLapKeHoach
{
    public partial class UserControlNganSach : UserControl
    {
        private Form root;
        public UserControlNganSach(Form father)
        {
            InitializeComponent();
            root = father;
        }

        private string _id_loai_gd;
        private string _ngayBatDau;
        private string _ngayKetThuc;
        private string _ngayConLai;
        private string _soTien;
        private string _soTienConLai;
        private string _loaiVi;
        private Image _img;
        private void UserControlNganSach_Load(object sender, EventArgs e)
        {

        }
        [Category("Custom props")]
        public string ID
        {
            get { return _id_loai_gd; }
            set { _id_loai_gd = value; labelName.Text = getName(value); }
        }

        [Category("Custom props")]
        public string NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; lbNgayBD.Text = value; }
        }

        [Category("Custom props")]
        public string NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; lbNgayKT.Text = value; }
        }

        [Category("Custom props")]

        public string NgayConLai
        {
            get { return _ngayConLai; }
            set { _ngayConLai = value; lbtextConlai.Text = value; }
        }

        [Category("Custom props")]
        public string SoTien
        {
            get { return _soTien; }
            set { _soTien = value; labelMoney.Text = Commom.getMoneyStr(value); }
        }

        [Category("Custom props")]
        public string SoTienConLai
        {
            get { return _soTienConLai; }
            set { _soTienConLai = value; checkColor(value); }
        }
        [Category("Custom props")]
        public string Vi
        {
            get { return _loaiVi; }
            set { _loaiVi = value; lbVi.Text = getNameVi(value); }
        }
        [Category("Custom props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; rpbImg.Image = value; }
        }
        
        public string getName(string ma)
        {
            string query = @"SELECT ten_loai_gd
                                        FROM LoaiGiaoDich
                                        WHERE ma_loai_gd = '" + ma + "'";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return rd;
        }
        private void checkColor(string strMoney)
        {
            double dMoney = double.Parse(strMoney);
            if (dMoney > 0) // còn định mức
            {
                lbSoTienConLai.Text = "Còn lại: " + Commom.getMoneyStr(strMoney);
                lbSoTienConLai.ForeColor = Color.ForestGreen;
            }
            else if(dMoney == 0) // bằng định mức
            {
                lbSoTienConLai.Text = "Hết định mức: " + Commom.getMoneyStr(strMoney);
                lbSoTienConLai.ForeColor = Color.ForestGreen;

            }
            else // vượt
            {
                lbSoTienConLai.Text = "Vượt định mức: " + Commom.getMoneyStr(strMoney);
                lbSoTienConLai.ForeColor = Color.Red;
            }
        }
        public string getNameVi(string ma)
        {
            string query = @"SELECT ten_vi
                                        FROM VI
                                        WHERE ma_vi = '"+ma+"'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            return rd;
        }

        private void UserControlNganSach_Click(object sender, EventArgs e)
        {
            string query = @"SELECT dbo.GET_TienNganSach('" + _loaiVi + "','" + _id_loai_gd + "')";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            ChiTietNganSach chiTietNganSach = new ChiTietNganSach(_loaiVi, _id_loai_gd, rd);
            DB.conn.Close();
            chiTietNganSach.ShowDialog();
            try
            {
                ((NganSach)root).getData();
            }
            catch (Exception) { ((NganSachKetThuc)root).getDataNganSach(); }
        }

        private void UserControlNganSach_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlNganSach_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
