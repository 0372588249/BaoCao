namespace QuanLySV.panel.panelLapKeHoach
{
    partial class NganSachKetThuc
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
            this.flowLayoutPanelNganSach = new System.Windows.Forms.FlowLayoutPanel();
            this.lbNganSach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNganSach
            // 
            this.flowLayoutPanelNganSach.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelNganSach.Location = new System.Drawing.Point(6, 10);
            this.flowLayoutPanelNganSach.Name = "flowLayoutPanelNganSach";
            this.flowLayoutPanelNganSach.Size = new System.Drawing.Size(594, 444);
            this.flowLayoutPanelNganSach.TabIndex = 24;
            // 
            // lbNganSach
            // 
            this.lbNganSach.AutoSize = true;
            this.lbNganSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganSach.Location = new System.Drawing.Point(516, 21);
            this.lbNganSach.Name = "lbNganSach";
            this.lbNganSach.Size = new System.Drawing.Size(116, 23);
            this.lbNganSach.TabIndex = 22;
            this.lbNganSach.Text = "Đã Kết Thúc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelNganSach);
            this.groupBox1.Location = new System.Drawing.Point(255, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 460);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Image = global::QuanLySV.Properties.Resources.left_arrow;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(257, 24);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 19);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trở về        ";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbTroVe_LinkClicked);
            // 
            // NganSachKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 575);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNganSach);
            this.Name = "NganSachKetThuc";
            this.Text = "NganSachKetThuc";
            this.Load += new System.EventHandler(this.NganSachKetThuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNganSach;
        private System.Windows.Forms.Label lbNganSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}