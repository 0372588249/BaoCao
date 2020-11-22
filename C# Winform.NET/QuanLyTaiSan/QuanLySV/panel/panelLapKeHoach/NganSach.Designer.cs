namespace QuanLySV.panel.panelLapKeHoach
{
    partial class NganSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelNganSach = new System.Windows.Forms.FlowLayoutPanel();
            this.llbThemVi = new System.Windows.Forms.LinkLabel();
            this.btDaKetThuc = new System.Windows.Forms.Button();
            this.lbNganSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.llbThemVi);
            this.panel1.Controls.Add(this.btDaKetThuc);
            this.panel1.Controls.Add(this.lbNganSach);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 614);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelNganSach);
            this.groupBox1.Location = new System.Drawing.Point(257, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 446);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanelNganSach
            // 
            this.flowLayoutPanelNganSach.AutoScroll = true;
            this.flowLayoutPanelNganSach.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelNganSach.Location = new System.Drawing.Point(6, 10);
            this.flowLayoutPanelNganSach.Name = "flowLayoutPanelNganSach";
            this.flowLayoutPanelNganSach.Size = new System.Drawing.Size(594, 430);
            this.flowLayoutPanelNganSach.TabIndex = 25;
            // 
            // llbThemVi
            // 
            this.llbThemVi.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThemVi.AutoSize = true;
            this.llbThemVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThemVi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThemVi.LinkColor = System.Drawing.Color.Green;
            this.llbThemVi.Location = new System.Drawing.Point(810, 20);
            this.llbThemVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbThemVi.Name = "llbThemVi";
            this.llbThemVi.Size = new System.Drawing.Size(47, 19);
            this.llbThemVi.TabIndex = 25;
            this.llbThemVi.TabStop = true;
            this.llbThemVi.Text = "Thêm";
            this.llbThemVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThemVi.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThemVi.Click += new System.EventHandler(this.llbThemVi_LinkClicked);
            // 
            // btDaKetThuc
            // 
            this.btDaKetThuc.BackColor = System.Drawing.Color.Snow;
            this.btDaKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDaKetThuc.ForeColor = System.Drawing.Color.Red;
            this.btDaKetThuc.Location = new System.Drawing.Point(267, 505);
            this.btDaKetThuc.Name = "btDaKetThuc";
            this.btDaKetThuc.Size = new System.Drawing.Size(584, 51);
            this.btDaKetThuc.TabIndex = 23;
            this.btDaKetThuc.Text = "Đã Kết Thúc";
            this.btDaKetThuc.UseVisualStyleBackColor = false;
            this.btDaKetThuc.Click += new System.EventHandler(this.btDaKetThuc_Click);
            // 
            // lbNganSach
            // 
            this.lbNganSach.AutoSize = true;
            this.lbNganSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganSach.Location = new System.Drawing.Point(538, 17);
            this.lbNganSach.Name = "lbNganSach";
            this.lbNganSach.Size = new System.Drawing.Size(98, 23);
            this.lbNganSach.TabIndex = 22;
            this.lbNganSach.Text = "Ngân Sách";
            // 
            // NganSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 575);
            this.Controls.Add(this.panel1);
            this.Name = "NganSach";
            this.Text = "Ngân Sách";
            this.Load += new System.EventHandler(this.NganSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbThemVi;
        private System.Windows.Forms.Button btDaKetThuc;
        private System.Windows.Forms.Label lbNganSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNganSach;
    }
}