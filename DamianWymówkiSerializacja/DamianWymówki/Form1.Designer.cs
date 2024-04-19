namespace DamianWymówki
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
            folder = new Button();
            save = new Button();
            open = new Button();
            randomExcuse = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            description = new TextBox();
            results = new TextBox();
            lastUsed = new DateTimePicker();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // folder
            // 
            folder.Location = new Point(12, 133);
            folder.Name = "folder";
            folder.Size = new Size(75, 23);
            folder.TabIndex = 0;
            folder.Text = "Folder";
            folder.UseVisualStyleBackColor = true;
            folder.Click += folder_Click;
            // 
            // save
            // 
            save.Location = new Point(93, 133);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 1;
            save.Text = "Zapisz";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // open
            // 
            open.Location = new Point(174, 133);
            open.Name = "open";
            open.Size = new Size(75, 23);
            open.TabIndex = 2;
            open.Text = "Otwórz";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // randomExcuse
            // 
            randomExcuse.Location = new Point(255, 133);
            randomExcuse.Name = "randomExcuse";
            randomExcuse.Size = new Size(112, 23);
            randomExcuse.TabIndex = 3;
            randomExcuse.Text = "Losowa wymówka";
            randomExcuse.UseVisualStyleBackColor = true;
            randomExcuse.Click += randomExcuse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Wymówka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Wyniki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Data pliku";
            // 
            // description
            // 
            description.Location = new Point(109, 9);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(203, 15);
            description.TabIndex = 8;
            description.TextChanged += description_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(109, 40);
            results.Multiline = true;
            results.Name = "results";
            results.Size = new Size(203, 15);
            results.TabIndex = 9;
            results.TextChanged += results_TextChanged;
            // 
            // lastUsed
            // 
            lastUsed.Location = new Point(109, 64);
            lastUsed.Name = "lastUsed";
            lastUsed.Size = new Size(203, 23);
            lastUsed.TabIndex = 10;
            lastUsed.ValueChanged += lastUsed_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 100);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(203, 18);
            textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 168);
            Controls.Add(textBox3);
            Controls.Add(lastUsed);
            Controls.Add(results);
            Controls.Add(description);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(randomExcuse);
            Controls.Add(open);
            Controls.Add(save);
            Controls.Add(folder);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button folder;
        private Button save;
        private Button open;
        private Button randomExcuse;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox description;
        private TextBox results;
        private DateTimePicker lastUsed;
        private TextBox textBox3;
    }
}
