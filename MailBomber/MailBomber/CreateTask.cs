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
    public partial class CreateTask : Form
    {
        public CreateTask()
        {
            InitializeComponent();
        }

        private void btn_CreateTask_Click(object sender, EventArgs e)
        {
            Firm f = new Firm() {id =(cb_list_firm.SelectedItem as Firm).id, name= (cb_list_firm.SelectedItem as Firm).name };
            Mail m = new Mail() { id=(lb_list_mails.SelectedItem as Mail).id, mail=(lb_list_mails.SelectedItem as Mail).mail };
            FirmMails fm = DBWorker.Instance.GetFirmMailsObj(m);
            DBWorker.Instance.AddTask(new TaskToSend() {
                is_enable = 1,
                date_to_execute=new DateTask(dtp_Task.Value.Year, dtp_Task.Value.Month, dtp_Task.Value.Day).Date,
                id_firm_mails = fm.id
            });
        }
    }
}
