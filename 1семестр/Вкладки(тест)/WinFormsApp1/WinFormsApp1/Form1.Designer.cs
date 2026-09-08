namespace WinFormsApp1
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
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            button2 = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            tabPage4 = new TabPage();
            groupBox2 = new GroupBox();
            button3 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            tabPage5 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(546, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(538, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заголовок";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 255);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 146);
            label1.Name = "label1";
            label1.Size = new Size(363, 25);
            label1.TabIndex = 0;
            label1.Text = "Контрольная работа по алгебре";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(538, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Вопрос 1";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(285, 196);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 3;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(262, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 45);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(224, 266);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 159);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 0;
            label3.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(538, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Вопрос 2";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(78, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 247);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Варианты ответа";
            // 
            // button2
            // 
            button2.Location = new Point(243, 91);
            button2.Name = "button2";
            button2.Size = new Size(106, 64);
            button2.TabIndex = 4;
            button2.Text = "Принять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(19, 161);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(40, 29);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(19, 126);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(19, 91);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(40, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(19, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(222, 355);
            label6.Name = "label6";
            label6.Size = new Size(0, 31);
            label6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(167, 31);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 0;
            label5.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(538, 420);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Вопрос 3";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(80, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 240);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Варианты ответа";
            // 
            // button3
            // 
            button3.Location = new Point(244, 84);
            button3.Name = "button3";
            button3.Size = new Size(108, 50);
            button3.TabIndex = 3;
            button3.Text = "Принять";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(11, 174);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(32, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "4";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(11, 101);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Примерно 3";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Натурально число >3 но <5";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(245, 357);
            label8.Name = "label8";
            label8.Size = new Size(0, 31);
            label8.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(161, 50);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 0;
            label7.Text = "Сколько будет 2 + 2 =";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(button4);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(538, 420);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Оценка";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(150, 201);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 120;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(67, 132);
            label9.Name = "label9";
            label9.Size = new Size(210, 25);
            label9.TabIndex = 3;
            label9.Text = "Набрано баллов =";
            // 
            // button6
            // 
            button6.Location = new Point(378, 299);
            button6.Name = "button6";
            button6.Size = new Size(109, 43);
            button6.TabIndex = 2;
            button6.Text = "Выход";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(47, 299);
            button5.Name = "button5";
            button5.Size = new Size(103, 43);
            button5.TabIndex = 1;
            button5.Text = "Начать заново";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(173, 50);
            button4.Name = "button4";
            button4.Size = new Size(169, 49);
            button4.TabIndex = 0;
            button4.Text = "Получить оценку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private GroupBox groupBox1;
        private Button button2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Button button3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label8;
        private Label label7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label10;
        private Label label9;
    }
}