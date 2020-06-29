using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Models;
using ProjectManagement.Controllers;


namespace ProjectManagement.Views
{
    public partial class FrmResource : Form
    {
        List<Resource> listResource;
        public FrmResource(ref List<Resource> resources)
        {
            this.listResource = resources;
            InitializeComponent();
            this.colID.DataPropertyName = nameof(Resource.ID);
            this.ColName.DataPropertyName = nameof(Resource.Ten);
            this.ColRole.DataPropertyName = nameof(Resource.VaiTro);
            this.ColPhone.DataPropertyName = nameof(Resource.SoDienThoai);
            this.ColMail.DataPropertyName = nameof(Resource.Mail);
            this.colBirth.DataPropertyName = nameof(Resource.NgaySinh);

            BindingSource source = new BindingSource();
            source.DataSource = ResourceController.getListResource();
            this.dataResource.DataSource = source;

        }

        private void BtnThemUser_Click(object sender, EventArgs e)
        {
            Resource user = new Resource();
            user.ID = ResourceController.GetIDResource();


            user.Ten = this.txtHoTen.Text.Trim();
            user.NgaySinh = this.dtpNgaysinh.Value;
            user.VaiTro = this.cbbVaiTro.Text.Trim();
            user.SoDienThoai = this.txtPhone.Text.Trim();
            user.Mail = this.txtEmail.Text.Trim();
            // xóa các control để người dùng nhập tiếp

            if(ResourceController.AddResource(user)== false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            txtHoTen.Clear();
            cbbVaiTro.Text = "";
            txtEmail.Clear();
            txtPhone.Clear();
            dtpNgaysinh.Value = DateTime.Now;

            BindingSource source = new BindingSource();
            source.DataSource = ResourceController.getListResource();
            this.dataResource.DataSource = source;

        }

        private void DataResource_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            
            int idre = Convert.ToInt32(this.dataResource.SelectedRows[0].Cells[0].Value.ToString());
            if (this.dataResource.SelectedRows.Count <= 0)
            {
                return;
            }
            Resource user = ResourceController.GetResource(idre);
            ResourceController.DeleteResource(user);
            BindingSource source = new BindingSource();
            source.DataSource = ResourceController.getListResource();
            this.dataResource.DataSource = source;
            
        }
    }
}
