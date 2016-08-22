using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBomber
{
    class MailSender
    {
        private MailSettings ms;
        private static MailSender _intance=null;

        public static MailSender Instance {
            get {
                if (_intance == null)
                    _intance = new MailSender();
                    return _intance;
            }
        }

        private MailSender() {
            ms = DBWorker.Instance.GetMailSettings();
        }


    }
}
