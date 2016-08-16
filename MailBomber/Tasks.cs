using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace MailBomber
{
    class Tasks
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int id { get; set; }
        [NotNull]
        public string name { get; set; }
        [NotNull]
        public int id_firm_mails { get; set; }
        [NotNull]
        public string date_to_start { get; set; }
        [NotNull]
        public string date_to_fulfilled { get; set; }
        [NotNull]
        public int is_active { get; set; }

    }
}
