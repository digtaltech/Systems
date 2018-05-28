using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class system : Form
    {
        public system()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime voteTime = new DateTime(2018, 2, 20, 0, 0, 0);

            TimeSpan TimeRemaining = voteTime - DateTime.Now;

            label1.Text = "До начала гонки осталось " + TimeRemaining.Days + " дня " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд";
        }
    }
}
