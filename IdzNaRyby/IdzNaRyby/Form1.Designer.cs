namespace IdzNaRyby
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
            textName = new TextBox();
            buttonStart = new Button();
            listHand = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textProgress = new TextBox();
            textBooks = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonAsk = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(12, 32);
            textName.Name = "textName";
            textName.PlaceholderText = "Edek";
            textName.Size = new Size(155, 23);
            textName.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(173, 32);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(154, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Rozpocznij grę!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // listHand
            // 
            listHand.FormattingEnabled = true;
            listHand.ItemHeight = 15;
            listHand.Location = new Point(333, 31);
            listHand.Name = "listHand";
            listHand.Size = new Size(156, 379);
            listHand.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 13);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Ręka";
            // 
            // textProgress
            // 
            textProgress.Location = new Point(12, 90);
            textProgress.Multiline = true;
            textProgress.Name = "textProgress";
            textProgress.ReadOnly = true;
            textProgress.Size = new Size(315, 253);
            textProgress.TabIndex = 5;
            // 
            // textBooks
            // 
            textBooks.Location = new Point(12, 364);
            textBooks.Multiline = true;
            textBooks.Name = "textBooks";
            textBooks.ReadOnly = true;
            textBooks.Size = new Size(315, 74);
            textBooks.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Postępy gry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Grupy";
            // 
            // buttonAsk
            // 
            buttonAsk.Enabled = false;
            buttonAsk.Location = new Point(333, 416);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(156, 23);
            buttonAsk.TabIndex = 9;
            buttonAsk.Text = "Zażądaj karty";
            buttonAsk.UseVisualStyleBackColor = true;
            buttonAsk.Click += buttonAsk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(buttonAsk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBooks);
            Controls.Add(textProgress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listHand);
            Controls.Add(buttonStart);
            Controls.Add(textName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private Button buttonStart;
        private ListBox listHand;
        private Label label1;
        private Label label2;
        private TextBox textProgress;
        private TextBox textBooks;
        private Label label3;
        private Label label4;
        private Button buttonAsk;
    }
}
