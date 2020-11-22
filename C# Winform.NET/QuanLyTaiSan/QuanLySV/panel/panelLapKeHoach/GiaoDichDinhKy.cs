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
    public partial class GiaoDichDinhKy : Form
    {
        DataManager dataManager = DataManager.GetDataManager();
        public string IDUser;
        public TaiKhoan root;
        List<GiaoDich> listGiaoDichs;
        List<CWallet> listWallets;
        UserControlGiaoDich[] listItem;
        public GiaoDichDinhKy()
        {
            InitializeComponent();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            ThemGiaoDichDinhKy themGiaoDichDinhKy = new ThemGiaoDichDinhKy();
            themGiaoDichDinhKy.ShowDialog();
        }

        private void GiaoDichDinhKy_Load(object sender, EventArgs e)
        {
            getData();
        }

        /* Lấy dữ liệu từ DB đổ lên List */
        void getData()
        {
            listGiaoDichs = new List<GiaoDich>();

            string query = @"SELECT *
                            FROM GiaoDichDinhKi";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                GiaoDich giaoDich = new GiaoDich(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString(), rd[5].ToString(), rd[6].ToString());
                listGiaoDichs.Add(giaoDich);
            }
            DB.conn.Close();

            addItem();
        }
        /* Add các ví lên flowLayoutPanel */
        void addItem()
        {
            flowLayoutPanelGiaoDich.Controls.Clear();
            /*flowLayoutPanelGiaoDich.Controls.Add(new UserControlGiaoDich());*/

            listItem = new UserControlGiaoDich[listGiaoDichs.Count];

            for (int i = 0; i < listItem.Length; i++)
            {
                listItem[i] = new UserControlGiaoDich();
                listItem[i].GhiChu = listGiaoDichs[i].MoTa;
                listItem[i].NgayGiaoDich = listGiaoDichs[i].NgayBatDau.Substring(0, 9) +" - "+listGiaoDichs[i].NgayKetThuc.Substring(0, 9);
                listItem[i].SoTien = listGiaoDichs[i].SoTien;
                listItem[i].ID = listGiaoDichs[i].MaLoaiGD;
                listItem[i].Img = listGiaoDichs[i].getImage();

                if (flowLayoutPanelGiaoDich.Controls.Count < 0)
                {
                    flowLayoutPanelGiaoDich.Controls.Clear();
                }
                else
                {
                    flowLayoutPanelGiaoDich.Controls.Add(listItem[i]);
                }
            }
        }

        private void llbThemVi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemGiaoDichDinhKy themGiaoDichDinhKy = new ThemGiaoDichDinhKy();
            themGiaoDichDinhKy.ShowDialog();
        }
    }
}
