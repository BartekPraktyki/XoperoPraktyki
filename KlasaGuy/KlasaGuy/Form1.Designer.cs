namespace KlasaGuy
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
            button1 = new Button();
            button2 = new Button();
            joesCashLabel = new Label();
            bobsCashLabel = new Label();
            bankCashLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 149);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 0;
            button1.Text = "Daj 10 zł Joemu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 149);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 1;
            button2.Text = "Weź 5 zł od Boba";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // joesCashLabel
            // 
            joesCashLabel.AutoSize = true;
            joesCashLabel.Location = new Point(12, 9);
            joesCashLabel.Name = "joesCashLabel";
            joesCashLabel.Size = new Size(38, 15);
            joesCashLabel.TabIndex = 2;
            joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            bobsCashLabel.AutoSize = true;
            bobsCashLabel.Location = new Point(12, 44);
            bobsCashLabel.Name = "bobsCashLabel";
            bobsCashLabel.Size = new Size(38, 15);
            bobsCashLabel.TabIndex = 3;
            bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            bankCashLabel.AutoSize = true;
            bankCashLabel.Location = new Point(12, 79);
            bankCashLabel.Name = "bankCashLabel";
            bankCashLabel.Size = new Size(38, 15);
            bankCashLabel.TabIndex = 4;
            bankCashLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 184);
            Controls.Add(bankCashLabel);
            Controls.Add(bobsCashLabel);
            Controls.Add(joesCashLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label joesCashLabel;
        private Label bobsCashLabel;
        private Label bankCashLabel;
    }
}
