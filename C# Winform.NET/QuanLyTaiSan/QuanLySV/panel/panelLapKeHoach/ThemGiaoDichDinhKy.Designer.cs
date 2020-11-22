namespace QuanLySV.panel.panelLapKeHoach
{
    partial class ThemGiaoDichDinhKy
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
            this.panelThe = new System.Windows.Forms.Panel();
            this.llbLuu = new System.Windows.Forms.LinkLabel();
            this.llbTroVe = new System.Windows.Forms.LinkLabel();
            this.lbThemGiaoDichDK = new System.Windows.Forms.Label();
            this.ccbLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.lbGhichu = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.ccbLoaiVi = new System.Windows.Forms.ComboBox();
            this.lbVi = new System.Windows.Forms.Label();
            this.pbSoTien = new System.Windows.Forms.PictureBox();
            this.pbImgVi = new System.Windows.Forms.PictureBox();
            this.pbLoaiGiaoDich = new System.Windows.Forms.PictureBox();
            this.tbTanSuat = new System.Windows.Forms.TextBox();
            this.lbTanSuat = new System.Windows.Forms.Label();
            this.panelThe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThe
            // 
            this.panelThe.Controls.Add(this.llbLuu);
            this.panelThe.Controls.Add(this.llbTroVe);
            this.panelThe.Controls.Add(this.lbThemGiaoDichDK);
            this.panelThe.Location = new System.Drawing.Point(1, 0);
            this.panelThe.Name = "panelThe";
            this.panelThe.Size = new System.Drawing.Size(738, 66);
            this.panelThe.TabIndex = 9;
            this.panelThe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThe_Paint);
            // 
            // llbLuu
            // 
            this.llbLuu.AutoSize = true;
            this.llbLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.llbLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbLuu.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbLuu.LinkColor = System.Drawing.Color.Green;
            this.llbLuu.Location = new System.Drawing.Point(667, 26);
            this.llbLuu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbLuu.Name = "llbLuu";
            this.llbLuu.Size = new System.Drawing.Size(36, 18);
            this.llbLuu.TabIndex = 18;
            this.llbLuu.TabStop = true;
            this.llbLuu.Text = "Lưu";
            this.llbLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbLuu.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbLuu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btLuu_Click);
            // 
            // llbTroVe
            // 
            this.llbTroVe.AutoSize = true;
            this.llbTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbTroVe.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.llbTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbTroVe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbTroVe.LinkColor = System.Drawing.Color.Black;
            this.llbTroVe.Location = new System.Drawing.Point(14, 26);
            this.llbTroVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbTroVe.Name = "llbTroVe";
            this.llbTroVe.Size = new System.Drawing.Size(96, 18);
            this.llbTroVe.TabIndex = 17;
            this.llbTroVe.TabStop = true;
            this.llbTroVe.Text = "        Quay lại";
            this.llbTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbTroVe.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbTroVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTroVe_LinkClicked);
            // 
            // lbThemGiaoDichDK
            // 
            this.lbThemGiaoDichDK.AutoSize = true;
            this.lbThemGiaoDichDK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThemGiaoDichDK.Location = new System.Drawing.Point(264, 24);
            this.lbThemGiaoDichDK.Name = "lbThemGiaoDichDK";
            this.lbThemGiaoDichDK.Size = new System.Drawing.Size(195, 19);
            this.lbThemGiaoDichDK.TabIndex = 2;
            this.lbThemGiaoDichDK.Text = "Thêm Giao Dịch Định Kỳ";
            // 
            // ccbLoaiGiaoDich
            // 
            this.ccbLoaiGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLoaiGiaoDich.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbLoaiGiaoDich.FormattingEnabled = true;
            this.ccbLoaiGiaoDich.Location = new System.Drawing.Point(161, 173);
            this.ccbLoaiGiaoDich.Name = "ccbLoaiGiaoDich";
            this.ccbLoaiGiaoDich.Size = new System.Drawing.Size(231, 24);
            this.ccbLoaiGiaoDich.TabIndex = 17;
            this.ccbLoaiGiaoDich.SelectedIndexChanged += new System.EventHandler(this.ccbLoaiGiaoDich_SelectedIndexChanged);
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(131, 224);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(553, 93);
            this.tbGhiChu.TabIndex = 15;
            // 
            // tbTien
            // 
            this.tbTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTien.Location = new System.Drawing.Point(161, 124);
            this.tbTien.Multiline = true;
            this.tbTien.Name = "tbTien";
            this.tbTien.Size = new System.Drawing.Size(231, 24);
            this.tbTien.TabIndex = 14;
            this.tbTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTien_KeyPress);
            // 
            // lbGhichu
            // 
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhichu.Location = new System.Drawing.Point(61, 227);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(57, 16);
            this.lbGhichu.TabIndex = 13;
            this.lbGhichu.Text = "Ghi chú:";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(58, 127);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(60, 16);
            this.lbSoTien.TabIndex = 12;
            this.lbSoTien.Text = "Số Tiền :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loại giao dịch :";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(131, 368);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 18;
            this.dtpTuNgay.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuNgay.Location = new System.Drawing.Point(58, 370);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(64, 16);
            this.lbTuNgay.TabIndex = 19;
            this.lbTuNgay.Text = "Từ ngày :";
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDenNgay.Location = new System.Drawing.Point(407, 369);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(71, 16);
            this.lbDenNgay.TabIndex = 21;
            this.lbDenNgay.Text = "Đến ngày :";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(484, 365);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 20;
            // 
            // ccbLoaiVi
            // 
            this.ccbLoaiVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLoaiVi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbLoaiVi.FormattingEnabled = true;
            this.ccbLoaiVi.Location = new System.Drawing.Point(131, 440);
            this.ccbLoaiVi.Name = "ccbLoaiVi";
            this.ccbLoaiVi.Size = new System.Drawing.Size(200, 24);
            this.ccbLoaiVi.TabIndex = 23;
            this.ccbLoaiVi.SelectedIndexChanged += new System.EventHandler(this.ccbLoaiVi_SelectedIndexChanged);
            // 
            // lbVi
            // 
            this.lbVi.AutoSize = true;
            this.lbVi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVi.Location = new System.Drawing.Point(61, 443);
            this.lbVi.Name = "lbVi";
            this.lbVi.Size = new System.Drawing.Size(28, 16);
            this.lbVi.TabIndex = 22;
            this.lbVi.Text = "Ví :";
            // 
            // pbSoTien
            // 
            this.pbSoTien.Image = global::QuanLySV.Properties.Resources.vnd;
            this.pbSoTien.Location = new System.Drawing.Point(410, 116);
            this.pbSoTien.Margin = new System.Windows.Forms.Padding(2);
            this.pbSoTien.Name = "pbSoTien";
            this.pbSoTien.Size = new System.Drawing.Size(37, 36);
            this.pbSoTien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSoTien.TabIndex = 24;
            this.pbSoTien.TabStop = false;
            // 
            // pbImgVi
            // 
            this.pbImgVi.Image = global::QuanLySV.Properties.Resources.wallet1;
            this.pbImgVi.Location = new System.Drawing.Point(345, 434);
            this.pbImgVi.Margin = new System.Windows.Forms.Padding(2);
            this.pbImgVi.Name = "pbImgVi";
            this.pbImgVi.Size = new System.Drawing.Size(37, 36);
            this.pbImgVi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImgVi.TabIndex = 25;
            this.pbImgVi.TabStop = false;
            // 
            // pbLoaiGiaoDich
            // 
            this.pbLoaiGiaoDich.Image = global::QuanLySV.Properties.Resources.wallet1;
            this.pbLoaiGiaoDich.Location = new System.Drawing.Point(410, 165);
            this.pbLoaiGiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.pbLoaiGiaoDich.Name = "pbLoaiGiaoDich";
            this.pbLoaiGiaoDich.Size = new System.Drawing.Size(37, 36);
            this.pbLoaiGiaoDich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoaiGiaoDich.TabIndex = 26;
            this.pbLoaiGiaoDich.TabStop = false;
            // 
            // tbTanSuat
            // 
            this.tbTanSuat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTanSuat.Location = new System.Drawing.Point(131, 504);
            this.tbTanSuat.Multiline = true;
            this.tbTanSuat.Name = "tbTanSuat";
            this.tbTanSuat.Size = new System.Drawing.Size(200, 24);
            this.tbTanSuat.TabIndex = 28;
            // 
            // lbTanSuat
            // 
            this.lbTanSuat.AutoSize = true;
            this.lbTanSuat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTanSuat.Location = new System.Drawing.Point(58, 507);
            this.lbTanSuat.Name = "lbTanSuat";
            this.lbTanSuat.Size = new System.Drawing.Size(66, 16);
            this.lbTanSuat.TabIndex = 27;
            this.lbTanSuat.Text = "Tần suất :";
            // 
            // ThemGiaoDichDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(739, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tbTanSuat);
            this.Controls.Add(this.lbTanSuat);
            this.Controls.Add(this.pbLoaiGiaoDich);
            this.Controls.Add(this.pbImgVi);
            this.Controls.Add(this.pbSoTien);
            this.Controls.Add(this.ccbLoaiVi);
            this.Controls.Add(this.lbVi);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lbTuNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.panelThe);
            this.Controls.Add(this.ccbLoaiGiaoDich);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.tbTien);
            this.Controls.Add(this.lbGhichu);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemGiaoDichDinhKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemGiaoDichDinhKy";
            this.Load += new System.EventHandler(this.ThemGiaoDichDinhKy_Load);
            this.panelThe.ResumeLayout(false);
            this.panelThe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaiGiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelThe;
        private System.Windows.Forms.Label lbThemGiaoDichDK;
        private System.Windows.Forms.ComboBox ccbLoaiGiaoDich;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.Label lbGhichu;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbTroVe;
        private System.Windows.Forms.LinkLabel llbLuu;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.ComboBox ccbLoaiVi;
        private System.Windows.Forms.Label lbVi;
        private System.Windows.Forms.PictureBox pbSoTien;
        private System.Windows.Forms.PictureBox pbImgVi;
        private System.Windows.Forms.PictureBox pbLoaiGiaoDich;
        private System.Windows.Forms.TextBox tbTanSuat;
        private System.Windows.Forms.Label lbTanSuat;
    }
}