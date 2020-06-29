namespace ProjectManagement.Views
{
    partial class FrmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataProject = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaProject = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btn_TaskOfProject = new System.Windows.Forms.Button();
            this.txtTenProject = new System.Windows.Forms.TextBox();
            this.btnThemProject = new System.Windows.Forms.Button();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.panel_Calendar = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_toDay = new System.Windows.Forms.Button();
            this.dtpk_date = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProject)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnXoaProject);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Controls.Add(this.btn_TaskOfProject);
            this.panel1.Controls.Add(this.txtTenProject);
            this.panel1.Controls.Add(this.btnThemProject);
            this.panel1.Controls.Add(this.dateKetThuc);
            this.panel1.Controls.Add(this.lblKetThuc);
            this.panel1.Controls.Add(this.dateBatDau);
            this.panel1.Controls.Add(this.lblBatDau);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 441);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataProject);
            this.panel3.Location = new System.Drawing.Point(5, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 238);
            this.panel3.TabIndex = 25;
            // 
            // dataProject
            // 
            this.dataProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenPro,
            this.colDateFrom,
            this.colDateTo});
            this.dataProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProject.Location = new System.Drawing.Point(0, 0);
            this.dataProject.Name = "dataProject";
            this.dataProject.Size = new System.Drawing.Size(413, 238);
            this.dataProject.TabIndex = 25;
            this.dataProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 43;
            // 
            // colTenPro
            // 
            this.colTenPro.HeaderText = "Tên project";
            this.colTenPro.Name = "colTenPro";
            this.colTenPro.ReadOnly = true;
            this.colTenPro.Width = 86;
            // 
            // colDateFrom
            // 
            this.colDateFrom.HeaderText = "Ngày bắt đầu";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ReadOnly = true;
            this.colDateFrom.Width = 97;
            // 
            // colDateTo
            // 
            this.colDateTo.HeaderText = "Ngày kết thúc";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ReadOnly = true;
            this.colDateTo.Width = 99;
            // 
            // btnXoaProject
            // 
            this.btnXoaProject.Location = new System.Drawing.Point(126, 128);
            this.btnXoaProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaProject.Name = "btnXoaProject";
            this.btnXoaProject.Size = new System.Drawing.Size(68, 61);
            this.btnXoaProject.TabIndex = 21;
            this.btnXoaProject.Text = "Xóa project";
            this.btnXoaProject.UseVisualStyleBackColor = true;
            this.btnXoaProject.Click += new System.EventHandler(this.BtnXoaProject_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(2, 10);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(61, 13);
            this.lblTieuDe.TabIndex = 11;
            this.lblTieuDe.Text = "Tên project";
            // 
            // btn_TaskOfProject
            // 
            this.btn_TaskOfProject.Location = new System.Drawing.Point(264, 128);
            this.btn_TaskOfProject.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaskOfProject.Name = "btn_TaskOfProject";
            this.btn_TaskOfProject.Size = new System.Drawing.Size(68, 61);
            this.btn_TaskOfProject.TabIndex = 20;
            this.btn_TaskOfProject.Text = "Công việc của project";
            this.btn_TaskOfProject.UseVisualStyleBackColor = true;
            this.btn_TaskOfProject.Click += new System.EventHandler(this.Btn_TaskOfProject_Click);
            // 
            // txtTenProject
            // 
            this.txtTenProject.Location = new System.Drawing.Point(67, 7);
            this.txtTenProject.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenProject.Name = "txtTenProject";
            this.txtTenProject.Size = new System.Drawing.Size(179, 20);
            this.txtTenProject.TabIndex = 12;
            // 
            // btnThemProject
            // 
            this.btnThemProject.Location = new System.Drawing.Point(5, 128);
            this.btnThemProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemProject.Name = "btnThemProject";
            this.btnThemProject.Size = new System.Drawing.Size(68, 61);
            this.btnThemProject.TabIndex = 19;
            this.btnThemProject.Text = "Thêm project";
            this.btnThemProject.UseVisualStyleBackColor = true;
            this.btnThemProject.Click += new System.EventHandler(this.BtnThemProject_Click);
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKetThuc.Location = new System.Drawing.Point(67, 88);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(179, 20);
            this.dateKetThuc.TabIndex = 18;
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Location = new System.Drawing.Point(2, 94);
            this.lblKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(47, 13);
            this.lblKetThuc.TabIndex = 16;
            this.lblKetThuc.Text = "Kết thúc";
            // 
            // dateBatDau
            // 
            this.dateBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBatDau.Location = new System.Drawing.Point(67, 43);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(179, 20);
            this.dateBatDau.TabIndex = 17;
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = true;
            this.lblBatDau.Location = new System.Drawing.Point(2, 50);
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(45, 13);
            this.lblBatDau.TabIndex = 15;
            this.lblBatDau.Text = "Bắt đầu";
            // 
            // panel_Calendar
            // 
            this.panel_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Calendar.AutoSize = true;
            this.panel_Calendar.Location = new System.Drawing.Point(440, 180);
            this.panel_Calendar.Name = "panel_Calendar";
            this.panel_Calendar.Size = new System.Drawing.Size(412, 313);
            this.panel_Calendar.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btn_toDay);
            this.panel2.Controls.Add(this.dtpk_date);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(440, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 117);
            this.panel2.TabIndex = 1;
            // 
            // btn_toDay
            // 
            this.btn_toDay.Location = new System.Drawing.Point(257, 29);
            this.btn_toDay.Name = "btn_toDay";
            this.btn_toDay.Size = new System.Drawing.Size(67, 20);
            this.btn_toDay.TabIndex = 0;
            this.btn_toDay.Text = "Hôm nay";
            this.btn_toDay.UseVisualStyleBackColor = true;
            this.btn_toDay.Click += new System.EventHandler(this.Btn_toDay_Click);
            // 
            // dtpk_date
            // 
            this.dtpk_date.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dtpk_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_date.Location = new System.Drawing.Point(59, 29);
            this.dtpk_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtpk_date.Name = "dtpk_date";
            this.dtpk_date.Size = new System.Drawing.Size(165, 20);
            this.dtpk_date.TabIndex = 17;
            this.dtpk_date.ValueChanged += new System.EventHandler(this.Dtpk_date_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thứ 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(339, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "Chủ nhật";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(283, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "Thứ 7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(227, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Thứ 6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Thứ 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thứ 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thứ 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Calendar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProject";
            this.Text = "FrmProject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProject)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Calendar;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTenProject;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Button btnThemProject;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpk_date;
        private System.Windows.Forms.Button btn_toDay;
        private System.Windows.Forms.Button btnXoaProject;
        private System.Windows.Forms.Button btn_TaskOfProject;
        private System.Windows.Forms.DataGridView dataProject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}