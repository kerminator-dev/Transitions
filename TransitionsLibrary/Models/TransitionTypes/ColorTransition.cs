using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TransitionsLibrary.Models.Functions.Easings;

namespace TransitionsLibrary.Models.TransitionTypes
{
    public class ColorTransition : TransitionType
    {
        private Color _Value;
        public Color Value
        {
            get => _Value;
            private set
            {
                _Value = value;
                OnValueChanged.Invoke(_Value);
            }
        }

        public delegate void OnValueChangedDelegate(Color value);
        public OnValueChangedDelegate OnValueChanged;

        public Color StartValue { get; protected set; }
        public Color EndValue { get; protected set; }

        public ColorTransition
        (Color startValue, Color endValue, int duration, OnValueChangedDelegate onValueChanged, EasingFunction easingFunction, int fps = 40, int startDelay = 0)
        : base(easingFunction, duration, fps, startDelay)
        {
            StartValue = startValue;
            EndValue = endValue;
            OnValueChanged = onValueChanged;
        }

        public override void Start()
        {
            if (!IsActive)
            {
                TransitionThread = new Thread(StartTransition);
                TransitionThread.Start();
            }
        }

        public override void Stop()
        {
            if (TransitionThread != null)
                TransitionThread.Abort();
        }

        protected override void StartTransition()
        {
            try
            {
                Color startValue = StartValue;
                Color endValue = EndValue;
                OnTransitionStart?.Invoke();
                do
                { 
                    int differenceR = (endValue.R - startValue.R);
                    int differenceG = (endValue.G - startValue.G);
                    int differenceB = (endValue.B - startValue.B);
                    int framesCount = (int)((double)Duration / 1000 * FPS);
                    if (framesCount <= 0)
                        framesCount = 1;
                    float offset = 1f / framesCount;
                    int delay = Duration / framesCount;
                    Thread.Sleep(StartDelay);

                    // Start
                    IsComplete = false;
                    IsActive = true;
                    float value;
                    byte r, g, b;

                    Value = StartValue;

                    for (float i = 0f; i < 1f; i += offset, Thread.Sleep(delay))
                    {
                        value = Function(i);
                        r = (byte)(startValue.R + value * differenceR);
                        g = (byte)(startValue.G + value * differenceG);
                        b = (byte)(startValue.B + value * differenceB);
                        Value = Normilize(r, g, b);
                    }

                    Value = EndValue;

                    if (ReverseOnLooping)
                    {
                        var temp = startValue;
                        startValue = endValue;
                        endValue = temp;
                    }
                } while (Loop);

                IsActive = false;
                IsComplete = true;
                OnTransitionEnd?.Invoke();
            }
            catch (ObjectDisposedException) { }
        }

        private Color Normilize(byte r, byte g, byte b)
        {
            if (r > 255)
            {
                r = 255;
            }
            if (g > 255)
            {
                g = 255;
            }
            if (b > 255)
            {
                b = 255;
            }

            if (r < 0)
            {
                r = 0;
            }
            if (g < 0)
            {
                g = 0;
            }
            if (b < 0)
            {
                b = 0;
            }
            return Color.FromArgb(r, g, b);
        }
    }
}
