using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransitionsLibrary.Models;
using TransitionsLibrary.Models.TransitionTypes;
using static TransitionsLibrary.Models.Functions.Easings;
using static TransitionsLibrary.Models.TransitionTypes.ValueTransition;

namespace NotificationsTest
{
    public partial class NotificationForm : Form
    {
        private ControlValueTransition SlideTransition;
        private Timer KillTimer;
        public NotificationForm(int killInterval, int transitionTime, string title, string text)
        {
            InitializeComponent();
            InitializeTransition(transitionTime);

            TitleLabel.Text = title;
            DescriptionLabel.Text = text;

            KillTimer = new Timer();
            KillTimer.Interval = killInterval;
            KillTimer.Tick += KillTimer_Tick;
        }

        public NotificationForm(int killInterval = 7000)
        {
            InitializeComponent();
            InitializeTransition(1500);

            KillTimer = new Timer();
            KillTimer.Interval = killInterval;
            KillTimer.Tick += KillTimer_Tick;
        }

        private void InitializeTransition(int transitionTime)
        {
            Random random = new Random();
            this.Location = new Point
            (
                x: GetScreen().Width + this.Width * 2, // start Y location away from borders
                y: random.Next(20, GetScreen().Height - 140) // random start Y location
            );

            int endValue = GetScreen().Width - this.Width - 20;

            SlideTransition = new ControlValueTransition
            (
                startValue: Location.X,
                endValue: endValue,
                duration: 1500,
                onValueChanged: OnValueChanged,
                easingFunction: Elastic.InOut,
                targetControl: this,
                fps: 60
            );
        }

        private void OnValueChanged(float value, Control control)
        {
            if (InvokeRequired)
            {
                Invoke(new ControlValueTransition.OnValueChangedDelegate(OnValueChanged), new object[] { value, control });
            }
            else
            {
                control.Location = new Point((int)value, Location.Y);
            }
        }

        public new void Show()
        {
            base.Show();
            KillTimer.Start();
            SlideTransition.Start();
        }

        private void KillTimer_Tick(object sender, EventArgs e)
        {
            KillTimer.Dispose();
            Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }
    }
}
