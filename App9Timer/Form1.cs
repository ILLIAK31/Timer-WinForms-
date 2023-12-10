using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTimer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App9Timer
{
    public partial class Form1 : Form
    {
        private CustomTimer customTimer;
        public Form1()
        {
            InitializeComponent();
            //if (IntervalValue.Text == "")
            //{
                //customTimer = new CustomTimer(1000);
                //customTimer.TimeElapsed += CustomTimer_TimeElapsed;
                //customTimer.OnError += CustomTimer_OnError;
            //}
            //else
            //{
            //    MessageBox.Show("Error with data");
            //}
        }
        private void CustomTimer_TimeElapsed()
        {
            UpdateListBox("Time elapsed");
        }
        private void CustomTimer_OnError(Exception ex)
        {
            UpdateListBox($"Error: {ex.Message}");
        }
        private void UpdateListBox(string message)
        {
            listBox1.Items.Add(message);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (IntervalValue.Text == "" || TimeValue.Text != "")
            {
                customTimer = new CustomTimer(int.Parse(IntervalValue.Text));
                customTimer.TimeElapsed += CustomTimer_TimeElapsed;
                customTimer.OnError += CustomTimer_OnError;
                customTimer.Start(int.Parse(TimeValue.Text));
                UpdateListBox("Timer started");
            }
            else
            {
                MessageBox.Show("Error with data");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            customTimer.Stop();
            UpdateListBox("Timer stopped");
        }
    }
}
