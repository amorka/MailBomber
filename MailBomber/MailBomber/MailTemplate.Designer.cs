namespace MailBomber
{
    partial class MailTemplate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ctd = new System.Windows.Forms.TextBox();
            this.tb_delay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема письма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тело письма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фраза для замены на название фирмы";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(33, 47);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(218, 20);
            this.tb_title.TabIndex = 3;
            // 
            // tb_word
            // 
            this.tb_word.Location = new System.Drawing.Point(33, 104);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(218, 20);
            this.tb_word.TabIndex = 4;
            this.tb_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(33, 162);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(371, 157);
            this.tb_body.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество писем в день";
            // 
            // tb_ctd
            // 
            this.tb_ctd.Location = new System.Drawing.Point(307, 47);
            this.tb_ctd.Name = "tb_ctd";
            this.tb_ctd.Size = new System.Drawing.Size(87, 20);
            this.tb_ctd.TabIndex = 8;
            // 
            // tb_delay
            // 
            this.tb_delay.Location = new System.Drawing.Point(307, 104);
            this.tb_delay.Name = "tb_delay";
            this.tb_delay.Size = new System.Drawing.Size(87, 20);
            this.tb_delay.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Задержка отправки (сек)";
            // 
            // MailTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 394);
            this.Controls.Add(this.tb_delay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ctd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_body);
            this.Controls.Add(this.tb_word);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MailTemplate";
            this.Text = "MailTemplate";
            this.Load += new System.EventHandler(this.MailTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ctd;
        private System.Windows.Forms.TextBox tb_delay;
        private System.Windows.Forms.Label label5;
    }
}