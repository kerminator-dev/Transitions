using System;
using System.Threading;
using System.Windows.Forms;
using static TransitionsLibrary.Models.Functions.Easings;

namespace TransitionsLibrary.Models
{
    /// <summary>
    /// Universal transition type
    /// Used to change one property of an object
    /// </summary>
    public class ValueTransition : Transition
    {
        public new float Value
        {
            get => _Value;
            private set
            {
                _Value = value;
                OnValueChanged.Invoke(_Value, TargetControl);
            }
        }
        public delegate void OnValueChangedDelegate(float Value, Control control);
        public OnValueChangedDelegate OnValueChanged;

        public int StartValue { get; }
        public int EndValue { get; }

        public Control TargetControl { get; }

        public ValueTransition(int startValue, int endValue, int duration, OnValueChangedDelegate onValueChanged, EasingFunction easingFunction, Control targetControl, int fps = 40, int startDelay = 0)
        : base(easingFunction, duration, fps, startDelay)
        {
            StartValue = startValue;
            EndValue = endValue;
            OnValueChanged = onValueChanged;
            TargetControl = targetControl;
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
                int difference = (EndValue - StartValue);
                int framesCount = (int)((double)Duration / 1000 * FPS);
                if (framesCount <= 0)
                    framesCount = 1;
                float offset = 1f / framesCount;
                int delay = Duration / framesCount;
                Thread.Sleep(StartDelay);

                if (OnTransitionStart != null) OnTransitionStart();
                IsComplete = false;
                IsActive = true;
                
                Value = StartValue;
                if (difference > 0)
                {
                    for (float i = 0f; i < 1f; i += offset, Thread.Sleep(delay))
                    {
                        Value = (int)(StartValue + Function(i) * difference);
                    }
                }
                else
                {
                    for (float i = 1f; i > 0f; i -= offset, Thread.Sleep(delay))
                    {
                        Value = (int)(EndValue + Function(i) * ((-1) * difference));
                    }
                }
                Value = EndValue;

                IsActive = false;
                IsComplete = true;
                if (OnTransitionEnd != null) 
                    OnTransitionEnd();
            }
            catch (ObjectDisposedException) { }
        }
    }
}
