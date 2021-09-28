using System.Windows.Forms;
using TransitionsLibrary.Models;
using static TransitionsLibrary.Models.ValueTransition;
using static TransitionsLibrary.Models.Functions.Easings;
using TransitionsLibrary.Models.Functions;

namespace TransitionsTest
{
    public partial class MainForm : Form
    {
        private ValueTransition SlideTransition;
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
                Invoke(new OnValueChangedDelegate(OnValueChanged), new object[] { value, control });
            }
            else
            {
                control.Left = (int)value;
            }
        }

        private void StartTransition(MouseEventArgs e)
        {
            if (SlideTransition != null && SlideTransition.IsActive) return;

            if (CurrentObject != null && CurrentFuntion != null)
            {
                SlideTransition = new ValueTransition
                (
                    startValue: CurrentObject.Location.X,  
                    endValue: e.X, 
                    duration: 1300, 
                    onValueChanged: OnValueChanged,
                    easingFunction: CurrentFuntion,
                    targetControl: CurrentObject,
                    fps: 60
                );
                SlideTransition.Start(); 
            }
        }

        private void QuadrPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = QuadrObject;
            CurrentFuntion = Easings.Quadratic.InOut;
            StartTransition(e);
        }

        private void ElasticPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ElasticObject;
            CurrentFuntion = Easings.Elastic.InOut;
            StartTransition(e);
        }

        private void BouncePanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BounceObject;
            CurrentFuntion = Easings.Bounce.InOut;
            StartTransition(e);
        }

        private void ExpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = ExpObject;
            CurrentFuntion = Easings.Exponential.InOut;
            StartTransition(e);
        }

        private void SinPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = SinObject;
            CurrentFuntion = Easings.Sinusoidal.InOut;
            StartTransition(e);
        }

        private void CircularPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = CircularObject;
            CurrentFuntion = Easings.Circular.InOut;
            StartTransition(e);
        }

        private void BackPanel_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentObject = BackObject;
            CurrentFuntion = Easings.Back.InOut;
            StartTransition(e);
        }
    }
}
