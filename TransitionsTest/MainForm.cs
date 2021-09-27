using TransitionsLibrary;
using TransitionsLibrary.Functions;
using System;
using System.Windows.Forms;
using static TransitionsLibrary.Transition;
using static TransitionsLibrary.Functions.Easing;

namespace TransitionsTest
{
    public partial class MainForm : Form
    {
        private Transition SlideAnimation;
        private Panel _CurrentObject;
        private Panel CurrentObject
        {
            get => _CurrentObject;
            set
            {
                _CurrentObject = value;
                LinePanel.BackColor = _CurrentObject.BackColor;
            }
        }
        
        private EasingFunction CurrentFuntion;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnValueChanged(float value)
        {
            if (InvokeRequired)
            {
                Invoke(new OnValueChangedDelegate(OnValueChanged), new object[] { value });
            }
            else
            {
                CurrentObject.Location = new System.Drawing.Point((int)value, CurrentObject.Location.Y);
                LocationXLabel.Text = "X: " + value;
            }
        }

        private void StartAnimation(MouseEventArgs e)
        {
            if (SlideAnimation != null && SlideAnimation.IsActive) return;

            if (CurrentObject != null && CurrentFuntion != null)
            {
                SlideAnimation = new Transition
                (
                    startValue: CurrentObject.Location.X,
                    endValue: e.X,
                    duration: Convert.ToInt32(DurationUpDown.Value),
                    onValueChanged: OnValueChanged,
                    easingFunction: CurrentFuntion,
                    fps: Convert.ToInt32(FpsUpDown.Value)
                );
                SlideAnimation.Animate();
            }
        }

        private void QuadrPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = QuadrObject;
            CurrentFuntion = Easing.Quadratic.InOut;
            StartAnimation(e);
        }

        private void ElasticPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ElasticObject;
            CurrentFuntion = Easing.Elastic.InOut;
            StartAnimation(e);
        }

        private void BouncePanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BounceObject;
            CurrentFuntion = Easing.Bounce.InOut;
            StartAnimation(e);
        }

        private void ExpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ExpObject;
            CurrentFuntion = Easing.Exponential.InOut;
            StartAnimation(e);
        }

        private void SinPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = SinObject;
            CurrentFuntion = Easing.Sinusoidal.InOut;
            StartAnimation(e);
        }

        private void CircularPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = CircularObject;
            CurrentFuntion = Easing.Circular.InOut;
            StartAnimation(e);
        }

        private void BackPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BackObject;
            CurrentFuntion = Easing.Back.InOut;
            StartAnimation(e);
        }
    }
}
