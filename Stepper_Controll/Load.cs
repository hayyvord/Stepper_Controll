using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepper_Controll
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            prBarLoad.Increment(1);
            if (prBarLoad.Value == 100) Timer.Stop();
        }
    }
}
