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

            picb_internet.BackColor = Color.Red;
            TestInternet();
        }

        private void TestInternet()
        {
            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.Arguments = @"/C ping google.com";
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.UseShellExecute = false;
            //p.Start();
            //StreamReader sr = p.StandardOutput;
            //this.Text = sr.ReadToEnd();
            //sr.Close();
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
    }
}
