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
    public partial class AlarmDataView : Form
    {
        List<string> hours = new List<string>();
        List<string> minutes = new List<string>();
        public AlarmDataView()
        {
            InitializeComponent();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AlaramDataView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                hours.Add(i.ToString().PadLeft(2, '0'));
            }
            for (int i = 0; i < 60; i++)
            {
                minutes.Add(i.ToString().PadLeft(2, '0'));
            }
            int hourIndex = 1;
            int minuteIndex = 1;

            label1.Text = "---";
            label2.Text = hours.ToArray()[0];
            label3.Text = hours.ToArray()[1];

            label4.Text = "---";
            label5.Text = minutes.ToArray()[0];
            label6.Text = minutes.ToArray()[1];

            guna2Panel1.MouseWheel += (senderm1, argsm1) =>
            {
                switch (argsm1.Delta)
                {
                    case 120:
                        {
                            if (hourIndex > 0)
                            {
                                label2.Text = hours.ToArray()[--hourIndex];
                                label3.Text = hours.ToArray()[hourIndex + 1];
                                if (hourIndex - 1 < 0)
                                {
                                    label1.Text = "---";
                                }
                                else
                                {
                                    label1.Text = hours.ToArray()[hourIndex - 1];
                                }
                            }
                            break;
                        }
                    case -120:
                        {
                            if (!(hourIndex > 22))
                            {
                                label2.Text = hours.ToArray()[++hourIndex];
                                label1.Text = hours.ToArray()[hourIndex - 1];
                                if (hourIndex + 1 > 22)
                                {
                                    label3.Text = "---";
                                }
                                else
                                {
                                    label3.Text = hours.ToArray()[hourIndex + 1];
                                }
                            }
                            break;
                        }
                }

            };
            guna2Panel2.MouseWheel += (senderm1, argsm1) =>
            {
                switch (argsm1.Delta)
                {
                    case 120:
                        {
                            if (minuteIndex > 0)
                            {
                                label5.Text = minutes.ToArray()[--minuteIndex];
                                label6.Text = minutes.ToArray()[minuteIndex + 1];
                                if (minuteIndex - 1 < 0)
                                {
                                    label4.Text = "---";
                                }
                                else
                                {
                                    label4.Text = minutes.ToArray()[minuteIndex - 1];
                                }
                            }
                            break;
                        }
                    case -120:
                        {
                            if (!(minuteIndex > 58))
                            {
                                label5.Text = minutes.ToArray()[++minuteIndex];
                                label4.Text = minutes.ToArray()[minuteIndex - 1];
                                if (minuteIndex + 1 > 58)
                                {
                                    label6.Text = "---";
                                }
                                else
                                {
                                    label6.Text = minutes.ToArray()[minuteIndex + 1];
                                }
                            }
                            break;
                        }
                }

            };
        }

        private string alaramdays = string.Empty;

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton1.Tag)))
            {
                AddDay(guna2CircleButton1.Text);
                guna2CircleButton1.FillColor = Color.FromArgb(30,30,30);
                guna2CircleButton1.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton1.Text);
                guna2CircleButton1.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton1.Tag = false;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton2.Tag)))
            {
                AddDay(guna2CircleButton2.Text);
                guna2CircleButton2.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton2.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton2.Text);
                guna2CircleButton2.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton2.Tag = false;
            }
        }
   
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton3.Tag)))
            {
                AddDay(guna2CircleButton3.Text);
                guna2CircleButton3.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton3.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton3.Text);
                guna2CircleButton3.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton3.Tag = false;
            }
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton4.Tag)))
            {
                AddDay(guna2CircleButton4.Text);
                guna2CircleButton4.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton4.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton4.Text);
                guna2CircleButton4.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton4.Tag = false;
            }
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton5.Tag)))
            {
                AddDay(guna2CircleButton5.Text);
                guna2CircleButton5.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton5.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton5.Text);
                guna2CircleButton5.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton5.Tag = false;
            }
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton6.Tag)))
            {
                AddDay(guna2CircleButton6.Text);
                guna2CircleButton6.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton6.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton6.Text);
                guna2CircleButton6.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton6.Tag = false;
            }
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            if (!(Convert.ToBoolean(guna2CircleButton7.Tag)))
            {
                AddDay(guna2CircleButton7.Text);
                guna2CircleButton7.FillColor = Color.FromArgb(30, 30, 30);
                guna2CircleButton7.Tag = true;
            }
            else
            {
                RemoveDay(guna2CircleButton7.Text);
                guna2CircleButton7.FillColor = Color.FromArgb(38, 38, 38);
                guna2CircleButton7.Tag = false;
            }
        }

        private void AddDay(string day)
        {
            alaramdays += day + " ";
        }
  
        private void RemoveDay(string day)
        {
            alaramdays = alaramdays.Replace(day + " ", string.Empty);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (alaramdays != string.Empty)
            {
                Program.form.NewAlaramData(label2.Text + ":" + label5.Text, alaramdays, guna2TextBox1.Text, true, null, false);
                this.Close();
            }
        }
    }
}
