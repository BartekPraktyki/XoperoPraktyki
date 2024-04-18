namespace Cards
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
            listBox1 = new ListBox();
            moveToDeck2 = new Button();
            moveToDeck1 = new Button();
            listBox2 = new ListBox();
            reset1 = new Button();
            reset2 = new Button();
            shuffle1 = new Button();
            shuffle2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(136, 289);
            listBox1.TabIndex = 0;
            // 
            // moveToDeck2
            // 
            moveToDeck2.Location = new Point(154, 188);
            moveToDeck2.Name = "moveToDeck2";
            moveToDeck2.Size = new Size(36, 23);
            moveToDeck2.TabIndex = 1;
            moveToDeck2.Text = "<<";
            moveToDeck2.UseVisualStyleBackColor = true;
            moveToDeck2.Click += moveToDeck2_Click;
            // 
            // moveToDeck1
            // 
            moveToDeck1.Location = new Point(154, 129);
            moveToDeck1.Name = "moveToDeck1";
            moveToDeck1.Size = new Size(36, 23);
            moveToDeck1.TabIndex = 2;
            moveToDeck1.Text = ">>";
            moveToDeck1.UseVisualStyleBackColor = true;
            moveToDeck1.Click += moveToDeck1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(196, 47);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(137, 289);
            listBox2.TabIndex = 3;
            // 
            // reset1
            // 
            reset1.Location = new Point(12, 342);
            reset1.Name = "reset1";
            reset1.Size = new Size(136, 23);
            reset1.TabIndex = 4;
            reset1.Text = "Przywróć zestaw 1.";
            reset1.UseVisualStyleBackColor = true;
            reset1.Click += reset1_Click;
            // 
            // reset2
            // 
            reset2.Location = new Point(12, 371);
            reset2.Name = "reset2";
            reset2.Size = new Size(136, 23);
            reset2.TabIndex = 5;
            reset2.Text = "Wymieszaj zestaw 1.";
            reset2.UseVisualStyleBackColor = true;
            reset2.Click += reset2_Click;
            // 
            // shuffle1
            // 
            shuffle1.Location = new Point(196, 342);
            shuffle1.Name = "shuffle1";
            shuffle1.Size = new Size(137, 23);
            shuffle1.TabIndex = 6;
            shuffle1.Text = "Przywróć zestaw 2.";
            shuffle1.UseVisualStyleBackColor = true;
            shuffle1.Click += shuffle1_Click;
            // 
            // shuffle2
            // 
            shuffle2.Location = new Point(196, 371);
            shuffle2.Name = "shuffle2";
            shuffle2.Size = new Size(137, 23);
            shuffle2.TabIndex = 7;
            shuffle2.Text = "Wymieszaj zestaw 2.";
            shuffle2.UseVisualStyleBackColor = true;
            shuffle2.Click += shuffle2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 428);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shuffle2);
            Controls.Add(shuffle1);
            Controls.Add(reset2);
            Controls.Add(reset1);
            Controls.Add(listBox2);
            Controls.Add(moveToDeck1);
            Controls.Add(moveToDeck2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button moveToDeck2;
        private Button moveToDeck1;
        private ListBox listBox2;
        private Button reset1;
        private Button reset2;
        private Button shuffle1;
        private Button shuffle2;
        private Label label1;
        private Label label2;
    }
}
