using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailBomber
{
    class DataInfo
    {
        private List<SInfo> l_tmp = null;

        public List<Firm> firms;
        public List<Mail> mails;

        public DataInfo() {
            firms = new List<Firm>();
            mails = new List<Mail>();
        }

        public List<SInfo> combo_info {
            get {
                if (l_tmp != null)
                    return l_tmp;
                else { List<SInfo> si = new List<SInfo>(); si.Add(new SInfo() { info="error"}); return si; }
            }
        }

        public void ParseFile(string fPath) {
            StreamReader sr = new StreamReader(File.Open(fPath, FileMode.Open, FileAccess.Read, FileShare.Read));
            string tmp_str = String.Empty;
            Regex reg = new Regex(@"^(.+)\|(.+)$", RegexOptions.IgnoreCase);
            Match match;
            int i = 0;
            do
            {

                tmp_str = sr.ReadLine();
                    if (tmp_str == null) break;
                    if(l_tmp==null) l_tmp = new List<SInfo>();
                l_tmp.Add(new SInfo() { info =i.ToString()+" - "+ tmp_str });
                i++;
                match = reg.Match(tmp_str);
                Group g_mail = match.Groups[1];
                mails.Add(new Mail() { mail = g_mail.Value });
                Group g_firm = match.Groups[2];
                firms.Add(new Firm() { name = g_firm.Value });

            } while (tmp_str != null);

            sr.Dispose();
        }
    } 
} 
