using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using System.Data.SQLite;

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
        private System.Data.SQLite.SQLiteConnection connect = null;
        private DBWorker() {
        }


        private void Connect() {
            if (connect == null || connect.State == System.Data.ConnectionState.Closed) {
                if (!File.Exists(Setting.DB_PATH))
                {
                    System.Data.SQLite.SQLiteConnection.CreateFile(Setting.DB_PATH);
                }
                connect = new System.Data.SQLite.SQLiteConnection("Data Source="+Setting.DB_PATH+"; Version=3;");
                connect.Open();
                
            }
        }

        private void Disconnect() {
            if (connect.State != System.Data.ConnectionState.Closed) {
                connect.Dispose();
            }
        }
    }
}
