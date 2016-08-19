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

        public void CreateTask(Firm m, DateTask d) {
            // Получение информации о количестве майлов у фирмы

            // проверка нет ли такого майла в заданиях

            // проверка нет ли фирмы такой в заданиях

            // если есть то активно или нет

            // если нету то добавляем с датой больше последнего
        }
    }
}
