namespace MailBomber
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортБазыtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСписокЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бомберToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускЗаданийНаИсполнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьВсеЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заданияToolStripMenuItem,
            this.бомберToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортБазыtxtToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортБазыtxtToolStripMenuItem
            // 
            this.импортБазыtxtToolStripMenuItem.Name = "импортБазыtxtToolStripMenuItem";
            this.импортБазыtxtToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.импортБазыtxtToolStripMenuItem.Text = "Импорт базы (.txt)";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьСписокЗаданийToolStripMenuItem,
            this.добавитьЗаданиеToolStripMenuItem,
            this.удалитьЗаданиеToolStripMenuItem});
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // показатьСписокЗаданийToolStripMenuItem
            // 
            this.показатьСписокЗаданийToolStripMenuItem.Name = "показатьСписокЗаданийToolStripMenuItem";
            this.показатьСписокЗаданийToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.показатьСписокЗаданийToolStripMenuItem.Text = "Показать список заданий";
            // 
            // добавитьЗаданиеToolStripMenuItem
            // 
            this.добавитьЗаданиеToolStripMenuItem.Name = "добавитьЗаданиеToolStripMenuItem";
            this.добавитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.добавитьЗаданиеToolStripMenuItem.Text = "Добавить задание";
            // 
            // удалитьЗаданиеToolStripMenuItem
            // 
            this.удалитьЗаданиеToolStripMenuItem.Name = "удалитьЗаданиеToolStripMenuItem";
            this.удалитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.удалитьЗаданиеToolStripMenuItem.Text = "Удалить задание";
            // 
            // бомберToolStripMenuItem
            // 
            this.бомберToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запускЗаданийНаИсполнениеToolStripMenuItem,
            this.остановитьВсеЗаданияToolStripMenuItem});
            this.бомберToolStripMenuItem.Name = "бомберToolStripMenuItem";
            this.бомберToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.бомберToolStripMenuItem.Text = "Бомбер";
            // 
            // запускЗаданийНаИсполнениеToolStripMenuItem
            // 
            this.запускЗаданийНаИсполнениеToolStripMenuItem.Name = "запускЗаданийНаИсполнениеToolStripMenuItem";
            this.запускЗаданийНаИсполнениеToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.запускЗаданийНаИсполнениеToolStripMenuItem.Text = "Запуск заданий на исполнение";
            // 
            // остановитьВсеЗаданияToolStripMenuItem
            // 
            this.остановитьВсеЗаданияToolStripMenuItem.Name = "остановитьВсеЗаданияToolStripMenuItem";
            this.остановитьВсеЗаданияToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.остановитьВсеЗаданияToolStripMenuItem.Text = "Остановить все задания";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.25182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.748184F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 375);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 437);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mail Bomber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортБазыtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСписокЗаданийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бомберToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускЗаданийНаИсполнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьВсеЗаданияToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
    }
}

