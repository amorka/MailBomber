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

        public delegate void DPBActionAddTasks();
        public event DPBActionAddTasks PBActionAddTasks;

        public AutoCreateTasks()
        {
            InitializeComponent();
        }

        private void btn_createTasks_Click(object sender, EventArgs e)
        {
            DBWorker.Instance.UpdateMailSetting(Int32.Parse(tb_mail_to_day.Text), Int32.Parse(tb_delayToSend.Text));
            TasksList tl = new TasksList();
            tl.actForm = this;
            tl.CreateTasks();
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AutoCreateTasks_Load(object sender, EventArgs e)
        {
            tb_countMailsinBase.Text = DBWorker.Instance.GetMails().Count.ToString();
            tb_countActiveAndExecutedTasks.Text = DBWorker.Instance.GetActiveTasksList().Count.ToString() + "/" + DBWorker.Instance.GetExecutedsTasksList().Count.ToString();
            CalcInfo();
            pb_autoCreateTasks.Step = 1;
            pb_autoCreateTasks.Value = 0;
            pb_autoCreateTasks.Minimum = 0;
            pb_autoCreateTasks.Maximum=DBWorker.Instance.GetMailsWhereDontHaveTasks().Count;
            PBActionAddTasks += AutoCreateTasks_PBActionAddTasks;

        }

        private void AutoCreateTasks_PBActionAddTasks()
        {
            pb_autoCreateTasks.Value++;
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
