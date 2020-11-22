namespace QuanLySV.panel.panelLapKeHoach
{
    partial class UserControlGiaoDich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lbNgayKT = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.rpbImg = new QuanLySV.RoundPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.rpbImg);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 65);
            this.panel1.TabIndex = 13;
            this.panel1.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(3, 110);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1);
            this.panel2.TabIndex = 16;
            this.panel2.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(433, 16);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(70, 17);
            this.labelMoney.TabIndex = 15;
            this.labelMoney.Text = "12,345,000";
            this.labelMoney.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.labelMoney.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(95, 10);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 22);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Ăn uống";
            this.labelName.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // lbNgayKT
            // 
            this.lbNgayKT.AutoSize = true;
            this.lbNgayKT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayKT.Location = new System.Drawing.Point(96, 83);
            this.lbNgayKT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayKT.Name = "lbNgayKT";
            this.lbNgayKT.Size = new System.Drawing.Size(71, 17);
            this.lbNgayKT.TabIndex = 18;
            this.lbNgayKT.Text = "30/11/2020";
            this.lbNgayKT.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.lbNgayKT.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(97, 49);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(61, 16);
            this.lbGhiChu.TabIndex = 19;
            this.lbGhiChu.Text = "Ghi chú :";
            this.lbGhiChu.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.lbGhiChu.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // rpbImg
            // 
            this.rpbImg.BackColor = System.Drawing.Color.Transparent;
            this.rpbImg.Image = global::QuanLySV.Properties.Resources.different;
            this.rpbImg.Location = new System.Drawing.Point(19, 11);
            this.rpbImg.Margin = new System.Windows.Forms.Padding(2);
            this.rpbImg.Name = "rpbImg";
            this.rpbImg.Size = new System.Drawing.Size(40, 39);
            this.rpbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rpbImg.TabIndex = 0;
            this.rpbImg.TabStop = false;
            this.rpbImg.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.rpbImg.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            // 
            // UserControlGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lbNgayKT);
            this.Name = "UserControlGiaoDich";
            this.Size = new System.Drawing.Size(554, 113);
            this.Load += new System.EventHandler(this.UserControlGiaoDich_Load);
            this.Click += new System.EventHandler(this.UserControlGiaoDich_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlGiaoDich_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlGiaoDich_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundPictureBox rpbImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lbNgayKT;
        private System.Windows.Forms.Label lbGhiChu;
    }
}
