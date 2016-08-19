using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBomber
{
    class DataInfo
    {
        public List<Mail> mails { get; set; } 
        public List<Firm> firms { get; set; }

        public List<SInfo> combo_info {
            get {
                Firm f1 = new Firm() { name = "F1" };
                Firm f2 = new Firm() { name = "F2" };

                Mail m1 = new Mail() { mail = "m1" };
                Mail m2 = new Mail() { mail = "m2" };
                ///////

                List<SInfo> l_tmp = new List<SInfo>();

                l_tmp.Add(new SInfo() { info = f1.name + " | " + m1.mail });
                l_tmp.Add(new SInfo() { info = f2.name + " | " + m2.mail });
                
                return l_tmp;
            }
        }
    } 
} 
