using System;
using System.Drawing;
using System.Windows.Forms;
using TransitionsLibrary.Models.TransitionTypes;
using static TransitionsLibrary.Models.Functions.Easings;
using static TransitionsLibrary.Models.TransitionTypes.ColorTransition;

namespace ColorTransitionExample
{
    public partial class MainForm : Form
    {
        ColorTransition Transition;
        public MainForm()
        {
            InitializeComponent();

            Transition = new ColorTransition
            (
                startValue: Color.Red,
                endValue: Color.Blue,
                duration: 1000,
                onValueChanged: OnColorChanged,
                easingFunction: Cubic.InOut,
                fps: 60
            );
            Transition.Loop = true;
            Transition.ReverseOnLooping = true;
        }

        private void OnColorChanged(Color color)
        {
            if(InvokeRequired)
            {
                Invoke(new OnValueChangedDelegate(OnColorChanged), new object[] { color });
            }
            else
            {
                ColorPanel.BackColor = color;
            }
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            Transition.Start();
        }
    }
}
