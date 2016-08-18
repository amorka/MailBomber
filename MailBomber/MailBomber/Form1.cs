using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBomber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBWorker dw = DBWorker.Instance;

            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 1" },
            //     new Mail() { mail= "mail1@mail.ru" }
            //    );
            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 2" },
            //     new Mail() { mail = "mail2@mail.ru" }
            //    );
            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 2"},
            //     new Mail() { mail = "mail22@mail.ru" }
            //    );
            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 2"},
            //     new Mail() { mail = "mail222@mail.ru" }
            //    );
            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 3" },
            //     new Mail() { mail = "mail3@mail.ru" }
            //    );
            //dw.AddFrirmMail(
            //     new Firm() { name = "Firm 3" },
            //     new Mail() { mail = "mail22@mail.ru" }
            //    );

        }
    }
}
