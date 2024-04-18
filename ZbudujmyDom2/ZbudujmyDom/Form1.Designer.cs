namespace ZbudujmyDom
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
            goHere = new Button();
            goThroughTheDoor = new Button();
            exits = new ComboBox();
            description = new TextBox();
            check = new Button();
            hide = new Button();
            SuspendLayout();
            // 
            // goHere
            // 
            goHere.Location = new Point(12, 207);
            goHere.Name = "goHere";
            goHere.Size = new Size(132, 24);
            goHere.TabIndex = 0;
            goHere.Text = "Idź tutaj:";
            goHere.UseVisualStyleBackColor = true;
            goHere.Click += goHere_Click;
            // 
            // goThroughTheDoor
            // 
            goThroughTheDoor.Location = new Point(12, 237);
            goThroughTheDoor.Name = "goThroughTheDoor";
            goThroughTheDoor.Size = new Size(306, 23);
            goThroughTheDoor.TabIndex = 1;
            goThroughTheDoor.Text = "Przejdź przez drzwi";
            goThroughTheDoor.UseVisualStyleBackColor = true;
            goThroughTheDoor.Click += goThroughTheDoor_Click;
            // 
            // exits
            // 
            exits.DropDownStyle = ComboBoxStyle.DropDownList;
            exits.FormattingEnabled = true;
            exits.Location = new Point(150, 208);
            exits.Name = "exits";
            exits.Size = new Size(168, 23);
            exits.TabIndex = 2;
            // 
            // description
            // 
            description.Location = new Point(12, 12);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(306, 189);
            description.TabIndex = 3;
            // 
            // check
            // 
            check.Location = new Point(12, 266);
            check.Name = "check";
            check.Size = new Size(306, 23);
            check.TabIndex = 4;
            check.Text = "sprawdź";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // hide
            // 
            hide.Location = new Point(12, 295);
            hide.Name = "hide";
            hide.Size = new Size(306, 23);
            hide.TabIndex = 5;
            hide.Text = "Kryj się!";
            hide.UseVisualStyleBackColor = true;
            hide.Click += hide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 329);
            Controls.Add(hide);
            Controls.Add(check);
            Controls.Add(description);
            Controls.Add(exits);
            Controls.Add(goThroughTheDoor);
            Controls.Add(goHere);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goHere;
        private Button goThroughTheDoor;
        private ComboBox exits;
        private TextBox description;
        private Button check;
        private Button hide;
    }
}
