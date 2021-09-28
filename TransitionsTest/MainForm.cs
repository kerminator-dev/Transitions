using System.Windows.Forms;
using TransitionsLibrary.Models.Functions;
using static TransitionsLibrary.Models.Functions.Easings;
using TransitionsLibrary.Models;
using static TransitionsLibrary.Models.ValueTransition;

namespace TransitionsTest
{
    public partial class MainForm : Form
    {
        private ValueTransition SlideAnimation;
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

        private void OnValueChanged(float value, Control control)
        {
            if (InvokeRequired)
            {
                Invoke(new OnValueChangedDelegate(OnValueChanged), new object[] { value });
            }
            else
            {
                control.Location = new System.Drawing.Point(control.Location.X, (int)value);
            }
        }

        private void StartAnimation(MouseEventArgs e)
        {
            if (SlideAnimation != null && SlideAnimation.IsActive) return;

            if (CurrentObject != null && CurrentFuntion != null)
            {
                var slideTransitionX = new ValueTransition
                (
                    startValue: 0,  // px
                    endValue: 1000, // px
                    duration: 1300, // ms
                    onValueChanged: OnValueChanged,
                    easingFunction: Elastic.InOut,
                    targetControl: CurrentObject,
                    fps: 60
                );
                slideTransitionX.Start();
            }
        }

        private void QuadrPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = QuadrObject;
            CurrentFuntion = Easings.Quadratic.InOut;
            StartAnimation(e);
        }

        private void ElasticPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ElasticObject;
            CurrentFuntion = Easings.Elastic.InOut;
            StartAnimation(e);
        }

        private void BouncePanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BounceObject;
            CurrentFuntion = Easings.Bounce.InOut;
            StartAnimation(e);
        }

        private void ExpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ExpObject;
            CurrentFuntion = Easings.Exponential.InOut;
            StartAnimation(e);
        }

        private void SinPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = SinObject;
            CurrentFuntion = Easings.Sinusoidal.InOut;
            StartAnimation(e);
        }

        private void CircularPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = CircularObject;
            CurrentFuntion = Easings.Circular.InOut;
            StartAnimation(e);
        }

        private void BackPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BackObject;
            CurrentFuntion = Easings.Back.InOut;
            StartAnimation(e);
        }
    }
}
