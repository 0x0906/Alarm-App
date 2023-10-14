using Alarm.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public class AlarmDataSet
        {
            public string Time { get; set; }
            public string Repeat { get; set; }
            public string Label { get; set; }
            public bool Mode { get; set; }
        }
       
        public List<AlarmDataSet> alarmDataSets = new List<AlarmDataSet>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location));
            if(processes.Length > 1)
            {
                Environment.Exit(0);
            
            }

            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json");
                alarmDataSets = JsonConvert.DeserializeObject<List<AlarmDataSet>>(json);
                foreach(AlarmDataSet alarmDataSet in alarmDataSets)
                {
                    NewAlaramData(alarmDataSet.Time,
                        alarmDataSet.Repeat,
                        alarmDataSet.Label,
                        alarmDataSet.Mode,
                        alarmDataSet,
                        true);
                }
            }

            Task.Run(() =>
            {
                CheckForAlarm();
            });

            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Show", (a, b) => { this.Show(); notifyIcon1.Visible = false; });
            contextMenu.MenuItems.Add("Exit", (a, b) => { UpdateJson(); notifyIcon1.Visible = false; Environment.Exit(0); });

            notifyIcon1.ContextMenu = contextMenu;

            notifyIcon1.DoubleClick += (a, b) => { this.Show(); notifyIcon1.Visible = false; };
        }

        int alaramsCount = 0;
        bool nwidthChanged = false;
        bool dwidthChanged = false;
        public void NewAlaramData(string time, string repeat, string label, bool mode, AlarmDataSet alarmDataSet, bool alreadyExists)
        {
            ListItem listItem = new ListItem();
            listItem.time_label.Text = time;
            listItem.repeat_lablel.Text = repeat;
            listItem.alaram_switch_toggle.Checked = mode;
            listItem.Width = (nwidthChanged) ? flowLayoutPanel1.Width - 25 : flowLayoutPanel1.Width - 5;
            listItem.Location = new Point(0, listItem.Height * alaramsCount);

            if (!alreadyExists)
            {
                alarmDataSet = new AlarmDataSet()
                {
                    Time = time,
                    Repeat = repeat,
                    Label = label,
                    Mode = mode
                };
                alarmDataSets.Add(alarmDataSet);
            }

            listItem.Tag = alarmDataSet;

            flowLayoutPanel1.Controls.Add(listItem);
           
            if (flowLayoutPanel1.Controls.Count > 4 && !nwidthChanged)
            {
                flowLayoutPanel1.AutoScroll = true;
                for (int c = 0; c < flowLayoutPanel1.Controls.Count; c++)
                {
                    flowLayoutPanel1.Controls[c].Width = flowLayoutPanel1.Controls[c].Width - 20;
                }
                nwidthChanged = true;
                dwidthChanged = false;
            }
            alaramsCount += 1;
        }
     
        public void ChangeModeAlaramData(ListItem listItem, bool mode)
        {
            alarmDataSets.Remove(listItem.Tag as AlarmDataSet);
            AlarmDataSet alarmDataSet = (AlarmDataSet)listItem.Tag;
            alarmDataSet.Mode = mode;
            alarmDataSets.Add(alarmDataSet);
        }

        public void RemoveAlaramData(ListItem listItem)
        {
            alarmDataSets.Remove(listItem.Tag as AlarmDataSet);
            flowLayoutPanel1.Controls.Remove(listItem);
            if (flowLayoutPanel1.Controls.Count <= 4 && !dwidthChanged)
            {
                for (int c = 0; c < flowLayoutPanel1.Controls.Count; c++)
                {
                    flowLayoutPanel1.Controls[c].Width = flowLayoutPanel1.Controls[c].Width + 20;
                }
                flowLayoutPanel1.AutoScroll = false;
                dwidthChanged = true;
                nwidthChanged = false;
            }
            alaramsCount -= 1;
        }
      
        public void UpdateJson()
        {
            string json = JsonConvert.SerializeObject(alarmDataSets);
            File.WriteAllText("data.json", json);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AlarmDataView alaramDataView = new AlarmDataView();
            alaramDataView.ShowDialog();
        }

        bool isPopuped = false;
        string oldTime = string.Empty;
        public void CheckForAlarm()
        {
            while (true)
            {
                string time = DateTime.Now.ToString("HH:mm");
                string day = DateTime.Now.ToString("ddd");
                foreach (AlarmDataSet alarmDataSet in alarmDataSets)
                {
                    if (alarmDataSet.Time == time &&
                        alarmDataSet.Repeat.Contains(day) &&
                        alarmDataSet.Mode
                        && !isPopuped)
                    {
                        isPopuped = true;
                        oldTime = time;
                        AlarmPopUp popUp = new AlarmPopUp();
                        popUp.time = alarmDataSet.Time;
                        popUp.label = alarmDataSet.Label;
                        popUp.ShowDialog();
                    }
                }
                if(oldTime != time)
                {
                    isPopuped = false;
                }
                Thread.Sleep(800);
            }
        }

    }
}
