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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            рисункиToolStripMenuItem = new ToolStripMenuItem();
            кот1ToolStripMenuItem = new ToolStripMenuItem();
            кот2ToolStripMenuItem = new ToolStripMenuItem();
            кот3ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, рисункиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(625, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // рисункиToolStripMenuItem
            // 
            рисункиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { кот1ToolStripMenuItem, кот2ToolStripMenuItem, кот3ToolStripMenuItem });
            рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            рисункиToolStripMenuItem.Size = new Size(65, 20);
            рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // кот1ToolStripMenuItem
            // 
            кот1ToolStripMenuItem.Name = "кот1ToolStripMenuItem";
            кот1ToolStripMenuItem.Size = new Size(118, 22);
            кот1ToolStripMenuItem.Text = "Кот № 1";
            кот1ToolStripMenuItem.Click += кот1ToolStripMenuItem_Click;
            // 
            // кот2ToolStripMenuItem
            // 
            кот2ToolStripMenuItem.Name = "кот2ToolStripMenuItem";
            кот2ToolStripMenuItem.Size = new Size(118, 22);
            кот2ToolStripMenuItem.Text = "Кот № 2";
            кот2ToolStripMenuItem.Click += кот2ToolStripMenuItem_Click;
            // 
            // кот3ToolStripMenuItem
            // 
            кот3ToolStripMenuItem.Name = "кот3ToolStripMenuItem";
            кот3ToolStripMenuItem.Size = new Size(118, 22);
            кот3ToolStripMenuItem.Text = "Кот № 3";
            кот3ToolStripMenuItem.Click += кот3ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(625, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 401);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Менюшки";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem рисункиToolStripMenuItem;
        private ToolStripMenuItem кот1ToolStripMenuItem;
        private ToolStripMenuItem кот2ToolStripMenuItem;
        private ToolStripMenuItem кот3ToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}