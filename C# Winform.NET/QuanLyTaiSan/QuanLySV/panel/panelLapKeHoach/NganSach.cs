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

namespace QuanLySV.panel.panelLapKeHoach
{
    public partial class NganSach : Form
    {
        public string IDUser;
        public LapKeHoach root;
        List<CWallet> listWallets;
        List<CNganSach> listNganSachs;
        UserControlNganSach[] listItem;
        public NganSach(LapKeHoach tk)
        {
            InitializeComponent();
            root = tk;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemNganSach themNganSach = new ThemNganSach();
            themNganSach.ShowDialog();
        }

        private void NganSach_Load(object sender, EventArgs e)
        {
            getData();
        }

        /* Lấy dữ liệu từ DB đổ lên List */
        public void getData()
        {
            listNganSachs = new List<CNganSach>();

            string query = @"SELECT * FROM NganSach";
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

            listItem = new UserControlNganSach[listNganSachs.Count];

            for (int i = 0; i < listItem.Length; i++)
            {

                DateTime DateTime = DateTime.Now;
                DateTime DateTimeKetThuc = DateTime.Parse(Commom.getDate(listNganSachs[i].NgayKetThuc));
                TimeSpan interval = DateTimeKetThuc.Subtract(DateTime);
                if (interval.Days>=0)
                {
                    listItem[i] = new UserControlNganSach(this);
                    listItem[i].ID = listNganSachs[i].MaLoaiGD;
                    listItem[i].Vi = listNganSachs[i].MaVi;
                    listItem[i].NgayBatDau = Commom.getDate(listNganSachs[i].NgayBatDau);
                    listItem[i].NgayKetThuc = Commom.getDate(listNganSachs[i].NgayKetThuc);
                    listItem[i].SoTien = listNganSachs[i].SoTien;
                    listItem[i].SoTienConLai = getSoTienConLai(listNganSachs[i].MaVi, listNganSachs[i].MaLoaiGD, listNganSachs[i].SoTien).ToString();

                    listItem[i].NgayConLai = "Còn lại: " + interval.Days.ToString() + " ngày";
                    listItem[i].Img = listNganSachs[i].getImage();
                }

                if (flowLayoutPanelNganSach.Controls.Count < 0)
                {
                    flowLayoutPanelNganSach.Controls.Clear();
                }
                else
                {
                    flowLayoutPanelNganSach.Controls.Add(listItem[i]);
                }
            }
        }


        public double getSoTienConLai(string loaiVi,string loaiGD,string soTien)
        {
            string query = @"SELECT dbo.GET_TienNganSach('" + loaiVi + "','" + loaiGD + "')";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            double soTienConLai = Convert.ToDouble(soTien) - Convert.ToDouble(rd);
            DB.conn.Close();
            return soTienConLai;
        }
        private void btDaKetThuc_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NganSachKetThuc fr = new NganSachKetThuc(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel1.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void llbThemVi_LinkClicked(object sender, EventArgs e)
        {
            ThemNganSach themNganSach = new ThemNganSach();
            themNganSach.ShowDialog();
            themNganSach.Close();
            getData();
        }
        public void ShowQuayLai()
        {
            root.ShowNganSach();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
