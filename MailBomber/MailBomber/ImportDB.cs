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
    public partial class ImportDB : Form
    {

        private string file_to_import = "";
        DataInfo di;

        public delegate void DlgObjSetMaxPB();
        DlgObjSetMaxPB DlgSetMaxPB;

        public delegate void DlgObjSetValPB(int v);
        DlgObjSetValPB DlgSetValPB;

        public delegate void DlgObjSetValLB(string s);
        DlgObjSetValLB DlgSetValLB;

        Task task_add_in_base;

        public ImportDB()
        {
            InitializeComponent();
        }

        private void ImportDB_Load(object sender, EventArgs e)
        {
            dgv_all.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "INFO",
                DataPropertyName = "info",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
               
            });
            dgv_all.AutoGenerateColumns = false;
            pb.Minimum = 0;
            pb.Step = 1;
            DlgSetMaxPB = new DlgObjSetMaxPB(SetMaxPB);
            DlgSetValPB = new DlgObjSetValPB(SetValuePB);
            DlgSetValLB = new DlgObjSetValLB(SetValLB);
            task_add_in_base = new Task(add_in_base);

        }

        private void ChangeDataSource(DataInfo di)
        {
            dgv_all.DataSource = null;
            dgv_all.DataSource = di.combo_info;

            lbFirms.DataSource = di.firms;
            lbFirms.DisplayMember = "name";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".txt|*.txt";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK) {
                file_to_import = ofd.FileName;
                label1.Text = ofd.SafeFileName;

                di = new DataInfo();
                di.ParseFile(file_to_import);
                ChangeDataSource(di);
                this.Text = di.combo_info.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBWorker.Instance.BeginWork();
            task_add_in_base.Start();
        }

        private void add_in_base() {
            if (di != null)
            {
                pb.Invoke(DlgSetMaxPB);

                Console.WriteLine(String.Format("Майлов считано из файла {0}", di.mails.Count));

                for (int i = 0; i < di.mails.Count; i++)
                {
                        DBWorker.Instance.AddFrirmMailsWork(di.firms[i], di.mails[i]);
                        pb.Invoke(DlgSetValPB, new object[] { (i+1) });
                        label1.Invoke(DlgSetValLB, new object[] { di.mails[i].mail });
                }
                DBWorker.Instance.EndWork();
                MessageBox.Show("Импорт завершен!");
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void SetMaxPB() {
            pb.Maximum = di.mails.Count;
        }

        private void SetValuePB( int value)
        {
            pb.Value= value;
        }

        private void SetValLB(string s) {
            label1.Text = s;
        }

        private void ImportDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (task_add_in_base.Status == TaskStatus.Running) {
                task_add_in_base.Dispose();
            }
        }
    }
}
