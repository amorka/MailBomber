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

        public AutoCreateTasks actForm;

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

        public void CreateTasks() {
            // Получение информации о количестве майлов у фирмы
            List<Firm> fl = DBWorker.Instance.GetFrims();
            DBWorker.Instance.BeginWork();
            // Проход по каждой фирме
            foreach (Firm f in fl) {
                //Проход по майлам фирмы
                foreach (Mail m in DBWorker.Instance.GetMailsFromFirmWork(f)) {
                    // еси на данный майл задания нет.
                    if (DBWorker.Instance.IsExistTaskWork(m) == null) {
                        // получаем последнее задание по фирме
                        TaskToSend tts = DBWorker.Instance.GetLastTaskFromFirmWork(f);
                        // если заданий нет вообще
                        if (tts == null)
                        {
                            DBWorker.Instance.AddTaskWork(new TaskToSend()
                            {
                                id_firm_mails = DBWorker.Instance.GetFirmMailsObjWork(f).id,
                                date_to_execute = new DateTask(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).CalcDate(),
                                is_enable = 1
                            });
                           // actForm.Invoke(Delegate.CreateDelegate(typeof(void),actForm, "PBActionAddTasks"));
                        }
                        // если у фирмы есть задания на другие емайлы
                        else
                        {
                            DateTask dt = new DateTask().Parse(tts.date_to_execute);
                            DBWorker.Instance.AddTaskWork(new TaskToSend()
                            {
                                id_firm_mails = DBWorker.Instance.GetFirmMailsObjWork(f).id,
                                date_to_execute = dt.CalcDate(),
                                is_enable = 1
                            });
                           // actForm.Invoke(Delegate.CreateDelegate(typeof(void), actForm, "PBActionAddTasks"));
                        }
                    }
                }
            }
            DBWorker.Instance.EndWork();
        }
    }
}
