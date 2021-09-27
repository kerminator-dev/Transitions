using System;
using System.Threading;
using static TransitionsLibrary.Functions.Easing;

namespace TransitionsLibrary
{
    public class Transition
    {
        private bool _IsActive = false;
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            private set
            {
                _IsActive = value;

                if (value)
                {
                    if (OnAnimationEnd != null) OnAnimationEnd();
                }
                else
                {
                    if (OnAnimationStart != null) OnAnimationStart();
                }
            }
        }
        private float _Value = 0;
        public float Value
        {
            get => _Value;
            private set
            {
                _Value = value;
                OnValueChanged.Invoke(_Value);
            }
        }
        private Thread AnimationThread;
        public delegate void OnValueChangedDelegate(float Value);
        public Action OnAnimationStart;
        public OnValueChangedDelegate OnValueChanged;
        public Action OnAnimationEnd;
        private EasingFunction Function;

        public int StartValue { get; }
        public int EndValue { get; }
        public int Duration { get; }
        public int FPS { get; set; }

        public Transition(int startValue, int endValue, int duration, OnValueChangedDelegate onValueChanged, EasingFunction easingFunction, int fps)
        {
            StartValue = startValue;
            EndValue = endValue;
            Duration = duration;
            OnValueChanged = onValueChanged;
            Function = easingFunction;
            FPS = fps;
        }

        public void Animate()
        {
            if (!IsActive)
            {
                AnimationThread = new Thread(Start);
                AnimationThread.Start();
            }
        }
        private void Start()
        {
            try
            {
                int difference = (EndValue - StartValue);
                int framesCount = (int)((double)Duration / 1000 * FPS);
                if (framesCount <= 0)
                    framesCount = 1;
                float offset = 1f / framesCount;
                int delay = Duration / framesCount;

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
            }
            catch (ObjectDisposedException) { }
        }
    }
}
