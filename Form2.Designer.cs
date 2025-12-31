namespace Sitzung
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            rbMonth = new RadioButton();
            rbWeek = new RadioButton();
            rbDay = new RadioButton();
            btnShow = new Button();
            dgvReport = new DataGridView();
            btnPdf = new Button();
            dtpReport = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMonth);
            groupBox1.Controls.Add(rbWeek);
            groupBox1.Controls.Add(rbDay);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Період";
            // 
            // rbMonth
            // 
            rbMonth.AutoSize = true;
            rbMonth.Location = new Point(6, 86);
            rbMonth.Name = "rbMonth";
            rbMonth.Size = new Size(79, 24);
            rbMonth.TabIndex = 2;
            rbMonth.Text = "Місяць";
            rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbWeek
            // 
            rbWeek.AutoSize = true;
            rbWeek.Location = new Point(6, 56);
            rbWeek.Name = "rbWeek";
            rbWeek.Size = new Size(91, 24);
            rbWeek.TabIndex = 1;
            rbWeek.Text = "Тиждень";
            rbWeek.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            rbDay.AutoSize = true;
            rbDay.Checked = true;
            rbDay.Location = new Point(6, 26);
            rbDay.Name = "rbDay";
            rbDay.Size = new Size(65, 24);
            rbDay.TabIndex = 0;
            rbDay.TabStop = true;
            rbDay.Text = "День";
            rbDay.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Azure;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Location = new Point(11, 143);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(166, 29);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.Azure;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(11, 211);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(360, 188);
            dgvReport.TabIndex = 3;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.Azure;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Location = new Point(205, 143);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(166, 29);
            btnPdf.TabIndex = 4;
            btnPdf.Text = "До PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // dtpReport
            // 
            dtpReport.Location = new Point(11, 178);
            dtpReport.Name = "dtpReport";
            dtpReport.Size = new Size(360, 27);
            dtpReport.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(384, 411);
            Controls.Add(dtpReport);
            Controls.Add(btnPdf);
            Controls.Add(dgvReport);
            Controls.Add(btnShow);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Звіт";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rbMonth;
        private RadioButton rbWeek;
        private RadioButton rbDay;
        private Button btnShow;
        private DataGridView dgvReport;
        private Button btnPdf;
        private DateTimePicker dtpReport;
    }
}