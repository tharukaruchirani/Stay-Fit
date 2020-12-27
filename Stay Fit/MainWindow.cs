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
            timer = new System.Timers.Timer(5*60*1000);
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


            if(time.Equals("07.55 AM")) // "07:55 AM"
            {

                if(dateNumber%3 == 0)
                {
                    ShowMessage(Properties.Resources.Set11);
                } else if(dateNumber%3 == 1)
                {
                    ShowMessage(Properties.Resources.Set21);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set31);
                }

            } else if (time.Equals("08:30 AM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set12);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set22);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set32);
                }

            } else if (time.Equals("10:00 AM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set13);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set23);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set33);
                }

            } else if (time.Equals("11:30 AM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set14);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set24);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set34);
                }

            } else if (time.Equals("01:00 PM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set15);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set25);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set35);
                }
            } else if (time.Equals("02:30 PM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set16);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set26);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set36);
                }
            } else if (time.Equals("03:30 PM")) 
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set17);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set27);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set37);
                }
            } else if (time.Equals("05:30 PM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set18);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set28);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set38);
                }
            } else if (time.Equals("08:00 PM"))
            {
                if (dateNumber % 3 == 0)
                {
                    ShowMessage(Properties.Resources.Set19);
                }
                else if (dateNumber % 3 == 1)
                {
                    ShowMessage(Properties.Resources.Set29);
                }
                else if (dateNumber % 3 == 2)
                {
                    ShowMessage(Properties.Resources.Set39);
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
    }
}
