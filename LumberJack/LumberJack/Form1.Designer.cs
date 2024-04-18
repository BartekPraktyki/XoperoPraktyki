namespace LumberJack
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
            label1 = new Label();
            name = new TextBox();
            addLumberjack = new Button();
            label2 = new Label();
            line = new ListBox();
            groupBox1 = new GroupBox();
            nextLumberjack = new Button();
            nextInLine = new ListBox();
            addFlapJacks = new Button();
            radioButton4 = new RadioButton();
            browned = new RadioButton();
            soggy = new RadioButton();
            crispy = new RadioButton();
            howMany = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)howMany).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię drwala";
            // 
            // name
            // 
            name.Location = new Point(108, 16);
            name.Name = "name";
            name.Size = new Size(137, 23);
            name.TabIndex = 1;
            // 
            // addLumberjack
            // 
            addLumberjack.Location = new Point(12, 50);
            addLumberjack.Name = "addLumberjack";
            addLumberjack.Size = new Size(233, 23);
            addLumberjack.TabIndex = 2;
            addLumberjack.Text = "Dodaj drwala";
            addLumberjack.UseVisualStyleBackColor = true;
            addLumberjack.Click += addLumberjack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Kolejka do śniadania";
            // 
            // line
            // 
            line.FormattingEnabled = true;
            line.ItemHeight = 15;
            line.Location = new Point(12, 125);
            line.Name = "line";
            line.Size = new Size(115, 319);
            line.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nextLumberjack);
            groupBox1.Controls.Add(nextInLine);
            groupBox1.Controls.Add(addFlapJacks);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(browned);
            groupBox1.Controls.Add(soggy);
            groupBox1.Controls.Add(crispy);
            groupBox1.Controls.Add(howMany);
            groupBox1.Location = new Point(133, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 319);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nakarm drwala";
            // 
            // nextLumberjack
            // 
            nextLumberjack.Location = new Point(6, 290);
            nextLumberjack.Name = "nextLumberjack";
            nextLumberjack.Size = new Size(106, 23);
            nextLumberjack.TabIndex = 7;
            nextLumberjack.Text = "Następny drwal";
            nextLumberjack.UseVisualStyleBackColor = true;
            nextLumberjack.Click += nextLumberjack_Click;
            // 
            // nextInLine
            // 
            nextInLine.FormattingEnabled = true;
            nextInLine.ItemHeight = 15;
            nextInLine.Location = new Point(6, 180);
            nextInLine.Name = "nextInLine";
            nextInLine.Size = new Size(106, 49);
            nextInLine.TabIndex = 6;
            // 
            // addFlapJacks
            // 
            addFlapJacks.Location = new Point(6, 151);
            addFlapJacks.Name = "addFlapJacks";
            addFlapJacks.Size = new Size(106, 23);
            addFlapJacks.TabIndex = 5;
            addFlapJacks.Text = "Dodaj naleśniki";
            addFlapJacks.UseVisualStyleBackColor = true;
            addFlapJacks.Click += addFlapJacks_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 126);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Bananowego";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            browned.AutoSize = true;
            browned.Location = new Point(6, 101);
            browned.Name = "browned";
            browned.Size = new Size(86, 19);
            browned.TabIndex = 3;
            browned.TabStop = true;
            browned.Text = "Rumianego";
            browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            soggy.AutoSize = true;
            soggy.Location = new Point(6, 76);
            soggy.Name = "soggy";
            soggy.Size = new Size(87, 19);
            soggy.TabIndex = 2;
            soggy.TabStop = true;
            soggy.Text = "Wilgotnego";
            soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            crispy.AutoSize = true;
            crispy.Location = new Point(6, 51);
            crispy.Name = "crispy";
            crispy.Size = new Size(87, 19);
            crispy.TabIndex = 1;
            crispy.TabStop = true;
            crispy.Text = "Chrupkiego";
            crispy.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            howMany.Location = new Point(6, 22);
            howMany.Name = "howMany";
            howMany.Size = new Size(73, 23);
            howMany.TabIndex = 0;
            howMany.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(groupBox1);
            Controls.Add(line);
            Controls.Add(label2);
            Controls.Add(addLumberjack);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)howMany).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox name;
        private Button addLumberjack;
        private Label label2;
        private ListBox line;
        private GroupBox groupBox1;
        private ListBox nextInLine;
        private Button addFlapJacks;
        private RadioButton radioButton4;
        private RadioButton browned;
        private RadioButton soggy;
        private RadioButton crispy;
        private NumericUpDown howMany;
        private Button nextLumberjack;
    }
}
