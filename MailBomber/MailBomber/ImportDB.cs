﻿using System;
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

            Task task_add_in_base = new Task(add_in_base);
            task_add_in_base.Start();


        }

        private void add_in_base() {
            if (di != null)
            {
                DBWorker dw = DBWorker.Instance;
                pb.Invoke(DlgSetMaxPB);
                
                for (int i = 0; i < di.mails.Count; i++)
                {
                    dw.AddFrirmMail(di.firms[i], di.mails[i]);
                    pb.Invoke(DlgSetValPB, new object [] { pb.Value });
                    label1.Invoke(DlgSetValLB, new object[] { di.mails[i].mail });
                }
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
    }
}
