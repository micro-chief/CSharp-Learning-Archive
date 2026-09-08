namespace Sports_source
{
    partial class Training
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.update_zanyatia_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_zanyatie = new System.Windows.Forms.Button();
            this.data_provedenia_zanyatia = new System.Windows.Forms.MaskedTextBox();
            this.mesto_provedenia_zanyatia = new System.Windows.Forms.TextBox();
            this.trener_zanyatia = new System.Windows.Forms.TextBox();
            this.nazvanie_zanyatia = new System.Windows.Forms.TextBox();
            this.id_zanyatia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_id_zanyatia = new System.Windows.Forms.TextBox();
            this.delete_btn_zanyatie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.izmenenie_id_zanyatia = new System.Windows.Forms.TextBox();
            this.izmenenie_data_zanyatia = new System.Windows.Forms.MaskedTextBox();
            this.izmenit_zanyatia_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(562, 506);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(310, 50);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(550, 449);
            this.dataGridView2.TabIndex = 1;
            // 
            // update_zanyatia_btn
            // 
            this.update_zanyatia_btn.Location = new System.Drawing.Point(562, 455);
            this.update_zanyatia_btn.Name = "update_zanyatia_btn";
            this.update_zanyatia_btn.Size = new System.Drawing.Size(310, 50);
            this.update_zanyatia_btn.TabIndex = 2;
            this.update_zanyatia_btn.Text = "Обновить данные";
            this.update_zanyatia_btn.UseVisualStyleBackColor = true;
            this.update_zanyatia_btn.Click += new System.EventHandler(this.update_zanyatia_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_zanyatie);
            this.groupBox1.Controls.Add(this.data_provedenia_zanyatia);
            this.groupBox1.Controls.Add(this.mesto_provedenia_zanyatia);
            this.groupBox1.Controls.Add(this.trener_zanyatia);
            this.groupBox1.Controls.Add(this.nazvanie_zanyatia);
            this.groupBox1.Controls.Add(this.id_zanyatia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(556, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление занятия";
            // 
            // add_zanyatie
            // 
            this.add_zanyatie.Location = new System.Drawing.Point(10, 153);
            this.add_zanyatie.Name = "add_zanyatie";
            this.add_zanyatie.Size = new System.Drawing.Size(294, 31);
            this.add_zanyatie.TabIndex = 11;
            this.add_zanyatie.Text = "Добавить";
            this.add_zanyatie.UseVisualStyleBackColor = true;
            this.add_zanyatie.Click += new System.EventHandler(this.add_zanyatie_Click);
            // 
            // data_provedenia_zanyatia
            // 
            this.data_provedenia_zanyatia.Location = new System.Drawing.Point(115, 99);
            this.data_provedenia_zanyatia.Mask = "00/00/0000";
            this.data_provedenia_zanyatia.Name = "data_provedenia_zanyatia";
            this.data_provedenia_zanyatia.Size = new System.Drawing.Size(69, 20);
            this.data_provedenia_zanyatia.TabIndex = 10;
            this.data_provedenia_zanyatia.ValidatingType = typeof(System.DateTime);
            // 
            // mesto_provedenia_zanyatia
            // 
            this.mesto_provedenia_zanyatia.Location = new System.Drawing.Point(115, 121);
            this.mesto_provedenia_zanyatia.Name = "mesto_provedenia_zanyatia";
            this.mesto_provedenia_zanyatia.Size = new System.Drawing.Size(189, 20);
            this.mesto_provedenia_zanyatia.TabIndex = 9;
            // 
            // trener_zanyatia
            // 
            this.trener_zanyatia.Location = new System.Drawing.Point(115, 75);
            this.trener_zanyatia.Name = "trener_zanyatia";
            this.trener_zanyatia.Size = new System.Drawing.Size(189, 20);
            this.trener_zanyatia.TabIndex = 7;
            // 
            // nazvanie_zanyatia
            // 
            this.nazvanie_zanyatia.Location = new System.Drawing.Point(115, 52);
            this.nazvanie_zanyatia.Name = "nazvanie_zanyatia";
            this.nazvanie_zanyatia.Size = new System.Drawing.Size(189, 20);
            this.nazvanie_zanyatia.TabIndex = 6;
            // 
            // id_zanyatia
            // 
            this.id_zanyatia.Location = new System.Drawing.Point(115, 28);
            this.id_zanyatia.Name = "id_zanyatia";
            this.id_zanyatia.Size = new System.Drawing.Size(45, 20);
            this.id_zanyatia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Место проведения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата проведения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тренер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название занятия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Занятия";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_id_zanyatia);
            this.groupBox2.Controls.Add(this.delete_btn_zanyatie);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(562, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление занятия";
            // 
            // delete_id_zanyatia
            // 
            this.delete_id_zanyatia.Location = new System.Drawing.Point(113, 23);
            this.delete_id_zanyatia.Name = "delete_id_zanyatia";
            this.delete_id_zanyatia.Size = new System.Drawing.Size(45, 20);
            this.delete_id_zanyatia.TabIndex = 12;
            // 
            // delete_btn_zanyatie
            // 
            this.delete_btn_zanyatie.Location = new System.Drawing.Point(4, 94);
            this.delete_btn_zanyatie.Name = "delete_btn_zanyatie";
            this.delete_btn_zanyatie.Size = new System.Drawing.Size(300, 30);
            this.delete_btn_zanyatie.TabIndex = 1;
            this.delete_btn_zanyatie.Text = "Удалить";
            this.delete_btn_zanyatie.UseVisualStyleBackColor = true;
            this.delete_btn_zanyatie.Click += new System.EventHandler(this.delete_btn_zanyatie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Занятия";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.izmenenie_id_zanyatia);
            this.groupBox3.Controls.Add(this.izmenenie_data_zanyatia);
            this.groupBox3.Controls.Add(this.izmenit_zanyatia_btn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 101);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменение Занятия";
            // 
            // izmenenie_id_zanyatia
            // 
            this.izmenenie_id_zanyatia.Location = new System.Drawing.Point(123, 34);
            this.izmenenie_id_zanyatia.Name = "izmenenie_id_zanyatia";
            this.izmenenie_id_zanyatia.Size = new System.Drawing.Size(45, 20);
            this.izmenenie_id_zanyatia.TabIndex = 10;
            // 
            // izmenenie_data_zanyatia
            // 
            this.izmenenie_data_zanyatia.Location = new System.Drawing.Point(123, 63);
            this.izmenenie_data_zanyatia.Mask = "00/00/0000";
            this.izmenenie_data_zanyatia.Name = "izmenenie_data_zanyatia";
            this.izmenenie_data_zanyatia.Size = new System.Drawing.Size(69, 20);
            this.izmenenie_data_zanyatia.TabIndex = 9;
            // 
            // izmenit_zanyatia_btn
            // 
            this.izmenit_zanyatia_btn.Location = new System.Drawing.Point(387, 11);
            this.izmenit_zanyatia_btn.Name = "izmenit_zanyatia_btn";
            this.izmenit_zanyatia_btn.Size = new System.Drawing.Size(145, 83);
            this.izmenit_zanyatia_btn.TabIndex = 8;
            this.izmenit_zanyatia_btn.Text = "Изменить";
            this.izmenit_zanyatia_btn.UseVisualStyleBackColor = true;
            this.izmenit_zanyatia_btn.Click += new System.EventHandler(this.izmenit_zanyatia_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Занятия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата проведения";
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update_zanyatia_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.exit);
            this.Name = "Training";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Занятия";
            this.Load += new System.EventHandler(this.Training_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button update_zanyatia_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mesto_provedenia_zanyatia;
        private System.Windows.Forms.TextBox trener_zanyatia;
        private System.Windows.Forms.TextBox nazvanie_zanyatia;
        private System.Windows.Forms.TextBox id_zanyatia;
        private System.Windows.Forms.MaskedTextBox data_provedenia_zanyatia;
        private System.Windows.Forms.Button add_zanyatie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delete_btn_zanyatie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delete_id_zanyatia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button izmenit_zanyatia_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox izmenenie_id_zanyatia;
        private System.Windows.Forms.MaskedTextBox izmenenie_data_zanyatia;
    }
}