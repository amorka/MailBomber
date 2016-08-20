namespace MailBomber
{
    partial class CreateTask
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
            this.cb_list_firm = new System.Windows.Forms.ComboBox();
            this.lb_list_mails = new System.Windows.Forms.ListBox();
            this.dtp_Task = new System.Windows.Forms.DateTimePicker();
            this.btn_CreateTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_list_firm
            // 
            this.cb_list_firm.FormattingEnabled = true;
            this.cb_list_firm.Location = new System.Drawing.Point(12, 42);
            this.cb_list_firm.Name = "cb_list_firm";
            this.cb_list_firm.Size = new System.Drawing.Size(121, 21);
            this.cb_list_firm.TabIndex = 0;
            // 
            // lb_list_mails
            // 
            this.lb_list_mails.FormattingEnabled = true;
            this.lb_list_mails.Location = new System.Drawing.Point(153, 12);
            this.lb_list_mails.Name = "lb_list_mails";
            this.lb_list_mails.Size = new System.Drawing.Size(120, 82);
            this.lb_list_mails.TabIndex = 1;
            // 
            // dtp_Task
            // 
            this.dtp_Task.Location = new System.Drawing.Point(291, 39);
            this.dtp_Task.Name = "dtp_Task";
            this.dtp_Task.Size = new System.Drawing.Size(137, 20);
            this.dtp_Task.TabIndex = 2;
            // 
            // btn_CreateTask
            // 
            this.btn_CreateTask.Location = new System.Drawing.Point(452, 12);
            this.btn_CreateTask.Name = "btn_CreateTask";
            this.btn_CreateTask.Size = new System.Drawing.Size(90, 78);
            this.btn_CreateTask.TabIndex = 3;
            this.btn_CreateTask.Text = "Создать задание";
            this.btn_CreateTask.UseVisualStyleBackColor = true;
            this.btn_CreateTask.Click += new System.EventHandler(this.btn_CreateTask_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 112);
            this.Controls.Add(this.btn_CreateTask);
            this.Controls.Add(this.dtp_Task);
            this.Controls.Add(this.lb_list_mails);
            this.Controls.Add(this.cb_list_firm);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_list_firm;
        private System.Windows.Forms.ListBox lb_list_mails;
        private System.Windows.Forms.DateTimePicker dtp_Task;
        private System.Windows.Forms.Button btn_CreateTask;
    }
}