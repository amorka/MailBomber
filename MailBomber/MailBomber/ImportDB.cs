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
    public partial class ImportDB : Form
    {
        public ImportDB()
        {
            InitializeComponent();
        }

        private void ImportDB_Load(object sender, EventArgs e)
        {
            lv_allInfo.Columns.Add("firms");
            lv_allInfo.Columns.Add("mails");
            lv_allInfo.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_allInfo.View = View.Details;
        }

        private void ChangeDataSource(DataInfo di)
        {
            int a; 
        }
    }
}
