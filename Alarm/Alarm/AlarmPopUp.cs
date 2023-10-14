using Alarm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class AlarmPopUp : Form
    {
        public string time { get; set; }
        public string label { get; set; }
        private SoundPlayer soundPlayer;
        public AlarmPopUp()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(Resources.wakeup_alarm_tone_21497);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Close();
        }

        private void AlarmPopUp_Load(object sender, EventArgs e)
        {
            label8.Text = time;
            guna2TextBox1.Text = label;
            soundPlayer.PlayLooping();
        }
    }
}
