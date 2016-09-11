namespace MailBomber
{
    partial class view_tsks_firm
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
            this.lb_firm = new System.Windows.Forms.ListBox();
            this.dgv_tasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_firm
            // 
            this.lb_firm.FormattingEnabled = true;
            this.lb_firm.Location = new System.Drawing.Point(12, 12);
            this.lb_firm.Name = "lb_firm";
            this.lb_firm.Size = new System.Drawing.Size(183, 238);
            this.lb_firm.TabIndex = 0;
            this.lb_firm.SelectedIndexChanged += new System.EventHandler(this.lb_firm_SelectedIndexChanged);
            // 
            // dgv_tasks
            // 
            this.dgv_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tasks.Location = new System.Drawing.Point(212, 12);
            this.dgv_tasks.Name = "dgv_tasks";
            this.dgv_tasks.Size = new System.Drawing.Size(393, 238);
            this.dgv_tasks.TabIndex = 1;
            // 
            // view_tsks_firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 262);
            this.Controls.Add(this.dgv_tasks);
            this.Controls.Add(this.lb_firm);
            this.Name = "view_tsks_firm";
            this.Text = "view_tsks_firm";
            this.Load += new System.EventHandler(this.view_tsks_firm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_firm;
        private System.Windows.Forms.DataGridView dgv_tasks;
    }
}