namespace BeeQueen
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            shifts = new NumericUpDown();
            workerBeeJob = new ComboBox();
            label1 = new Label();
            nextShift = new Button();
            report = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(shifts);
            groupBox1.Controls.Add(workerBeeJob);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przydział prac robotnicom";
            // 
            // button1
            // 
            button1.Location = new Point(6, 66);
            button1.Name = "button1";
            button1.Size = new Size(294, 23);
            button1.TabIndex = 4;
            button1.Text = "Przypisz tę pracę pszczole";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Zmiany";
            // 
            // shifts
            // 
            shifts.Location = new Point(180, 38);
            shifts.Name = "shifts";
            shifts.Size = new Size(120, 23);
            shifts.TabIndex = 2;
            // 
            // workerBeeJob
            // 
            workerBeeJob.DropDownStyle = ComboBoxStyle.DropDownList;
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Location = new Point(6, 37);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(168, 23);
            workerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Zadanie robotnicy";
            // 
            // nextShift
            // 
            nextShift.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nextShift.Location = new Point(325, 12);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(169, 104);
            nextShift.TabIndex = 1;
            nextShift.Text = "Przepracuj następną zmianę";
            nextShift.UseVisualStyleBackColor = true;
            nextShift.Click += nextShift_Click;
            // 
            // report
            // 
            report.Location = new Point(12, 122);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(482, 215);
            report.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 345);
            Controls.Add(report);
            Controls.Add(nextShift);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown shifts;
        private ComboBox workerBeeJob;
        private Label label1;
        private Button button1;
        private Button nextShift;
        private TextBox report;
    }
}
