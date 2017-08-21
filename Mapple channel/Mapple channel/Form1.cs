using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapple_channel
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            SetTextboxes();
        }

        private void SetTextboxes()
        {
            textBoxIP. Text = "192.168.2.14";
            textBoxPassword.Text = "raspberry";
            textBoxUser.Text = "pi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSH_Connection.user = textBoxUser.Text;
            SSH_Connection.password = textBoxPassword.Text;
            SSH_Connection.IP = textBoxIP.Text;

            Tableau tab = new Tableau();
            tab.Show();

            SSH_Connection ssh = new SSH_Connection();
            richTextBoxConnectionResult.Text = ssh.ConnectionTest(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
        }
    }
}
