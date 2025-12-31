namespace Sitzung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategory = new ComboBox();
            dtpDate = new DateTimePicker();
            numAmount = new NumericUpDown();
            btnSave = new Button();
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.Azure;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(256, 26);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(194, 28);
            cmbCategory.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(25, 86);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(207, 27);
            dtpDate.TabIndex = 1;
            // 
            // numAmount
            // 
            numAmount.BackColor = Color.Azure;
            numAmount.DecimalPlaces = 2;
            numAmount.Location = new Point(25, 26);
            numAmount.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(207, 27);
            numAmount.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Azure;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(356, 84);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Azure;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Location = new Point(256, 84);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 29);
            btnReport.TabIndex = 4;
            btnReport.Text = "До звітів";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(478, 143);
            Controls.Add(btnReport);
            Controls.Add(btnSave);
            Controls.Add(numAmount);
            Controls.Add(dtpDate);
            Controls.Add(cmbCategory);
            Name = "Form1";
            Text = "Головна";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCategory;
        private DateTimePicker dtpDate;
        private NumericUpDown numAmount;
        private Button btnSave;
        private Button btnReport;
    }
}
