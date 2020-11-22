namespace QuanLySV
{
    partial class GiaoDichTaiChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbVi = new System.Windows.Forms.ComboBox();
            this.groupBoxRoot = new System.Windows.Forms.GroupBox();
            this.pbSoTien = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.panelNguoiQuen = new System.Windows.Forms.Panel();
            this.cbbNguoiQuen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.pbLoaiGiaoDich = new System.Windows.Forms.PictureBox();
            this.cbbLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.cbbNhomGiaoDich = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbVi = new System.Windows.Forms.PictureBox();
            this.llbThemVi = new System.Windows.Forms.LinkLabel();
            this.groupBoxRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoTien)).BeginInit();
            this.panelNguoiQuen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.Location = new System.Drawing.Point(406, 12);
            this.lbNameForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(240, 25);
            this.lbNameForm.TabIndex = 12;
            this.lbNameForm.Text = "GIAO DỊCH TÀI CHÍNH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 2);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chọn ví thực hiện giao dịch:";
            // 
            // cbbVi
            // 
            this.cbbVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVi.FormattingEnabled = true;
            this.cbbVi.Location = new System.Drawing.Point(266, 40);
            this.cbbVi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbVi.Name = "cbbVi";
            this.cbbVi.Size = new System.Drawing.Size(250, 29);
            this.cbbVi.TabIndex = 14;
            this.cbbVi.SelectedIndexChanged += new System.EventHandler(this.cbbVi_SelectedIndexChanged);
            // 
            // groupBoxRoot
            // 
            this.groupBoxRoot.Controls.Add(this.pbSoTien);
            this.groupBoxRoot.Controls.Add(this.label3);
            this.groupBoxRoot.Controls.Add(this.tbSoTien);
            this.groupBoxRoot.Controls.Add(this.panelNguoiQuen);
            this.groupBoxRoot.Controls.Add(this.label6);
            this.groupBoxRoot.Controls.Add(this.dtpNgayGiaoDich);
            this.groupBoxRoot.Controls.Add(this.pbLoaiGiaoDich);
            this.groupBoxRoot.Controls.Add(this.cbbLoaiGiaoDich);
            this.groupBoxRoot.Controls.Add(this.label4);
            this.groupBoxRoot.Controls.Add(this.label1);
            this.groupBoxRoot.Controls.Add(this.tbGhiChu);
            this.groupBoxRoot.Controls.Add(this.cbbNhomGiaoDich);
            this.groupBoxRoot.Controls.Add(this.label2);
            this.groupBoxRoot.Controls.Add(this.pbVi);
            this.groupBoxRoot.Controls.Add(this.cbbVi);
            this.groupBoxRoot.Controls.Add(this.label5);
            this.groupBoxRoot.Location = new System.Drawing.Point(71, 53);
            this.groupBoxRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRoot.Name = "groupBoxRoot";
            this.groupBoxRoot.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxRoot.Size = new System.Drawing.Size(900, 500);
            this.groupBoxRoot.TabIndex = 17;
            this.groupBoxRoot.TabStop = false;
            // 
            // pbSoTien
            // 
            this.pbSoTien.Image = global::QuanLySV.Properties.Resources.vnd;
            this.pbSoTien.Location = new System.Drawing.Point(435, 224);
            this.pbSoTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSoTien.Name = "pbSoTien";
            this.pbSoTien.Size = new System.Drawing.Size(37, 36);
            this.pbSoTien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSoTien.TabIndex = 114;
            this.pbSoTien.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 113;
            this.label3.Text = "Số tiền:";
            // 
            // tbSoTien
            // 
            this.tbSoTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTien.Location = new System.Drawing.Point(266, 229);
            this.tbSoTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSoTien.Size = new System.Drawing.Size(157, 29);
            this.tbSoTien.TabIndex = 112;
            this.tbSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTien_KeyPress);
            // 
            // panelNguoiQuen
            // 
            this.panelNguoiQuen.Controls.Add(this.cbbNguoiQuen);
            this.panelNguoiQuen.Controls.Add(this.label7);
            this.panelNguoiQuen.Location = new System.Drawing.Point(484, 216);
            this.panelNguoiQuen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelNguoiQuen.Name = "panelNguoiQuen";
            this.panelNguoiQuen.Size = new System.Drawing.Size(393, 60);
            this.panelNguoiQuen.TabIndex = 111;
            // 
            // cbbNguoiQuen
            // 
            this.cbbNguoiQuen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNguoiQuen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguoiQuen.FormattingEnabled = true;
            this.cbbNguoiQuen.Location = new System.Drawing.Point(153, 14);
            this.cbbNguoiQuen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNguoiQuen.Name = "cbbNguoiQuen";
            this.cbbNguoiQuen.Size = new System.Drawing.Size(187, 29);
            this.cbbNguoiQuen.TabIndex = 110;
            this.cbbNguoiQuen.SelectedIndexChanged += new System.EventHandler(this.cbbNguoiQuen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 109;
            this.label7.Text = "Với:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 107;
            this.label6.Text = "Ngày giao dịch:";
            // 
            // dtpNgayGiaoDich
            // 
            this.dtpNgayGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGiaoDich.Location = new System.Drawing.Point(266, 100);
            this.dtpNgayGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayGiaoDich.Name = "dtpNgayGiaoDich";
            this.dtpNgayGiaoDich.Size = new System.Drawing.Size(250, 29);
            this.dtpNgayGiaoDich.TabIndex = 106;
            // 
            // pbLoaiGiaoDich
            // 
            this.pbLoaiGiaoDich.Location = new System.Drawing.Point(845, 159);
            this.pbLoaiGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLoaiGiaoDich.Name = "pbLoaiGiaoDich";
            this.pbLoaiGiaoDich.Size = new System.Drawing.Size(37, 36);
            this.pbLoaiGiaoDich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoaiGiaoDich.TabIndex = 29;
            this.pbLoaiGiaoDich.TabStop = false;
            // 
            // cbbLoaiGiaoDich
            // 
            this.cbbLoaiGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiGiaoDich.FormattingEnabled = true;
            this.cbbLoaiGiaoDich.Location = new System.Drawing.Point(637, 164);
            this.cbbLoaiGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbLoaiGiaoDich.Name = "cbbLoaiGiaoDich";
            this.cbbLoaiGiaoDich.Size = new System.Drawing.Size(187, 29);
            this.cbbLoaiGiaoDich.TabIndex = 28;
            this.cbbLoaiGiaoDich.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiGiaoDich_SelectedIndexChanged);
            this.cbbLoaiGiaoDich.Click += new System.EventHandler(this.cbbLoaiGiaoDich_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Loại giao dịch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ghi chú:";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(144, 314);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGhiChu.Size = new System.Drawing.Size(735, 167);
            this.tbGhiChu.TabIndex = 24;
            // 
            // cbbNhomGiaoDich
            // 
            this.cbbNhomGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhomGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhomGiaoDich.FormattingEnabled = true;
            this.cbbNhomGiaoDich.Location = new System.Drawing.Point(266, 164);
            this.cbbNhomGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNhomGiaoDich.Name = "cbbNhomGiaoDich";
            this.cbbNhomGiaoDich.Size = new System.Drawing.Size(187, 29);
            this.cbbNhomGiaoDich.TabIndex = 22;
            this.cbbNhomGiaoDich.SelectedIndexChanged += new System.EventHandler(this.cbbNhomGiaoDich_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nhóm giao dịch:";
            // 
            // pbVi
            // 
            this.pbVi.Image = global::QuanLySV.Properties.Resources.wallet1;
            this.pbVi.Location = new System.Drawing.Point(539, 34);
            this.pbVi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVi.Name = "pbVi";
            this.pbVi.Size = new System.Drawing.Size(37, 36);
            this.pbVi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbVi.TabIndex = 16;
            this.pbVi.TabStop = false;
            // 
            // llbThemVi
            // 
            this.llbThemVi.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThemVi.AutoSize = true;
            this.llbThemVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThemVi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThemVi.LinkColor = System.Drawing.Color.Green;
            this.llbThemVi.Location = new System.Drawing.Point(929, 16);
            this.llbThemVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbThemVi.Name = "llbThemVi";
            this.llbThemVi.Size = new System.Drawing.Size(101, 19);
            this.llbThemVi.TabIndex = 112;
            this.llbThemVi.TabStop = true;
            this.llbThemVi.Text = "Thêm giao dịch";
            this.llbThemVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThemVi.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThemVi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemVi_LinkClicked);
            // 
            // GiaoDichTaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 601);
            this.Controls.Add(this.llbThemVi);
            this.Controls.Add(this.groupBoxRoot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNameForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GiaoDichTaiChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDichTaiChinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GiaoDichTaiChinh_Load);
            this.groupBoxRoot.ResumeLayout(false);
            this.groupBoxRoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoTien)).EndInit();
            this.panelNguoiQuen.ResumeLayout(false);
            this.panelNguoiQuen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbVi;
        private System.Windows.Forms.GroupBox groupBoxRoot;
        private System.Windows.Forms.ComboBox cbbLoaiGiaoDich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.ComboBox cbbNhomGiaoDich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLoaiGiaoDich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayGiaoDich;
        private System.Windows.Forms.Panel panelNguoiQuen;
        private System.Windows.Forms.ComboBox cbbNguoiQuen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llbThemVi;
        private System.Windows.Forms.PictureBox pbSoTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoTien;
    }
}