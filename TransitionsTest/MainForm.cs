using System.Windows.Forms;
using TransitionsLibrary;
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
                BackPanel.Location = new System.Drawing.Point(CurrentObject.Location.X, (int)value);
            }
        }

        private void StartAnimation(MouseEventArgs e)
        {
            if (SlideAnimation != null && SlideAnimation.IsActive) return;

            if (CurrentObject != null && CurrentFuntion != null)
            {
                var slideTransitionX = new Transition
                (
                    startValue: 0,  // px
                    endValue: 1000, // px
                    duration: 1300, // ms
                    onValueChanged: OnValueChanged,
                    easingFunction: Elastic.InOut,
                    fps: 60
                );
                slideTransitionX.Animate();
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
