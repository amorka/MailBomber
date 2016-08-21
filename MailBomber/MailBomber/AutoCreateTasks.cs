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
    public partial class AutoCreateTasks : Form
    {

        public AutoCreateTasks()
        {
            InitializeComponent();
        }

        private void btn_createTasks_Click(object sender, EventArgs e)
        {

            List<Mail> mlDHT = DBWorker.Instance.GetMailsWhereDontHaveTasks();
            TasksList tl = new TasksList();
            // Добавить Методы быстрого добавления заданий

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AutoCreateTasks_Load(object sender, EventArgs e)
        {
            tb_countMailsinBase.Text = DBWorker.Instance.GetMails().Count.ToString();
            tb_countActiveAndExecutedTasks.Text = DBWorker.Instance.GetActiveTasksList().Count.ToString() + "/" + DBWorker.Instance.GetExecutedsTasksList().Count.ToString();
            CalcInfo();
        }

        private void CalcInfo() {
            tb_countNewTasks.Text = (DBWorker.Instance.GetMails().Count - DBWorker.Instance.GetActiveTasksList().Count).ToString();
            tb_countDayToExecuted.Text = (Int32.Parse(tb_countNewTasks.Text) / Int32.Parse(tb_mail_to_day.Text)).ToString();
        }

        private void tb_mail_to_day_TextChanged(object sender, EventArgs e)
        {
            CalcInfo();
        }
    }
}
