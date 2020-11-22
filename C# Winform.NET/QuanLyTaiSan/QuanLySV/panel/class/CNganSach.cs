using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV.panel
{
    class CNganSach
    {
        private string maVi;
        private string maLoaiGD;
        private string soTien;
        private string ngayBatDau;
        private string ngayKetThuc;
        private string ngayConLai;

        public CNganSach(string maVi, string maLoaiGD, string soTien, string ngayBatDau, string ngayKetThuc)
        {
            this.maVi = maVi;
            this.maLoaiGD = maLoaiGD;
            this.soTien = soTien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaVi { get => maVi; set => maVi = value; }
        public string MaLoaiGD { get => maLoaiGD; set => maLoaiGD = value; }
        public string SoTien { get => soTien; set => soTien = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string NgayConLai { get => ngayConLai; set => ngayConLai = value; }

        public Image getImage()
        {
            string query = @"SELECT img
                            FROM LoaiGiaoDich
                            WHERE ma_loai_gd = '" + MaLoaiGD + "'";

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
