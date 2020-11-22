using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class Data
    {
        private string taiKhoan;

        public Data(string taiKhoan)
        {
            this.taiKhoan = taiKhoan;
        }

        public Data()
        {

        }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
