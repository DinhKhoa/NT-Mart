using System.Data;
using Microsoft.Data.SqlClient;
namespace NT_Mart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static SqlConnection ConnectionSQL()
        {
            SqlConnection sql = new SqlConnection("Data Source=DESKTOP-LAPTOP;Initial Catalog=\"NT Mart\";Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            try
            {
                sql.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thể kết nối Database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sql;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Nhập tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Nhập tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.DimGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
                chkShowMatKhau.Enabled = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.DimGray;
                txtMatKhau.UseSystemPasswordChar = false;
                chkShowMatKhau.Enabled = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sUsername = txtTenDangNhap.Text.Trim();
            string sPassword = txtMatKhau.Text.Trim();
            SqlConnection sql = ConnectionSQL();
            using (SqlCommand cmd = new SqlCommand("sp_CheckUsersForLogin", sql))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", sUsername);
                cmd.Parameters.AddWithValue("@Password", sPassword);
                SqlParameter retParam = new SqlParameter("@ketQuaTraVe", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(retParam);
                cmd.CommandTimeout = 5;
                cmd.ExecuteNonQuery();
                bool isValid = Convert.ToBoolean(retParam.Value);

                if (isValid)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread th = new Thread(OpenFormQuanLy);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập/mật khẩu không đúng hoặc không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sql.Close();
            }
        }
        private void OpenFormQuanLy()
        {
            Application.Run(new QuanLy());
        }
    }
}
