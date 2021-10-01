using System;
using System.Threading;
using System.Windows.Forms;
using static TransitionsLibrary.Models.Functions.Easings;

namespace TransitionsLibrary.Models.TransitionTypes
{
    public class ValueTransition : TransitionType
    {
        private float _Value;
        public float Value
        {
            get => _Value;
            private set
            {
                _Value = value;
                OnValueChanged.Invoke(_Value);
            }
        }

        public delegate void OnValueChangedDelegate(float value);
        public OnValueChangedDelegate OnValueChanged;

        public int StartValue { get; protected set; }
        public int EndValue { get; protected set; }

        public ValueTransition(int startValue, int endValue, int duration, OnValueChangedDelegate onValueChanged, EasingFunction easingFunction, int fps = 40, int startDelay = 0)
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
                int startValue = StartValue;
                int endValue = EndValue;
                OnTransitionStart?.Invoke();
                do
                {
                    int difference = (endValue - startValue);
                    int framesCount = (int)((double)Duration / 1000 * FPS);
                    if (framesCount <= 0)
                        framesCount = 1;
                    float offset = 1f / framesCount;
                    int delay = Duration / framesCount;
                    Thread.Sleep(StartDelay);

                    // Start
                    IsComplete = false;
                    IsActive = true;

                    Value = startValue;
                    if (difference > 0)
                    {
                        for (float i = 0f; i < 1f; i += offset, Thread.Sleep(delay))
                        {
                            Value = (int)(startValue + Function(i) * difference);
                        }
                    }
                    else
                    {
                        for (float i = 1f; i > 0f; i -= offset, Thread.Sleep(delay))
                        {
                            Value = (int)(endValue + Function(i) * ((-1) * difference));
                        }
                    }
                    Value = endValue;

                    if (ReverseOnLooping)
                    {
                        var temp = startValue;
                        startValue = endValue;
                        endValue = temp;
                    }
                } 
                while (Loop);
                IsActive = false;
                IsComplete = true;
                OnTransitionEnd?.Invoke();
            }
            catch (ObjectDisposedException) { }
        }
    }
}
