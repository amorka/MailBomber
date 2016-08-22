using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBomber
{
    class MailSettings
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body{ get; set; }
        public string word_to_replease{ get; set; }
        public int count_mails_to_send_in_day{ get; set; }
        public int  delay_to_send{ get; set; }
    }
}
