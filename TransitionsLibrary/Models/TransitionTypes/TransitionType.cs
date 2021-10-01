using System;
using System.Threading;
using static TransitionsLibrary.Models.Functions.Easings;

namespace TransitionsLibrary.Models.TransitionTypes
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class TransitionType
    {
        protected bool _IsActive = false;
        public bool IsActive
        {
            get => _IsActive;
            protected set
            {
                _IsActive = value;
            }
        }
        protected Thread TransitionThread;
        public Action OnTransitionStart { get; set; }
        public Action OnTransitionEnd { get; set; }
        protected EasingFunction Function;
        public int Duration { get; private protected set; }
        public int FPS { get; set; }
        public int StartDelay { get; private protected set; }
        private bool _IsComplete = false;
        public bool IsComplete 
        { 
            get => _IsComplete;
            protected set => _IsComplete = value; 
        }

        public bool Loop { get; set; } = false;
        public bool ReverseOnLooping { get; set; } = false;

        protected TransitionType(EasingFunction function, int duration, int fps, int startDelay, bool loop = false, bool reverseOnLooping = false)
        {
            if (fps < 1)
                throw new ArgumentException("FPS must be greater than 0!");
            if (duration < 1)
                throw new ArgumentException("Duration must be greater than 0!");

            Function = function;
            FPS = fps;
            StartDelay = startDelay;
            Duration = duration;
            TransitionThread = new Thread(StartTransition);
            Loop = loop;
            ReverseOnLooping = reverseOnLooping;
        }

        public abstract void Start();

        public abstract void Stop();

        protected abstract void StartTransition();

        protected virtual void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
