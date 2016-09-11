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
            com.CommandText = "CREATE TABLE firms (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT);";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE firm_mails (id INTEGER PRIMARY KEY AUTOINCREMENT, id_mail INTEGER, id_firm INTEGER);";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE tasks (id INTEGER PRIMARY KEY AUTOINCREMENT, id_firm_mails INTEGER, ordering INTEGER, is_enable INTEGER);";
            com.ExecuteNonQuery();
            com.CommandText = "CREATE TABLE mail_settings (id INTEGER PRIMARY KEY AUTOINCREMENT, title TEXT, body TEXT, word_to_replease TEXT, count_mails_to_send_in_day INTEGER, delay_to_send INTEGER);";
            com.ExecuteNonQuery();
            com.CommandText = "INSERT INTO mail_settings (title, body, word_to_replease ,count_mails_to_send_in_day, delay_to_send) VALUES ('Заголовок','тело','слово для замены',300,20);";
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

        private void UpdateMail(Mail m) {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE mails SET  mail='" + m.mail + "' WHERE id="+m.id+";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void UpdateMail(List<Mail> ml)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Mail m in ml)
            {
                com.CommandText = "UPDATE mails SET  mail='" + m.mail + "' WHERE id=" + m.id + ";";
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
        public List<Mail> GetMails() {
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
        public List<Mail> GetMailsWhereDontHaveTasks()
        {
            CreateConnection();
            List<Mail> tmp_mails = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT mails.id as m_id, mails.mail as m_mail FROM mails " +
                              "INNER JOIN firm_mails ON mails.id=firm_mails.id_mail "+
                              "LEFT JOIN tasks ON firm_mails.id=tasks.id_firm_mails "+
                              "WHERE tasks.id_firm_mails IS NULL;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp_mails = new List<Mail>();
                while (r.Read())
                {
                    tmp_mails.Add(new Mail() { id = Int32.Parse(r["m_id"].ToString()), mail = r["m_mail"].ToString() });
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

        private void UpdateFirm(Firm f)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE firms SET  name='" + f.name + "' WHERE id=" + f.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        private void UpdateFirms(List<Firm> fl)
        {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            foreach (Firm f in fl)
            {
                com.CommandText = "UPDATE firms SET  name='" + f.name + "' WHERE id=" + f.id + ";";
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
        public List<Firm> GetFrims()
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

        public void AddFrirmMails(Firm f, Mail m) {
            
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
        public void AddFrirmMailsWork(Firm f, Mail m)
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
            else {
                Console.WriteLine(String.Format("- - Не был добавлен майл - {0} - Фирма - {1} -", m.mail, f.name));
            }
            
         }

        public FirmMails GetFirmMailsObj(Mail m) {
            FirmMails fm = null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * " +
                              "FROM firm_mails " +
                              "WHERE firm_mails.id_mail=" + m.id + ";";
            SQLiteDataReader r = com.ExecuteReader();
            while (r.Read()) {
                fm = new FirmMails() {id = Int32.Parse(r["id"].ToString()),
                                     id_firm = Int32.Parse(r["id_firm"].ToString()),
                                     id_mail=Int32.Parse(r["id_mail"].ToString())
                };
            }
            CloseConnection();
            return fm;
        }
        public FirmMails GetFirmMailsObj(Firm f)
        {
            FirmMails fm = null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * " +
                              "FROM firm_mails " +
                              "WHERE firm_mails.id_firm=" + f.id + ";";
            SQLiteDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                fm = new FirmMails()
                {
                    id = Int32.Parse(r["id"].ToString()),
                    id_firm = Int32.Parse(r["id_firm"].ToString()),
                    id_mail = Int32.Parse(r["id_mail"].ToString())
                };
            }
            CloseConnection();
            return fm;
        }
        public FirmMails GetFirmMailsObjWork(Mail m)
        {
            FirmMails fm = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * " +
                              "FROM firm_mails " +
                              "WHERE firm_mails.id_mail=" + m.id + ";";
            SQLiteDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                fm = new FirmMails()
                {
                    id = Int32.Parse(r["id"].ToString()),
                    id_firm = Int32.Parse(r["id_firm"].ToString()),
                    id_mail = Int32.Parse(r["id_mail"].ToString())
                };
            }
            return fm;
        }
        public FirmMails GetFirmMailsObjWork(Firm f)
        {
            FirmMails fm = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * " +
                              "FROM firm_mails " +
                              "WHERE firm_mails.id_firm=" + f.id + ";";
            SQLiteDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                fm = new FirmMails()
                {
                    id = Int32.Parse(r["id"].ToString()),
                    id_firm = Int32.Parse(r["id_firm"].ToString()),
                    id_mail = Int32.Parse(r["id_mail"].ToString())
                };
            }
            return fm;
        }

        public Firm GetFirmFromMail(Mail m, MailSearch ms) {
            Firm f = null;
            CreateConnection();
                SQLiteCommand com = connection.CreateCommand();
                SQLiteDataReader r;
                switch (ms) {
                    case MailSearch.ID:
                        com.CommandText =   "SELECT firms.id as f_id, firms.name as f_name FROM firm_mails "+
                                            "INNER JOIN firms ON firm_mails.id_firm=firms.id "+
                                            "WHERE firm_mails.id_mail="+m.id+ " LIMIT 1;";
                        r = com.ExecuteReader();
                        if (r.FieldCount > 0)
                        {
                            while (r.Read())
                            {
                                f = new Firm() { id = Int32.Parse(r["f_id"].ToString()), name = r["f_name"].ToString() };
                            }
                        }
                    break;
                    case MailSearch.MAIL:
                        com.CommandText = "SELECT firms.id as f_id, firms.name as f_name FROM firm_mails " +
                                          "INNER JOIN firms ON firm_mails.id_firm=firms.id " +
                                          "INNER JOIN mails ON firm_mails.id_mail=mails.id " +
                                          "WHERE mails.mail LIKE " + m.mail + " LIMIT 1;";
                        r = com.ExecuteReader();
                        if (r.FieldCount > 0)
                        {
                            while (r.Read())
                            {
                                f = new Firm() { id = Int32.Parse(r["f_id"].ToString()), name = r["f_name"].ToString() };
                            }
                        }
                    break;
                }
            CloseConnection();
            return f;
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
        public List<Mail> GetMailsFromFirmWork(Firm f)
        {
            List<Mail> tmp_lm = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT mails.id as m_id, mails.mail as m_mail FROM firms " +
                              "INNER JOIN firm_mails ON firms.id=firm_mails.id_firm " +
                              "INNER JOIN mails ON firm_mails.id_mail=mails.id " +
                              "WHERE firms.name LIKE '" + f.name + "';";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp_lm = new List<Mail>();
                while (r.Read())
                {
                    tmp_lm.Add(new Mail() { id = Int32.Parse(r["m_id"].ToString()), mail = r["m_mail"].ToString() });
                }
            }
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

        public List<TaskToSend> GetTasksList()
        {
            List<TaskToSend> tmp = new List<TaskToSend>();
            CreateConnection();
                SQLiteCommand com = connection.CreateCommand();
                com.CommandText = "SELECT * FROM tasks ORDER BY tasks.ordering DESC;";
                SQLiteDataReader r = com.ExecuteReader();
                if (r.FieldCount > 0)
                {
                    while (r.Read())
                    {
                        tmp.Add(new TaskToSend() { id=Int32.Parse(r["id"].ToString()),
                                                   is_enable = Int32.Parse(r["is_enable"].ToString()),
                                                   id_firm_mails = Int32.Parse(r["id_firm_mails"].ToString()),
                                                   ordering = Int32.Parse(r["ordering"].ToString())
                        });
                    }
                }
            CloseConnection();
            return tmp;
        }

        public List<TaskToSend> GetActiveTasksList()
        {
            List<TaskToSend> tmp = new List<TaskToSend>();
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM tasks WHERE is_enable=1 ORDER BY tasks.ordering ASC;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp.Add(new TaskToSend()
                    {
                        id = Int32.Parse(r["id"].ToString()),
                        is_enable = Int32.Parse(r["is_enable"].ToString()),
                        id_firm_mails = Int32.Parse(r["id_firm_mails"].ToString()),
                        ordering = Int32.Parse(r["ordering"].ToString())
                    });
                }
            }
            CloseConnection();
            return tmp;
        }

        public List<TaskToSend> GetActiveTasksList(int limit)
        {
            List<TaskToSend> tmp = new List<TaskToSend>();
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM tasks WHERE is_enable=1 ORDER BY tasks.ordering ASC LIMIT " + limit+";";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp.Add(new TaskToSend()
                    {
                        id = Int32.Parse(r["id"].ToString()),
                        is_enable = Int32.Parse(r["is_enable"].ToString()),
                        id_firm_mails = Int32.Parse(r["id_firm_mails"].ToString()),
                        ordering = Int32.Parse(r["ordering"].ToString())
                    });
                }
            }
            CloseConnection();
            return tmp;
        }

        public List<TaskToSend> GetExecutedsTasksList()
        {
            List<TaskToSend> tmp = new List<TaskToSend>();
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM tasks WHERE is_enable=0 ORDER BY tasks.ordering ASC;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    tmp.Add(new TaskToSend()
                    {
                        id = Int32.Parse(r["id"].ToString()),
                        is_enable = Int32.Parse(r["is_enable"].ToString()),
                        id_firm_mails = Int32.Parse(r["id_firm_mails"].ToString()),
                        ordering = Int32.Parse(r["ordering"].ToString())
                    });
                }
            }
            CloseConnection();
            return tmp;
        }

        public void AddTask(TaskToSend tts) {
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO tasks (id_firm_mails, is_enable, ordering) VALUES (" + tts.id_firm_mails+","+tts.is_enable+","+tts.ordering + ");";
            com.ExecuteNonQuery();
            CloseConnection();
        }
        public void AddTaskWork(TaskToSend tts)
        {
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "INSERT INTO tasks (id_firm_mails, is_enable, ordering) VALUES (" + tts.id_firm_mails + "," + tts.is_enable + "," + tts.ordering + ");";
            com.ExecuteNonQuery();
        }

        public void UpdateTasks(TaskToSend tts) {
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE tasks SET id_firm_mails="+tts.id_firm_mails+ ", is_enable="+tts.is_enable+ ", ordering=" + tts.ordering + " WHERE id=" + tts.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteTask(TaskToSend tts) {
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "DELETE FROM tasks WHERE id=" + tts.id + ";";
            com.ExecuteNonQuery();
            CloseConnection();
        }

        public List<TaskToSend> IsExistTask(Mail m) {
            List<TaskToSend> tmp = null ;
            CreateConnection();
                SQLiteCommand com = connection.CreateCommand();
                com.CommandText = "SELECT tasks.id as t_id, tasks.is_enable as t_is_enable, tasks.ordering as t_ordering, tasks.id_firm_mails as t_id_firm_mails " +
                                  "FROM tasks " +
                                  "INNER JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id "+
                                  "WHERE firm_mails.id_mail="+m.id+";";
                SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                tmp = new List<TaskToSend>();
                while (r.Read())
                {
                    tmp.Add(new TaskToSend()
                    {
                        id = Int32.Parse(r["t_id"].ToString()),
                        is_enable = Int32.Parse(r["t_is_enable"].ToString()),
                        ordering = Int32.Parse(r["t_ordering"].ToString()),
                        id_firm_mails = Int32.Parse(r["t_id_firm_mails"].ToString())
                    });
                }
            }
            CloseConnection();

            return tmp;
        }
        public List<TaskToSend> IsExistTaskWork(Mail m)
        {
            List<TaskToSend> tmp = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT tasks.id as t_id, tasks.is_enable as t_is_enable, tasks.ordering as t_ordering, tasks.id_firm_mails as t_id_firm_mails " +
                              "FROM tasks " +
                              "LEFT JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id " +
                              "WHERE firm_mails.id_mail=" + m.id + ";";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if(tmp==null) tmp = new List<TaskToSend>();
                    tmp.Add(new TaskToSend()
                    {
                        id = Int32.Parse(r["t_id"].ToString()),
                        is_enable = Int32.Parse(r["t_is_enable"].ToString()),
                        ordering = Int32.Parse(r["t_ordering"].ToString()),
                        id_firm_mails = Int32.Parse(r["t_id_firm_mails"].ToString())
                    });
                }
            }
            return tmp;
        }

        public TaskToSend GetLastTaskFromFirm(Firm f) {
            CreateConnection();
            TaskToSend tmp=null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT tasks.id as t_id, tasks.ordering as t_ordering, tasks.id_firm_mails as t_id_firm_mails, tasks.is_enable as t_is_enable FROM tasks " +
                              "INNER JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id " +
                              "WHERE firm_mails.id_firm=" + f.id + " ORDER BY tasks.ordering DESC;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                r.Read();
                tmp = new TaskToSend()
                {
                    id = Int32.Parse(r["t_id"].ToString()),
                    ordering = Int32.Parse(r["t_ordering"].ToString()),
                    id_firm_mails = Int32.Parse(r["t_id_firm_mails"].ToString()),
                    is_enable = Int32.Parse(r["t_is_enable"].ToString()),
                };
            }
            CloseConnection();
            return tmp;
        }
        public TaskToSend GetLastTaskFromFirmWork(Firm f)
        {
            TaskToSend tmp = null;
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT tasks.id as t_id, tasks.ordering as t_ordering, tasks.id_firm_mails as t_id_firm_mails, tasks.is_enable as t_is_enable FROM tasks " +
                              "INNER JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id " +
                              "WHERE firm_mails.id_firm=" + f.id + " ORDER BY tasks.ordering DESC;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.StepCount > 0)
            {
                r.Read();
                tmp = new TaskToSend()
                {
                    id = Int32.Parse(r["t_id"].ToString()),
                    ordering = Int32.Parse(r["t_ordering"].ToString()),
                    id_firm_mails = Int32.Parse(r["t_id_firm_mails"].ToString()),
                    is_enable = Int32.Parse(r["t_is_enable"].ToString())
                }; 
            }
            return tmp;
        }

        public MailSettings GetMailSettings()
        {
            MailSettings ms=null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT * FROM mail_settings LIMIT 1;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    ms = new MailSettings() {
                        id = Int32.Parse(r["id"].ToString()),
                        body = r["body"].ToString(),
                        title = r["title"].ToString(),
                        word_to_replease = r["word_to_replease"].ToString(),
                        delay_to_send = Int32.Parse(r["delay_to_send"].ToString()),
                        count_mails_to_send_in_day = Int32.Parse(r["count_mails_to_send_in_day"].ToString()),
                    };
                }
            }
            CloseConnection();
            return ms;
        }

        public Mail GetMailFromTask(TaskToSend tts) {
            Mail m = null;
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT mails.id as m_id, mails.mail as m_mail "+
                              "FROM tasks "+
                              "INNER JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id "+
                              "INNER JOIN mails ON firm_mails.id_mail=mails.id "+
                              "WHERE tasks.id ="+tts.id+";";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    m = new Mail()
                    {
                        id = Int32.Parse(r["m_id"].ToString()),
                        mail = r["m_mail"].ToString()
                    };
                }
            }

            CloseConnection();
            return m;
        }

        public void UpdateMailSetting(int count_to_day, int delay) {
            CreateConnection();

            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "UPDATE mail_settings SET count_mails_to_send_in_day=" + count_to_day + ", delay_to_send="+ delay + " WHERE id=1;";
            com.ExecuteNonQuery();
            CloseConnection();
        }

        public void UpdateMailSetting(string title, string body, string word, int c_t_d, int delay)
        {
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            BinaryWriter bw = new BinaryWriter(new MemoryStream());
            com.CommandText = "UPDATE mail_settings SET title='" + title + "', body='" + body + "', word_to_replease='"+word+ "', count_mails_to_send_in_day="+c_t_d+", delay_to_send="+delay+" WHERE id=1;";
            com.ExecuteNonQuery();
            CloseConnection();
        }

        public List<TaskToSend> GetTasksListFromFirm(Firm f) {
            List<TaskToSend> tmp = new List<TaskToSend>();
            CreateConnection();
            SQLiteCommand com = connection.CreateCommand();
            com.CommandText = "SELECT tasks.id as t_id, tasks.ordering as t_ordering, tasks.id_firm_mails as t_id_firm_mails, tasks.is_enable as t_is_enable FROM tasks " +
                              "INNER JOIN firm_mails ON tasks.id_firm_mails=firm_mails.id " +
                              "WHERE firm_mails.id_firm=" + f.id + " ORDER BY tasks.ordering ASC;";
            SQLiteDataReader r = com.ExecuteReader();
            if (r.FieldCount > 0)
            {
                while (r.Read())
                {
                    TaskToSend tmpt = new TaskToSend()
                    {
                        id = Int32.Parse(r["t_id"].ToString()),
                        ordering = Int32.Parse(r["t_ordering"].ToString()),
                        id_firm_mails = Int32.Parse(r["t_id_firm_mails"].ToString()),
                        is_enable = Int32.Parse(r["t_is_enable"].ToString()),
                    };
                    tmp.Add(tmpt);
                }
            }
            CloseConnection();
            return tmp;
        }



        //public TaskToSend GetLastTaskFromFirm(Mail m)
        //{
        //}
    }
}
