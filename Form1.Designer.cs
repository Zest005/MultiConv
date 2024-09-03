namespace MyConverter
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            progressBar1 = new ProgressBar();
            panel4 = new Panel();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(340, 23);
            textBox1.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "Photo";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(6, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Video";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(6, 77);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 19);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Audio";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 7;
            label1.Text = "Choose type of file to convert";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(12, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 115);
            panel1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 23);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.SelectionChangeCommitted += comboBox2_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 11;
            label3.Text = "Choose format to convert";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 10;
            label2.Text = "Choose original format";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton3);
            panel2.Location = new Point(12, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 102);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(114, 32);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 9;
            button1.Text = "Choose file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(114, 7);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 13;
            button2.Text = "Convert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(progressBar1);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(12, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(346, 83);
            panel3.TabIndex = 14;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(340, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 14;
            progressBar1.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(12, 236);
            panel4.Name = "panel4";
            panel4.Size = new Size(346, 72);
            panel4.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.Location = new Point(313, 418);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "GitHub";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(158, 418);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 17;
            label4.Text = "@Zest";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.Location = new Point(255, 418);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(52, 15);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "LinkedIn";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(12, 418);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 19;
            label5.Text = "version 0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 442);
            Controls.Add(label5);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MultiConv";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private ProgressBar progressBar1;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel linkLabel2;
        private Label label5;
    }
}
