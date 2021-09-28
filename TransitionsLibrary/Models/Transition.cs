using System;
using System.Threading;
using static TransitionsLibrary.Models.Functions.Easings;

namespace TransitionsLibrary.Models
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Transition
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
        protected float _Value = 0;
        public float Value { get; private set; }
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

        protected Transition(EasingFunction function, int duration, int fps, int startDelay)
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
        }

        public abstract void Start();

        public abstract void Stop();

        protected abstract void StartTransition();
    }
}
