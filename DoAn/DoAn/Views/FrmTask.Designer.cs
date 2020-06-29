namespace ProjectManagement.Views
{
    partial class FrmTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataTask = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstResource = new System.Windows.Forms.ListBox();
            this.ccbNTH = new System.Windows.Forms.ComboBox();
            this.btnXoaCongViec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenCongViec = new System.Windows.Forms.Label();
            this.txtNhapTieuDe = new System.Windows.Forms.TextBox();
            this.btnThemCongViec = new System.Windows.Forms.Button();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTask)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataTask);
            this.panel1.Controls.Add(this.lstResource);
            this.panel1.Controls.Add(this.ccbNTH);
            this.panel1.Controls.Add(this.btnXoaCongViec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTenCongViec);
            this.panel1.Controls.Add(this.txtNhapTieuDe);
            this.panel1.Controls.Add(this.btnThemCongViec);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.dateKetThuc);
            this.panel1.Controls.Add(this.lblKetThuc);
            this.panel1.Controls.Add(this.rtxtMoTa);
            this.panel1.Controls.Add(this.dateBatDau);
            this.panel1.Controls.Add(this.lblBatDau);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 521);
            this.panel1.TabIndex = 24;
            // 
            // dataTask
            // 
            this.dataTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenTask,
            this.colMoTa,
            this.colDateFrom,
            this.colDateTo,
            this.colNTH});
            this.dataTask.Location = new System.Drawing.Point(8, 201);
            this.dataTask.Name = "dataTask";
            this.dataTask.Size = new System.Drawing.Size(550, 317);
            this.dataTask.TabIndex = 26;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 43;
            // 
            // colTenTask
            // 
            this.colTenTask.HeaderText = "Tên công việc";
            this.colTenTask.Name = "colTenTask";
            this.colTenTask.ReadOnly = true;
            this.colTenTask.Width = 93;
            // 
            // colMoTa
            // 
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Width = 47;
            // 
            // colDateFrom
            // 
            this.colDateFrom.HeaderText = "Ngày bắt đầu";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.ReadOnly = true;
            this.colDateFrom.Width = 72;
            // 
            // colDateTo
            // 
            this.colDateTo.HeaderText = "Ngày kết thúc";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.ReadOnly = true;
            this.colDateTo.Width = 72;
            // 
            // colNTH
            // 
            this.colNTH.HeaderText = "Người thực hiện";
            this.colNTH.Name = "colNTH";
            this.colNTH.ReadOnly = true;
            this.colNTH.Width = 80;
            // 
            // lstResource
            // 
            this.lstResource.FormattingEnabled = true;
            this.lstResource.Location = new System.Drawing.Point(410, 35);
            this.lstResource.Name = "lstResource";
            this.lstResource.Size = new System.Drawing.Size(142, 160);
            this.lstResource.TabIndex = 24;
            this.lstResource.DoubleClick += new System.EventHandler(this.LstResource_DoubleClick);
            // 
            // ccbNTH
            // 
            this.ccbNTH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ccbNTH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ccbNTH.FormattingEnabled = true;
            this.ccbNTH.Location = new System.Drawing.Point(410, 2);
            this.ccbNTH.Name = "ccbNTH";
            this.ccbNTH.Size = new System.Drawing.Size(142, 21);
            this.ccbNTH.TabIndex = 23;
            this.ccbNTH.SelectedIndexChanged += new System.EventHandler(this.CcbNTH_SelectedIndexChanged);
            // 
            // btnXoaCongViec
            // 
            this.btnXoaCongViec.Location = new System.Drawing.Point(285, 122);
            this.btnXoaCongViec.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaCongViec.Name = "btnXoaCongViec";
            this.btnXoaCongViec.Size = new System.Drawing.Size(94, 47);
            this.btnXoaCongViec.TabIndex = 21;
            this.btnXoaCongViec.Text = "Xóa project";
            this.btnXoaCongViec.UseVisualStyleBackColor = true;
            this.btnXoaCongViec.Click += new System.EventHandler(this.BtnXoaCongViec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Người thực hiện";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblTenCongViec
            // 
            this.lblTenCongViec.AutoSize = true;
            this.lblTenCongViec.Location = new System.Drawing.Point(2, 10);
            this.lblTenCongViec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenCongViec.Name = "lblTenCongViec";
            this.lblTenCongViec.Size = new System.Drawing.Size(44, 13);
            this.lblTenCongViec.TabIndex = 11;
            this.lblTenCongViec.Text = "Tiêu đề";
            // 
            // txtNhapTieuDe
            // 
            this.txtNhapTieuDe.Location = new System.Drawing.Point(50, 7);
            this.txtNhapTieuDe.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapTieuDe.Name = "txtNhapTieuDe";
            this.txtNhapTieuDe.Size = new System.Drawing.Size(165, 20);
            this.txtNhapTieuDe.TabIndex = 12;
            // 
            // btnThemCongViec
            // 
            this.btnThemCongViec.Location = new System.Drawing.Point(285, 47);
            this.btnThemCongViec.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCongViec.Name = "btnThemCongViec";
            this.btnThemCongViec.Size = new System.Drawing.Size(94, 47);
            this.btnThemCongViec.TabIndex = 19;
            this.btnThemCongViec.Text = "Thêm project";
            this.btnThemCongViec.UseVisualStyleBackColor = true;
            this.btnThemCongViec.Click += new System.EventHandler(this.BtnThemCongViec_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(2, 47);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(34, 13);
            this.lblMoTa.TabIndex = 13;
            this.lblMoTa.Text = "Mô tả";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateKetThuc.Location = new System.Drawing.Point(64, 164);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(151, 20);
            this.dateKetThuc.TabIndex = 18;
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Location = new System.Drawing.Point(2, 170);
            this.lblKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(47, 13);
            this.lblKetThuc.TabIndex = 16;
            this.lblKetThuc.Text = "Kết thúc";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(50, 44);
            this.rtxtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(165, 63);
            this.rtxtMoTa.TabIndex = 14;
            this.rtxtMoTa.Text = "";
            // 
            // dateBatDau
            // 
            this.dateBatDau.CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBatDau.Location = new System.Drawing.Point(64, 122);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(151, 20);
            this.dateBatDau.TabIndex = 17;
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = true;
            this.lblBatDau.Location = new System.Drawing.Point(2, 128);
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(45, 13);
            this.lblBatDau.TabIndex = 15;
            this.lblBatDau.Text = "Bắt đầu";
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTask";
            this.Text = "FrmTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstResource;
        private System.Windows.Forms.ComboBox ccbNTH;
        private System.Windows.Forms.Button btnXoaCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenCongViec;
        private System.Windows.Forms.TextBox txtNhapTieuDe;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.DataGridView dataTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNTH;
    }
}