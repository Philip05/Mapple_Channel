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
    public partial class ChoixGPIO : Form
    {
        public ChoixGPIO()
        {
            InitializeComponent();
        }

        private void buttonGPIO23_Click(object sender, EventArgs e)
        {
            GPIO23 gpio23 = new GPIO23();
            gpio23.Text = "GPIO 23   Connecté à " + SSH_Connection.IP;
            gpio23.Show();
        }

        private void GPIO24_Click(object sender, EventArgs e)
        {
            GPIO24 gpio24 = new GPIO24();
            gpio24.Text = " GPIO 24   Connecté à " + SSH_Connection.IP;
            gpio24.Show();
        }
    }
}
