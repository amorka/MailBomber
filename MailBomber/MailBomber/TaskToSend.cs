﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBomber
{
    class TaskToSend
    {
        public int id { get; set; }
        public int id_firm_mails { get; set; }
        public string date_to_execute { get; set; }
        public int is_enable { get; set; }
    }
}
