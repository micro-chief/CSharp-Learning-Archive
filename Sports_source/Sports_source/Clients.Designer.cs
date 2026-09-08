namespace Sports_source
{
    partial class Clients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_client = new System.Windows.Forms.Button();
            this.client_data_zanyatia = new System.Windows.Forms.MaskedTextBox();
            this.client_number_phone = new System.Windows.Forms.MaskedTextBox();
            this.client_comment = new System.Windows.Forms.TextBox();
            this.client_el_pochta = new System.Windows.Forms.TextBox();
            this.FIO_client = new System.Windows.Forms.TextBox();
            this.id_client = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.client_delete_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_client_pole = new System.Windows.Forms.TextBox();
            this.btn_update_client = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.izmenenie_telephona_client = new System.Windows.Forms.MaskedTextBox();
            this.izmenit_client_btn = new System.Windows.Forms.Button();
            this.izmenenie_id_client = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(562, 509);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(310, 50);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_client);
            this.groupBox1.Controls.Add(this.client_data_zanyatia);
            this.groupBox1.Controls.Add(this.client_number_phone);
            this.groupBox1.Controls.Add(this.client_comment);
            this.groupBox1.Controls.Add(this.client_el_pochta);
            this.groupBox1.Controls.Add(this.FIO_client);
            this.groupBox1.Controls.Add(this.id_client);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(562, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление клиента";
            // 
            // add_client
            // 
            this.add_client.Location = new System.Drawing.Point(6, 188);
            this.add_client.Name = "add_client";
            this.add_client.Size = new System.Drawing.Size(298, 36);
            this.add_client.TabIndex = 13;
            this.add_client.Text = "Добавить ";
            this.add_client.UseVisualStyleBackColor = true;
            this.add_client.Click += new System.EventHandler(this.add_client_Click);
            // 
            // client_data_zanyatia
            // 
            this.client_data_zanyatia.Location = new System.Drawing.Point(145, 120);
            this.client_data_zanyatia.Mask = "00/00/0000";
            this.client_data_zanyatia.Name = "client_data_zanyatia";
            this.client_data_zanyatia.Size = new System.Drawing.Size(67, 20);
            this.client_data_zanyatia.TabIndex = 12;
            this.client_data_zanyatia.ValidatingType = typeof(System.DateTime);
            // 
            // client_number_phone
            // 
            this.client_number_phone.Location = new System.Drawing.Point(145, 70);
            this.client_number_phone.Mask = "+7 (999)-999-99-99";
            this.client_number_phone.Name = "client_number_phone";
            this.client_number_phone.Size = new System.Drawing.Size(159, 20);
            this.client_number_phone.TabIndex = 11;
            // 
            // client_comment
            // 
            this.client_comment.Location = new System.Drawing.Point(145, 149);
            this.client_comment.Name = "client_comment";
            this.client_comment.Size = new System.Drawing.Size(159, 20);
            this.client_comment.TabIndex = 3;
            // 
            // client_el_pochta
            // 
            this.client_el_pochta.Location = new System.Drawing.Point(145, 94);
            this.client_el_pochta.Name = "client_el_pochta";
            this.client_el_pochta.Size = new System.Drawing.Size(159, 20);
            this.client_el_pochta.TabIndex = 9;
            // 
            // FIO_client
            // 
            this.FIO_client.Location = new System.Drawing.Point(145, 46);
            this.FIO_client.Name = "FIO_client";
            this.FIO_client.Size = new System.Drawing.Size(159, 20);
            this.FIO_client.TabIndex = 7;
            // 
            // id_client
            // 
            this.id_client.Location = new System.Drawing.Point(145, 23);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(42, 20);
            this.id_client.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Комментарий клиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата Занятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Эл.Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Клиента";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.client_delete_btn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.delete_client_pole);
            this.groupBox2.Location = new System.Drawing.Point(562, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление клиента";
            // 
            // client_delete_btn
            // 
            this.client_delete_btn.Location = new System.Drawing.Point(6, 61);
            this.client_delete_btn.Name = "client_delete_btn";
            this.client_delete_btn.Size = new System.Drawing.Size(298, 33);
            this.client_delete_btn.TabIndex = 6;
            this.client_delete_btn.Text = "Удалить";
            this.client_delete_btn.UseVisualStyleBackColor = true;
            this.client_delete_btn.Click += new System.EventHandler(this.client_delete_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID Клиента";
            // 
            // delete_client_pole
            // 
            this.delete_client_pole.Location = new System.Drawing.Point(145, 32);
            this.delete_client_pole.Name = "delete_client_pole";
            this.delete_client_pole.Size = new System.Drawing.Size(42, 20);
            this.delete_client_pole.TabIndex = 4;
            // 
            // btn_update_client
            // 
            this.btn_update_client.Location = new System.Drawing.Point(562, 453);
            this.btn_update_client.Name = "btn_update_client";
            this.btn_update_client.Size = new System.Drawing.Size(310, 50);
            this.btn_update_client.TabIndex = 14;
            this.btn_update_client.Text = "Обновить данные";
            this.btn_update_client.UseVisualStyleBackColor = true;
            this.btn_update_client.Click += new System.EventHandler(this.btn_update_client_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.izmenenie_telephona_client);
            this.groupBox3.Controls.Add(this.izmenit_client_btn);
            this.groupBox3.Controls.Add(this.izmenenie_id_client);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(5, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 105);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение Клиента";
            // 
            // izmenenie_telephona_client
            // 
            this.izmenenie_telephona_client.Location = new System.Drawing.Point(106, 63);
            this.izmenenie_telephona_client.Mask = "+7 (999)-999-99-99";
            this.izmenenie_telephona_client.Name = "izmenenie_telephona_client";
            this.izmenenie_telephona_client.Size = new System.Drawing.Size(134, 20);
            this.izmenenie_telephona_client.TabIndex = 21;
            // 
            // izmenit_client_btn
            // 
            this.izmenit_client_btn.Location = new System.Drawing.Point(368, 19);
            this.izmenit_client_btn.Name = "izmenit_client_btn";
            this.izmenit_client_btn.Size = new System.Drawing.Size(176, 80);
            this.izmenit_client_btn.TabIndex = 20;
            this.izmenit_client_btn.Text = "Изменить";
            this.izmenit_client_btn.UseVisualStyleBackColor = true;
            this.izmenit_client_btn.Click += new System.EventHandler(this.izmenit_client_btn_Click);
            // 
            // izmenenie_id_client
            // 
            this.izmenenie_id_client.Location = new System.Drawing.Point(106, 29);
            this.izmenenie_id_client.Name = "izmenenie_id_client";
            this.izmenenie_id_client.Size = new System.Drawing.Size(42, 20);
            this.izmenenie_id_client.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID Клиента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Номер телефона";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_update_client);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Clients_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox client_data_zanyatia;
        private System.Windows.Forms.MaskedTextBox client_number_phone;
        private System.Windows.Forms.TextBox client_comment;
        private System.Windows.Forms.TextBox client_el_pochta;
        private System.Windows.Forms.TextBox FIO_client;
        private System.Windows.Forms.TextBox id_client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button client_delete_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox delete_client_pole;
        private System.Windows.Forms.Button add_client;
        private System.Windows.Forms.Button btn_update_client;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox izmenenie_id_client;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox izmenenie_telephona_client;
        private System.Windows.Forms.Button izmenit_client_btn;
    }
}