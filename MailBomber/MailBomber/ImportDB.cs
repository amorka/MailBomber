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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgv_all.AutoGenerateColumns = false;

            DataInfo di = new DataInfo();
            di.firms = new List<Firm>();
            di.firms.Add(new Firm() { name = "Firm1" });
            di.firms.Add(new Firm() { name = "Firm2" });
            di.mails = new List<Mail>();
            di.mails.Add(new Mail() { mail="mail@1"});
            di.mails.Add(new Mail() { mail = "mail@2" });
            ChangeDataSource(di);
        }

        private void ChangeDataSource(DataInfo di)
        {
            
            dgv_all.DataSource = di.combo_info;



        }
    }
}
