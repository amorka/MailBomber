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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_activeTask = new System.Windows.Forms.DataGridView();
            this.lv_activeTask = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_executedTask = new System.Windows.Forms.DataGridView();
            this.dgv_allTask = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.picb_internet = new System.Windows.Forms.PictureBox();
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activeTask)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_executedTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTask)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_internet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заданияToolStripMenuItem});
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
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem});
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
            this.label1.Location = new System.Drawing.Point(23, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус Internet";
            // 
            // picb_internet
            // 
            this.picb_internet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_internet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picb_internet.Location = new System.Drawing.Point(3, 20);
            this.picb_internet.Name = "picb_internet";
            this.picb_internet.Size = new System.Drawing.Size(121, 15);
            this.picb_internet.TabIndex = 1;
            this.picb_internet.TabStop = false;
            // 
            // сформироватьЗаданияНаВсюБазуToolStripMenuItem
            // 
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Name = "сформироватьЗаданияНаВсюБазуToolStripMenuItem";
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Text = "Сформировать задания на всю базу";
            this.сформироватьЗаданияНаВсюБазуToolStripMenuItem.Click += new System.EventHandler(this.сформироватьЗаданияНаВсюБазуToolStripMenuItem_Click);
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_executedTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTask)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_internet)).EndInit();
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
    }
}

