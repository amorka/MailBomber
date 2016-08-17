using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace MailBomber
{
    class Mails
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int id { get; set; }
        [NotNull]
        public string mail { get; set; }
    }
}
