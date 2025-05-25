namespace NT_Mart
{
    partial class QuanLy
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
            panel1 = new Panel();
            btnCloseQuanLy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCloseQuanLy);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 42);
            panel1.TabIndex = 0;
            // 
            // btnCloseQuanLy
            // 
            btnCloseQuanLy.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseQuanLy.Location = new Point(941, -3);
            btnCloseQuanLy.Name = "btnCloseQuanLy";
            btnCloseQuanLy.Size = new Size(44, 45);
            btnCloseQuanLy.TabIndex = 1;
            btnCloseQuanLy.Text = "X";
            btnCloseQuanLy.UseVisualStyleBackColor = true;
            btnCloseQuanLy.Click += btnCloseQuanLy_Click;
            // 
            // QuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 566);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLy";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCloseQuanLy;
    }
}