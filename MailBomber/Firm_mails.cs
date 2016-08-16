using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace MailBomber
{
    class Firm_mails
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int id { get; set; }
        [NotNull]
        public int id_firm { get; set; }
        [NotNull]
        public int id_mail { get; set; }
    }
}
