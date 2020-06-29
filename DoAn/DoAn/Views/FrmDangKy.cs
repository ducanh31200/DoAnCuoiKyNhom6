using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Controllers;
using ProjectManagement.Models;

namespace ProjectManagement.Views
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }

       

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_DangKy_Click(object sender, EventArgs e)
        {
            if(txtTK.Text =="" || txtCheckPass.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Account account = new Account();
            account.TenDangNhap = txtTK.Text.ToString();
            if(txtPass.Text.ToString() != txtCheckPass.Text.ToString())
            {
                MessageBox.Show("Nhập mật khẩu chưa giống nhau, mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            account.MatKhau = txtPass.Text.ToString();

            if(AccountController.AddAccount(account))
            {
                MessageBox.Show("Đăng kí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Clear();
                txtPass.Clear();
                txtCheckPass.Clear();
                return;
            }

        }
    }
}
