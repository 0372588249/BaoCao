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
    public partial class UserControlGiaoDich : UserControl
    {
        public UserControlGiaoDich()
        {
            InitializeComponent();
        }
        private string _id;
        private string _ghiChu;
        private string _ngay;
        private string _soTien;
        private Image _img;

        [Category("Custom props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; labelName.Text = getName(value);
            }
        }

        [Category("Custom props")]
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; lbGhiChu.Text = "Ghi chú : "+ value; }
        }

        [Category("Custom props")]
        public string NgayGiaoDich
        {
            get { return _ngay; }
            set { _ngay = value; lbNgayKT.Text = value; }
        }

        [Category("Custom props")]
        public string SoTien
        {
            get { return _soTien; }
            set { _soTien = value; labelMoney.Text = Commom.getMoneyStr(value); }
        }
        [Category("Custom props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; rpbImg.Image = value; }
        }
        private void UserControlGiaoDich_Load(object sender, EventArgs e)
        {

        }
        public string getName(string ma)
        {
            string query = @"SELECT ten_loai_gd
                                        FROM LoaiGiaoDich
                                        WHERE ma_loai_gd = '"+ma+"'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString() ;
            DB.conn.Close();
            return rd;
        }

        private void UserControlGiaoDich_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UserControlGiaoDich_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UserControlGiaoDich_Click(object sender, EventArgs e)
        {
           //ChiTietNganSach chiTietNganSach = new ChiTietNganSach(_id);
            //chiTietNganSach.ShowDialog();
        }
    }
}
