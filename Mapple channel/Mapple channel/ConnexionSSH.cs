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
        private SSH_Connection ssh = new SSH_Connection();

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

        private void SetSSHConnectionValues()
        {
            SSH_Connection.user = textBoxUser.Text;
            SSH_Connection.password = textBoxPassword.Text;
            SSH_Connection.IP = textBoxIP.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSSHConnectionValues();
            ssh.ConnectionSSH(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            SetSSHConnectionValues();
            richTextBoxConnectionResult.Text = ssh.ConnectionTest(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
        }
    }
}
