using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace MailBomber
{
    class DBWorker
    {
        private static DBWorker _this=null;
        public static DBWorker getInstance { get {
                if (DBWorker._this == null) {
                    DBWorker._this = new DBWorker();
                }
                return DBWorker._this;
            }}
        private DBWorker() {
        }
    }
}
