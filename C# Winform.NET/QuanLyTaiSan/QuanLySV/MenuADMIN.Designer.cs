namespace QuanLySV
{
    partial class MenuADMIN
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
            this.components = new System.ComponentModel.Container();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbToday = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.runText = new System.Windows.Forms.Timer(this.components);
            this.labelRun = new System.Windows.Forms.Label();
            this.panelRunText = new System.Windows.Forms.Panel();
            this.panelListButton = new System.Windows.Forms.Panel();
            this.btTaiKhoan = new ePOSOne.btnProduct.Button_WOC();
            this.btLapKeHoach = new ePOSOne.btnProduct.Button_WOC();
            this.btBaoCao = new ePOSOne.btnProduct.Button_WOC();
            this.btThemGiaoDich = new ePOSOne.btnProduct.Button_WOC();
            this.btSoGiaoDich = new ePOSOne.btnProduct.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUser.SuspendLayout();
            this.panelRunText.SuspendLayout();
            this.panelListButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Azure;
            this.panelUser.Controls.Add(this.lbName);
            this.panelUser.Controls.Add(this.lbDate);
            this.panelUser.Controls.Add(this.lbToday);
            this.panelUser.Location = new System.Drawing.Point(1077, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(206, 56);
            this.panelUser.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbDate.Location = new System.Drawing.Point(92, 20);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(71, 15);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "00-00-0000";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(64, 18);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 17);
            this.lbName.TabIndex = 3;
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToday.Location = new System.Drawing.Point(33, 18);
            this.lbToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(53, 18);
            this.lbToday.TabIndex = 2;
            this.lbToday.Text = "Today:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen3;
            this.panelMenu.Location = new System.Drawing.Point(0, 96);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1283, 568);
            this.panelMenu.TabIndex = 2;
            // 
            // runText
            // 
            this.runText.Enabled = true;
            this.runText.Interval = 15;
            this.runText.Tick += new System.EventHandler(this.runText_Tick);
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRun.ForeColor = System.Drawing.Color.Red;
            this.labelRun.Location = new System.Drawing.Point(8, 4);
            this.labelRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(298, 26);
            this.labelRun.TabIndex = 4;
            this.labelRun.Text = "Phần mềm quản lý tài chính";
            // 
            // panelRunText
            // 
            this.panelRunText.BackColor = System.Drawing.Color.SkyBlue;
            this.panelRunText.Controls.Add(this.labelRun);
            this.panelRunText.Location = new System.Drawing.Point(0, 0);
            this.panelRunText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRunText.Name = "panelRunText";
            this.panelRunText.Size = new System.Drawing.Size(1283, 35);
            this.panelRunText.TabIndex = 5;
            // 
            // panelListButton
            // 
            this.panelListButton.Controls.Add(this.panelUser);
            this.panelListButton.Controls.Add(this.btTaiKhoan);
            this.panelListButton.Controls.Add(this.btLapKeHoach);
            this.panelListButton.Controls.Add(this.btBaoCao);
            this.panelListButton.Controls.Add(this.btThemGiaoDich);
            this.panelListButton.Controls.Add(this.btSoGiaoDich);
            this.panelListButton.Location = new System.Drawing.Point(0, 36);
            this.panelListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelListButton.Name = "panelListButton";
            this.panelListButton.Size = new System.Drawing.Size(1283, 58);
            this.panelListButton.TabIndex = 6;
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.BorderColor = System.Drawing.Color.ForestGreen;
            this.btTaiKhoan.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btTaiKhoan.Location = new System.Drawing.Point(684, 1);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btTaiKhoan.OnHoverButtonColor = System.Drawing.Color.White;
            this.btTaiKhoan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btTaiKhoan.Size = new System.Drawing.Size(167, 55);
            this.btTaiKhoan.TabIndex = 7;
            this.btTaiKhoan.Text = "Tài khoản";
            this.btTaiKhoan.TextColor = System.Drawing.Color.Black;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            // 
            // btLapKeHoach
            // 
            this.btLapKeHoach.BackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.BorderColor = System.Drawing.Color.ForestGreen;
            this.btLapKeHoach.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btLapKeHoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLapKeHoach.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLapKeHoach.FlatAppearance.BorderSize = 0;
            this.btLapKeHoach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btLapKeHoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLapKeHoach.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLapKeHoach.ForeColor = System.Drawing.Color.White;
            this.btLapKeHoach.Location = new System.Drawing.Point(513, 1);
            this.btLapKeHoach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLapKeHoach.Name = "btLapKeHoach";
            this.btLapKeHoach.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btLapKeHoach.OnHoverButtonColor = System.Drawing.Color.White;
            this.btLapKeHoach.OnHoverTextColor = System.Drawing.Color.Black;
            this.btLapKeHoach.Size = new System.Drawing.Size(167, 55);
            this.btLapKeHoach.TabIndex = 6;
            this.btLapKeHoach.Text = "Lập kế hoạch";
            this.btLapKeHoach.TextColor = System.Drawing.Color.Black;
            this.btLapKeHoach.UseVisualStyleBackColor = false;
            this.btLapKeHoach.Click += new System.EventHandler(this.btLapKeHoach_Click);
            // 
            // btBaoCao
            // 
            this.btBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.BorderColor = System.Drawing.Color.ForestGreen;
            this.btBaoCao.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBaoCao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBaoCao.FlatAppearance.BorderSize = 0;
            this.btBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCao.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCao.ForeColor = System.Drawing.Color.White;
            this.btBaoCao.Location = new System.Drawing.Point(172, 1);
            this.btBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btBaoCao.OnHoverButtonColor = System.Drawing.Color.White;
            this.btBaoCao.OnHoverTextColor = System.Drawing.Color.Black;
            this.btBaoCao.Size = new System.Drawing.Size(167, 55);
            this.btBaoCao.TabIndex = 4;
            this.btBaoCao.Text = "Báo cáo";
            this.btBaoCao.TextColor = System.Drawing.Color.Black;
            this.btBaoCao.UseVisualStyleBackColor = false;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // btThemGiaoDich
            // 
            this.btThemGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.BorderColor = System.Drawing.Color.ForestGreen;
            this.btThemGiaoDich.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btThemGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThemGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThemGiaoDich.FlatAppearance.BorderSize = 0;
            this.btThemGiaoDich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThemGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btThemGiaoDich.Location = new System.Drawing.Point(343, 1);
            this.btThemGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThemGiaoDich.Name = "btThemGiaoDich";
            this.btThemGiaoDich.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btThemGiaoDich.OnHoverButtonColor = System.Drawing.Color.White;
            this.btThemGiaoDich.OnHoverTextColor = System.Drawing.Color.Black;
            this.btThemGiaoDich.Size = new System.Drawing.Size(167, 55);
            this.btThemGiaoDich.TabIndex = 5;
            this.btThemGiaoDich.Text = "Thêm giao dịch";
            this.btThemGiaoDich.TextColor = System.Drawing.Color.Black;
            this.btThemGiaoDich.UseVisualStyleBackColor = false;
            this.btThemGiaoDich.Click += new System.EventHandler(this.btThemGiaoDich_Click);
            // 
            // btSoGiaoDich
            // 
            this.btSoGiaoDich.BackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.BorderColor = System.Drawing.Color.ForestGreen;
            this.btSoGiaoDich.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btSoGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSoGiaoDich.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSoGiaoDich.FlatAppearance.BorderSize = 0;
            this.btSoGiaoDich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSoGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSoGiaoDich.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btSoGiaoDich.Location = new System.Drawing.Point(1, 1);
            this.btSoGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSoGiaoDich.Name = "btSoGiaoDich";
            this.btSoGiaoDich.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btSoGiaoDich.OnHoverButtonColor = System.Drawing.Color.White;
            this.btSoGiaoDich.OnHoverTextColor = System.Drawing.Color.Black;
            this.btSoGiaoDich.Size = new System.Drawing.Size(167, 55);
            this.btSoGiaoDich.TabIndex = 3;
            this.btSoGiaoDich.Text = "Sổ giao dịch";
            this.btSoGiaoDich.TextColor = System.Drawing.Color.Black;
            this.btSoGiaoDich.UseVisualStyleBackColor = false;
            this.btSoGiaoDich.Click += new System.EventHandler(this.btSoGiaoDich_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 2);
            this.panel1.TabIndex = 0;
            // 
            // MenuADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListButton);
            this.Controls.Add(this.panelRunText);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuADMIN_FormClosing);
            this.Load += new System.EventHandler(this.MenuADMIN_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelRunText.ResumeLayout(false);
            this.panelRunText.PerformLayout();
            this.panelListButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbToday;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panelMenu;
        private ePOSOne.btnProduct.Button_WOC btSoGiaoDich;
        private System.Windows.Forms.Timer runText;
        private System.Windows.Forms.Label labelRun;
        private System.Windows.Forms.Panel panelRunText;
        private System.Windows.Forms.Panel panelListButton;
        private ePOSOne.btnProduct.Button_WOC btTaiKhoan;
        private ePOSOne.btnProduct.Button_WOC btLapKeHoach;
        private ePOSOne.btnProduct.Button_WOC btBaoCao;
        private ePOSOne.btnProduct.Button_WOC btThemGiaoDich;
        private System.Windows.Forms.Panel panel1;
    }
}