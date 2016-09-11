using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    public partial class Form1 : Form
    {
        TasksList tl;

        public delegate void DChangeCountSendedMails(int c);
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBWorker dw = DBWorker.Instance;
            tl = new TasksList();
            UpdateListTask();

            dgv_activeTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_activeTask.AllowUserToAddRows = false;
            dgv_activeTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_executedTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_executedTask.AllowUserToAddRows = false;
            dgv_executedTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_allTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_allTask.AllowUserToAddRows = false;
            dgv_allTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (InternetTester.TestInternetConnection() == ConnectionStatus.Connected)
            {
                picb_internet.BackColor = Color.Green;
                button1.Enabled = true;
            }
            else
            {
                picb_internet.BackColor = Color.Red;
            }
        }

        private void импортБазыИзtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDB idb = new ImportDB();
            if (idb.ShowDialog() == DialogResult.OK) {

            }
        }

        private void создатьЗаданиеНаКонкретныйEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask ct = new CreateTask();
            ct.parentForm = this;
            ct.Show();
        }


        public void UpdateListTask() {

            //MessageBox.Show("Обновление списка активных заданий");
            BindingSource bs_activeTask = new BindingSource();
            dgv_activeTask.DataSource = null;
            bs_activeTask.DataSource = tl.LActiveTasks;
            dgv_activeTask.DataSource = bs_activeTask;

            BindingSource bs_executedTask = new BindingSource();
            dgv_executedTask.DataSource = null;
            bs_executedTask.DataSource = tl.LExecutedsTasks;
            dgv_executedTask.DataSource = bs_executedTask;

            BindingSource bs_allTask = new BindingSource();
            dgv_allTask.DataSource = null;
            bs_allTask.DataSource = tl.LTasks;
            dgv_allTask.DataSource = bs_allTask;

            lb_act_tasks.Text = dgv_activeTask.Rows.Count.ToString();

        }

        private void dgv_activeTask_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void сформироватьЗаданияНаВсюБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoCreateTasks act = new AutoCreateTasks();
            if (act.ShowDialog() == DialogResult.OK) {
                UpdateListTask();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailSender.Instance.EventInternetStatus += changeStatusInternet;
            MailSender.Instance.EventMailSended += changeCountSendedMails;
            MailSender.Instance.StartSender();
        }

        public void changeStatusInternet(ConnectionStatus cs) {
            if (cs == ConnectionStatus.Connected)
            {
                picb_internet.BackColor = Color.Green;
            }
            else
            {
                picb_internet.BackColor = Color.Red;
                button1.Enabled = false;
            }
        }

        public void changeCountSendedMails(int count) {
            lb_count_mails_to_sended.Invoke(new DChangeCountSendedMails(SetCountSendedMails), new object[] { count});
        }

        private void SetCountSendedMails(int c) {
            lb_count_mails_to_sended.Text = c.ToString();
            UpdateListTask();
        }

        private void редактироватьШаблонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailTemplate mt = new MailTemplate();
            if (mt.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Настройки сохранены!");
            }
        }

        private void заданияПоФирмамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_tsks_firm vtf = new view_tsks_firm();
            vtf.Show();
        }
    }
}
