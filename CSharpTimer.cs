using System.DirectoryServices.ActiveDirectory;
using System.Timers;

namespace CSharpTimer
{
    public partial class CSharpTimer : Form
    {
        public CSharpTimer()
        {
            InitializeComponent();
        }

        System.Timers.Timer Timer;
        int minute,
            second,
            hour;

        private void CSharpTimer_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;
            Timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Invoke(
                new Action(() =>
                {
                    second = second + 1;
                    if (second == 60)
                    {
                        minute = minute + 1;
                        second = 0;
                    }
                    if (minute == 60)
                    {
                        hour = hour + 1;
                        minute = 0;
                        second = 0;
                    }
                    LblTimer.Text = "Time: " + hour + ":" + minute + ":" + second;
                })
            );
        }
    }
}
