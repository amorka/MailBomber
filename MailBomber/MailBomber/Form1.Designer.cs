﻿namespace MailBomber
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
            this.импортБазыИзtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияПоФирмамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрИнфыПоФирмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеДанныхБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.письмоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьШаблонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_activeTask = new System.Windows.Forms.DataGridView();
            this.lv_activeTask = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_executedTask = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_allTask = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.picb_internet = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_act_tasks = new System.Windows.Forms.Label();
            this.lb_count_mails_to_sended = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activeTask)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_executedTask)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTask)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_internet)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заданияToolStripMenuItem,
            this.письмоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортБазыИзtxtToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортБазыИзtxtToolStripMenuItem
            // 
            this.импортБазыИзtxtToolStripMenuItem.Name = "импортБазыИзtxtToolStripMenuItem";
            this.импортБазыИзtxtToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.импортБазыИзtxtToolStripMenuItem.Text = "Импорт базы из .txt";
            this.импортБазыИзtxtToolStripMenuItem.Click += new System.EventHandler(this.импортБазыИзtxtToolStripMenuItem_Click);
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem,
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem,
            this.заданияПоФирмамToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // создатьЗаданиеНаКонкретныйEmailToolStripMenuItem
            // 
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem.Name = "создатьЗаданиеНаКонкретныйEmailToolStripMenuItem";
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem.Text = "Создать задание на конкретный Email";
            this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem.Click += new System.EventHandler(this.создатьЗаданиеНаКонкретныйEmailToolStripMenuItem_Click);
            // 
            // сформироватьЗаданияНаВсюБазуToolStripMenuItem
            // 
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Name = "сформироватьЗаданияНаВсюБазуToolStripMenuItem";
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Text = "Сформировать задания на всю базу";
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Click += new System.EventHandler(this.сформироватьЗаданияНаВсюБазуToolStripMenuItem_Click);
            // 
            // заданияПоФирмамToolStripMenuItem
            // 
            this.заданияПоФирмамToolStripMenuItem.Name = "заданияПоФирмамToolStripMenuItem";
            this.заданияПоФирмамToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.заданияПоФирмамToolStripMenuItem.Text = "Задания по фирмам";
            this.заданияПоФирмамToolStripMenuItem.Click += new System.EventHandler(this.заданияПоФирмамToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрИнфыПоФирмеToolStripMenuItem,
            this.редактированиеДанныхБазыToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // просмотрИнфыПоФирмеToolStripMenuItem
            // 
            this.просмотрИнфыПоФирмеToolStripMenuItem.Name = "просмотрИнфыПоФирмеToolStripMenuItem";
            this.просмотрИнфыПоФирмеToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.просмотрИнфыПоФирмеToolStripMenuItem.Text = "Просмотр Инфы по фирме";
            this.просмотрИнфыПоФирмеToolStripMenuItem.Click += new System.EventHandler(this.просмотрИнфыПоФирмеToolStripMenuItem_Click);
            // 
            // редактированиеДанныхБазыToolStripMenuItem
            // 
            this.редактированиеДанныхБазыToolStripMenuItem.Name = "редактированиеДанныхБазыToolStripMenuItem";
            this.редактированиеДанныхБазыToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.редактированиеДанныхБазыToolStripMenuItem.Text = "Редактирование данных базы";
            this.редактированиеДанныхБазыToolStripMenuItem.Click += new System.EventHandler(this.редактированиеДанныхБазыToolStripMenuItem_Click);
            // 
            // письмоToolStripMenuItem
            // 
            this.письмоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьШаблонToolStripMenuItem});
            this.письмоToolStripMenuItem.Name = "письмоToolStripMenuItem";
            this.письмоToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.письмоToolStripMenuItem.Text = "Письмо";
            // 
            // редактироватьШаблонToolStripMenuItem
            // 
            this.редактироватьШаблонToolStripMenuItem.Name = "редактироватьШаблонToolStripMenuItem";
            this.редактироватьШаблонToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.редактироватьШаблонToolStripMenuItem.Text = "Редактировать шаблон";
            this.редактироватьШаблонToolStripMenuItem.Click += new System.EventHandler(this.редактироватьШаблонToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.61468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.38532F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 436);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_activeTask);
            this.tabPage1.Controls.Add(this.lv_activeTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Активные задания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_activeTask
            // 
            this.dgv_activeTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_activeTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_activeTask.Location = new System.Drawing.Point(3, 3);
            this.dgv_activeTask.Name = "dgv_activeTask";
            this.dgv_activeTask.ReadOnly = true;
            this.dgv_activeTask.Size = new System.Drawing.Size(506, 314);
            this.dgv_activeTask.TabIndex = 1;
            this.dgv_activeTask.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_activeTask_CellPainting);
            // 
            // lv_activeTask
            // 
            this.lv_activeTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_activeTask.Location = new System.Drawing.Point(3, 3);
            this.lv_activeTask.Name = "lv_activeTask";
            this.lv_activeTask.Size = new System.Drawing.Size(506, 314);
            this.lv_activeTask.TabIndex = 0;
            this.lv_activeTask.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_executedTask);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выполненные задания";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_executedTask
            // 
            this.dgv_executedTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_executedTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_executedTask.Location = new System.Drawing.Point(3, 3);
            this.dgv_executedTask.Name = "dgv_executedTask";
            this.dgv_executedTask.ReadOnly = true;
            this.dgv_executedTask.Size = new System.Drawing.Size(506, 314);
            this.dgv_executedTask.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_allTask);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(512, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Все задания";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_allTask
            // 
            this.dgv_allTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_allTask.Location = new System.Drawing.Point(3, 3);
            this.dgv_allTask.Name = "dgv_allTask";
            this.dgv_allTask.ReadOnly = true;
            this.dgv_allTask.Size = new System.Drawing.Size(506, 314);
            this.dgv_allTask.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.picb_internet, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(254, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус Internet";
            // 
            // picb_internet
            // 
            this.picb_internet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_internet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_internet.Location = new System.Drawing.Point(3, 19);
            this.picb_internet.Name = "picb_internet";
            this.picb_internet.Size = new System.Drawing.Size(121, 16);
            this.picb_internet.TabIndex = 1;
            this.picb_internet.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.64706F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(263, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(254, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lb_act_tasks, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lb_count_mails_to_sended, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(87, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(48, 32);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lb_act_tasks
            // 
            this.lb_act_tasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_act_tasks.AutoSize = true;
            this.lb_act_tasks.Location = new System.Drawing.Point(17, 17);
            this.lb_act_tasks.Name = "lb_act_tasks";
            this.lb_act_tasks.Size = new System.Drawing.Size(13, 13);
            this.lb_act_tasks.TabIndex = 3;
            this.lb_act_tasks.Text = "0";
            // 
            // lb_count_mails_to_sended
            // 
            this.lb_count_mails_to_sended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_count_mails_to_sended.AutoSize = true;
            this.lb_count_mails_to_sended.Location = new System.Drawing.Point(17, 1);
            this.lb_count_mails_to_sended.Name = "lb_count_mails_to_sended";
            this.lb_count_mails_to_sended.Size = new System.Drawing.Size(13, 13);
            this.lb_count_mails_to_sended.TabIndex = 2;
            this.lb_count_mails_to_sended.Text = "0";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(141, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать рассылку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(78, 32);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Осталось";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отправлено";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activeTask)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_executedTask)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTask)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_internet)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортБазыИзtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗаданиеНаКонкретныйEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lv_activeTask;
        private System.Windows.Forms.DataGridView dgv_activeTask;
        private System.Windows.Forms.DataGridView dgv_executedTask;
        private System.Windows.Forms.DataGridView dgv_allTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picb_internet;
        private System.Windows.Forms.ToolStripMenuItem сформироватьЗаданияНаВсюБазуToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lb_count_mails_to_sended;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem письмоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьШаблонToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lb_act_tasks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem заданияПоФирмамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрИнфыПоФирмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДанныхБазыToolStripMenuItem;
    }
}

