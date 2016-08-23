using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    public partial class MailTemplate : Form
    {
        MailSettings ms;

        public MailTemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_body.Text == String.Empty) return;
            if (tb_title.Text == String.Empty) return;
            if (tb_word.Text == String.Empty) return;
            if (tb_delay.Text == String.Empty) return;
            if (tb_ctd.Text == String.Empty) return;
            DBWorker.Instance.UpdateMailSetting(tb_title.Text, tb_body.Text,tb_word.Text,Int32.Parse(tb_ctd.Text), Int32.Parse(tb_delay.Text));
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void MailTemplate_Load(object sender, EventArgs e)
        {
            ms = DBWorker.Instance.GetMailSettings();

            tb_title.Text = ms.title;
            tb_word.Text = ms.word_to_replease;
            tb_body.Text = ms.body;
            tb_delay.Text = ms.delay_to_send.ToString();
            tb_ctd.Text = ms.count_mails_to_send_in_day.ToString();

        }
    }
}
