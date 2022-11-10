
namespace KursovaDataBase
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Statictics_btn = new System.Windows.Forms.Button();
            this.countstudent = new System.Windows.Forms.Label();
            this.gpu_label = new System.Windows.Forms.Label();
            this.max_mark_label = new System.Windows.Forms.Label();
            this.min_mark_label = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Статистика оцінок";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1018, 300);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            title1.Name = "Статистика оцінок";
            this.chart1.Titles.Add(title1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(153, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 93;
            this.label2.Text = "Група:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(102, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "Кількість студентів групи:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(102, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 95;
            this.label3.Text = "Середній бал:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(102, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 96;
            this.label4.Text = "Максимальний бал:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(102, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 21);
            this.label5.TabIndex = 97;
            this.label5.Text = "Мінімальний бал:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(231, 339);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 22);
            this.textBox1.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(231, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 99;
            // 
            // Statictics_btn
            // 
            this.Statictics_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Statictics_btn.FlatAppearance.BorderSize = 2;
            this.Statictics_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statictics_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Statictics_btn.Location = new System.Drawing.Point(673, 366);
            this.Statictics_btn.Name = "Statictics_btn";
            this.Statictics_btn.Size = new System.Drawing.Size(158, 60);
            this.Statictics_btn.TabIndex = 100;
            this.Statictics_btn.Text = "Показати статистику";
            this.Statictics_btn.UseVisualStyleBackColor = true;
            this.Statictics_btn.Click += new System.EventHandler(this.Statictics_btn_Click);
            // 
            // countstudent
            // 
            this.countstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countstudent.AutoSize = true;
            this.countstudent.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.countstudent.ForeColor = System.Drawing.Color.Red;
            this.countstudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.countstudent.Location = new System.Drawing.Point(370, 387);
            this.countstudent.Name = "countstudent";
            this.countstudent.Size = new System.Drawing.Size(0, 21);
            this.countstudent.TabIndex = 101;
            // 
            // gpu_label
            // 
            this.gpu_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpu_label.AutoSize = true;
            this.gpu_label.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.gpu_label.ForeColor = System.Drawing.Color.Red;
            this.gpu_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpu_label.Location = new System.Drawing.Point(250, 424);
            this.gpu_label.Name = "gpu_label";
            this.gpu_label.Size = new System.Drawing.Size(0, 21);
            this.gpu_label.TabIndex = 102;
            // 
            // max_mark_label
            // 
            this.max_mark_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.max_mark_label.AutoSize = true;
            this.max_mark_label.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.max_mark_label.ForeColor = System.Drawing.Color.Red;
            this.max_mark_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.max_mark_label.Location = new System.Drawing.Point(305, 457);
            this.max_mark_label.Name = "max_mark_label";
            this.max_mark_label.Size = new System.Drawing.Size(0, 21);
            this.max_mark_label.TabIndex = 103;
            // 
            // min_mark_label
            // 
            this.min_mark_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.min_mark_label.AutoSize = true;
            this.min_mark_label.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.min_mark_label.ForeColor = System.Drawing.Color.Red;
            this.min_mark_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.min_mark_label.Location = new System.Drawing.Point(284, 499);
            this.min_mark_label.Name = "min_mark_label";
            this.min_mark_label.Size = new System.Drawing.Size(0, 21);
            this.min_mark_label.TabIndex = 104;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(678, 445);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 25);
            this.radioButton1.TabIndex = 105;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "За групами";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bookman Old Style", 10.8F);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(678, 481);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(233, 25);
            this.radioButton2.TabIndex = 106;
            this.radioButton2.Text = "За студентами групи";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1042, 554);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.min_mark_label);
            this.Controls.Add(this.max_mark_label);
            this.Controls.Add(this.gpu_label);
            this.Controls.Add(this.countstudent);
            this.Controls.Add(this.Statictics_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1060, 601);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Statictics_btn;
        public System.Windows.Forms.Label countstudent;
        public System.Windows.Forms.Label gpu_label;
        public System.Windows.Forms.Label max_mark_label;
        public System.Windows.Forms.Label min_mark_label;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}