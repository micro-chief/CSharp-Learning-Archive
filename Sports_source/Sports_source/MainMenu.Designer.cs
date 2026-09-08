namespace Sports_source
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clients = new System.Windows.Forms.Button();
            this.training = new System.Windows.Forms.Button();
            this.subscription = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clients
            // 
            this.clients.Location = new System.Drawing.Point(226, 154);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(220, 43);
            this.clients.TabIndex = 0;
            this.clients.Text = "Клиенты";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // training
            // 
            this.training.Location = new System.Drawing.Point(226, 203);
            this.training.Name = "training";
            this.training.Size = new System.Drawing.Size(220, 43);
            this.training.TabIndex = 1;
            this.training.Text = "Занятия";
            this.training.UseVisualStyleBackColor = true;
            this.training.Click += new System.EventHandler(this.training_Click);
            // 
            // subscription
            // 
            this.subscription.Location = new System.Drawing.Point(226, 252);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(220, 43);
            this.subscription.TabIndex = 2;
            this.subscription.Text = "Абонементы";
            this.subscription.UseVisualStyleBackColor = true;
            this.subscription.Click += new System.EventHandler(this.subscription_Click);
            // 
            // staff
            // 
            this.staff.Location = new System.Drawing.Point(226, 301);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(220, 43);
            this.staff.TabIndex = 3;
            this.staff.Text = "Персонал";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(452, 446);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(220, 43);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(257, 76);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(159, 33);
            this.Name_label.TabIndex = 5;
            this.Name_label.Text = "СПОРТЗАЛ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.subscription);
            this.Controls.Add(this.training);
            this.Controls.Add(this.clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортзал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button training;
        private System.Windows.Forms.Button subscription;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label Name_label;
    }
}

