using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV.panel
{
    class GiaoDich
    {
        private string maVi;
        private string maLoaiGD;
        private string soTien;
        private string moTa;
        private string tanSuat;
        private string ngayBatDau;
        private string ngayKetThuc;

        public GiaoDich(string maVi, string maLoaiGD, string soTien, string moTa, string tanSuat, string ngayBatDau, string ngayKetThuc)
        {
            this.maVi = maVi;
            this.maLoaiGD = maLoaiGD;
            this.soTien = soTien;
            this.moTa = moTa;
            this.tanSuat = tanSuat;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaVi { get => maVi; set => maVi = value; }
        public string MaLoaiGD { get => maLoaiGD; set => maLoaiGD = value; }
        public string SoTien { get => soTien; set => soTien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string TanSuat { get => tanSuat; set => tanSuat = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public Image getImage()
        {
            string query = @"SELECT img
                            FROM LoaiGiaoDich
                            WHERE ma_loai_gd = '"+ MaLoaiGD + "'";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            string rd = cmd.ExecuteScalar().ToString();
            DB.conn.Close();
            Image img;

            try
            {
                img = Image.FromFile("../../icon/" + rd);
            }
            catch (Exception)
            {
                img = null;
            }
            return img;
        }
    }
}
