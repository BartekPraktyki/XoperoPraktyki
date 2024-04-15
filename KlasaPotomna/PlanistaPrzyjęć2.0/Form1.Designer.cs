namespace PlanistaPrzyjęć2._0
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            costLabel = new Label();
            label2 = new Label();
            healthyBox = new CheckBox();
            fancyBox = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            tabPage2 = new TabPage();
            cakeWriting = new TextBox();
            TooLongLabel = new Label();
            label7 = new Label();
            label4 = new Label();
            birthdayCost = new Label();
            fancyBirthday = new CheckBox();
            numberBirthday = new NumericUpDown();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(345, 250);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(costLabel);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(healthyBox);
            tabPage1.Controls.Add(fancyBox);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(337, 222);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Impreza okolicznościowa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            costLabel.BorderStyle = BorderStyle.Fixed3D;
            costLabel.Location = new Point(63, 107);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(100, 23);
            costLabel.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(7, 107);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 10;
            label2.Text = "Koszt";
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(7, 75);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(98, 19);
            healthyBox.TabIndex = 9;
            healthyBox.Text = "Opcja zdrowa";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += healthyBox_CheckedChanged;
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Checked = true;
            fancyBox.CheckState = CheckState.Checked;
            fancyBox.Location = new Point(7, 50);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(135, 19);
            fancyBox.TabIndex = 8;
            fancyBox.Text = "Dekoracje fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += fancyBox_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(7, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Ilość osób";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cakeWriting);
            tabPage2.Controls.Add(TooLongLabel);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(birthdayCost);
            tabPage2.Controls.Add(fancyBirthday);
            tabPage2.Controls.Add(numberBirthday);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(337, 222);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Przyjęcie urodzinowe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cakeWriting
            // 
            cakeWriting.Location = new Point(8, 99);
            cakeWriting.Name = "cakeWriting";
            cakeWriting.Size = new Size(167, 23);
            cakeWriting.TabIndex = 16;
            cakeWriting.Text = "Sto lat!";
            cakeWriting.TextChanged += cakeWriting_TextChanged;
            // 
            // TooLongLabel
            // 
            TooLongLabel.AutoSize = true;
            TooLongLabel.BackColor = Color.Red;
            TooLongLabel.Location = new Point(105, 72);
            TooLongLabel.Name = "TooLongLabel";
            TooLongLabel.Size = new Size(70, 15);
            TooLongLabel.TabIndex = 15;
            TooLongLabel.Text = "ZBYT DŁUGI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 72);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 14;
            label7.Text = "Napis na torcie";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(64, 169);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 13;
            // 
            // birthdayCost
            // 
            birthdayCost.AutoSize = true;
            birthdayCost.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            birthdayCost.Location = new Point(8, 169);
            birthdayCost.Name = "birthdayCost";
            birthdayCost.Size = new Size(41, 17);
            birthdayCost.TabIndex = 12;
            birthdayCost.Text = "Koszt";
            // 
            // fancyBirthday
            // 
            fancyBirthday.AutoSize = true;
            fancyBirthday.Checked = true;
            fancyBirthday.CheckState = CheckState.Checked;
            fancyBirthday.Location = new Point(8, 50);
            fancyBirthday.Name = "fancyBirthday";
            fancyBirthday.Size = new Size(135, 19);
            fancyBirthday.TabIndex = 8;
            fancyBirthday.Text = "Dekoracje fantazyjne";
            fancyBirthday.UseVisualStyleBackColor = true;
            fancyBirthday.CheckedChanged += fancyBirthday_CheckedChanged;
            // 
            // numberBirthday
            // 
            numberBirthday.Location = new Point(8, 21);
            numberBirthday.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numberBirthday.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberBirthday.Name = "numberBirthday";
            numberBirthday.Size = new Size(120, 23);
            numberBirthday.TabIndex = 7;
            numberBirthday.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numberBirthday.ValueChanged += numberBirthday_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 3);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 6;
            label6.Text = "Ilość osób";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 244);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberBirthday).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label costLabel;
        private Label label2;
        private CheckBox healthyBox;
        private CheckBox fancyBox;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label TooLongLabel;
        private Label label7;
        private Label label4;
        private Label birthdayCost;
        private CheckBox fancyBirthday;
        private NumericUpDown numberBirthday;
        private Label label6;
        private TextBox cakeWriting;
    }
}
