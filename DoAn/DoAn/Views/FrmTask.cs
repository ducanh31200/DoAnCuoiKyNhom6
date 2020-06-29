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

    public partial class FrmTask : Form
    {
        private int idPro;
        List<Resource> listRe;
        public int IdPro { get => idPro; set => idPro = value; }

        public FrmTask(int ID)
        {
            InitializeComponent();
            listRe = new List<Resource>();
            this.colID.DataPropertyName = nameof(Models.Task.ID);
            this.colTenTask.DataPropertyName = nameof(Models.Task.TenCongViec);
            this.colMoTa.DataPropertyName = nameof(Models.Task.MoTa);
            this.colDateFrom.DataPropertyName = nameof(Models.Task.NgayBatDau);
            this.colDateTo.DataPropertyName = nameof(Models.Task.NgayKetThuc);
            this.colNTH.DataPropertyName = nameof(Models.Task.IDResource);
            this.IdPro = ID;

            lstResource.Text = "";
            BindingSource source = new BindingSource();
            source.DataSource = TaskController.GetListTask(IdPro);
            this.dataTask.DataSource = source;
            BindingSource source2 = new BindingSource();
            source2.DataSource = ResourceController.getListResource();
            ccbNTH.DataSource = source2;
            ccbNTH.ValueMember = "ID";

        }

        private void BtnThemCongViec_Click(object sender, EventArgs e)
        {
            Models.Task task = new Models.Task();
            task.ID = TaskController.GetIDTask();
            task.IDProject = IdPro;
            task.TenCongViec = this.txtNhapTieuDe.Text.Trim();
            task.MoTa = this.rtxtMoTa.Text.Trim();
            task.NgayBatDau = this.dateBatDau.Value;
            task.NgayKetThuc = this.dateKetThuc.Value;
            string displayusers = "";
            for (int i = 0; i < lstResource.Items.Count; i++)
            {
                displayusers = displayusers + this.lstResource.Items[i] + "  ";
                task.IDResource = Convert.ToInt32(this.lstResource.Items[i]);

            }


            if (TaskController.AddTask(task) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }

            txtNhapTieuDe.Clear();

            ccbNTH.Text = "";
            rtxtMoTa.Text = "";
            lstResource.Text = "";
            dateKetThuc.Value = DateTime.Now;
            dateBatDau.Value = DateTime.Now;
            BindingSource source = new BindingSource();
            source.DataSource = TaskController.GetListTask(IdPro);
            this.dataTask.DataSource = source;
        }

        private void BtnXoaCongViec_Click(object sender, EventArgs e)
        {
            try
            {

                int idtask = Convert.ToInt32(this.dataTask.SelectedRows[0].Cells[0].Value.ToString());
                if (this.dataTask.SelectedRows.Count <= 0)
                {
                    return;
                }

                Models.Task task = TaskController.GetTask(idtask);
                TaskController.DeleteTask(task);
                BindingSource source = new BindingSource();
                source.DataSource = TaskController.GetListTask(IdPro);
                this.dataTask.DataSource = source;
            }
            catch
            {
                return;
            }

        }


        private void CcbNTH_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstResource.Items.Count; i++)
            {
                if (this.ccbNTH.Text == this.lstResource.Items[i].ToString())
                {
                    MessageBox.Show("Đã chọn !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
            if (ccbNTH.Text != "ProjectManagement.Models.Resource")
                lstResource.Items.Add(ccbNTH.Text);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LstResource_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstResource.SelectedIndex >= 0)
            {
                this.lstResource.Items.RemoveAt(this.lstResource.SelectedIndex);
            }
        }

        private void BtnSuaCongViec_Click(object sender, EventArgs e)
        {

        }
    }
}
