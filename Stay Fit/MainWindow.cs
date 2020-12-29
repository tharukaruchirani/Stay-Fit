using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Stay_Fit
{
    public partial class MainWindow : Form
    {

        private static System.Timers.Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            SetTimer();
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            timer = new System.Timers.Timer(59*1000);
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

            String time = DateTime.Now.ToString("h:mm tt");

            DateTime start = DateTime.Parse("25-Dec-2020");
            DateTime dt = DateTime.Parse(DateTime.Today.ToString("d"));
            TimeSpan t = dt - start;
            int dateNumber =  (int)t.TotalDays;

            Console.WriteLine(time);
            Console.WriteLine(dateNumber);

            if (time.Equals("7:55 AM")) // "7:55 AM"
            {

                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set11);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set21);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set31);
                        break;
                }

            } else if (time.Equals("8:30 AM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set12);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set22);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set32);
                        break;
                }

            } else if (time.Equals("10:00 AM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set13);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set23);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set33);
                        break;
                }

            } else if (time.Equals("11:30 AM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set14);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set24);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set34);
                        break;
                }

            } else if (time.Equals("1:00 PM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set15);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set25);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set35);
                        break;
                }
            } else if (time.Equals("2:30 PM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set16);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set26);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set36);
                        break;
                }
            } else if (time.Equals("3:30 PM")) 
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set17);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set27);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set37);
                        break;
                }
            } else if (time.Equals("5:30 PM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set18);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set28);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set38);
                        break;
                }
            } else if (time.Equals("8:00 PM"))
            {
                switch (dateNumber % 3)
                {
                    case 0:
                        ShowMessage(Properties.Resources.Set19);
                        break;
                    case 1:
                        ShowMessage(Properties.Resources.Set29);
                        break;
                    case 2:
                        ShowMessage(Properties.Resources.Set39);
                        break;
                }
            }
        }

        private static void ShowMessage(Bitmap bmp)
        {
            AlertForm f = new AlertForm();
            f.SetImage(bmp);
            f.ShowDialog();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowMessage(Properties.Resources.Set39);
        }
    }
}
