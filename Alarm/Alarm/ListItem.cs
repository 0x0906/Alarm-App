using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Program.form.RemoveAlaramData(this);
        }

        private void alaram_switch_toggle_Click(object sender, EventArgs e)
        {
            Program.form.ChangeModeAlaramData(this, alaram_switch_toggle.Checked);
        }
    }
}
