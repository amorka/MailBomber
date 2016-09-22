using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    public partial class Edit : Form
    {
        OpenFileDialog ofd;
        List<string> from_file;
        List<string> error_logs;
        List<Mail> mails;
        public Edit()
        {
            InitializeComponent();
            error_logs = new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task tBegin = new Task(() => {

            // загрузка строк из файла
            from_file = new List<string>();
            StreamReader sr_ff = new StreamReader(File.Open(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read));
            string ff_tmp = null;
            do
            {
                ff_tmp=sr_ff.ReadLine();
                if (ff_tmp == null || ff_tmp == String.Empty) break;
                from_file.Add(ff_tmp);
            } while (ff_tmp != null);
            sr_ff.Dispose();
            ////////////////
            mails = new List<Mail>();
            mails = DBWorker.Instance.GetMails();
            Regex reg = new Regex(@"^(.+)\|(.+)$", RegexOptions.IgnoreCase);
            Match match;
            int i = 0;
            int y = 0;
            foreach (Mail m in mails) {
                    DBWorker.Instance.BeginWork();
                    foreach (string mail_from_file in from_file) {
                    
                    match = reg.Match(mail_from_file);
                    Group g_mail = match.Groups[1];

                    if (g_mail.Value == m.mail)
                    {
                        Group firm = match.Groups[2];
                        //????
                        Firm f_t = DBWorker.Instance.GetFirmFromMailWork(m, MailSearch.ID);
                        FirmMails fm = DBWorker.Instance.GetFirmMailsObjWork(m);

                        if (f_t.name != firm.Value) {
                            /* Console.WriteLine("--------------------------------------------------------");
                             Console.WriteLine("Майл = " + m.mail);
                             Console.WriteLine("Фирма в базе = " + f_t.name);
                             Console.WriteLine("Фирма в файле = " + match.Groups[2].Value);*/
                            Firm f_new = DBWorker.Instance.GetFirmWork(new Firm() { name = firm.Value }, FirmSearch.NAME);
                                if (f_new != null)
                                {
                                    fm.id_firm = f_new.id;
                                    DBWorker.Instance.UpdateFirmMailsObjWork(fm);
                                    f_new.name = firm.Value;
                                    DBWorker.Instance.UpdateFirmWork(f_new);
                                    //if (f_new.id == 251)
                                    // {
                                    Console.WriteLine("---------------------Обновлено-------------------------");
                                    Console.WriteLine("Строка из файла = " + mail_from_file);
                                    Console.WriteLine("Найдена фирма в базе по имени из файла = " + f_new.name);
                                    Console.WriteLine("Майл = " + m.mail);
                                    Console.WriteLine("Фирма в базе = " + f_t.name);
                                    Console.WriteLine("Фирма в файле = " + match.Groups[2].Value);
                                    Console.WriteLine("Количество полученных майлов с базы = " + mails.Count.ToString());
                                    Console.WriteLine("Шаг = " + i.ToString());
                                    i++;
                                    break;
                                    // }
                                }
                                else {
                                    Console.WriteLine(" --- НЕ найдена фирма в базе по имени из файла = " + firm.Value+" с майлом "+ g_mail.Value);
                                    error_logs.Add(" --- НЕ найдена фирма в базе по имени из файла = " + firm.Value + " с майлом " + g_mail.Value);
                                    
                                    Firm f = new Firm() { name= firm.Value };
                                    DBWorker.Instance.AddFirmWork(f);
                                    f = DBWorker.Instance.GetFirmWork(f, FirmSearch.NAME);
                                    fm.id_firm = f.id;
                                    DBWorker.Instance.UpdateFirmMailsObjWork(fm);
                                    y++;
                                }
                        }
                    }
                match = null;
                }
                DBWorker.Instance.EndWork();
            }
            Console.WriteLine("Обновлено " + i.ToString()+" откорректированно "+y.ToString());
                // WriteLoag
                StreamWriter sw = new StreamWriter("log.txt");
                sw.WriteLine("Обновлено " + i.ToString() + " откорректированно " + y.ToString());
                sw.WriteLine("Количество полученных майлов с базы = " + mails.Count.ToString());
                foreach (string s_log in error_logs) {
                    sw.WriteLine(s_log);
                }
                sw.Dispose();


            ///////////////////////////////
            /// Загрузка эталонного списка 
            //StreamReader sr = new StreamReader(File.Open(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read));
            //string tmp_str = String.Empty;

            //int i = 0;
            //DBWorker.Instance.BeginWork();
            //do
            //{

            //    Regex reg = new Regex(@"^(.+)\|(.+)$", RegexOptions.IgnoreCase);
            //    Match match;
            //    tmp_str = sr.ReadLine();
            //    if (tmp_str == null || tmp_str == String.Empty) break;
            //    match = reg.Match(tmp_str);

            //    Group g_mail = match.Groups[1];
            //    Firm fff = DBWorker.Instance.GetFirmFromMailWork(new Mail() { mail = g_mail.Value }, MailSearch.MAIL);
            //    if (fff != null)
            //    {
            //        Group g_firm = match.Groups[2];
            //        if (g_firm.Value != fff.name)
            //        {
            //            fff.name = g_firm.Value;
            //            DBWorker.Instance.UpdateFirmWork(fff);

            //            // Console.WriteLine(String.Format("mail {0} firm {1} новое название {2}"));
            //            if (g_firm.Value.IndexOf("Красные Баррикады") > -1)
            //                Console.WriteLine(String.Format("В файле mail {0} firm {1} | заменяем на mail {2} firm {3}", g_mail.Value, g_firm.Value, g_mail.Value, fff.name));
            //        }
            //        else {

            //        }
            //    }


            //} while (tmp_str != null);
            //DBWorker.Instance.EndWork();
            //sr.Dispose();
            ///////////////////////////////
            MessageBox.Show("Правка закончена!");
            });

            tBegin.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "|*.txt";
            ofd.ShowDialog();
        }
    }
}
