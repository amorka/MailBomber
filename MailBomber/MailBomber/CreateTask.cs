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
        public Form1 parentForm;

        public delegate void EventConteinerUpdateTaskList();

        public event EventConteinerUpdateTaskList UpdateTaskList;
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

            UpdateTaskList();
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                UpdateTaskList += parentForm.UpdateListTask;
            }

            cb_list_firm.DataSource = DBWorker.Instance.GetFrims();
            cb_list_firm.DisplayMember = "name";
            cb_list_firm.SelectedIndex = 0;
            cb_list_firm.SelectedIndexChanged += Cb_list_firm_SelectedIndexChanged;
        }

        private void Cb_list_firm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_list_mails.DataSource = null;
            lb_list_mails.DataSource = DBWorker.Instance.GetMailsFromFirm((cb_list_firm.SelectedItem as Firm));
            lb_list_mails.DisplayMember = "mail";
            lb_list_mails.SelectedIndex = 0;
        }
    }
}
