using QuanLySV.panel.panelLapKeHoach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV.panel
{
    public partial class LapKeHoach : Form
    {
        public LapKeHoach()
        {
            InitializeComponent();
        }

        private void btNganSach_Click(object sender, EventArgs e)
        {
            panelShowLapKeHoach.Controls.Clear();
            NganSach fr = new NganSach(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelShowLapKeHoach.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void btGiaoDichDinhKy_Click(object sender, EventArgs e)
        {
            panelShowLapKeHoach.Controls.Clear();
            GiaoDichDinhKy fr = new GiaoDichDinhKy() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelShowLapKeHoach.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void LapKeHoach_Load(object sender, EventArgs e)
        {
            panelShowLapKeHoach.Controls.Clear();
            NganSach fr = new NganSach(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelShowLapKeHoach.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        public void ShowNganSach()
        {
            panelShowLapKeHoach.Controls.Clear();
            NganSach fr = new NganSach(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelShowLapKeHoach.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
    }
}
