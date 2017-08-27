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
    public partial class GPIO23 : Form
    {
        private decimal duration = 0;
        public GPIO23()
        {
            InitializeComponent();
            numericUpDownTimer.Enabled = false;
            comboBoxFiles.Text = "Open_Mapple_Channels_0";
        }
        private void Design()
        {
            buttonStop.BackColor = Color.Red;
            buttonStart.BackColor = Color.Green;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio23ON(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP, comboBoxFiles.Text);
                duration = numericUpDownTimer.Value;
                if (duration != 0)
                {
                    timer.Start();
                }
            }
            else if(checkBoxTimer.Checked == false)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio23ON(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP, comboBoxFiles.Text);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio23OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
                timer.Stop();
            }
            else if (checkBoxTimer.Checked == false)
            {
                SSH_Connection ssh = new SSH_Connection();
                richTextBoxResultsCommands.Text = ssh.TurnGpio23OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP);
                timer.Stop();
            }
        }

        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked == true)
            {
                comboBoxFiles.Text = "Open_Mapple_Channels_0";
                comboBoxFiles.Enabled = false;
                numericUpDownTimer.Enabled = true;
            }
            else if (checkBoxTimer.Checked == false)
            {
                comboBoxFiles.Enabled = true;
                numericUpDownTimer.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            numericUpDownTimer.Value = duration;
            if(duration == 0)
            {
                timer.Stop();
                SSH_Connection ssh = new SSH_Connection();
                MessageBox.Show("Temps écoulée" + "\n" + "Message du server : " + ssh.TurnGpio23OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP));
                richTextBoxResultsCommands.Text = "Commande terminée. Les ports sont maintenant fermés.";
            }
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            numericUpDownTimer.Value = 0;
            numericUpDownTimer.Enabled = false;
            comboBoxFiles.Enabled = true;
            comboBoxFiles.Text = string.Empty;
            checkBoxTimer.Checked = false;
            SSH_Connection ssh = new SSH_Connection();
            MessageBox.Show(richTextBoxResultsCommands.Text = ssh.TurnGpio23OFF(SSH_Connection.user, SSH_Connection.password, SSH_Connection.IP));
        }
    }
}
