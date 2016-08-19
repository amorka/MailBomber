using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace MailBomber
{
    enum MailSearch { ID,MAIL }
    enum FirmSearch { ID, NAME }

    class DBWorker
    {
        private static DBWorker _instance=null;
        public static DBWorker Instance {
            get {
                if (_instance == null)
                {
                    _instance = new DBWorker();

                    if (!File.Exists(_instance.db_file)) {
                        _instance.CreateConnection();
                        _instance.CreateTables();
                        _instance.CloseConnection();
                    }

                    return _instance;
                }
                else {
                    return _instance;
                }
            } }
        private DBWorker() {

        }

        private SQLiteConnection connection=null;
        private string db_file = "mail_db.db";

        private void CreateConnection() {
            connection = new SQLiteConnection("Data Source="+db_file+"; Version=3;");
            connection.Open();
        }

        private void CreateTables()
        {
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "CREATE TABLE mails (id INTEGER PRIMARY KEY AUTOINCREMENT, mail TEXT);";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE firm (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT);";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE firm_mails (id INTEGER PRIMARY KEY AUTOINCREMENT, id_mail INTEGER, id_firm INTEGER);";
            com.ExecuteNonQuery();
            

        }

        private void CloseConnection() {
            connection.Dispose();
        }

        private void AddMail(Mail m) {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO mails (mail) VALUES ('"+m.mail+"');";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void AddMailWork(Mail m)
        {
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO mails (mail) VALUES ('" + m.mail + "');";
            com.ExecuteNonQuery();
        }
        private void AddMails(List<Mail> ml)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Mail m in ml)
            {
                com.CommandText = "INSERT INTO mails (mail) VALUES ('" + m.mail + "');";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private void UpgateMail(Mail m) {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE TABLE mails SET  mail='" + m.mail + "' WHERE id="+m.id+";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void UpgateMail(List<Mail> ml)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Mail m in ml)
            {
                com.CommandText = "UPDATE TABLE mails SET  mail='" + m.mail + "' WHERE id=" + m.id + ";";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private void DeleteMail(Mail m) {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "DELETE FROM mails WHERE id=" + m.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void DeleteMails(List<Mail> ml)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Mail m in ml)
            {
                com.CommandText = "DELETE FROM mails WHERE id=" + m.id + ";";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private Mail GetMail(Mail m, MailSearch ms)
        {
            Mail tmp = null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            if (ms == MailSearch.ID)
            {
                com.CommandText = "SELECT * FROM mails WHERE id=" + m.id + ";";
            }
            else {
                com.CommandText = "SELECT * FROM mails WHERE mail LIKE '" + m.mail + "';";
            }
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp = new Mail() { id = Int32.Parse(r["id"].ToString()), mail = r["mail"].ToString() };
                }
                CloseConnection();
            }
            return tmp;
        }
        private Mail GetMailWork(Mail m, MailSearch ms)
        {
            Mail tmp = null;
            SQLiteCommand com = connection.CreateCommand();
            if (ms == MailSearch.ID)
            {
                com.CommandText = "SELECT * FROM mails WHERE id=" + m.id + ";";
            }
            else {
                com.CommandText = "SELECT * FROM mails WHERE mail LIKE '" + m.mail + "';";
            }
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp = new Mail() { id = Int32.Parse(r["id"].ToString()), mail = r["mail"].ToString() };
                }
            }
            return tmp;
        }
        private List<Mail> GetMails() {
            CreateConnection();
            List<Mail> tmp_mails = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM mails;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp_mails = new List<Mail>();
                while (r.Read())
                {
                    tmp_mails.Add(new Mail() { id = Int32.Parse(r["id"].ToString()), mail = r["mail"].ToString() });
                }
            }
            CloseConnection();

            return tmp_mails;
        }


        private void AddFirm(Firm f) {
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO firms (name) VALUES ('" + f.name + "');";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void AddFirmWork(Firm f)
        {
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO firms (name) VALUES ('" + f.name + "');";
            com.ExecuteNonQuery();
        }
        private void AddFirms(List<Firm> fl)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Firm f in fl)
            {
                com.CommandText = "INSERT INTO firms (mail) VALUES ('" + f.name + "');";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private void UpgateFirm(Firm f)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE TABLE firms SET  name='" + f.name + "' WHERE id=" + f.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void UpgateFirms(List<Firm> fl)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Firm f in fl)
            {
                com.CommandText = "UPDATE TABLE firms SET  name='" + f.name + "' WHERE id=" + f.id + ";";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private void DeleteFirm(Firm f)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "DELETE FROM firms WHERE id=" + f.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void DeleteFirms(List<Firm> fl)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Firm f in fl)
            {
                com.CommandText = "DELETE FROM firms WHERE id=" + f.id + ";";
                com.ExecuteNonQuery();
            }
            CloseConnection();
        }

        private Firm GetFirm(Firm f, FirmSearch fs)
        {
            Firm tmp = null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            if (fs == FirmSearch.ID)
            {
                com.CommandText = "SELECT * FROM firms WHERE id=" + f.id + " LIMIT 1;";
            }
            else {
                com.CommandText = "SELECT * FROM firms WHERE name LIKE '" + f.name + "'  LIMIT 1;";
            }
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp = new Firm() { id = Int32.Parse(r["id"].ToString()), name = r["name"].ToString() };
                }
            }
            CloseConnection();
            return tmp;
        }
        private Firm GetFirmWork(Firm f, FirmSearch fs)
        {
            Firm tmp = null;
            SQLiteCommand com = connection.CreateCommand();
            if (fs == FirmSearch.ID)
            {
                com.CommandText = "SELECT * FROM firms WHERE id=" + f.id + " LIMIT 1;";
            }
            else {
                com.CommandText = "SELECT * FROM firms WHERE name LIKE '" + f.name + "'  LIMIT 1;";
            }
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp = new Firm() { id = Int32.Parse(r["id"].ToString()), name = r["name"].ToString() };
                }
            }
            return tmp;
        }
        private List<Firm> GetFrims()
        {
            CreateConnection();
            List<Firm> tmp_firms = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM firms;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp_firms= new List<Firm>();
                while (r.Read())
                {
                    tmp_firms.Add(new Firm() { id = Int32.Parse(r["id"].ToString()), name = r["name"].ToString() });
                }
            }
            CloseConnection();

            return tmp_firms;
        }

        public void AddFrirmMail(Firm f, Mail m) {
            
            // add firm
            Firm test_f = GetFirm(f, FirmSearch.NAME);
            if (test_f== null)
            {
                AddFirm(f);
            }
            Mail test_m = GetMail(m, MailSearch.MAIL);
            if (test_m == null)
            {
                AddMail(m);
                CreateConnection();
                SQLiteCommand com = connection.CreateCommand();
                com.CommandText = "INSERT INTO firm_mails (id_firm, id_mail) VALUES (" + GetFirm(f, FirmSearch.NAME).id + "," + GetMail(m, MailSearch.MAIL).id + ");";
                com.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void AddFrirmMailWork(Firm f, Mail m)
        {
            // add firm
                Firm test_f = GetFirmWork(f, FirmSearch.NAME);
                if (test_f == null)
                {
                    AddFirmWork(f);
                }
                Mail test_m = GetMailWork(m, MailSearch.MAIL);
                if (test_m == null)
                {
                    AddMailWork(m);
                    SQLiteCommand com = connection.CreateCommand();
                    com.CommandText = "INSERT INTO firm_mails (id_firm, id_mail) VALUES (" + GetFirmWork(f, FirmSearch.NAME).id + "," + GetMailWork(m, MailSearch.MAIL).id + ");";
                    com.ExecuteNonQuery();
                }
            
         }

        public List<Mail> GetMailsFromFirm(Firm f) {
            List<Mail> tmp_lm = null;

            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT mails.id as m_id, mails.mail as m_mail FROM firms "+
                              "INNER JOIN firm_mails ON firms.id=firm_mails.id_firm "+
                              "INNER JOIN mails ON firm_mails.id_mail=mails.id "+
                              "WHERE firms.name LIKE '"+f.name+"';";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp_lm = new List<Mail>();
                while (r.Read()) {
                    tmp_lm.Add(new Mail() { id=Int32.Parse(r["m_id"].ToString()), mail= r["m_mail"].ToString()});
                }
            }
                CloseConnection();

            return tmp_lm;
        }

        public void BeginWork() {
            connection = new SQLiteConnection("Data Source=" + db_file + "; Version=3;");
            connection.Open();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "BEGIN;";
            com.ExecuteNonQuery();
        }

        public void EndWork() {
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "COMMIT;";
            com.ExecuteNonQuery();
            connection.Dispose();
        }


    }
}
