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
    public partial class Tableau : Form
    {
        public Tableau()
        {
            InitializeComponent();
        }
        private void Design()
        {
            Tableau.ActiveForm.Text = "Hello";
            buttonStop.BackColor = Color.Red;
            buttonStart.BackColor = Color.Green;
        }
    }
}
