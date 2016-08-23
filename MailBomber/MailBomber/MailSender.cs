using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MailBomber
{
    class MailSender
    {
        public delegate void DChangeInternetStatus(ConnectionStatus cs);
        public event DChangeInternetStatus EventInternetStatus;

        public delegate void DMailSended(int count);
        public event DMailSended EventMailSended;

        private MailSettings ms;
        private static MailSender _intance=null;

        public int count_mail_sended;

        public static MailSender Instance {
            get {
                if (_intance == null)
                    _intance = new MailSender();
                    return _intance;
            }
        }

        private Task taskSender;

        private MailSender() {
            ms = DBWorker.Instance.GetMailSettings();
            taskSender = new Task(MethodForSend);
            count_mail_sended = 0;
        }

        public void StartSender() { taskSender.Start(); }

        private void MethodForSend() {
            // сделать проверку доступности интернета
            List<TaskToSend> ttsList = DBWorker.Instance.GetActiveTasksList(ms.count_mails_to_send_in_day);

            for (int i = 0; i < ttsList.Count; i++) {
                if (InternetTester.TestInternetConnection() == ConnectionStatus.NotConnected) {
                    EventInternetStatus(ConnectionStatus.NotConnected);
                    MessageBox.Show("Отсутствует подключение к Интернету. Рассылка писем остановлена! (отправлено "+i+" писем)");
                    break;
                }
                Mail m = DBWorker.Instance.GetMailFromTask(ttsList[i]);
                Firm f = DBWorker.Instance.GetFirmFromMail(m, MailSearch.ID);

                if (SendMail("mail.nic.ru", "robot@skb-4.com ","pass",m.mail,ms.title,ms.body.Replace(ms.word_to_replease,f.name)))
                {
                    //запись в базу об исполненом задании
                    ttsList[i].is_enable = 0;
                    DBWorker.Instance.UpdateTasks(ttsList[i]);
                    count_mail_sended++;
                    EventMailSended(count_mail_sended);
                }
                else {
                    break;
                }
                    

                Thread.Sleep(ms.delay_to_send);
            }
        }


        private bool SendMail(string smtpServer, string from, string password, string mailto, string caption, string message, string attachFile = null)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                if (!string.IsNullOrEmpty(attachFile))
                    mail.Attachments.Add(new Attachment(attachFile));
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 25;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка отправки сообщения - " + e.Message);
                return false;
            }
        }

    }
}
