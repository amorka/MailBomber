using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SQLite;
using System.Windows.Forms;

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
        private SQLiteConnection connect = null;
        private DBWorker() {
        }


        private void Connect() {
            try
            {
                if (connect == null)
                {
                    bool is_new_db = false;
                    if (!File.Exists(Setting.DB_PATH))
                    {
                        is_new_db = true;
                    }
                    connect = new SQLiteConnection(Setting.DB_PATH, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, false);
                    
                    if (is_new_db)
                    {

                        connect.CreateTable<Mails>();
                        connect.Insert(new Mails()
                        {
                            id = 1,
                            mail = "amorka89@gmail.com"
                        });
                    }
                }
            }
            catch (SQLiteException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnect() {
            
                connect.Dispose();
            
        }

        public void test() {
            Connect();
            Disconnect();
        }
    }
}
