using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    class TasksList
    {
        List<TaskToSend> _LTasks;
        public List<TaskToSend> LTasks {
            get {
                UpdateTasksList();
                return _LTasks;
            }
        }

        public List<TaskToSend> LActiveTasks {
            get {
                return DBWorker.Instance.GetActiveTasksList();
            }
        }

        public List<TaskToSend> LExecutedsTasks
        {
            get
            {
                return DBWorker.Instance.GetExecutedsTasksList();
            }
        }

        public TasksList() {
            _LTasks = new List<TaskToSend>();
            UpdateTasksList();
        }

        private void UpdateTasksList() {
            _LTasks = DBWorker.Instance.GetTasksList();
        }

        public void CreateTask(Mail m, DateTask d) {
            // Получение информации о количестве майлов у фирмы
            Firm f = DBWorker.Instance.GetFirmFromMail(m, MailSearch.ID);
            List<TaskToSend> lTasks = DBWorker.Instance.IsExistTask(m);
            if (lTasks != null) {
                if (lTasks.Exists(e => e.is_enable == 1))
                {
                    MessageBox.Show("На данный Емайл уже есть активное задание");
                }
                else
                {
                    FirmMails tmp = DBWorker.Instance.GetFirmMailsObj(m);
                    DBWorker.Instance.AddTask(new TaskToSend() {
                                                date_to_execute = d.Date,
                                                is_enable = 1,
                                                id_firm_mails= tmp.id
                    });
                    UpdateTasksList();
                }
            }
        }
    }
}
