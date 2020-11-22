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

namespace QuanLySV.panel
{
    public partial class BaoCao : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @IdUser: ID ví cần query
        public string IdUser;
        public string IDWallets;

        public string timeStart;
        public string timeEnd;
        List<CSoNo> listWallets;
        UserControlOwe[] listItem;
        public BaoCao(string idUser, string idWallet, string start, string end)
        {
            InitializeComponent();
            IdUser = idUser;
            IDWallets = idWallet;
            timeStart = start;
            timeEnd = end;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {/*
            chart1.Series["Series1"].Points.AddXY("tháng 1", 1000);
            chart1.Series["Series1"].Points.AddXY("tháng 2", 1700);
            chart1.Series["Series1"].Points.AddXY("tháng 3", 1600);
            chart1.Series["Series1"].Points.AddXY("tháng 4", 1400);
            chart1.Series["Series1"].Points.AddXY("tháng 5", 1300);
            chart1.Series["Series1"].Points.AddXY("tháng 6", 1200);*/
            getData();
            getDataChartThu();
            getDataChartChi();
            getDataChartThuNhap();
        }


        /* Lấy dữ liệu từ DB đổ lên List */
        void getData()
        {
            listWallets = new List<CSoNo>();

            float sum_cho_vay = 0, sum_di_vay = 0;

            string query = @"SELECT NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd , SUM(GiaoDichTaiChinh.so_tien) , COUNT(*)
                                FROM GiaoDichTaiChinh, TaiKhoan, VI, NguoiQuen, LoaiGiaoDich
                                WHERE TaiKhoan.taikhoan = VI.taikhoan
                                AND TaiKhoan.taikhoan = NguoiQuen.taikhoan

                                AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                                AND GiaoDichTaiChinh.ma_nguoi_quen = NguoiQuen.ma_nguoi_quen

                                AND GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd

                                AND TaiKhoan.taikhoan = '" + IdUser + "'" +
                                "AND(LoaiGiaoDich.ten_loai_gd = N'Đi vay' OR LoaiGiaoDich.ten_loai_gd = N'Cho vay')" +
                                "AND NguoiQuen.ma_nguoi_quen != " + Commom.clone_nguoi_quen + "";



            if (timeEnd == string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian = '" + timeStart + "'";
            }
            else if (timeEnd != string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian >= '" + timeStart + "' AND GiaoDichTaiChinh.thoi_gian <= '" + timeEnd + "'";
            }



            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = "+ IDWallets + "";
            }
            query += " GROUP BY NguoiQuen.ten_nguoi_quen, LoaiGiaoDich.ten_loai_gd";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                CSoNo owe = new CSoNo(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
                listWallets.Add(owe);
                if (owe.LoaiNhanTra == "Đi vay")
                {
                    sum_di_vay += float.Parse(owe.SoTien);
                }
                else if (owe.LoaiNhanTra == "Cho vay")
                {
                    sum_cho_vay += float.Parse(owe.SoTien);
                }
            }
            DB.conn.Close();
            lbChoVay.Text = Commom.getMoneyStr(sum_cho_vay.ToString());
            lbNo.Text = Commom.getMoneyStr(sum_di_vay.ToString());
        }
        void getDataChartThu()
        {
            double sum = 0;
            string query = @"SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', LoaiGiaoDich.ten_loai_gd FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
                            WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                            AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
                            AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                            AND VI.taikhoan = '" + IdUser + "' AND NhomGiaoDich.ten_nhom_gd = N'Khoản thu'";


            if (timeEnd == string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian = '"+timeStart+"'";
            }
            else if(timeEnd != string.Empty  && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian >= '"+timeStart+"' AND GiaoDichTaiChinh.thoi_gian <= '"+timeEnd+"'";
            }



            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '"+ IDWallets +"'";
            }

            query += " GROUP BY LoaiGiaoDich.ten_loai_gd";



            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chartThu.Series["Thu"].Points.AddXY(rd[1].ToString(), double.Parse(rd[0].ToString()));
                sum += double.Parse(rd[0].ToString());
            }
            DB.conn.Close();

            if (sum == 0)
            {
                chartThu.Series["Thu"].Points.AddXY("Chưa có giao dịch", 100);
            }

            lbKhoanThu.Text = "Khoản thu: " + Commom.getMoneyStr(sum.ToString());


        }
        void getDataChartChi()
        {
            double sum = 0;
            string query = @"SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', LoaiGiaoDich.ten_loai_gd FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
                            WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                            AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
                            AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                            AND VI.taikhoan = '" + IdUser + "' AND NhomGiaoDich.ten_nhom_gd = N'Khoản chi'";


            if (timeEnd == string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian = '" + timeStart + "'";
            }
            else if (timeEnd != string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian >= '" + timeStart + "' AND GiaoDichTaiChinh.thoi_gian <= '" + timeEnd + "'";
            }



            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '" + IDWallets + "'";
            }

            query += " GROUP BY LoaiGiaoDich.ten_loai_gd";



            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chartChi.Series["Chi"].Points.AddXY(rd[1].ToString(), double.Parse(rd[0].ToString()));
                sum += double.Parse(rd[0].ToString());
            }
            DB.conn.Close();

            if (sum == 0)
            {
                chartChi.Series["Chi"].Points.AddXY("Chưa có giao dịch", 100);
            }

            lbKhoanChi.Text = "Khoản chi: " + Commom.getMoneyStr(sum.ToString());
        }

        void getDataChartThuNhap()
        {
            // thu
            string query = @"SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', GiaoDichTaiChinh.thoi_gian FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
                            WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                            AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
                            AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                            AND VI.taikhoan = '" + IdUser + "' AND NhomGiaoDich.ten_nhom_gd = N'Khoản thu'";


            if (timeEnd == string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian = '" + timeStart + "'";
            }
            else if (timeEnd != string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian >= '" + timeStart + "' AND GiaoDichTaiChinh.thoi_gian <= '" + timeEnd + "'";
            }



            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '" + IDWallets + "'";
            }

            query += " GROUP BY GiaoDichTaiChinh.thoi_gian";



            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chartThuNhap.Series["Thu"].Points.AddXY(Commom.getDate(rd[1].ToString()), double.Parse(rd[0].ToString()));
            }
            DB.conn.Close();

            // chi


            query = @"SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', GiaoDichTaiChinh.thoi_gian FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
                            WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
                            AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
                            AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
                            AND VI.taikhoan = '" + IdUser + "' AND NhomGiaoDich.ten_nhom_gd = N'Khoản chi'";


            if (timeEnd == string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian = '" + timeStart + "'";
            }
            else if (timeEnd != string.Empty && timeStart != string.Empty)
            {
                query += " AND GiaoDichTaiChinh.thoi_gian >= '" + timeStart + "' AND GiaoDichTaiChinh.thoi_gian <= '" + timeEnd + "'";
            }



            if (IDWallets != string.Empty)
            {
                query += " AND VI.ma_vi = '" + IDWallets + "'";
            }

            query += " GROUP BY GiaoDichTaiChinh.thoi_gian";


            DB.conn.Open();
            cmd = new SqlCommand(query, DB.conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chartThuNhap.Series["Chi"].Points.AddXY(Commom.getDate(rd[1].ToString()), double.Parse(rd[0].ToString()));
            }
            DB.conn.Close();
        }
    }
}
