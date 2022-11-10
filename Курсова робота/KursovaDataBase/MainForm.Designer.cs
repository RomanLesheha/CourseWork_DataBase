
namespace KursovaDataBase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Statictics_btn = new System.Windows.Forms.Button();
            this.Authorization_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.PictureBox();
            this.teachers_comboBox = new System.Windows.Forms.ComboBox();
            this.DeteleDB_btn = new System.Windows.Forms.Button();
            this.teachers_check = new System.Windows.Forms.RadioButton();
            this.students_check = new System.Windows.Forms.RadioButton();
            this.students_comboBox = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.search_field = new System.Windows.Forms.TextBox();
            this.students_dataGridView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberGradeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teachers_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Update_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Statictics_btn);
            this.panel2.Controls.Add(this.Authorization_btn);
            this.panel2.Controls.Add(this.Update_btn);
            this.panel2.Controls.Add(this.teachers_comboBox);
            this.panel2.Controls.Add(this.DeteleDB_btn);
            this.panel2.Controls.Add(this.teachers_check);
            this.panel2.Controls.Add(this.students_check);
            this.panel2.Controls.Add(this.students_comboBox);
            this.panel2.Controls.Add(this.Search_btn);
            this.panel2.Controls.Add(this.Add_btn);
            this.panel2.Controls.Add(this.search_field);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 669);
            this.panel2.TabIndex = 2;
            // 
            // Statictics_btn
            // 
            this.Statictics_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Statictics_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Statictics_btn.BackgroundImage")));
            this.Statictics_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statictics_btn.ForeColor = System.Drawing.Color.White;
            this.Statictics_btn.Location = new System.Drawing.Point(134, 498);
            this.Statictics_btn.Name = "Statictics_btn";
            this.Statictics_btn.Size = new System.Drawing.Size(100, 47);
            this.Statictics_btn.TabIndex = 18;
            this.Statictics_btn.Text = "Статистика";
            this.Statictics_btn.UseVisualStyleBackColor = true;
            this.Statictics_btn.Click += new System.EventHandler(this.Statictics_btn_Click);
            // 
            // Authorization_btn
            // 
            this.Authorization_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Authorization_btn.BackColor = System.Drawing.Color.White;
            this.Authorization_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Authorization_btn.BackgroundImage")));
            this.Authorization_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization_btn.ForeColor = System.Drawing.Color.White;
            this.Authorization_btn.Location = new System.Drawing.Point(107, 604);
            this.Authorization_btn.Name = "Authorization_btn";
            this.Authorization_btn.Size = new System.Drawing.Size(145, 39);
            this.Authorization_btn.TabIndex = 17;
            this.Authorization_btn.Text = "Авторизуватись";
            this.Authorization_btn.UseVisualStyleBackColor = false;
            this.Authorization_btn.Click += new System.EventHandler(this.Authorization_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update_btn.BackgroundImage")));
            this.Update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_btn.Image = ((System.Drawing.Image)(resources.GetObject("Update_btn.Image")));
            this.Update_btn.Location = new System.Drawing.Point(297, 3);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(45, 46);
            this.Update_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Update_btn.TabIndex = 16;
            this.Update_btn.TabStop = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // teachers_comboBox
            // 
            this.teachers_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.teachers_comboBox.FormattingEnabled = true;
            this.teachers_comboBox.Items.AddRange(new object[] {
            "По алфавіту",
            "За кафедрою",
            "За посадою"});
            this.teachers_comboBox.Location = new System.Drawing.Point(58, 453);
            this.teachers_comboBox.Name = "teachers_comboBox";
            this.teachers_comboBox.Size = new System.Drawing.Size(254, 24);
            this.teachers_comboBox.TabIndex = 15;
            this.teachers_comboBox.Text = "Сортувати";
            this.teachers_comboBox.Visible = false;
            this.teachers_comboBox.SelectedIndexChanged += new System.EventHandler(this.teachers_comboBox_SelectedIndexChanged);
            // 
            // DeteleDB_btn
            // 
            this.DeteleDB_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeteleDB_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeteleDB_btn.BackgroundImage")));
            this.DeteleDB_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeteleDB_btn.ForeColor = System.Drawing.Color.White;
            this.DeteleDB_btn.Location = new System.Drawing.Point(240, 525);
            this.DeteleDB_btn.Name = "DeteleDB_btn";
            this.DeteleDB_btn.Size = new System.Drawing.Size(93, 47);
            this.DeteleDB_btn.TabIndex = 11;
            this.DeteleDB_btn.Text = "Очистити БД";
            this.DeteleDB_btn.UseVisualStyleBackColor = true;
            this.DeteleDB_btn.Click += new System.EventHandler(this.DeteleDB_btn_Click);
            // 
            // teachers_check
            // 
            this.teachers_check.AutoSize = true;
            this.teachers_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teachers_check.BackgroundImage")));
            this.teachers_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teachers_check.Location = new System.Drawing.Point(195, 12);
            this.teachers_check.Name = "teachers_check";
            this.teachers_check.Size = new System.Drawing.Size(96, 21);
            this.teachers_check.TabIndex = 14;
            this.teachers_check.Text = "Викладачі";
            this.teachers_check.UseVisualStyleBackColor = true;
            this.teachers_check.CheckedChanged += new System.EventHandler(this.teachers_check_CheckedChanged);
            // 
            // students_check
            // 
            this.students_check.AutoSize = true;
            this.students_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("students_check.BackgroundImage")));
            this.students_check.Checked = true;
            this.students_check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.students_check.Location = new System.Drawing.Point(58, 12);
            this.students_check.Name = "students_check";
            this.students_check.Size = new System.Drawing.Size(91, 21);
            this.students_check.TabIndex = 13;
            this.students_check.TabStop = true;
            this.students_check.Text = "Студенти";
            this.students_check.UseVisualStyleBackColor = true;
            this.students_check.CheckedChanged += new System.EventHandler(this.students_check_CheckedChanged);
            // 
            // students_comboBox
            // 
            this.students_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.students_comboBox.FormattingEnabled = true;
            this.students_comboBox.Items.AddRange(new object[] {
            "Оцінки за спаданням",
            "Оцінки за зростанням",
            "По алфавіту"});
            this.students_comboBox.Location = new System.Drawing.Point(58, 453);
            this.students_comboBox.Name = "students_comboBox";
            this.students_comboBox.Size = new System.Drawing.Size(254, 24);
            this.students_comboBox.TabIndex = 3;
            this.students_comboBox.Text = "Сортувати";
            this.students_comboBox.SelectedIndexChanged += new System.EventHandler(this.students_comboBox_SelectedIndexChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_btn.BackgroundImage")));
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(35, 525);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(93, 47);
            this.Search_btn.TabIndex = 12;
            this.Search_btn.Text = "Знайти";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add_btn.BackgroundImage")));
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(134, 551);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(100, 47);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Добавити";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // search_field
            // 
            this.search_field.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.search_field.Location = new System.Drawing.Point(58, 416);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(254, 22);
            this.search_field.TabIndex = 1;
            this.search_field.Text = "Введіть ПІБ чи групу...";
            this.search_field.Enter += new System.EventHandler(this.search_field_Enter);
            // 
            // students_dataGridView
            // 
            this.students_dataGridView.AllowUserToAddRows = false;
            this.students_dataGridView.AllowUserToDeleteRows = false;
            this.students_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.students_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.students_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.students_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.students_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.NumberGradeBook,
            this.Specialty,
            this.Group,
            this.GPU,
            this.Curator,
            this.EDIT,
            this.DELETE});
            this.students_dataGridView.Location = new System.Drawing.Point(373, 0);
            this.students_dataGridView.MinimumSize = new System.Drawing.Size(829, 490);
            this.students_dataGridView.Name = "students_dataGridView";
            this.students_dataGridView.ReadOnly = true;
            this.students_dataGridView.RowHeadersWidth = 51;
            this.students_dataGridView.RowTemplate.Height = 24;
            this.students_dataGridView.Size = new System.Drawing.Size(1135, 490);
            this.students_dataGridView.StandardTab = true;
            this.students_dataGridView.TabIndex = 3;
            this.students_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.students_dataGridView_CellClick);
            this.students_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.students_dataGridView_RowHeaderMouseClick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Fullname";
            this.FullName.HeaderText = "ПІБ";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // NumberGradeBook
            // 
            this.NumberGradeBook.DataPropertyName = "NumberGradeBook";
            this.NumberGradeBook.HeaderText = "Номер Заліковки";
            this.NumberGradeBook.MinimumWidth = 6;
            this.NumberGradeBook.Name = "NumberGradeBook";
            this.NumberGradeBook.ReadOnly = true;
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.HeaderText = "Спеціальність";
            this.Specialty.MinimumWidth = 6;
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Група";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // GPU
            // 
            this.GPU.DataPropertyName = "GPU";
            this.GPU.HeaderText = "Середній бал";
            this.GPU.MinimumWidth = 6;
            this.GPU.Name = "GPU";
            this.GPU.ReadOnly = true;
            // 
            // Curator
            // 
            this.Curator.DataPropertyName = "Curator";
            this.Curator.HeaderText = "Куратор";
            this.Curator.MinimumWidth = 6;
            this.Curator.Name = "Curator";
            this.Curator.ReadOnly = true;
            // 
            // EDIT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EDIT.DefaultCellStyle = dataGridViewCellStyle1;
            this.EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EDIT.HeaderText = "";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Text = "ЗМІНИТИ";
            this.EDIT.UseColumnTextForButtonValue = true;
            // 
            // DELETE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DELETE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE.HeaderText = "";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Text = "ВИДАЛИТИ";
            this.DELETE.UseColumnTextForButtonValue = true;
            // 
            // teachers_DataGridView
            // 
            this.teachers_DataGridView.AllowUserToAddRows = false;
            this.teachers_DataGridView.AllowUserToDeleteRows = false;
            this.teachers_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teachers_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachers_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.teachers_DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teachers_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachers_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.teachers_DataGridView.Location = new System.Drawing.Point(373, 485);
            this.teachers_DataGridView.MinimumSize = new System.Drawing.Size(829, 490);
            this.teachers_DataGridView.Name = "teachers_DataGridView";
            this.teachers_DataGridView.ReadOnly = true;
            this.teachers_DataGridView.RowHeadersWidth = 51;
            this.teachers_DataGridView.RowTemplate.Height = 24;
            this.teachers_DataGridView.Size = new System.Drawing.Size(1135, 490);
            this.teachers_DataGridView.StandardTab = true;
            this.teachers_DataGridView.TabIndex = 4;
            this.teachers_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teachers_DataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn2.FillWeight = 250F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Кафедра";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Посада";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Disciplines";
            this.dataGridViewTextBoxColumn4.FillWeight = 250F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Наукові дисципліни";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Degree";
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Науковий ступінь";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Groups";
            this.Column1.HeaderText = "Групи";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "ЗМІНИТИ";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "ВИДАЛИТИ";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 655);
            this.Controls.Add(this.teachers_DataGridView);
            this.Controls.Add(this.students_dataGridView);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1527, 702);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данних факультету електроніки та комп\'ютерних наук";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Update_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Update_btn;
        private System.Windows.Forms.ComboBox teachers_comboBox;
        private System.Windows.Forms.Button DeteleDB_btn;
        private System.Windows.Forms.RadioButton teachers_check;
        private System.Windows.Forms.RadioButton students_check;
        private System.Windows.Forms.ComboBox students_comboBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox search_field;
        public System.Windows.Forms.DataGridView students_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberGradeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curator;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
        public System.Windows.Forms.DataGridView teachers_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Button Authorization_btn;
        private System.Windows.Forms.Button Statictics_btn;
    }
}

