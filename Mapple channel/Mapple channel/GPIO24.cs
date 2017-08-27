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
    public partial class GPIO24 : Form
    {
        private decimal duration = 0;
        public GPIO24()
        {
            InitializeComponent();
            numericUpDownTimer.Enabled = false;
        }
        private void Design()
        {
            buttonStop.BackColor = Color.Red;
            buttonStart.BackColor = Color.Green;
        }

        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                numericUpDownTimer.Enabled = true;
            }
            else if (checkBoxTimer.Checked == false)
            {
                numericUpDownTimer.Enabled = false;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            numericUpDownTimer.Value = 0;
            numericUpDownTimer.Enabled = false;
            checkBoxTimer.Checked = false; ;
            SSH_Connection ssh = new SSH_Connection();
            MessageBox.Show(richTextBoxResultsCommands.Text = ssh.TurnGpio24OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio24OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
                timer.Stop();
            }
            else if (checkBoxTimer.Checked == false)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio24OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
                timer.Stop();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio24ON(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
                duration = numericUpDownTimer.Value;
                if (duration != 0)
                {
                    timer.Start();
                }
            }
            else if (checkBoxTimer.Checked == false)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio24ON(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            duration--;
            numericUpDownTimer.Value = duration;
            if (duration == 0)
            {
                timer.Stop();
                SSH_Connection ssh = new SSH_Connection();
                MessageBox.Show("Temps écoulée" + "\n" + "Message du server : " + ssh.TurnGpio24OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP));
                richTextBoxResultsCommands.Text = "Commande terminée. Les ports sont maintenant fermés.";
            }
        }
    }
}
