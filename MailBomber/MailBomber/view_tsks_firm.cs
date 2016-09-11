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
    public partial class view_tsks_firm : Form
    {
        public view_tsks_firm()
        {
            InitializeComponent();
        }

        private void lb_firm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_tasks.DataSource = DBWorker.Instance.GetTasksListFromFirm((lb_firm.SelectedItem as Firm));
        }

        private void view_tsks_firm_Load(object sender, EventArgs e)
        {
            lb_firm.DataSource = DBWorker.Instance.GetFrims();
            lb_firm.DisplayMember = "name";
            dgv_tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_tasks.ReadOnly = true;
        }
    }
}
