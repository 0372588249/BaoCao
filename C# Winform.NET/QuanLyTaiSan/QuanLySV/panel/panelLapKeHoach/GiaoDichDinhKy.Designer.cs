namespace QuanLySV.panel.panelLapKeHoach
{
    partial class GiaoDichDinhKy
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
            this.lbGiaoDichDinhKy = new System.Windows.Forms.Label();
            this.flowLayoutPanelGiaoDich = new System.Windows.Forms.FlowLayoutPanel();
            this.llbThemVi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbGiaoDichDinhKy
            // 
            this.lbGiaoDichDinhKy.AutoSize = true;
            this.lbGiaoDichDinhKy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaoDichDinhKy.Location = new System.Drawing.Point(468, 33);
            this.lbGiaoDichDinhKy.Name = "lbGiaoDichDinhKy";
            this.lbGiaoDichDinhKy.Size = new System.Drawing.Size(178, 22);
            this.lbGiaoDichDinhKy.TabIndex = 4;
            this.lbGiaoDichDinhKy.Text = "Giao Dịch Định Kỳ";
            // 
            // flowLayoutPanelGiaoDich
            // 
            this.flowLayoutPanelGiaoDich.AutoScroll = true;
            this.flowLayoutPanelGiaoDich.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelGiaoDich.Location = new System.Drawing.Point(268, 104);
            this.flowLayoutPanelGiaoDich.Name = "flowLayoutPanelGiaoDich";
            this.flowLayoutPanelGiaoDich.Size = new System.Drawing.Size(584, 459);
            this.flowLayoutPanelGiaoDich.TabIndex = 6;
            // 
            // llbThemVi
            // 
            this.llbThemVi.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.llbThemVi.AutoSize = true;
            this.llbThemVi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbThemVi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbThemVi.LinkColor = System.Drawing.Color.Green;
            this.llbThemVi.Location = new System.Drawing.Point(800, 59);
            this.llbThemVi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbThemVi.Name = "llbThemVi";
            this.llbThemVi.Size = new System.Drawing.Size(52, 19);
            this.llbThemVi.TabIndex = 20;
            this.llbThemVi.TabStop = true;
            this.llbThemVi.Text = "Thêm";
            this.llbThemVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llbThemVi.VisitedLinkColor = System.Drawing.Color.Green;
            this.llbThemVi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbThemVi_LinkClicked);
            // 
            // GiaoDichDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 575);
            this.Controls.Add(this.llbThemVi);
            this.Controls.Add(this.flowLayoutPanelGiaoDich);
            this.Controls.Add(this.lbGiaoDichDinhKy);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GiaoDichDinhKy";
            this.Text = "Giao dịch định kỳ";
            this.Load += new System.EventHandler(this.GiaoDichDinhKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbGiaoDichDinhKy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGiaoDich;
        private System.Windows.Forms.LinkLabel llbThemVi;
    }
}