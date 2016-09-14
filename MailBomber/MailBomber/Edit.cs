using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    public partial class Edit : Form
    {
        OpenFileDialog ofd;

        public Edit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///////////////////////////////
            /// Загрузка эталонного списка 
            StreamReader sr = new StreamReader(File.Open(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read));
            string tmp_str = String.Empty;
            Regex reg = new Regex(@"^(.+)\|(.+)$", RegexOptions.IgnoreCase);
            Match match;
            int i = 0;
            DBWorker.Instance.BeginWork();
            do
            {

                tmp_str = sr.ReadLine();
                if (tmp_str == null) break;
                match = reg.Match(tmp_str);

                Group g_mail = match.Groups[1];
                Firm f = DBWorker.Instance.GetFirmFromMailWork(new Mail() { mail = g_mail.Value }, MailSearch.MAIL);
                if (f != null)
                {
                    Group g_firm = match.Groups[2];
                    if (!g_firm.Value.Equals(f.name))
                    {
                        f.name = g_firm.Value;
                        DBWorker.Instance.UpdateFirmWork(f);
                    }
                }
                

            } while (tmp_str != null);
            DBWorker.Instance.EndWork();
            sr.Dispose();
            ///////////////////////////////
            //if (DBWorker.Instance.GetMail(new Mail() { mail= })


        }
    }
}
