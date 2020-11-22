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
    public partial class NganSachKetThuc : Form
    {
        public string IDUser;
        public NganSach root;
        List<CWallet> listWallets;
        List<CNganSach> listNganSachs;
        UserControlWallets[] listItem;
        UserControlNganSach[] listItemNganSachs;
        public NganSachKetThuc(NganSach tk)
        {
            InitializeComponent();
            root = tk;
        }

        private void NganSachKetThuc_Load(object sender, EventArgs e)
        {
            getDataNganSach();
        }

        /* Lấy dữ liệu từ DB đổ lên List */
        public void getDataNganSach()
        {
            listNganSachs = new List<CNganSach>();

            string query = @"SELECT * FROM NganSach
";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CNganSach nganSach = new CNganSach(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                listNganSachs.Add(nganSach);
            }
            DB.conn.Close();

            addItem();
        }
        /* Add các ví lên flowLayoutPanel */
        void addItem()
        {
            flowLayoutPanelNganSach.Controls.Clear();

            listItemNganSachs = new UserControlNganSach[listNganSachs.Count];

            for (int i = 0; i < listItemNganSachs.Length; i++)
            {

                DateTime DateTime = DateTime.Now;
                DateTime DateTimeKetThuc = DateTime.Parse(Commom.getDate(listNganSachs[i].NgayKetThuc));
                TimeSpan interval = DateTimeKetThuc.Subtract(DateTime);
                if (interval.Days < 0)
                {
                    listItemNganSachs[i] = new UserControlNganSach(this);
                    listItemNganSachs[i].ID = listNganSachs[i].MaLoaiGD;
                    listItemNganSachs[i].Vi = listNganSachs[i].MaVi;
                    listItemNganSachs[i].NgayBatDau = Commom.getDate(listNganSachs[i].NgayBatDau);
                    listItemNganSachs[i].NgayKetThuc = Commom.getDate(listNganSachs[i].NgayKetThuc);
                    listItemNganSachs[i].SoTien = listNganSachs[i].SoTien;
                    listItemNganSachs[i].SoTienConLai = getSoTienConLai(listNganSachs[i].MaVi, listNganSachs[i].MaLoaiGD, listNganSachs[i].SoTien).ToString();

                    listItemNganSachs[i].NgayConLai = "Còn lại: " + interval.Days.ToString() + " ngày";
                    listItemNganSachs[i].Img = listNganSachs[i].getImage();
                }

                if (flowLayoutPanelNganSach.Controls.Count < 0)
                {
                    flowLayoutPanelNganSach.Controls.Clear();
                }
                else
                {
                    flowLayoutPanelNganSach.Controls.Add(listItemNganSachs[i]);
                }
            }
        }


        public double getSoTienConLai(string loaiVi, string loaiGD, string soTien)
        {
            string query = @"SELECT dbo.GET_TienNganSach('" + loaiVi + "','" + loaiGD + "')";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            double soTienConLai = Convert.ToDouble(soTien) - Convert.ToDouble(rd);
            DB.conn.Close();
            return soTienConLai;
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.ShowQuayLai();
        }
    }
}
