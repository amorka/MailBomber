namespace MailBomber
{
    partial class AutoCreateTasks
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
            this.tb_mail_to_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_1mailToDay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_rewriteTasks = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_delayToSend = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_countActiveAndExecutedTasks = new System.Windows.Forms.TextBox();
            this.tb_countMailsinBase = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_countDayToExecuted = new System.Windows.Forms.TextBox();
            this.tb_countNewTasks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_createTasks = new System.Windows.Forms.Button();
            this.pb_autoCreateTasks = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_mail_to_day
            // 
            this.tb_mail_to_day.Location = new System.Drawing.Point(153, 29);
            this.tb_mail_to_day.Name = "tb_mail_to_day";
            this.tb_mail_to_day.Size = new System.Drawing.Size(75, 20);
            this.tb_mail_to_day.TabIndex = 0;
            this.tb_mail_to_day.Text = "300";
            this.tb_mail_to_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_mail_to_day.TextChanged += new System.EventHandler(this.tb_mail_to_day_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество Email в день";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "В день на 1 Email фирмы";
            // 
            // cb_1mailToDay
            // 
            this.cb_1mailToDay.AutoSize = true;
            this.cb_1mailToDay.Checked = true;
            this.cb_1mailToDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_1mailToDay.Location = new System.Drawing.Point(183, 94);
            this.cb_1mailToDay.Name = "cb_1mailToDay";
            this.cb_1mailToDay.Size = new System.Drawing.Size(15, 14);
            this.cb_1mailToDay.TabIndex = 3;
            this.cb_1mailToDay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пересозадать задачи?";
            // 
            // cb_rewriteTasks
            // 
            this.cb_rewriteTasks.AutoSize = true;
            this.cb_rewriteTasks.Checked = true;
            this.cb_rewriteTasks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_rewriteTasks.Location = new System.Drawing.Point(183, 128);
            this.cb_rewriteTasks.Name = "cb_rewriteTasks";
            this.cb_rewriteTasks.Size = new System.Drawing.Size(15, 14);
            this.cb_rewriteTasks.TabIndex = 5;
            this.cb_rewriteTasks.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_delayToSend);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_rewriteTasks);
            this.groupBox1.Controls.Add(this.tb_mail_to_day);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_1mailToDay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // tb_delayToSend
            // 
            this.tb_delayToSend.Location = new System.Drawing.Point(153, 61);
            this.tb_delayToSend.Name = "tb_delayToSend";
            this.tb_delayToSend.Size = new System.Drawing.Size(75, 20);
            this.tb_delayToSend.TabIndex = 7;
            this.tb_delayToSend.Text = "5";
            this.tb_delayToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Задержда отправки (сек)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество Майлов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество задани (а/в)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Предворительное количество новых";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_countActiveAndExecutedTasks);
            this.groupBox2.Controls.Add(this.tb_countMailsinBase);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 83);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сводка";
            // 
            // tb_countActiveAndExecutedTasks
            // 
            this.tb_countActiveAndExecutedTasks.Location = new System.Drawing.Point(136, 52);
            this.tb_countActiveAndExecutedTasks.Name = "tb_countActiveAndExecutedTasks";
            this.tb_countActiveAndExecutedTasks.ReadOnly = true;
            this.tb_countActiveAndExecutedTasks.Size = new System.Drawing.Size(97, 20);
            this.tb_countActiveAndExecutedTasks.TabIndex = 9;
            this.tb_countActiveAndExecutedTasks.Text = "0/0";
            this.tb_countActiveAndExecutedTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_countMailsinBase
            // 
            this.tb_countMailsinBase.Location = new System.Drawing.Point(153, 23);
            this.tb_countMailsinBase.Name = "tb_countMailsinBase";
            this.tb_countMailsinBase.ReadOnly = true;
            this.tb_countMailsinBase.Size = new System.Drawing.Size(63, 20);
            this.tb_countMailsinBase.TabIndex = 8;
            this.tb_countMailsinBase.Text = "0";
            this.tb_countMailsinBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_countDayToExecuted);
            this.groupBox3.Controls.Add(this.tb_countNewTasks);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 136);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Прогноз";
            // 
            // tb_countDayToExecuted
            // 
            this.tb_countDayToExecuted.Location = new System.Drawing.Point(84, 108);
            this.tb_countDayToExecuted.Name = "tb_countDayToExecuted";
            this.tb_countDayToExecuted.ReadOnly = true;
            this.tb_countDayToExecuted.Size = new System.Drawing.Size(63, 20);
            this.tb_countDayToExecuted.TabIndex = 11;
            this.tb_countDayToExecuted.Text = "0";
            this.tb_countDayToExecuted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_countNewTasks
            // 
            this.tb_countNewTasks.Location = new System.Drawing.Point(84, 51);
            this.tb_countNewTasks.Name = "tb_countNewTasks";
            this.tb_countNewTasks.ReadOnly = true;
            this.tb_countNewTasks.Size = new System.Drawing.Size(63, 20);
            this.tb_countNewTasks.TabIndex = 10;
            this.tb_countNewTasks.Text = "0";
            this.tb_countNewTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Время полного выполнения";
            // 
            // btn_createTasks
            // 
            this.btn_createTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_createTasks.Location = new System.Drawing.Point(13, 442);
            this.btn_createTasks.Name = "btn_createTasks";
            this.btn_createTasks.Size = new System.Drawing.Size(238, 44);
            this.btn_createTasks.TabIndex = 11;
            this.btn_createTasks.Text = "Сформировать";
            this.btn_createTasks.UseVisualStyleBackColor = true;
            this.btn_createTasks.Click += new System.EventHandler(this.btn_createTasks_Click);
            // 
            // pb_autoCreateTasks
            // 
            this.pb_autoCreateTasks.Location = new System.Drawing.Point(12, 492);
            this.pb_autoCreateTasks.Name = "pb_autoCreateTasks";
            this.pb_autoCreateTasks.Size = new System.Drawing.Size(240, 23);
            this.pb_autoCreateTasks.TabIndex = 12;
            // 
            // AutoCreateTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 523);
            this.Controls.Add(this.pb_autoCreateTasks);
            this.Controls.Add(this.btn_createTasks);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoCreateTasks";
            this.Text = "AutoCreateTasks";
            this.Load += new System.EventHandler(this.AutoCreateTasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mail_to_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_1mailToDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_rewriteTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_countActiveAndExecutedTasks;
        private System.Windows.Forms.TextBox tb_countMailsinBase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_countDayToExecuted;
        private System.Windows.Forms.TextBox tb_countNewTasks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_createTasks;
        private System.Windows.Forms.TextBox tb_delayToSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pb_autoCreateTasks;
    }
}