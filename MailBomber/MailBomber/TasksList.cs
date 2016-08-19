using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
