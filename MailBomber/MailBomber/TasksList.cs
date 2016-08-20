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
        List<TaskToSend> LTasks;

        public TasksList() {
            LTasks = new List<TaskToSend>();
            UpdateTasksList();
        }

        private void UpdateTasksList() {
            LTasks = DBWorker.Instance.GetTasksList();
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
                }
            }
            // проверка нет ли такого майла в заданиях

            // проверка нет ли фирмы такой в заданиях

            // если есть то активно или нет

            // если нету то добавляем с датой больше последнего
        }
    }
}
