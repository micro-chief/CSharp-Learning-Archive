namespace Sports_source
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomer_phone = new System.Windows.Forms.MaskedTextBox();
            this.grafik_rabotnika = new System.Windows.Forms.MaskedTextBox();
            this.add_rabotnika = new System.Windows.Forms.Button();
            this.zp_rabotnika = new System.Windows.Forms.TextBox();
            this.specialnocst_rabotnika = new System.Windows.Forms.TextBox();
            this.dolzhnost_rabotnika = new System.Windows.Forms.TextBox();
            this.FIO_rabotnika = new System.Windows.Forms.TextBox();
            this.id_rabotnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_id_rabotnika = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.delete_id_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.izmenenie_zp_rabotnika = new System.Windows.Forms.TextBox();
            this.izmenenie_id_rabotnika = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.izmnenie_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(556, 505);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(310, 50);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomer_phone);
            this.groupBox1.Controls.Add(this.grafik_rabotnika);
            this.groupBox1.Controls.Add(this.add_rabotnika);
            this.groupBox1.Controls.Add(this.zp_rabotnika);
            this.groupBox1.Controls.Add(this.specialnocst_rabotnika);
            this.groupBox1.Controls.Add(this.dolzhnost_rabotnika);
            this.groupBox1.Controls.Add(this.FIO_rabotnika);
            this.groupBox1.Controls.Add(this.id_rabotnika);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(556, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление персонала";
            // 
            // nomer_phone
            // 
            this.nomer_phone.Location = new System.Drawing.Point(135, 149);
            this.nomer_phone.Mask = "+7 (999)-999-99-99";
            this.nomer_phone.Name = "nomer_phone";
            this.nomer_phone.Size = new System.Drawing.Size(169, 20);
            this.nomer_phone.TabIndex = 20;
            // 
            // grafik_rabotnika
            // 
            this.grafik_rabotnika.Location = new System.Drawing.Point(135, 123);
            this.grafik_rabotnika.Mask = "LL\\-LL, 00:00-00:00";
            this.grafik_rabotnika.Name = "grafik_rabotnika";
            this.grafik_rabotnika.Size = new System.Drawing.Size(169, 20);
            this.grafik_rabotnika.TabIndex = 19;
            // 
            // add_rabotnika
            // 
            this.add_rabotnika.Location = new System.Drawing.Point(9, 224);
            this.add_rabotnika.Name = "add_rabotnika";
            this.add_rabotnika.Size = new System.Drawing.Size(295, 44);
            this.add_rabotnika.TabIndex = 18;
            this.add_rabotnika.Text = "Добавить";
            this.add_rabotnika.UseVisualStyleBackColor = true;
            this.add_rabotnika.Click += new System.EventHandler(this.add_rabotnika_Click);
            // 
            // zp_rabotnika
            // 
            this.zp_rabotnika.Location = new System.Drawing.Point(135, 175);
            this.zp_rabotnika.Name = "zp_rabotnika";
            this.zp_rabotnika.Size = new System.Drawing.Size(169, 20);
            this.zp_rabotnika.TabIndex = 17;
            // 
            // specialnocst_rabotnika
            // 
            this.specialnocst_rabotnika.Location = new System.Drawing.Point(135, 97);
            this.specialnocst_rabotnika.Name = "specialnocst_rabotnika";
            this.specialnocst_rabotnika.Size = new System.Drawing.Size(169, 20);
            this.specialnocst_rabotnika.TabIndex = 14;
            // 
            // dolzhnost_rabotnika
            // 
            this.dolzhnost_rabotnika.Location = new System.Drawing.Point(135, 71);
            this.dolzhnost_rabotnika.Name = "dolzhnost_rabotnika";
            this.dolzhnost_rabotnika.Size = new System.Drawing.Size(169, 20);
            this.dolzhnost_rabotnika.TabIndex = 13;
            // 
            // FIO_rabotnika
            // 
            this.FIO_rabotnika.Location = new System.Drawing.Point(135, 45);
            this.FIO_rabotnika.Name = "FIO_rabotnika";
            this.FIO_rabotnika.Size = new System.Drawing.Size(169, 20);
            this.FIO_rabotnika.TabIndex = 12;
            // 
            // id_rabotnika
            // 
            this.id_rabotnika.Location = new System.Drawing.Point(135, 19);
            this.id_rabotnika.Name = "id_rabotnika";
            this.id_rabotnika.Size = new System.Drawing.Size(38, 20);
            this.id_rabotnika.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Специальность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "График работы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Номер телефона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ЗП";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_id_rabotnika);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.delete_id_btn);
            this.groupBox2.Location = new System.Drawing.Point(556, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление персонала";
            // 
            // delete_id_rabotnika
            // 
            this.delete_id_rabotnika.Location = new System.Drawing.Point(135, 58);
            this.delete_id_rabotnika.Name = "delete_id_rabotnika";
            this.delete_id_rabotnika.Size = new System.Drawing.Size(38, 20);
            this.delete_id_rabotnika.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID Работника";
            // 
            // delete_id_btn
            // 
            this.delete_id_btn.Location = new System.Drawing.Point(9, 120);
            this.delete_id_btn.Name = "delete_id_btn";
            this.delete_id_btn.Size = new System.Drawing.Size(295, 37);
            this.delete_id_btn.TabIndex = 19;
            this.delete_id_btn.Text = "Удалить";
            this.delete_id_btn.UseVisualStyleBackColor = true;
            this.delete_id_btn.Click += new System.EventHandler(this.delete_id_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.izmenenie_zp_rabotnika);
            this.groupBox3.Controls.Add(this.izmenenie_id_rabotnika);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.izmnenie_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение персонала";
            // 
            // izmenenie_zp_rabotnika
            // 
            this.izmenenie_zp_rabotnika.Location = new System.Drawing.Point(112, 66);
            this.izmenenie_zp_rabotnika.Name = "izmenenie_zp_rabotnika";
            this.izmenenie_zp_rabotnika.Size = new System.Drawing.Size(100, 20);
            this.izmenenie_zp_rabotnika.TabIndex = 22;
            // 
            // izmenenie_id_rabotnika
            // 
            this.izmenenie_id_rabotnika.Location = new System.Drawing.Point(112, 28);
            this.izmenenie_id_rabotnika.Name = "izmenenie_id_rabotnika";
            this.izmenenie_id_rabotnika.Size = new System.Drawing.Size(100, 20);
            this.izmenenie_id_rabotnika.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID Работника";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "ЗП";
            // 
            // izmnenie_btn
            // 
            this.izmnenie_btn.Location = new System.Drawing.Point(437, 19);
            this.izmnenie_btn.Name = "izmnenie_btn";
            this.izmnenie_btn.Size = new System.Drawing.Size(95, 75);
            this.izmnenie_btn.TabIndex = 20;
            this.izmnenie_btn.Text = "Изменить";
            this.izmnenie_btn.UseVisualStyleBackColor = true;
            this.izmnenie_btn.Click += new System.EventHandler(this.izmnenie_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(556, 449);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(310, 50);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Обновить данные";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit);
            this.Name = "Staff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_rabotnika;
        private System.Windows.Forms.TextBox zp_rabotnika;
        private System.Windows.Forms.TextBox specialnocst_rabotnika;
        private System.Windows.Forms.TextBox dolzhnost_rabotnika;
        private System.Windows.Forms.TextBox FIO_rabotnika;
        private System.Windows.Forms.TextBox id_rabotnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_id_btn;
        private System.Windows.Forms.Button izmnenie_btn;
        private System.Windows.Forms.TextBox delete_id_rabotnika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox izmenenie_zp_rabotnika;
        private System.Windows.Forms.TextBox izmenenie_id_rabotnika;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox nomer_phone;
        private System.Windows.Forms.MaskedTextBox grafik_rabotnika;
    }
}