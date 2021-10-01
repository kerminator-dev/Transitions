using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TransitionsLibrary.Models.TransitionTypes;

namespace TransitionsLibrary.Models
{
    public class TransitionManager
    {
        public List<TransitionType> Transitions { get; private set; }
        public int StartDelay { get; private set; }
        private Action _OnTransitionsEnds;
        public Action OnTransitionsEnds
        {
            get => _OnTransitionsEnds;
            set
            {
                _OnTransitionsEnds = value;

                for (int i = 0; i < Transitions.Count; i++)
                {
                    Transitions[i].OnTransitionEnd += OnSingleTransitionEnd;
                }
            }
        }

        public bool IsWorking
        {
            get
            {
                for (int i = 0; i < Transitions.Count; i++)
                {
                    if (Transitions[i].IsActive)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public TransitionManager(List<TransitionType> transitionsList, int startDelay = 0)
        {
            Transitions = new List<TransitionType>(transitionsList);
            StartDelay = startDelay;
        }

        public TransitionManager(int startDelay = 0)
        {
            StartDelay = startDelay;
            Transitions = new List<TransitionType>();
        }

        public void Start()
        {
            if (!IsWorking)
            {
                Thread.Sleep(StartDelay);

                for (int i = 0; i < Transitions.Count; i++)
                {
                    Transitions[i].Start();
                }
            }
        }

        private void OnSingleTransitionEnd()
        {
            if (OnTransitionsEnds != null)
            {
                if (Transitions.Where(i => i.IsComplete).Count() == Transitions.Count)
                {
                    OnTransitionsEnds();
                }
            }
        }
        
        public void Stop()
        {
            for (int i = 0; i < Transitions.Count; i++)
            {
                Transitions[i].Stop();
            }
        }
    }
}
