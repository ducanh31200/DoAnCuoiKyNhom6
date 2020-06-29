using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Views;
using ProjectManagement.Models;

namespace ProjectManagement
{
    public partial class MDIFrm : Form
    {
        FrmProject frmPro;
        FrmResource frmRe;

        List<Resource> listResource;



        public MDIFrm()
        {
            InitializeComponent();
        }

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmPro is null || this.frmPro.IsDisposed)
            {
                this.frmPro = new FrmProject();
                this.frmPro.MdiParent = this;
                this.frmPro.Show();
            }
            else
            {
                this.frmPro.Select();
            }
        }
        private void ResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmRe is null || this.frmRe.IsDisposed)
            {
                this.frmRe = new FrmResource(ref listResource);
                this.frmRe.MdiParent = this;
                this.frmRe.Show();
            }
            else
            {
                this.frmRe.Select();
            }
        }

        private void TasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MDIFrm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

      
        private void TabMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void MDIFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "THÔNG BÁO",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi != DialogResult.OK)
                e.Cancel = true;
            
        }

        private void MDIFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
