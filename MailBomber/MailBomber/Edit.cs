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
        List<Mail> mails;
        public Edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
           // DBWorker.Instance.BeginWork();
            Regex reg = new Regex(@"^(.+)\|(.+)$", RegexOptions.IgnoreCase);
            Match match;
            int i = 0;
            foreach (Mail m in mails) {
                foreach (string mail_from_file in from_file) {
                    match = reg.Match(mail_from_file);
                    Group g_mail = match.Groups[1];

                    if (g_mail.Value == m.mail)
                    {
                        Thread.Sleep(50);
                        Group firm = match.Groups[2];
                        //????
                        Firm f_t = DBWorker.Instance.GetFirmFromMail(m, MailSearch.ID);
                        Thread.Sleep(50);
                        FirmMails fm = DBWorker.Instance.GetFirmMailsObj(m);

                        if (f_t.name != match.Groups[2].Value) {
                            /* Console.WriteLine("--------------------------------------------------------");
                             Console.WriteLine("Майл = " + m.mail);
                             Console.WriteLine("Фирма в базе = " + f_t.name);
                             Console.WriteLine("Фирма в файле = " + match.Groups[2].Value);*/
                            Firm f_new = DBWorker.Instance.GetFirm(new Firm() { name = match.Groups[2].Value }, FirmSearch.NAME);
                            if (f_new != null) {
                                fm.id_firm = f_new.id;
                                DBWorker.Instance.UpdateFirmMailsObj(fm);
                                DBWorker.Instance.UpdateFirm(f_new);
                                //if (f_new.id == 251)
                               // {
                                    Console.WriteLine("---------------------Обновлено-------------------------");
                                    Console.WriteLine("Строка из файла = "+ mail_from_file);
                                    Console.WriteLine("Найдена фирма в базе по имени из файла = "+ f_new.name);
                                    Console.WriteLine("Майл = " + m.mail);
                                    Console.WriteLine("Фирма в базе = " + f_t.name);
                                    Console.WriteLine("Фирма в файле = " + match.Groups[2].Value);
                                    Console.WriteLine("Шаг = " + i.ToString());
                                i++;
                                break;
                               // }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Обновлено " + i.ToString());
            //DBWorker.Instance.EndWork();




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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "|*.txt";
            ofd.ShowDialog();
        }
    }
}
