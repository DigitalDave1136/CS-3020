namespace SatelliteTracker
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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 20);
            label1.Name = "label1";
            label1.Size = new Size(407, 25);
            label1.TabIndex = 0;
            label1.Text = "Select the number of Satellites you want to return:";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10", "100", "1000", "10000" });
            comboBox1.Location = new Point(51, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 143);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 3;
            label2.Text = "Was UDL successful?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 252);
            label3.Name = "label3";
            label3.Size = new Size(466, 25);
            label3.TabIndex = 4;
            label3.Text = "Select the specific Satellite you want to see the record for:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 20);
            label4.Name = "label4";
            label4.Size = new Size(286, 25);
            label4.TabIndex = 5;
            label4.Text = "Number of Satellite records found:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1131, 20);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 6;
            label5.Text = "Satellite Number:";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(49, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(850, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1284, 17);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(558, 81);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(876, 297);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(51, 96);
            button1.Name = "button1";
            button1.Size = new Size(261, 34);
            button1.TabIndex = 12;
            button1.Text = "Submit UDL request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(54, 344);
            button2.Name = "button2";
            button2.Size = new Size(258, 34);
            button2.TabIndex = 13;
            button2.Text = "Submit Satellite Info Request";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(54, 294);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(258, 33);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Activates after UDL request";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(54, 393);
            button3.Name = "button3";
            button3.Size = new Size(258, 34);
            button3.TabIndex = 15;
            button3.Text = "Reset Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3137, 450);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private Button button3;
        public TextBox textBox1;
        public TextBox textBox4;
        public TextBox textBox2;
        public TextBox textBox3;
    }
}
