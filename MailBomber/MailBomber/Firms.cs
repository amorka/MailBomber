using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace MailBomber
{
    class Firms
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int id { get; set; }
        [NotNull]
        public string name { get; set; }
    }
}
