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
    public partial class FrmProject : Form
    {
        int Doc = 51;
        int Ngang = 41;
        int col = 7;
        int row = 6;
        List<Project> listProject;

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private List<string> dayOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        FrmTask formTask;

       

        public FrmProject()
        {
            listProject = new List<Project>();
            InitializeComponent();
            this.colID.DataPropertyName = nameof(Project.ID);
            this.colTenPro.DataPropertyName = nameof(Project.TenProject);
            this.colDateFrom.DataPropertyName = nameof(Project.NgayBatDau);
            this.colDateTo.DataPropertyName = nameof(Project.NgayKetThuc);

            

            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.GetListProject();
            this.dataProject.DataSource = source;

            createCalendar();
        }

        void clearCalendar()
        {
            for(int i=0;i<matrix.Count;i++)
            {
                for(int j=0;j<matrix[i].Count;j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.Gray;
                }
            }
        }

        void createCalendar()
        {
            Matrix = new List<List<Button>>();
            
            Button o = new Button();
            {
                o.Height = 0;
                o.Width = 0;
                o.Location = new Point(-2, 5);
            }
            for (int i = 0; i < row; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= col; j++)
                {
                    Button btn = new Button();
                    {
                        btn.Width = Doc;
                        btn.Height = Ngang;
                        btn.Location = new Point(o.Location.X + o.Width + 5, o.Location.Y);
                        
                        btn.Tag = i.ToString();
                    }
                    btn.Click += Btn_Click;
                    panel_Calendar.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    o = btn;
                    
                }
                o.Location = new Point(-2, o.Location.Y + Ngang + 5);
                o.Height = 0;
                o.Width = 0;
            }
            setDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
        }

        int dayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31; 
                case 2:
                    if (date.Year % 4 == 0 && date.Year % 100 != 0 || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void setDefaultDate()
        {
            dtpk_date.Value = DateTime.Now;
        }
        void showCalendar(DateTime date)
        {
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            clearCalendar();
            int line = 0;

            for(int i=1;i <= dayOfMonth(date);i++)
            {
                int col = dayOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrix[line][col];
                if (selectedDay(useDate, DateTime.Now))
                    btn.BackColor = Color.Yellow;
                listProject = ProjectController.GetListProject().ToList();
                foreach(Project pro in listProject)
                {
                    if (selectedDay(useDate, pro.NgayBatDau.Value))
                        btn.BackColor = Color.Green;
                    if (selectedDay(useDate, pro.NgayKetThuc.Value))
                        btn.BackColor = Color.Red;
                }

                btn.Text = i.ToString();
                if (col >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }
        bool selectedDay(DateTime A,DateTime B)
        {
            return A.Year == B.Year && A.Month == B.Month && A.Day == B.Day;
        }


        private void Dtpk_date_ValueChanged(object sender, EventArgs e)
        {
            showCalendar((sender as DateTimePicker).Value);
        }

       

        private void Btn_TaskOfProject_Click(object sender, EventArgs e)
        {
            if (this.dataProject.SelectedRows.Count <= 0)
            {
                return;
            }
            int id = Convert.ToInt32(this.dataProject.SelectedRows[0].Cells[0].Value.ToString());
            formTask = new FrmTask(id);
            formTask.ShowDialog();
        }
        


        private void Btn_toDay_Click(object sender, EventArgs e)
        {
            setDefaultDate();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnThemProject_Click(object sender, EventArgs e)
        {
            
            Project project = new Project();
            project.ID = ProjectController.GetIDProject();


            project.TenProject = this.txtTenProject.Text.Trim();
            project.NgayBatDau = this.dateBatDau.Value;
            project.NgayKetThuc = this.dateKetThuc.Value;

            listProject.Add(project);
            // xóa các control để người dùng nhập tiếp

            if (ProjectController.AddProject(project) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }

            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.GetListProject();
            this.dataProject.DataSource = source;

            txtTenProject.Clear();

            dateBatDau.Value = DateTime.Now;
            dateKetThuc.Value = DateTime.Now;

            
        }

        private void BtnSuaProject_Click(object sender, EventArgs e)
        {

        }



        private void BtnXoaProject_Click(object sender, EventArgs e)
        {
            try
            {
                int idre = Convert.ToInt32(this.dataProject.SelectedRows[0].Cells[0].Value.ToString());
                if (this.dataProject.SelectedRows.Count <= 0)
                {
                    return;
                }
                Project project = ProjectController.GetProject(idre);
                ProjectController.DeleteProject(project);
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.GetListProject();
                this.dataProject.DataSource = source;
            }
            catch
            {
                MessageBox.Show("Không xóa được ! vui lòng thử lại !", "Thông báo !");
                return;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
