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
    public partial class ViewInfo : Form
    {
        public ViewInfo()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            textBox1.Enabled = true;

        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {
            rbname.Checked = true;
            comboBox1.DataSource = DBWorker.Instance.GetFrims();
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = DBWorker.Instance.GetMailsFromFirm(comboBox1.SelectedItem as Firm);
            listBox1.DisplayMember = "mail";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Firm f = DBWorker.Instance.GetFirm(new Firm() { id = Int32.Parse(textBox1.Text) }, FirmSearch.ID);
                if (f != null)
                {
                    listBox1.DataSource = DBWorker.Instance.GetMailsFromFirm(f);
                    listBox1.DisplayMember = "mail";
                }
                else {
                    listBox1.DataSource = null;
                }
            }
            else {
                listBox1.DataSource = null;
            }
        }
    }
}
