namespace NT_Mart
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelDock = new Panel();
            btnCloseLogin = new Button();
            panelLogin = new Panel();
            picLogo = new PictureBox();
            btnDangNhap = new Button();
            chkShowMatKhau = new CheckBox();
            panelMatKhau = new Panel();
            lbMatKhau = new Label();
            txtMatKhau = new TextBox();
            lbTenForm = new Label();
            panelTenDangNhap = new Panel();
            lbTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            panelDock.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelMatKhau.SuspendLayout();
            panelTenDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // panelDock
            // 
            panelDock.BackColor = Color.Indigo;
            panelDock.Controls.Add(btnCloseLogin);
            panelDock.Dock = DockStyle.Top;
            panelDock.Location = new Point(0, 0);
            panelDock.Name = "panelDock";
            panelDock.Size = new Size(404, 36);
            panelDock.TabIndex = 1;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.BackColor = Color.Transparent;
            btnCloseLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseLogin.FlatStyle = FlatStyle.Popup;
            btnCloseLogin.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseLogin.ForeColor = SystemColors.ButtonHighlight;
            btnCloseLogin.Location = new Point(365, -10);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(45, 55);
            btnCloseLogin.TabIndex = 2;
            btnCloseLogin.Text = "X";
            btnCloseLogin.UseVisualStyleBackColor = false;
            btnCloseLogin.Click += Close_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.MediumPurple;
            panelLogin.Controls.Add(picLogo);
            panelLogin.Controls.Add(btnDangNhap);
            panelLogin.Controls.Add(chkShowMatKhau);
            panelLogin.Controls.Add(panelMatKhau);
            panelLogin.Controls.Add(lbTenForm);
            panelLogin.Controls.Add(panelTenDangNhap);
            panelLogin.Location = new Point(34, 68);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(336, 492);
            panelLogin.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Maroon;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(106, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 123);
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Lavender;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatStyle = FlatStyle.Popup;
            btnDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(23, 405);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(293, 57);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkShowMatKhau
            // 
            chkShowMatKhau.AutoSize = true;
            chkShowMatKhau.Enabled = false;
            chkShowMatKhau.Location = new Point(168, 360);
            chkShowMatKhau.Name = "chkShowMatKhau";
            chkShowMatKhau.Size = new Size(148, 24);
            chkShowMatKhau.TabIndex = 5;
            chkShowMatKhau.Text = "Hiển thị mật khẩu";
            chkShowMatKhau.UseVisualStyleBackColor = true;
            chkShowMatKhau.CheckedChanged += chkShowMatKhau_CheckedChanged;
            // 
            // panelMatKhau
            // 
            panelMatKhau.Controls.Add(lbMatKhau);
            panelMatKhau.Controls.Add(txtMatKhau);
            panelMatKhau.Location = new Point(23, 285);
            panelMatKhau.Name = "panelMatKhau";
            panelMatKhau.Size = new Size(293, 79);
            panelMatKhau.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMatKhau.ForeColor = SystemColors.ButtonHighlight;
            lbMatKhau.Location = new Point(0, 9);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(91, 23);
            lbMatKhau.TabIndex = 2;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.ControlLightLight;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.DimGray;
            txtMatKhau.Location = new Point(0, 35);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(293, 34);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.Text = "Nhập mật khẩu";
            txtMatKhau.Enter += txtMatKhau_Enter;
            txtMatKhau.Leave += txtMatKhau_Leave;
            // 
            // lbTenForm
            // 
            lbTenForm.AutoSize = true;
            lbTenForm.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenForm.ForeColor = SystemColors.ButtonHighlight;
            lbTenForm.Location = new Point(30, 135);
            lbTenForm.Name = "lbTenForm";
            lbTenForm.Size = new Size(280, 38);
            lbTenForm.TabIndex = 0;
            lbTenForm.Text = "Đăng nhập NT Mart";
            // 
            // panelTenDangNhap
            // 
            panelTenDangNhap.Controls.Add(lbTenDangNhap);
            panelTenDangNhap.Controls.Add(txtTenDangNhap);
            panelTenDangNhap.Location = new Point(23, 200);
            panelTenDangNhap.Name = "panelTenDangNhap";
            panelTenDangNhap.Size = new Size(293, 79);
            panelTenDangNhap.TabIndex = 3;
            // 
            // lbTenDangNhap
            // 
            lbTenDangNhap.AutoSize = true;
            lbTenDangNhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenDangNhap.ForeColor = SystemColors.ButtonHighlight;
            lbTenDangNhap.Location = new Point(0, 9);
            lbTenDangNhap.Name = "lbTenDangNhap";
            lbTenDangNhap.Size = new Size(133, 23);
            lbTenDangNhap.TabIndex = 2;
            lbTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = SystemColors.ControlLightLight;
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = Color.DimGray;
            txtTenDangNhap.Location = new Point(0, 35);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(293, 34);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.Text = "Nhập tên đăng nhập";
            txtTenDangNhap.Enter += txtTenDangNhap_Enter;
            txtTenDangNhap.Leave += txtTenDangNhap_Leave;
            // 
            // frmLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(404, 591);
            Controls.Add(panelLogin);
            Controls.Add(panelDock);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelDock.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelMatKhau.ResumeLayout(false);
            panelMatKhau.PerformLayout();
            panelTenDangNhap.ResumeLayout(false);
            panelTenDangNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDock;
        private Button btnCloseLogin;
        private Panel panelLogin;
        private Label lbTenForm;
        private TextBox txtTenDangNhap;
        private Panel panelTenDangNhap;
        private Label lbTenDangNhap;
        private Panel panelMatKhau;
        private Label lbMatKhau;
        private TextBox txtMatKhau;
        private CheckBox chkShowMatKhau;
        private Button btnDangNhap;
        private PictureBox picLogo;
    }
}
