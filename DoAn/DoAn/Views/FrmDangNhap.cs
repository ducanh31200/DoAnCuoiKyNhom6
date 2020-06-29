using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjectManagement.Controllers;

namespace ProjectManagement.Views
{
     public partial class FrmDangNhap : Form
    {

        public FrmDangNhap()
        {
            InitializeComponent();
        }
        
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if(AccountController.CheckAccount(txtTKhoan.Text.ToString(),txtPass.Text.ToString()))
            { 
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MDIFrm form = new MDIFrm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "THÔNG BÁO",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi != DialogResult.OK)
                e.Cancel = true;
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
